using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTHPT.Models;

namespace WebTHPT.Controllers
{
    public class LoginController : Controller
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        // GET: Login
        [HttpGet]
        public ActionResult Index(FormCollection collection)
        {
            //var Username = collection["Username"];
            //var Password = collection["Password"];
            //if (String.IsNullOrEmpty(Username))
            //{
            //    ViewData["Loi"] = "Tên đăng nhập không được bỏ trống";
            //}
            //else if (String.IsNullOrEmpty(Password))
            //{
            //    ViewData["Loi1"] = "Mật Khẩu không được bỏ trống";
            //}
            //else
            //{
            //    GiaoVien gv = db.GiaoViens.SingleOrDefault(n => n.MaGV == Username && n.PassWordHash == Password);
            //    if(gv!=null)
            //    {
            //        ViewBag.ThongBao = "Đăng nhập thành công";
            //        Session["MaGV"]=gv;
            //        return RedirectToAction("Index", "Home");
            //    }
            //    else
            //    {
            //        ViewBag.ThongBao = "Tài khoản không tồn tại";
            //    }
            //}
            return View();
        }

    }
}