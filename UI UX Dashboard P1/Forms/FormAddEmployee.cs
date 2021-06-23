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
    public partial class FormAddEmployee : Form
    {
        HotelEntities db = new HotelEntities();
        public FormAddEmployee()
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
    }
}
