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

        protected void rdbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioButtonList rbl = (RadioButtonList)sender;

            if (rbl.SelectedValue == "Orcamento")
            {
                pnlFinancas.Visible = true;

                lbl.Text = "Nome Plano";
                ddl.DataSource = SGSFinanceiroRelatorioDTO.OrcamentoLista;
                ddl.DataTextField = "NomePlano";
                ddl.DataValueField = "CodigoOrcamento";
                ddl.DataBind();
                ddl.Items.Insert(0, new ListItem("Todos", "Todos"));

                lbl1.Visible = false;
                ddlNaturezaLancamento.Visible = false;

                lbl2.Text = "Data Início Vigência";
                lbl3.Text = "Data Fim Vigência";
            }
            else if (rbl.SelectedValue == "Financas")
            {
                pnlFinancas.Visible = true;

                lbl.Text = "Tipo de Lançamento";
                ddl.Items.Clear();
                ddlNaturezaLancamento.Visible = false;
                
                ddl.Items.Insert(0, new ListItem("Todos", "Todos"));
                ddl.Items.Insert(1, new ListItem("Despesa", "Despesa"));
                ddl.Items.Insert(2, new ListItem("Receita", "Receita"));


                ddlNaturezaLancamento.Visible = true;

                lbl1.Visible = true;
                lbl1.Text = "Natureza Lançamento";
                lbl2.Text = "Data Início Lançamento";
                lbl3.Text = "Data Fim Lançamento";
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
            SGSFinanceiroRelatorioDTO.OrcamentoLista = objSGSServico.ListarOrcamento();

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
            if (rdbTipo.SelectedValue == "Financas")
            {
                if (ddl.SelectedValue != "Todos")
                    SGSFinanceiroRelatorioDTO.TipoLancamentoValor = ddl.SelectedValue;
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
            else if (rdbTipo.SelectedValue == "Orcamento")
            {
                if (ddl.SelectedValue != "Todos")
                    SGSFinanceiroRelatorioDTO.OrcamentoDTO.CodigoOrcamentoValor = Convert.ToInt32(ddl.SelectedValue);
                else
                    SGSFinanceiroRelatorioDTO.OrcamentoDTO.CodigoOrcamentoValor = null;

                if (!String.IsNullOrEmpty(txtDtInicioLancamento.Text))
                    SGSFinanceiroRelatorioDTO.OrcamentoDTO.InicioVigenciaValor = Convert.ToDateTime(txtDtInicioLancamento.Text);
                else
                    SGSFinanceiroRelatorioDTO.OrcamentoDTO.InicioVigenciaValor = null;

                if (!String.IsNullOrEmpty(txtDtFimLancamento.Text))
                    SGSFinanceiroRelatorioDTO.OrcamentoDTO.FimVigenciaValor = Convert.ToDateTime(txtDtFimLancamento.Text);
                else
                    SGSFinanceiroRelatorioDTO.OrcamentoDTO.FimVigenciaValor = null;
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

            if (rdbTipo.SelectedValue == "Financas")
            {
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
            else if (rdbTipo.SelectedValue == "Orcamento")
            {
                SGSFinanceiroRelatorioDTO.OrcamentoDTO = objSGSServico.ConsultarOrcamento(SGSFinanceiroRelatorioDTO.OrcamentoDTO);

                if (SGSFinanceiroRelatorioDTO.OrcamentoDTO.OrcamentoLista.Count > 0)
                {
                    RelatorioDTO.DadosRelatorio = SGSFinanceiroRelatorioDTO.OrcamentoDTO.OrcamentoLista;

                    ClientScript.RegisterStartupScript(Page.GetType(), "Popup", "<script> window.open('../Relatorio/Relatorio.aspx?tipo=RelOrcamento');</script>)");
                }
                else
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "Script", "<script> alert('Nenhuma orçamento encontrada!');  </script>");
                }
            }
        }

        protected void GerarRelatorioOrcamento_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            PegarDadosView();

           

        }

      
    }
}