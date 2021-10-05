<%@ page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterTemplate.Master" CodeBehind="~/AddEmployee.aspx.cs" Inherits="SampleWebApp.AddEmployee" %>
<asp:Content ContentPlaceHolderID="ChildContent" runat="server" ID="content1">
    <div>
            <h1>Enter New Employee Details!!</h1>
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
                Dept:<asp:DropDownList runat="server" ID="dpList">
                </asp:DropDownList>
            </p>
            <p>
                <asp:Button Text="Add Employee" runat="server" ID="btnAddNew" OnClick="btnAddNew_Click"/>
            </p>
        </div>
</asp:Content>