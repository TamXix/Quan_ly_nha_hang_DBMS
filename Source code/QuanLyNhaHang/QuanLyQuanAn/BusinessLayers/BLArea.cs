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
    public class BLArea
    {
        DBMain db = null;
        public BLArea()
        {
            db = new DBMain();
        }

        public List<cArea> LayDanhSachArea()
        {
            List<cArea> tbl = new List<cArea>();
            DataSet ds = db.ExecuteQueryDS("EXEC GetListArea", CommandType.Text);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                cArea tb = new cArea(item);

                tbl.Add(tb);
            }
            return tbl;
        }
        public bool AddArea(string name, ref string err)
        {
            err = "";
            string query = "EXEC AddArea @name";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { name });
        }
        public bool DeleteArea(int idtalbe, ref string err)
        {
            err = "";
            string query = "EXEC DeleteArea @id";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idtalbe });
        }
        public bool UpdateArea(int idtable, string newname, ref string err)
        {
            err = "";
            string query = "EXEC UpdateArea @id , @name";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idtable, newname });
        }

    }
}
