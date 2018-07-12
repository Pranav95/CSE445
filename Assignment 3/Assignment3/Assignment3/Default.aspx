<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>TRY IT PAGE</h1>
    
    <div class="row">
        <br>
        <p>Stemming service</p>
        <p>Takes string input</p>
        <br>

        <asp:TextBox ID="TextBox2" runat="server" Width="493px"></asp:TextBox>
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:Button ID="Button1" runat="server" Text="Get String" Width="103px" OnClick="Button1_Click" />
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="491px"></asp:TextBox>

    </div>
    <br>
    <br>
    <br>
    <div class="row">
        <br>
        <p>Stop words removal service</p>
        <p>Takes string input</p>
        <br>

        <asp:TextBox ID="TextBox1" runat="server" Width="493px"></asp:TextBox>
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:Button ID="Button2" runat="server" Text="Remove" Width="103px" OnClick="Button2_Click" />
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Width="491px"></asp:TextBox>

    </div>

    <br>
    <br>
    <br>
    <div class="row">
        <br>
        <p>TF IDF Score</p>
        <p>Takes two strings</p>
        <br>

        <asp:TextBox ID="TextBox5" runat="server" Width="493px"></asp:TextBox>
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:TextBox ID="TextBox6" runat="server" Width="491px"></asp:TextBox>
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:Button ID="Button3" runat="server" Text="Find" Width="103px" OnClick="Button3_Click" />
        &nbsp;
        &nbsp;
        &nbsp;
        
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        
      <div class="row">
        <br>
        <p>Get Movie by tags</p>
        <p>Example movie tags - magician, illlusion, space</p>
        <p>Takes string input</p>
        <br>

        <asp:TextBox ID="TextBox7" runat="server" Width="493px"></asp:TextBox>
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:Button ID="Button4" runat="server" Text="Get Movie" Width="103px" OnClick="Button4_Click" />
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:TextBox ID="TextBox8" runat="server" Width="491px"></asp:TextBox>

    </div>
    
        <div class="row">
        <br>
        <p>Add movie</p>
        <p>Enter movie and tags seperated by space</p>
        <p>First textbox takes movie name and second takes tags</p>
        <br>

        <asp:TextBox ID="TextBox9" runat="server" Width="493px"></asp:TextBox>
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:TextBox ID="TextBox10" runat="server" Width="491px"></asp:TextBox>
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:Button ID="Button5" runat="server" Text="Add" Width="103px" OnClick="add_movie" />
        &nbsp;
        &nbsp;
        &nbsp;
    

    </div>


     
</asp:Content>
