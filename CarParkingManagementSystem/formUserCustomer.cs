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
    public partial class formUserCustomer : Form
    {
        Customer customer = new Customer();
        public string IDKH;

        public formUserCustomer(string id)
        {
            InitializeComponent();
            IDKH = id;
        }

        public void LoadData()
        {
            DataTable dt = customer.User(IDKH);
            this.txtID.Text = dt.Rows[0]["ID"].ToString();
            this.txtName.Text = dt.Rows[0]["ten"].ToString();
            this.txtAge.Text = dt.Rows[0]["tuoi"].ToString();
            this.txtAddress.Text = dt.Rows[0]["diachi"].ToString();
            this.txtSDT.Text = dt.Rows[0]["sdt"].ToString();
        }

        private void formUserCustomer_Load(object sender, EventArgs e)
        {
            this.txtID.Enabled = false;
            this.txtName.Enabled = false;
            this.txtAge.Enabled = false;
            this.txtAddress.Enabled = false;
            this.txtSDT.Enabled = false;

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
            customer.SuaThongTinCaNhan(this.txtID.Text, this.txtName.Text, this.txtAge.Text, this.txtSDT.Text, this.txtAddress.Text);
            MessageBox.Show("Cập nhật thông tin thành công!");

            this.txtID.Enabled = false;
            this.txtName.Enabled = false;
            this.txtAge.Enabled = false;
            this.txtAddress.Enabled = false;
            this.txtSDT.Enabled = false;

            LoadData();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            DataTable dt = customer.user_pass(IDKH);
            formChangePassword form = new formChangePassword();
            form.Username = dt.Rows[0]["username"].ToString();
            form.Password = dt.Rows[0]["password"].ToString();
            form.Show();
        }
    }
}

