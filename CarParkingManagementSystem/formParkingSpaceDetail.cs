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
    public partial class formParkingSpaceDetail : Form
    {
        Manager manager = new Manager();
        int flag = 0;
        public formParkingSpaceDetail()
        {
            InitializeComponent();
            LoadData();
        }
        public formParkingSpaceDetail(string id)
        {
            InitializeComponent();
            LoadData(id);
        }
        public void LoadData()
        {
            this.txtID.Clear();
            this.txtIDKhachhang.Clear();
            this.txtIDNhanvien.Clear();
            this.txtTrangthai.Clear();
            this.txtGiatien.Clear();

            this.txtID.Focus();
        }
        public void LoadData(string id)
        {
            DataTable dt = manager.GetNoiDoXeByID(id);
            this.txtID.Text = dt.Rows[0]["IDDoXe"].ToString();
            this.txtIDKhachhang.Text = dt.Rows[0]["IDNguoiDung"].ToString();
            this.txtIDNhanvien.Text = dt.Rows[0]["IDNhanVien"].ToString();
            this.txtTrangthai.Text = dt.Rows[0]["trangthai"].ToString();
            this.txtGiatien.Text = dt.Rows[0]["sotien"].ToString();
        }

        private void formParkingSpaceDetail_Load(object sender, EventArgs e)
        {
            // nếu constructor không có tham số thì là thêm mới loadData()
            if (txtID.Text == "")
            {
                LoadData();
                flag = 0;
            }
            // nếu constructor có tham số thì là sửa loadData(string id)
            else
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
            if ((txtID.Text.Trim() == string.Empty) || (txtIDKhachhang.Text.Trim() == string.Empty) || (txtIDNhanvien.Text.Trim() == string.Empty) || (txtTrangthai.Text.Trim() == string.Empty) || (txtGiatien.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (flag == 0)
            {
                try
                {
                    if (manager.ThemNoiDoXe(txtID.Text, txtIDKhachhang.Text, txtIDNhanvien.Text, txtTrangthai.Text, txtGiatien.Text))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (flag == 1)
            {
                try
                {
                    if (manager.SuaNoiDoXe(txtID.Text, txtIDKhachhang.Text, txtIDNhanvien.Text, txtTrangthai.Text, txtGiatien.Text))
                    {
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(txtID.Text);
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
