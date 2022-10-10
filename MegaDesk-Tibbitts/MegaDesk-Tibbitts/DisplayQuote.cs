using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Tibbitts
{
    public partial class DisplayQuote : Form
    {   
        // Declare variables.
        private readonly DeskQuote _deskQuote;
        private readonly Desk desk;


        public DisplayQuote(DeskQuote deskQuote)
        {
            _deskQuote = deskQuote;
            InitializeComponent();
        }

        private void dqMainMenuBtn_Click(object sender, EventArgs e)
        {
            // Return to MainManu Form.
            MainMenu mainMenuReturn = new MainMenu();
            mainMenuReturn.Tag = this;
            mainMenuReturn.Show(this);
            Hide();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            try
            {
                dqNameDisplay.Text = _deskQuote.name;
                dqWidthDisplay.Text = _deskQuote.Desk.width.ToString();
                dqDepthDisplay.Text = _deskQuote.Desk.depth.ToString();
                dqDrawersDisplay.Text = _deskQuote.Desk.numDrawers.ToString();
                dqMaterialDisplay.Text = _deskQuote.Desk.materialType.ToString();
                dqRushDisplay.Text = _deskQuote.rush.ToString();
                dqTotalDisplay.Text = "$" + _deskQuote.getTotal(desk).ToString();
            } catch
            {
                Console.WriteLine("Error Loading Values Into Display Quote Screen.");
            }
        }
    }
}
