using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW02
{
    public partial class AdminPanel : System.Web.UI.Page
    {
        const string FILE_PATH = "~/editorData.html";

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string loggedIn = Session["LoggedIn"].ToString();
                if (String.IsNullOrEmpty(loggedIn) || loggedIn != "admin")
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    if(!IsPostBack)
                        if (File.Exists(Server.MapPath(FILE_PATH)))
                            rte.Text = File.ReadAllText(Server.MapPath(FILE_PATH));
                }
            }
            catch (Exception)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void rte_SaveButtonClick(object sender, EventArgs e)
        {
            using (StreamWriter _testData = new StreamWriter(Server.MapPath(FILE_PATH)))
            {
                _testData.Write(rte.Text);
            }
        }
    }
}