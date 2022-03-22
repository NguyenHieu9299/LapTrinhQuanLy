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
        [Display(Name = "Mã Nhân Viên")]
        public string MaNV { get; set; }
        [Display(Name = "Tên Nhân Viên")]
        public string TenNV { get; set; }
        [Display(Name = "Địa Chỉ Nhân Viên")]
        public string DCNV { get; set; }
        [Display(Name = "Số Điện Thoại")]
        public string SoDienThoai { get; set; }
    }
}