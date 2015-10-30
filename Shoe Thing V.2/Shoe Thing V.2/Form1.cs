using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void solematerialBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String Value1 = solematerialBox.Text;
            if (Value1 == "Leather")
            {
                soleTextbox.Text = "50";
            }
            else if (Value1 == "Rubber")
            {
                soleTextbox.Text = "30";
            }
            else
            {
                soleTextbox.Text = "10";
            }

        }

        private void topmaterialBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Value2 = topmaterialBox.Text;
            if (Value2 == "Leather")
            {
                topTextbox.Text = "100";
            }
            else if (Value2 == "Canvas")
            {
                topTextbox.Text = "50";
            }
            else if (Value2 == "Fake Leather")
            {
                topTextbox.Text = "20";
            }
            else
            {
                topTextbox.Text = "5";
            }



        }

        private void liningBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Value3 = liningBox.Text;
            if (Value3 == "Swede")
            {
                liningTextBox.Text = "200";
            }
            else if (Value3 == "Brushed Swede")
            {
                liningTextBox.Text = "150";
            }
            else if (Value3 == "Polished Leather")
            {
                liningTextBox.Text = "100";
            }
            else
            {
                liningTextBox.Text = "25";
            }
        }

        private void colourBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Value4 = colourBox.Text;
            if (Value4 == "Black")
            {
                colourTextBox.Text = "0";
            }
            else if (Value4 == "Brown")
            {
                colourTextBox.Text = "0";
            }
            else if (Value4 == "Beige")
            {
                colourTextBox.Text = "50";
            }
            else if (Value4 == "White")
            {
                colourTextBox.Text = "100";
            }
            else
            {
                colourTextBox.Text = "125000000";
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int SoleVal = Int32.Parse(soleTextbox.Text);
            int TopVal = Int32.Parse(topTextbox.Text);
            int LiningVal = Int32.Parse(liningTextBox.Text);
            int ColourVal = Int32.Parse(colourTextBox.Text);

            int FinalVal = SoleVal + TopVal + LiningVal + ColourVal;

            String Num = FinalVal.ToString();
            String Num2 = "$" + Num;
            priceTextbox.Text = Num2.ToString();

        }

        private void priceTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void soleTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
