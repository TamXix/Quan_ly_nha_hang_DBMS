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
    public partial class frmThongTinTaiKhoan : Form
    {
        private BLAccount blaccout;
        private string error;
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
            blaccout = new BLAccount();
            
            LoadData();
        }
        private void LoadData()
        {
            this.tbxtendangnhapt1.Text = frmQuanLy.Account.User;
            this.tbxhotent1.Text = frmQuanLy.Account.Ten;
            this.tbxhotent2.Text = tbxhotent1.Text;
            if (frmQuanLy.Account.IsAdmin == 1)
                this.tbxquyenhant1.Text = "Admin";
            else
                this.tbxquyenhant1.Text = "Client";
            this.tbxid.Text = frmQuanLy.Account.Id.ToString();
            this.tbxcmndt2.Text = this.tbxcmndt1.Text = frmQuanLy.Account.IdentityCard;
            this.tbxdiachit2.Text = this.tbxdiachit1.Text = frmQuanLy.Account.Address;
            this.tbxgioitinht2.Text = tbxgioitinht1.Text = frmQuanLy.Account.Sex;
            this.tbxcalam.Text = frmQuanLy.Account.Shift.ToString();
            this.tbxngaysinht1.Text = frmQuanLy.Account.DateOfBirth.ToShortDateString();
            this.dtpkngaysinht2.Value = frmQuanLy.Account.DateOfBirth;
            this.tbxvitrit1.Text = frmQuanLy.Account.Work;
            this.tbxsdtt2.Text = this.tbxsdtt1.Text = frmQuanLy.Account.PhoneNumber;
            this.tbxngaybatdaut1.Text = frmQuanLy.Account.StartDay.ToShortDateString();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            tbxcmndt2.ResetText();
            tbxdiachit2.ResetText();
            tbxhotent2.ResetText();
            tbxsdtt2.ResetText();
            tbxsdtt2.ResetText();
            tbxgioitinht2.ResetText();
            tbxmatkhaucu.ResetText();
            tbxmatkhaumoi.ResetText();
            tbxxacnhan.ResetText();
            tbxmatkhaucu.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Thoát cửa sổ?\n Thông tin tài khoản sẽ không lưu lại nếu chưa xác nhận!",
                 "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (tbxmatkhaucu.Text.Trim() == "" || tbxmatkhaumoi.Text.Trim() == "" || tbxxacnhan.Text.Trim() == "" || 
                tbxhotent2.Text.Trim() == "" || tbxcmndt2.Text.Trim() == "" || tbxgioitinht2.Text.Trim() == "" || 
                tbxdiachit2.Text.Trim() == "" || tbxsdtt2.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!",
                "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbxmatkhaumoi.Text.Trim() != tbxxacnhan.Text.Trim())
            {
                MessageBox.Show("Xác nhận mật khẩu mới không chính xác vui lòng nhập lại!",
                "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!blaccout.ChangeInfo(frmQuanLy.Account.User, tbxmatkhaucu.Text.Trim(), tbxmatkhaumoi.Text.Trim(), Convert.ToInt32(tbxid.Text),
                tbxhotent2.Text.Trim(), tbxgioitinht2.Text.Trim(),tbxcmndt2.Text.Trim(),
                tbxdiachit2.Text.Trim(), tbxsdtt2.Text.Trim(), dtpkngaysinht2.Value.ToShortDateString(), ref error))
            {
                MessageBox.Show(error, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cập nhật thành công!\nHãy ghi nhớ tài khoản và mật khẩu của bạn, nếu quên, hãy liên hệ quản trị viên của bạn!",
                                "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQuanLy.Account = blaccout.GetAccount(this.tbxtendangnhapt1.Text.Trim(), this.tbxmatkhaumoi.Text.Trim());
                btnxoa.PerformClick();
                LoadData();
            }
        }
    }
}
