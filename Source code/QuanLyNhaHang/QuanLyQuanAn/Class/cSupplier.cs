using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Class
{
    public class cSupplier
    {
        private int iD;
        private string name;
        private string phoneNumber;
        private string address;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }

        public cSupplier(DataRow row)
        {
            try
            {
                this.name = row["SUPNAME"].ToString();
                this.iD = Convert.ToInt32(row["IDSUP"]);
                this.phoneNumber = row["PHONENUMBER"].ToString();
                this.address = row["ADDRESS"].ToString();
            }
            catch { };
        }
        public cSupplier()
        { }
    }
}
