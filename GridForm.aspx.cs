using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class GridForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grdDetails.DataSource = new ManagerDataDataContext().Employees.ToList();
                grdDetails.DataBind();
            }
        }

        protected void grdDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}