using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTHBaiTapLon513.Models
{
    public class HoaDonBanHang
    {
        [Key]
        [Display(Name = "Mã Hóa Đơn")]
        public string MaHoaDon { get; set; }
        [Display(Name = "Ngày bán")]
        public string NgayBan { get; set; }
        [Display(Name = "Mã Hàng")]
        public string MaHang { get; set; }
        
        public HangBan HangBan { get; set; }

        [Display(Name = "Số Lượng")]
        public int Soluong { get; set; }
        [Display(Name = "Đơn Giá")]
        public int DonGia { get; set; }
        [Display(Name = "Thành Tiền")]
        public int ThanhTien { get; set; }
        
    }
}