using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_UX_Dashboard_P1.Models;

namespace UI_UX_Dashboard_P1.Forms
{
    public partial class frmAddEmployee : Form
    {
        HotelEntities db = new HotelEntities();
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool status = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text=="")
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
                Employee employee = new Employee();
                employee.Name = txtName.Text;
                employee.Address = txtAddress.Text;
                employee.Phone = txtPhone.Text;
                employee.EmployeeTypeID = int.Parse(cboEmployeeType.SelectedValue.ToString());
                //Thêm vào db
                db.Employees.Add(employee);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            //Lấy loại nhân viên
            cboEmployeeType.DataSource = db.EmployeeTypes.ToList();
            cboEmployeeType.DisplayMember = "Name";
            cboEmployeeType.ValueMember = "ID";
        }
    }
}
