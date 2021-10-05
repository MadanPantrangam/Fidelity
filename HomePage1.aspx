<%@ page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterTemplate.Master" CodeBehind="~/HomePage1.aspx.cs" Inherits="SampleWebApp.HomePage1" %>
<asp:Content ContentPlaceHolderID="ChildContent" runat="server" ID="content1">
     <h1>Welcome To FNFI</h1>
        <div style="vertical-align:central">
            <h1>
                <asp:Label Text="Enter Name" runat="server" />
                <asp:TextBox runat="server" ID="txtName"/>
               <%-- <asp:Button ID="btnSave"Text="Submit" runat="server"/>--%>
                <asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click" />
              <%--  <button onclick="ClickMe()">Click Me</button>--%>
            </h1>
        </div>
        <div>
            <asp:Label Text="" ID="lblInfo" runat="server" />
        </div>
</asp:Content>