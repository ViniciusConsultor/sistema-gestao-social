using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Entidades.DTO;
using SGS.Entidades;
using SGS.Servicos;

namespace SGS.View.Alimentacao
{
    public partial class ConsultarAlimentacao : System.Web.UI.Page
    {

        #region Eventos

        protected void Page_Load(object sender, EventArgs e)
        {
            if (DadosAcesso.Perfil == "Gestor" || DadosAcesso.Perfil == "Funcionario")
            {
                if (!Page.IsPostBack)
                {
                    this.CarregarPagina();
                }
            }
            // Caso usuário logado não possua acesso redireciona usuário para tela que informa que ele não possui acesso.
            else
            {
                Server.Transfer("../SemPermissao.aspx");
            }
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarAlimentacao.aspx");
        }

        protected void rptDia_ItemCreated(object sender, RepeaterItemEventArgs e)
        {

            if (e.Item.DataItem != null)
            {
                Repeater rptDia2 = (Repeater)sender;
                //Repeater rptPeriodo2 = (Repeater) rptDia2.FindControl("rptPeriodo");
                Repeater rptPeriodo3 = (Repeater)e.Item.FindControl("rptPeriodo");

                ConsultarAlimentacaoDTO.DiaSemanaDTO diaDTO = (ConsultarAlimentacaoDTO.DiaSemanaDTO)e.Item.DataItem;

                rptPeriodo3.DataSource = diaDTO.PeriodoDTOLista;
                rptPeriodo3.DataBind();
            }

        }

        protected void btnLocalizar_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            PegarDadosView();

            RepeaterAlimentacaoDataSource = objSGSServico.ConsultarAlimentacao(SGSConsultarAlimentacaoDTO.DiaSemanaValor);
        }

        protected void ddlDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            PegarDadosView();

            RepeaterAlimentacaoDataSource = objSGSServico.ConsultarAlimentacao(SGSConsultarAlimentacaoDTO.DiaSemanaValor);
        }

        #endregion

        #region Metodos

        public void CarregarPagina()
        {
            SGSConsultarAlimentacaoDTO = new ConsultarAlimentacaoDTO();
        }

        public void PegarDadosView()
        {
            if (ddlDiaSemana.SelectedValue != "Selecione")
                SGSConsultarAlimentacaoDTO.DiaSemanaValor = ddlDiaSemana.SelectedValue;
            else
                SGSConsultarAlimentacaoDTO.DiaSemanaValor = "";
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Esta propriedade armazena em memória os dados da Entidade Alimentacao
        /// </summary>
        public SGS.Entidades.DTO.ConsultarAlimentacaoDTO SGSConsultarAlimentacaoDTO
        {
            set
            {
                if (ViewState["SGSConsultarAlimentacaoDTO"] == null)
                    ViewState.Add("SGSConsultarAlimentacaoDTO", value);
                else
                    ViewState["SGSConsultarAlimentacaoDTO"] = value;
            }
            get
            {
                if (ViewState["SGSConsultarAlimentacaoDTO"] == null)
                    return null;
                else
                    return (SGS.Entidades.DTO.ConsultarAlimentacaoDTO)ViewState["SGSConsultarAlimentacaoDTO"];
            }

        }

        public List<ConsultarAlimentacaoDTO.DiaSemanaDTO> RepeaterAlimentacaoDataSource
        {
            set
            {
                if (value.Count > 0)
                {
                    pnlInformacao.Visible = false;
                    rptDia.DataSource = value;
                    rptDia.DataBind();
                }
                else
                {
                    pnlInformacao.Visible = true;
                    rptDia.DataSource = null;
                    rptDia.DataBind();
                }
            }
        }

        #endregion

       

    }
}