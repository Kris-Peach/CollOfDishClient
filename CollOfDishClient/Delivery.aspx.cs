﻿using System;
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
            string date = Request.QueryString["date"];
            if(date == "400")
            {
                Lbl_dateDelivery.Text = "Заказ не оформлен";
            }
            else
            {
                Lbl_dateDelivery.Text = "Дата доставки: " + date;
            }
            
        }

        protected void Btn_GoSearch_Click(object sender, EventArgs e)
        {
            string sessionId = (string)Session["myValue"];
            Uri baseurl = new Uri("http://localhost/CollOfDishClient/");
            Uri newurl = new Uri(baseurl, "(S(" + sessionId + "))/SearchPage");
            Response.Redirect(newurl.ToString());
        }
    }
}