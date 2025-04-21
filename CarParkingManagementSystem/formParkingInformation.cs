using CarParkingManagementSystem.Properties;
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
    public partial class formParkingInformation : Form
    {
        Customer customer = new Customer();
        public string IDKH;

        public formParkingInformation(string id)
        {
            InitializeComponent();
            IDKH = id;
        }

        public void LoadData()
        {
            DataTable dt = customer.ThongtinDoxe(IDKH);
            if (dt.Rows.Count > 0 )
            {
                this.lblID.Text = dt.Rows[0]["ID"].ToString();
                this.lblName.Text = dt.Rows[0]["ten"].ToString();
                this.lblAge.Text = dt.Rows[0]["tuoi"].ToString();
                this.lblSDT.Text = dt.Rows[0]["sdt"].ToString();
                this.lblAddress.Text = dt.Rows[0]["diachi"].ToString();
                this.lblBienso.Text = dt.Rows[0]["bienSo"].ToString();
                this.lblNgaydoxe.Text = dt.Rows[0]["ngayDoXe"].ToString();
                this.lblNgaylayxe.Text = dt.Rows[0]["ngayLayXe"].ToString();
                this.lblPhidoxe.Text = dt.Rows[0]["sotien"].ToString() + "đ";
            }
            else
            {
                this.lblID.Text = "";
                this.lblName.Text = "";
                this.lblAge.Text = "";
                this.lblSDT.Text = "";
                this.lblAddress.Text = "";
                this.lblBienso.Text = "";
                this.lblNgaydoxe.Text = "";
                this.lblNgaylayxe.Text = "";
                this.lblPhidoxe.Text = "0đ";
                btnRetrieve.Enabled = false;
            }
        }

        private void formParkingInformation_Load(object sender, EventArgs e)
        {
            parkingLot();
            LoadData();
        }

        private void parkingLot()
        {
            object IDspace = null;
            if (NullReferenceException.Equals(customer.ViTriDoXe(IDKH), IDspace))
                parked.IDSpace = "IDSpace";
            else
                parked.IDSpace = customer.ViTriDoXe(IDKH).ToString();
            parked.Icon = Resources.car;
            parked.IconBg = Color.Gainsboro;            
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            formInputTicket form = new formInputTicket(IDKH, 0);
            form.ShowDialog(); // Mở form lấy vé
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            parkingLot();
        }
    }
}
