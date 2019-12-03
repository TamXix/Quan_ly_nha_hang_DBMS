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
    public class BLFood
    {
        DBMain db = null;
        public BLFood()
        {
            db = new DBMain();
        }
        public List<cMenu> GetListMenu(int idtable)
        {
            List<cMenu> listMenu = new List<cMenu>();
            string query = "EXEC GetListOrder @idtable";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text, new object[] { idtable });
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow item in dt.Rows)
            {
                cMenu menu = new cMenu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
        public List<cFood> GetListFood(int IDType)
        {
            List<cFood> lsfood = new List<cFood>();
            string query = "EXEC GetFoodsByIDType @idtype";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text, new object[] { IDType });
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                cFood type = new cFood(item);
                lsfood.Add(type);
            }
            return lsfood;
        }

        public bool AddFood(string foodname,  int idtype, double gia, ref string err)
        {
            err = "";
            string query = "EXEC AddFood @FoodName , @Price , @IdType";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { foodname, gia, idtype });
        }
        public bool UpdateFood(int idfood, string foodname, int idtype, double gia, ref string err)
        {
            err = "";
            string query = "EXEC UpdateFood @IdFood , @NewName , @NewIdType , @NewPrice";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idfood, foodname, idtype, gia });
        }
        public bool DeleteFood(int idfood, ref string err)
        {
            err = "";
            string query = "EXEC DeleteFood @id";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idfood });
        }
        public DataTable GetListFood()
        {
            string query = "EXEC GetListFood";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text);
            return  ds.Tables[0];
        }
        public List<cFood> SearchFood(string name)
        {
            string searchname = "N'%" + name + "%'";
            string query = "EXEC SearchFood @name";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text, new object[] { name });
            DataTable dt = ds.Tables[0];
            List<cFood> lst = new List<cFood>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lst.Add(new cFood(dt.Rows[i]));
            }
            return lst;
        }
        
    }
}
