using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = dgvEmployee.SelectedRows[0];
                employeeID = (int)dataGridViewRow.Cells[0].Value;
            }
        }
        private void LoadDataGridView()
        {
            using (var context = new HotelEntities())
            {
                dgvEmployee.DataSource = context.Employees.Select(x => new { ID = x.ID, Name = x.Name, Address = x.Address, EmployeeType = x.EmployeeType.Name ,Status=x.IsLocked==true?"Lock":"Active"}).ToList();
            }
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            LoadDataGridView();

            if (dgvEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = dgvEmployee.SelectedRows[0];
                employeeID = (int)dataGridViewRow.Cells[0].Value;
            }
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Do you want to lock employee", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DataGridViewRow dataGridViewRow = dgvEmployee.SelectedRows[0];
                    Employee employee = db.Employees.Find(dataGridViewRow.Cells[0].Value);
                    employee.IsLocked = true;
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
                LoadDataGridView();
            }
        }

        private void btnShowLocked_Click(object sender, EventArgs e)
        {
            using (var context = new HotelEntities())
            {
                dgvEmployee.DataSource = context.Employees.Where(x=>x.IsLocked==true).Select(x => new { ID = x.ID, Name = x.Name, Address = x.Address, EmployeeType = x.EmployeeType.Name, Status = x.IsLocked == true ? "Lock" : "Active" }).ToList();
            }
        }

        private void btnShowActived_Click(object sender, EventArgs e)
        {
            using (var context = new HotelEntities())
            {
                dgvEmployee.DataSource = context.Employees.Where(x => x.IsLocked == false).Select(x => new { ID = x.ID, Name = x.Name, Address = x.Address, EmployeeType = x.EmployeeType.Name, Status = x.IsLocked == true ? "Lock" : "Active" }).ToList();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            using (var context = new HotelEntities())
            {
                dgvEmployee.DataSource = context.Employees.Select(x => new { ID = x.ID, Name = x.Name, Address = x.Address, EmployeeType = x.EmployeeType.Name, Status = x.IsLocked == true ? "Lock" : "Active" }).ToList();
            }
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                    DataGridViewRow dataGridViewRow = dgvEmployee.SelectedRows[0];
                    Employee employee = db.Employees.Find(dataGridViewRow.Cells[0].Value);
                    employee.IsLocked = false;
                    db.SaveChanges();

                    LoadDataGridView();
            }
        }
    }
}
