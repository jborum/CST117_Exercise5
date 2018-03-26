using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excerise_5_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int intTerms;

            // Text box only allows integers
            if (int.TryParse(txtTerms.Text, out intTerms))
            {
                // Declare variable
                int index = 0;
                double x = 4;
                double y = 1;
                double approx;
                double newpi = 0.0;

                // While loop to loop per number of integers selected by user
                while (++index < intTerms - 1)
                {
                    //Algorithm to create = 4 - 4/3 + 4/5 - 4/6 + 4/7 - 4/8 + 4/9...
                    approx = x / y;
                    newpi = newpi + approx;
                    y = y + 2;
                    // Alternate the positive and negative value for x
                    x = (x > 0) ? -4.0 : 4.0;
                }

                //Update text box and label
                txtPI.Text = Convert.ToString(newpi);
                this.label2.Text = "Approximate value of pi after " + txtTerms.Text + " terms";
            }
            else
            {
                //Message box to let user know there is an invalid input.
                MessageBox.Show("Please Enter Valid Integer", "Input Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                txtTerms.Text = "";
                this.ActiveControl = txtTerms;
            }
        }

    }
}
