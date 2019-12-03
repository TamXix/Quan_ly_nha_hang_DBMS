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
    public partial class frmQuanLyMonAn : Form
    {
        private bool Them = false;
        private bool themdm = false;
        private bool themncc = false;
        private BLFood food;
        private BLTypeFood typefood;
        private BLSupplier supplier;
        List<cSupplier> lstsupplier;
        List<cTypeFood> lstTypeFood;
        private string err = "";
        public frmQuanLyMonAn()
        {
            InitializeComponent();
            food = new BLFood();
            typefood = new BLTypeFood();
            supplier = new BLSupplier();
            lstTypeFood = new List<cTypeFood>();
            lstsupplier = new List<cSupplier>();
            LoadData();
        }
        void LoadData()
        {
            //Xóa trống các đối tượng trong panel
            txtTenMon.ResetText();
            txtDonGia.ResetText();
            cmbLoaiMon.ResetText();
            // Không cho thao tác trên nút Lưu
            btnLuu.Enabled = false;
            btnluu2.Enabled = false;
            pnl.Enabled = false;
            // Cho thao tác trên các nút thêm / sửa / Xóa / thoát
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnhuy.Enabled = false;
            btnThoat.Enabled = true;

            tbxtendanhmuc.Enabled = false;
            btnthem2.Enabled = true;
            btnsua2.Enabled = true;
            btnxoa2.Enabled = true;
            btnthoat2.Enabled = true;
            btnhuy2.Enabled = false;
            tbxtendanhmuc.ResetText();


            pnlncc.Enabled = false;
            btnthem3.Enabled = true;
            btnsua3.Enabled = true;
            btnxoa3.Enabled = true;
            btnthoat3.Enabled = true;
            btnhuy3.Enabled = false;

            cmbLoaiMon.DisplayMember = "TypeName";
            cmbsupplier.DisplayMember = "Name";
            lstTypeFood = typefood.GetListTypeFood();
            lstsupplier = supplier.GetListSupplier();

            cmbsupplier.DataSource = lstsupplier;
            cmbLoaiMon.DataSource = lstTypeFood;

            dgvMon.DataSource = food.GetListFood();
            dgvdanhmuc.DataSource = lstTypeFood;
            dgvncc.DataSource = lstsupplier;

            try
            {

            }
            catch
            {
                MessageBox.Show(" Không lấy được nội dung trong table. Lỗi rồi!!!");
            }
        }

        private void btnthem2_Click(object sender, EventArgs e)
        {
            themdm = true;
            tbxtendanhmuc.Enabled = true;
            tbxtendanhmuc.ResetText();
            btnluu2.Enabled = true;
            btnthem2.Enabled = false;
            btnxoa2.Enabled = false;
            btnthoat2.Enabled = false;
            btnhuy2.Enabled = true;
            tbxtendanhmuc.Focus();
        }

        private void btnsua2_Click(object sender, EventArgs e)
        {
            themdm = false;
            tbxtendanhmuc.Enabled = true;
            btnluu2.Enabled = true;
            btnhuy2.Enabled = true;
            btnxoa2.Enabled = false;
            btnthem2.Enabled = false;
            btnsua2.Enabled = false;

        }

        private void btnxoa2_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc muốn xóa???", "Thông báo!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dl == DialogResult.Yes)
            {
                if(!typefood.DeleteFoodType((int)dgvdanhmuc.Rows[dgvdanhmuc.CurrentCell.RowIndex].Cells[0].Value, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxtendanhmuc.ResetText();
                LoadData();
            }
        }

        private void btnluu2_Click(object sender, EventArgs e)
        {
            if (themdm)
            {
                if (tbxtendanhmuc.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!typefood.AddFoodType(tbxtendanhmuc.Text.Trim(), IdSup, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxtendanhmuc.ResetText();
                    LoadData();
                    tbxtendanhmuc.Focus();
                }

            }
            else
            {
                string name = tbxtendanhmuc.Text.Trim();
                int idtype = (int)dgvdanhmuc.Rows[dgvdanhmuc.CurrentCell.RowIndex].Cells[0].Value;
                if(!typefood.UpdateFoodType(idtype, name, IdSup, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxtendanhmuc.ResetText();
                    LoadData();
                    tbxtendanhmuc.Focus();
                }

            }
        }

        private void btnhuy2_Click(object sender, EventArgs e)
        {
            tbxtendanhmuc.ResetText();
            tbxtendanhmuc.Enabled = false;
            btnthem2.Enabled = true;
            btnsua2.Enabled = true;
            btnthoat2.Enabled = true;
            btnluu2.Enabled = false;
            btnxoa2.Enabled = true;
            btnhuy2.Enabled = false;
        }

        private void btnthoat2_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) this.Close();
        }

        private void dgvdanhmuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvdanhmuc.CurrentCell.RowIndex;
            tbxtendanhmuc.Text = dgvdanhmuc.Rows[r].Cells[1].Value.ToString();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Them = true;
            // Xóa trống các đối tượng trong panel1
            txtDonGia.ResetText();
            txtTenMon.ResetText();
            cmbLoaiMon.ResetText();
            // Cho thao tác trên các nút Lưu /panel
            btnLuu.Enabled = true;
            pnl.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnhuy.Enabled = true;
            // Đưa con trỏ đến TextField txtMaMon

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            Them = false;
            btnLuu.Enabled = true;
            pnl.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnhuy.Enabled = true;
            btnSua.Enabled = false;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                int r = dgvMon.CurrentCell.RowIndex;
                int idfood = (int)dgvMon.Rows[r].Cells[0].Value;
                if (!food.DeleteFood(idfood, ref err))
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

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            int idtype = -1;
            idtype = idtypefood;
            if(idtypefood == -1)
            {
                MessageBox.Show("Bạn chưa chọn danh mục thức ăn!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Them)
            {
                if (txtTenMon.Text.Trim() == "" || txtDonGia.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                double gia = Convert.ToDouble(txtDonGia.Text.Trim());
                err = "";
                if (!food.AddFood(txtTenMon.Text.Trim(), idtype, gia, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm món thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenMon.ResetText();
                    txtDonGia.ResetText();
                    LoadData();
                    txtTenMon.Focus();
                }
            }
            else
            {
                if (txtTenMon.Text.Trim() == "" || txtDonGia.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int r = -1;
                try
                {
                    r = dgvMon.CurrentCell.RowIndex;
                }
                catch
                {
                    MessageBox.Show("Vui lòng chọn món!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int idfood = (int)dgvMon.Rows[r].Cells[0].Value;
                double gia = Convert.ToDouble(txtDonGia.Text.Trim());
                if (!food.UpdateFood(idfood, txtTenMon.Text.Trim(), idtype, gia, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenMon.ResetText();
                    txtDonGia.ResetText();
                    LoadData();
                    txtTenMon.Focus();
                }
            }

        }

        private void btnhuy_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) this.Close();
        }

        private void dgvMon_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvMon.CurrentCell.RowIndex;
            txtTenMon.Text = dgvMon.Rows[r].Cells[1].Value.ToString();
            cmbLoaiMon.Text = dgvMon.Rows[r].Cells[3].Value.ToString();
            txtDonGia.Text = dgvMon.Rows[r].Cells[2].Value.ToString();

        }

        private void txtDonGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLuu.PerformClick();
        }

        private void tbxtendanhmuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnluu2.PerformClick();

        }
        private int idtypefood = -1;

        private void cmbLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            idtypefood = lstTypeFood[cmbLoaiMon.SelectedIndex].IDType;
        }

        private void btnthem3_Click(object sender, EventArgs e)
        {
            themncc = true;
            pnlncc.Enabled = true;
            btnluu3.Enabled = true;
            btnthem3.Enabled = false;
            btnxoa3.Enabled = false;
            btnthoat3.Enabled = false;
            btnhuy3.Enabled = true;
            tbxtennhacc.Focus();

        }

        private void btnsua3_Click(object sender, EventArgs e)
        {
            themncc = false;
            btnluu3.Enabled = true;
            pnlncc.Enabled = true;
            btnthem3.Enabled = false;
            btnxoa3.Enabled = false;
            btnthoat3.Enabled = false;
            btnhuy3.Enabled = true;
            btnsua3.Enabled = false;
            tbxtennhacc.Focus();

        }

        private void btnxoa3_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc muốn xóa???", "Thông báo!",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                if (!supplier.DeleteSupplier(IdNhaCungCap, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxtendanhmuc.ResetText();
                LoadData();
            }

        }

        private void btnluu3_Click(object sender, EventArgs e)
        {
            if (themncc)
            {
                if (tbxtennhacc.Text.Trim() == "" || tbxdiachi.Text.Trim() == "" || tbxsdt.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!supplier.AddSupplier(tbxtennhacc.Text.Trim(), tbxsdt.Text.Trim(), tbxdiachi.Text.Trim(), ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxtennhacc.ResetText();
                    LoadData();
                    tbxtennhacc.Focus();
                }

            }
            else
            {
                if (!supplier.UpdateSupplier(IdNhaCungCap, tbxtennhacc.Text.Trim(), tbxsdt.Text.Trim(), tbxdiachi.Text.Trim(), ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxtennhacc.ResetText();
                    LoadData();
                    tbxtennhacc.Focus();
                }

            }

        }

        private void btnhuy3_Click(object sender, EventArgs e)
        {
            tbxidsup.ResetText();
            tbxdiachi.ResetText();
            tbxsdt.ResetText();
            pnlncc.Enabled = false;
            btnthem3.Enabled = true;
            btnsua3.Enabled = true;
            btnthoat3.Enabled = true;
            btnluu3.Enabled = false;
            btnxoa3.Enabled = true;
            btnhuy3.Enabled = false;

        }

        private void btnthoat3_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) this.Close();

        }
        private int IdSup = -1;
        private void cmbsupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IdSup = lstsupplier[cmbsupplier.SelectedIndex].ID;
            }
            catch { }
        }
        private int IdNhaCungCap = -1;
        private void dgvncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvncc.CurrentCell.RowIndex;

            IdNhaCungCap = (int)dgvncc.Rows[r].Cells[0].Value;
            tbxtennhacc.Text = dgvncc.Rows[r].Cells[1].Value.ToString();
            tbxsdt.Text = dgvncc.Rows[r].Cells[2].Value.ToString();
            tbxdiachi.Text = dgvncc.Rows[r].Cells[3].Value.ToString();
        }
    }
}
