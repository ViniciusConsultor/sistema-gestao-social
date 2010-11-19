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

            if (!Page.IsPostBack)
            {
                this.CarregarPagina();
            }

            //RT.ViewPDF(new ReportSamples.TableLayoutManagerSample(), "FlowLayoutManagerSample.pdf"); 
            //RT.ViewPDF(new ReportSamples.TableLayoutManagerSample(), "FlowLayoutManagerSample.pdf");

            //PdfReport<ReportSamples.TableLayoutManagerSample> pdfReport = new PdfReport<ReportSamples.TableLayoutManagerSample>();
            //pdfReport.pageLayout = PageLayout.TwoPageLeft;
            //pdfReport.Response(this);
           
            //SGS.CamadaDados.AssistidoDados assistidoDados = new CamadaDados.AssistidoDados();
            //Session.Add("ListaAssistido", assistidoDados.Listar(null));

            //PdfReport<AssistidoRelatorio> pdfReport = new PdfReport<AssistidoRelatorio>();
            //pdfReport.pageLayout = PageLayout.SinglePage;

            //pdfReport.Response(this);
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

        protected void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            SGSAssistidoRelatorioDTO.AssistidoLista = objSGSServico.ConsultarAssistido(SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO);
        }

        public void PegarDadosView()
        {
            if (ddlAssistido.SelectedValue != "Todos")
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.CodigoAssisitoValor = Convert.ToInt32(ddlAssistido.SelectedValue);
            else
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.CodigoAssisitoValor = null;

            SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.StatusAssistidoValor = ddlStatusAssistido.SelectedValue;

            if (ddlStatusCadastro.SelectedValue != "Selecione")
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.StatusCadastroValor = Convert.ToBoolean(ddlStatusCadastro.SelectedValue);
            else
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.StatusCadastroValor = null;

            SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.EstadoSaudeValor = ddlEstadoSaude.SelectedValue;

            if (String.IsNullOrEmpty(txtDataEntrada.Text))
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.DataEntradaValor = Convert.ToDateTime(txtDataEntrada.Text);
            else
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.DataEntradaValor = null;

            if (String.IsNullOrEmpty(txtDataSaída.Text))
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.DataSaidaValor = Convert.ToDateTime(txtDataSaída.Text);
            else
                SGSAssistidoRelatorioDTO.ConsultarAssistidoDTO.DataSaidaValor = null;


        }

        

        

     
    }
}