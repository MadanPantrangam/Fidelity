using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class CookiesDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Info");
            cookie.Values.Add("Name", txtName.Text);
            cookie.Values.Add("Email", txtEmailAddress.Text);
            Response.Cookies.Add(cookie);
            Response.Redirect("Recipiant.aspx");
        }
    }
}