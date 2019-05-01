using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW02
{
    public partial class Content : System.Web.UI.Page
    {
        const string FILE_PATH = "~/editorData.html";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Server.MapPath(FILE_PATH)))
                    editorContent.InnerHtml = File.ReadAllText(Server.MapPath(FILE_PATH));
            }
            catch (Exception)
            { Response.Redirect("Content.aspx"); }
        }
    }
}