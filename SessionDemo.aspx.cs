using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class SessionDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Words"] == null)
            {
                Session.Add("Words", new List<string>());
            }
            else
            {
                if(!IsPostBack)
                {
                    lstWords.DataSource = Session["Words"] as List<string>;
                    lstWords.DataBind();
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var list = Session["Words"] as List<string>;
            list.Add(txtWord.Text);
            Response.Redirect("SessionDemo.aspx");
        }
    }
}