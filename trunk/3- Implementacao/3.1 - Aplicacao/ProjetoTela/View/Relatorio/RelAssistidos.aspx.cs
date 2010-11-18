using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Root.Reports;
using SGS.Relatorios;



namespace SGS.View.Relatorio
{
    public partial class RelAssistidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //RT.ViewPDF(new ReportSamples.TableLayoutManagerSample(), "FlowLayoutManagerSample.pdf"); 
            //RT.ViewPDF(new ReportSamples.TableLayoutManagerSample(), "FlowLayoutManagerSample.pdf");
            
            //PdfReport<ImageSample> pdfReport = new PdfReport<ImageSample>();
            //pdfReport.pageLayout = PageLayout.TwoPageLeft;
            //pdfReport.Response(this);
            SGS.CamadaDados.AssistidoDados assistidoDados = new CamadaDados.AssistidoDados();
            assistidoDados.Listar(null);

            PdfReport<AssistidoRelatorio> pdfReport = new PdfReport<AssistidoRelatorio>();
            pdfReport.pageLayout = PageLayout.SinglePage;
            
            pdfReport.Response(this);
        }
    }
}