using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/*
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
                ClientScript.RegisterStartupScript(Page.GetType(), "DadosExcluidos", "<script> alert('Finança excluída com sucesso!'); </script>");

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
                    Server.Transfer("bla.aspx"); //transfere usuário para tela "Alimentação não encontrada"
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

            objDesenvolvimento.Atividade = 
            objDesenvolvimento.CargaHoraria = 
            objDesenvolvimento.DiaSemana = ddlDiaSemana.SelectedValue;
            objDesenvolvimento.Horario = Convert.ToDateTime(txtHorario.Text);
            objDesenvolvimento.Periodo = ddlPeriodo.SelectedValue;
            objDesenvolvimento.PorcaoAlimento = txtPorcaoAlimento.Text;
            objDesenvolvimento.Alimento = ltbAlimentos.SelectedValue;
            objDesenvolvimento.Diretiva = txtDiretiva.Text;

            return objDesenvolvimento;
        }

        /// <summary>
        /// Preenche a View com os dados que estão na entidade Alimentação
        /// </summary>
        private void PreencherDadosView()
        {

            ddlDiaSemana.SelectedValue = SGSDesenvolvimento.DiaSemana;
            txtHorario.Text = SGSDesenvolvimento.Horario.Value.ToString();
            ddlPeriodo.SelectedValue = SGSDesenvolvimento.Periodo;
            txtPorcaoAlimento.Text = SGSDesenvolvimento.PorcaoAlimento;
            ltbAlimentos.SelectedValue = SGSDesenvolvimento.Alimento;
            txtDiretiva.Text = SGSDesenvolvimento.Diretiva;

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

        #endregion

    }
}*/