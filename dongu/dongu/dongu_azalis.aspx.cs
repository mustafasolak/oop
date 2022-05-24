using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dongu
{
    public partial class dongu_azalis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Dongu_Click(object sender, EventArgs e)
        {

            for (int i = 100; i >0; i--)
            {
                List_Dongu.Items.Add(i.ToString());   
            }

        }
    }
}