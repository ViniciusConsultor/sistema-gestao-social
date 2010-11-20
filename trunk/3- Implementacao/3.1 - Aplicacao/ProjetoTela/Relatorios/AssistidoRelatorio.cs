using Root.Reports;
using System;
using System.IO;
using System.Data;
using System.Drawing;
using SGS.Entidades.DTO;
using SGS.Entidades;

// Creation date: 08.11.2002
// Checked: 31.10.2004
// Author: Otto Mayer (mot@root.ch)
// Version: 1.03

// Report.NET copyright © 2002-2006 root-software ag, Bürglen Switzerland - Otto Mayer, Stefan Spirig, all rights reserved
// This library is free software; you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License
// as published by the Free Software Foundation, version 2.1 of the License.
// This library is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more details. You
// should have received a copy of the GNU Lesser General Public License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA www.opensource.org/licenses/lgpl-license.html

namespace SGS.Relatorios
{
    /// <summary>Table Layout Manager and Data-Set Sample</summary>
    /// <remarks>
    /// This sample creates a table with data from a data set.
    /// The table layout manager <see cref="Root.Reports.TableLayoutManager"/> automatically builds the grid lines,
    /// header of the table, page breaks, etc.
    /// The event handler <see cref="ReportSamples.TableLayoutManagerSample.Tlm_NewContainer"/> binds each table container to a new page.
    /// The first page has a caption. The following pages have no caption and therefore the table can be made higher.
    /// <para>PDF file: <see href="http://web.root.ch/developer/report_net/samples/TableLayoutManagerSample.pdf">TableLayoutManagerSample.pdf</see></para>
    /// <para>Source: <see href="http://web.root.ch/developer/report_net/samples/TableLayoutManagerSample.cs">TableLayoutManagerSample.cs</see></para>
    /// Manuel acesso Stream Resource http://support.microsoft.com/kb/324567
    /// </remarks>
    public class AssistidoRelatorio : Report
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
                

                col = new TlmColumnMM(tlm, "Assistido", 40);
                col.tlmCellDef_Default.tlmTextMode = TlmTextMode.MultiLine;

                col = new TlmColumnMM(tlm, "Dt. Nascimento", 26);

                col = new TlmColumnMM(tlm, "Dt. Entrada", 20);

                col = new TlmColumnMM(tlm, "Dt. Saída", 20);

                col = new TlmColumnMM(tlm, "Estado Saúde", 22);

                col = new TlmColumnMM(tlm, "Status", 26);

                col = new TlmColumnMM(tlm, "Ativo", 18);

                System.Collections.Generic.List<Assistido> listaAssistido = (System.Collections.Generic.List<Assistido>)RelatorioDTO.DadosRelatorio;
                foreach (Assistido assistido in listaAssistido)
                {
                    tlm.NewRow();
                    tlm.Add(0, new RepString(fontProp_Text, assistido.Nome));

                    if (assistido.DataNascimento.HasValue) tlm.Add(1, new RepString(fontProp_Text, assistido.DataNascimento.Value.ToString("dd/MM/yyyy")));
                    else tlm.Add(1, new RepString(fontProp_Text, ""));
                    
                    tlm.Add(2, new RepString(fontProp_Text, assistido.DataEntrada.Value.ToString("dd/MM/yyyy")));

                    if (assistido.DataSaida.HasValue) tlm.Add(3, new RepString(fontProp_Text, assistido.DataSaida.Value.ToString("dd/MM/yyyy")));
                    else tlm.Add(3, new RepString(fontProp_Text, ""));
                    
                    tlm.Add(4, new RepString(fontProp_Text, assistido.EstadoSaude));
                    tlm.Add(5, new RepString(fontProp_Text, assistido.StatusAssistido));
                    tlm.Add(6, new RepString(fontProp_Text, assistido.AssistidoAtivo));
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
                page_Cur.AddCT_MM(rPosLeft + (rPosRight - rPosLeft) / 2, rPosTop, new RepString(fontProp_Title, "SGS - Relatório Assistido"));
                ea.container.rHeightMM -= fontProp_Title.rLineFeedMM;  // reduce height of table container for the first page
            }

            // the new container must be added to the current page
            page_Cur.AddMM(rPosLeft, rPosBottom - ea.container.rHeightMM, ea.container);
        }
    }
}
