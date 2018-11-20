using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollOfDishClient
{
    public partial class Delivery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_GoSearch_Click(object sender, EventArgs e)
        {
            string sessionId = (string)Session["myValue"];
            Uri baseurl = new Uri("http://localhost:52215/");
            Uri newurl = new Uri(baseurl, "(S(" + sessionId + "))/SearchPage.aspx");
            Response.Redirect(newurl.ToString());
        }
    }
}