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
            if (DadosAcesso.Perfil == "Gestor"  || DadosAcesso.Perfil == "Funcionario")
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

            string url = @"ManterPlanoOrcamentario.aspx?tipo=alt&cod=" + SGSOrcamento.OrcamentoNatureza.CodigoOrcamento.Value.ToString();
            Server.Transfer(url);

            ClientScript.RegisterStartupScript(Page.GetType(), "DadosSalvos", "<script> alert('Dados salvos com sucesso!'); </script>");

            
        }




        protected void btnRemover_Click(object sender, EventArgs e)
        {

            SGSServico objSGSServico = new SGSServico();

            if (objSGSServico.ExcluirOrcamento(SGSOrcamento.Orcamento.CodigoOrcamento.Value))
                ClientScript.RegisterStartupScript(Page.GetType(), "DadosExcluidos", "<script> alert('Plano Orcamentário excluído com sucesso!'); </script>");

            Response.Redirect("ConsultarPlanoOrcamentario.aspx");

        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {

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

            if (Request.QueryString["tipo"] == "alt")
            {
             
                lblTitulo.Text = "Alterar PlanoOrcamentario";
                lblDescricao.Text = "Descrição: Permite alterar os Planos Orçamentário da Casa Lar.";
                btnExcluir.Visible = true;

                SGSOrcamento.Orcamento.CodigoOrcamento = Convert.ToInt32(Request.QueryString["cod"]);
                
                //preenche a propriedade Plano Orcamentario
                SGSOrcamento.Orcamento = objSGSServico.ObterOrcamento(SGSOrcamento.Orcamento.CodigoOrcamento.Value);

                gridOrcamento.Visible = true;

                if (SGSOrcamento != null)
                    this.PreencherDadosView();
                else
                    Server.Transfer("bla.aspx"); //transfere usuário para tela plano não encontrado
            }
            else
            {
                lblTitulo.Text = "Cadastrar Orcamento";
                lblDescricao.Text = "Descrição: Permite cadastrar os Orcamento Casa Lar.";
                btnExcluir.Visible = false;

                gridOrcamento.Visible = false;
                btnIncluir.Visible = false;
                btnLimpar.Visible = false;
                btnRemover.Visible = false;
                ddlNaturezaDespesa.Visible = false;
                txtValorDespesa.Visible = false;
                lblNaturezaDespesa.Visible = false;
                lblValorDespesa.Visible = false;


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
            objOrcamentoDTO.Orcamento.InicioVigencia = Convert.ToDateTime(txtInicioVigencia.Text);
            objOrcamentoDTO.Orcamento.FimVigencia = Convert.ToDateTime(txtFimVigencia.Text);
            objOrcamentoDTO.Orcamento.ValorOrcamento = Convert.ToDecimal(txtValorOrcamento.Text);
            objOrcamentoDTO.Orcamento.SaldoDisponivel = Convert.ToDecimal(txtSaldoDisponivel.Text);
            objOrcamentoDTO.Orcamento.StatusPlano = ddlStatus.SelectedValue;

            if (ddlNaturezaDespesa.Visible == true)
            {
                objOrcamentoDTO.OrcamentoNatureza.CodigoNatureza = Convert.ToInt32(ddlNaturezaDespesa.SelectedValue);
                objOrcamentoDTO.OrcamentoNatureza.DataCriacao = DateTime.Now;
                objOrcamentoDTO.OrcamentoNatureza.CodigoOrcamento = objOrcamentoDTO.Orcamento.CodigoOrcamento;

                if (txtValorDespesa.Text != "")
                    objOrcamentoDTO.OrcamentoNatureza.Valor = Convert.ToDecimal(txtValorDespesa.Text);
            }
            
            return objOrcamentoDTO;
        }


        /// <summary>
        /// Preenche a View com os dados que estão na entidade Orcamento.
        /// </summary>
        private void PreencherDadosView()
        {

            txtNomePlano.Text = SGSOrcamento.Orcamento.NomePlano;
            txtInicioVigencia.Text = SGSOrcamento.Orcamento.InicioVigencia.Value.ToString();
            txtFimVigencia.Text = SGSOrcamento.Orcamento.FimVigencia.Value.ToString();
            txtValorOrcamento.Text = SGSOrcamento.Orcamento.ValorOrcamento.ToString();
            txtSaldoDisponivel.Text = SGSOrcamento.Orcamento.SaldoDisponivel.ToString();
            ddlStatus.SelectedValue = SGSOrcamento.Orcamento.StatusPlano;

            if (SGSOrcamento.Orcamento.CodigoCasaLar.HasValue)
                ddlCasaLar.SelectedValue = SGSOrcamento.Orcamento.CodigoCasaLar.Value.ToString();

            if (SGSOrcamento.NaturezaLancamento.CodigoNatureza.HasValue)
                ddlNaturezaDespesa.SelectedValue = SGSOrcamento.NaturezaLancamento.CodigoNatureza.Value.ToString();

            if (SGSOrcamento.OrcamentoNatureza.Valor.HasValue)
                txtValorDespesa.Text = SGSOrcamento.OrcamentoNatureza.Valor.ToString();



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



    }
}