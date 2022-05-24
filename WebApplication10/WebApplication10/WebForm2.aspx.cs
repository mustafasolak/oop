using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int baslangic = Convert.ToInt16(TextBox1.Text);
            int kosul= Convert.ToInt16(TextBox2.Text);
            int artirim= Convert.ToInt16(TextBox3.Text);
            for (int i = baslangic; i < kosul; i=i+artirim)
            {
                ListBox1.Items.Add(i.ToString());
            }

        }
    }
}