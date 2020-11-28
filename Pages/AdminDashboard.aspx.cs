using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebIntroduce_BTL.Pages
{
    
    public partial class AdminDashboard : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                btn_Product.BorderColor = Color.Red;
                btn_Product.Font.Bold = true;
            }
            
        }
    }
}