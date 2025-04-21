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

namespace CarParkingManagementSystem
{
    public partial class formAttendantMain : Form
    {
        Attendant attendant = new Attendant();
        public string ID;

        public formAttendantMain(string id)
        {
            InitializeComponent();
            ID = id;
        }

        public void openChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void LoadData()
        {
            btnUser.Text = "           " + attendant.GetNameCustomer(ID).ToString();
        }

        private void formAttendantMain_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.btnRestoreDown.Visible = true;
                this.btnMaximize.Visible = false;
            }
            else
            {
                this.btnRestoreDown.Visible = false;
                this.btnMaximize.Visible = true;
            }

            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.btnRestoreDown.Visible = true;
            this.btnMaximize.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnRestoreDown_Click(object sender, EventArgs e)
        {
            this.btnRestoreDown.Visible = false;
            this.btnMaximize.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBaidoxe_Click(object sender, EventArgs e)
        {
            btnUser.BackColor = Color.DarkSlateGray;
            btnBaidoxe.BackColor = Color.Firebrick;
            btnKhachhang.BackColor = Color.DarkSlateGray;

            openChildForm(new formParkingLot(ID, 1));
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            btnUser.BackColor = Color.DarkSlateGray;
            btnBaidoxe.BackColor = Color.DarkSlateGray;
            btnKhachhang.BackColor = Color.Firebrick;

            openChildForm(new formCustomerOfAttendant(ID));
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            btnUser.BackColor = Color.Firebrick;
            btnBaidoxe.BackColor = Color.DarkSlateGray;
            btnKhachhang.BackColor = Color.DarkSlateGray;

            formUserAttendant form = new formUserAttendant(ID);
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            formLogin form = new formLogin();
            this.Hide();
            form.ShowDialog();
        }
    }
}
