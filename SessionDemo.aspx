<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTemplate.Master" AutoEventWireup="true" CodeBehind="SessionDemo.aspx.cs" Inherits="SampleWebApp.SessionDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ChildContent" runat="server">
    <div>
            <h3>My Own Set Of Words!</h3>
        <p>
            Enter The Word:  <asp:TextBox runat="server" ID="txtWord"></asp:TextBox>
            <asp:Button Text="Save" runat="server" ID="btnSave" OnClick="btnSave_Click" />
        </p>
        <p>
            List Of Words:<br />
            <asp:ListBox runat="server" ID="lstWords" Height="358px" Width="258px">
               
            </asp:ListBox>
        </p>
    </div>
</asp:Content>
