<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PersonSearch.aspx.cs" Inherits="Controls_PersonSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageMainContent" Runat="Server">
    First Name:<asp:TextBox ID="srcFName" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    Last Name:<asp:TextBox ID="srcLName" runat="server"></asp:TextBox>
    <br /><br />
    <asp:button runat="server" ID="btnSearch" text="Search" OnClick="btnSearch_Click" />
    <br /><br />

    <asp:GridView runat="server" ID="gvPerson" AutoGenerateColumns="false" >
        <Columns>
            <asp:BoundField DataField="FirstName" HeaderText="First Name"  />
            <asp:BoundField DataField="LastName" HeaderText="Last Name" />
            <asp:HyperLinkField Text="Edit" DataNavigateUrlFormatString="ContactManager.aspx?Per_ID={0}" DataNavigateUrlFields="PersonID" />
            <asp:HyperLinkField Text="Delete" DataNavigateUrlFormatString="ContactManager.aspx?Per_ID={0}" DataNavigateUrlFields="PersonID" />
        </Columns>
    </asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pageSideContent" Runat="Server">
</asp:Content>

