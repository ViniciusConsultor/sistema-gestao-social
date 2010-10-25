using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGS.View.PlanoOrcamentario
{
    public partial class ManterPlanoOrcamentario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {

            //ddlNaturezaDespesa.DataSource = 
            ddlNaturezaDespesa.DataBind();


        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }

    }
}