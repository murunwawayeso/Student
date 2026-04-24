using System;
using System.Windows.Forms;

namespace SmartStudentProfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            int age, marks;

            // Validation
            if (!int.TryParse(txtAge.Text, out age) || age <= 0)
            {
                MessageBox.Show("Invalid Age");
                return;
            }

            if (!int.TryParse(txtMarks.Text, out marks) || marks < 0 || marks > 100)
            {
                MessageBox.Show("Invalid Marks");
                return;
            }

            string readiness = CalculateReadiness(marks);

            lblOutput.Text =
                "Name: " + name +
                "\nAge: " + age +
                "\nMarks: " + marks +
                "\nReadiness: " + readiness;
        }

        // Method reused
        private string CalculateReadiness(int marks)
        {
            if (marks >= 75)
                return "High Readiness";
            else if (marks >= 50)
                return "Moderate Readiness";
            else
                return "Low Readiness";
        }
    }
}
