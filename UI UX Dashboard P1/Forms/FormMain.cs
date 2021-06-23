using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_UX_Dashboard_P1.UserControls;

namespace UI_UX_Dashboard_P1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UC_DashBroad uC_DashBroad = new UC_DashBroad();
            uC_DashBroad.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uC_DashBroad);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLeftMenu_Click(object sender, EventArgs e)
        {
            timerLeftMenu.Start();
        }
        bool leftMenu = false;
        private void timerLeftMenu_Tick(object sender, EventArgs e)
        {
            if (leftMenu)
            {
                if (pnlLeftMenu.Width <= 215)
                {
                    pnlLeftMenu.Width += 5;
                    btnLeftMenu.Left += 5;
                    lblAdmin.Left += 5;
                }
                else
                {
                    leftMenu = false;
                    timerLeftMenu.Stop();
                }
            }
            else
            {
                if (pnlLeftMenu.Width > 50)
                {
                    pnlLeftMenu.Width -= 5;
                    btnLeftMenu.Left -= 5;
                    lblAdmin.Left -= 5;
                }
                else
                {
                    leftMenu = true;
                    timerLeftMenu.Stop();
                }
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            int i = 0;
            //Kiểm tra các controls trong pnlMain có tồn tại UC_Employee chưa
            foreach (Control control in pnlMain.Controls)
            {
                if (control is UserControl)
                {
                    if(control.Name == "UC_Employee")
                    {
                        if (pnlMain.Controls[i].Name == "UC_Employee")
                        {
                            pnlMain.Controls[i].BringToFront();
                            return;
                        }
                    }
                }
                i++;
            }
            //Nếu chưa tồn tại UC_Employee thì Add vào pnlMain
            UC_Employee uC_Employee = new UC_Employee();
            uC_Employee.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uC_Employee);
            pnlMain.Controls[pnlMain.Controls.Count-1].BringToFront();
        }

        private void btnDashBroad_Click(object sender, EventArgs e)
        {
            int i = 0;
            //Kiểm tra các controls trong pnlMain có tồn tại UC_DashBroad chưa
            foreach (Control control in pnlMain.Controls)
            {
                if (control is UserControl)
                {
                    if (control.Name == "UC_DashBroad")
                    {
                        if (pnlMain.Controls[i].Name == "UC_DashBroad")
                        {
                            pnlMain.Controls[i].BringToFront();
                            return;
                        }
                    }
                }
                i++;
            }
            UC_DashBroad uC_DashBroad = new UC_DashBroad();
            uC_DashBroad.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uC_DashBroad);
            pnlMain.Controls[pnlMain.Controls.Count-1].BringToFront();
        }
    }
}
