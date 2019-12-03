using QuanLyQuanAn.BusinessLayers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn.PresentationLayer
{
    public partial class frmThongKe : Form
    {
        BLBill bill;
        BLVoucher voucher;
        BLNhanVien nhanvien;

        public frmThongKe()
        {
            InitializeComponent();
            bill = new BLBill();
            voucher = new BLVoucher();
            nhanvien = new BLNhanVien();
            LoadDatetime();
            LoadData();
        }
        private void LoadData()
        {
            dgvthongke.DataSource = bill.ThongKe(datefrom.Value, dateto.Value);
        }
        private void LoadDatetime()
        {
            DateTime today = DateTime.Now;
            datefrom.Value = new DateTime(today.Year, today.Month, 1);
            dateto.Value = datefrom.Value.AddMonths(1).AddDays(-1);
        }


        private void btnxem_Click_1(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnpre_Click_1(object sender, EventArgs e)
        {
            datefrom.Value = new DateTime(datefrom.Value.Year, datefrom.Value.Month, 1);
            datefrom.Value = datefrom.Value.AddMonths(-1);
            dateto.Value = datefrom.Value.AddMonths(1).AddDays(-1);
            btnxem.PerformClick();

        }

        private void btnnext_Click_1(object sender, EventArgs e)
        {
            datefrom.Value = new DateTime(datefrom.Value.Year, datefrom.Value.Month, 1);
            datefrom.Value = datefrom.Value.AddMonths(1);
            dateto.Value = datefrom.Value.AddMonths(1).AddDays(-1);
            btnxem.PerformClick();

        }

        private void btnchitiet_Click(object sender, EventArgs e)
        {

        }

        private void dgvthongke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvthongke.CurrentCell.RowIndex;
                int idbill = (int)dgvthongke.Rows[r].Cells[0].Value;
                dgvdetails.DataSource = bill.BillDetails(idbill);
                tbxten.Text = nhanvien.GetNameEmployeeFromBill(idbill);
                tbxvoucher.Text = voucher.GetNameVoucherFromBill(idbill);
            }
            catch { }
        }
    }
}
