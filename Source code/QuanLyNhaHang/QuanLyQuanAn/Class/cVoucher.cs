using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Class
{
    public class cVoucher
    {
        private int iD;
        private string code;
        private string name;
        private int value;
        private DateTime startDate;
        private DateTime? expirationDate;

        public int ID { get => iD; set => iD = value; }
        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public int Value { get => value; set => this.value = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime? ExpirationDate { get => expirationDate; set => expirationDate = value; }

        public cVoucher(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.code = row["CODE"].ToString();
            this.name = row["NAME"].ToString();
            this.value = (int)row["VALUE"];
            this.startDate = (DateTime)row["STARTDAY"];
            this.ExpirationDate = (DateTime)row["EXPIRATIONDATE"];

        }
    }
}
