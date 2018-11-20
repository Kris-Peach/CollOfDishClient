using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CollOfDishClient
{
    public partial class Order : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_ConfirmOrder_Click(object sender, EventArgs e)
        {
            string sessionId = (string)Session["myValue"];
            string cartId = Request.QueryString["cartId"];
            string cost = Request.QueryString["cost"];
            string town = TxtBox_usrTown.Text;
            string street = TxtBox_usrStreet.Text;
            string house = TxtBox_usrHouse.Text;
            string flat = TxtBox_usrFlat.Text;
            string com = TxtBox_usrComment.Text;
            Uri baseurl = new Uri("http://localhost/CollOfDishClient/");
            Uri newurl = new Uri(baseurl, "(S(" + sessionId + "))/Payment?cartId="+cartId+
                "&cost="+cost+"&t="+town+"&s="+street+"&h="+house+"&f="+flat+"&c="+com);
            Response.Redirect(newurl.ToString());
        }
    }
}