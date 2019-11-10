<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Controls_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="mainPageContent" Runat="Server">

    <asp:Label ID="lblUser" runat="server" Text="Username: "></asp:Label>
    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>

    <br />

    <asp:Label ID="lblPass" runat="server" Text="Password:"></asp:Label>
    <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>

    <br />

    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />

    <br />

    <asp:Label ID="lblIssue" runat="server" Text=""></asp:Label>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="sidePageContent" Runat="Server">
</asp:Content>

