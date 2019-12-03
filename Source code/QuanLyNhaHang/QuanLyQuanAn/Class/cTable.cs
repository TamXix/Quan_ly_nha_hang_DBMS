using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Class
{
    public class cTable
    {
        private int iD;
        private string name;
        private int iDArea;
        private string status;

        public int ID { get => iD; set => iD = value; }
        public string Status { get => status; set => status = value; }
        public string Name { get => name; set => name = value; }
        public int IDArea { get => iDArea; set => iDArea = value; }

        public cTable(int id, string name, int idarea, string stt)
        {
            this.iD = id;
            this.name = name;
            this.iDArea = idarea;
            this.status = stt;
        }

        public cTable(DataRow row)
        {
            this.iD = Convert.ToInt32(row["IDTABLE"]);
            this.name = row["NAME"].ToString();
            this.iDArea = Convert.ToInt32(row["IDAREA"]);
            this.status = row["STATUS"].ToString();
            int stt = Convert.ToInt32(row["STATUS"]);
            if (stt == 1)
                this.status = "Có người";
            else
                this.status = "Trống";
        }
    }
}
