using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Servicos;
using SGS.Entidades.DTO;
using SGS.Entidades;

namespace SGS.View.Procedimentos
{
    public partial class ManterProcedimentos : System.Web.UI.Page
    {

        #region Eventos

        /// <summary>
        /// Evento OnLoad da tela
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            // Valida se o usuário logado possui acesso.
            if (DadosAcesso.Perfil == "Gestor" || DadosAcesso.Perfil == "Funcionario")
            {
                if (!Page.IsPostBack)
                {
                    this.CarregarTela();
                }
            }
            // Caso usuário logado não possua acessa redireciona usuário para tela que informa que ele não possui acesso.
            else
            {
                Server.Transfer("../SemPermissao.aspx");
            }
        }

        /// <summary>
        /// Evento onClick do botão Salvar login
        /// </summary>
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            SGSServico sgsServico = new SGSServico();

            SGSProcedimentos = sgsServico.SalvarProcedimentos(PegarDadosView());

            ClientScript.RegisterStartupScript(Page.GetType(), "DadosSalvos", "<script> alert('Dados salvos com sucesso!'); </script>");

            string url = @"ManterProcedimentos.aspx?tipo=alt&cod=" + SGSProcedimentos.CodigoProcedimento.Value.ToString();
            Response.Redirect(url);
        }

        /// <summary>
        /// Evento OnClick do Botão Excluir
        /// </summary>
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            if (objSGSServico.ExcluirProcedimentos(SGSProcedimentos.CodigoProcedimento.Value))
                ClientScript.RegisterStartupScript(Page.GetType(), "DadosExcluidos", "<script> alert('Procedimentos excluído com sucesso!'); </script>");

            Response.Redirect("ConsultarProcedimentos.aspx");

        }

        /// <summary>
        /// Evento OnClick do Botão Cancelar
        /// </summary>
        protected void btnCancelar_Click(object sender, EventArgs e)
        {

            if (Request.QueryString["tipo"] == "alt")
            {
                Server.Transfer("ManterProcedimentos.aspx?tipo=alt&cod=" + SGSProcedimentos.CodigoProcedimento.Value.ToString());

            }
            else
            {
                Server.Transfer("ManterProcedimentos.aspx");
            }

        }

        #endregion

        #region Métodos

        /// <summary>
        /// Este método preenche os controles da tela de acordo com a operação que
        /// está sendo executado "cadastro" ou "edição".
        /// </summary>
        public void CarregarTela()
        {
            SGSServico objSGSServico = new SGSServico();
            SGSProcedimentos = new Entidades.Procedimentos();

            objSGSServico.ListarAssistido(true);

            this.AssistidoLista = objSGSServico.ListarAssistido(true);

            if (Request.QueryString["tipo"] == "alt")
            {
                lblTitulo.Text = "Alterar Procedimentos";
                lblDescricao.Text = "Descrição: Permite Alterar os procedimentos dos assistidos.";
                btnExcluir.Visible = true;

                SGSProcedimentos.CodigoProcedimento = Convert.ToInt32(Request.QueryString["cod"]);

                SGSProcedimentos = objSGSServico.ObterProcedimentos(SGSProcedimentos.CodigoProcedimento.Value);

                if (SGSProcedimentos != null)
                    this.PreencherDadosView();
                else
                    Server.Transfer("bla.aspx");
            }
            else
            {
                lblTitulo.Text = "Cadastrar Procedimentos";
                lblDescricao.Text = "Descrição: Permite Cadatrar os procedimentos dos assistidos";
                btnExcluir.Visible = false;
            }
        }

        /// <summary>
        /// Preencha a entidade Procedimentos com os dados da View
        /// </summary>
        private SGS.Entidades.Procedimentos PegarDadosView()
        {
            SGS.Entidades.Procedimentos objProcedimentos = SGSProcedimentos;

            objProcedimentos.CodigoAssistido = Convert.ToInt32(ddlAssistido.SelectedValue);
            objProcedimentos.TipoProcedimento = ddlTipoProcedimento.SelectedValue;
            objProcedimentos.Procedimento = ddlProcedimento.SelectedValue;
            objProcedimentos.Descricao = txtDescricao.Text;
            objProcedimentos.StatusProcedimento = ddlStatus.SelectedValue;
            objProcedimentos.PessoaAtendente = txtPessoaAtendente.Text;
            objProcedimentos.LaudoAtendente = txtLaudoAtendente.Text;

            if (txtDataMarcada.Text != "")
                objProcedimentos.DataMarcada = Convert.ToDateTime(txtDataMarcada.Text);

            if (txtDataRealizada.Text != "")
                objProcedimentos.DataRealizada = Convert.ToDateTime(txtDataRealizada.Text);




            return objProcedimentos;
        }

        /// <summary>
        /// Preenche a View com os dados que estão na entidade Procedimentos
        /// </summary>
        private void PreencherDadosView()
        {

            ddlAssistido.SelectedValue = SGSProcedimentos.CodigoAssistido.Value.ToString();
            ddlTipoProcedimento.SelectedValue = SGSProcedimentos.TipoProcedimento;
            ddlProcedimento.SelectedValue = SGSProcedimentos.Procedimento;
            txtDescricao.Text = SGSProcedimentos.Descricao;
            ddlStatus.SelectedValue = SGSProcedimentos.StatusProcedimento;
            txtPessoaAtendente.Text = SGSProcedimentos.PessoaAtendente;
            txtLaudoAtendente.Text = SGSProcedimentos.LaudoAtendente;

            if (SGSProcedimentos.DataMarcada.HasValue)
                txtDataMarcada.Text = SGSProcedimentos.DataMarcada.ToString();

            if (SGSProcedimentos.DataRealizada.HasValue)
                txtDataRealizada.Text = SGSProcedimentos.DataRealizada.ToString();


        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Esta propriedade armazena em memória os dados da Entidade Procedimentos
        /// </summary>
        public SGS.Entidades.Procedimentos SGSProcedimentos
        {
            set
            {
                if (ViewState["SGSProcedimentos"] == null)
                    ViewState.Add("SGSProcedimentos", value);
                else
                    ViewState["SGSProcedimentos"] = value;
            }
            get
            {
                if (ViewState["SGSProcedimentos"] == null)
                    return null;
                else
                    return (SGS.Entidades.Procedimentos)ViewState["SGSProcedimentos"];
            }

        }
         
        /// <summary>
        /// Esta Propiedade recebe uma lista de assistido
        /// </summary>
        public List<Assistido> AssistidoLista
        {
            set
            {
                ddlAssistido.DataSource = value;
                ddlAssistido.DataBind();
                ddlAssistido.Items.Insert(0, new ListItem("Selecione", "Selecione"));
            }
        }

        #endregion

    }
}