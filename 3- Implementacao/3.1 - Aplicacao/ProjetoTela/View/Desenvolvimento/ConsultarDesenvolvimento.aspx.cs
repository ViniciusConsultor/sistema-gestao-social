using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Entidades.DTO;
using SGS.Entidades;
using SGS.Servicos;

namespace SGS.View.Desenvolvimento
{
    public partial class ConsultarDesenvolvimento : System.Web.UI.Page
    {

    
        #region Eventos

        /// <summary>
        /// Evento onLoad da Página
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

        protected void btnLocalizar_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            DesenvolvimentoDTO = new DesenvolvimentoDTO();


            if (ddlAssistido.SelectedValue == "Selecione")
            {
                DesenvolvimentoDTO.AssistidoValor = null;
            }
            else
            {
                DesenvolvimentoDTO.AssistidoValor = Convert.ToInt32(ddlAssistido.SelectedValue);
            }

            if (txtAtividade.Text == "")
            {
                DesenvolvimentoDTO.AtividadeValor = "";
            }
            else
            {
                DesenvolvimentoDTO.AtividadeValor = txtAtividade.Text;
            }


            if (txtDataInicio.Text == "")
            {
                DesenvolvimentoDTO.DataInicioValor = null;
            }
            else
            {
                DesenvolvimentoDTO.DataInicioValor = Convert.ToDateTime(txtDataInicio.Text);
            }

            if (txtDataFim.Text == "")
            {
                DesenvolvimentoDTO.DataFimValor = null;
            }
            else
            {
                DesenvolvimentoDTO.DataFimValor = Convert.ToDateTime(txtDataFim.Text);
            }

            DesenvolvimentoDTO = objSGSServico.ConsultarDesenvolvimento(DesenvolvimentoDTO);


            GridDesenvolvimentoDataSource = DesenvolvimentoDTO.DesenvolvimentoAssistidoDTOLista;

        }

        /// <summary>
        /// Evento onClick do Limpar Login
        /// </summary>
        protected void btnLimpar_Click(object sender, EventArgs e)
        {

            Server.Transfer("ConsultarDesenvolvimento.aspx");
        }

        /// <summary>
        /// Esse método é responsável pela paginação da GridDesenvolvimento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gridDesenvolvimento_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridDesenvolvimento.PageIndex = e.NewPageIndex;
            GridDesenvolvimentoDataSource = DesenvolvimentoDTO.DesenvolvimentoAssistidoDTOLista;
        }

        #endregion

        #region Metodos

        public void CarregarTela()
        {
            SGSServico objSGSServico = new SGSServico();
            SGSDesenvolvimento = new Entidades.Desenvolvimento();

            objSGSServico.ListarAssistido(true);

            this.AssistidoLista = objSGSServico.ListarAssistido(true);

        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Propriedade de DesenvolvimentoDTO que fica em memória ViewState
        /// </summary>
        protected DesenvolvimentoDTO DesenvolvimentoDTO
        {
            set
            {
                ViewState.Add("DesenvolvimentoDTO", value);
            }
            get
            {
                if (ViewState["DesenvolvimentoDTO"] == null)
                    return null;
                else
                    return (DesenvolvimentoDTO)ViewState["DesenvolvimentoDTO"];
            }
        }


        /// <summary>
        /// Preenche o Grid de Desenvolvimento
        /// </summary>
        protected List<SGS.Entidades.DTO.DesenvolvimentoAssistidoDTO> GridDesenvolvimentoDataSource
        {
            set
            {
                gridDesenvolvimento.DataSource = value;
                gridDesenvolvimento.DataBind();
            }
        }

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