<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Quotes and Weather</h1>
        <p>Check weather and get an inspirational quote. </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Login And Register</h2>
            <p>
                Register or Login</p>
            <p>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Register" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Staff Login </h2>
            <p>
                Staff Login
            </p>
            <p>
                &nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Staff1" />
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Staff2" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>&nbsp;&nbsp; </h2>
        </div>
    </div>
</asp:Content>
