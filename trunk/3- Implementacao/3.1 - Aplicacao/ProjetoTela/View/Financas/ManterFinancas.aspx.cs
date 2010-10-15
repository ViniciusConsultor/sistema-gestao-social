using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Servicos;
using SGS.Entidades.DTO;

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
            // Valida se o usuário logado possui acesso.
            if (DadosAcesso.Perfil == "Gestor")
            {
                if (!Page.IsPostBack)
                {
                    this.CarregarTela();
                }
            }
            // Caso usuário logado não possua acesso redireciona usuário para tela que informa que ele não possui acesso.
            else
            {
                Server.Transfer("../SemPermissao.aspx");
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

        /// <summary>
        /// Evento OnClick do Botão Cancelar
        /// </summary>
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            string url;
            if (Request.QueryString["tipo"] == "alt")
                url = @"ManterFinancas.aspx?tipo=alt&cod=" + Request.QueryString["cod"].ToString();
            else
                url = "ManterFinancas.aspx";

            Server.Transfer(url);
        }

        /// <summary>
        /// Evento OnClick do Botão Excluir
        /// </summary>
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            if (objSGSServico.ExcluirFinancas(SGSFinancas.CodigoFinancas.Value))
                ClientScript.RegisterStartupScript(Page.GetType(), "DadosExcluidos", "<script> alert('Finança excluída com sucesso!'); </script>");

            Response.Redirect("ConsultarFinancas.aspx");
        }


        #region Metodos

        /// <summary>
        /// Este método preenche os controles da tela de acordo com a operação que
        /// está sendo executado "cadastro" ou "edição".
        /// </summary>
        public void CarregarTela()
        {
            SGSServico objSGSServico = new SGSServico();
            SGSFinancas = new Entidades.Financas();

            if (Request.QueryString["tipo"] == "alt")
            {
                ////* View/Financas/ManterFinancas.aspx?tipo=alt&cod=1
                lblTitulo.Text = "Alterar Finanças";
                lblDescricao.Text = "Descrição: Permite alterar as Finanças da Casa Lar.";
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

        /// <summary>
        /// Preencha a entidade Login com os dados da View
        /// </summary>
        private SGS.Entidades.Financas PegarDadosView()
        {
            SGS.Entidades.Financas objFinancas = SGSFinancas;
            objFinancas.CodigoCasaLar = Convert.ToInt32(ddlCasaLar.SelectedValue);
            objFinancas.TipoLancamento = ddlTipoLancamento.SelectedValue;
            objFinancas.DataLancamento = Convert.ToDateTime(txtDataLancamento.Text);
            objFinancas.DataCriacao = Convert.ToDateTime(txtDataCriacao.Text);
            objFinancas.Valor = Convert.ToDecimal(txtValor.Text);
            objFinancas.LancadoPor = txtLancadoPor.Text;
            objFinancas.Observacao = txtObservacao.Text;


            return objFinancas;
        }

        /// <summary>
        /// Preenche a View com os dados que estão na entidade Finanças
        /// </summary>
        private void PreencherDadosView()
        {
            ddlCasaLar.SelectedValue = SGSFinancas.CodigoCasaLar.Value.ToString();
            ddlTipoLancamento.SelectedValue = SGSFinancas.TipoLancamento;
            txtDataLancamento.Text = SGSFinancas.DataLancamento.Value.ToString();
            txtDataCriacao.Text = SGSFinancas.DataCriacao.Value.ToString();
            txtValor.Text = SGSFinancas.Valor.Value.ToString();
            txtLancadoPor.Text = SGSFinancas.LancadoPor;
            txtObservacao.Text = SGSFinancas.Observacao;
        }

        #endregion



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

        protected void btnCancelar_Click1(object sender, EventArgs e)
        {
            if (Request.QueryString["tipo"] == "alt")
            {
                Server.Transfer("ManterFinancas.aspx?tipo=alt&cod=" + SGSFinancas.CodigoFinancas.Value.ToString() );

            }
            else
            {
                Server.Transfer("ManterFinancas.aspx");
            }

        }

        #endregion

    }
}