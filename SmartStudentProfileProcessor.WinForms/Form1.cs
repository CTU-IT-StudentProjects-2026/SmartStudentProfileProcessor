using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartStudentProfileProcessor.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ensure result label starts empty
            lblFinalResult.Text = "";
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string studentName = txtName.Text.Trim();

            if (!int.TryParse(txtAge.Text, out int studentAge))
            {
                lblFinalResult.Text = "Please enter a valid number for age.";
                lblFinalResult.ForeColor = Color.Red;
                return;
            }

            if (!double.TryParse(txtScore.Text, out double assessmentScore) ||
                assessmentScore < 0 || assessmentScore > 100)
            {
                lblFinalResult.Text = "Please enter a score between 0 and 100.";
                lblFinalResult.ForeColor = Color.Red;
                return;
            }

            if (studentAge >= 18 && assessmentScore >= 50)
            {
                lblFinalResult.Text = "Student " + studentName + " is READY.";
                lblFinalResult.ForeColor = Color.Green;
            }
            else
            {
                lblFinalResult.Text = "Student " + studentName + " is NOT READY.";
                lblFinalResult.ForeColor = Color.Red;
            }
            MessageBox.Show(lblFinalResult.Text);
        }
    }
};