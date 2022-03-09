using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NTHBaiTapLon513.Models
{
    public partial class quanlybanhangDBContext : DbContext
    {
        public quanlybanhangDBContext()
            : base("name=quanlybanhangDBContext")
        {
        }

        public virtual DbSet<TrangChu> TrangChus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrangChu>()
                .Property(e => e.C_TrangChu)
                .IsFixedLength();

            modelBuilder.Entity<TrangChu>()
                .Property(e => e.SanPham)
                .IsFixedLength();
        }
    }
}
