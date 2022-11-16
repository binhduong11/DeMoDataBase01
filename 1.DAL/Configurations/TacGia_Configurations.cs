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
    internal class TacGia_Configurations : IEntityTypeConfiguration<TacGia>
    {
        void IEntityTypeConfiguration<TacGia>.Configure(EntityTypeBuilder<TacGia> builder)
        {
            builder.ToTable("TacGia");
            builder.HasKey(x => x.IdTacGia);

            builder.Property(b => b.MaTacGia).HasColumnName("MaTacGia")
                .HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(b => b.TenTacGia).HasColumnName("TenTacGia")
                .HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
