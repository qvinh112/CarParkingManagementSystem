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
    public partial class formAccountDetail : Form
    {
        Manager manager = new Manager();
        int flag = 0;
        public formAccountDetail()
        {
            InitializeComponent();
            LoadData();
        }
        public formAccountDetail(string id)
        {
            InitializeComponent();
            LoadData(id);
        }
        public void LoadData()
        {
            this.txtID.Clear();
            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.txtReenterPwd.Clear();
            this.txtRole.Clear();

            this.txtID.Focus();
        }
        public void LoadData(string id)
        {
            DataTable dt = manager.GetTaiKhoanByID(id);
            this.txtID.Text = dt.Rows[0]["ID"].ToString();
            this.txtUsername.Text = dt.Rows[0]["username"].ToString();
            this.txtPassword.Text = dt.Rows[0]["password"].ToString();
            this.txtReenterPwd.Text = dt.Rows[0]["password"].ToString();
            this.txtRole.Text = dt.Rows[0]["vaiTro"].ToString();
            this.txtID.Enabled = false;
        }

        private void formAccountDetail_Load(object sender, EventArgs e)
        {
            // nếu constructor không có tham số thì là thêm mới loadData()
            if (txtID.Text == "")
            {
                LoadData();
                flag = 0;

            }
            else // ngược lại là sửa thì load dữ liệu của id đó lên
            {
                LoadData(txtID.Text);
                flag = 1;
            }
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
            if ((txtID.Text == "") || (txtUsername.Text == "") || (txtPassword.Text == "") || (txtReenterPwd.Text == "") || (txtRole.Text == ""))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin yêu cầu!", "Thông báo");
                return;
            }
            if (txtPassword.Text != txtReenterPwd.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!", "Thông báo");
                return;
            }
            if (flag == 0)
            {
                try
                {
                    manager.ThemTaiKhoan(txtID.Text, txtUsername.Text, txtPassword.Text, txtRole.Text);
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            else
            {
                try
                {
                    manager.SuaTaiKhoan(txtID.Text, txtUsername.Text, txtPassword.Text, txtRole.Text);
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
        }
    }
}
