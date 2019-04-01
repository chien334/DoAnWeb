using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAnWebThiTracNghiem.Areas.Teacher.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Xin hãy nhập tài khoản")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Xin hãy nhập mật khẩu")]
        public string PassWord { get; set; }
        public bool Remember { get; set; }
    }
}