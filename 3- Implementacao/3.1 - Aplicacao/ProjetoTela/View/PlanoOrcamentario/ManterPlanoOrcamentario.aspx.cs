using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Servicos;
using SGS.Entidades.DTO;

namespace SGS.View.PlanoOrcamentario
{
    public partial class ManterPlanoOrcamentario : System.Web.UI.Page
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
        /// Evento On Click do botão Salvar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSalvar_Click(object sender, EventArgs e)
        {

            SGSServico sgsServico = new SGSServico();

            SGSOrcamento = PegarDadosView();
            SGSOrcamento.Orcamento = sgsServico.SalvarOrcamento(SGSOrcamento.Orcamento);

            string url = @"ManterPlanoOrcamentario.aspx?tipo=alt&cod=" + SGSOrcamento.Orcamento.CodigoOrcamento.Value.ToString();
            Server.Transfer(url);

            ClientScript.RegisterStartupScript(Page.GetType(), "DadosSalvos", "<script> alert('Dados salvos com sucesso!'); </script>");


        }

        /// <summary>
        /// Evento OnClick do Botão Excluir
        /// </summary>
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            if (objSGSServico.ExcluirOrcamento(SGSOrcamento.Orcamento.CodigoOrcamento.Value))
                ClientScript.RegisterStartupScript(Page.GetType(), "DadosExcluidos", "<script> alert('Plano Orcamentário excluído com sucesso!'); </script>");

            Response.Redirect("ConsultarPlanoOrcamentario.aspx");
        }

        /// <summary>
        /// Evento On Click do botão Cancelar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["tipo"] == "alt")
            {
                Server.Transfer("ManterPlanoOrcamentario.aspx?tipo=alt&cod=" + SGSOrcamento.Orcamento.CodigoOrcamento.Value.ToString());

            }
            else
            {
                Server.Transfer("ManterPlanoOrcamentario.aspx");
            }

        }

        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            SGSServico sgsServico = new SGSServico();

            SGSOrcamento = PegarDadosView();
            SGSOrcamento.OrcamentoNatureza = sgsServico.IncluirItemOrcamento(SGSOrcamento.OrcamentoNatureza);
            btnRemover.Enabled = true;

            SGSOrcamento.OrcamentoNaturezaLista = sgsServico.ListarOrcamentoNatureza(SGSOrcamento.Orcamento.CodigoOrcamento.Value);

            lblVisualizarItem.Visible = true;
            gridOrcamento.Visible = true;
            gridOrcamento.DataSource = SGSOrcamento.OrcamentoNaturezaLista;
            gridOrcamento.DataBind();

            PreencherDadosView();

            ClientScript.RegisterStartupScript(Page.GetType(), "DadosSalvos", "<script> alert('Item do Orçamento incluído com sucesso!'); </script>");
        }

        protected void btnRemover_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();
            SGSOrcamento = PegarDadosView();

            if (objSGSServico.ExcluirOrcamentoNatureza(SGSOrcamento.OrcamentoNatureza.CodigoOrcamento.Value, SGSOrcamento.OrcamentoNatureza.CodigoNatureza.Value))
            {
                btnRemover.Enabled = false;
                SGSOrcamento.OrcamentoNatureza = null;
                PreencherDadosView();

                SGSOrcamento.OrcamentoNaturezaLista = objSGSServico.ListarOrcamentoNatureza(SGSOrcamento.Orcamento.CodigoOrcamento.Value);

                lblVisualizarItem.Visible = true;
                gridOrcamento.Visible = true;
                gridOrcamento.DataSource = SGSOrcamento.OrcamentoNaturezaLista;
                gridOrcamento.DataBind();

                PreencherDadosView();

                ClientScript.RegisterStartupScript(Page.GetType(), "DadosExcluidos", "<script> alert('Item do Orçamento excluído com sucesso!'); </script>");
            }
        }

        protected void ddlNaturezaDespesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddl = (DropDownList)sender;

            if (ddl.SelectedValue == "Selecione")
            {
                txtValorDespesa.Text = "";
                btnRemover.Enabled = false;
            }
            else
            {
                SGSServico objSGSServico = new SGSServico();
                SGSOrcamento = PegarDadosView();

                SGSOrcamento.OrcamentoNatureza = objSGSServico.ObterOrcamentoNatureza(SGSOrcamento.OrcamentoNatureza.CodigoNatureza.Value, SGSOrcamento.OrcamentoNatureza.CodigoOrcamento.Value);

                if (SGSOrcamento.OrcamentoNatureza == null)
                    btnRemover.Enabled = false;
                else
                    btnRemover.Enabled = true;

                if (SGSOrcamento.OrcamentoNatureza == null)
                {
                    SGSOrcamento.OrcamentoNatureza = new Entidades.OrcamentoNatureza();
                    SGSOrcamento.OrcamentoNatureza.CodigoNatureza = Convert.ToInt32(ddlNaturezaDespesa.SelectedValue);
                    btnRemover.Enabled = false;
                }
                PreencherDadosView();
            }
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
            SGSOrcamento = new OrcamentoDTO();
            SGSOrcamento.Orcamento = new Entidades.Orcamento();

            ddlCasaLar.DataSource = objSGSServico.ListarCasaLarOrcamento();
            ddlCasaLar.DataBind();

            ddlNaturezaDespesa.DataSource = objSGSServico.ListarNaturezaDespesa();
            ddlNaturezaDespesa.DataBind();
            ddlNaturezaDespesa.Items.Insert(0, new ListItem("Selecione", "Selecione"));

            if (Request.QueryString["tipo"] == "alt")
            {
                lblTitulo.Text = "Alterar Plano Orçamentário";
                lblDescricao.Text = "Descrição: Permite alterar o Plano Orçamentário da Casa Lar.";
                btnExcluir.Visible = true;

                SGSOrcamento.Orcamento.CodigoOrcamento = Convert.ToInt32(Request.QueryString["cod"]);

                //preenche a propriedade Plano Orcamentario
                SGSOrcamento.Orcamento = objSGSServico.ObterOrcamento(SGSOrcamento.Orcamento.CodigoOrcamento.Value);


                SGSOrcamento.OrcamentoNaturezaLista = objSGSServico.ListarOrcamentoNatureza(SGSOrcamento.Orcamento.CodigoOrcamento.Value);
                gridOrcamento.Visible = true;
                gridOrcamento.DataSource = SGSOrcamento.OrcamentoNaturezaLista;
                gridOrcamento.DataBind();

                if (SGSOrcamento != null)
                    this.PreencherDadosView();
                else
                    Server.Transfer("bla.aspx"); //transfere usuário para tela plano não encontrado
            }
            else
            {
                lblTitulo.Text = "Cadastrar Plano Orçamentário";
                lblDescricao.Text = "Descrição: Permite cadastrar o Plano Orçamentário da Casa Lar.";
                btnExcluir.Visible = false;

                gridOrcamento.Visible = false;
                btnIncluir.Visible = false;
                btnRemover.Visible = false;
                ddlNaturezaDespesa.Visible = false;
                txtValorDespesa.Visible = false;
                pnlItemOrcamento.Visible = false;
                pnlHR.Visible = false;
                pnlGrid.Visible = false;
                lblItemOrcamento.Visible = false;
                lblNaturezaDespesa.Visible = false;
                lblValorDespesa.Visible = false;
                validatorValorOrcado.Enabled = false;
                validatorValorOrcado.Visible = false;
                lblVisualizarItem.Visible = false;
            }
        }

        /// <summary>
        /// Preencha a entidade Orcamento com os dados da View
        /// </summary>
        private SGS.Entidades.DTO.OrcamentoDTO PegarDadosView()
        {
            SGS.Entidades.DTO.OrcamentoDTO objOrcamentoDTO = SGSOrcamento;

            objOrcamentoDTO.Orcamento.CodigoCasaLar = Convert.ToInt32(ddlCasaLar.SelectedValue);
            objOrcamentoDTO.Orcamento.NomePlano = txtNomePlano.Text;

            if (txtInicioVigencia.Text != "")
                objOrcamentoDTO.Orcamento.InicioVigencia = Convert.ToDateTime(txtInicioVigencia.Text);
            else
                objOrcamentoDTO.Orcamento.InicioVigencia = null;

            if (txtFimVigencia.Text != "")
                objOrcamentoDTO.Orcamento.FimVigencia = Convert.ToDateTime(txtFimVigencia.Text);
            else
                objOrcamentoDTO.Orcamento.FimVigencia = null;

            if (txtValorOrcamento.Text != "")
                objOrcamentoDTO.Orcamento.ValorOrcamento = Convert.ToDecimal(txtValorOrcamento.Text);
            else
                objOrcamentoDTO.Orcamento.ValorOrcamento = null;

            objOrcamentoDTO.Orcamento.StatusPlano = ddlStatus.SelectedValue;

            if (ddlNaturezaDespesa.Visible == true && ddlNaturezaDespesa.SelectedValue != "Selecione")
            {
                objOrcamentoDTO.OrcamentoNatureza = new Entidades.OrcamentoNatureza();

                objOrcamentoDTO.OrcamentoNatureza.CodigoOrcamento = objOrcamentoDTO.Orcamento.CodigoOrcamento;
                objOrcamentoDTO.OrcamentoNatureza.CodigoNatureza = Convert.ToInt32(ddlNaturezaDespesa.SelectedValue);
                objOrcamentoDTO.OrcamentoNatureza.DataCriacao = DateTime.Now;

                if (txtValorDespesa.Text != "")
                    objOrcamentoDTO.OrcamentoNatureza.Valor = Convert.ToDecimal(txtValorDespesa.Text);
            }
            else
            {
                objOrcamentoDTO.OrcamentoNatureza = null;
            }

            return objOrcamentoDTO;
        }


        /// <summary>
        /// Preenche a View com os dados que estão na entidade OrcamentoDTO.
        /// </summary>
        private void PreencherDadosView()
        {
            txtNomePlano.Text = SGSOrcamento.Orcamento.NomePlano;
            txtInicioVigencia.Text = SGSOrcamento.Orcamento.InicioVigencia.Value.ToString();
            txtFimVigencia.Text = SGSOrcamento.Orcamento.FimVigencia.Value.ToString();
            txtValorOrcamento.Text = String.Format("{0:F}", SGSOrcamento.Orcamento.ValorOrcamento);
            txtValorOrcado.Text = String.Format("{0:C2}", SGSOrcamento.Orcamento.ValorOrcado);
            txtValorFinanceiroReal.Text = String.Format("{0:C2}", SGSOrcamento.Orcamento.ValorFinanceiroReal);
            txtSaldoDisponivel.Text = String.Format("{0:C2}", SGSOrcamento.Orcamento.SaldoDisponivelOrcamento);
            ddlStatus.SelectedValue = SGSOrcamento.Orcamento.StatusPlano;

            if (SGSOrcamento.Orcamento.CodigoCasaLar.HasValue)
                ddlCasaLar.SelectedValue = SGSOrcamento.Orcamento.CodigoCasaLar.Value.ToString();

            if (SGSOrcamento.OrcamentoNatureza != null)
            {
                if (SGSOrcamento.OrcamentoNatureza.CodigoNatureza.HasValue)
                    ddlNaturezaDespesa.SelectedValue = SGSOrcamento.OrcamentoNatureza.CodigoNatureza.Value.ToString();
                if (SGSOrcamento.OrcamentoNatureza.Valor.HasValue)
                    txtValorDespesa.Text = SGSOrcamento.OrcamentoNatureza.Valor.ToString();
                else
                    txtValorDespesa.Text = "";
            }
            else
            {
                ddlNaturezaDespesa.SelectedValue = "Selecione";
                txtValorDespesa.Text = "";
            }
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Esta propriedade armazena em memória os dados da Entidade Orcamento
        /// </summary>
        public SGS.Entidades.DTO.OrcamentoDTO SGSOrcamento
        {
            set
            {
                if (ViewState["SGSOrcamento"] == null)
                    ViewState.Add("SGSOrcamento", value);
                else
                    ViewState["SGSOrcamento"] = value;
            }
            get
            {
                if (ViewState["SGSOrcamento"] == null)
                    return null;
                else
                    return (SGS.Entidades.DTO.OrcamentoDTO)ViewState["SGSOrcamento"];
            }

        }

        #endregion

        protected void gridOrcamento_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridOrcamento.PageIndex = e.NewPageIndex;
            gridOrcamento.DataSource = SGSOrcamento.OrcamentoNaturezaLista;
            gridOrcamento.DataBind();
        }

    }
}