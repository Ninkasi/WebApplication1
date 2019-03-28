using System;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Base64Dekooderi dekooderi = new Base64Dekooderi();

            alkuTxt.Text = dekooderi.MyMessage;

            if(tbEka.Text.Length > 0)
            {
                dekooderi.MyMessage = tbEka.Text;
            }

            string temppi = dekooderi.EnkoodaaTeksti(dekooderi.MyMessage);

            alkuTxtEnkoodattu.Text = temppi;

            alkuTxtDekoodattu.Text = dekooderi.DekoodaaTeksti(temppi);
           
        }
    }
}