using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Validation.Models
{
    internal class KiemTraNgaySinhAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime ngaysinh = (DateTime) value;
            if (ngaysinh > DateTime.Today)
            {
                return new ValidationResult("Ngay sinh trong tuong lai");
            }
            return ValidationResult.Success;
        }
    }
}