using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class UserDao
    {
        QLThiTracNghiem _db = null;
        public UserDao()
        {
            _db = new QLThiTracNghiem();
        }
        public string Insert(GiaoVien entity)
        {
            _db.GiaoViens.Add(entity);
            _db.SaveChanges();
            return entity.MaGV;
        }
        public GiaoVien GetByID(string username)
        {
            return _db.GiaoViens.SingleOrDefault(x => x.MaGV == username);
        }
        public int Login(string UserName, string PassWord)
        {
            var result = _db.GiaoViens.SingleOrDefault(x => x.MaGV == UserName);
            if (result == null)
            {
                return 0;   // tai khoan khong ton tai
            }
            else
            {
                if (result.PassWordHash == PassWord)
                {
                    return 1;   // dang nhap thanh cong
                }
                else
                {
                    return -2;  // sai mat khau
                }
            }
        }
        public bool CheckUserName(string username)
        {
            return _db.GiaoViens.Count(x => x.MaGV == username) > 0;
        }

    }
}
