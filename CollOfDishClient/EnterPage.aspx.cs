using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollOfDishClient
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_login_Click(object sender, EventArgs e)
        {
            string login = TxtBox_login.Text;
            TxtBox_login.Text = "";
            string password = TxtBox_password.Text;
        }
    }
}