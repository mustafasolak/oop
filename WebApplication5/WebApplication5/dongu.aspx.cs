using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class dongu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
      
        protected void Btn_Basla_Click(object sender, EventArgs e)
        {
            try
            {
                Lbl_Hata.Text = "";
                List_Dongu.Items.Clear();
                int a, basla, artirim, kosul;
                basla = Convert.ToInt16(Txt_Basla.Text);
                artirim = Convert.ToInt16(Txt_Artis.Text);
                kosul = Convert.ToInt16(Txt_Kosul.Text);
                for (a = basla; a <= kosul; a = a + artirim)
                {
                    List_Dongu.Items.Add(a.ToString());
                }
            }
            catch (Exception hata)
            {
                Lbl_Hata.Text = hata.ToString();
             
            }          
           
        }
    }
}