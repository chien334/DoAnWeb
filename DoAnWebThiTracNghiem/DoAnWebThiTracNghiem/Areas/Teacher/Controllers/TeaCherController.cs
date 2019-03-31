using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Model.DAO;
using Model.EF;

namespace DoAnWebThiTracNghiem.Areas.Teacher.Controllers
{
    public class TeaCherController : Controller
    {
        // GET: Teacher/TeaCher
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DeThi()
        {
            return View();
        }
        public ActionResult LayCauHoi()
        {
            return View();
        }
        public ActionResult ThongTinGiaoVien(string Magv)
        {
            return View();
        }
        public ActionResult QuanLyLopHoc()
        {
            return View();
        }
        public ActionResult BoDe(DeThi de)
        {
            if (ModelState.IsValid)
            {
                long id = new DeThiDAO().Insert(de);
                if (id > 0)
                    return RedirectToAction("Index", "Teacher");

                else
                    ModelState.AddModelError("", "Thêm thành công");
                  
            }
            return View();
        }
        public ActionResult DanhSachHocSinh()
        {
            return View();
        }
    }
}