using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollOfDishClient
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_registration_Click(object sender, EventArgs e)
        {
            string usrName = TxtBox_usrName.Text;
            string usrScdName = TxtBox_usrScdName.Text;
            string pass1 = TxtBox_pass1.Text;
            string pass2 = TxtBox_pass2.Text;

        }
    }
}