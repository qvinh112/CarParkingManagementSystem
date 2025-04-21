using CarParkingManagementSystem.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingManagementSystem
{
    public partial class formCustomerOfAttendant : Form
    {
        Attendant attendant = new Attendant();
        public string IDNV;

        public formCustomerOfAttendant(string id)
        {
            InitializeComponent();
            IDNV = id;
        }

        public void LoadData()
        {
            try
            {
                this.dtgChitietCanhan.DataSource = attendant.GetAllThongTinCaNhan(IDNV);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Khách hàng. Lỗi rồi!!!");
            }
        }

        private void formCustomerOfAttendant_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = attendant.TimKiemThongTinCaNhan(IDNV, txtFind.Text);
                dtgChitietCanhan.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgChitietCanhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgChitietCanhan.CurrentCell.RowIndex;
            string id = dtgChitietCanhan.Rows[r].Cells[0].Value.ToString();

            formRetrieveCarAttendant form = new formRetrieveCarAttendant(id);
            form.Show();
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"D:\SPKT\NamBa\OOPR230279_23_1_12\Tuan16\Folder\Khachhang_" + IDNV + ".txt");
                sw.WriteLine("                                                    Danh sách khách hàng                                                           ");
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
