using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAPI_Form.Controller;
using System.Web.Http;
using System.Net.Http;

namespace WebIntroduce_BTL.Pages
{
    public partial class SignInPages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            String _user = txt_Email.ToString();
            Response.Write("USER name = " + _user);

        }
    }
}