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
    internal class TheLoai_Configurations : IEntityTypeConfiguration<TheLoai>
    {
        void IEntityTypeConfiguration<TheLoai>.Configure(EntityTypeBuilder<TheLoai> builder)
        {
            builder.ToTable("TheLoai");
            builder.HasKey(x => x.IdTheLoai);

            builder.Property(b => b.MaTheLoai).HasColumnName("MaTheLoai")
                .HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(b => b.TenTheLoai).HasColumnName("TenTheLoai")
                .HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
