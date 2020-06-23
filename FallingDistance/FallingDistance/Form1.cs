using System;
using System.Windows.Forms;

namespace FallingDistance
{
    public partial class Form1 : Form
    {
        const double g = 9.8;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textTime.Text = "";
            textDistance.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double t;
            if (double.TryParse(textTime.Text, out t))
            {
                double d = FallingDistance(t);
                textDistance.Text = d.ToString("n") + " meters";
            }
            else
                MessageBox.Show("Invalid Input.", "Please enter a number");
        }
        private double FallingDistance (double t)
        {
            double d = 0.5 * g * Math.Pow(t, 2);
            return d;
        }
    }
}
