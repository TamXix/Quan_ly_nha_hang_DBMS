using QuanLyQuanAn.BusinessLayers;
using QuanLyQuanAn.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn.PresentationLayer
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
            ShowBill();
            string tennv = frmQuanLy.Account.Ten;
            BLBill bill = new BLBill();
            lbsohoadon.Text = bill.GetUnCheckBillID(frmQuanLyBanAn.IDTABLE).ToString();
            lbtennv.Text = tennv;
            btnxacnhan.Focus();
        }
        void ShowBill()
        {
            lwMonDaChon.Items.Clear();
            double TotalPrice = 0;
            foreach (cMenu item in frmQuanLyBanAn.lsMenu)
            {
                ListViewItem lwitem = new ListViewItem(item.Foodname);
                lwitem.SubItems.Add(item.Price.ToString());
                lwitem.SubItems.Add(item.Count.ToString());
                lwitem.SubItems.Add(item.TotalPrice.ToString());
                TotalPrice += item.TotalPrice;
                lwMonDaChon.Items.Add(lwitem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            lbtongtien.Text = TotalPrice.ToString("c", culture);

            int giamgia = frmQuanLyBanAn.GiamGia;
            lbgiamgia.Text = giamgia.ToString() + "%";
            double tientra = TotalPrice - (TotalPrice * giamgia / 100);
            lbtientra.Text = tientra.ToString("c", culture);
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            frmQuanLyBanAn.XacNhan = true;
            this.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            frmQuanLyBanAn.XacNhan = false;
            this.Close();
        }
    }
}
