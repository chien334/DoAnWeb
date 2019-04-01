using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Model.DAO
{
    public class DeThiDAO
    {
        QLThiTracNghiem db = null;

        public DeThiDAO()
        {
            db = new QLThiTracNghiem();
        }
        public bool Insert(DeThi de)
        {
            try
            {
                db.DeThis.Add(de);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
