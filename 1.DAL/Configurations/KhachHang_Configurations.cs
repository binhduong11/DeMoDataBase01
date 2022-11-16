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
    internal class KhachHang_Configurations : IEntityTypeConfiguration<KhachHang>
    {
        void IEntityTypeConfiguration<KhachHang>.Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang");
            builder.HasKey(x=>x.IdKhachHang);

            builder.Property(c => c.MaKHachHang).HasColumnName("MaKhachHang")
                .HasColumnType("nvarchar (100)").IsRequired();
            builder.Property(c => c.TenKhachHang).HasColumnName("TenKhachHang")
                .HasColumnType("nvarchar (100)").IsRequired();
            builder.Property(c => c.MaKHachHang).HasColumnName("MaKhachHang")
                .HasColumnType("nvarchar (100)").IsRequired();
            builder.Property(c => c.GioiTinh).HasColumnName("GioiTinh")
                .HasColumnType("nvarchar (100)").IsRequired();
            builder.Property(c => c.SDT).HasColumnName("SDT")
                .HasColumnType("nvarchar (100)").IsRequired();
            builder.Property(c => c.DiaChi).HasColumnName("DiaChi")
                .HasColumnType("nvarchar (100)").IsRequired();
            builder.Property(c => c.NgaySinh).HasColumnName("NgaySinh")
                .HasColumnType("DateTime").IsRequired();
        }
    }
}
