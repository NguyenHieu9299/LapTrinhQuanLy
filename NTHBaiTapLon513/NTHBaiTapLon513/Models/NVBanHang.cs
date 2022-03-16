using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTHBaiTapLon513.Models
{
    public class NVBanHang
    {
        [Key]
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string DCNV { get; set; }
        public string SoDienThoai { get; set; }
    }
}