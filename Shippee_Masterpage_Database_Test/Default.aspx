<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<script runat="server">

</script>

<asp:Content ID ="content1" ContentPlaceHolderID="head" Runat="server">



</asp:Content>

<asp:Content ID ="content2" ContentPlaceHolderID="pageMainContent" Runat="server">

    <h1>Shippee's Snacks is here to serve</h1>
    <asp:image id="Snacks" runat="server" imageurl="~/images/snack.jpg" />
    

</asp:Content>

<asp:Content ID ="content3" ContentPlaceHolderID="pageSideContent" Runat="server">

    <h2>Snacks<br />
    Chips<br />
    Power Bars<br />
    Sandwiches<br />
    PopTarts<br />
    Muffins<br />
    Patries<br />
    Soda<br />
    Water<br />
    </h2>
    


</asp:Content>