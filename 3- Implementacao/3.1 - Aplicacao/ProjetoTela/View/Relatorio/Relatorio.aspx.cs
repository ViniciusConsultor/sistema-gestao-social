using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Entidades.DTO;
using SGS.Relatorios;
using Root.Reports;

namespace SGS.View.Relatorio
{
    public partial class Relatorio : System.Web.UI.Page
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

        #endregion

        #region Metodos

        public void CarregarPagina()
        {

            if (Request.QueryString["tipo"] == "RelAssistidos")
            {
                PdfReport<AssistidoRelatorio> pdfReport = new PdfReport<AssistidoRelatorio>();
                pdfReport.pageLayout = PageLayout.SinglePage;
                pdfReport.Response(this);
            }
            else if (Request.QueryString["tipo"] == "RelFinancas")
            {
                PdfReport<FinancasRelatorio> pdfReport = new PdfReport<FinancasRelatorio>();
                pdfReport.pageLayout = PageLayout.SinglePage;
                pdfReport.Response(this);
            }
            else if (Request.QueryString["tipo"] == "RelOrcamento")
            {
                PdfReport<OrcamentoRelatorio> pdfReport = new PdfReport<OrcamentoRelatorio>();
                pdfReport.pageLayout = PageLayout.SinglePage;
                pdfReport.Response(this);
            }
        }

        #endregion

    }
}