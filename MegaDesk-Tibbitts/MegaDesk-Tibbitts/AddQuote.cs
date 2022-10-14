using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Tibbitts
{
    public partial class AddQuote : Form
    {

        // Declare variables.
        readonly ErrorProvider errorProvider1 = new ErrorProvider();
        private bool nonNumberEntered = false;
        public DeskQuote deskQuote = new DeskQuote();
        int widthConversion;

        public AddQuote()
        {
            InitializeComponent();
        }

        private void aqMainMenuBtn_Click(object sender, EventArgs e)
        {
            // Return to MainManu Form.
            MainMenu mainMenuReturn = (MainMenu)Tag;
            mainMenuReturn.Show();
            Close();
        }
        private void aqSubmitBtn_Click(object sender, EventArgs e)
        {
            deskQuote.name = aqFullNameTB.Text;
            deskQuote.Desk.Depth = Int32.Parse(aqDeskLengthTB.Text);
            deskQuote.Desk.DrawerNumber = Int32.Parse(aqNumDrawersCB.Text);
            deskQuote.rush = Int32.Parse(aqRushOptionsCB.Text);
            deskQuote.Desk.Width = widthConversion;
            // Enum assignment test (example from Bro Smith)
            //aqSurfMaterialCB.DataSource = Enum.GetNames(typeof(DesktopMaterial));
            deskQuote.Desk.Material = aqSurfMaterialCB.Text;
            //deskQuote.Desk.materialType = Int32.Parse(aqSurfMaterialCB.DataSource);

            

            var displayQuoteView = new DisplayQuote(deskQuote);
            displayQuoteView.Tag = this;
            displayQuoteView.Show(this);
            Hide();

            //saving quotes to file
            List<DeskQuote> allQuotes;

            try
            {
                var quotesJson = File.ReadAllText("quotes.json");
                allQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotesJson) ?? new List<DeskQuote>();
            }
            catch (Exception)
            {
                allQuotes = new List<DeskQuote>();
            }

            allQuotes.Add(deskQuote);
            var json = JsonConvert.SerializeObject(allQuotes);
            File.WriteAllText("quotes.json", json);
        }
        
        private void aqDeskWidthTB_Validating(object sender,
                System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;

            // Cancel the event and select the text to be corrected by the user.
            if (!validWidth(aqDeskWidthTB.Text, out errorMsg))
            {
                e.Cancel = true;
                aqDeskWidthTB.Select(0, aqDeskWidthTB.Text.Length);
            }

            // Set the ErrorProvider error with the text to display. 
            this.errorProvider1.SetError(aqDeskWidthTB, errorMsg);
        }

        private void aqDeskWidthTB_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(aqDeskWidthTB, "");
        }

        public bool validWidth(string width, out string errorMessage)
        {
            widthConversion = Int32.Parse(width);

            if (widthConversion >= Desk.MIN_WIDTH && widthConversion <= Desk.MAX_WIDTH)
            {
                errorMessage = "";
                aqDeskWidthTB.BackColor = System.Drawing.Color.White;
                //deskQuote.desk.width = widthConversion;
                return true;
            }
            else
            {
                errorMessage = "Desk must be between 24 and 96 inches in width.";
                aqDeskWidthTB.BackColor = System.Drawing.Color.LightYellow;
                return false;
            }
        }

        // Make sure user enters a number in width field as we go.
        private void aqDeskWidthTB_TextChanged(object sender, EventArgs e)
        {
            string widthValue = aqDeskWidthTB.Text;
            int number;
            bool success = int.TryParse(widthValue, out number);

            // Make sure the user entered a number.
            if (!success)
            {
                errorProvider1.SetError(aqDeskWidthTB, "Please enter a valid number between 24 and 96 (Example: 25, 68, 27)");
                aqDeskWidthTB.BackColor = System.Drawing.Color.LightYellow;
                return;
            }
            else
            {
                aqDeskWidthTB.BackColor = System.Drawing.Color.White;
                return;
            }
        }

        // Handle the KeyDown event to determine the type of character entered into the control.
        private void aqDeskDepthTB_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Initialize the flag to false.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }

                //If shift key was pressed, it's not a number.
                if (Control.ModifierKeys == Keys.Shift)
                {
                    nonNumberEntered = true;
                }

                /* Depth Verification
                string depthString = aqDeskLengthTB.Text;
                int depthValue = Int32.Parse(depthString);
                string errorMessage;

                if (depthValue >= Desk.MIN_DEPTH && depthValue <= Desk.MAX_DEPTH)
                {
                    errorMessage = "";
                    aqDeskLengthTB.BackColor = System.Drawing.Color.White;
                    //deskQuote.desk.width = widthConversion;
                    return;
                }
                else
                {
                    errorMessage = "Desk must be between 12 and 48 inches in depth.";
                    aqDeskLengthTB.BackColor = System.Drawing.Color.LightYellow;
                    return;
                } */
            }
        }

        private void aqDeskDepthTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            // Enum assignment test (example from Bro Smith)
            aqSurfMaterialCB.DataSource = Enum.GetNames(typeof(Desk.DeskMaterial));
        }
    }
}
