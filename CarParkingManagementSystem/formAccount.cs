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
    public partial class formAccount : Form
    {
        Manager manager = new Manager();
        public formAccount()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                this.dtgAccount.DataSource = manager.GetAllTaiKhoan();
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Tài khoản. Lỗi rồi!!!");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu cột ID của dòng hiện tại
            int r = dtgAccount.CurrentCell.RowIndex;
            string id = dtgAccount.Rows[r].Cells[0].Value.ToString();
            formAccountDetail form = new formAccountDetail(id);
            form.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formAccountDetail form = new formAccountDetail();
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // lấy dữ liệu cột ID của dòng hiện tại
                int r = dtgAccount.CurrentCell.RowIndex;
                string id = dtgAccount.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    manager.XoaTaiKhoan(id);
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtFind.Text == "")
                {
                    LoadData();
                }
                else
                {
                    this.dtgAccount.DataSource = manager.TimKiemTaiKhoan(txtFind.Text);
                }
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Tài khoản. Lỗi rồi!!!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void formAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"D:\SPKT\NamBa\OOPR230279_23_1_12\Tuan16\Folder\TaiKhoan.txt");
                sw.WriteLine("                                                    Danh sách Tài Khoản                                                        ");
                sw.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");

                for (int i = 0; i < dtgAccount.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dtgAccount.Columns.Count; j++)
                    {
                        sw.Write(" " + dtgAccount.Rows[i].Cells[j].Value.ToString() + " " + "|");
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
