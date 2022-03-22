using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTHBaiTapLon513.Models
{
    public class NCC
    {
        [Key]
        [Display(Name = "Mã Nhà Cung Cấp")]
        public string MaNCC { get; set; }
        [Display(Name = "Tên Nhà Cung Cấp")]
        public string TenNCC { get; set; }
        [Display(Name = "Tên Hàng")]
        public string TenHang { get; set; }
        [Display(Name = "Địa Chỉ")]
        public string Diachi { get; set; }
        [Display(Name = "Số Diện Thoại")]
        public int SoDienThoai { get; set; }
    }
}