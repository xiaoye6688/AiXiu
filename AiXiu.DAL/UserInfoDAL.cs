using AiXiu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiXiu.DAL
{
    public class UserInfoDAL
    {
        public bool IsMobileNo(string tel)
        {
            AiXiuDBContext db = new AiXiuDBContext();
            var model = db.TBLogins.FirstOrDefault(x => x.MobileNumber == tel);
            if (model==null)//未重复
            {
                return false;
            }
            return true;

        }
        public bool AddUser(string tel,string pwd)
        {
            AiXiuDBContext db = new AiXiuDBContext();
            var model = new TBLogins
            {
                MobileNumber = tel,

                Password = pwd,
                UserName = tel
            };
            db.TBLogins.Add(model);
            if (db.SaveChanges()>0)
            {
                return true;
            }
            return false;
        }
    }
}
