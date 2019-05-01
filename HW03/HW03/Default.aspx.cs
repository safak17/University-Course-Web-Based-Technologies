using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace HW03
{
  
    public partial class _Default : Page
    {

        List<Book> BooksList = new List<Book>() {
            new Book(1, "ASP.NET 3.5 Unleashed", "Stephen Walther", "Sams", 1920, 
                "https://images-na.ssl-images-amazon.com/images/I/51JKj34lqwL._SX381_BO1,204,203,200_.jpg"),
            new Book(2, "ASP.NET Evolution", "Dan Kent", "Sams", 384, 
                "https://images-na.ssl-images-amazon.com/images/I/51RcJe0xzuL._SX402_BO1,204,203,200_.jpg"),
            new Book(3, "Mastering Web Development with Microsoft Visual Studio 2015", "John Paul Mueller", "Sams", 848,
                "https://img1.od-cdn.com/ImageType-400/0128-1/B08/A60/5A/%7BB08A605A-4DD9-4F1F-81E3-CB71FEE87380%7DImg400.jpg"),
            new Book(4, "Beginning ASP.NET 2.0", "14", "19", 792,
                "https://covers.oreillystatic.com/images/9780764588501/lrg.jpg"),
            new Book(5, "Beginning ASP.NET in C# 2008: From Novice to Professional, Second Edition", "Matthew MacDonald", "Apress", 954,
                "https://images-na.ssl-images-amazon.com/images/I/51BPnaiuPYL._SX388_BO1,204,203,200_.jpg")
        };

        ArrayList SelectedBookIDs = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {
            AddBooksToSession();

            //  Reference: http://www.btdersleri.com/ders/AspNet-Cookie-Kullan%C4%B1m%C4%B1
            if ( Request.Cookies["userCookie"] != null)
            {
                string firstName = Request.Cookies["userCookie"]["firstName"];
                string lastName  = Request.Cookies["userCookie"]["lastName"];

                if (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
                {
                    UnauthorisedUser.Visible = true;
                    UserInfo.Visible = false;
                }
                else
                {
                    UnauthorisedUser.Visible = false;
                    UserInfo.Visible = true;
                    WelcomeUserInfo.InnerText += firstName + " " + lastName;

                    BookInfo.Visible = true;

                    foreach(Book book in BooksList)
                    {
                        BookNames.InnerHtml += "<a class='btn btn-lg' href='BookInfo.aspx?id=" + book.BookID + "'>" + book.Title + "</a><br/>";
                    }
                }
            }
            else
            {
                UserInfo.Visible = false;
                BookInfo.Visible = false;
            }
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Response.Cookies["userCookie"].Expires = DateTime.Now.AddDays(-1);
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        public void AddBooksToSession()
        {
            Session["BooksList"] = BooksList;
            
            if(null == (ArrayList)Session["SelectedBookIDs"])
            {
                Session["SelectedBookIDs"] = SelectedBookIDs;
            }
                
        }
    }
}