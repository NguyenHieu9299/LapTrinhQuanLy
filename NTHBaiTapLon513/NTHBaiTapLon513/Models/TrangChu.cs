namespace NTHBaiTapLon513.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrangChu")]
    public partial class TrangChu
    {
        [Key]
        [Column("[TrangChu")]
        [StringLength(10)]
        public string C_TrangChu { get; set; }

        [StringLength(10)]
        public string SanPham { get; set; }
    }
}
