using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.DAO;
using DoAnWebThiTracNghiem.Common;
using DoAnWebThiTracNghiem.Models;

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
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.UserName, Encryptor.MD5Hash(model.PassWord));
                if (result == 1)
                {
                    var user = dao.GetByID(model.UserName);
                    var userSession = new UserLogin
                    {
                        UserName = user.MaGV,
                        UserID = user.UserID,
                        Permission = (int)user.permission
                    };
                    Session.Add(CommonConstant.USER_SESSION, userSession);
                    if (user.permission == 1)
                    {
                        return Redirect("/Teacher/temp"); //neu la admin
                    }
                    return Redirect("/"); // ve trang chu
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại!");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản đang bị khoá!");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Mật khẩu không đúng!");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không đúng!");
                }
            }
            return View(model);
        }
    }
}