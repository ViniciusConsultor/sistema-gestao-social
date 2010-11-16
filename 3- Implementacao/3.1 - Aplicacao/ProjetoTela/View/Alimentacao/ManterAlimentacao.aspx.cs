using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Servicos;
using SGS.Entidades;
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
            if (DadosAcesso.Perfil == "Gestor" || DadosAcesso.Perfil == "Funcionario")
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

            string url = @"ManterAlimentacao.aspx?tipo=alt&cod=" + SGSAlimentacao.CodigoAlimentacao.Value.ToString();
            Response.Redirect(url);

            ClientScript.RegisterStartupScript(Page.GetType(), "DadosSalvos", "<script> alert('Dados salvos com sucesso!'); </script>");
        }

        /// <summary>
        /// Evento OnClick do Botão Cancelar
        /// </summary>
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["tipo"] == "alt")
            {
                Response.Redirect("ManterAlimentacao.aspx?tipo=alt&cod=" + SGSAlimentacao.CodigoAlimentacao.Value.ToString());
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

            Response.Redirect("ManterAlimentacao.aspx");
        }

        protected void ddlDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlDiaSemana = (DropDownList)sender;

            if (ddlDiaSemana.SelectedValue == "Selecione")
            {
                Response.Redirect("ManterAlimentacao.aspx");
            }
            else
            {
                string url;
                url = "ManterAlimentacao.aspx?dia=" + ddlDiaSemana.SelectedValue;
                Response.Redirect(url);
            }
        }

        protected void ddlPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlPeriodo = (DropDownList)sender;

            if (ddlPeriodo.SelectedValue == "Selecione")
            {
                txtDiretiva.Visible = false;
                lblDiretiva.Visible = false;
                txtHorario.Visible = false;
                lblHorario.Visible = false;
                lblAlimentos.Visible = false;
                ltbAlimentos.Visible = false;
                btnExcluir.Visible = false;
            }
            //Qualquer outro periodo: Desjejum, Almoço, Janter, etc...
            else
            {
                SGSServico objSGSServico = new SGSServico();

                Entidades.Alimentacao objAlimentacao = objSGSServico.ObterAlimentacaoPorDiaPeriodo(ddlDiaSemana.SelectedValue, ddlPeriodo.SelectedValue);
                //Caso este Dia e Período já possuam  
                if (objAlimentacao != null)
                {
                    string url = @"ManterAlimentacao.aspx?tipo=alt&cod=" + objAlimentacao.CodigoAlimentacao.Value.ToString();
                    Response.Redirect(url);
                }
                else
                {
                    string url = @"ManterAlimentacao.aspx?dia=" + ddlDiaSemana.SelectedValue + "&periodo=" + ddlPeriodo.SelectedValue;
                    Response.Redirect(url);


                }
            }
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

            SGSAlimentacao.AlimentoLista = objSGSServico.ListarAlimento();

            ltbAlimentos.DataSource = SGSAlimentacao.AlimentoLista;
            ltbAlimentos.DataBind();

            //Alterar Alimentação
            if (Request.QueryString["tipo"] != null && Request.QueryString["cod"] != null)
            {
                int codigoAlimentacao = Convert.ToInt32(Request.QueryString["cod"]);
                SGSAlimentacao = objSGSServico.ObterAlimentacao(codigoAlimentacao);
                PreencherDadosView();

                lblTitulo.Text = "Alterar Alimentação";
                lblDescricao.Text = "Descrição: Permite Alterar a Alimentação da Casa Lar.";

                HabilitarControles();
            }
            //exibe periodo depois de escolher o dia
            else
            {
                lblTitulo.Text = "Cadastrar Alimentação";
                lblDescricao.Text = "Descrição: Permite Cadastrar a Alimentação da Casa Lar.";

                if (Request.QueryString["dia"] != null && Request.QueryString["periodo"] != null)
                {
                    ddlDiaSemana.SelectedValue = Request.QueryString["dia"].ToString();
                    ddlPeriodo.SelectedValue = Request.QueryString["periodo"].ToString();

                    HabilitarControles();
                }
                else if (Request.QueryString["dia"] != null)
                {
                    ddlDiaSemana.SelectedValue = Request.QueryString["dia"].ToString();
                    ddlPeriodo.Visible = true;
                    lblPeriodo.Visible = true;
                }

                btnExcluir.Visible = false;
            }
        }

        /// <summary>
        /// Habilita controles da tela
        /// </summary>
        private void HabilitarControles()
        {
            lblPeriodo.Visible = true;
            ddlPeriodo.Visible = true;
            lblHorario.Visible = true;
            txtHorario.Visible = true;
            lblDiretiva.Visible = true;
            txtDiretiva.Visible = true;
            lblAlimentos.Visible = true;
            ltbAlimentos.Visible = true;
        }

        /// <summary>
        /// Preencha a entidade Alimentacao com os dados da View
        /// </summary>
        private SGS.Entidades.Alimentacao PegarDadosView()
        {
            SGS.Entidades.Alimentacao objAlimentacao = SGSAlimentacao;

            objAlimentacao.DiaSemana = ddlDiaSemana.SelectedValue;
            objAlimentacao.Horario = txtHorario.Text;
            objAlimentacao.Periodo = ddlPeriodo.SelectedValue;
            objAlimentacao.Diretiva = txtDiretiva.Text;

            objAlimentacao.AlimentacaoAlimentoLista = new List<AlimentacaoAlimento>();
            AlimentacaoAlimento objAlimentacaoAlimento = new AlimentacaoAlimento();
            foreach (ListItem objListItem in ltbAlimentos.Items)
            {
                objAlimentacaoAlimento = new AlimentacaoAlimento();

                if (objListItem.Selected == true)
                {
                    objAlimentacaoAlimento.CodigoAlimento = Convert.ToInt32(objListItem.Value);
                    objAlimentacao.AlimentacaoAlimentoLista.Add(objAlimentacaoAlimento);
                }
            }

            return objAlimentacao;
        }

        /// <summary>
        /// Preenche a View com os dados que estão na entidade Alimentação
        /// </summary>
        private void PreencherDadosView()
        {
            ddlDiaSemana.SelectedValue = SGSAlimentacao.DiaSemana;
            ddlPeriodo.SelectedValue = SGSAlimentacao.Periodo;
            txtHorario.Text = SGSAlimentacao.Horario;
            txtDiretiva.Text = SGSAlimentacao.Diretiva;

            foreach (AlimentacaoAlimento item in SGSAlimentacao.AlimentacaoAlimentoLista)
            {
                foreach (ListItem itemltbAlimentos in ltbAlimentos.Items)
                {
                    if (itemltbAlimentos.Value == item.CodigoAlimento.ToString())
                        itemltbAlimentos.Selected = true;
                }
            }
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


    }
}
