using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW02
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string USERNAME_ADMIN = "admin";
        string PASSWORD_ADMIN = "passwd";

        string USERNAME_USER = "user";
        string PASSWORD_USER = "passwd";

        const string DESTINATION_URL_USER = "Content.aspx";
        const string DESTINATION_URL_ADMIN = "AdminPanel.aspx";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signIn_Click(object sender, EventArgs e)
        {
            string userName = inputUsername.Value;
            string password = inputPassword.Value;

            if (userName == USERNAME_ADMIN && password == PASSWORD_ADMIN)
            {

                Session.Add("LoggedIn", userName);
                Response.Redirect(DESTINATION_URL_ADMIN);

            }
            else if (userName == USERNAME_USER && password == PASSWORD_USER)
            {
                Session.Add("LoggedIn", userName);
                Response.Redirect(DESTINATION_URL_USER);
            }
        }
    }
}