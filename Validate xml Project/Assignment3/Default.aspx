<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>TRY IT PAGE</h1>
    
    <div class="row">
        <br>
        <p>Verification service</p>
        <p>Takes URL of XML and the URL of XMLS file and validates the xml file.</p>
        <br>

        <asp:TextBox ID="TextBox2" runat="server" Width="493px"></asp:TextBox>
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="491px"></asp:TextBox>

    </div>
        <asp:Button ID="Button1" runat="server" Text="Verify" Width="103px" OnClick="Verification" />
    <br>
    <br>
    <br />
    <br />
    <br />

        <asp:TextBox ID="TextBox5" runat="server" Width="693px" Height="216px"></asp:TextBox>
        <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br>
    <div class="row">
        <br>
        <p>Transformation service</p>
        <p>Takes URL of XML and the URL of XSL file and trasform the xml file.</p>
        <br>

        <asp:TextBox ID="TextBox1" runat="server" Width="493px"></asp:TextBox>
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Width="491px"></asp:TextBox>

    </div>
        <asp:Button ID="Button2" runat="server" Text="Transform" Width="103px" OnClick="Transform" />
    <br>
    <br>
    <br />
    <br />
    <br />

        <br />
    
    <br>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br>
    <br>
    <div class="row">
        <br>
        &nbsp;
        &nbsp;
        
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <div class="row">
            <p>y</p>

    </div>
    </div>
</asp:Content>
