using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4
{
    public partial class Form1 : Form
    {
        private double purchasePrice, downPayment, amountToFinance, interest, monthlyPayment;
        private int term;
        private const int months = 12;
        const string emptyTitle = "Input Left Empty", invalidData = "Invalid Data Entered", emptyMessage =
            "All inputs in this form are required.", invalidDouble = "This input value must be a valid decimal";
			
        public Form1()
        {
            InitializeComponent();
        }

        private void purchasePriceBox_TextChanged(object sender, EventArgs e)
        {
            purchasePriceBox.BackColor = Color.White;
        }

        private void downBox_TextChanged(object sender, EventArgs e)
        {
            downBox.BackColor = Color.White;
        }

        private void interestBox_TextChanged(object sender, EventArgs e)
        {
            interestBox.BackColor = Color.White;
        }

        private void termBox_TextChanged(object sender, EventArgs e)
        {
            termBox.BackColor = Color.White;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calBtn_Click(object sender, EventArgs e)
        {

            calculate_payment();
        }

        // Calculates the monthly payment for a fixed interest rate loan.
        // Displays the amount to finance and the monthly payment on the form.
        private void calculate_payment()
        {
            if (isNotEmpty() && isValid())
            {
                if (purchasePrice > downPayment)
                {
                    amountToFinance = purchasePrice - downPayment;
                }
                else 
                {
                    amountToFinance = 0;
                }

                interest = interest / 100 / months;
                monthlyPayment = interest * amountToFinance *
                    Math.Pow(1 + interest, term) / (Math.Pow(1 + interest, term) - 1);

                financeAmountBox.Text = amountToFinance.ToString("C");

                if (interest > 0)
                {
                    monthlyPaymentBox.Text = monthlyPayment.ToString("C");
                }
                else
                {
                    monthlyPayment = amountToFinance / term;
                    monthlyPaymentBox.Text = monthlyPayment.ToString("C");
                }
            }
        }
        // Validates user input 
        // Return true if the user enter valid numbers, false otherwise.
        private bool isValid()
        {
           
            if (!double.TryParse(purchasePriceBox.Text, out purchasePrice) || purchasePrice < 0)
            {
                MessageBox.Show(invalidDouble, invalidData);
                purchasePriceBox.BackColor = Color.Red;
                return false;
            }
            else if (!double.TryParse(downBox.Text, out downPayment) || downPayment < 0) {
                MessageBox.Show(invalidDouble, invalidData);
                downBox.BackColor = Color.Red;
                return false;
            }
            else if (!double.TryParse(interestBox.Text, out interest) || interest < 0)
            {
                MessageBox.Show(invalidDouble, invalidData);
                interestBox.BackColor = Color.Red;
                return false;
            }
            else if (!int.TryParse(termBox.Text, out term) || term <= 0)
            {
                MessageBox.Show("This input value must be a valid integral.", invalidData);
                termBox.BackColor = Color.Red;
                return false;
            }
            else
            {
                return true;
            }
        }
        // Checks if any of the inputs is empty.
        // Returns false if any input is empty, true otherwise.
        private bool isNotEmpty()
        {
            if (purchasePriceBox.Text == "")
            {
                MessageBox.Show(emptyMessage, emptyTitle);                
                purchasePriceBox.BackColor = Color.Red;
                return false;
            }
            else if (downBox.Text == "")
            {
                MessageBox.Show(emptyMessage, emptyTitle);
                downBox.BackColor = Color.Red;
                return false;
            }
            else if (interestBox.Text == "")
            {
                MessageBox.Show(emptyMessage, emptyTitle);
                interestBox.BackColor = Color.Red;
                return false;
            }
            else if (termBox.Text == "")
            {
                MessageBox.Show(emptyMessage, emptyTitle);
                termBox.BackColor = Color.Red;
                return false;
            }
           
            else
            {
                return true;
            }
        }
    }
}
