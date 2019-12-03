using QuanLyQuanAn.BusinessLayers;
using QuanLyQuanAn.Class;
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
    public partial class frmQuanLyAccount : Form
    {
        BLAccount account;
        BLNhanVien nhanvien;
        private string err = "";
        private List<cAccount> lstAccount;
        private List<cNhanVien> lstNhanVien;
        private int idNhanVien;
        public frmQuanLyAccount()
        {
            InitializeComponent();
            account = new BLAccount();
            nhanvien = new BLNhanVien();
            lstAccount = new List<cAccount>();
            lstNhanVien = new List<cNhanVien>();
            LoadData();
        }

        private void LoadData()
        {
            lstAccount = account.GetListAccount();
            dgvaccount.DataSource = lstAccount;
            lstNhanVien = nhanvien.GetlistNV();
            cmbHoten.DisplayMember = "Name";
            cmbHoten.DataSource = lstNhanVien;
            dgvaccount.Columns[0].Visible = false;
            dgvaccount.Columns[5].Visible = false;
            dgvaccount.Columns[6].Visible = false;      
            dgvaccount.Columns[7].Visible = false;
            dgvaccount.Columns[8].Visible = false;
            dgvaccount.Columns[9].Visible = false;
            dgvaccount.Columns[10].Visible = false;
            dgvaccount.Columns[11].Visible = false;
            dgvaccount.Columns[12].Visible = false;
            pnl.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            btnresetpass.Enabled = true;
            btnthoat.Enabled = true;
            
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            pnl.Enabled = true;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            btnxoa.Enabled = false;
            btnthoat.Enabled = false;
            btnresetpass.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if(tbxuser.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int isad = 0;
            if (chbxadmin.CheckState == CheckState.Checked)
                isad = 1;
            if(!account.AddAccount(tbxuser.Text.Trim(), idNhanVien, isad, ref err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbxuser.ResetText();
            LoadData();
        }

        private void btnresetpass_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.Cancel) return;

            if (!account.ResetPass(tbxuser.Text, ref err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Reset thành công!\n Mật khẩu là '1'.", "Thông báo!", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.Cancel) return;

            if (!account.DeleteAccount(tbxuser.Text, ref err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Xóa thành công!", "Thông báo!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            pnl.Enabled = false;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            btnxoa.Enabled = true;
            btnthoat.Enabled = true;
            btnresetpass.Enabled = true;
            btnthem.Enabled = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }

        private void dgvaccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvaccount.CurrentCell.RowIndex;
            tbxuser.Text = dgvaccount.Rows[r].Cells[3].Value.ToString();
            if (dgvaccount.Rows[r].Cells[2].Value.ToString() == "1")
                chbxadmin.CheckState = CheckState.Checked;
            else
                chbxadmin.CheckState = CheckState.Unchecked;
        }

        private void cmbHoten_SelectedIndexChanged(object sender, EventArgs e)
        {
            idNhanVien = lstNhanVien[cmbHoten.SelectedIndex].ID;
        }
    }
}
