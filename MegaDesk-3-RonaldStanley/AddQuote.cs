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
    public partial class AddQuote : Form
    {

        string name;
        int width = 0;
        int depth = 0;
        int numberOfDrawers = 0;
        int price = 0;
        string material;
        int materialPrice = 0;
        string rushOrderOption;
        int rushCost = 0;
        string quotePrice;
        string[] line = new string[7];

        
       

        public AddQuote()
        {
            InitializeComponent();
        }

        private void displayQuoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                name = nameBox.Text;
                width = int.Parse(widthTextBox.Text);
                depth = int.Parse(heightTextBox.Text);
                numberOfDrawers = int.Parse(drawersBox.Text);
                material = materialsDropDownBox.Text;
                rushOrderOption = rushOrderDropDownBox.Text;

                switch (rushOrderOption)
                {
                    case "3 days":
                        rushCost = 60;
                        break;
                    case "5 days":
                        rushCost = 40;
                        break;
                    case "7 days":
                        rushCost = 30;
                        break;
                    default: MessageBox.Show("Nothing Selected.");
                        break;
                }

                switch (material)
                {
                    case "Oak":
                        materialPrice = 200;
                        break;
                    case "Laminate":
                        materialPrice = 100;
                        break;
                    case "Pine":
                        materialPrice = 50;
                        break;
                    case "Rosewood":
                        materialPrice = 300;
                        break;
                    case "Veneer":
                        materialPrice = 125;
                        break;
                    default: MessageBox.Show("No materials selected.");
                        break;
                }

                //calculate price 
                price = (200 + (width * depth) + (numberOfDrawers * 50) + rushCost + materialPrice);
                quotePrice = price.ToString();
                line[0] = nameBox.Text;
                line[1] = widthTextBox.Text;
                line[2] = heightTextBox.Text;
                line[3] = drawersBox.Text;
                line[4] = materialsDropDownBox.Text;
                line[5] = rushOrderDropDownBox.Text;
                line[6] = quotePrice;

                string csv = string.Format("{0},{1},{2},{3},{4},{5},{6}\n", line[0], line[1], line[2], line[3], line[4], line[5], line[6]);
                File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Quotes.txt", csv);



            }
            catch (Exception)
            {
                throw;
            }

            //Desk newDesk = new Desk();
            //{
            //    width = width;
            //    depth = depth;
            //    numberOfDrawers = numberOfDrawers;

            //}
        }

       
        private void widthTextBox_Validating(object sender, CancelEventArgs e)
        { 
            int w;
            if (int.TryParse(widthTextBox.Text, out w))
            {
                if (w > 96 || w< 24)
                {
                    widthTextBox.Text = "";
                    MessageBox.Show("Please enter a value between 24 and 96 inches!");
                    widthTextBox.Focus();
                }
            }
        }

        private void heightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int d;
            if (int.TryParse(heightTextBox.Text, out d))
            {
                if (d > 48 || d < 12)
                {
                    
                    MessageBox.Show("Please enter a value between 12 and 48 inches!");
                    heightTextBox.Focus();
                }
            }

        }
    }
}
