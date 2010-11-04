﻿using System;
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

            SGSOrcamento = sgsServico.SalvarOrcamento(PegarDadosView());

            string url = @"ManterPlanoOrcamentario.aspx?tipo=alt&cod=" + SGSOrcamento.CodigoOrcamento.Value.ToString();
            Server.Transfer(url);

            ClientScript.RegisterStartupScript(Page.GetType(), "DadosSalvos", "<script> alert('Dados salvos com sucesso!'); </script>");

                       
        }

        /// <summary>
        /// Evento OnClick do Botão Excluir
        /// </summary>
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            if (objSGSServico.ExcluirOrcamento(SGSOrcamento.CodigoOrcamento.Value))
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
                Server.Transfer("ManterPlanoOrcamentario.aspx?tipo=alt&cod=" + SGSOrcamento.CodigoOrcamento.Value.ToString());

            }
            else
            {
                Server.Transfer("ManterPlanoOrcamentario.aspx");
            }

        }


        protected void btnIncluir_Click(object sender, EventArgs e)
        {

            
        }


        #endregion

        protected void btnRemover_Click(object sender, EventArgs e)
        {

        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        #region Metodos

        /// <summary>
        /// Este método preenche os controles da tela de acordo com a operação que
        /// está sendo executado "cadastro" ou "edição".
        /// </summary>
        public void CarregarTela()
        {
            SGSServico objSGSServico = new SGSServico();
            SGSOrcamento = new Entidades.Orcamento();
            ddlCasaLar.DataSource = objSGSServico.ListarCasaLarOrcamento();
            ddlCasaLar.DataBind();
            ddlNaturezaDespesa.DataSource = objSGSServico.ListarNaturezaDespesa();
            ddlNaturezaDespesa.DataBind();

            if (Request.QueryString["tipo"] == "alt")
            {
             
                lblTitulo.Text = "Alterar PlanoOrcamentario";
                lblDescricao.Text = "Descrição: Permite alterar os Planos Orçamentário da Casa Lar.";
                btnExcluir.Visible = true;
                                
                SGSOrcamento.CodigoOrcamento = Convert.ToInt32(Request.QueryString["cod"]);
                
                //preenche a propriedade Plano Orcamentario
                SGSOrcamento = objSGSServico.ObterOrcamento(SGSOrcamento.CodigoOrcamento.Value);


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

            }
        }

        /// <summary>
        /// Preencha a entidade Orcamento com os dados da View
        /// </summary>
        private SGS.Entidades.Orcamento PegarDadosView()
        {
            SGS.Entidades.Orcamento objOrcamento = SGSOrcamento;

            objOrcamento.CodigoCasaLar = Convert.ToInt32(ddlCasaLar.SelectedValue);
            objOrcamento.NomePlano = txtNomePlano.Text;
            objOrcamento.InicioVigencia = Convert.ToDateTime(txtInicioVigencia.Text);
            objOrcamento.FimVigencia = Convert.ToDateTime(txtFimVigencia.Text);
            objOrcamento.ValorOrcamento = Convert.ToDecimal(txtValorOrcamento.Text);
            objOrcamento.SaldoDisponivel = Convert.ToDecimal(txtSaldoDisponivel.Text);
            objOrcamento.StatusPlano = ddlStatus.SelectedValue;
            objOrcamento.NaturezaLancamento.NomeNatureza = ddlNaturezaDespesa.SelectedValue;
            objOrcamento.OrcamentoNatureza.Valor = Convert.ToDecimal(txtValorDespesa.Text);


            return objOrcamento;
        }


        /// <summary>
        /// Preenche a View com os dados que estão na entidade Orcamento.
        /// </summary>
        private void PreencherDadosView()
        {

            txtNomePlano.Text = SGSOrcamento.NomePlano;
            txtInicioVigencia.Text = SGSOrcamento.InicioVigencia.Value.ToString();
            txtFimVigencia.Text = SGSOrcamento.FimVigencia.Value.ToString();
            txtValorOrcamento.Text = SGSOrcamento.ValorOrcamento.ToString();
            txtSaldoDisponivel.Text = SGSOrcamento.SaldoDisponivel.ToString();
            ddlStatus.SelectedValue = SGSOrcamento.StatusPlano;
           // ddlNaturezaDespesa.SelectedValue = SGSNaturezaLancamento.NomeNatureza;
            txtValorDespesa.Text = SGSOrcamento.OrcamentoNatureza.Valor.ToString();

            if (SGSOrcamento.CodigoCasaLar.HasValue)
                ddlCasaLar.SelectedValue = SGSOrcamento.CodigoCasaLar.Value.ToString();

            if (SGSOrcamento.OrcamentoNatureza.CodigoNatureza.HasValue)
                ddlNaturezaDespesa.SelectedValue = SGSOrcamento.OrcamentoNatureza.CodigoNatureza.Value.ToString();


        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Esta propriedade armazena em memória os dados da Entidade Orcamento
        /// </summary>
        public SGS.Entidades.Orcamento SGSOrcamento
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
                    return (SGS.Entidades.Orcamento)ViewState["SGSOrcamento"];
            }

        }

        #endregion



    }
}