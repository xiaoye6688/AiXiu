using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AiXiu.BLL;

namespace AiXiu.WebSite
{
    public partial class aixiu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnReg_Click(object sender, EventArgs e)
        {
            UserInfoBLL UserInfoBLL = new UserInfoBLL();
            string msg = UserInfoBLL.ADDUser(txtTel.Text, txtPwd.Text);
        }
    }
}