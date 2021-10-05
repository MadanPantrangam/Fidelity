<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTemplate.Master" AutoEventWireup="true" CodeBehind="CookiesDemo.aspx.cs" Inherits="SampleWebApp.CookiesDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ChildContent" runat="server">
      <h1>Cookies Demo Example!!!</h1>
    <hr />
    <div>
        <p>
            Enter The Name: <asp:TextBox runat="server" ID="txtName"/>
            <asp:RequiredFieldValidator ErrorMessage="Name is Mandatory" ForeColor="IndianRed" ControlToValidate="txtName" runat="server"></asp:RequiredFieldValidator>

        </p>
        <p>
                        Enter The Email Address: <asp:TextBox runat="server" ID="txtEmailAddress"/>
            <asp:RegularExpressionValidator ErrorMessage="E-Mail is not in Proper format!" ForeColor="IndianRed" ControlToValidate="txtEmailAddress" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" runat="server"></asp:RegularExpressionValidator>

        </p>
        <p>
                <asp:Button Text="Send Info" runat="server" ID="btnSend" OnClick="btnSend_Click" />
        </p>
    </div>
</asp:Content>
