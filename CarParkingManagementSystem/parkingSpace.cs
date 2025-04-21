using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using CarParkingManagementSystem.Properties;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarParkingManagementSystem.DBLayer;
using CarParkingManagementSystem.BSLayer;
using System.IO;

namespace CarParkingManagementSystem
{
    public partial class parkingSpace : UserControl
    {
        Customer customer = new Customer();

        public parkingSpace()
        {
            InitializeComponent();
        }

        private int _flag;
        private string _idUser;
        private string _idSpace;
        private Image _icon;
        private Color _iconBg;

        [Category("Parking Space Props")]
        public int Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }

        [Category("Parking Space Props")]
        public string IDUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }

        [Category("Parking Space Props")]
        public string IDSpace
        {
            get { return _idSpace; }
            set { _idSpace = value; lblIDSpace.Text = value; }
        }

        [Category("Parking Space Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; ptbParked.Image = value; }
        }

        [Category("Parking Space Props")]
        public Color IconBg
        {
            get { return _iconBg; }
            set { _iconBg = value; panel1.BackColor = value; }
        }

        private void parkingSpace_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightGray;
        }

        private void parkingSpace_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = _iconBg;
        }

        private void parkingSpace_Click(object sender, EventArgs e)
        {
            if (Flag == 0)
            {
                if (_iconBg == Color.LightGray)
                {
                    MessageBox.Show("Vị trí này đã có xe khác đỗ!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (_iconBg == Color.White)
                {
                    DialogResult ans = MessageBox.Show("Đỗ xe ở vị trí này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {
                        customer.DoXe(IDSpace, IDUser, "chuatra");
                        MessageBox.Show("Đỗ xe thành công!");
                        IconBg = Color.LightGray;
                        Icon = Resources.car;

                        try
                        {
                            DataTable dt = customer.ThongtinDoxe(IDUser);
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
                    }
                }
            }

            if (Flag == 1)
            {
                if (_iconBg == Color.LightGray)
                {
                    MessageBox.Show("Vị trí này đã có xe khác đỗ!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (_iconBg == Color.White)
                {
                    DialogResult ans = MessageBox.Show("Đỗ xe ở vị trí này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {
                        formParkCarAttendant form = new formParkCarAttendant();
                        form.IDSpace = IDSpace;
                        form.IDNV = IDUser;
                        form.Show();
                        IconBg = Color.LightGray;
                        Icon = Resources.car;
                    }
                }
            }
        }
    }
}
