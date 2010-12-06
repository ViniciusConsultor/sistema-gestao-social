using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using BRQ.SI.Framework.Web.Security;

namespace BRQ.SI.SCB.UI.Web.UserControls
{
    public partial class BoxUserInfo : System.Web.UI.UserControl
    {
        //public ScpcIdentity PerfilAutenticado 
        //{
        //    get
        //    {
        //        return (ScpcIdentity)Context.User.Identity;
        //    }
        //}

        protected void Page_Load(object sender, EventArgs e)
        {

            //lblUserInfo.Text = PerfilAutenticado.NomeUsuario;
            //lblUserInfo.ToolTip = PerfilAutenticado.NomeUsuario;

        }
        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../SCPC2/Home.aspx/Sair", true);
        }
    }
}