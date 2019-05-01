<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HW03._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.1/css/all.css" integrity="sha384-50oBUHEmvpQ+1lW4y57PTFmhCaXp0ML5d60M1M7uH2+nqUivzIebhndOJK28anvf" crossorigin="anonymous">
   
    <style>
        .error-template {
            padding: 40px 15px;
            text-align: center;
        }

        .error-actions {
            margin-top: 15px;
            margin-bottom: 15px;
        }

            .error-actions .btn {
                margin-right: 10px;
            }
    </style>

    <div runat="server" id="UnauthorisedUser">

        <div class="container">
            <div class="row">
                <div class="error-template">
                    <h1>Oops!</h1>
                    <h2>You are not logged in...</h2>

                    <div class="error-actions">
                        <a href="Login.aspx" class="btn btn-lg btn-success"><span class="glyphicon glyphicon-home"></span>
                            Login</a>
                    </div>
                </div>
            </div>
        </div>

    </div>

    <div runat="server" class="container">
        <div runat="server" id="UserInfo">
            <div class="jumbotron">
                <h1 runat="server" id="WelcomeUserInfo" class="display-4">Welcome, </h1>
                <a class="btn btn-warning btn-lg" href="Cart.aspx"><span class="fas fa-shopping-cart"></span>Cart</a>
                <asp:Button ID="logout" runat="server" Text="Logout" CssClass="btn btn-danger btn-lg" OnClick="logout_Click" />
            </div>
        </div>

        <div runat="server" id="BookInfo">
            <hr />
            <div runat="server" id="BookNames"></div>
        </div>
    </div>
</asp:Content>
