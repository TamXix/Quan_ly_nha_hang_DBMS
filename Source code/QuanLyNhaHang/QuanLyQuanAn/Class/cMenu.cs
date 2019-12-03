using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Class
{
    public class cMenu
    {
        private string foodname;
        private int count;
        private double price;
        private double totalPrice;

        public string Foodname { get => foodname; set => foodname = value; }
        public int Count { get => count; set => count = value; }
        public double Price { get => price; set => price = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }

        public cMenu(string name, double gia, int sl)
        {
            this.foodname = name;
            this.price = gia;
            this.count = sl;
            this.totalPrice = 0;
        }
        public cMenu(DataRow row)
        {
            this.foodname = row["FOODNAME"].ToString();
            this.price = Convert.ToDouble(row["PRICE"]);
            this.count = Convert.ToInt32(row["COUNT"]);
            this.totalPrice = Convert.ToDouble(row["TOTALPRICE"]);

        }
    }
}
