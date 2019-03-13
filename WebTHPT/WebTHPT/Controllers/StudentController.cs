using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTHPT.Models;

namespace WebTHPT.Controllers
{
    public class StudentController : Controller
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ThongTinHocSinh()
        {
            var hs = (from k in db.Khois
                      join l in db.Lops on k.MaKhoi equals l.MaKhoi
                      join h in db.HocSinhs on l.MaLop equals h.MaLop
                      where h.MaHS == "HS190001"
                      select new
                      {
                          MaHS = h.MaHS,
                          HoTenHS = h.HoTenHS,
                          TenLop = l.TenLop,
                          TenKhoi = k.TenKhoi,
                          NienKhoa = h.NienKhoa,
                          NgaySinh = h.NgaySinh
                      }).OrderBy(c => c.MaHS).ToList();
            return View(hs);
        }

        public ActionResult DiemHocSinh()
        {

            return View();
        }
        public ActionResult DeThi()
        {

            return View();
        }
        public ActionResult GopY()
        {
            return View();
        }
    }
}