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
            var hs = from h in db.ThongTinTKHs select h;
            return View(hs);
        }

        public string GetGioiTinh(bool gt)
        {
            if (!gt)
            {
                return "nam";
            }
            else return "nữ";
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