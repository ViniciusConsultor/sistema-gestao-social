using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Entidades;
using SGS.Entidades.DTO;
using SGS.Servicos;

namespace SGS.View.Relatorio
{
    public partial class RelFinancas : System.Web.UI.Page
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

        protected void rdbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioButtonList rbl = (RadioButtonList)sender;

            if (rbl.SelectedValue == "Orcamento")
            {
                pnlFinancas.Visible = false;
            }
            else if (rbl.SelectedValue == "Financas")
            {
                pnlFinancas.Visible = true;
            }
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            Response.Redirect("RelFinancas.aspx");
        }


        protected void btnLimparOrcamento_Click(object sender, EventArgs e)
        {
            Response.Redirect("RelFinancas.aspx");
        }

        #endregion

        #region Metodos

        public void CarregarPagina()
        {
            SGSFinanceiroRelatorioDTO = new FinanceiroRelatorioDTO();
            SGSServico objSGSServico = new SGSServico();

            SGSFinanceiroRelatorioDTO.NaturezaLancamentoLista = objSGSServico.ListarNaturezaLancamento();

            PreencheDadosView();
        }

        public void PreencheDadosView()
        {
            ddlNaturezaLancamento.DataSource = SGSFinanceiroRelatorioDTO.NaturezaLancamentoLista;
            ddlNaturezaLancamento.DataBind();
            ddlNaturezaLancamento.Items.Insert(0, new ListItem("Todos", "Todos"));
        }

        public void PegarDadosView()
        {
            if (pnlFinancas.Visible == true)
            {
                if (ddlTipoLancamento.SelectedValue != "Todos")
                    SGSFinanceiroRelatorioDTO.TipoLancamentoValor = ddlTipoLancamento.SelectedValue;
                else
                    SGSFinanceiroRelatorioDTO.TipoLancamentoValor = "";

                if (ddlNaturezaLancamento.SelectedValue != "Todos")
                    SGSFinanceiroRelatorioDTO.NaturezaLancamentoValor = Convert.ToInt32(ddlNaturezaLancamento.SelectedValue);
                else
                    SGSFinanceiroRelatorioDTO.NaturezaLancamentoValor = null;

                if (!String.IsNullOrEmpty(txtDtInicioLancamento.Text))
                    SGSFinanceiroRelatorioDTO.DtInicioValor = Convert.ToDateTime(txtDtInicioLancamento.Text);
                else
                    SGSFinanceiroRelatorioDTO.DtInicioValor = null;

                if (!String.IsNullOrEmpty(txtDtFimLancamento.Text))
                    SGSFinanceiroRelatorioDTO.DtFimValor = Convert.ToDateTime(txtDtFimLancamento.Text);
                else
                    SGSFinanceiroRelatorioDTO.DtFimValor = null;
            }
            else if (pnlOrcamento.Visible == true)
            {
                if (ddlNomePlano.SelectedValue != "Todos")
                    SGSFinanceiroRelatorioDTO.CodigoPlanoValor = Convert.ToInt32(ddlNomePlano.SelectedValue);
                else
                    SGSFinanceiroRelatorioDTO.CodigoPlanoValor = null;

                if (!String.IsNullOrEmpty(txtInicioVigencia.Text))
                    SGSFinanceiroRelatorioDTO.DtInicioValor = Convert.ToDateTime(txtInicioVigencia.Text);
                else
                    SGSFinanceiroRelatorioDTO.DtInicioValor = null;

                if (!String.IsNullOrEmpty(txtFimVigencia.Text))
                    SGSFinanceiroRelatorioDTO.DtFimValor = Convert.ToDateTime(txtFimVigencia.Text);
                else
                    SGSFinanceiroRelatorioDTO.DtFimValor = null;
            }
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Esta propriedade representa o FinanceiroRelatorioDTO e fica em memória
        /// </summary>
        public FinanceiroRelatorioDTO SGSFinanceiroRelatorioDTO
        {
            set
            {
                if (ViewState["SGSFinanceiroRelatorioDTO"] == null)
                    ViewState.Add("SGSFinanceiroRelatorioDTO", value);
                else
                    ViewState["SGSFinanceiroRelatorioDTO"] = value;
            }
            get
            {
                if (ViewState["SGSFinanceiroRelatorioDTO"] == null)
                    return null;
                else
                    return (FinanceiroRelatorioDTO)ViewState["SGSFinanceiroRelatorioDTO"];
            }
        }

        #endregion

        protected void btnGerarRelatorioFinancas_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            PegarDadosView();

            SGSFinanceiroRelatorioDTO.FinancasLista = objSGSServico.ConsultarFinancasRelatorio(SGSFinanceiroRelatorioDTO);

            if (SGSFinanceiroRelatorioDTO.FinancasLista.Count > 0)
            {
                RelatorioDTO.DadosRelatorio = SGSFinanceiroRelatorioDTO.FinancasLista;

                ClientScript.RegisterStartupScript(Page.GetType(), "Popup", "<script> window.open('../Relatorio/Relatorio.aspx?tipo=RelFinancas');</script>)");
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "Script", "<script> alert('Nenhuma finança encontrada!');  </script>");
            }

        }

        protected void GerarRelatorioOrcamento_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            PegarDadosView();

            
        }

      
    }
}