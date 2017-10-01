using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_RonaldStanley
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addNewQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuote = new AddQuote();
            addNewQuote.Show();
        }

        private void viewAllQuotesButton_Click(object sender, EventArgs e)
        {

        }

        private void searchAllQuotesButton_Click(object sender, EventArgs e)
        {
            SearchAllQuotes addNewSearch = new SearchAllQuotes();
            addNewSearch.Show();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
