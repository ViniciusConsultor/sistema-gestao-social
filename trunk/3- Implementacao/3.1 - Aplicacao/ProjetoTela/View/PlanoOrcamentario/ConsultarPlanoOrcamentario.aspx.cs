using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Entidades.DTO;
using SGS.Servicos;

namespace SGS.View.PlanoOrcamentario
{
    public partial class ConsultarPlanoOrcamentario : System.Web.UI.Page
    {

        #region Eventos

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
        /// Evento onClick do Localizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLocalizar_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            OrcamentoDTO = new OrcamentoDTO();

            OrcamentoDTO.NomePlanoValor = ddlNomePlano.Text;

            if (txtInicioVigencia.Text == "")
            {
                OrcamentoDTO.InicioVigenciaValor = null;
            }
            else
            {
                OrcamentoDTO.InicioVigenciaValor = Convert.ToDateTime(txtInicioVigencia.Text);
            }

            if (txtFimVigencia.Text == "")
            {
                OrcamentoDTO.FimVigenciaValor = null;
            }
            else
            {
                OrcamentoDTO.FimVigenciaValor = Convert.ToDateTime(txtFimVigencia.Text);
            }
            

            OrcamentoDTO = objSGSServico.ConsultarOrcamento(OrcamentoDTO);


            GridOrcamentoDataSource = OrcamentoDTO.OrcamentoLista;

        }

        /// <summary>
        /// Evento onClick do Limpar Finanças
        /// </summary>
        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarOrcamento.aspx");
        }

               /// <summary>
        /// Esse método é responsável pela paginação da GridOrcamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gridOrcamento_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridOrcamento.PageIndex = e.NewPageIndex;
            GridOrcamentoDataSource = OrcamentoDTO.OrcamentoLista;
        }

        #endregion

        #region Metodos

        public void CarregarTela()
        {
            SGSServico objSGSServico = new SGSServico();
            SGSOrcamento = new Entidades.Orcamento();

            ddlNomePlano.DataSource = objSGSServico.ListarOrcamento();
            ddlNomePlano.DataBind();

            if (Request.QueryString["tipo"] == "con")
            {
                ////* View/Orcamento/ManterPlanoOrcamentario.aspx?tipo=alt&cod=1
                lblTitulo.Text = "Consultar Plano Orçamentário";
                lblDescricao.Text = "Descrição: Permite consultar os Planos Orçamentários da Casa Lar.";
                btnLimpar.Visible = true;
                SGSOrcamento.CodigoOrcamento = Convert.ToInt32(Request.QueryString["cod"]);
               

                SGSOrcamento = objSGSServico.ObterOrcamento(SGSOrcamento.CodigoOrcamento.Value);
            }

        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Propriedade de OrcamentoDTO que fica em memória ViewState
        /// </summary>
        protected OrcamentoDTO OrcamentoDTO
        {
            set
            {
                ViewState.Add("OrcamentoDTO", value);
            }
            get
            {
                if (ViewState["OrcamentoDTO"] == null)
                    return null;
                else
                    return (OrcamentoDTO)ViewState["OrcamentoDTO"];
            }
        }


        /// <summary>
        /// Preenche o Grid de Orcamento
        /// </summary>
        protected List<SGS.Entidades.Orcamento> GridOrcamentoDataSource
        {
            set
            {
                gridOrcamento.DataSource = value;
                gridOrcamento.DataBind();
            }
        }

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