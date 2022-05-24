using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class rastgele : System.Web.UI.Page
    {

         public int sayi,kontrol=1,hak=3; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (kontrol==1)
            {
                //Random() sınıfından bir değişken tanımladık
                var rastgele_sayi = new Random(); 
                sayi= rastgele_sayi.Next(1,10);
                kontrol = 2;
                Lbl_Hak.Text = "KALAN HAKKINIZ = " + hak.ToString();
            }  
        } 
        protected void Btn_SayiUret_Click(object sender, EventArgs e)
        {
            int tahminedilen = Convert.ToInt16(Txt_tahminedilen.Text);
            
            if (tahminedilen==sayi)
            {
                Lbl_Sonuc.Text = "kazandınız";
                
            }
            else
            {
                Lbl_Sonuc.Text = "kaybettiniz";
                hak--;
            }
            if (hak==0)
            {
                Lbl_Sonuc.Text = "HİÇ HAKKINIZ KALMADI";
            }
            Lbl_Hak.Text = "KALAN HAKKINIZ = " + hak.ToString();
        }
    }
}