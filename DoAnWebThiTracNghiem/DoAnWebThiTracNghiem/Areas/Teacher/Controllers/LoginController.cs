using DoAnWebThiTracNghiem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.DAO;

namespace DoAnWebThiTracNghiem.Areas.Teacher.Controllers
{
    public class LoginController : Controller
    {
        // GET: Teacher/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            return View();
        }
    }
}