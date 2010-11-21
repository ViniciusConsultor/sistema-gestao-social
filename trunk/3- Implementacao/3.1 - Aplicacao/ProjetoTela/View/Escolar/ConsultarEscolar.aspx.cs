using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Entidades.DTO;
using SGS.Servicos;

namespace SGS.View.Escolar
{
    public partial class ConsultarEscolar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DadosAcesso.Perfil != "")
            {
                if (!Page.IsPostBack)
                {
                    CarregarDados();
                }
            }
            else
            {
                Response.Redirect("../LoginUI/Login.aspx");
            }
        }

        public void CarregarDados()
        {
            SGSConsultarEscolarDTO = new ConsultarEscolarDTO();
            SGSServico sgsServico = new SGSServico();

            SGSConsultarEscolarDTO.AssistidoLista = sgsServico.ListarAssistido(true);

            PreencherDadosView();
        }

        protected void PreencherDadosView()
        {
            ddlAssistido.DataSource = SGSConsultarEscolarDTO.AssistidoLista;
            ddlAssistido.DataBind();
        }

        protected void PegarDadosView()
        {
            if (ddlAssistido.SelectedValue != "Todos")
                SGSConsultarEscolarDTO.ParametroConsultarEscolarDTO.CodigoAssistido = Convert.ToInt32(ddlAssistido.SelectedValue);
            else
                SGSConsultarEscolarDTO.ParametroConsultarEscolarDTO.CodigoAssistido = null;

            SGSConsultarEscolarDTO.ParametroConsultarEscolarDTO.GrauEscolaridade = ddlGrauEscolaridade.SelectedValue;
        }
        

        #region Propriedades

        /// <summary>
        /// Propriedade de ConsultarEscolarDTO que fica em memória ViewState
        /// </summary>
        protected ConsultarEscolarDTO SGSConsultarEscolarDTO
        {
            set
            {
                ViewState.Add("ConsultarEscolarDTO", value);
            }
            get
            {
                if (ViewState["ConsultarEscolarDTO"] == null)
                    return null;
                else
                    return (ConsultarEscolarDTO)ViewState["ConsultarEscolarDTO"];
            }
        }
        
        #endregion

        protected void btnLocalizar_Click(object sender, EventArgs e)
        {
            SGSServico sgsServico = new SGSServico();

            PegarDadosView();

            sgsServico.ConsultarEscolar(SGSConsultarEscolarDTO.ParametroConsultarEscolarDTO);
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarEscolar.aspx");
        }
    }
}