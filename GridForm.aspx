<%@ page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterTemplate.Master" CodeBehind="~/GridForm.aspx.cs" Inherits="SampleWebApp.GridForm" %>
<asp:Content ContentPlaceHolderID="ChildContent" runat="server" ID="content1">
    <div>
            <asp:GridView runat="server" ID="grdDetails" OnSelectedIndexChanged="grdDetails_SelectedIndexChanged"></asp:GridView>
        </div>
</asp:Content>