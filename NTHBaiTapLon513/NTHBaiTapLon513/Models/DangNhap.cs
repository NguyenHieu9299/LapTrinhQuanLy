using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTHBaiTapLon513.Models
{
    public class DangNhap
    {
        [Key]
        [Display(Name = "Tên Đăng Nhập")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string TenDangNhap { get; set; }
        [Display(Name = "Mật Khẩu")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string MatKhau { get; set; }
    }
}