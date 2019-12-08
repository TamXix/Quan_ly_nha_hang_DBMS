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
    public partial class frmWork : Form
    {
        BLWork work;
        List<cWork> lstWork;

        public frmWork()
        {
            InitializeComponent();
            work = new BLWork();
            lstWork = new List<cWork>();
            LoadData();
        }

        private void LoadData()
        {
            cmbcongviec.DisplayMember = "Name";
            try
            {
                lstWork = work.GetListWork();
                cmbcongviec.DataSource = lstWork;
                tbxsoluong.Text = (dgvnhanvien.Rows.Count - 1).ToString();
                tbxluong.Text = dgvnhanvien.Rows[0].Cells[3].Value.ToString();
                cmbcalamviec.SelectedIndex = 0;
            }
            catch { }
        }
        private int IdCongViec = -1;
        private void cmbcongviec_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdCongViec = lstWork[cmbcongviec.SelectedIndex].ID;
            dgvnhanvien.DataSource = work.GetListEmployeeByIdWork(IdCongViec);
            tbxsoluong.Text = (dgvnhanvien.Rows.Count - 1).ToString();
            tbxluong.Text = dgvnhanvien.Rows[0].Cells[3].Value.ToString();

        }
        private int CaLam = -1;
        private void cmbcalamviec_SelectedIndexChanged(object sender, EventArgs e)
        {
            CaLam = (int)cmbcalamviec.SelectedIndex + 1;
            dgvnhanvien2.DataSource = work.GetListEmployeeByShift(CaLam);
            tbxsoluongnv2.Text = (dgvnhanvien2.Rows.Count - 1).ToString();
        }

        private void tbxchitiet2_Click(object sender, EventArgs e)
        {
            frmQLCongViec f = new frmQLCongViec();
            this.Hide();
            f.ShowDialog();
        }

        private void tbxtrove2_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Đóng cửa sổ?", "Trả lời",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                this.Close();

        }

        private void btnchitiet_Click(object sender, EventArgs e)
        {
            frmQLCongViec f = new frmQLCongViec();
            this.Hide();
            f.ShowDialog();

        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Đóng cửa sổ?", "Trả lời",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                this.Close();

        }
    }
}
