<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTemplate.Master" AutoEventWireup="true" CodeBehind="Recipiant.aspx.cs" Inherits="SampleWebApp.Recipiant" %>
<%@ PreviousPageType VirtualPath="~/PreviousPageDemo.aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ChildContent" runat="server">
    <h2>
        Data Sent by the User!!
    </h2>
    <asp:Label ID="lblInfo" BorderColor="Black" BorderStyle="Dotted" Height="260px" Width="424px" runat="server" />
</asp:Content>
