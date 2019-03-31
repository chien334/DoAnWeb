using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class DeThiDAO
    {
        QLThiTracNghiem db = null;
        public DeThiDAO()
        {
            db = new QLThiTracNghiem();
        }
        public int Insert(DeThi dt)
        {
            db.DeThis.Add(dt);
            db.SaveChanges();
            return dt.MaDe;
        }
    }
}
