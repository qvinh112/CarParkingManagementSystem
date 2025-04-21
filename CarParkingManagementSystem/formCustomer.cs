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
    public partial class formCustomer : Form
    {
        Manager manager = new Manager();
        public formCustomer()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                this.dtgChitietCanhan.DataSource = manager.GetAllThongTinCaNhan();
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Khách hàng. Lỗi rồi!!!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu cột ID của dòng hiện tại
            int r = dtgChitietCanhan.CurrentCell.RowIndex;
            string id = dtgChitietCanhan.Rows[r].Cells[0].Value.ToString();
            formCustomerDetail form = new formCustomerDetail(id);
            form.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formCustomerDetail form = new formCustomerDetail();
            form.ShowDialog();
        }

        private void formCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // lấy dữ liệu cột ID của dòng hiện tại
                int r = dtgChitietCanhan.CurrentCell.RowIndex;
                string id = dtgChitietCanhan.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    manager.XoaThongTinCaNhan(id);
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa dữ liệu!");
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa dữ liệu này!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = manager.TimKiemThongTinCaNhan(txtFind.Text);
                dtgChitietCanhan.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"D:\SPKT\NamBa\OOPR230279_23_1_12\Tuan16\Folder\KhachHang.txt");
                sw.WriteLine("                                                    Danh sách Khách hàng                                                        ");
                sw.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");

                for (int i = 0; i < dtgChitietCanhan.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dtgChitietCanhan.Columns.Count; j++)
                    {
                        sw.Write(" " + dtgChitietCanhan.Rows[i].Cells[j].Value.ToString() + " " + "|");
                    }
                    sw.WriteLine("");
                    sw.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                }
                sw.Close();

                MessageBox.Show("Đã in danh sách!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("In thất bại!\n" + ex.Message);
            }
        }
    }
}
