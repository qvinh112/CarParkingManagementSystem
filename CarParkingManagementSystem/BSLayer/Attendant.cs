using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarParkingManagementSystem.DBLayer;

namespace CarParkingManagementSystem.BSLayer
{
    public class Attendant
    {
        Connector db = new Connector();
        public Attendant() { }

        public object GetNameCustomer(string ID)
        {
            object dt;
            string sql = string.Format("select ten from ThongTinCaNhan where ID = '{0}'", ID);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                dt = table.Rows[0]["ten"];
            }
            else
            {
                dt = null;
            }
            return dt;
        }

        public bool DoXe(string IDDoXe, string IDKH, string trangthai)
        {
            string sql = string.Format("update NoiDoXe set trangthai = '{0}', IDNguoiDung = '{1}' where IDDoXe = '{2}'", trangthai, IDKH, IDDoXe);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public DataTable User(string ID)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select ID, ten, tuoi, diachi, sdt from ThongTinCaNhan where ID = '" + ID + "'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public bool SuaThongTinCaNhan(string ID, string ten, string tuoi, string sdt, string diachi)
        {
            string sql = string.Format("update ThongTinCaNhan set ten = '{0}', tuoi = '{1}', sdt = '{2}', diachi = '{3}' where ID = '{4}'", ten, tuoi, sdt, diachi, ID);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public DataTable user_pass(string ID)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select username, password from TaiKhoan where ID = '" + ID + "'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetAllThongTinCaNhan(string IDNV)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT ttcn.* FROM ThongTinCaNhan ttcn JOIN TaiKhoan tk ON ttcn.ID = tk.ID JOIN NoiDoXe dx ON ttcn.ID = dx.IDNguoiDung WHERE tk.vaiTro = 'nguoidung' and dx.IDNhanVien = '" + IDNV + "'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable TimKiemThongTinCaNhan(string IDNV, string keyword)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT ttcn.* FROM ThongTinCaNhan ttcn JOIN TaiKhoan tk ON ttcn.ID = tk.ID JOIN NoiDoXe dx ON ttcn.ID = dx.IDNguoiDung WHERE tk.vaiTro = 'nguoidung' and dx.IDNhanVien = '" + IDNV + "' AND (ttcn.ID LIKE '%" + keyword + "%' OR  	ttcn.bienSo LIKE '%" + keyword + "%' OR       ttcn.ten LIKE '%" + keyword + "%' OR       ttcn.tuoi LIKE '%" + keyword + "%' OR       ttcn.sdt LIKE '%" + keyword + "%' OR       ttcn.bienSo LIKE '%" + keyword + "%' 	  )", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable ThongtinDoxe(string IDKH)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select ID, ten, tuoi, diachi, sdt, bienSo, ngayDoXe, ngayLayXe, DX.sotien from ThongTinCaNhan CN inner join NoiDoXe DX on CN.ID = DX.IDNguoiDung where CN.ID = '" + IDKH + "'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable ThongtinVexe(string IDKH)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select ID, ten, bienSo, ngayDoXe, ngayLayXe, DX.sotien from ThongTinCaNhan CN inner join NoiDoXe DX on CN.ID = DX.IDNguoiDung where CN.ID = '" + IDKH + "'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public object ViTriDoXe(string ID)
        {
            object dt;
            string sql = string.Format("select IDDoxe from NoiDoXe where IDNguoiDung = '{0}'", ID);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                dt = table.Rows[0]["IDDoxe"];
            }
            else
            {
                dt = null;
            }
            return dt;
        }

        public bool LayXe(string IDDoXe)
        {
            string sql = string.Format("update NoiDoXe set IDNguoiDung = null, trangthai = 'trong' where IDDoXe = '{0}'", IDDoXe);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
    }
}
