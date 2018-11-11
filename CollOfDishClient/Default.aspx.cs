using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CollOfDishClient.ServiceReference1;

namespace CollOfDishClient
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private class Info //Вложеный класс, который содержит информацию для соединения
        {
            public string key;
            public AgregatorServerSoapClient client;
            public Info(string k)
            {
                key = k;
            }
        }
        protected void Button2_Click(object sender, EventArgs e) //редактировать
        {
            Info info = new Info(TextBox1.Text);
            info.client = new AgregatorServerSoapClient ();
            string answer;
            //answer.Code_status = 200;
            while (true)
            {
                if (info.key != null)
                {
                    answer = info.client.TestMethod(info.key);
                    break;
                }
                else { Label1.Text = "Укажите название статьи!!"; }
            }
            Label1.Text = answer;

        }
    }
}