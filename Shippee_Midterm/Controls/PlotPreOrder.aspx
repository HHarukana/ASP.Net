<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PlotPreOrder.aspx.cs" Inherits="PlotPreOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainPageContent" Runat="Server">

    <h1>Cemetary Plot Pre Order</h1>
    <asp:Label ID="lblPlot_ID" runat="server" />
    <br />

    <asp:Label ID="lblcurrDate" runat="server" Text="Current Date: "></asp:Label>
    <asp:TextBox ID="txtcurrDate" runat="server"></asp:TextBox>
    <br />

    <br />

    <asp:Label ID="lblcemetary" runat="server" Text="Cemetary: "></asp:Label>
    <asp:DropDownList ID="ddcemetary" runat="server">

        <asp:ListItem Selected="True" Value="default"> Choose One </asp:ListItem>
        <asp:ListItem Value="listEGCemetary"> East Greenwhich Cemetary </asp:ListItem>
        <asp:ListItem Value="listGlenCemetary"> Glenwood Cemetary </asp:ListItem>
        <asp:ListItem Value="listQuidCemetary"> Quidnessett Memorial Cemetary </asp:ListItem>

    </asp:DropDownList>
    <br />

    <br />

    <asp:Label ID="lblfirstName" runat="server" Text="First Name: "></asp:Label>
    <asp:TextBox ID="txtfirstName" runat="server"></asp:TextBox>
    <br />

    <br />

    <asp:Label ID="lblmiddleName" runat="server" Text="Middle Name: "></asp:Label>
    <asp:TextBox ID="txtmiddleName" runat="server"></asp:TextBox>
    <br />

    <br />

    <asp:Label ID="lbllastName" runat="server" Text="Last Name: "></asp:Label>
    <asp:TextBox ID="txtlastName" runat="server"></asp:TextBox>
    <br />

    <br />

    <asp:Label ID="lbltitle" runat="server" Text="Title: "></asp:Label>
    <asp:DropDownList ID="ddtitle" runat="server">

        <asp:ListItem Selected="True" Value="default"> Choose One </asp:ListItem>
        <asp:ListItem Value="listGFather"> Grandfather </asp:ListItem>
        <asp:ListItem Value="listGMother"> Grandmother </asp:ListItem>
        <asp:ListItem Value="listFather"> Father </asp:ListItem>
        <asp:ListItem Value="listMother"> Mother </asp:ListItem>
        <asp:ListItem Value="listSon"> Son </asp:ListItem>
        <asp:ListItem Value="listDaughter"> Daughter </asp:ListItem>
        <asp:ListItem Value="listHusband"> Husband </asp:ListItem>
        <asp:ListItem Value="listWife"> Wife </asp:ListItem>
        


    </asp:DropDownList>
    <br />

    <br />

    <asp:Label ID="lblDOB" runat="server" Text="Date of Birth: "></asp:Label>
    <asp:Calendar ID="calDOB" runat="server"></asp:Calendar>
    <br />

    <asp:Label ID="lblDOD" runat="server" Text="Date of Death: "></asp:Label>
    <asp:Calendar ID="calDOD" runat="server"></asp:Calendar>
    <br />

    <asp:Label ID="lblvet" runat="server" Text="Military Vet: "></asp:Label>
    <asp:CheckBox ID="checkVet" runat="server" />
    <br />

    <br />

    <asp:Label ID="lblbranch" runat="server" Text="Military Branch: "></asp:Label>
    <asp:DropDownList ID="ddbranch" runat="server">

        <asp:ListItem Selected="True" Value="default"> Choose One </asp:ListItem>
        <asp:ListItem Value="listArmy"> US Army </asp:ListItem>
        <asp:ListItem Value="listAirForce"> Air Force </asp:ListItem>
        <asp:ListItem Value="listNavy"> Navy </asp:ListItem>
        <asp:ListItem Value="listMarine"> US Marine </asp:ListItem>
        <asp:ListItem Value="listCoastGuard"> Coast Guard </asp:ListItem>

    </asp:DropDownList>
    <br />

    <br />

    <asp:Label ID="lblstone" runat="server" Text="Stone Type: "></asp:Label>
    <asp:DropDownList ID="ddstone" runat="server">

        <asp:ListItem Selected="True" Value="default"> Choose One </asp:ListItem>
        <asp:ListItem Value="listGranite"> Granite </asp:ListItem>
        <asp:ListItem Value="listMarble"> Marble </asp:ListItem>
        <asp:ListItem Value="listLimestone"> Limestone </asp:ListItem>

    </asp:DropDownList>
    <br />

    <br />

    <asp:Label ID="lblnote" runat="server" Text="Note: "></asp:Label>
    <asp:TextBox ID="txtnote" runat="server"></asp:TextBox>
    <br />
    
    <br />
    
    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
    <br />
    <br />
    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
    <br />
    <br />
    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
    <br />
    <br />

    <asp:Label ID="lblFeedback" runat="server" Text=""></asp:Label>
    

    <br />

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="sidePageContent" Runat="Server">
</asp:Content>

