<%@ page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterTemplate.Master" CodeBehind="~/DisplayEmployee.aspx.cs" Inherits="SampleWebApp.DisplayEmployee" %>
<asp:Content ContentPlaceHolderID="ChildContent" runat="server" ID="content1">
         <h1>Employee Data</h1>
      <div style="height: 320px; width: 106px">
          <asp:ListBox ID="ldlDisplay1" runat="server" Height="321px" Width="112px" AutoPostBack="True" OnSelectedIndexChanged="ldlDisplay1_SelectedIndexChanged">
          </asp:ListBox>
      </div>
        <div>
            <h2>Details Of The Selected Employees</h2>
            <p>
                Employee Id : <asp:TextBox runat="server" ID="txtID"/>
            </p>
             <p>
                Employee Name : <asp:TextBox runat="server" ID="txtName"/>
            </p>
             <p>
                Employee Address : <asp:TextBox runat="server" ID="txtAddress"/>
            </p>
             <p>
                Employee Salary : <asp:TextBox runat="server" ID="txtSalary"/>
            </p>
            <p>
                <asp:Button Text="Save Changes" runat="server" ID="btnUpadte" OnClick="btnUpadte_Click"/>
            </p>
        </div>
</asp:Content>