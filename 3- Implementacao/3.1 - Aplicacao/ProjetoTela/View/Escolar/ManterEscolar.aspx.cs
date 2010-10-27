using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SGS.Servicos;
using SGS.Entidades;
using SGS.Entidades.DTO;

namespace SGS.View.Escolar
{
    public partial class ManterEscolar : System.Web.UI.Page
    {
        #region Eventos

        /// <summary>
        /// Evento OnLoad da tela
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //this.CarregarTela();

            }


        }

        /// <summary>
        /// Evento onClick do botão Salvar Escolar
        /// </summary>
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            SGSServico sgsServico = new SGSServico();

            //SGSEscolar = sgsServico.SalvarEscolar(PegarDadosView());

            //string url = @"ManterEscolar.aspx?tipo=alt&cod=" + SGSEscolar.CodigoInstituicao.Value.ToString();
            //Response.Redirect(url);

            ClientScript.RegisterStartupScript(Page.GetType(), "DadosSalvos", "<script> alert('Dados salvos com sucesso!'); </script>");
        }

        /// <summary>
        /// Evento OnClick do Botão Cancelar
        /// </summary>
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            string url;
            if (Request.QueryString["tipo"] == "alt")
                url = @"ManterEscolar.aspx?tipo=alt";
            else
                url = "ManterEscolar.aspx";

            Server.Transfer(url);
        }

        /// <summary>i8
        /// Evento OnClick do Botão Excluir
        /// </summary>
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            //if (objSGSServico.ExcluirEscolar(SGSEscolar.CodigoCasaLar.Value, SGSEscolar.Contato.CodigoContato.Value))
                //ClientScript.RegisterStartupScript(Page.GetType(), "DadosExcluidos", "<script> alert('Dados Escolares excluídos com sucesso!'); </script>");
            //TODO:maycon - Exibir msg javascript
            //TODO:maycon - não deixar excluir casalar quando possuir relação com outras entidades.
            Response.Redirect("../Apresentacao.aspx");
        }

        #endregion
    }
}