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
    public class BLTableFood
    {
        DBMain db = null;
        public BLTableFood()
        {
            db = new DBMain();
        }

        public List<cTable> LayDanhSachbBanAn()
        {
            List<cTable> tbl = new List<cTable>();
            DataSet ds = db.ExecuteQueryDS("EXEC GetListTable", CommandType.Text);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                cTable tb = new cTable(item);

                tbl.Add(tb);
            }
            return tbl;
        }

        public DataTable GetTableInfo()
        {
            DataSet ds = db.ExecuteQueryDS("EXEC GetTableInfo", CommandType.Text);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            return dt;
        }

        public bool CheckOutTable(int idtable, ref string err)
        {
            string query = "EXEC CheckOutTable @id";
            err = "";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idtable });
        }
        public bool ClearTable(int idtable, ref string err)
        {
            string query = "EXEC ClearTable @id";
            err = "";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idtable });
        }
        public bool AddTable(string name, int idarea, ref string err)
        {
            err = "";
            string query = "EXEC AddTable @name , @id";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { name, idarea });
        }
        public bool DeleteTable(int idtalbe, ref string err)
        {
            err = "";
            string query = "EXEC DeleteTable @id";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idtalbe });
        }
        public bool UpdateTable(int idtable, string newname, int newidarea, ref string err)
        {
            err = "";
            string query = "EXEC UpdateTable @id , @name , @idarea";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idtable, newname, newidarea });
        }
    }
}
