using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Root.Reports;
using SGS.Relatorios;
using SGS.Entidades;
using SGS.Entidades.DTO;
using SGS.Servicos;

namespace SGS.View.Relatorio
{
    public partial class RelAssistidos : System.Web.UI.Page
    {

        #region Eventos

        protected void Page_Load(object sender, EventArgs e)
        {
            if (DadosAcesso.Perfil != "")
            {
                if (!Page.IsPostBack)
                {
                    this.CarregarPagina();
                }
            }
            else
            {
                Response.Redirect("../LoginUI/Login.aspx");
            }
        }

        protected void ddlAssistido_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddl = (DropDownList)sender;

            if (ddl.SelectedValue == "Todos")
            {
                AtivarControles(true);
            }
            else
            {
                AtivarControles(false);
            }
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            Response.Redirect("RelAssistidos.aspx");
        }

        protected void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            PegarDadosView();

            SGSAssistidoRelatorioDTO.AssistidoLista = objSGSServico.ConsultarAssistido(SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO);

            if (SGSAssistidoRelatorioDTO.AssistidoLista.Count > 0)
            {
                RelatorioDTO.DadosRelatorio = SGSAssistidoRelatorioDTO.AssistidoLista;

                ClientScript.RegisterStartupScript(Page.GetType(), "Popup", "<script> window.open('../Relatorio/Relatorio.aspx?tipo=RelAssistidos');</script>)");
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "Script", "<script> alert('Nenhum assistido encontrado!');  </script>");
            }

        }

        #endregion

        #region Metodos

        private void CarregarPagina()
        {
            SGSAssistidoRelatorioDTO = new AssistidoRelatorioDTO();
            SGSServico objSGSServico = new SGSServico();

            SGSAssistidoRelatorioDTO.AssistidoLista = objSGSServico.ListarAssistido(null);
            ddlAssistido.DataSource = SGSAssistidoRelatorioDTO.AssistidoLista;
            ddlAssistido.DataBind();
            ddlAssistido.Items.Insert(0, new ListItem("Todos", "Todos"));
        }

        private void AtivarControles(bool status)
        {
            ddlStatusAssistido.Enabled = status;
            ddlStatusAssistido.SelectedIndex = 0; 
            ddlStatusCadastro.Enabled = status;
            ddlStatusCadastro.SelectedIndex = 0;
            ddlEstadoSaude.Enabled = status;
            ddlEstadoSaude.SelectedIndex = 0;
            txtDataEntrada.Enabled = status;
            txtDataEntrada.Text = "";
            txtDataSaída.Enabled = status;
            txtDataEntrada.Text = "";
        }

        public void PegarDadosView()
        {
            if (ddlAssistido.SelectedValue != "Todos")
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.CodigoAssisitoValor = Convert.ToInt32(ddlAssistido.SelectedValue);
            else
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.CodigoAssisitoValor = null;

            if (ddlStatusAssistido.SelectedValue != "Selecione")
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.StatusAssistidoValor = ddlStatusAssistido.SelectedValue;
            else
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.StatusAssistidoValor = "";

            if (ddlStatusCadastro.SelectedValue != "Selecione")
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.StatusCadastroValor = Convert.ToBoolean(ddlStatusCadastro.SelectedValue);
            else
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.StatusCadastroValor = null;

            if (ddlEstadoSaude.SelectedValue != "Selecione")
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.EstadoSaudeValor = ddlEstadoSaude.SelectedValue;
            else
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.EstadoSaudeValor = null;

            if (!String.IsNullOrEmpty(txtDataEntrada.Text))
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.DataEntradaValor = Convert.ToDateTime(txtDataEntrada.Text);
            else
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.DataEntradaValor = null;

            if (!String.IsNullOrEmpty(txtDataSaída.Text))
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.DataSaidaValor = Convert.ToDateTime(txtDataSaída.Text);
            else
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.DataSaidaValor = null;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Esta propriedade representa o ConsultarAssistidoDTO e fica em memória
        /// </summary>
        public AssistidoRelatorioDTO SGSAssistidoRelatorioDTO
        {
            set
            {
                if (ViewState["SGSAssistidoRelatorioDTO"] == null)
                    ViewState.Add("SGSAssistidoRelatorioDTO", value);
                else
                    ViewState["SGSAssistidoRelatorioDTO"] = value;
            }
            get
            {
                if (ViewState["SGSAssistidoRelatorioDTO"] == null)
                    return null;
                else
                    return (AssistidoRelatorioDTO)ViewState["SGSAssistidoRelatorioDTO"];
            }
        }

        #endregion

    }
}