using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Model;

namespace _1.DAL.Model
{
    public class SachChiTiet
    {
        public Guid IdSachCT { get; set; }
        public Guid IdSach { get; set; }
        public Guid IdNXB { get; set; }
        public Guid IdTacGia { get; set; }
        public Guid IdTheLoai { get; set; }
        public string MoTa { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public int SoTrang { get; set; }
        public virtual Sach ? sach { get; set; }
        public virtual NXB ? NXB { get; set; }
        public virtual TacGia ? TacGia { get; set; }
        public virtual TheLoai ? TheLoai { get; set; }

    }
}
