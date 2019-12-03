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
    public partial class frmVoucher : Form
    {
        private BLVoucher voucher;  
        private bool them = false;
        private string err;
        public frmVoucher()
        {
            InitializeComponent();
            voucher = new BLVoucher();
            LoadData();
        }
        private void LoadData()
        {
            //Xóa trống các đối tượng trong panel
            tbxcode.ResetText();
            // Không cho thao tác trên nút Lưu
            btnluu.Enabled = false;
            pnl2.Enabled = false;
            // Cho thao tác trên các nút thêm / sửa / Xóa / thoát
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnhuy.Enabled = false;
            btnthoat.Enabled = true;

            try
            {
                dgvvoucher.DataSource = voucher.GetListVoucher();
            }
            catch
            {
                MessageBox.Show(" Không lấy được nội dung trong table. Lỗi rồi!!!");
            }
        }
    
        private void btnthem_Click(object sender, EventArgs e)
        {
            them = true;
            tbxcode.ResetText();
            nmrgiatri.Value = 1;
            // Cho thao tác trên các nút Lưu /panel
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            pnl2.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnthoat.Enabled = false;
            tbxcode.Focus();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                int r = dgvvoucher.CurrentCell.RowIndex;
                int id = (int)dgvvoucher.Rows[r].Cells[0].Value;
                if (!voucher.DeleteVoucher(id, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                if (tbxcode.Text.Trim() == "" || tbxname.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!voucher.InsertVoucher(tbxcode.Text.Trim(), tbxname.Text.Trim(), (int)nmrgiatri.Value, dtpngayhethan.Value, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm voucher thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxcode.ResetText();
                    LoadData();
                }
            }
            else
            {
                if (tbxcode.Text.Trim() == "" || tbxname.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int id = (int)dgvvoucher.Rows[dgvvoucher.CurrentCell.RowIndex].Cells[0].Value;
                if (!voucher.UpdateVoucher(id, tbxcode.Text.Trim(), tbxname.Text.Trim(), (int)nmrgiatri.Value, dtpngayhethan.Value, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa voucher thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxcode.ResetText();
                    LoadData();
                }
            }

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            tbxcode.ResetText();
            nmrgiatri.Value = 1;
            pnl2.Enabled = false;
            btnthem.Enabled = true;
            btnthoat.Enabled = true;
            btnluu.Enabled = false;
            btnxoa.Enabled = true;
            btnhuy.Enabled = false;


        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) this.Close();


        }

        private void dgvvoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvvoucher.CurrentCell.RowIndex;
                tbxcode.Text = dgvvoucher.Rows[r].Cells[1].Value.ToString();
                tbxname.Text = dgvvoucher.Rows[r].Cells[2].Value.ToString();
                nmrgiatri.Value = (int)dgvvoucher.Rows[r].Cells[3].Value;
                dtpngayhethan.Value = (DateTime)dgvvoucher.Rows[r].Cells[5].Value;
            }
            catch
            { }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            them = false;
            // Cho thao tác trên các nút Lưu /panel
            btnluu.Enabled = true;
            pnl2.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnthoat.Enabled = false;
            btnhuy.Enabled = true;

            tbxcode.Focus();
        }
    }
}
