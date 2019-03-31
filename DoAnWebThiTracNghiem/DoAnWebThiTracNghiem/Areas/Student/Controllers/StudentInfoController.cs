using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWebThiTracNghiem.Areas.Student
{
    public class StudentInfoController : Controller
    {
        // GET: Student/StudentInfo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult InfoST()
        {
            return View();
        }
    }
}