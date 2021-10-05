using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class Recipiant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(Request.QueryString.Count==0)
            //{
            //    lblInfo.Text = "No Data Is Shared!!!!";
            //}
            //else
            //{
            //    var name = Request.QueryString["Name"];
            //    var email = Request.QueryString["Email"];
            //    lblInfo.Text = $"The Name : {name}<br/>The E-mail Address: {email}";
            //}

            //***********************Cookie Example****************************
            //var cookie = Request.Cookies["Info"];
            //if (cookie == null)
            //{
            //    lblInfo.Text = "No Data Is Shared!!!!";
            //}
            //else
            //{
            //    var name = cookie.Values["Name"];
            //    var email = cookie.Values["Email"];
            //    lblInfo.Text = $"The Name : {name}<br/>The E-mail Address: {email}";
            //}


            //***************************PreviousPage Example******************
            if(PreviousPage == null)
            {
                lblInfo.Text = "This page is viewed directly  without visiting any other page ";
                    return;
            }
            else
            {
                var name = PreviousPage.UserName;
                var email = PreviousPage.EmailAddress;
                lblInfo.Text = $"The Name : {name}<br/>The E-mail Address: {email}";
            }
        }
    }
}