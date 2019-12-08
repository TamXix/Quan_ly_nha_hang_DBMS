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
    public partial class frmQuanLyNhanVien : Form
    {
        private bool Them = false;
        private BLNhanVien nhanvien;
        private BLWork work;
        List<cWork> lstwork;
        private string err = "";
        private int CaLamViec = -1;
        private string NameCol;
        private bool isAscending = true;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            nhanvien = new BLNhanVien();
            work = new BLWork();
            lstwork = new List<cWork>();
            NameCol = "IDEMPLOYEE";
            LoadData();
        }
        void LoadData()
        {
            panel1.Enabled = false;
            tbxma.ResetText();
            tbxten.ResetText();
            tbxcmnd.ResetText();
            tbxdiachi.ResetText();
            tbxtienthuong.ResetText();
            tbxsdt.ResetText();

            btnluu.Enabled = false;

            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthoat.Enabled = true;
            lstwork = work.GetListWork();
            cmbcongviec.DisplayMember = "Name";
            cmbcongviec.DataSource = lstwork;
            dgvNV.DataSource = nhanvien.GetListEmployee(NameCol, isAscending);
            //TinhLuong();
        }
        private void TinhLuong()
        {
            try
            {
                for (int i = 0; i < dgvNV.Rows.Count; i++)
                {
                    int idnv = (int)dgvNV.Rows[i].Cells[0].Value;
                    nhanvien.UpdateSalary(idnv, ref err);
                }
            }
            catch { }
        }
        private void ResetText()
        {
            tbxten.ResetText();
            tbxtienthuong.ResetText();
            tbxcmnd.ResetText();
            tbxdiachi.ResetText();
            tbxsdt.ResetText();
            tbxma.ResetText();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            Them = true;
            tbxma.ResetText();
            tbxten.ResetText();
            tbxcmnd.ResetText();
            tbxdiachi.ResetText();
            tbxtienthuong.ResetText();
            tbxsdt.ResetText();

            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthoat.Enabled = false;

            tbxma.Focus();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Them = false;
            panel1.Enabled = true;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthoat.Enabled = false;

            tbxma.Enabled = false;
            tbxten.Focus();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc chắn xóa không?", "Trả lời",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(traloi == DialogResult.Yes)
            {
                if(!nhanvien.DeleteNhanVien((int)dgvNV.Rows[dgvNV.CurrentCell.RowIndex].Cells[0].Value, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetText();
                    LoadData();

                }
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            int thuong;
            try
            {
                thuong = Convert.ToInt32(tbxtienthuong.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Giá trị tiền thưởng không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Them)
            {
                if (tbxten.Text.Trim() == "" || tbxcmnd.Text.Trim() == "" || tbxdiachi.Text.Trim() == ""
                    || tbxsdt.Text.Trim() == "" || tbxtienthuong.Text.Trim() == "" )
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string gioitinh = "Nữ";
                if (rabNam.Checked == true)
                    gioitinh = "Nam";

                if (!nhanvien.AddNhanVien(tbxten.Text.Trim(), gioitinh, dtpngaysinh.Value, tbxcmnd.Text.Trim(), tbxdiachi.Text.Trim(),
                     tbxsdt.Text.Trim(), idcongviec, CaLamViec, dtpngaybatdau.Value, thuong, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetText();
                    LoadData();
                    //TinhLuong();
                }
            }
            else
            {
                if (tbxten.Text.Trim() == "" || tbxcmnd.Text.Trim() == "" || tbxdiachi.Text.Trim() == ""
                                   || tbxsdt.Text.Trim() == "" || tbxtienthuong.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int id = (int)dgvNV.Rows[dgvNV.CurrentCell.RowIndex].Cells[0].Value;

                string gioitinh = "Nữ";
                if (rabNam.Checked == true)
                    gioitinh = "Nam";

                if (!nhanvien.UpdateNhanvien(id, tbxten.Text.Trim(), gioitinh, dtpngaysinh.Value, tbxcmnd.Text.Trim(), tbxdiachi.Text.Trim(),
                     tbxsdt.Text.Trim(), idcongviec, CaLamViec, dtpngaybatdau.Value, thuong, ref err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetText();
                    LoadData();
                    btnhuy.PerformClick();
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Đóng cửa sổ?", "Trả lời",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                this.Close();

        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvNV.CurrentCell.RowIndex;

                tbxma.Text = dgvNV.Rows[r].Cells[0].Value.ToString();
                tbxten.Text = dgvNV.Rows[r].Cells[1].Value.ToString();
                if (dgvNV.CurrentRow.Cells[2].Value.ToString() == "Nam")
                    rabNam.Checked = true;
                else
                    rabNu.Checked = true;
                tbxluongthang.Text = dgvNV.Rows[r].Cells[11].Value.ToString();

                dtpngaysinh.Value = Convert.ToDateTime(dgvNV.Rows[r].Cells[3].Value.ToString());
                dtpngaybatdau.Value = Convert.ToDateTime(dgvNV.Rows[r].Cells[7].Value.ToString());

                tbxtienthuong.Text = dgvNV.Rows[r].Cells[10].Value.ToString();
                tbxcmnd.Text = dgvNV.Rows[r].Cells[4].Value.ToString();
                tbxdiachi.Text = dgvNV.Rows[r].Cells[5].Value.ToString();
                tbxsdt.Text = dgvNV.Rows[r].Cells[6].Value.ToString();
                
            }
            catch { }
        }

        private void cmbcalam_SelectedIndexChanged(object sender, EventArgs e)
        {
            CaLamViec = cmbcalam.SelectedIndex + 1;
        }
        private int idcongviec = -1;
        private void cmbcongviec_SelectedIndexChanged(object sender, EventArgs e)
        {
            idcongviec = lstwork[cmbcongviec.SelectedIndex].ID;
        }
        
        private void sid_Click(object sender, EventArgs e)
        {
            NameCol = "IDEMPLOYEE";
            LoadData();
            isAscending = !isAscending;

        }

        private void sname_Click(object sender, EventArgs e)
        {
            NameCol = "empname";
            LoadData();     
            isAscending = !isAscending;

        }

        private void sgioitinh_Click(object sender, EventArgs e)
        {
            NameCol = "SEX";
            LoadData();
            isAscending = !isAscending;

        }

        private void sns_Click(object sender, EventArgs e)
        {
            NameCol = "DATEOFBIRTH";
            LoadData();
            isAscending = !isAscending;

        }

        private void sngaylam_Click(object sender, EventArgs e)
        {
            NameCol = "STARTDAY";
            LoadData();
            isAscending = !isAscending;

        }

        private void svitri_Click(object sender, EventArgs e)
        {
            NameCol = "WorkName";
            LoadData();
            isAscending = !isAscending;

        }

        private void scalam_Click(object sender, EventArgs e)
        {
            NameCol = "CaLam";
            LoadData();
            isAscending = !isAscending;

        }

        private void stienthuong_Click(object sender, EventArgs e)
        {
            NameCol = "BONUS";
            LoadData();
            isAscending = !isAscending;

        }

        private void sluong_Click(object sender, EventArgs e)
        {
            NameCol = "TongLuong";
            LoadData();
            isAscending = !isAscending;

        }
    }
}
