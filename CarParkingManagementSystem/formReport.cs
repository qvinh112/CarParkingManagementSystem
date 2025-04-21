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
using System.IO;

namespace CarParkingManagementSystem
{
    public partial class formReport : Form
    {
        Manager manager = new Manager();
        public formReport()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                DataTable dt = manager.GetAllInfoDoXe();
                this.dtgReport.DataSource = dt;
                this.cb_Type.SelectedIndex = 0;
                this.txtFind.Hide();
                // đặt lại ngày bắt đầu là 20/11/2020
                this.dtpDayStart.Value = new DateTime(2020, 11, 20);
                this.dtpDayEnd.Value = new DateTime(2023, 11, 20);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể hiển thị dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formReport_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            if (cb_Type.SelectedIndex == 0)
            {
                try
                {
                    string dayStart = this.dtpDayStart.Value.ToString("yyyy-MM-dd");
                    string dayEnd = this.dtpDayEnd.Value.ToString("yyyy-MM-dd");
                    object sotienDuTinh = manager.TinhDoanhThuChuaTraDoXe(dayStart, dayEnd);
                    // thông báo số tiền dự tính
                    MessageBox.Show("Số tiền dự tính: " + sotienDuTinh.ToString() + " VNĐ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể tính dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cb_Type.SelectedIndex == 1)
            {
                try
                {
                    string dayStart = this.dtpDayStart.Value.ToString("yyyy-MM-dd");
                    string dayEnd = this.dtpDayEnd.Value.ToString("yyyy-MM-dd");
                    object sotienDaThu = manager.TinhDoanhThuTraDoXe(dayStart, dayEnd);
                    // thông báo số tiền đã thu
                    MessageBox.Show("Số tiền thực tế đã thu: " + sotienDaThu.ToString() + " VNĐ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể tính dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            if (cb_Type.SelectedIndex == 0)
            {
                try
                {
                    string dayStart = this.dtpDayStart.Value.ToString("yyyy-MM-dd");
                    string dayEnd = this.dtpDayEnd.Value.ToString("yyyy-MM-dd");
                    object sotienDuTinh = manager.TinhDoanhThuChuaTraDoXe(dayStart, dayEnd);
                    string path = @"D:\SPKT\NamBa\OOPR230279_23_1_12\Tuan16\DoanhTHu\DoanhThuDuKien.txt";
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Ngày bắt đầu: " + dayStart);
                        sw.WriteLine("Ngày kết thúc: " + dayEnd);
                        sw.WriteLine("Số tiền dự tính: " + sotienDuTinh.ToString() + " VNĐ");
                        sw.Close();
                    }    
                    MessageBox.Show("Đã xuất dữ liệu vào file DoanhThuDuKien.txt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xuất dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cb_Type.SelectedIndex == 1)
            {
                try
                {
                    string dayStart = this.dtpDayStart.Value.ToString("yyyy-MM-dd");
                    string dayEnd = this.dtpDayEnd.Value.ToString("yyyy-MM-dd");
                    object sotienDaThu = manager.TinhDoanhThuTraDoXe(dayStart, dayEnd);
                    string path = @"D:\SPKT\NamBa\OOPR230279_23_1_12\Tuan16\DoanhTHu\DoanhThuThucTe.txt";
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Ngày bắt đầu: " + dayStart);
                        sw.WriteLine("Ngày kết thúc: " + dayEnd);
                        sw.WriteLine("Số tiền thực tế đã thu: " + sotienDaThu.ToString() + " VNĐ");
                        sw.Close();
                    }
                    MessageBox.Show("Đã xuất dữ liệu vào file DoanhThuThucTe.txt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xuất dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
