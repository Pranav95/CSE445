<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staff1Login.aspx.cs" Inherits="Protected_Staff2Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <h2>LOGIN PAGE FOR STAFF 1</h2>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="28px" Width="233px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Height="28px" Width="233px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="125px" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
