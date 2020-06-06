using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Validation.Models
{
    public class EmployeeInfo
    {
        [Display(Name ="Ho ten")]
        [Required(ErrorMessage ="Vui long nhap thong tin!")]
        public string FullName { get; set; }

        [Display(Name = "Tuoi")]
        [Required(ErrorMessage = "Vui long nhap thong tin!")]
        public int Age { get; set; }

        [Display(Name = "Mo ta")]
        [MaxLength(255,ErrorMessage ="Toi da chi 255 ky tu")]
        [DataType(DataType.MultilineText)]
        public string Detail { get; set; }
    }
}
