using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace HW03
{
    public partial class Cart : System.Web.UI.Page
    {
        public List<Book> BooksList;
        public ArrayList SelectedBookIDs;



        protected void Page_Load(object sender, EventArgs e)
        {
            BooksList = (List<Book>)Session["BooksList"];
            SelectedBookIDs = (ArrayList)Session["SelectedBookIDs"];
        }
    }
}