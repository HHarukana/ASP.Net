<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ContactManager.aspx.cs" Inherits="Controls_ContactManager" %>



<asp:Content ID ="content1" ContentPlaceHolderID="head" Runat="server">



</asp:Content>

<asp:Content ID ="content2" ContentPlaceHolderID="pageMainContent" Runat="server">

    <h1>Please Add Your Contact Information</h1>
    <br />

    <asp:Label ID="lblPerson_ID" runat="server" />

    <asp:Label ID="lblFName" runat="server" Text="First Name:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID ="reqFieldFirst" runat="server" ControlToValidate="txtFName" ErrorMessage="You Must Enter a First Name."></asp:RequiredFieldValidator>
    <br />

    <asp:Label ID="lblMName" runat="server" Text="Middle Name"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtMName" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="lblLName" runat="server" Text="Last Name"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID ="reqFieldLast" runat="server" ControlToValidate="txtLName" ErrorMessage="You Must Enter a Last Name."></asp:RequiredFieldValidator>
    <br />

    <asp:Label ID="lblStreet" runat="server" Text="Street Address:"></asp:Label>
    &nbsp;&nbsp;
    <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID ="reqFieldStreet" runat="server" ControlToValidate="txtStreet" ErrorMessage="You Must Enter a Street."></asp:RequiredFieldValidator>
    <br />

    <asp:Label ID="lblCity" runat="server" Text="City:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID ="reqFieldCity" runat="server" ControlToValidate="txtCity" ErrorMessage="You Must Enter a City."></asp:RequiredFieldValidator>
    <br />

    <asp:Label ID="lblState" runat="server" Text="State:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID ="reqFieldState" runat="server" ControlToValidate="txtState" ErrorMessage="You Must Enter a State."></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID ="regExpressionState" runat="server" ControlToValidate="txtState" ValidationExpression="^(?-i:A[LKSZRAEP]|C[AOT]|D[EC]|F[LM]|G[AU]|HI|I[ADLN]|K[SY]|LA|M[ADEHINOPST]|N[CDEHJMVY]|O[HKR]|P[ARW]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY])" ErrorMessage="Not a Valid US State ID, 2 Capital Letters Only"></asp:RegularExpressionValidator>
    <br />

    <asp:Label ID="lblZip" runat="server" Text="Zip Code:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID ="reqFieldZip" runat="server" ControlToValidate="txtZip" ErrorMessage="You Must Enter a Zip Code."></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID ="regExpressionZip" runat="server" ControlToValidate="txtZip" ValidationExpression="\d{5}" ErrorMessage="You Must Enter a Zip Code. 5 digits only."></asp:RegularExpressionValidator>
    <br />

    <asp:Label ID="lblNum" runat="server" Text="Phone Number:"></asp:Label>
    &nbsp; <asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID ="regExpressionPhone" runat="server" ControlToValidate="txtNum" ValidationExpression="\d{3}\d{3}\d{4}" ErrorMessage="Not a Valid Phone Number 1111111111"></asp:RegularExpressionValidator>
    <br />

    <asp:Label ID="lblMail" runat="server" Text="Email:"></asp:Label>      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID ="reqFieldMail" runat="server" ControlToValidate="txtMail" ErrorMessage="You Must Enter a Email Adress."></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID ="regExpressionMail" runat="server" ControlToValidate="txtMail" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" ErrorMessage="Not a Valid Email Address. name@name.com or name@name.co"></asp:RegularExpressionValidator>
    <br />


    <br />

    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

    <br />

    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />

    <br />

    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />

    <br />
    <br />
    
    <asp:Label ID="lblFeedback" runat="server" Text=""></asp:Label>
    

    <br />
    
    
    

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

