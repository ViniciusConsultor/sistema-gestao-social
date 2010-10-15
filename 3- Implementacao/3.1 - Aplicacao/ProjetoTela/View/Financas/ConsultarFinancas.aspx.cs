using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Entidades.DTO;
using SGS.Servicos;

namespace SGS.View.Financas
{
    public partial class ConsultarFinancas : System.Web.UI.Page
    {

        #region Eventos

        /// <summary>
        /// Evento onLoad da Página
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento onClick do Localizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLocalizar_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            FinancasDTO = new FinancasDTO();

            FinancasDTO.TipoLancamentoValor = ddlTipoLancamento.Text;
            FinancasDTO.DataLancamentoValor = txtDataLancamento.Text;
            FinancasDTO.DescricaoValor = txtDescricao.Text;

            FinancasDTO = objSGSServico.ConsultarFinancas(FinancasDTO);


            GridFinancasDataSource = FinancasDTO.FinancasLista;

        }

        /// <summary>
        /// Evento onClick do Limpar Finanças
        /// </summary>
        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarFinancas.aspx");
        }

        #endregion


        #region Metodos


        #endregion

        #region Propriedades

        /// <summary>
        /// Propriedade de FinancasDTO que fica em memória ViewState
        /// </summary>
        protected FinancasDTO FinancasDTO
        {
            set
            {
                ViewState.Add("FinancasDTO", value);
            }
            get
            {
                if (ViewState["FinancasDTO"] == null)
                    return null;
                else
                    return (FinancasDTO)ViewState["FinancasDTO"];
            }
        }


        /// <summary>
        /// Preenche o Grid de Financas
        /// </summary>
        protected List<SGS.Entidades.Financas> GridFinancasDataSource
        {
            set
            {
                gridFinancas.DataSource = value;
                gridFinancas.DataBind();
            }
        }

        #endregion



    }
}