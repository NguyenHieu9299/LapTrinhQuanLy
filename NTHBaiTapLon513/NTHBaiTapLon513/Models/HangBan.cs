using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTHBaiTapLon513.Models
{
    public class HangBan
    {
        [Key]
        [Display(Name ="Mã Hàng")]
        [Required(ErrorMessage ="Không được bỏ trống")]
        public string MaHang { get; set; }
        [Display(Name = "Tên Hàng")]
        public string TenHang { get; set; }
        [Display(Name = "Vị Trí")]
        public string ViTri { get; set; }
        [Display(Name = "Số lượng")]
        public string SoLuong { get; set; }
        [Display(Name = "Đơn Giá")]
        public string DonGia { get; set; }
        [Display(Name = "Thành Tiền")]
        public string ThanhTien { get; set; }
        [Display(Name = "Hạn Sử Dụng")]
        public string HanSD { get; set; }
        public ICollection<HoaDonBanHang> HoaDonBanHang { get; set; }

    }
}