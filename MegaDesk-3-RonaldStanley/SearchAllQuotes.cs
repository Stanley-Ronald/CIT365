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

namespace MegaDesk_3_RonaldStanley
{
    public partial class SearchAllQuotes : Form
    {
        public SearchAllQuotes()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string[] quoteFile = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\Quotes.txt");
            string material;
            material = searchComboBox.Text;

            for (int i = 0; i < quoteFile.Length; i++)
            {
                if (quoteFile[i].Contains(material))
                {
                    searchQuoteOutcome.Text += quoteFile[i] + " ";
                }

            }



        }
            
            
             
    } 
}
    
