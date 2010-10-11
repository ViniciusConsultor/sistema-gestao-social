using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Servicos;

namespace SGS.View.Financas
{
    public partial class ManterFinancas : System.Web.UI.Page
    {


        #region Eventos

        /// <summary>
        /// Evento OnLoad da tela
        /// </summary>
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.CarregarTela();
            }           
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            SGSServico sgsServico = new SGSServico();

            SGSFinancas = sgsServico.SalvarFinancas(PegarDadosView());

            ClientScript.RegisterStartupScript(Page.GetType(), "DadosSalvos", "<script> alert('Dados salvos com sucesso!'); </script>");

            //string url = @"ManterFinancas.aspx?tipo=alt&cod=" + SGSFinancas.CodigoFinancas.Value.ToString();
            //Server.Transfer(url);
            
        }

        private SGS.Entidades.Financas PegarDadosView()
        {
            SGS.Entidades.Financas objFinancas = SGSFinancas;
            objFinancas.TipoLancamento = ddlTipoLancamento.SelectedValue;
            objFinancas.DataLancamento = Convert.ToDateTime(txtDataLancamento.Text);
            objFinancas.DataCriacao = Convert.ToDateTime(txtDataCriacao.Text);
            objFinancas.Valor = Convert.ToDecimal(txtValor.Text);
            objFinancas.LancadoPor = txtLancadoPor.Text;
            objFinancas.Observacao = txtObservacao.Text;

            
            return objFinancas;
        }

        public void CarregarTela()
        {
            SGSServico objSGSServico = new SGSServico();
            SGSFinancas = new Entidades.Financas();

            if (Request.QueryString["tipo"] == "alt")
            {
                ////* View/Financas/ManterFinancas.aspx?tipo=alt&cod=1
                lblTitulo.Text = "Alterar Financas";
                lblDescricao.Text = "Descrição: Permite alterar as Financass da Casa Lar.";
                btnExcluir.Visible = true;
                SGSFinancas.CodigoFinancas = Convert.ToInt32(Request.QueryString["cod"]);
                //SGSFinancas.CodigoFinancas = 1;

                SGSFinancas = objSGSServico.ObterFinancas(SGSFinancas.CodigoFinancas.Value);

                if (SGSFinancas != null)
                    this.PreencherDadosView();
                else
                    Server.Transfer("bla.aspx"); //transfere usuário para tela finança não encontrada
            }
            else
            {
                lblTitulo.Text = "Cadastrar Financas";
                lblDescricao.Text = "Descrição: Permite cadastrar os Financas Casa Lar.";
                btnExcluir.Visible = false;
            }
        }

        private void PreencherDadosView()
        {
            ddlTipoLancamento.SelectedValue = SGSFinancas.TipoLancamento;
            txtDataLancamento.Text = SGSFinancas.DataLancamento.Value.ToString();
            txtDataCriacao.Text = SGSFinancas.DataCriacao.Value.ToString();
            txtValor.Text = SGSFinancas.Valor.Value.ToString();
            txtLancadoPor.Text = SGSFinancas.LancadoPor;
            txtObservacao.Text = SGSFinancas.Observacao;           
        }

        #region Propriedades

        /// <summary>
        /// Esta propriedade armazena em memória os dados da Entidade Financas
        /// </summary>
        public SGS.Entidades.Financas SGSFinancas
        {
            set
            {
                if (ViewState["SGSFinancas"] == null)
                    ViewState.Add("SGSFinancas", value);
                else
                    ViewState["SGSFinancas"] = value;
            }
            get
            {
                if (ViewState["SGSFinancas"] == null)
                    return null;
                else
                    return (SGS.Entidades.Financas)ViewState["SGSFinancas"];
            }

        }

        #endregion

        protected void ddlCasaLar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion
    }
}