<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookInfo.aspx.cs" Inherits="HW03.BookInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">

        <div runat="server" class="container" id="errorDiv">
            <h1 runat="server" id="errorHeader"></h1>
            <a href="Default.aspx" class="btn btn-info btn-lg">Return to Main Page</a>
        </div>

        <div runat="server" class="container" id="bookInfoDiv">
            <div class="row">
                <div class="col-lg-4 col-sm-6">
                    <br />
                    <img runat="server" id="imageBook" class="img-thumbnail" src="" alt="">
                </div>
                <div class="col-lg-8">
                    <br>
                    <br>
                    <br>
                    <br>
                    <br>
                    <h1 runat="server" id="headerBookName">bookName</h1>
                    <h3 runat="server" id="headerAuthor">author</h3>
                    <h5 runat="server" id="headerPublisher">publisher</h5>
                    <h5 runat="server" id="headerPages">pages</h5>

                    <br>
                    <br>
                    <br>
                    <br>
                    <br>

                    <asp:Button ID="addToCart" runat="server" Text="Add to Cart" CssClass="btn btn-success btn-lg" OnClick="addToCart_Click" />
                    <a href="Cart.aspx" class="btn btn-warning btn-lg">Display Shopping Cart</a>
                    <a href="Default.aspx" class="btn btn-info btn-lg">Return to Main Page</a>
                </div>
            </div>


            <br />
            <div runat="server" id="alertSuccess" class="alert alert-success alert-dismissible fade show" role="alert">

                <strong>Book is added to the shopping cart.</strong>
                <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>

            <div runat="server" id="alertWarning" class="alert alert-warning alert-dismissible fade show" role="alert">
                <strong>Book is already in the list! </strong>
                <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>
        </div>
    </form>

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</body>
</html>
