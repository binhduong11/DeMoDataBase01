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
    internal class HoaDonChiTiet_Configurations : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        void IEntityTypeConfiguration<HoaDonChiTiet>.Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(x => x.IdHoaDonChiTiet);
            builder.Property(c => c.DonGia).HasColumnName("DonGia")
                .HasColumnType("decimal").IsRequired();
            builder.Property(c => c.SoLuong).HasColumnName("SoLuong")
                .HasColumnType("int").IsRequired();

            builder.HasOne(x => x.HoaDon)
                .WithMany().HasForeignKey(p => p.IdHoaDon);
            builder.HasOne(x => x.SachChiTiet)
                .WithMany().HasForeignKey(p => p.IdSachChiTiet);
        }
    }
}
