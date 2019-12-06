using QuanLyQuanAn.DataLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.BusinessLayers
{
    public class BLBill
    {
        DBMain db = null;
        public BLBill()
        {
            db = new DBMain();
        }

        public int GetUnCheckBillID(int idtable)
        {
            DataSet ds = db.ExecuteQueryDS("EXEC GetUnpaidBillID @idtable", CommandType.Text, new object[] { idtable });
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                //cBill bill = new cBill(row);
                return Convert.ToInt32(row["IDBILL"]);
            }
            return -1;
        }
        public bool InSertBill(int IDtable, string username, ref string err)
        {
            err = "";
            string query = "EXEC InSertBill @idtable ,  @username";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { IDtable, username });
        }
        public int GetMaxIDBill()
        {
            int max = -1;
            string query = "EXEC GetMaxIDBill";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            max = Convert.ToInt32(dt.Rows[0]["idbill"]);
            return max;
        }

        public DataTable ThongKe(DateTime Dfrom, DateTime Dto, string colname, bool isA)
        {
            string query = "EXEC ThongKe @datefrom , @dateto , @colname , @isA";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text, new object[] { Dfrom, Dto, colname, isA });
            return ds.Tables[0];
        }
        public bool Pay(int idbill, int idtable, int idvoucher, int giamgia, double tongtien, ref string err)
        {
            err = "";
            string query = "EXEC Pay @idbill , @idtable , @idvouher , @giamgia , @tongtien";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idbill, idtable, idvoucher, giamgia, tongtien });
        }

        public bool GopBan(int idtable1, int idtable2, string user, ref string err)
        {
            err = "";
            string query = "EXEC GopBan @idtable1 , @idtable2 , @user";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idtable1, idtable2, user });

        }
        public DataTable BillDetails(int idbill)
        {
            string query = "EXEC BillDetails @idbill";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text, new object[] { idbill });
            return ds.Tables[0];
        }
    }
}
