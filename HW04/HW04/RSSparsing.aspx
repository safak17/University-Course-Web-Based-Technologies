<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RSSparsing.aspx.cs" Inherits="HW04.RSSparsing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HW04-RSSparsing</title>

    <!--REFERENCE REFRESH PAGE : https://stackoverflow.com/questions/1987125/how-to-refresh-a-web-page-automatically-every-specified-period-of-time -->
    <meta http-equiv="refresh" content="10"> 
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvNews" runat="server" BackColor="#6699FF" BorderColor="#666699" BorderStyle="Solid" BorderWidth="2px" Font-Bold="True" Font-Size="Large" ForeColor="White">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
