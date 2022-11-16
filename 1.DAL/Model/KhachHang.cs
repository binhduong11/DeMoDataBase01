using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Model
{
    public class KhachHang
    {
        public Guid IdKhachHang { get; set; }
        public string MaKHachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
    }
}
