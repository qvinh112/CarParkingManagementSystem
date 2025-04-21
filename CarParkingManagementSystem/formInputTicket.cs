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
    public partial class formInputTicket : Form
    {
        Attendant attendant = new Attendant();
        public string IDKH;
        public int flag;

        public formInputTicket(string id, int _fl)
        {
            InitializeComponent();
            IDKH = id;
            flag = _fl;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            string text = "";
            bool ticket = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                lblOpen.Text = "Đã chọn file!";
                try
                {
                    using (StreamReader sr = new StreamReader(open.FileName))
                    {
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            text += line + "\n";
                        }
                    }

                    DataTable dt = attendant.ThongtinVexe(IDKH);

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        if (text.Contains(dt.Rows[0][dt.Columns[i].ColumnName.Trim()].ToString().Trim()) == false)
                        {
                            MessageBox.Show("Vé xe không khớp!");
                            ticket = false;
                            break;
                        }
                    }

                    if (ticket)
                    {
                        MessageBox.Show("Vé khớp thông tin!");

                        if (flag == 0)
                        {
                            formPayment form = new formPayment(IDKH);
                            this.Close();
                            form.ShowDialog();
                        }
                        else
                        {
                            attendant.LayXe(attendant.ViTriDoXe(IDKH).ToString());
                            MessageBox.Show("Lấy xe thành công!");
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Khong the doc du lieu tu file da cho: " + ex.Message);
                }
            }              
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
