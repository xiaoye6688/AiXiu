using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiXiu.DAL;

namespace AiXiu.BLL
{
    public class UserInfoBLL
    {
        public string ADDUser(string tel ,string pwd)
        {
            UserInfoDAL userInfoDAL = new UserInfoDAL();
            if (userInfoDAL.IsMobileNo(tel))
            {
                return "手机号已存在";
            }
            else
            {
                if (userInfoDAL.AddUser(tel,pwd))
                {
                    return "注册成功";
                }
                else
                {
                    return "注册失败";
                }
            }
        }
    }
}
