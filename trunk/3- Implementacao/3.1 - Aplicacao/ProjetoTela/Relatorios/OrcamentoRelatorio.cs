using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.Entidades.DTO;
using SGS.Entidades;
using Root.Reports;
using System.Drawing;

namespace SGS.Relatorios
{
    public class OrcamentoRelatorio : Report
    {

        private FontDef fontDef_Helvetica;
        private Double rPosLeft = 20;  // millimeters
        private Double rPosRight = 195;  // millimeters
        private Double rPosTop = 24;  // millimeters
        private Double rPosBottom = 278;  // millimeters

        private AssistidoRelatorioDTO _objAssistidoRelatorioDTO;
        public AssistidoRelatorioDTO AssistidoRelatorioDTO
        {
            get { return _objAssistidoRelatorioDTO; }
            set { _objAssistidoRelatorioDTO = value; }

        }

        //------------------------------------------------------------------------------------------30.10.2004
        /// <summary>Creates this report.</summary>
        /// <remarks>
        /// This method overrides the method <see cref="Root.Reports.Report.Create"/> of the base class <see cref="Root.Reports.Report"/>.
        /// </remarks>
        protected override void Create()
        {
            fontDef_Helvetica = new FontDef(this, FontDef.StandardFont.TimesRoman);
            FontProp fontProp_Text = new FontPropMM(fontDef_Helvetica, 1.9);  // standard font
            FontProp fontProp_Header = new FontPropMM(fontDef_Helvetica, 1.9);  // font of the table header
            fontProp_Header.bBold = true;

            // create table
            TableLayoutManager tlm;
            using (tlm = new TableLayoutManager(fontProp_Header))
            {
                tlm.rContainerHeightMM = rPosBottom - rPosTop;  // set height of table
                tlm.tlmCellDef_Header.rAlignV = RepObj.rAlignCenter;  // set vertical alignment of all header cells
                tlm.tlmCellDef_Default.penProp_LineBottom = new PenProp(this, 0.05, Color.LightGray);  // set bottom line for all cells
                tlm.tlmHeightMode = TlmHeightMode.AdjustLast;
                tlm.eNewContainer += new TableLayoutManager.NewContainerEventHandler(Tlm_NewContainer);

                // define columns
                TlmColumn col;


                col = new TlmColumnMM(tlm, "Nome Plano", 35);
                col.tlmCellDef_Default.tlmTextMode = TlmTextMode.MultiLine;

                col = new TlmColumnMM(tlm, "Dt. Início", 25);

                col = new TlmColumnMM(tlm, "Dt. Fim", 25);

                col = new TlmColumnMM(tlm, "Valor Orçamento", 30);

                col = new TlmColumnMM(tlm, "Valor Gasto", 30);

                col = new TlmColumnMM(tlm, "Saldo Orçamento", 30);

                List<Orcamento> listaOrcamento = (List<Orcamento>)RelatorioDTO.DadosRelatorio;
                foreach (Orcamento orcamento in listaOrcamento)
                {
                    tlm.NewRow();
                    tlm.Add(0, new RepString(fontProp_Text, orcamento.NomePlano));

                    tlm.Add(1, new RepString(fontProp_Text, orcamento.InicioVigencia.Value.ToString("dd/MM/yyyy") ));

                    tlm.Add(2, new RepString(fontProp_Text, orcamento.FimVigencia.Value.ToString("dd/MM/yyyy")));

                    tlm.Add(3, new RepString(fontProp_Text, String.Format("{0:C2}", orcamento.ValorOrcamento.Value)));

                    tlm.Add(4, new RepString(fontProp_Text, String.Format("{0:C2}", orcamento.ValorFinanceiroReal)));

                    tlm.Add(5, new RepString(fontProp_Text, String.Format("{0:C2}", orcamento.SaldoDisponivelOrcamento)));
                }
            }

            //page_Cur.AddCT_MM(rPosLeft + tlm.rWidthMM / 2, rPosTop + tlm.rCurY_MM + 2, new RepString(fontProp_Text, "- end of table -"));

            // print page number and current date/time
            Double rY = rPosBottom + 1.5;
            foreach (Page page in enum_Page)
            {
                page.AddLT_MM(rPosLeft, rY, new RepString(fontProp_Text, DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString()));
                page.AddRT_MM(rPosRight, rY, new RepString(fontProp_Text, page.iPageNo + " / " + iPageCount));
            }
        }

        //------------------------------------------------------------------------------------------30.10.2004
        /// <summary>Creates a new page.</summary>
        /// <param name="oSender">Sender</param>
        /// <param name="ea">Event argument</param>
        /// <remarks>
        /// The first page has a caption. The following pages have no caption and therefore the table can be made higher.
        /// </remarks>
        public void Tlm_NewContainer(Object oSender, TableLayoutManager.NewContainerEventArgs ea)
        {  // only "public" for NDoc, should be "private"
            new Page(this);

            // first page with caption
            if (page_Cur.iPageNo == 1)
            {
                FontProp fontProp_Title = new FontPropMM(fontDef_Helvetica, 4);
                fontProp_Title.bBold = true;
                page_Cur.AddCT_MM(rPosLeft + (rPosRight - rPosLeft) / 2, rPosTop, new RepString(fontProp_Title, "SGS - Relatório Orçamento"));
                ea.container.rHeightMM -= fontProp_Title.rLineFeedMM;  // reduce height of table container for the first page
                ea.container.rWidth = 800;
            }

            // the new container must be added to the current page
            page_Cur.AddMM(rPosLeft, rPosBottom - ea.container.rHeightMM, ea.container);
        }


    }
}