using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Security;


namespace SGS.View
{
    public partial class Codificacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = SGS.Componentes.Criptografia.Criptografar("Jesus te Amo!", "Salvacao");
            
            lblDecriptografado.Text = SGS.Componentes.Criptografia.Descriptografar(Label1.Text, "Salvacao");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Label1.Text = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile("JesusTeAmo", "md5");



        }
    }
}