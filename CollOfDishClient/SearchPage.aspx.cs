using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollOfDishClient
{
    public partial class SearchPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lbl_usrName.Text = "Kristina Gridneva";
            Lbl_usrName.Visible = true;
        }

        protected void Btn_search_Click(object sender, EventArgs e)
        {
            string dishName = TxtBox_search.Text;

            //заполняем элементы отображения результатами от сервера

            //делаем видимым элементы отображения результатов поиска
            Lbl_AnswerNameDish.Visible = true;
            Img_AnswerImage.Visible = true;
            TxtBox_AnswerText.Visible = true;
            Btn_Suggest.Visible = true;
        }

        protected void Btn_Suggest_Click(object sender, EventArgs e)
        {
            string sessionId = (string)Session["myValue"];
            Uri baseurl = new Uri("http://localhost:52215/");
            Uri newurl = new Uri(baseurl, "(S(" + sessionId + "))/Carts.aspx");
            Response.Redirect(newurl.ToString());
        }
    }
}