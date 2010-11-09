using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Servicos;
using SGS.Entidades.DTO;


namespace SGS.View.Alimentacao
{
    public partial class ManterAlimentacao : System.Web.UI.Page
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

            SGSAlimentacao = sgsServico.SalvarAlimentacao(PegarDadosView());

            ClientScript.RegisterStartupScript(Page.GetType(), "DadosSalvos", "<script> alert('Dados salvos com sucesso!'); </script>");

            string url = @"ManterAlimentacao.aspx?tipo=alt&cod=" + SGSAlimentacao.CodigoAlimentacao.Value.ToString();
            Server.Transfer(url);

        }

        /// <summary>
        /// Evento OnClick do Botão Cancelar
        /// </summary>
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["tipo"] == "alt")
            {
                Server.Transfer("ManterAlimentacao.aspx?tipo=alt&cod=" + SGSAlimentacao.CodigoAlimentacao.Value.ToString());

            }
            else
            {
                Server.Transfer("ManterAlimentacao.aspx");
            }

        }

        /// <summary>
        /// Evento OnClick do Botão Excluir
        /// </summary>
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            if (objSGSServico.ExcluirAlimentacao(SGSAlimentacao.CodigoAlimentacao.Value))
                ClientScript.RegisterStartupScript(Page.GetType(), "DadosExcluidos", "<script> alert('Finança excluída com sucesso!'); </script>");

            Response.Redirect("ConsultarAlimentacao.aspx");
        }

        #endregion


        #region Metodos

        /// <summary>
        /// Este método preenche os controles da tela de acordo com a operação que está sendo executado "cadastro" ou "edição".
        /// </summary>
        public void CarregarTela()
        {
            SGSServico objSGSServico = new SGSServico();
            SGSAlimentacao = new Entidades.Alimentacao();

            if (Request.QueryString["dia"] != null)
            {
                ddlDiaSemana.SelectedValue = Request.QueryString["dia"].ToString();
                ddlPeriodo.Visible = true;
                lblPeriodo.Visible = true;


                lblTitulo.Text = "Alterar Alimentação";
                lblDescricao.Text = "Descrição: Permite alterar a Alimentação da Casa Lar.";
            }
        }

        /// <summary>
        /// Preencha a entidade Alimentacao com os dados da View
        /// </summary>
        private SGS.Entidades.Alimentacao PegarDadosView()
        {
            SGS.Entidades.Alimentacao objAlimentacao = SGSAlimentacao;

            objAlimentacao.DiaSemana = ddlDiaSemana.SelectedValue;
            objAlimentacao.Horario = Convert.ToDateTime(txtHorario.Text);
            objAlimentacao.Periodo = ddlPeriodo.SelectedValue;
            objAlimentacao.Alimento = ltbAlimentos.SelectedValue;
            objAlimentacao.Diretiva = txtDiretiva.Text;

            return objAlimentacao;
        }

        /// <summary>
        /// Preenche a View com os dados que estão na entidade Alimentação
        /// </summary>
        private void PreencherDadosView()
        {

            ddlDiaSemana.SelectedValue = SGSAlimentacao.DiaSemana;
            txtHorario.Text = SGSAlimentacao.Horario.Value.ToString();
            ddlPeriodo.SelectedValue = SGSAlimentacao.Periodo;
            ltbAlimentos.SelectedValue = SGSAlimentacao.Alimento;
            txtDiretiva.Text = SGSAlimentacao.Diretiva;

        }

        #endregion


        #region Propriedades

        /// <summary>
        /// Esta propriedade armazena em memória os dados da Entidade Alimentacao
        /// </summary>
        public SGS.Entidades.Alimentacao SGSAlimentacao
        {
            set
            {
                if (ViewState["SGSAlimentacao"] == null)
                    ViewState.Add("SGSAlimentacao", value);
                else
                    ViewState["SGSAlimentacao"] = value;
            }
            get
            {
                if (ViewState["SGSAlimentacao"] == null)
                    return null;
                else
                    return (SGS.Entidades.Alimentacao)ViewState["SGSAlimentacao"];
            }

        }

        #endregion

        protected void ddlDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlDiaSemana = (DropDownList)sender;


            if (ddlDiaSemana.SelectedValue == "Selecione")
            {
                Server.Transfer("ManterAlimentacao.aspx");
            }
            else
            {
                string url;
                url = "ManterAlimentacao.aspx?dia=" + ddlDiaSemana.SelectedValue;
                Server.Transfer(url);
                //TODO: Exibir Periodo
            }
        }

        protected void ddlPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlPeriodo = (DropDownList)sender;

            if (ddlPeriodo.SelectedValue == "Selecione")
            {
                txtDiretiva.Visible = false;
                txtHorario.Visible = false;
                btnExcluir.Visible = false;
                ltbAlimentos.Visible = false;
            }
            //Qualquer outro periodo: Desjejum, Almoço, Janter, etc...
            else
            {
                //TODO: Ir na base de dados 
                txtDiretiva.Visible = true;
                lblDiretiva.Visible = true;
                txtHorario.Visible = true;
                lblHorario.Visible = true;
                ltbAlimentos.Visible = true;
                lblAlimentos.Visible = true;
                btnExcluir.Visible = true;

            }
        }

      
    }
}
