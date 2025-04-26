using CarParkingManagementSystem.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace CarParkingManagementSystem
{
    public partial class formPayment : Form
    {
        Customer customer = new Customer();
        public string IDKH;

        public formPayment(string id)
        {
            InitializeComponent();
            IDKH = id;
        }

        public void LoadData()
        {
            DataTable dt = customer.ThongtinDoxe(IDKH);
            this.txtID.Text = dt.Rows[0]["ID"].ToString();
            this.txtName.Text = dt.Rows[0]["ten"].ToString();
            this.txtBienso.Text = dt.Rows[0]["bienSo"].ToString();
            this.txtNgaydoxe.Text = dt.Rows[0]["ngayDoXe"].ToString();
            this.txtNgaylayxe.Text = dt.Rows[0]["ngayLayXe"].ToString();
            this.txtPhidoxe.Text = dt.Rows[0]["sotien"].ToString();
        }

        private void formPayment_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnInternet_Click(object sender, EventArgs e)
        {
            string soTien = txtPhidoxe.Text.Trim();
            string noiDung = txtBienso.Text.Trim();

            // Thay thông tin bên dưới bằng tài khoản SePay của bạn
            string acc = "LOCSPAY000308452";
            string bank = "ACB";

            // Tạo URL QR
            string qrUrl = $"https://qr.sepay.vn/img?acc={acc}&bank={bank}&amount={soTien}&des={noiDung}";

            // Hiển thị ảnh QR lên PictureBox
            pictureBox.Load(qrUrl);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPhidoxe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBienso_TextChanged(object sender, EventArgs e)
        {

        }
        private string CleanTransactionContent(string content)
        {
            if (string.IsNullOrEmpty(content))
                return "";

            // Chuyển về chữ thường, loại bỏ ký tự đặc biệt
            var cleaned = new string(content
                .ToLower()
                .Where(c => char.IsLetterOrDigit(c)) // chỉ giữ lại chữ & số
                .ToArray());

            return cleaned;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string accountNumber = "LOCSPAY000308452";
            string apiUrl = $"https://my.sepay.vn/userapi/transactions/list?account_number={accountNumber}&limit=10";
            string bearerToken = "FOE8NU31EPPH0KIGPSBV92XOJ0GJY46OHRI9K2VNKUTMZALAJ1ERDRF4ZTMFVDFX";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerToken}");
                    client.DefaultRequestHeaders.Add("Accept", "application/json");

                    var response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(json);

                    if (data == null || data.transactions == null)
                    {
                        MessageBox.Show("Không lấy được dữ liệu từ API hoặc dữ liệu không đúng định dạng.");
                        return;
                    }

                    string amountInput = txtPhidoxe?.Text?.Trim();
                    string desInput = txtBienso?.Text?.Trim();

                    var transactions = ((IEnumerable<dynamic>)data.transactions).ToList(); // chỉ cần dòng này
                    var sortedTransactions = transactions.OrderByDescending(tx => DateTime.Parse((string)tx.transaction_date));

                    foreach (var tx in sortedTransactions)
                    {
                        string amount = tx.amount_in;
                        string content = tx.transaction_content;

                        if (content != null)
                        {
                            string cleanedContent = CleanTransactionContent(content.ToString());

                            string normalizedAmount = amount.Contains('.') ? amount.Split('.')[0] : amount;

                            bool amountMatches = normalizedAmount == amountInput;
                            string cleanedInput = CleanTransactionContent(desInput);
                            bool contentMatches = cleanedContent.Contains(cleanedInput);


                            if (amountMatches && contentMatches)
                            {
                                MessageBox.Show("✅ Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }

                    MessageBox.Show("❌ Chưa thấy giao dịch phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi gọi API!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Chi tiết lỗi: " + ex.Message);
                }
            }
        }
    }
}
