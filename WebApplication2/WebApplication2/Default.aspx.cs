using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sayac = 10; //başlangıç
            while (sayac>=1) //döngü koşulu-bitiş
            {
                ListBox1.Items.Add(sayac.ToString());
                sayac--; //artım döngü adımı
            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            ListBox2.Items.Clear();
            for (int i = 1; i < 100; i+=2)
            {
                ListBox2.Items.Add(i.ToString());
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ListBox3.Items.Clear();
            for (int i = 0; i < 100; i+=2)
            {
                ListBox3.Items.Add(i.ToString());
            }
        }
    }
}