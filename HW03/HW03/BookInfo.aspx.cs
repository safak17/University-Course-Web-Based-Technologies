using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace HW03
{
    public partial class BookInfo : System.Web.UI.Page
    {
        Book book = null;
        string bookId = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            errorDiv.Visible = false;
            alertSuccess.Visible = false;
            alertWarning.Visible = false;


            
            if (Request.QueryString["id"] != null)
            {
                bookId = (string)Request.QueryString["id"];
            }
            else
            {
                errorHeader.InnerText = "Please, specify a Book ID !";
                errorDiv.Visible = true;
            }


            if (!string.IsNullOrEmpty(bookId))
            {
                List<Book> booksList = (List<Book>)Session["booksList"];
                

                try
                {
                    book = booksList.First(b => b.BookID.ToString() == bookId);
                }
                catch (Exception)
                {
                    errorHeader.InnerText = "Invalid Book ID !";
                    errorDiv.Visible = true;
                    bookInfoDiv.Visible = false;
                }

                if( book != null)
                {
                    imageBook.Src = book.ImageUrl;
                    headerBookName.InnerText = book.Title;
                    headerAuthor.InnerText = "by " + book.Author;
                    headerPublisher.InnerText = "Publisher: " + book.Publisher;
                    headerPages.InnerText = "Page Number: " + book.PageNumber.ToString();
                }
            }
        }

        protected void addToCart_Click(object sender, EventArgs e)
        {
            ArrayList SelectedBookIDs = (ArrayList) Session["SelectedBookIDs"];

            if( SelectedBookIDs.Count != 0 && SelectedBookIDs.Contains(bookId))
            {
                alertWarning.Visible = true;
            }
            else
            {
                SelectedBookIDs.Add(bookId);
                Session["SelectedBookIDs"] = SelectedBookIDs;
                alertSuccess.Visible = true;
            }
        }
    }
}