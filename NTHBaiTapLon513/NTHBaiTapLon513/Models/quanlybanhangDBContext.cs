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
        public virtual DbSet<DangNhap> DangNhaps { get; set; }
        public virtual DbSet<HangBan> HangBans { get; set; }
        public virtual DbSet<HoaDonBanHang> HoaDonBanHangs { get; set; }
        public virtual DbSet<NCC> NCCs { get; set; }
        public virtual DbSet<NVBanHang> NVBanHangs { get; set; }

        
       
    }
}
