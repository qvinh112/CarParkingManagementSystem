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
    public partial class formParkingSpace : Form
    {
        Manager manager = new Manager();
        public formParkingSpace()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                dtgChitietBaidoxe.DataSource = manager.GetNoiDoXe();
                // Đếm số dòng của datagridview để gán cho label
                int num = dtgChitietBaidoxe.Rows.Count;
                this.lb_SoLuongBaiDo.Text = (num - 1).ToString();
                this.lb_SoXeDaTra.Text = manager.GetTraNoiDoXe().ToString();
                if (manager.SoTienDaTra().ToString() == "")
                {
                    this.lb_SoTienDaTra.Text = "0";
                }
                else
                {
                    this.lb_SoTienDaTra.Text = manager.SoTienDaTra().ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể hiển thị dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu cột IDDoXe của dòng hiện tại
            int r = dtgChitietBaidoxe.CurrentCell.RowIndex;
            string id = dtgChitietBaidoxe.Rows[r].Cells[0].Value.ToString();
            formParkingSpaceDetail form = new formParkingSpaceDetail(id);
            form.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formParkingSpaceDetail form = new formParkingSpaceDetail();
            form.ShowDialog();
        }

        private void formParkingSpace_Load(object sender, EventArgs e)
        {
            LoadData();
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
                dt = manager.TimKiemNoiDoXe(txtFind.Text);
                dtgChitietBaidoxe.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // lấy dữ liệu cột IDDoXe của dòng hiện tại
                int r = dtgChitietBaidoxe.CurrentCell.RowIndex;
                string id = dtgChitietBaidoxe.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    if (manager.XoaNoiDoXe(id))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"D:\SPKT\NamBa\OOPR230279_23_1_12\Tuan16\Folder\BaiDo.txt");
                sw.WriteLine("                                                    Danh sách Bãi Đỗ                                                         ");
                sw.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");

                for (int i = 0; i < dtgChitietBaidoxe.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dtgChitietBaidoxe.Columns.Count; j++)
                    {
                        sw.Write(" " + dtgChitietBaidoxe.Rows[i].Cells[j].Value.ToString() + " " + "|");
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
