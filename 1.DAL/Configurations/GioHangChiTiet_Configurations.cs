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
    internal class GioHangChiTiet_Configurations : IEntityTypeConfiguration<GioHangChiTiet>
    {
        void IEntityTypeConfiguration<GioHangChiTiet>.Configure(EntityTypeBuilder<GioHangChiTiet> builder)
        {
            builder.ToTable("GioHangChiTiet");
            builder.HasKey(x => x.IdGioHangCT);
            builder.Property(c => c.DonGia).HasColumnName("DonGia")
                .HasColumnType("decimal").IsRequired();
            builder.Property(c => c.Soluong).HasColumnName("SoLuong")
                .HasColumnType("int");

            builder.HasOne(x => x.GioHang)
                .WithMany().HasForeignKey(p => p.IdGioHang);
            builder.HasOne(x => x.SachChiTiet)
                .WithMany().HasForeignKey(p => p.IdSachChiTiet);
        }
    }
}
