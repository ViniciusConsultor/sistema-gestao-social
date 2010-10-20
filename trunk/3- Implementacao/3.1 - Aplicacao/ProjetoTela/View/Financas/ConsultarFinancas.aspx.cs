using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Entidades.DTO;
using SGS.Servicos;

namespace SGS.View.Financas
{
    public partial class ConsultarFinancas : System.Web.UI.Page
    {

        #region Eventos

        /// <summary>
        /// Evento onLoad da Página
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
        /// Evento onClick do Localizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLocalizar_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            FinancasDTO = new FinancasDTO();

            FinancasDTO.TipoLancamentoValor = ddlTipoLancamento.Text;
            FinancasDTO.DescricaoValor = txtDescricao.Text;

            if (txtDataLancamento.Text == "")
            {
                FinancasDTO.DataLancamentoValor = null;
            }
            else
            {
                FinancasDTO.DataLancamentoValor = Convert.ToDateTime(txtDataLancamento.Text);
            }

            FinancasDTO = objSGSServico.ConsultarFinancas(FinancasDTO);


            GridFinancasDataSource = FinancasDTO.FinancasLista;

        }

        /// <summary>
        /// Evento onClick do Limpar Finanças
        /// </summary>
        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarFinancas.aspx");
        }

        /// <summary>
        /// Esse método é responsável pela paginação da GridFinancas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gridFinancas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridFinancas.PageIndex = e.NewPageIndex;
            GridFinancasDataSource = FinancasDTO.FinancasLista;
        }

        #endregion

        #region Metodos

        public void CarregarTela()
        {
            SGSServico objSGSServico = new SGSServico();
            SGSFinancas = new Entidades.Financas();

            if (Request.QueryString["tipo"] == "con")
            {
                ////* View/Financas/ManterFinancas.aspx?tipo=alt&cod=1
                lblTitulo.Text = "Consultar Finanças";
                lblDescricao.Text = "Descrição: Permite consultar as Finanças da Casa Lar.";
                btnLimpar.Visible = true;
                SGSFinancas.CodigoFinancas = Convert.ToInt32(Request.QueryString["cod"]);
                //SGSFinancas.CodigoFinancas = 1;

                SGSFinancas = objSGSServico.ObterFinancas(SGSFinancas.CodigoFinancas.Value);
            }

        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Propriedade de FinancasDTO que fica em memória ViewState
        /// </summary>
        protected FinancasDTO FinancasDTO
        {
            set
            {
                ViewState.Add("FinancasDTO", value);
            }
            get
            {
                if (ViewState["FinancasDTO"] == null)
                    return null;
                else
                    return (FinancasDTO)ViewState["FinancasDTO"];
            }
        }


        /// <summary>
        /// Preenche o Grid de Financas
        /// </summary>
        protected List<SGS.Entidades.Financas> GridFinancasDataSource
        {
            set
            {
                gridFinancas.DataSource = value;
                gridFinancas.DataBind();
            }
        }

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

        #endregion

    }
}