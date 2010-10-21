using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGS.View.Pessoa
{
    public partial class ManterPessoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList objDropDownList = (DropDownList)sender;

            if (objDropDownList.SelectedValue == "Selecione")
            {
                ucPessoaDadosBasico.Visible = false;
            }
            else if (objDropDownList.SelectedValue == "Assistido")
            {
                ucPessoaDadosBasico.Visible = true;
            }
            else if (objDropDownList.SelectedValue == "Funcionario")
            {
                ucPessoaDadosBasico.Visible = true;
            }
            else if (objDropDownList.SelectedValue == "Voluntario")
            {

                ucPessoaDadosBasico.Visible = true;
            }

        }
    }
}