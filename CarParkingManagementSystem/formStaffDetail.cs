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
    public partial class formStaffDetail : Form
    {
        Manager manager = new Manager();
        int flag = 0;
        public formStaffDetail()
        {
            InitializeComponent();
            LoadData();
        }
        public formStaffDetail(string id)
        {
            InitializeComponent();
            LoadData(id);
        }
        public void LoadData()
        {
            this.txtID.Clear();
            this.txtName.Clear();
            this.txtAge.Clear();
            this.txtSDT.Clear();
            this.txtAddress.Clear();

            this.txtID.Focus();
        }
        public void LoadData(string id)
        {
            DataTable dt = manager.GetNhanVienByID(id);
            this.txtID.Text = dt.Rows[0]["ID"].ToString();
            this.txtName.Text = dt.Rows[0]["ten"].ToString();
            this.txtAge.Text = dt.Rows[0]["tuoi"].ToString();
            this.txtSDT.Text = dt.Rows[0]["sdt"].ToString();
            this.txtAddress.Text = dt.Rows[0]["diachi"].ToString();
            this.txtID.Enabled = false;
        }

        private void formStaffDetail_Load(object sender, EventArgs e)
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
            if (txtID.Text == "" || txtName.Text == "" || txtAge.Text == "" || txtSDT.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (flag == 0)
            {
                try
                {
                    manager.ThemNhanVien(txtID.Text, txtName.Text, txtAge.Text, txtSDT.Text, txtAddress.Text);
                    MessageBox.Show("Thêm thành công!");
                    LoadData();
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
                    manager.SuaNhanVien(txtID.Text, txtName.Text, txtAge.Text, txtSDT.Text, txtAddress.Text);
                    MessageBox.Show("Sửa thành công!");
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
        }
    }
}
