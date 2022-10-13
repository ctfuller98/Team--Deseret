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
using DocumentFormat.OpenXml.Math;
using Newtonsoft.Json;

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
                dqWidthDisplay.Text = _deskQuote.Desk.width.ToString() + " inches";
                dqDepthDisplay.Text = _deskQuote.Desk.depth.ToString() + " inches";
                dqDrawersDisplay.Text = _deskQuote.Desk.numDrawers.ToString();
                dqMaterialDisplay.Text = _deskQuote.Desk.materialType.ToString();
                dqRushDisplay.Text = _deskQuote.rush.ToString() + " days";
                dqTotalDisplay.Text = "$" + _deskQuote.getTotal(desk).ToString();
                dqBaseCostDisplay.Text = "$200";
                dqLinearFeetCostDisplay.Text = "$" + _deskQuote.getLinearFeetCost().ToString();
                dqDrawersCostDisplay.Text = "$" + _deskQuote.getDrawerCost().ToString();
                dqMaterialCostDisplay.Text = "$" + _deskQuote.getMaterialCost();
                dqRushCostDisplay.Text = "$" + _deskQuote.getRushCost(_deskQuote.rush);
            } catch
            {
                Console.WriteLine("Error Loading Values Into Display Quote Screen.");
            }
        }
    }
}
