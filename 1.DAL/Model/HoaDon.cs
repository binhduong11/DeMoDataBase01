using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Model
{
    public class HoaDon
    {
        public Guid IdHoaDon { get; set; }
        public Guid IdKhachHang { get; set; }
        public Guid IdNhanVien { get; set; }
        public string MaHoaDon { get; set; }
        public decimal DonGia { get; set; }
        public DateTime NgayTao { get; set; }
        public string TrangThai { get; set; }
        public virtual KhachHang? KhachHang { get; set ;}
        public virtual NhanVien NhanVien { get; set; }
    }
}
