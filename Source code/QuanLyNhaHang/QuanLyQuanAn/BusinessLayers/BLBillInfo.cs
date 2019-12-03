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
    public class BLBillInfo
    {
        DBMain db = null;
        public BLBillInfo()
        {
            db = new DBMain();
        }

        public List<cBillInfo> GetListBillInfo(int idbill)
        {
            List<cBillInfo> ls = new List<cBillInfo>();
            DataSet ds = db.ExecuteQueryDS("SELECT * FROM dbo.BILLINFO WHERE IDBILL = " + idbill, CommandType.Text);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                cBillInfo billinfo = new cBillInfo(item);
                ls.Add(billinfo);
            }
            return ls;
        }
        public bool InsertBillInfo(int idbill, int idfood, int count, ref string err)
        {
            err = "";
            string query = "EXEC InsertBillInfo @idbill , @idfood , @count";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idbill, idfood, count });
        }

        public int GetCountByIDFood(int idfood, int idbill)
        {
            int count = 0;
            string query = "EXEC GetCountByIDFood @idfood , @idbill";

            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text, new object[] { idfood, idbill });
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            try
            {
                count = Convert.ToInt32(dt.Rows[0]["COUNT"]);
            }
            catch
            {
                count = 0;
            }
            return count;
        }
        public bool DeleteBillInfo(int idbill, int idfood, ref string err)
        {
            string query = "EXEC DeleteBillInfo @idbill , @idfood";
            err = "";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idbill, idfood });
        }
        public bool UpdateCount(int idbill, int idfood, int count, ref string err)
        {
            string query = "EXEC UpdateCount @idbill , @idfood , @count";
            err = "";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idbill, idfood, count });
        }

        public bool ChuyenBillInfo(int idsrcbill, int iddesbill, ref string err)
        {
            string query = "UPDATE BILLINFO SET IDBILL = " + iddesbill + " WHERE IDBILL = " + idsrcbill;
            err = "";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }

    }
}
