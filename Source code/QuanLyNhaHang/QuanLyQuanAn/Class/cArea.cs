using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Class
{
    public class cArea
    {
        private int iD;
        private string name;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }

        public cArea(int id, string name)
        {
            this.iD = id;
            this.name = name;
        }

        public cArea(DataRow row)
        {
            this.iD = Convert.ToInt32(row["IDAREA"]);
            this.name = row["NAME"].ToString();
        }
    }

}
