<%@ Page Title="Card Validation" CodeBehind="Default.aspx.cs" Inherits="Homework_1._Default" %>
<form id="form1" runat="server">
    <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="Red" Text="Verify Your Card Here"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="lblSelectCreditCard" runat="server" Font-Bold="True" Font-Size="Large" Text="Select Credit Card:"></asp:Label>
&nbsp;&nbsp;
    <asp:DropDownList ID="ddlCardNames" runat="server" AutoPostBack="True">
        <asp:ListItem Value="Unknown"></asp:ListItem>
        <asp:ListItem>MasterCard</asp:ListItem>
        <asp:ListItem>Visa</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblCreditCardNumber" runat="server" Font-Bold="True" Font-Size="Large" Text="Credit Card Number:"></asp:Label>
&nbsp;
    <asp:TextBox ID="tbCardNumber" runat="server" AutoPostBack="True" OnTextChanged="tbCardNumber_TextChanged" Width="256px"></asp:TextBox>
&nbsp;
    <asp:Button ID="btnCheck" runat="server" OnClick="btnCheck_Click" Text="Check" BorderColor="Black" BorderWidth="2px" />
    <br />
    <br />
    <br />
</form>

