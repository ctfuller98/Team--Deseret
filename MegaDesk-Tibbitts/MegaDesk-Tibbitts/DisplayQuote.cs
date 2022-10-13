using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Math;

namespace MegaDesk_Tibbitts
{
    public partial class DisplayQuote : Form
    {   
        // Declare variables.
        private readonly DeskQuote _deskQuote; //= new DeskQuote();
        private readonly Desk desk; // = new Desk();


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
                dqQuoteNumDisplay.Text = DeskQuote.quoteNum.ToString();
                dqDateDisplay.Text = _deskQuote.TimeStamp.ToString("MMM d, yyyy");
                dqNameDisplay.Text = _deskQuote.name;
                dqWidthDisplay.Text = _deskQuote.Desk.Width + " inches";
                dqDepthDisplay.Text = _deskQuote.Desk.Depth + " inches";
                dqDrawersDisplay.Text = _deskQuote.Desk.DrawerNumber.ToString();
                dqMaterialDisplay.Text = _deskQuote.Desk.Material;
                dqRushDisplay.Text = _deskQuote.rush + " days";
                dqTotalDisplay.Text = "$" + _deskQuote.getTotal(desk);
                dqBaseCostDisplay.Text = "$200";
                dqLinearFeetCostDisplay.Text = "$" + _deskQuote.getLinearFeetCost();
                dqDrawersCostDisplay.Text = "$" + _deskQuote.getDrawerCost();
                dqMaterialCostDisplay.Text = "$" + _deskQuote.getMaterialCost();
                dqRushCostDisplay.Text = "$" + _deskQuote.getRushCost(_deskQuote.rush);
            } catch
            {
                Console.WriteLine("Error Loading Values Into Display Quote Screen.");
            }
        }
    }
}
