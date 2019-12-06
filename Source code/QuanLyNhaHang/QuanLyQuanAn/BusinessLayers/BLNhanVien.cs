using QuanLyQuanAn.Class;
using QuanLyQuanAn.DataLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.BusinessLayers
{
    public class BLNhanVien
    {
        DBMain db = null;
        public BLNhanVien()
        {
            db = new DBMain();
        }
        public DataTable GetListEmployee(string namecol, bool isAscending)
        {
            string query = "EXEC GetListImployee @namecol , @isA";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text, new object[] { namecol, isAscending });
            return ds.Tables[0];
        }
        public List<cNhanVien> GetlistNV()
        {
            List<cNhanVien> lst = new List<cNhanVien>();
            string query = "EXEC GetListEMP";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow item in dt.Rows)
            {
                cNhanVien nv = new cNhanVien(item);
                lst.Add(nv);
            }
            return lst;

        }
        public bool AddNhanVien(string name, string gioitinh, DateTime ngaysinh, string cmnd, string diachi, string sdt, int idcongviec, int ca,  DateTime ngaybd, int tienthuong, ref string err)
        {
            string query = "EXEC AddEmployee @ten , @gioitinh , @ngaysinh , @cmnd , @diachi , @sdt , @idcongviec , @calam , @ngaybd , @tienthuong";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { name, gioitinh, ngaysinh, cmnd, diachi, sdt, idcongviec, ca, ngaybd, tienthuong });
        }
        public bool UpdateNhanvien(int id, string name, string gioitinh, DateTime ngaysinh, string cmnd, string diachi, string sdt, int idcongviec, int ca, DateTime ngaybd, int tienthuong, ref string err)
        {

            string query = "EXEC UpdateEmployee @id , @ten , @gioitinh , @ngaysinh , @cmnd , @diachi , @sdt , @idcongviec , @calam , @ngaybd , @tienthuong";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] {id, name, gioitinh, ngaysinh, cmnd, diachi, sdt, idcongviec, ca, ngaybd, tienthuong });
        }
        public bool DeleteNhanVien(int id, ref string err)
        {
            string query = "EXEC DeleteEmployee @id" + id;
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { id });
        }

        public string GetNameEmployeeFromBill(int idbill)
        {
            string query = "EXEC GetNameEmployee @idbill";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text, new object[] { idbill });
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            return dt.Rows[0]["NAME"].ToString();
        }
        public bool UpdateSalary(int idnv, ref string err)
        {
            string query = "EXEC UpdateSalary @idnv";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idnv });
        }
    }
}
