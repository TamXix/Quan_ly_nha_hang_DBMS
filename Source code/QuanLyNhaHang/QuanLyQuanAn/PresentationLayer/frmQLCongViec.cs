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
    public partial class frmQLCongViec : Form
    {
        private BLWork work;
        private bool them = false;
        private string err;

        public frmQLCongViec()
        {
            InitializeComponent();
            work = new BLWork();
            LoadData();
        }

        private void LoadData()
        {
            //Xóa trống các đối tượng trong panel
            tbxten.ResetText();
            tbxluong.ResetText();
            tbxten.Enabled = false;
            tbxluong.Enabled = false;
            // Không cho thao tác trên nút Lưu
            btnluu.Enabled = false;
            // Cho thao tác trên các nút thêm / sửa / Xóa / thoát
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnhuy.Enabled = false;
            List<cWork> lstwork = new List<cWork>();
            try
            {
                lstwork = work.GetListWork();
                dgvcongviec.DataSource = lstwork;
            }
            catch
            {
                MessageBox.Show(" Không lấy được nội dung trong table. Lỗi rồi!!!");
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            them = true;
            tbxten.Enabled = true;
            tbxluong.Enabled = true;
            // Cho thao tác trên các nút Lưu /panel
            btnluu.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btnthem.Enabled = false;
            btnhuy.Enabled = true;
            btnxoa.Enabled = false;
            tbxten.Focus();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            tbxten.Enabled = true;
            tbxluong.Enabled = true;
            them = false;
            // Cho thao tác trên các nút Lưu /panel
            btnluu.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btnthem.Enabled = false;
            btnhuy.Enabled = true;
            btnxoa.Enabled = false;
            tbxten.Focus();

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            int luong = 0;
            try
            {
                luong = Convert.ToInt32(tbxluong.Text);
            }
            catch
            {
                MessageBox.Show("Giá trị không hợp lệ!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                return;
            }
            if (them)
            {
                if (tbxten.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!work.AddWork(tbxten.Text.Trim(), luong, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm voucher thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxten.ResetText();
                    tbxluong.ResetText();
                    LoadData();
                }
            }
            else
            {
                if (tbxten.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int id = (int)dgvcongviec.Rows[dgvcongviec.CurrentCell.RowIndex].Cells[0].Value;
                if (!work.UpdateWork(id, tbxten.Text.Trim(), luong, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa voucher thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxten.ResetText();
                    tbxluong.ResetText();
                    LoadData();
                }
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                int r = dgvcongviec.CurrentCell.RowIndex;
                int id = (int)dgvcongviec.Rows[r].Cells[0].Value;
                if (!work.DeleteWork(id, ref err))
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

        private void btnhuy_Click(object sender, EventArgs e)
        {
            tbxten.Enabled = false;
            tbxluong.Enabled = false;
            tbxten.ResetText();
            tbxluong.ResetText();
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnxoa.Enabled = true;
            btnhuy.Enabled = false;
        }

        private void dgvcongviec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvcongviec.CurrentCell.RowIndex;
                tbxten.Text = dgvcongviec.Rows[r].Cells[1].Value.ToString();
                tbxluong.Text = dgvcongviec.Rows[r].Cells[2].Value.ToString();
            }
            catch
            { }
        }
    }
}
