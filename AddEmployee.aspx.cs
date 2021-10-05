using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        static ManagerDataDataContext context = new ManagerDataDataContext();

        private List<Dept> getAllDepts()
        {
            return context.Depts.ToList();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var depts = getAllDepts();
                foreach (var dept in depts)
                {
                    dpList.Items.Add(new ListItem { Text = dept.DeptName, Value = dept.DeptId.ToString() });
                }
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            //get the values from inputs and create Employee Object
            var emp = new Employee
            {
                DepId = int.Parse(dpList.SelectedValue),
                EmpAddress = txtAddress.Text,
                EmpName = txtName.Text,
                EmpSalary = int.Parse(txtSalary.Text)
            };
            context.Employees.InsertOnSubmit(emp);
            context.SubmitChanges();
            Response.Redirect("DisplayEmployee.aspx");
        }
    }
}