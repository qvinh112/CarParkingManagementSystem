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
    public partial class formPayment : Form
    {
        Customer customer = new Customer();
        public string IDKH;

        public formPayment(string id)
        {
            InitializeComponent();
            IDKH = id;
        }

        public void LoadData()
        {
            DataTable dt = customer.ThongtinDoxe(IDKH);
            this.txtID.Text = dt.Rows[0]["ID"].ToString();
            this.txtName.Text = dt.Rows[0]["ten"].ToString();
            this.txtBienso.Text = dt.Rows[0]["bienSo"].ToString();
            this.txtNgaydoxe.Text = dt.Rows[0]["ngayDoXe"].ToString();
            this.txtNgaylayxe.Text = dt.Rows[0]["ngayLayXe"].ToString();
            this.txtPhidoxe.Text = dt.Rows[0]["sotien"].ToString();
        }

        private void formPayment_Load(object sender, EventArgs e)
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

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            customer.LayXe(customer.ViTriDoXe(IDKH).ToString());
            MessageBox.Show("Thanh toán thành công!");
            MessageBox.Show("Lấy xe thành công!");
            this.Close();
        }

        private void btnInternet_Click(object sender, EventArgs e)
        {
            string soTien = txtPhidoxe.Text.Trim();
            string noiDung = txtBienso.Text.Trim();

            // Thay thông tin bên dưới bằng tài khoản SePay của bạn
            string acc = "LOCSPAY000308452";
            string bank = "ACB";

            // Tạo URL QR
            string qrUrl = $"https://qr.sepay.vn/img?acc={acc}&bank={bank}&amount={soTien}&des={noiDung}";

            // Hiển thị ảnh QR lên PictureBox
            pictureBox.Load(qrUrl);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPhidoxe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBienso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
