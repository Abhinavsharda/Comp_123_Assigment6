using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Assignment6
{
    public partial class BmiCalculator : Form
    {
        public BmiCalculator()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // decelaring variables for height, weight, BMI
            double ht, wt, bmi;
            ht = Convert.ToDouble(HeightTextBox.Text);
            wt = Convert.ToDouble(WeightTextBox.Text);

            if (ht > 0 && wt > 0)
            {
                HeightTextBox.Enabled = false;
                WeightTextBox.Enabled = false;

                if (MetricRadioButton.Checked == true)
                {
                    bmi = wt / ((ht) * (ht));
                    ResultTextBox.Text = Convert.ToString(bmi);
                }
                else if (ImperialRadioButton.Checked == true)
                {
                    //algorithm
                    bmi = (wt * 4.88) / ((ht) * (ht));


                    ResultTextBox.Text = Convert.ToString(bmi);
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";

            ResultTextBox.Text = "0.0";


            //enable all the textbox
            HeightTextBox.Enabled = true;
            WeightTextBox.Enabled = true;
        }
    }
}
