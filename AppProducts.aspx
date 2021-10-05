<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTemplate.Master" AutoEventWireup="true" CodeBehind="AppProducts.aspx.cs" Inherits="SampleWebApp.AppProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ChildContent" runat="server">
    <div>
           <p>
               List Of Products : <br />
               <asp:ListBox runat="server" ID="lstProducts" Height="358px" Width="258px">
                   <asp:ListItem Text="ItemId" Value="ItemId" />
                   <asp:ListItem Text="ItemName" />
                    <asp:ListItem Text="ItemPrice" />
                   <asp:ListItem Text="ItemQuantity" />
               </asp:ListBox>
           </p>
    </div>
</asp:Content>
 