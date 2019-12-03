using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Class
{
    public class cBill
    {
        private int iDBill;
        private DateTime? dateCome;
        private DateTime? dateLease;
        private int iDTable;
        private int status;
        private double? totalPrice;

        public int IDBill { get => iDBill; set => iDBill = value; }
        public int IDTable { get => iDTable; set => iDTable = value; }
        public DateTime? DateCome { get => dateCome; set => dateCome = value; }
        public DateTime? DateLease { get => dateLease; set => dateLease = value; }
        public int Status { get => status; set => status = value; }
        public double? TotalPrice { get => totalPrice; set => totalPrice = value; }

        public cBill(int id, DateTime? dcome, DateTime? dlease, int idtable, int status)
        {
            this.iDBill = id;
            this.dateCome = dcome;
            this.dateLease = dlease;
            this.iDTable = idtable;
            this.Status = status;
        }
        public cBill(DataRow row)
        {
            this.IDTable = (int)row["IDTABLE"];
            this.Status = (int)row["STATUS"];
            this.iDBill = (int)row["IDBILL"];
            this.dateCome = (DateTime?)row["DATECOME"];
            this.dateLease = (DateTime?)row["DATELEASE"];
        }
    }
}
