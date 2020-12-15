using System;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        Tip tip;
        public Form1()
        {
            InitializeComponent();
            tip = new Tip();

        }

        // Function to set the value of tip percentage
        private void Tippercenttxt_TextChanged(object sender, EventArgs e)
        {
            double value;
            if(double.TryParse(Tippercenttxt.Text, out value))
            {
                tip.set_tip_percentage(value);
            }
        }

        // Function to set the value of number of person
        private void noptxt_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(noptxt.Text, out value))
            {
                tip.set_no_of_person(value);
            }
        }

        // Function to set value of bill amount
        private void billtxt_TextChanged(object sender, EventArgs e)
        {
                double value;
                if (double.TryParse(billtxt.Text, out value))
                {
                    tip.set_bill(value);
                }
            
        }
        // Function is used to decrement the value of tip percentage by 1
        private void btntipdecrement_Click(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(Tippercenttxt.Text, out value))
            {
                if (value != 0)
                {
                    value--;
                }
            }
            else
            {
                value = 0;
            }
                
           Tippercenttxt.Text = Convert.ToString(value);
        }

        // Function is used to increment the value of tip percentage by 1
        private void btntipincrement_Click(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(Tippercenttxt.Text, out value))
            {
                value++;
            }
            else
            {
                value = 0;
            }
            Tippercenttxt.Text = Convert.ToString(value);
        }

        // Function is used to decrement the value of number of person by 1
        private void btnNOPdecrement_Click(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(noptxt.Text, out value))
            {
                if (value != 0)
                {
                    value--;
                }
            }
            else
            {
                value = 0;
            }
            noptxt.Text = Convert.ToString(value);
        }

        // Function is used to increment the value of number of person by 1
        private void btnNOPincrement_Click(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(noptxt.Text, out value))
            {
                value++;
            }
            else
            {
                value = 0;
            }
            noptxt.Text = Convert.ToString(value);
        }

        // Function for calculating tip per person and total per person
        private void btncalculate_Click(object sender, EventArgs e)
        {
            // If bill amount is not valid or empty
            if(billtxt.Text.Length == 0 || billtxt.Text=="0")
            {
                label7.Text = "Enter valid bill amount";
            }
            // If tip percent is not valid or empty
            if(Tippercenttxt.Text.Length == 0 || Tippercenttxt.Text=="0")
            {
                label8.Text = "Enter valid tip percentage(>0)";
            }
            // If no of person is not valid or empty
            if (noptxt.Text.Length == 0 || noptxt.Text == "0")
            {
                label9.Text = "Enter valid number of people(>0)";
            }
         
            double value = tip.calculate_tip();
            tiptxt.Text = Currency() + Convert.ToString(value);

            double value1 = tip.calculate_total();
            totaltxt.Text = Currency() + Convert.ToString(value1);
        }

        // Fucntion to clear all the fields
        private void btnClose_Click(object sender, EventArgs e)
        {
            billtxt.Text = "";
            Tippercenttxt.Text = "0";
            noptxt.Text = "0";
            tiptxt.Text = "";
            totaltxt.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }

        // Function to prevent user to enter any character in bill amount
        private void billtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.' && e.KeyChar.ToString() != "\b")
            {

                e.Handled = true;

            }
        }

        // Function to prevent user to enter any character in tip percent
        private void Tippercenttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar.ToString() != "\b" && e.KeyChar != '.') 
            {

                e.Handled = true;

            }
        }

        // Function to prevent user to enter any character in no of person
        private void noptxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar.ToString() != "\b")
            {

                e.Handled = true;

            }
        }

        private String Currency()
        {
            if (countryCB1.SelectedIndex == 0)
            {
                return "₹ ";
            }
            else if (countryCB1.SelectedIndex == 1)
            {
                return "$ ";
            }
            else if (countryCB1.SelectedIndex == 2)
            {
                return "£ ";
            
            }
            return "  ";
        }
    }
}
