using CarParkingManagementSystem.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CarParkingManagementSystem
{
    public partial class formParkCarAttendant : Form
    {
        Attendant attendant = new Attendant();

        public formParkCarAttendant()
        {
            InitializeComponent();
        }

        private string _idSpace;

        public string IDSpace
        {
            get { return _idSpace; }
            set { _idSpace = value; }
        }

        private string _idNV;

        public string IDNV
        {
            get { return _idNV; }
            set { _idNV = value; }
        }

        private void formParkCarAttendant_Load(object sender, EventArgs e)
        {
            this.txtIDDoxe.Text = IDSpace;
            this.txtIDKhachhang.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnParkcar_Click(object sender, EventArgs e)
        {
            attendant.DoXe(IDSpace, this.txtIDKhachhang.Text, "chuatra");
            MessageBox.Show("Đỗ xe thành công!");
            try
            {
                DataTable dt = attendant.ThongtinDoxe(this.txtIDKhachhang.Text);
                StreamWriter sw = new StreamWriter(@"D:\SPKT\NamBa\OOPR230279_23_1_12\Tuan16\Folder\Vexe" + IDSpace + ".txt");

                sw.WriteLine("-------------Vé gửi xe-----------");
                sw.WriteLine("ID khách hàng: " + dt.Rows[0]["ID"].ToString());
                sw.WriteLine("Tên khách hàng: " + dt.Rows[0]["ten"].ToString());
                sw.WriteLine("Vị trí đỗ xe: " + IDSpace);
                sw.WriteLine("Biển số xe: " + dt.Rows[0]["bienSo"].ToString());
                sw.WriteLine("Ngày đỗ xe: " + dt.Rows[0]["ngayDoXe"].ToString());
                sw.WriteLine("Ngày lấy xe: " + dt.Rows[0]["ngayLayXe"].ToString());
                sw.WriteLine("Phí đỗ xe: " + dt.Rows[0]["sotien"].ToString() + "đ");
                sw.WriteLine("---------------------------------");                
                sw.Close();
                MessageBox.Show("Đã in vé!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("In vé thất bại!\n" + ex.Message);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
