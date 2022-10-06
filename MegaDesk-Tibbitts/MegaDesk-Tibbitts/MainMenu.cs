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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void mmAddBtn_Click(object sender, EventArgs e)
        {
            // Navigate to AddQuote Form.
            AddQuote addQuoteView = new AddQuote();
            addQuoteView.Tag = this;
            addQuoteView.Show(this);
            Hide();
        }

        private void mmViewBtn_Click(object sender, EventArgs e)
        {
            // Navigate to View Quotes Form.
            ViewAllQuotes viewQuoteView = new ViewAllQuotes();
            viewQuoteView.Tag = this;
            viewQuoteView.Show(this);
            Hide();
        }

        private void mmSearchBtn_Click(object sender, EventArgs e)
        {
            // Navigate to Search Quotes Form.
            SearchQuotes searchQuoteView = new SearchQuotes();
            searchQuoteView.Tag = this;
            searchQuoteView.Show(this);
            Hide();
        }

        private void mmExitBtn_Click(object sender, EventArgs e)
        {
            // Close the program.
            Close();
        }
    }
}
