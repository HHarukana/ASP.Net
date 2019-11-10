<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PlotSearch.aspx.cs" Inherits="Controls_PlotSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainPageContent" Runat="Server">
    First Name:<asp:TextBox ID="srcFName" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    Last Name:<asp:TextBox ID="srcLName" runat="server"></asp:TextBox>
    <br /><br />
    <asp:button runat="server" ID="btnSearch" text="Search" OnClick="btnSearch_Click" />
    <br /><br />

     <asp:GridView runat="server" ID="gvPerson" AutoGenerateColumns="false" >
        <Columns>
            <asp:BoundField DataField="Cemetary" HeaderText="Cemetary"  />
            <asp:BoundField DataField="LastName" HeaderText="Last Name" />
            <asp:HyperLinkField Text="Edit" DataNavigateUrlFormatString="PlotPreOrder.aspx?Plot_ID={0}" DataNavigateUrlFields="PlotID" />
            <asp:HyperLinkField Text="Delete" DataNavigateUrlFormatString="PlotPreOrder.aspx?Plot_ID={0}" DataNavigateUrlFields="PlotID" />
        </Columns>
    </asp:GridView>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="sidePageContent" Runat="Server">
</asp:Content>

