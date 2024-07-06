using System;
using System.Windows.Forms;

namespace TrigonometricCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbLeg.Checked)
                {
                    double leg = double.Parse(txtLeg.Text);
                    double angle = double.Parse(txtAngle.Text) * (Math.PI / 180); // Convert to radians
                    double result = 0;

                    if (rbSin.Checked)
                    {
                        result = leg / Math.Sin(angle);
                    }
                    else if (rbCos.Checked)
                    {
                        result = leg / Math.Cos(angle);
                    }
                    else if (rbTan.Checked)
                    {
                        result = leg / Math.Tan(angle);
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid ratio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    lblResult.Text = $"Result: {result:F2}";
                }
                else if (rbAngle.Checked)
                {
                    double leg1 = double.Parse(txtLeg1.Text);
                    double leg2 = double.Parse(txtLeg2.Text);
                    double result = 0;

                    if (rbSin.Checked)
                    {
                        result = Math.Asin(leg1 / leg2) * (180 / Math.PI); // Convert to degrees
                    }
                    else if (rbCos.Checked)
                    {
                        result = Math.Acos(leg1 / leg2) * (180 / Math.PI); // Convert to degrees
                    }
                    else if (rbTan.Checked)
                    {
                        result = Math.Atan(leg1 / leg2) * (180 / Math.PI); // Convert to degrees
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid ratio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    lblResult.Text = $"Result: {result:F2} degrees";
                }
                else
                {
                    MessageBox.Show("Please select what you want to find.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbLeg_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLeg.Checked)
            {
                pnlLegInputs.Visible = true;
                pnlAngleInputs.Visible = false;
            }
        }

        private void rbAngle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAngle.Checked)
            {
                pnlLegInputs.Visible = false;
                pnlAngleInputs.Visible = true;
            }
        }
    }
}
