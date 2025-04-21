using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingManagementSystem
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        public void openChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.btnRestoreDown.Visible = true;
                this.btnMaximize.Visible = false;
            }
            else
            {
                this.btnRestoreDown.Visible = false;
                this.btnMaximize.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.btnRestoreDown.Visible = true;
            this.btnMaximize.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnRestoreDown_Click(object sender, EventArgs e)
        {
            this.btnRestoreDown.Visible = false;
            this.btnMaximize.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBaidoxe_Click(object sender, EventArgs e)
        {
            btnTaikhoan.BackColor = Color.DarkSlateGray;
            btnUser.BackColor = Color.DarkSlateGray;
            btnBaidoxe.BackColor = Color.Firebrick;
            btnKhachhang.BackColor = Color.DarkSlateGray;
            btnNhanvien.BackColor = Color.DarkSlateGray;
            btnReport.BackColor = Color.DarkSlateGray;

            openChildForm(new formParkingSpace());
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            btnTaikhoan.BackColor = Color.DarkSlateGray;
            btnUser.BackColor = Color.DarkSlateGray;
            btnBaidoxe.BackColor = Color.DarkSlateGray;
            btnKhachhang.BackColor = Color.Firebrick;
            btnNhanvien.BackColor = Color.DarkSlateGray;
            btnReport.BackColor = Color.DarkSlateGray;

            openChildForm(new formCustomer());
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            btnTaikhoan.BackColor = Color.DarkSlateGray;
            btnUser.BackColor = Color.DarkSlateGray;
            btnBaidoxe.BackColor = Color.DarkSlateGray;
            btnKhachhang.BackColor = Color.DarkSlateGray;
            btnNhanvien.BackColor = Color.Firebrick;
            btnReport.BackColor = Color.DarkSlateGray;

            openChildForm(new formStaff());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            btnTaikhoan.BackColor = Color.DarkSlateGray;
            btnUser.BackColor = Color.DarkSlateGray;
            btnBaidoxe.BackColor = Color.DarkSlateGray;
            btnKhachhang.BackColor = Color.DarkSlateGray;
            btnNhanvien.BackColor = Color.DarkSlateGray;
            btnReport.BackColor = Color.Firebrick;

            openChildForm(new formReport());
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            btnTaikhoan.BackColor = Color.Firebrick;
            btnUser.BackColor = Color.DarkSlateGray;
            btnBaidoxe.BackColor = Color.DarkSlateGray;
            btnKhachhang.BackColor = Color.DarkSlateGray;
            btnNhanvien.BackColor = Color.DarkSlateGray;
            btnReport.BackColor = Color.DarkSlateGray;

            openChildForm(new formAccount());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            btnTaikhoan.BackColor = Color.DarkSlateGray;
            btnUser.BackColor = Color.Firebrick;
            btnBaidoxe.BackColor = Color.DarkSlateGray;
            btnKhachhang.BackColor = Color.DarkSlateGray;
            btnNhanvien.BackColor = Color.DarkSlateGray;
            btnReport.BackColor = Color.DarkSlateGray;

            formUser form = new formUser();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin form = new formLogin();
            form.ShowDialog();
        }
    }
}
