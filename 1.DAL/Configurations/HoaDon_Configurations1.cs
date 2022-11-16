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
    internal class HoaDon_Configurations1 : IEntityTypeConfiguration<HoaDon>
    {
        void IEntityTypeConfiguration<HoaDon>.Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.IdHoaDon);
            builder.Property(c => c.MaHoaDon).HasColumnName("MaHoaDon")
                .HasColumnType("nvarchar (100)").IsRequired();
            builder.Property(c => c.DonGia).HasColumnName("DonGia")
                .HasColumnType("decimal").IsRequired();
            builder.Property(c => c.NgayTao).HasColumnName("NgayTao")
                .HasColumnType("datetime");
            builder.Property(c => c.TrangThai).HasColumnName("TrangThai")
                .HasColumnName("nvarchar (100)").IsRequired();

            builder.HasOne(x => x.NhanVien)
                .WithMany().HasForeignKey(p => p.IdNhanVien);
            builder.HasOne(x => x.KhachHang)
                .WithMany().HasForeignKey(p => p.IdKhachHang);
        }
    }
}
