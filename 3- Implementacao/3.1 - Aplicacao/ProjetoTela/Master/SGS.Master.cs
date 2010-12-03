using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Entidades.DTO;

namespace ProjetoTela.Master
{
    public partial class SGS : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DadosAcesso.SessaoDTO == null)
                btnSair.Visible = false;
            else
                btnSair.Visible = true;

        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Server.Transfer(Request.ApplicationPath + "/View/LoginUI/Login.aspx");
        }
    }
}