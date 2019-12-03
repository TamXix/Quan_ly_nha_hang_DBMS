using QuanLyQuanAn.DataLayers;
using QuanLyQuanAn.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.BusinessLayers
{
    public class BLAccount
    {
        DBMain db = null;
        public BLAccount()
        {
            db = new DBMain();
        }
        public cAccount GetAccount(string username, string pass)
        {
            string query = "EXEC GetAccount @UserName , @PassWord";
            DataSet ds = db.ExecuteQueryDS(query, CommandType.Text, new object[] {username, pass});
            

            if (ds.Tables[0].Rows.Count == 0)
                return null;
            cAccount account = new cAccount(ds.Tables[0].Rows[0]);
            return account;

        }

        public bool ChangeInfo(string username, string oldpass, string newpass, int id,
            string name, string gioitinh, string cmnd, string diachi, string sdt, string ngaysinh, ref string err)
        {
            if (this.GetAccount(username, oldpass) == null)
            {
                err = "Mật khẩu cũ không chính xác!";
                return false;
            }
            string query = "EXEC UpdateInfo @username , @oldpass , @newpass , @id , @name , @gioitinh , @cmnd , @diachi , @sdt , @ngaysinh";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, 
                new object[] { username, oldpass, newpass, id, name, gioitinh, cmnd, diachi, sdt, ngaysinh });
        }
        

        public List<cAccount> GetListAccount()
        {
            List<cAccount> lstAccount = new List<cAccount>();
            string query = "EXEC GetListAccount";
            DataSet ds = db.ExecuteQueryDS(query , CommandType.Text);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                cAccount acc = new cAccount(item);
                lstAccount.Add(acc);
            }

            return lstAccount;
        }
        public bool AddAccount(string username, int id, int type, ref string err)
        {
            string query = "EXEC AddAccount @UserName , @id , @IsAdmin";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { username, id, type });
        }
        public bool ResetPass(string username, ref string err)
        {
            string query = "EXEC ResetPassword @UserName";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { username });
        }
        public bool DeleteAccount(string username, ref string err)
        {
            string q = "EXEC DeleteAccount @UserName";
            return db.MyExecuteNonQuery(q, CommandType.Text, ref err, new object[] { username });
        }
    }
}
