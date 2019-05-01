<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="HW03.Cart" %>

<%@ Import Namespace="HW03" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div runat="server" class="container" id="bookInfoDiv">
            <div class="container mt-2 d-flex justify-content-center">
                <a href="Default.aspx" class="btn btn-info btn-lg">Return to Main Page</a>
            </div>
            <%
                if (SelectedBookIDs.Count != 0)
                {
                    foreach (string bookId in SelectedBookIDs)
                    {
                        Book book = BooksList.First(b => b.BookID.ToString() == bookId);
            %>

                        <div class="row">
                            <div class="col-lg-4 col-sm-6">
                                <br />
                                <img id="imageBook" class="img-thumbnail" src="<%= book.ImageUrl%>" alt="">
                            </div>
                            <div class="col-lg-8">
                                <br><br><br><br><br>
                                <h1 id="headerBookName"><%= book.Title %></h1>
                                <h3 id="headerAuthor"><%= book.Author %></h3>
                                <h5 id="headerPublisher"><%= book.Publisher %></h5>
                                <h5 id="headerPages"><%= book.PageNumber %></h5>
                                <br><br><br><br><br>
                            </div>
                        </div>

            <%      }// foreach
                } // if(SelectedBookIDs.Count != 0)
                else
                {
            %>
                    <div runat="server" class="container mt-2 d-flex justify-content-center">
                        <h1 id="errorHeader">Your shopping cart is empty.</h1>
                    </div>

            <%} %>
        </div>
    </form>

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</body>
</html>
