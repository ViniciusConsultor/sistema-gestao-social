using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SGS.Entidades.DTO;
using SGS.Entidades.Enum;

namespace ProjetoTela.Telas
{
    public partial class Apresentacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Verifica se o usuário possui acesso a esta tela
            if (DadosAcesso.SessaoDTO == null)
            {
                Response.Redirect("../View/LoginUI/Login.aspx");
            }
        }
    }
}