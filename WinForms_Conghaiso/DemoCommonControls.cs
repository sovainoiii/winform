using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Bai lam cua Pham Duc Minh
namespace WinForms_Conghaiso
{
    public partial class DemoCommonControls : Form
    {
        public DemoCommonControls()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string EmployeeID = txtEmpID.Text;
            string EmployeeName = txtEmpName.Text;
            string Phone = mtxtPhone.Text;
            string Gender = (rdMale.Checked) ? "Male" : "Female";
            string Degree = cboDegree.Text;
            StringBuilder builder = new StringBuilder();
            builder.Append($"Employee ID: {EmployeeID}\n");
            builder.Append($"Employee Name: {EmployeeName}\n");
            builder.Append($"Phone: {Phone}\n");
            builder.Append($"Gender: {Gender}\n");
            builder.Append($"Degree: {Degree}");
            MessageBox.Show(builder.ToString(), "Employee Detail");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
