using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Class
{
    public class cNhanVien
    {
        private int iD;
        private string name;
        private string gioiTinh;
        private DateTime? ngaySinh;
        private string cMND;
        private string sdt;
        private string diaChi;
        private DateTime? ngayBatDau;
        private int iDCongViec;
        private int caLamViec;
        private int tienThuong;
        private int tongLuong;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime? NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime? NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public int IDCongViec { get => iDCongViec; set => iDCongViec = value; }
        public int CaLamViec { get => caLamViec; set => caLamViec = value; }
        public int TienThuong { get => tienThuong; set => tienThuong = value; }
        public int TongLuong { get => tongLuong; set => tongLuong = value; }

        public cNhanVien(DataRow row)
        {
            this.ID = (int)row["IDEMPLOYEE"];
            this.Name = row["NAME"].ToString();
            this.GioiTinh = row["SEX"].ToString();
            this.NgaySinh = (DateTime)row["DATEOFBIRTH"];
            this.NgayBatDau = (DateTime)row["STARTDAY"];
            this.CMND = row["IDENTITYCARD"].ToString();
            this.DiaChi = row["ADDRESS"].ToString();
            this.Sdt = row["PHONENUMBER"].ToString();
            this.tongLuong = (int)row["SALARY"];
            this.iDCongViec = (int)row["IDWORK"];
            this.caLamViec = (int)row["SHIFT"];
        }
        public cNhanVien()
        { }
    }
}
