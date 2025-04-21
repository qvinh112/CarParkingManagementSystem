using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarParkingManagementSystem.DBLayer;

namespace CarParkingManagementSystem.BSLayer
{
    public class Manager
    {
        Connector db = new Connector();
        public Manager() { }
        public DataTable GetNoiDoXe()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from NoiDoXe", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable GetNoiDoXeByID(string ID)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from NoiDoXe where IDDoXe = '" + ID + "'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public object GetTraNoiDoXe()
        {
            object dt;
            //SELECT COUNT(*) AS SoLuong FROM NoiDoXe WHERE trangthai<> 'trong'
            string sql = string.Format("SELECT COUNT(*) AS SoLuong FROM NoiDoXe WHERE trangthai = 'tra'");
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                dt = table.Rows[0]["SoLuong"];
            }
            else
            {
                dt = null;
            }
            return dt;
        }
        public object SoTienDaTra()
        {
            object dt;
            //SELECT SUM(CAST(sotien AS INT)) AS TongSoTienDaTra FROM NoiDoXe WHERE trangthai = 'trong'
            string sql = string.Format("SELECT SUM(CAST(sotien AS INT)) AS SoTien FROM NoiDoXe WHERE trangthai = 'tra'");
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                dt = table.Rows[0]["SoTien"];
            }
            else
            {
                dt = null;
            }
            return dt;
        }
        public DataTable TimKiemNoiDoXe(string keyword)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from NoiDoXe where IDDoXe like '%" + keyword + "%' or  IDNguoiDung like '%" + keyword + "%' or trangthai like '%" + keyword + "%' or sotien like '%" + keyword + "%'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool ThemNoiDoXe(string IDDoXe, string IDNguoiDung, string IDNhanVien, string trangthai, string sotien)
        {
            string sql = string.Format("insert into NoiDoXe(IDDoXe, IDNguoiDung, IDNhanVien, trangthai, sotien) values('{0}', '{1}', '{2}', '{3}', '{4}')", IDDoXe, IDNguoiDung, IDNhanVien, trangthai, sotien);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
        public bool SuaNoiDoXe(string IDDoXe, string IDNguoiDung, string IDNhanVien, string trangthai, string sotien)
        {
            string sql = string.Format("update NoiDoXe set IDNguoiDung = '{0}', IDNhanVien = '{1}', trangthai = '{2}', sotien = '{3}' where IDDoXe = '{4}'", IDNguoiDung, IDNhanVien, trangthai, sotien, IDDoXe);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
        public bool XoaNoiDoXe(string IDDoXe)
        {
            string sql = string.Format("delete from NoiDoXe where IDDoXe = '{0}'", IDDoXe);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public DataTable GetAllThongTinCaNhan()
        {
            DataTable dt = new DataTable();
            // SELECT ttcn.* FROM ThongTinCaNhan ttcn JOIN TaiKhoan tk ON ttcn.ID = tk.ID WHERE tk.vaiTro = 'nguoidung'
            SqlCommand cmd = new SqlCommand("SELECT ttcn.* FROM ThongTinCaNhan ttcn JOIN TaiKhoan tk ON ttcn.ID = tk.ID WHERE tk.vaiTro = 'nguoidung'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable GetThongTinCaNhanByID(string ID)
        {
            DataTable dt = new DataTable();
            // SELECT ttcn.* FROM ThongTinCaNhan ttcn JOIN TaiKhoan tk ON ttcn.ID = tk.ID WHERE ttcn.ID = 'KH001' AND tk.vaiTro = 'nguoidung'
            SqlCommand cmd = new SqlCommand("SELECT ttcn.* FROM ThongTinCaNhan ttcn JOIN TaiKhoan tk ON ttcn.ID = tk.ID WHERE ttcn.ID = '" + ID + "' AND tk.vaiTro = 'nguoidung'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable TimKiemThongTinCaNhan(string keyword)
        {
            DataTable dt = new DataTable();
            // SELECT ttcn.* FROM ThongTinCaNhan ttcn JOIN TaiKhoan tk ON ttcn.ID = tk.ID WHERE tk.vaiTro = 'nguoidung' AND (ttcn.ID LIKE '%25%' OR  	ttcn.bienSo LIKE '%25%' OR       ttcn.ten LIKE '%25%' OR       ttcn.tuoi LIKE '%25%' OR       ttcn.sdt LIKE '%25%' OR       ttcn.bienSo LIKE '%25%' 	  )
            SqlCommand cmd = new SqlCommand("SELECT ttcn.* FROM ThongTinCaNhan ttcn JOIN TaiKhoan tk ON ttcn.ID = tk.ID WHERE tk.vaiTro = 'nguoidung' AND (ttcn.ID LIKE '%" + keyword + "%' OR  	ttcn.bienSo LIKE '%" + keyword + "%' OR       ttcn.ten LIKE '%" + keyword + "%' OR       ttcn.tuoi LIKE '%" + keyword + "%' OR       ttcn.sdt LIKE '%" + keyword + "%' OR       ttcn.bienSo LIKE '%" + keyword + "%' 	  )", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public bool ThemThongTinCaNhan(string ID, string ten, string tuoi, string sdt, string diachi, string bienSo, string ngayDoXe, string ngayLayXe, string sotien)
        {
            string username = GenerateRandomString("username_", 1);
            string password = GenerateRandomString("password_", 3);
            try
            {
                // Mở kết nối
                db.OpenConnection();

                // Bắt đầu transaction
                SqlTransaction transaction = db.GetConnection().BeginTransaction();

                // Thực hiện câu lệnh INSERT vào bảng ThongTinCaNhan
                string sqlThongTinCaNhan = string.Format("insert into ThongTinCaNhan(ID, ten, tuoi, sdt, diachi, bienSo, ngayDoXe, ngayLayXe, sotien) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", ID, ten, tuoi, sdt, diachi, bienSo, ngayDoXe, ngayLayXe, sotien);
                SqlCommand cmdThongTinCaNhan = new SqlCommand(sqlThongTinCaNhan, db.GetConnection(), transaction);
                int resultThongTinCaNhan = cmdThongTinCaNhan.ExecuteNonQuery();

                // Thực hiện câu lệnh INSERT vào bảng TaiKhoan
                string sqlTaiKhoan = string.Format("INSERT INTO TaiKhoan(ID, username, password, vaiTro) VALUES ('{0}', '{1}', '{2}', 'nguoidung')", ID, username, password);
                SqlCommand cmdTaiKhoan = new SqlCommand(sqlTaiKhoan, db.GetConnection(), transaction);
                int resultTaiKhoan = cmdTaiKhoan.ExecuteNonQuery();

                // Kết thúc transaction
                if (resultThongTinCaNhan > 0 && resultTaiKhoan > 0)
                {
                    transaction.Commit();
                    return true;
                }
                else
                {
                    transaction.Rollback();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                // Đóng kết nối
                db.CloseConnection();
            }
        }
        public bool SuaThongTinCaNhan(string ID, string ten, string tuoi, string sdt, string diachi, string bienSo, string ngayDoXe, string ngayLayXe, string sotien)
        {
            string sql = string.Format("update ThongTinCaNhan set ten = '{0}', tuoi = '{1}', sdt = '{2}', diachi = '{3}', bienSo = '{4}', ngayDoXe = '{5}', ngayLayXe = '{6}', sotien = '{7}' where ID = '{8}'", ten, tuoi, sdt, diachi, bienSo, ngayDoXe, ngayLayXe, sotien, ID);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
        public bool XoaThongTinCaNhan(string ID)
        {
            string sql = string.Format("delete from ThongTinCaNhan where ID = '{0}'", ID);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public DataTable GetAllNhanVien()
        {
            DataTable dt = new DataTable();
            // SELECT ttcn.ID,ttcn.ten, ttcn.tuoi, ttcn.diachi, ttcn.sdt FROM ThongTinCaNhan ttcn JOIN TaiKhoan tk ON ttcn.ID = tk.ID WHERE tk.vaiTro = 'nhanvien'
            SqlCommand cmd = new SqlCommand("SELECT ttcn.ID,ttcn.ten, ttcn.tuoi, ttcn.diachi, ttcn.sdt FROM ThongTinCaNhan ttcn JOIN TaiKhoan tk ON ttcn.ID = tk.ID WHERE tk.vaiTro = 'nhanvien'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable GetNhanVienByID(string ID)
        {
            DataTable dt = new DataTable();
            // SELECT ttcn.ID,ttcn.ten, ttcn.tuoi, ttcn.diachi, ttcn.sdt FROM ThongTinCaNhan ttcn JOIN TaiKhoan tk ON ttcn.ID = tk.ID WHERE ttcn.ID = 'NV001' AND tk.vaiTro = 'nhanvien'
            SqlCommand cmd = new SqlCommand("SELECT ttcn.ID,ttcn.ten, ttcn.tuoi, ttcn.diachi, ttcn.sdt FROM ThongTinCaNhan ttcn JOIN TaiKhoan tk ON ttcn.ID = tk.ID WHERE ttcn.ID = '" + ID + "' AND tk.vaiTro = 'nhanvien'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable TimKiemNhanVien(string keyword)
        {
            DataTable dt = new DataTable();
            // SELECT ttcn.ID,ttcn.ten, ttcn.tuoi, ttcn.diachi, ttcn.sdt FROM ThongTinCaNhan ttcn JOIN TaiKhoan tk ON ttcn.ID = tk.ID WHERE tk.vaiTro = 'nhanvien' AND (ttcn.ID LIKE '%25%' OR  	ttcn.ten LIKE '%25%' OR       ttcn.tuoi LIKE '%25%' OR       ttcn.sdt LIKE '%25%' OR       ttcn.diachi LIKE '%25%' 	  )
            SqlCommand cmd = new SqlCommand("SELECT ttcn.ID,ttcn.ten, ttcn.tuoi, ttcn.diachi, ttcn.sdt FROM ThongTinCaNhan ttcn JOIN TaiKhoan tk ON ttcn.ID = tk.ID WHERE tk.vaiTro = 'nhanvien' AND (ttcn.ID LIKE '%" + keyword + "%' OR  	ttcn.ten LIKE '%" + keyword + "%' OR       ttcn.tuoi LIKE '%" + keyword + "%' OR       ttcn.sdt LIKE '%" + keyword + "%' OR       ttcn.diachi LIKE '%" + keyword + "%' 	  )", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool ThemNhanVien(string ID, string ten, string tuoi, string sdt, string diachi)
        {
            // Tạo random user và password 
            string username = GenerateRandomString("username_", 1);
            string password = GenerateRandomString("password_", 3);
            try
            {
                // Mở kết nối
                db.OpenConnection();

                // Bắt đầu transaction
                SqlTransaction transaction = db.GetConnection().BeginTransaction();

                // Thực hiện câu truy vấn thêm nhân viên vào bảng ThongTinCaNhan
                string sqlThongTinCaNhan = string.Format("INSERT INTO ThongTinCaNhan(ID, ten, tuoi, sdt, diachi) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", ID, ten, tuoi, sdt, diachi);
                SqlCommand cmdThongTinCaNhan = new SqlCommand(sqlThongTinCaNhan, db.GetConnection(), transaction);
                int resultThongTinCaNhan = cmdThongTinCaNhan.ExecuteNonQuery();

                // Thực hiện câu truy vấn thêm nhân viên vào bảng TaiKhoan
                string sqlTaiKhoan = string.Format("INSERT INTO TaiKhoan(ID, username, password, vaiTro) VALUES ('{0}', '{1}', '{2}', 'nhanvien')", ID, username, password);
                SqlCommand cmdTaiKhoan = new SqlCommand(sqlTaiKhoan, db.GetConnection(), transaction);
                int resultTaiKhoan = cmdTaiKhoan.ExecuteNonQuery();

                // Kết thúc transaction
                if (resultThongTinCaNhan > 0 && resultTaiKhoan > 0)
                {
                    transaction.Commit();
                    return true;
                }
                else
                {
                    transaction.Rollback();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                // Đóng kết nối
                db.CloseConnection();
            }
        }
        public bool SuaNhanVien(string ID, string ten, string tuoi, string sdt, string diachi)
        {
            string sql = string.Format("update ThongTinCaNhan set ten = '{0}', tuoi = '{1}', sdt = '{2}', diachi = '{3}' where ID = '{4}'", ten, tuoi, sdt, diachi, ID);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
        public bool XoaNhanVien(string ID)
        {
            string sql = string.Format("delete from ThongTinCaNhan where ID = '{0}'", ID);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public DataTable GetAllTaiKhoan()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from TaiKhoan", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable GetTaiKhoanByID(string ID)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from TaiKhoan where ID = '" + ID + "'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable TimKiemTaiKhoan(string keyword)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from TaiKhoan where ID like '%" + keyword + "%' or username like '%" + keyword + "%' or password like '%" + keyword + "%' or vaiTro like '%" + keyword + "%'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool ThemTaiKhoan(string ID, string username, string password, string vaiTro)
        {
            string sql = string.Format("insert into TaiKhoan(ID, username, password, vaiTro) values('{0}', '{1}', '{2}', '{3}')", ID, username, password, vaiTro);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
        public bool SuaTaiKhoan(string ID, string username, string password, string vaiTro)
        {
            string sql = string.Format("update TaiKhoan set username = '{0}', password = '{1}', vaiTro = '{2}' where ID = '{3}'", username, password, vaiTro, ID);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
        public bool XoaTaiKhoan(string ID)
        {
            string sql = string.Format("delete from TaiKhoan where ID = '{0}'", ID);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public DataTable GetAllAdminInfo()
        {
            DataTable dt = new DataTable();
            // SELECT ttcn.ID, ttcn.ten, ttcn.tuoi, ttcn.diachi, ttcn.sdt FROM ThongTinCaNhan ttcn JOIN TaiKhoan tk ON ttcn.ID = tk.ID WHERE tk.vaiTro = 'quanli'
            SqlCommand cmd = new SqlCommand("SELECT ttcn.ID, ttcn.ten, ttcn.tuoi, ttcn.diachi, ttcn.sdt FROM ThongTinCaNhan ttcn JOIN TaiKhoan tk ON ttcn.ID = tk.ID WHERE tk.vaiTro = 'quanli'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool SuaAdminInfo(string ID, string ten, string tuoi, string sdt, string diachi)
        {
            string sql = string.Format("update ThongTinCaNhan set ten = '{0}', tuoi = '{1}', sdt = '{2}', diachi = '{3}' where ID = '{4}'", ten, tuoi, sdt, diachi, ID);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
        public bool DoiMatKau(string ID, string oldpassword, string newpassword)
        {
            string sql = string.Format("update TaiKhoan set password = '{0}' where ID = '{1}' and password = '{2}'", newpassword, ID, oldpassword);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
        public object TinhDoanhThuTraDoXe(string ngayBatDau, string ngayKetThuc)
        {
            object dt;
            // SELECT SUM(CONVERT(INT, nx.sotien)) AS TongSoTien FROM NoiDoXe nx JOIN ThongTinCaNhan ttcn ON nx.IDNguoiDung = ttcn.ID WHERE nx.trangthai = 'tra'  AND ttcn.ngayLayXe BETWEEN '2020-01-01' AND '2024-01-31';
            string sql = string.Format("SELECT SUM(CONVERT(INT, nx.sotien)) AS TongSoTien FROM NoiDoXe nx JOIN ThongTinCaNhan ttcn ON nx.IDNguoiDung = ttcn.ID WHERE nx.trangthai = 'tra'  AND ttcn.ngayLayXe BETWEEN '{0}' AND '{1}'", ngayBatDau, ngayKetThuc);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                dt = table.Rows[0]["TongSoTien"];
            }
            else
            {
                dt = null;
            }
            return dt;
        }
        public object TinhDoanhThuChuaTraDoXe(string ngayBatDau, string ngayKetThuc)
        {
            object dt;
            // SELECT SUM(CONVERT(INT, nx.sotien)) AS TongSoTien FROM NoiDoXe nx JOIN ThongTinCaNhan ttcn ON nx.IDNguoiDung = ttcn.ID WHERE nx.trangthai = 'chuatra'  AND ttcn.ngayLayXe BETWEEN '2020-01-01' AND '2024-01-31';
            string sql = string.Format("SELECT SUM(CONVERT(INT, nx.sotien)) AS TongSoTien FROM NoiDoXe nx JOIN ThongTinCaNhan ttcn ON nx.IDNguoiDung = ttcn.ID WHERE nx.trangthai = 'chuatra'  AND ttcn.ngayLayXe BETWEEN '{0}' AND '{1}'", ngayBatDau, ngayKetThuc);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                dt = table.Rows[0]["TongSoTien"];
            }
            else
            {
                dt = null;
            }
            return dt;
        }

        public DataTable GetAllInfoDoXe()
        {
            DataTable dt = new DataTable();
            // SELECT ttcn.ID, ttcn.ten, ttcn.ngayDoXe, ttcn.ngayLayXe, nx.IDDoXe, nx.IDNguoiDung, nx.IDNhanVien, nx.trangthai, nx.sotien FROM ThongTinCaNhan ttcn INNER JOIN NoiDoXe nx ON ttcn.ID = nx.IDNguoiDung;
            SqlCommand cmd = new SqlCommand("SELECT ttcn.ID, ttcn.ten, ttcn.ngayDoXe, ttcn.ngayLayXe, nx.IDDoXe, nx.IDNguoiDung, nx.IDNhanVien, nx.trangthai, nx.sotien FROM ThongTinCaNhan ttcn INNER JOIN NoiDoXe nx ON ttcn.ID = nx.IDNguoiDung", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        static string GenerateRandomString(string prefix, int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();

            // Tạo chuỗi ngẫu nhiên bằng cách chọn ngẫu nhiên các ký tự từ chuỗi chars
            string randomString = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return prefix + randomString;
        }
    }
}
