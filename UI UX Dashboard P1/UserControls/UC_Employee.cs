using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_UX_Dashboard_P1.Forms;
using UI_UX_Dashboard_P1.Models;

namespace UI_UX_Dashboard_P1.UserControls
{
    public partial class UC_Employee : UserControl
    {
        HotelEntities db = new HotelEntities();
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEmployee formAddEmployee = new frmAddEmployee();
            formAddEmployee.ShowDialog();
            if (formAddEmployee.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Add employee success", "Message");
                LoadDataGridView();
            }
        }

        private void LoadDataGridView()
        {
            dgvEmployee.DataSource = db.Employees.ToList();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = db.Employees.ToList();

            if (dgvEmployee.SelectedRows.Count > 0)
            {
                    DataGridViewRow dataGridViewRow = dgvEmployee.SelectedRows[0];
                    employeeID = (int)dataGridViewRow.Cells[0].Value;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Do you want to delete employee", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DataGridViewRow dataGridViewRow = dgvEmployee.SelectedRows[0];
                    Employee employee = db.Employees.Find(dataGridViewRow.Cells[0].Value);
                    db.Employees.Remove(employee);
                    db.SaveChanges();

                    LoadDataGridView();
                }
            }
        }
        //Tạo biến để lưu mã nhân viên dùng cho update
        public static int employeeID = 0;
        private void dgvEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = dgvEmployee.SelectedRows[0];
                employeeID = (int)dataGridViewRow.Cells[0].Value;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditEmployee frmEditEmployee = new frmEditEmployee();
            frmEditEmployee.ShowDialog();
            if (frmEditEmployee.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Edit employee success", "Message");
                db.SaveChanges();
                LoadDataGridView();
            }
        }
    }
}
