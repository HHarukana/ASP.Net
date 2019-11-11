<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PlotPreOrder.aspx.cs" Inherits="PlotPreOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainPageContent" Runat="Server">

    <h1>Cemetary Plot Pre Order</h1>
    <asp:Label ID="lblPlot_ID" runat="server" />
    <br />

    <asp:Label ID="lblcurrDate" runat="server" Text="Current Date: "></asp:Label>
    <asp:Label ID="txtcurrDate" runat="server"></asp:Label>
    
    <br />

    <br />

    <asp:Label ID="lblcemetary" runat="server" Text="Cemetary: "></asp:Label>
    <asp:DropDownList ID="ddcemetary" runat="server">

        <asp:ListItem Selected="True" Value="0" Text="Choose One" />
        <asp:ListItem Value="East Greenwhich Cemetary" Text="East Greenwhich Cemetary" />  
        <asp:ListItem Value="Glenwood Cemetary" Text="Glenwood Cemetary" />
        <asp:ListItem Value="Quidnessett Memorial Cemetary" Text="Quidnessett Memorial Cemetary" /> 

    </asp:DropDownList>
    <br />

    <br />

    <asp:Label ID="lblfirstName" runat="server" Text="First Name: "></asp:Label>
    <asp:TextBox ID="txtfirstName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID ="ReqFieldFirst" runat="server" ControlToValidate="txtfirstName" ErrorMessage="Must Have a First Name"></asp:RequiredFieldValidator>
    <br />

    <br />

    <asp:Label ID="lblmiddleName" runat="server" Text="Middle Name: "></asp:Label>
    <asp:TextBox ID="txtmiddleName" runat="server"></asp:TextBox>
    <br />

    <br />

    <asp:Label ID="lbllastName" runat="server" Text="Last Name: "></asp:Label>
    <asp:TextBox ID="txtlastName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID ="ReqFieldLast" runat="server" ControlToValidate="txtlastName" ErrorMessage="Must Have a Last Name"></asp:RequiredFieldValidator>
    <br />

    <br />

    <asp:Label ID="lbltitle" runat="server" Text="Title: "></asp:Label>
    <asp:DropDownList ID="ddtitle" runat="server">

        <asp:ListItem Selected="True" Value="0" Text="Choose One" />
        <asp:ListItem Value="1" Text="Grandfather" />
        <asp:ListItem Value="2" Text="Grandmother" />
        <asp:ListItem Value="3" Text="Father" />
        <asp:ListItem Value="4" Text="Mother" />
        <asp:ListItem Value="5" Text="Son" />
        <asp:ListItem Value="6" Text="Daughter" />
        <asp:ListItem Value="7" Text="Husband" /> 
        <asp:ListItem Value="8" Text="Wife"/> 
        


    </asp:DropDownList>
    <br />

    <br />

    <asp:Label ID="lblDOB" runat="server" Text="Date of Birth: "></asp:Label>
    <asp:Calendar ID="calDOB" runat="server"  OnSelectionChanged="calDOB_SelectionChanged"></asp:Calendar>
    <asp:TextBox ID="txtCalDOB" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID ="ReqFieldDOB" runat="server" ControlToValidate="txtcalDOB" ErrorMessage="Must Have a Date of Birth"></asp:RequiredFieldValidator>
    <br />
    <br />
    <br />

    <asp:Label ID="lblDOD" runat="server" Text="Date of Death: "></asp:Label>
    <asp:Calendar ID="calDOD" runat="server" OnSelectionChanged="calDOD_SelectionChanged"></asp:Calendar>
    <asp:TextBox ID="txtCalDOD" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID ="ReqFieldDOD" runat="server" ControlToValidate="txtcalDOB" ErrorMessage="Must Have a Date of Death"></asp:RequiredFieldValidator>
    <br />

    <asp:Label ID="lblvet" runat="server" Text="Military Vet: "></asp:Label>
    <asp:CheckBox ID="checkVet" Checked="false" AutoPostBack="true" runat="server" />
    <br />

    <br />

    <asp:Label ID="lblbranch" runat="server" Text="Military Branch: "></asp:Label>
    <asp:DropDownList ID="ddbranch"  runat="server" OnSelectedIndexChanged="ddbranch_SelectedIndexChanged">

        <asp:ListItem Selected="True" Value="0" Text="Choose One" /> 
        <asp:ListItem Value="1" Text="US Army"/>
        <asp:ListItem Value="2" Text="Air Force"/>
        <asp:ListItem Value="3" Text="Navy" /> 
        <asp:ListItem Value="4" Text="Us Marine" /> 
        <asp:ListItem Value="5" Text="Coast Guard" /> 

    </asp:DropDownList>
    <br />

    <br />

    <asp:Label ID="lblstone" runat="server" Text="Stone Type: "></asp:Label>
    <asp:DropDownList ID="ddstone" runat="server">

        <asp:ListItem Selected="True" Value="0" Text="Choose One" /> 
        <asp:ListItem Value="1" Text="Granite" /> 
        <asp:ListItem Value="2" Text="Marble" /> 
        <asp:ListItem Value="3" Text="Limestone" /> 

    </asp:DropDownList>
    <br />

    <br />

    <asp:Label ID="lblnote" runat="server" Text="Note: "></asp:Label>
    <asp:TextBox ID="txtnote" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID ="ReqFieldNote" runat="server" ControlToValidate="txtnote" ErrorMessage="Must Have something to write"></asp:RequiredFieldValidator>
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

