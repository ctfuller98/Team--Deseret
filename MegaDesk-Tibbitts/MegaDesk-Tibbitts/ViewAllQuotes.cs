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
    public partial class ViewAllQuotes : Form
    {
        private List<DeskQuote> allQuotesJson;
        public ViewAllQuotes()
        {
            InitializeComponent();

            //read json file
            string json = File.ReadAllText("quotes.json");
            allQuotesJson = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
            PopulateDataTable();
        }

        private void PopulateDataTable()
        {
            foreach (DeskQuote quote in allQuotesJson)
            {
                var newRow = allQuotesTable.Rows.Add();
                allQuotesTable.Rows[newRow].Cells["name"].Value = quote.name;
                allQuotesTable.Rows[newRow].Cells["TimeStamp"].Value = quote.TimeStamp.ToString("MMM d, yyyy");
                allQuotesTable.Rows[newRow].Cells["totalCost"].Value = quote.totalCost.ToString();
                allQuotesTable.Rows[newRow].Cells["rush"].Value = quote.rush;
                allQuotesTable.Rows[newRow].Cells["width"].Value = quote.Desk.Width + " in";
                allQuotesTable.Rows[newRow].Cells["depth"].Value = quote.Desk.Depth + " in";
                allQuotesTable.Rows[newRow].Cells["numDrawers"].Value = quote.Desk.DrawerNumber;
                allQuotesTable.Rows[newRow].Cells["materialType"].Value = quote.Desk.Material;

            }

        }
        private void vqMainMenuBtn_Click(object sender, EventArgs e)
        {
            // Return to MainManu Form.
            MainMenu mainMenuReturn = (MainMenu)Tag;
            mainMenuReturn.Show();
            Close();
        }
    }
}
