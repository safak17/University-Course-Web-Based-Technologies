using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW03
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signIn_Click(object sender, EventArgs e)
        {
            Response.Cookies["userCookie"]["firstName"] = inputFirstName.Value;
            Response.Cookies["userCookie"]["lastName"]  = inputLastName.Value;
            Response.Cookies["userCookie"].Expires      = DateTime.Now.AddMonths(1);
            Response.Redirect("Default.aspx");
        }
    }
}