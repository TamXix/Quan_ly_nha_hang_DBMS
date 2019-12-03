using QuanLyQuanAn.BusinessLayers;
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
    public partial class frmLogin : Form
    {
        BLAccount dangnhap;
        public frmLogin()
        {
            InitializeComponent();
            dangnhap = new BLAccount();
        }

        private void tbxname_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                tbxpass.Focus();
        }

        private void tbxpass_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btndangnhap.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát không?",
                "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            tbxname.ResetText();
            tbxpass.ResetText();
            tbxname.Focus();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            frmQuanLy.Account = dangnhap.GetAccount(tbxname.Text.Trim(), tbxpass.Text.Trim());
            if (frmQuanLy.Account == null)
            {
                frmQuanLy.isLogin = false;
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmQuanLy.isLogin = true;
                if (frmQuanLy.Account.IsAdmin == 1)
                    frmQuanLy.isAdmin = true;
                else
                    frmQuanLy.isAdmin = false;
                MessageBox.Show("Đăng nhập thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
