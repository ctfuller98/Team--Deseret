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
    public partial class ViewAllQuotes : Form
    {
        public List<DeskQuote> allQuotes;
        public ViewAllQuotes()
        {
            InitializeComponent();
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
