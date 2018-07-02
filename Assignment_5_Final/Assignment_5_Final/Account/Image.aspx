<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Image.aspx.cs" Inherits="Image" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
<h5>Please verify </h5>
    
        <asp:Image ID="Image1" runat="server"/> <br />
        <asp:Button ID="btn_newIMG" runat="server" Text="New image" Height="34px" Width="117px" OnClick="btn_newIMG_Click" /> 
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lblVerify" runat="server">Enter the characters in the image:</asp:Label> 
        <asp:TextBox ID="txtVerify" style='width:110px' runat="server"></asp:TextBox>
         <asp:Button ID="btn_verify" runat="server" Text="Verify" Height="34px" Width="117px" OnClick="btn_verify_Click"/>
    

        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </form>
    

</body>
</html>
