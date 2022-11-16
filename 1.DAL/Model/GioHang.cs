using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Model
{
    public class GioHang
    {
        public Guid IdGioHang { get; set; }
        public Guid IdKhachHang { get; set; }
        public Guid IdNhanVien { get; set; }
        public string MaGioHang { get; set; }
        public decimal DonGia { get; set; }
        public string TrangThai { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
        public virtual KhachHang ? KhachHang { get; set; }
    }
}
