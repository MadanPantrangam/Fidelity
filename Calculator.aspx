<%@ page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterTemplate.Master" CodeBehind="~/Calculator.aspx.cs" Inherits="SampleWebApp.Calculator" %>
<asp:Content ContentPlaceHolderID="ChildContent" runat="server" ID="content1">
    	    <div>
            <h1>Welcome to Calculations</h1>
            <hr />
            <p>
                Enter The First Value : <asp:TextBox runat="server" ID="txtfirst"/>
            </p>
             <p>
                Enter The Second Value : <asp:TextBox runat="server" ID="txtSecond"/>
            </p>
            <p>
                Select The Operation : 
                <asp:DropDownList runat="server" ID="dpList">
                    <asp:ListItem Text="+" />
                    <asp:ListItem Text="-" />
                    <asp:ListItem Text="X" />
                    <asp:ListItem Text="/" />
                </asp:DropDownList>
            </p>
            <p>
                <asp:Button Text="Result" runat="server" ID="btnCalculate" OnClick="btnCalculate_Click"/>
            </p>
            <p>
                The Result : <asp:Label Text="" ID="ldlDisplay" runat="server" />
            </p>

        </div>
</asp:Content>