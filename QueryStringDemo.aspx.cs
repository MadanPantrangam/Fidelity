using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class QueryStringDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Query String is the easiest way of sharing info from one page to another
        protected void btnSend_Click(object sender, EventArgs e)
        {
            var text = $"Recipiant.aspx?Name={txtName.Text}&Email={txtEmailAddress.Text}";
            Response.Redirect(text);//Response.Redirect is like asking the server to move to the specific page mentioned in the arg.
        }
    }
}