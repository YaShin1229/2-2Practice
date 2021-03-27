using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice
{
    public partial class GenerateBomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[,] table = new string[10, 10];
            int[] num = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };
            int r = 0, c = 0;
            for (int i = 0; i < 10; i++)
            {
                rowcol(ref r, ref c, num[i]);
                table[r, c] = "*";
            }
            Response.Write("<table>");
            for (int i = 0; i < 10; i++)
            {
                Response.Write("<tr>");
                for (int j = 0; j < 10; j++)
                {
                    Response.Write("<td>");
                    Response.Write(table[i, j]);
                    Response.Write("</td>");
                }
                Response.Write("</tr>");
            }
            Response.Write("</table>");
        }
    }
}