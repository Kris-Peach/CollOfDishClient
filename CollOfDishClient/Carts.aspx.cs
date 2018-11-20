using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollOfDishClient
{
    public partial class Carts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lbl_dishName.Text = "Мы подобрали наборы продуктов для Блюда:";

            Create_Table_Cars(2, 3, "Список ингридиентов");

            ListItem item1 = new ListItem("Корзина 1", "20");
            ListItem item2 = new ListItem("Корзина 2", "40");
            Rbl_listOfCarts.Items.Add(item1);
            Rbl_listOfCarts.Items.Add(item2);
            


        }

        protected void Create_Table_Cars(int row, int col, string text)
        {
            int num_car = 1;
            int cost = 300;
            TableHeaderRow _headerrow = new TableHeaderRow();
            for (int i=0; i<row; i++)
            {
                TableRow _row = new TableRow();
                for(int j=0; j<col; j++)
                {
                    TableCell _cell = new TableCell();
                    switch(j)
                    {
                        case 0:
                            _cell.Text = "Корзина " + num_car.ToString();
                            break;
                        case 1:
                            _cell.Text = text;
                            break;
                        case 2:
                            _cell.Text = cost.ToString() + "руб.";
                            break;
                    }
                    _row.Cells.Add(_cell);
                }
                
                num_car++;
                Tbl_Carts.Rows.Add(_row);

            }
            TableHeaderCell _headercell1 = new TableHeaderCell();
            _headercell1.Text = "Корзина №";
            _headercell1.Scope = TableHeaderScope.Column;
            _headerrow.Cells.Add(_headercell1);

            TableHeaderCell _headercell2 = new TableHeaderCell();
            _headercell2.Text = "Список ингридиентов";
            _headercell2.Scope = TableHeaderScope.Column;
            _headerrow.Cells.Add(_headercell2);

            TableHeaderCell _headercell3 = new TableHeaderCell();
            _headercell3.Text = "Стоимость";
            _headercell3.Scope = TableHeaderScope.Column;
            _headerrow.Cells.Add(_headercell3);

            Tbl_Carts.Rows.AddAt(0, _headerrow);

            return;
        }

        protected void Btn_Order_Click(object sender, EventArgs e)
        {
            string sessionId = (string)Session["myValue"];
            Uri baseurl = new Uri("http://localhost:52215/");
            Uri newurl = new Uri(baseurl, "(S(" + sessionId + "))/Order.aspx");
            Response.Redirect(newurl.ToString());
        }
    }
}