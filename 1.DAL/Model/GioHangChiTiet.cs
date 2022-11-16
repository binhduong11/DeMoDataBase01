using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Model
{
    public class GioHangChiTiet
    {
        public Guid IdGioHangCT { get; set; }
        public Guid IdGioHang { get; set; }
        public Guid IdSachChiTiet { get; set; }
        public decimal DonGia { get; set; }
        public int Soluong { get; set; }
        public virtual GioHang? GioHang { get; set; }
        public virtual SachChiTiet? SachChiTiet { get; set; }
    }
}
