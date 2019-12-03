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
    public class BLVoucher
    {
        DBMain db = null;
        public BLVoucher()
        {
            db = new DBMain();
        }
        public int GetValueSale(string code)
        {
            int value = 0;
            string query = "EXEC GetValueSale @code";

            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text, new object[] { code });
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            try
            {
                value = Convert.ToInt32(dt.Rows[0]["VALUE"]);
            }
            catch
            {
                value = 0;
            }
            return value;
        }

        public cVoucher GetVoucher(string code)
        {
            string query = "EXEC GetVoucher @code";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text, new object[] { code });
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            cVoucher vc = null;
            try
            {
                vc = new cVoucher(dt.Rows[0]);
            }
            catch { }
            return vc;
        }

        public bool InsertVoucher(string code, string name, int giatri, DateTime ngayhethan, ref string err)
        {
            err = "";
            string query = "EXEC InsertVoucher @code , @name , @value , @hethan";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { code, name, giatri, ngayhethan });
        }
        public bool DeleteVoucher(int id, ref string err)
        {
            err = "";
            string query = "EXEC DeleteVoucher @id";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { id });
        }
        public bool UpdateVoucher(int id, string code, string name, int giatri, DateTime ngayhethan, ref string err)
        {
            err = "";
            string query = "EXEC EditVoucher @id , @code , @name , @giatri , @ngayhethan";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { id, code, name, giatri, ngayhethan });

        }
        public DataTable GetListVoucher()
        {
            string query = "SELECT * FROM VOUCHER";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text);
            return ds.Tables[0];
        }

        public string GetNameVoucherFromBill(int idbill)
        {
            string query = "EXEC GetNameVoucher @id";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text, new object[] { idbill });
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            return dt.Rows[0]["NAME"].ToString();
        }
    }
}