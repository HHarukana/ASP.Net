<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ControlPanel.aspx.cs" Inherits="Controls_ControlPanel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageMainContent" Runat="Server">
    <h1>Welcome to Admin World</h1>

    <a href="ContactManager.aspx" runat="server">Contact Information</a>
    <br />
    <br />
    <a href="PersonSearch.aspx" runat="server">Contact Search</a>
   
    <asp:Button ID="btnOut" runat="server" Text="Logout" OnClick="btnOut_Click" />
   

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pageSideContent" Runat="Server">
</asp:Content>

