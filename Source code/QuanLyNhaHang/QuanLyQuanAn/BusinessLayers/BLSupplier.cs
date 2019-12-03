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
    public class BLSupplier
    {
        DBMain db = null;
        public BLSupplier()
        {
            db = new DBMain();
        }

        public List<cSupplier> GetListSupplier()
        {
            List<cSupplier> lst = new List<cSupplier>();
            string query = "EXEC GetListSupplier";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                cSupplier acc = new cSupplier(item);
                lst.Add(acc);
            }

            return lst;
        }

        public bool UpdateSupplier(int idsup, string name, string sdt, string address, ref string err)
        {
            string query = "EXEC UpdateSupplier @idsup , @name , @sdt , @address";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idsup, name, sdt, address});
        }

        public bool AddSupplier(string name, string sdt, string address, ref string err)
        {
            string query = "EXEC AddSupplier @name , @sdt , @address";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { name, sdt, address });
        }

        public bool DeleteSupplier(int id, ref string err)
        {
            string query = "EXEC DeleteSupplier @id";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { id });
        }
    }
}
