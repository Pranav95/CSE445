<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staff2_add.aspx.cs" Inherits="Protected2_Staff2_add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>ADMIN PAGE FOR STAFF2</h1>
        <h2>GIVE ADMIN RIGHTS TO A USER</h2>
        <<div>
            <asp:TextBox ID="TextBox1" runat="server" Width="234px"></asp:TextBox>
        </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" Text="Change" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        <h2>Add a user to staff2</h2>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Width="234px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" Width="234px"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="Button2" runat="server" Text="Add" OnClick="Button2_Click" />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

        </p>
    </form>
</body>
</html>
