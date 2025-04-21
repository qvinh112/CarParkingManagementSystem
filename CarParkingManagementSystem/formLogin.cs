using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarParkingManagementSystem.DBLayer;
using CarParkingManagementSystem.BSLayer;

namespace CarParkingManagementSystem
{
    public partial class formLogin : Form
    {
        login taikhoan = new login();
        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
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

            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin đăng nhập!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                object dt = taikhoan.loginCheck(txtUsername.Text, txtPassword.Text);
                if (dt.ToString() == "quanli")
                {
                    this.Hide();
                    formMain form = new formMain();                    
                    form.Show();
                }
                else if (dt.ToString() == "nguoidung")
                {
                    string id = taikhoan.ID(txtUsername.Text, txtPassword.Text).ToString().Trim();
                    this.Hide();
                    formCustomerMain form = new formCustomerMain(id);
                    form.Show();
                }
                else if (dt.ToString() == "nhanvien")
                {
                    string id = taikhoan.ID(txtUsername.Text, txtPassword.Text).ToString().Trim();
                    this.Hide();
                    formAttendantMain form = new formAttendantMain(id);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác. Mời nhập lại!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*else
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác. Mời nhập lại!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }*/
        }

        private void ptbHidePass_Click(object sender, EventArgs e)
        {
            ptbHidePass.Hide();
            txtPassword.UseSystemPasswordChar = false;
            ptbShowPass.Show();
        }

        private void ptbShowPass_Click(object sender, EventArgs e)
        {
            ptbShowPass.Hide();
            txtPassword.UseSystemPasswordChar = true;
            ptbHidePass.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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
    }
}
