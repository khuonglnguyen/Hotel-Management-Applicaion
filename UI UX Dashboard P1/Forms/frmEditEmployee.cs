using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_UX_Dashboard_P1.Models;
using UI_UX_Dashboard_P1.UserControls;

namespace UI_UX_Dashboard_P1.Forms
{
    public partial class frmEditEmployee : Form
    {
        HotelEntities db = new HotelEntities();
        public frmEditEmployee()
        {
            InitializeComponent();
        }

        private void frmEditEmployee_Load(object sender, EventArgs e)
        {
            //Lấy ds loại nhân viên
            cboEmployeeType.DataSource = db.EmployeeTypes.ToList();
            cboEmployeeType.DisplayMember = "Name";
            cboEmployeeType.ValueMember = "ID";

            if (UC_Employee.employeeID != 0)
            {
                Employee employee = db.Employees.Find(UC_Employee.employeeID);
                txtName.Text = employee.Name;
                txtAddress.Text = employee.Address;
                txtPhone.Text = employee.Address;
                cboEmployeeType.SelectedValue = employee.EmployeeTypeID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool status = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text == "")
                    {
                        status = false;
                    }
                }
            }
            if (!status)
            {
                MessageBox.Show("Please input all information employee", "Message");
                return;
            }
            try
            {
                Employee employee = db.Employees.Find(UC_Employee.employeeID);
                employee.Name = txtName.Text;
                employee.Address = txtAddress.Text;
                employee.Phone = txtPhone.Text;
                employee.EmployeeTypeID = int.Parse(cboEmployeeType.SelectedValue.ToString());
                //Lưu
                db.SaveChanges();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
