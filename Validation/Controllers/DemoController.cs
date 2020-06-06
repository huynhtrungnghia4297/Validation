using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Validation.Models;

namespace Validation.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult ThemNhanVien()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ThemNhanVien(Nhanvien nv)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("loi", "Server chua hop le");
            }
            return View();
        }
        public IActionResult AddEmployee()
        {
            return View();
        }
        public IActionResult KiemTraMaNhanVien(int MaNhanVien)
        {
            int[] dsMa = new int[] { 777, 2222, 999, 369, 1515 };
            if(dsMa.Contains(MaNhanVien))
            {
                return Json("Ma nay da co");
            }
            return Json(true);
        }
       
    }
}