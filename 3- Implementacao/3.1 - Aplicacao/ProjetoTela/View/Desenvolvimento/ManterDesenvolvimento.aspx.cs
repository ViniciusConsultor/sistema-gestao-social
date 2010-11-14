using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Componentes;
using SGS.Entidades.DTO;
using SGS.Entidades;
using SGS.Servicos;

namespace SGS.View.Desenvolvimento
{
    public partial class ManterDesenvolvimento : System.Web.UI.Page
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
        /// Evento On click do botão SAlvar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            SGSServico sgsServico = new SGSServico();

            SGSDesenvolvimento = sgsServico.SalvarDesenvolvimento(PegarDadosView());

            ClientScript.RegisterStartupScript(Page.GetType(), "DadosSalvos", "<script> alert('Dados salvos com sucesso!'); </script>");

            string url = @"ManterDesenvolvimento.aspx?tipo=alt&cod=" + SGSDesenvolvimento.CodigoDesenvolvimento.Value.ToString();
            Server.Transfer(url);

        }

        /// <summary>
        /// Evento OnClick do Botão Cancelar
        /// </summary>
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["tipo"] == "alt")
            {
                Server.Transfer("ManterDesenvolvimento.aspx?tipo=alt&cod=" + SGSDesenvolvimento.CodigoDesenvolvimento.Value.ToString());

            }
            else
            {
                Server.Transfer("ManterDesenvolvimento.aspx");
            }

        }

        /// <summary>
        /// Evento OnClick do Botão Excluir
        /// </summary>
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            if (objSGSServico.ExcluirDesenvolvimento(SGSDesenvolvimento.CodigoDesenvolvimento.Value))
                ClientScript.RegisterStartupScript(Page.GetType(), "DadosExcluidos", "<script> alert('Desenvolvimento excluído com sucesso!'); </script>");

            Response.Redirect("ConsultarDesenvolvimento.aspx");
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
            SGSDesenvolvimento = new Entidades.Desenvolvimento();

            objSGSServico.ListarAssistido(true);

            this.AssistidoLista = objSGSServico.ListarAssistido(true);

            if (Request.QueryString["tipo"] == "alt")
            {
                lblTitulo.Text = "Alterar Desenvolvimento";
                lblDescricao.Text = "Descrição: Permite alterar o Desenvolvimento Profissional do assistido.";
                btnExcluir.Visible = true;
                SGSDesenvolvimento.CodigoDesenvolvimento = Convert.ToInt32(Request.QueryString["cod"]);

                SGSDesenvolvimento = objSGSServico.ObterDesenvolvimento(SGSDesenvolvimento.CodigoDesenvolvimento.Value);

                if (SGSDesenvolvimento != null)
                    this.PreencherDadosView();
                else
                    Server.Transfer("bla.aspx"); //transfere usuário para tela "Dados não encontrado"
            }
            else
            {
                lblTitulo.Text = "Cadastrar Desenvolvimento";
                lblDescricao.Text = "Descrição: Permite cadastrar o Desenvolvimento Profissional do assistido.";
                btnExcluir.Visible = false;
            }
        }

        /// <summary>
        /// Preencha a entidade Desenvolvimento com os dados da View
        /// </summary>
        private SGS.Entidades.Desenvolvimento PegarDadosView()
        {
            SGS.Entidades.Desenvolvimento objDesenvolvimento = SGSDesenvolvimento;

            objDesenvolvimento.CodigoAssistido = Convert.ToInt32(ddlAssistido.SelectedValue);
            objDesenvolvimento.TipoAtividade = ddlTipoAtividade.SelectedValue;
            objDesenvolvimento.Atividade = txtAtividade.Text;
            objDesenvolvimento.DescricaoAtividade = txtDescricao.Text;
            objDesenvolvimento.Valor = Convert.ToDecimal(txtValor.Text);
            objDesenvolvimento.StatusAtividade = ddlStatus.SelectedValue;
            objDesenvolvimento.CargaHoraria = txtCargaHoraria.Text;
            
            if (txtDataInicio.Text != "")
                objDesenvolvimento.DataInicio = Convert.ToDateTime(txtDataInicio.Text);

            if (txtDataFim.Text != "")
                objDesenvolvimento.DataFim = Convert.ToDateTime(txtDataFim.Text);



            return objDesenvolvimento;
        }

        /// <summary>
        /// Preenche a View com os dados que estão na entidade Alimentação
        /// </summary>
        private void PreencherDadosView()
        {
            ddlAssistido.SelectedValue = SGSDesenvolvimento.CodigoAssistido.Value.ToString();
            ddlTipoAtividade.SelectedValue = SGSDesenvolvimento.TipoAtividade;
            txtAtividade.Text = SGSDesenvolvimento.Atividade;
            txtDescricao.Text = SGSDesenvolvimento.DescricaoAtividade;
            txtValor.Text = SGSDesenvolvimento.Valor.ToString();
            ddlStatus.SelectedValue = SGSDesenvolvimento.StatusAtividade;
            txtCargaHoraria.Text = SGSDesenvolvimento.CargaHoraria;

            if (SGSDesenvolvimento.DataInicio.HasValue)
                txtDataInicio.Text = SGSDesenvolvimento.DataInicio.ToString();

            if (SGSDesenvolvimento.DataFim.HasValue)
                txtDataFim.Text = SGSDesenvolvimento.DataFim.ToString();
        }

        #endregion


        #region Propriedades

        /// <summary>
        /// Esta propriedade armazena em memória os dados da Entidade Desenvolvimento
        /// </summary>
        public SGS.Entidades.Desenvolvimento SGSDesenvolvimento
        {
            set
            {
                if (ViewState["SGSDesenvolvimento"] == null)
                    ViewState.Add("SGSDesenvolvimento", value);
                else
                    ViewState["SGSDesenvolvimento"] = value;
            }
            get
            {
                if (ViewState["SGSDesenvolvimento"] == null)
                    return null;
                else
                    return (SGS.Entidades.Desenvolvimento)ViewState["SGSDesenvolvimento"];
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