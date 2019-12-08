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
        private string ColName;
        private bool isAscending = true;
        public frmThongKe()
        {
            InitializeComponent();
            bill = new BLBill();
            voucher = new BLVoucher();
            nhanvien = new BLNhanVien();
            ColName = "IDBILL";
            LoadDatetime();
            LoadData();
        }
        private void LoadData()
        {
            dgvthongke.DataSource = bill.ThongKe(datefrom.Value, dateto.Value, ColName, isAscending);
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
                tbxten.ResetText();
                tbxvoucher.ResetText();
                int r = dgvthongke.CurrentCell.RowIndex;
                int idbill = (int)dgvthongke.Rows[r].Cells[0].Value;
                dgvdetails.DataSource = bill.BillDetails(idbill);
                tbxten.Text = nhanvien.GetNameEmployeeFromBill(idbill);
                tbxvoucher.Text = voucher.GetNameVoucherFromBill(idbill);
            }
            catch { }
        }

        private void sidbill_Click(object sender, EventArgs e)
        {
            ColName = "IDBILL";
            LoadData();
            isAscending = !isAscending;
        }

        private void stenban_Click(object sender, EventArgs e)
        {
            ColName = "tenban";
            LoadData();
            isAscending = !isAscending;

        }

        private void skhuvuc_Click(object sender, EventArgs e)
        {
            ColName = "khuvuc";
            LoadData();
            isAscending = !isAscending;
        }

        private void sdenluc_Click(object sender, EventArgs e)
        {
            ColName = "tgden";
            LoadData();
            isAscending = !isAscending;
        }

        private void sgiamgia_Click(object sender, EventArgs e)
        {
            ColName = "DISCOUNT";
            LoadData();
            isAscending = !isAscending;

        }

        private void stongtien_Click(object sender, EventArgs e)
        {
            ColName = "TOTAL";
            LoadData();
            isAscending = !isAscending;

        }
    }
}
