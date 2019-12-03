using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DataLayers
{
    public class DBMain
    {
        string ConnectionString = @"Data Source=DESKTOP-UQP5DO6\MRXIX;Initial Catalog=QUANLYNHAHANG;Integrated Security=True";
        //đối tượng kết nối
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable
        SqlDataAdapter da = null;
        //Đối tượng hiển thị dữ liệu lên Form
        DataSet ds = null;
        //Lệnh
        SqlCommand comm = null;
        public DBMain()
        {
            conn = new SqlConnection(ConnectionString);
            comm = conn.CreateCommand();
        }

        public DataSet ExecuteQueryDS(string strsql, CommandType ct, object[] parameter = null)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comm.CommandText = strsql;
            comm.CommandType = ct;
            if (parameter != null)
            {
                string[] listPara = strsql.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        comm.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            comm.Parameters.Clear();
            return ds;
        }

        public bool MyExecuteNonQuery(string strsql, CommandType ct, ref string error, object[] parameter = null)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandType = ct;
            comm.CommandText = strsql;

            if (parameter != null)
            {
                string[] listPara = strsql.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        comm.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }


            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException e)
            {
                error = e.Message;
            }
            finally
            {
                comm.Parameters.Clear();
                conn.Close();
            }
            return f;
        }
    }
}
