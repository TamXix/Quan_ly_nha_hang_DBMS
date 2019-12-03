using QuanLyQuanAn.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class frmQuanLy : Form
    {
        public static bool isLogin = false;
        public static bool isAdmin = false;
        public static cAccount Account;
        public frmQuanLy()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            if(isLogin == true)
            {
                lbtext.Hide();
                lbxinchao.Text = "Xin chào " + Account.Ten + "!";
                lbxinchao.Show();
                thôngTinTàiKhoảnToolStripMenuItem.Enabled = true;
                btndangnhap.Enabled = false;
                if (isAdmin)
                    administratorToolStripMenuItem.Enabled = true;
                btnquanlyban.Enabled = true;
                đăngNhậpToolStripMenuItem.Enabled = false;
                đăngXuấtToolStripMenuItem.Enabled = true;
            }
            else
            {
                lbtext.Show();
                lbxinchao.Hide();
                btndangnhap.Enabled = true;
                thôngTinTàiKhoảnToolStripMenuItem.Enabled = false;
                btnquanlyban.Enabled = false;
                administratorToolStripMenuItem.Enabled = false;
                isAdmin = false;
                đăngXuấtToolStripMenuItem.Enabled = false;
                đăngNhậpToolStripMenuItem.Enabled = true;
            }
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btndangnhap.PerformClick();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Đăng xuất khỏi ứng dụng?",
                 "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                Account = null;
                isLogin = false;
                isAdmin = false;
                Load();
            }
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Thoát khỏi ứng dụng?",
     "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                Application.Exit();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinTaiKhoan f = new frmThongTinTaiKhoan();
            this.Hide();
            f.ShowDialog();
            Load();
            this.Show();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            this.Hide();
            f.ShowDialog();
            this.Show();
            Load();
        }
        private void btnquanlyban_Click(object sender, EventArgs e)
        {
            frmQuanLyBanAn f = new frmQuanLyBanAn();
            f.ShowDialog();
        }

        private void quảnLýMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyMonAn f = new frmQuanLyMonAn();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe f = new frmThongKe();
            f.ShowDialog();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyAccount f = new frmQuanLyAccount();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void voucherKhuyễnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVoucher f = new frmVoucher();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanAn f = new frmBanAn();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void frmQuanLy_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Control)
            {
                if (e.KeyCode.Equals(Keys.Q))
                    btnquanlyban.PerformClick();
                if (e.KeyCode.Equals(Keys.A))
                    administratorToolStripMenuItem.PerformClick();
                if (e.KeyCode.Equals(Keys.T))
                    thôngTinTàiKhoảnToolStripMenuItem.PerformClick();
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien f = new frmQuanLyNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýCôngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLCongViec f = new frmQLCongViec();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thốngKêNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWork f = new frmWork();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
