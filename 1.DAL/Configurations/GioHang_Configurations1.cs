using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations
{
    internal class GioHang_Configurations1 : IEntityTypeConfiguration<GioHang>
    {
        void IEntityTypeConfiguration<GioHang>.Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.ToTable("GioHang");
            builder.HasKey(x=>x.IdGioHang);
            builder.Property(c => c.MaGioHang).HasColumnName("GioHang")
                .HasColumnType("nvarchar(100)");
            builder.Property(c => c.TrangThai).HasColumnName("TrangThai")
                .HasColumnType("nvarchar(100)");
            builder.Property(c => c.DonGia).HasColumnName("DonGia")
                .HasColumnType("decimal");
            builder.HasOne(x => x.NhanVien)
                .WithMany().HasForeignKey(c => c.IdNhanVien);
            builder.HasOne(x => x.KhachHang)
                .WithMany().HasForeignKey(c => c.IdKhachHang);
        }
    }
}
