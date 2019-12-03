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
    public partial class frmBanAn : Form
    {
        private BLTableFood tablefood;
        private BLArea area;
        private bool them = false;
        private bool them2 = false;
        private List<cArea> lstArea;
        private int idarea;
        private string err;
        public frmBanAn()
        {
            InitializeComponent();
            lstArea = new List<cArea>();
            tablefood = new BLTableFood();
            area = new BLArea();
            LoadData();
        }
        private void LoadData()
        {
          //TABLE

            //Xóa trống các đối tượng trong panel
            tbxname.ResetText();
            tbxname.Enabled = false;
            // Không cho thao tác trên nút Lưu
            btnluu.Enabled = false;
            // Cho thao tác trên các nút thêm / sửa / Xóa / thoát
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnhuy.Enabled = false;
            btnthoat.Enabled = true;

            cmbarea.DisplayMember = "Name";
            try
            {
                dgvtable.DataSource = tablefood.GetTableInfo();
            }
            catch
            {
                MessageBox.Show(" Không lấy được nội dung từ FOODTABLE. Lỗi rồi!!!");
            }

            //AREA

            tbxtenkv.ResetText();
            tbxtenkv.Enabled = false;
            // Không cho thao tác trên nút Lưu
            btnluu2.Enabled = false;
            // Cho thao tác trên các nút thêm / sửa / Xóa / thoát
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnsua2.Enabled = true;
            btnthem2.Enabled = true;
            btnxoa2.Enabled = true;
            btnhuy2.Enabled = false;
            btnthoat2.Enabled = true;
            try
            {
                lstArea = area.LayDanhSachArea();
                cmbarea.DataSource = lstArea;
                dgvarea.DataSource = lstArea;
            }
            catch
            {
                MessageBox.Show(" Không lấy được nội dung trong AREA. Lỗi rồi!!!");
            }
            try
            {
                idarea = lstArea[0].ID;
            }
            catch { }

        }

        private void tbxname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnluu.PerformClick();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            them = true;
            tbxname.Enabled = true;
            tbxname.ResetText();
            // Cho thao tác trên các nút Lưu /panel
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnthoat.Enabled = false;
            tbxname.Focus();

        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            them = false;
            tbxname.Enabled = true;
            tbxname.Focus();
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnhuy.Enabled = true;
            btnthoat.Enabled = false;

        }

        private void btnluu_Click_1(object sender, EventArgs e)
        {
            if (them)
            {
                if (tbxname.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!tablefood.AddTable(tbxname.Text.Trim(), idarea, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxname.ResetText();
                    LoadData();
                }
            }
            else
            {
                if (tbxname.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int r = dgvtable.CurrentCell.RowIndex;
                int id = (int)dgvtable.Rows[r].Cells[0].Value;
                if (!tablefood.UpdateTable(id, tbxname.Text.Trim(), idarea, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxname.ResetText();
                    LoadData();
                }
            }

        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                int r = dgvtable.CurrentCell.RowIndex;
                int id = (int)dgvtable.Rows[r].Cells[0].Value;
                if (!tablefood.DeleteTable(id, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }

        }

        private void btnhuy_Click_1(object sender, EventArgs e)
        {
            tbxname.ResetText();
            tbxname.Enabled = false;
            btnthem.Enabled = true;
            btnthoat.Enabled = true;
            btnluu.Enabled = false;
            btnxoa.Enabled = true;

        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) this.Close();

        }

        private void btnthem2_Click(object sender, EventArgs e)
        {
            them2 = true;
            tbxtenkv.Enabled = true;
            tbxtenkv.ResetText();
            // Cho thao tác trên các nút Lưu /panel
            btnluu2.Enabled = true;
            btnhuy2.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btnthem2.Enabled = false;
            btnxoa2.Enabled = false;
            btnthoat2.Enabled = false;
            tbxtenkv.Focus();
        }

        private void btnsua2_Click(object sender, EventArgs e)
        {
            them2 = false;
            tbxtenkv.Enabled = true;
            tbxtenkv.Focus();
            btnluu2.Enabled = true;
            btnthem2.Enabled = false;
            btnsua2.Enabled = false;
            btnxoa2.Enabled = false;
            btnhuy2.Enabled = true;
            btnthoat2.Enabled = false;
        }

        private void btnluu2_Click(object sender, EventArgs e)
        {
            if (them2)
            {
                if (tbxtenkv.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!area.AddArea(tbxtenkv.Text.Trim(), ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxtenkv.ResetText();
                    LoadData();
                }
            }
            else
            {
                if (tbxtenkv.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int r = dgvarea.CurrentCell.RowIndex;
                int id = (int)dgvarea.Rows[r].Cells[0].Value;
                if (!area.UpdateArea(id, tbxtenkv.Text.Trim(), ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxtenkv.ResetText();
                    LoadData();
                }
            }

        }

        private void btnxoa2_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                int r = dgvarea.CurrentCell.RowIndex;
                int id = (int)dgvarea.Rows[r].Cells[0].Value;
                if (!area.DeleteArea(id, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }

        }

        private void btnhuy2_Click(object sender, EventArgs e)
        {
            tbxtenkv.ResetText();
            tbxtenkv.Enabled = false;
            btnthem2.Enabled = true;
            btnthoat2.Enabled = true;
            btnluu2.Enabled = false;
            btnxoa2.Enabled = true;

        }

        private void btnthoat2_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) this.Close();
        }

        private void cmbarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            idarea = lstArea[cmbarea.SelectedIndex].ID;
        }

        private void dgvtable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvtable.CurrentCell.RowIndex;
            tbxname.Text = dgvtable.Rows[r].Cells[1].Value.ToString();

        }

        private void dgvarea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvarea.CurrentCell.RowIndex;
            tbxtenkv.Text = dgvarea.Rows[r].Cells[1].Value.ToString();
        }
    }
}
