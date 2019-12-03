using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Class
{
    public class cTypeFood
    {
        private int iDType;
        private string typeName;
        private int idSup;
        private string supName;

        public int IDType { get => iDType; set => iDType = value; }
        public string TypeName { get => typeName; set => typeName = value; }
        public int IdSup { get => idSup; set => idSup = value; }
        public string SupName { get => supName; set => supName = value; }

        public cTypeFood(int id, string typename)
        {
            this.iDType = id;
            this.typeName = typename;
        }
        public cTypeFood(DataRow row)
        {
            this.iDType = Convert.ToInt32(row["IDTYPE"]);
            this.typeName = row["TYPENAME"].ToString();
            this.idSup = Convert.ToInt32(row["IDSUPPLIER"]);
            this.supName = row["SUPNAME"].ToString();
        }

    }
}
