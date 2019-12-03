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
    public class BLTypeFood
    {
        DBMain db = null;
        public BLTypeFood()
        {
            db = new DBMain();
        }

        public List<cTypeFood> GetListTypeFood()
        {
            List<cTypeFood> lstype = new List<cTypeFood>();
            string query = "EXEC GetListFoodType";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                cTypeFood type = new cTypeFood(item);
                lstype.Add(type);
            }
            return lstype;
        }
        public bool AddFoodType( string typename, int idsup,  ref string err)
        {
            err = "";
            string query = "EXEC AddFoodType @NewName , @idsup";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { typename, idsup });
        }
        public bool UpdateFoodType(int idtype, string typename, int idsup, ref string err)
        {
            err = "";
            string query = "EXEC UpdateFoodType @IdType , @NewName , @idsup";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idtype, typename, idsup });
        }
        public bool DeleteFoodType(int idtype, ref string err)
        {
            err = "";
            string query = "EXEC DeleteFoodType @IdType";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idtype });
        }

    }
}
