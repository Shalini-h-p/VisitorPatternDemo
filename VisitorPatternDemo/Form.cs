using System;

namespace visitorExample
{
    public partial class Form : System.Windows.Forms.Form
    {
        SalaryContainer salaryContainer = new SalaryContainer();
        Functions functions;

        public Form()
        {
            InitializeComponent();
            functions = new Functions();
            salaryContainer.Accept(functions);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int sal;
            try
            {
                sal = int.Parse(empSaltxt.Text);
            }
            catch (Exception)
            {
                ShowMessage("* Input is not valid.");
                return;
            }
            var result = salaryContainer.AddSalary(sal);
            if (result)
            {
                ShowMessage($"{sal} is added as salary");
            }
            else
            {
                ShowMessage($"* {sal} is not in range {salaryContainer.Min} to {salaryContainer.Max}.");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var sal = salaryContainer.EmpSal;
            salaryContainer.RemoveItem();
            ShowMessage($"{sal} has been Deleted");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var result = functions.ReadAvail();
            ShowMessage($"{result} is the Employee Salary.");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int val;
            try
            {
                val = int.Parse(updateMax.Text);
            }
            catch (Exception)
            {
                ShowMessage("* Input is not valid.");
                return;
            }
            functions.UpdateMaxSal(val);
            ShowMessage($"{val} is the new Maximum Salary.");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int val;
            try
            {
                val = int.Parse(updateMin.Text);
            }
            catch (Exception)
            {
                ShowMessage("* Input is not valid.");
                return;
            }
            functions.UpdateMinSal(val);
            ShowMessage($"{val} is the new Minimum Salary.");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ShowMessage($"The range is {salaryContainer.Min} to {salaryContainer.Max}.");
        }

        private void ShowMessage(string message = "")
        {
            warningTxt.Text = message;
        }
    }
}
