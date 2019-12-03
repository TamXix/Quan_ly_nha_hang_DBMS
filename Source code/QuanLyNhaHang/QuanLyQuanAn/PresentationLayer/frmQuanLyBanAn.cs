    using QuanLyQuanAn.BusinessLayers;
using QuanLyQuanAn.Class;
using QuanLyQuanAn.PresentationLayer;
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

namespace QuanLyQuanAn
{
    public partial class frmQuanLyBanAn : Form
    {
        private BLBill bill;
        private BLBillInfo billinfo;
        private BLFood food;
        private BLTypeFood typefood;
        private BLVoucher blvoucher;
        private BLTableFood tablefood;

        public static List<cMenu> lsMenu;
        public static int IDTABLE = -1;
        public static int GiamGia = 0;
        public static int TongTien;
        public static bool XacNhan = false;
        public static double TotalPrice;
        private cVoucher voucher;
        private string error;
        public frmQuanLyBanAn()
        {
            InitializeComponent();
            bill = new BLBill();
            billinfo = new BLBillInfo();
            food = new BLFood();
            typefood = new BLTypeFood();
            blvoucher = new BLVoucher();
            tablefood = new BLTableFood();
            LayBanaAn();
            LoadType();
            //menuStrip1.Hide();
        }
        void LayBanaAn()
        {
            lwbanan.Items.Clear();
            lwbanan2.Items.Clear();
            List<cTable> ltb = tablefood.LayDanhSachbBanAn();
            lwbanan.LargeImageList = imlbanan;
            lwbanan2.LargeImageList = imlbanan;
            foreach (cTable item in ltb)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = item.Name + "\n" + item.Status;
                lv.Tag = item;
                if (item.Status == "Trống")
                    lv.ImageIndex = 0;
                else
                {
                    lv.ImageIndex = 1;
                    lv.BackColor = Color.Red;
                }
                if (item.IDArea == 1)
                    lwbanan.Items.Add(lv);
                else
                    lwbanan2.Items.Add(lv);
            }
            cbxchuyenban.DataSource = ltb;
            cbxchuyenban.DisplayMember = "Name";
        }

        void ShowBill(int IDtable)
        {
            lwMonDaChon.Items.Clear();
            TotalPrice = 0;
            lsMenu = food.GetListMenu(IDtable);
            foreach (cMenu item in lsMenu)
            {
                ListViewItem lwitem = new ListViewItem(item.Foodname);
                lwitem.SubItems.Add(item.Price.ToString());
                lwitem.SubItems.Add(item.Count.ToString());
                lwitem.SubItems.Add(item.TotalPrice.ToString());
                TotalPrice += item.TotalPrice;
                lwMonDaChon.Items.Add(lwitem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            tbxtongtien.Text = TotalPrice.ToString("c", culture);
        }
        private void lwbanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cTable tb = (cTable)lwbanan.SelectedItems[0].Tag;
                int idtable = tb.ID;
                IDTABLE = tb.ID;
                lbsoban.Text = tb.Name;
                ShowBill(idtable);
            }
            catch { }
        }
        void LoadType()
        {
            List<cTypeFood> lsType = typefood.GetListTypeFood();
            cbxdanhmuc.DataSource = lsType;
            cbxdanhmuc.DisplayMember = "TypeName";
        }
        void LoadFood(int IDType)
        {
            List<cFood> lsFood = food.GetListFood(IDType);
            lbxtenmon.DataSource = lsFood;
            lbxtenmon.DisplayMember = "FoodName";

            lbxgia.DataSource = lsFood;
            lbxgia.DisplayMember = "Price";
        }
        private void showErr()
        {
            MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void cbxdanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            cTypeFood select = cb.SelectedItem as cTypeFood;
            id = select.IDType;
            LoadFood(id);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(IDTABLE == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn ăn!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idbill = bill.GetUnCheckBillID(IDTABLE);
            int idfood = (lbxtenmon.SelectedItem as cFood).FoodID;
            int SL = Convert.ToInt32(nmrsoluong.Value);

            if(idbill == -1)
            {
                if (!bill.InSertBill(IDTABLE, frmQuanLy.Account.User, ref error))
                    showErr();
                int idmax = bill.GetMaxIDBill();
                if (!billinfo.InsertBillInfo(idmax, idfood, SL, ref error))
                    showErr();
                if (!tablefood.CheckOutTable(IDTABLE, ref error))
                    showErr();
            }
            else
            {
                int SLchon = billinfo.GetCountByIDFood(idfood, idbill);
                if (SLchon == 0)
                {
                    if (SL > 0)
                    {
                        if (!billinfo.InsertBillInfo(idbill, idfood, SL, ref error))
                            showErr();
                        if (!tablefood.CheckOutTable(IDTABLE, ref error))
                            showErr();
                    }
                }
                else if (SLchon + SL <= 0)
                {
                    if (!billinfo.DeleteBillInfo(idbill, idfood, ref error))
                        showErr();
                }
                else
                {
                    if (!billinfo.UpdateCount(idbill, idfood, SLchon + SL, ref error))
                        showErr();
                    if (!tablefood.CheckOutTable(IDTABLE, ref error))
                        showErr();
                }
            }
            LayBanaAn();
            ShowBill(IDTABLE);
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            int idbill = bill.GetUnCheckBillID(IDTABLE);
            try
            {
                GiamGia = voucher.Value;
            }
            catch { GiamGia = 0; }

            if (idbill != -1)
            {
                frmHoaDon f = new frmHoaDon();
                f.ShowDialog();
                if (XacNhan)
                {
                    XacNhan = false;
                    if(voucher == null)
                    {
                        if (!bill.Pay(idbill, IDTABLE, -1, 0, TotalPrice, ref error))
                        {
                            showErr();
                            return;
                        }
                    }
                    else
                    {
                        if (!bill.Pay(idbill, IDTABLE, voucher.ID, GiamGia, TotalPrice - (TotalPrice * GiamGia / 100), ref error))
                        {
                            showErr();
                            return;
                        }
                    }
                    ShowBill(IDTABLE);
                    LayBanaAn();
                    tbxvoucher.ResetText();
                    lbgiamgia.Text = "0%";
                    GiamGia = 0;
                    voucher = null;
                    MessageBox.Show("Thanh toán thành công!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lbxtenmon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            nmrsoluong.Value = 1;
            btnthem.PerformClick();
        }

        private void btnchuyenban_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                ChuyenBan();
        }
        private void ChuyenBan()
        {
            int srcidbill = bill.GetUnCheckBillID(IDTABLE);
            List<cTable> lst = new List<cTable>();
            lst = tablefood.LayDanhSachbBanAn();
            int idtb = lst[cbxchuyenban.SelectedIndex].ID;
            int desidbill = bill.GetUnCheckBillID(idtb);

            if (srcidbill == desidbill)
                return;
            else if (desidbill == -1)
            {
                if (!bill.InSertBill(idtb, frmQuanLy.Account.User, ref error))
                    showErr();
            }           
            else if (srcidbill == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!bill.GopBan(IDTABLE, idtb, frmQuanLy.Account.User, ref error))
                showErr();

            LayBanaAn();
            ShowBill(desidbill);
        }

        private void btncheckvoucher_Click(object sender, EventArgs e)
        {
            voucher = blvoucher.GetVoucher(tbxvoucher.Text.Trim());
            if(voucher == null)
            {
                MessageBox.Show("Voucher không chính xác!",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxvoucher.ResetText();
                return;
            }
            lbgiamgia.Text = voucher.Value.ToString() + "%";
            MessageBox.Show("Voucher trị giá " + voucher.Value + "%", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmQuanLyBanAn_Load(object sender, EventArgs e)
        {

        }

        private void tbxvoucher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btncheckvoucher.PerformClick();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            List<cFood> lsFood = food.SearchFood(tbxtimkiem.Text.Trim());
            lbxtenmon.DataSource = lsFood;
            lbxtenmon.DisplayMember = "FoodName";

            lbxgia.DataSource = lsFood;
            lbxgia.DisplayMember = "Price";
        }

        private void tbxtimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btntim.PerformClick();
        }

        private void frmQuanLyBanAn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.F))
                    tbxtimkiem.Focus();
                if (e.KeyCode.Equals(Keys.A))
                    btnthem.PerformClick();
                if (e.KeyCode.Equals(Keys.T))
                    btnthanhtoan.PerformClick();
                if (e.KeyCode.Equals(Keys.C))
                    btnchuyenban.PerformClick();
                if (e.KeyCode.Equals(Keys.V))
                    tbxvoucher.Focus();
                if (e.KeyCode.Equals(Keys.S))
                    nmrsoluong.Focus();
                if (e.KeyCode.Equals(Keys.D))
                    cbxdanhmuc.Focus();
                    
            }
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbxtimkiem.Focus();
        }

        private void voucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbxvoucher.Focus();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbxdanhmuc.Focus();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Thoát ứng dụng?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }

        private void chuyểnBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnchuyenban.PerformClick();
        }

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnthem.PerformClick();
        }

        private void lbxtenmon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxtimkiem_TextChanged(object sender, EventArgs e)
        {
            btntim.PerformClick();
        }

        private void lwbanan2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cTable tb = (cTable)lwbanan2.SelectedItems[0].Tag;
                int idtable = tb.ID;
                IDTABLE = tb.ID;
                lbsoban.Text = tb.Name;
                ShowBill(idtable);
            }
            catch { }

        }
    }   
}
