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
    public partial class formCustomerDetail : Form
    {
        Manager manager = new Manager();
        int flag = 0;
        public formCustomerDetail()
        {
            InitializeComponent();
            LoadData();
        }
        public formCustomerDetail(string id)
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
            this.txtBienso.Clear();
            this.txtNgaydoxe.Clear();
            this.txtNgaylayxe.Clear();
            this.txtPhidoxe.Clear();

            this.txtID.Focus();
        }
        public void LoadData(string id)
        {
            DataTable dt = manager.GetThongTinCaNhanByID(id);
            this.txtID.Text = dt.Rows[0]["ID"].ToString();
            this.txtName.Text = dt.Rows[0]["ten"].ToString();
            this.txtAge.Text = dt.Rows[0]["tuoi"].ToString();
            this.txtSDT.Text = dt.Rows[0]["sdt"].ToString();
            this.txtAddress.Text = dt.Rows[0]["diachi"].ToString();
            this.txtBienso.Text = dt.Rows[0]["bienSo"].ToString();
            this.txtNgaydoxe.Text = dt.Rows[0]["ngayDoXe"].ToString();
            this.txtNgaylayxe.Text = dt.Rows[0]["ngayLayXe"].ToString();
            this.txtPhidoxe.Text = dt.Rows[0]["sotien"].ToString();
            this.txtID.Enabled = false;
        }

        private void formCustomerDetail_Load(object sender, EventArgs e)
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
            if ((txtID.Text.Trim() == string.Empty) || (txtName.Text.Trim() == string.Empty) || (txtAge.Text.Trim() == string.Empty) || (txtSDT.Text.Trim() == string.Empty) || (txtAddress.Text.Trim() == string.Empty) || (txtBienso.Text.Trim() == string.Empty) || (txtNgaydoxe.Text.Trim() == string.Empty) || (txtNgaylayxe.Text.Trim() == string.Empty) || (txtPhidoxe.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (flag == 0)
            {
                try
                {
                    if (manager.ThemThongTinCaNhan(txtID.Text, txtName.Text, txtAge.Text, txtSDT.Text, txtAddress.Text, txtBienso.Text, txtNgaydoxe.Text, txtNgaylayxe.Text, txtPhidoxe.Text))
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
            else
            {
                try
                {
                    if (manager.SuaThongTinCaNhan(txtID.Text, txtName.Text, txtAge.Text, txtSDT.Text, txtAddress.Text, txtBienso.Text, txtNgaydoxe.Text, txtNgaylayxe.Text, txtPhidoxe.Text))
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
