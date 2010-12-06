using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Servicos;
using SGS.Entidades;
using SGS.Entidades.DTO;
using BRQ.SI.SCB.UI.Web.UserControls;

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
                MessageBox1.OnClickButtonYes += new MessageBox.ClickButtonYes(MessageBoxControl_OnConfirmarExcluir);

                if (!Page.IsPostBack)
                {
                    this.CarregarTela();
                }
                else if (HiddenField1.Value == "Retorno")
                {
                    string url = @"ManterFinancas.aspx?tipo=alt&cod=" + SGSFinancas.CodigoFinancas.Value.ToString();
                    Server.Transfer(url);
                }
                else if (HiddenField1.Value == "Exclusao")
                {
                    Response.Redirect("ConsultarFinancas.aspx");
                }
            }
            // Caso usuário logado não possua acesso redireciona usuário para tela que informa que ele não possui acesso.
            else
            {
                Server.Transfer("../SemPermissao.aspx");
            }
        }

        /// <summary>
        /// Evento On click do botão SAlvar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            SGSServico sgsServico = new SGSServico();

            SGSFinancas = sgsServico.SalvarFinancas(PegarDadosView());
            MessageBox1.ShowMessage("Dados salvos com sucesso!", BRQ.SI.SCB.UI.Web.UserControls.MessageBoxType.Success);
            HiddenField1.Value = "Retorno";
        }

        /// <summary>
        /// Evento OnClick do Botão Cancelar
        /// </summary>
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["tipo"] == "alt")
            {
                Server.Transfer("ManterFinancas.aspx?tipo=alt&cod=" + SGSFinancas.CodigoFinancas.Value.ToString());

            }
            else
            {
                Server.Transfer("ManterFinancas.aspx");
            }

        }

        /// <summary>
        /// Evento OnClick do Botão Excluir
        /// </summary>
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox1.ShowMessage("Deseja realmente excluir?", BRQ.SI.SCB.UI.Web.UserControls.MessageBoxType.Question);

        }

        #endregion

        #region Metodos

        /// <summary>
        /// Este método preenche os controles da tela de acordo com a operação que
        /// está sendo executado "cadastro" ou "edição".
        /// </summary>
        public void CarregarTela()
        {
            SGSServico objSGSServico = new SGSServico();
            SGSFinancas = new Entidades.Financas();
            
            ddlNaturezaFinanca.DataSource = objSGSServico.ListarNaturezaLancamento();
            ddlNaturezaFinanca.DataBind();
            ddlNaturezaFinanca.Items.Insert(0, new ListItem("Selecione", "Selecione"));
            
            ddlCasaLar.DataSource = objSGSServico.ListarCasaLar();
            ddlCasaLar.DataBind();


            if (Request.QueryString["tipo"] == "alt")
            {
                ////* View/Financas/ManterFinancas.aspx?tipo=alt&cod=1
                lblTitulo.Text = "Alterar Finanças";
                lblDescricao.Text = "Descrição: Permite alterar as Finanças da Casa Lar.";
                btnExcluir.Visible = true;
                SGSFinancas.CodigoFinancas = Convert.ToInt32(Request.QueryString["cod"]);

                SGSFinancas = objSGSServico.ObterFinancas(SGSFinancas.CodigoFinancas.Value);


                if (SGSFinancas != null)
                    this.PreencherDadosView();
            }
            else
            {
                lblTitulo.Text = "Cadastrar Financas";
                lblDescricao.Text = "<b>Descrição:</b> Permite cadastrar as Financas da Casa Lar.";
                btnExcluir.Visible = false;
                txtDataCriacao.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txtLancadoPor.Text = DadosAcesso.SessaoDTO.Login.Nome;
            }
        }

        /// <summary>
        /// Preencha a entidade Financas com os dados da View
        /// </summary>
        private SGS.Entidades.Financas PegarDadosView()
        {
            SGS.Entidades.Financas objFinancas = SGSFinancas;

            objFinancas.CodigoCasaLar = Convert.ToInt32(ddlCasaLar.SelectedValue);
            objFinancas.TipoLancamento = ddlTipoLancamento.SelectedValue;
            objFinancas.DataLancamento = Convert.ToDateTime(txtDataLancamento.Text);
            objFinancas.DataCriacao = DateTime.Now;
            if (ddlTipoLancamento.SelectedValue == "Receita")
            {
                objFinancas.Valor = Convert.ToDecimal(txtValor.Text);
                if (objFinancas.Valor < 0)
                    objFinancas.Valor = objFinancas.Valor * (-1);
            }
            else
            {
                objFinancas.Valor = -1 * Convert.ToDecimal(txtValor.Text);
                if (objFinancas.Valor > 0)
                    objFinancas.Valor = objFinancas.Valor * (-1);
            }
            objFinancas.LancadoPor = txtLancadoPor.Text;
            objFinancas.Observacao = txtObservacao.Text;
            objFinancas.CodigoNatureza = Convert.ToInt32(ddlNaturezaFinanca.SelectedValue);

            return objFinancas;
        }

        /// <summary>
        /// Preenche a View com os dados que estão na entidade Finanças
        /// </summary>
        private void PreencherDadosView()
        {

            ddlTipoLancamento.SelectedValue = SGSFinancas.TipoLancamento;
            txtDataLancamento.Text = SGSFinancas.DataLancamento.Value.ToString();
            txtDataCriacao.Text = SGSFinancas.DataCriacao.Value.ToString();
            txtValor.Text = String.Format("{0:F2}", SGSFinancas.Valor.Value);
            txtLancadoPor.Text = SGSFinancas.LancadoPor;
            txtObservacao.Text = SGSFinancas.Observacao;

            if (SGSFinancas.CodigoCasaLar.HasValue)
                ddlCasaLar.SelectedValue = SGSFinancas.CodigoCasaLar.Value.ToString();

            if (SGSFinancas.CodigoNatureza.HasValue)
                ddlNaturezaFinanca.SelectedValue = SGSFinancas.CodigoNatureza.Value.ToString();

        }

        protected void MessageBoxControl_OnConfirmarExcluir()
        {

            SGSServico objSGSServico = new SGSServico();

            if (objSGSServico.ExcluirFinancas(SGSFinancas.CodigoFinancas.Value))
                MessageBox1.ShowMessage("Finança excluída com sucesso!", BRQ.SI.SCB.UI.Web.UserControls.MessageBoxType.Success);

            HiddenField1.Value = "Exclusao";
            
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

        protected void ddlCasaLar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

    }
}

