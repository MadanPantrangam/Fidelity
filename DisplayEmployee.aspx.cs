using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class DisplayEmployee : System.Web.UI.Page
    {
        static ManagerDataDataContext context = new ManagerDataDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var lists = getAllNames();
                foreach (var name in lists)
                {
                    ldlDisplay1.Items.Add(name);
                }
            }
          
        }

        private List<string> getAllNames()
        {
            var names = context.Employees.Select(e => e.EmpName).ToList();
            return names;
        }

        protected void ldlDisplay1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trace.Write("Selection Of The List Boxes Post here!");
            var selectedName = ldlDisplay1.SelectedValue;
            var selectedEmp = context.Employees.FirstOrDefault(emp => emp.EmpName == selectedName);
            txtID.Text = selectedEmp.EmpId.ToString();
            txtName.Text = selectedEmp.EmpName;
            txtAddress.Text = selectedEmp.EmpAddress;
            txtSalary.Text = selectedEmp.EmpSalary.ToString();
        }

        protected void btnUpadte_Click(object sender, EventArgs e)
        {
            var empId = int.Parse(txtID.Text);
            var selected = context.Employees.SingleOrDefault(emp => emp.EmpId == empId);
            if(selected == null)
            {
                throw new Exception("Employee Not found for Update!");
            }
            selected.EmpName = txtName.Text;
            selected.EmpAddress = txtAddress.Text;
            selected.EmpSalary = int.Parse(txtSalary.Text);
            context.SubmitChanges();
            Response.Redirect("DisplayEmployee.aspx");
        }
    }
}