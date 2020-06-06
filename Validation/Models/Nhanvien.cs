using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Validation.Models
{
    public class Nhanvien
    {
        public int ID { get; set; }


        [Display(Name="Ma Nhan Vien")]
        [Required(ErrorMessage ="*")]
        [Remote(action: "KiemTraMaNhanVien",
                controller:"Demo")]
        public int MaNhanVien { get; set; }

        [Display(Name = "Ten Nhan Vien")]
        [Required(ErrorMessage = "*")]
        public string TenNhanVien  { get; set; }


        [EmailAddress]
        [Required(ErrorMessage = "Khong dung Email dinh dang !")]
        public string Email { get; set; }


        [Url]
        public string Website { get; set; }

        [Display(Name = "Ngay sinh")]
        [DataType(DataType.Date)]
        [KiemTraNgaySinh]
        public DateTime NgaySinh { get; set; }


        [Display(Name = "Gioi tinh")]
        public string GioiTinh { get; set; }


        [Display(Name ="Luong")]
        [Range(0, double.MaxValue)]
        public double Luong { get; set; }


        public string DiaChi { get; set; }


        public string DienThoai { get; set; }
        [CreditCard]
        public string SoTaiKhoan { get; set; }


        [MaxLength(255)]
        [DataType(DataType.MultilineText)]
        public string ThongTinThem { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage ="*")]
        [MinLength(4,ErrorMessage ="Toi thieu 4 ky tu")]
        
        [RegularExpression("[A-Z]+[0-9]+[a-z]+[@#$%^&*~]+", ErrorMessage ="Mat Khau phau chua it nhat 1 chu so, 1 chu hoa,1 chu thuong,1 ky tu dac biet")]
        public string MatKhau { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "*")]
        [Compare("MatKhau",ErrorMessage ="Mat Khau khong trung khop ")]
        public string NhapLaiMatKhau { get; set; }
    }
}
