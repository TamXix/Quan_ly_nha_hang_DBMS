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
    class BLWork
    {
        DBMain db = null;
        public BLWork()
        {
            db = new DBMain();
        }
        public bool AddWork(string name, int luong, ref string err)
        {
            err = "";
            string query = "EXEC AddWork @name , @luong";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { name, luong });
        }
        public bool DeleteWork(int id, ref string err)
        {
            err = "";
            string query = "EXEC DeleteWork @id";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { id });
        }
        public bool UpdateWork(int id, string name, int luong, ref string err)
        {
            err = "";
            string query = "EXEC UpdateWork @id , @name , @luong";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { id, name, luong});

        }
        public List<cWork> GetListWork()
        {
            List<cWork> lstwork = new List<cWork>();
            string query = "EXEC GetListWork";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text);
            DataTable dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                cWork work = new cWork(item);
                lstwork.Add(work);
            }
            return lstwork;
        }
        public DataTable GetListEmployeeByIdWork(int idwork)
        {
            string query = "EXEC GetListEmployeeByIdWork @idwork";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text, new object[] { idwork });
            DataTable dt = ds.Tables[0];
            return dt;
        }
        public DataTable GetListEmployeeByShift(int calam)
        {
            string query = "EXEC GetListEmployeeByShift @calam";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text, new object[] { calam });
            DataTable dt = ds.Tables[0];
            return dt;
        }
    }
}
