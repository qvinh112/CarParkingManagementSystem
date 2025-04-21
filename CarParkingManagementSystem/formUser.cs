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
    public partial class formUser : Form
    {
        Manager manager = new Manager();
        public formUser()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                DataTable dataTable = manager.GetAllAdminInfo();
                this.txtID.Text = dataTable.Rows[0]["ID"].ToString();
                this.txtName.Text = dataTable.Rows[0]["ten"].ToString();
                this.txtAge.Text = dataTable.Rows[0]["tuoi"].ToString();
                this.txtAddress.Text = dataTable.Rows[0]["diachi"].ToString();
                this.txtSDT.Text = dataTable.Rows[0]["sdt"].ToString();
                this.lb_ten.Text = dataTable.Rows[0]["ten"].ToString();
                this.txtID.Enabled = false;
                this.txtName.Enabled = false;
                this.txtAge.Enabled = false;
                this.txtAddress.Enabled = false;
                this.txtSDT.Enabled = false;
                this.btnDoiMK.Hide();

            }
            catch (Exception)
            {
                MessageBox.Show("Không thể hiển thị dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void formUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.txtID.Enabled = false;
            this.txtName.Enabled = true;
            this.txtAge.Enabled = true;
            this.txtAddress.Enabled = true;
            this.txtSDT.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text.Trim() == string.Empty || this.txtAge.Text.Trim() == string.Empty || this.txtAddress.Text.Trim() == string.Empty || this.txtSDT.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    manager.SuaAdminInfo(this.txtID.Text, this.txtName.Text, this.txtAge.Text, this.txtAddress.Text, this.txtSDT.Text);
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể cập nhật thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            formChangePassword form = new formChangePassword();
            form.ShowDialog();
        }
    }
}
