using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Model;

namespace _1.DAL.Model
{
    public class NhanVien
    {
        public Guid IdNhanVien { get; set; }
        public Guid IdBc { get; set; }
        public Guid IdChucVu { get; set; }
        public string Ten { get; set; }
        public string MaNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }
        public string TrangThai { get; set; }
        public virtual ChucVu? ChucVu { get; set; }
        public virtual NhanVien? nhanvien { get; set; }
    }
}
