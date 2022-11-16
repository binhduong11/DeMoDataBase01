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
    internal class NhanVien_Configurations : IEntityTypeConfiguration<NhanVien>
    {
        void IEntityTypeConfiguration<NhanVien>.Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x=>x.IdNhanVien);

            builder.Property(b => b.MaNhanVien).HasColumnName("MaNhanVien")
                .HasColumnType("nvarchar (100)").IsRequired();
            builder.Property(b => b.Ten).HasColumnName("TenNhanVien")
                .HasColumnType("nvarchar (100)").IsRequired();
            builder.Property(b => b.GioiTinh).HasColumnName("GioiTinh")
                .HasColumnType("nvarchar (10)").IsRequired();
            builder.Property(b => b.DiaChi).HasColumnName("DiaChi")
                .HasColumnType("nvarchar (100)").IsRequired();
            builder.Property(b => b.SDT).HasColumnName("SDT")
                .HasColumnType("nvarchar (10)").IsRequired();
            builder.Property(b => b.TrangThai).HasColumnName("TrangThai")
                .HasColumnType("nvarchar (10)").IsRequired();
            builder.Property(b => b.NgaySinh).HasColumnName("NgaySinh")
                .HasColumnType("datetime").IsRequired();

            builder.HasOne(x=>x.ChucVu)
                .WithMany().HasForeignKey(p =>p.IdChucVu);
        }
    }
}
