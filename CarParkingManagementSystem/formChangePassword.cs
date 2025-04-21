using CarParkingManagementSystem.BSLayer;
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
    public partial class formChangePassword : Form
    {
        Customer customer = new Customer();

        public formChangePassword()
        {
            InitializeComponent();
        }

        private string username;
        private string password;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        { 
            get { return password; } 
            set {  password = value; } 
        }

        public void Clear()
        {
            this.txtOldPwd.Clear();
            this.txtNewPwd.Clear();
            this.txtReenterPwd.Clear();
            this.txtOldPwd.UseSystemPasswordChar = true;
            this.txtNewPwd.UseSystemPasswordChar = true;
            this.txtReenterPwd.UseSystemPasswordChar = true;

            this.txtOldPwd.Focus();
        }

        private void formChangePassword_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtOldPwd.Text.Trim() == string.Empty || this.txtNewPwd.Text.Trim() == string.Empty || this.txtReenterPwd.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin đăng nhập!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (this.txtOldPwd.Text.Trim() != Password)
                MessageBox.Show("Không đúng mật khẩu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                customer.DoiMatKhau(Username, this.txtNewPwd.Text.Trim());
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            }
        }

        private void cboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxShowPass.Checked == true)
            {
                this.txtOldPwd.UseSystemPasswordChar = false;
                this.txtNewPwd.UseSystemPasswordChar = false;
                this.txtReenterPwd.UseSystemPasswordChar = false;                
            }
            else
            {
                this.txtOldPwd.UseSystemPasswordChar = true;
                this.txtNewPwd.UseSystemPasswordChar = true;
                this.txtReenterPwd.UseSystemPasswordChar = true;
            }                 
        }
    }
}
