using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Entidades.DTO;
using SGS.Servicos;
using SGS.Entidades;

namespace SGS.View.Procedimentos
{
    public partial class ConsultarProcedimentos : System.Web.UI.Page
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
            
            ProcedimentosDTO = new ProcedimentosDTO();


            if (ddlAssistido.SelectedValue == "Selecione")
            {
                ProcedimentosDTO.AssistidoValor = null;
            }
            else
            {
                ProcedimentosDTO.AssistidoValor = Convert.ToInt32(ddlAssistido.SelectedValue);
            }


            if (txtDataMarcada.Text == "")
            {
                ProcedimentosDTO.DataMarcadaValor = null;
            }
            else
            {
                ProcedimentosDTO.DataMarcadaValor = Convert.ToDateTime(txtDataMarcada.Text);
            }

            if (txtDataRealizada.Text == "")
            {
                ProcedimentosDTO.DataRealizadaValor = null;
            }
            else
            {
                ProcedimentosDTO.DataRealizadaValor = Convert.ToDateTime(txtDataRealizada.Text);
            }

            ProcedimentosDTO = objSGSServico.ConsultarProcedimentos(ProcedimentosDTO);


            GridProcedimentosDataSource = ProcedimentosDTO.ProcedimentosAssistidoDTOLista;

        }

         /// <summary>
        /// Evento onClick do Limpar Login
        /// </summary>
        protected void btnLimpar_Click(object sender, EventArgs e)
        {

            Server.Transfer("ConsultarProcedimentos.aspx");
        }

        /// <summary>
        /// Esse método é responsável pela paginação da GridProcedimentos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gridProcedimentos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridProcedimentos.PageIndex = e.NewPageIndex;
            GridProcedimentosDataSource = ProcedimentosDTO.ProcedimentosAssistidoDTOLista;
        }

        #endregion

        #region Metodos

        public void CarregarTela()
        {
            SGSServico objSGSServico = new SGSServico();
            SGSProcedimentos = new Entidades.Procedimentos();

            objSGSServico.ListarAssistido(true);

            this.AssistidoLista = objSGSServico.ListarAssistido(true);

        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Propriedade de ProcedimentosDTO que fica em memória ViewState
        /// </summary>
        protected ProcedimentosDTO ProcedimentosDTO
        {
            set
            {
                ViewState.Add("ProcedimentosDTO", value);
            }
            get
            {
                if (ViewState["ProcedimentosDTO"] == null)
                    return null;
                else
                    return (ProcedimentosDTO)ViewState["ProcedimentosDTO"];
            }
        }


        /// <summary>
        /// Preenche o Grid de desenvolvimento
        /// </summary>
        protected List<SGS.Entidades.ProcedimentosAssistidoDTO> GridProcedimentosDataSource
        {
            set
            {
                gridProcedimentos.DataSource = value;
                gridProcedimentos.DataBind();
            }
        }

        /// <summary>
        /// Esta propriedade armazena em memória os dados da Entidade Procedimentos
        /// </summary>
        public SGS.Entidades.Procedimentos SGSProcedimentos
        {
            set
            {
                if (ViewState["SGSProcedimentos"] == null)
                    ViewState.Add("SGSProcedimentos", value);
                else
                    ViewState["SGSProcedimentos"] = value;
            }
            get
            {
                if (ViewState["SGSProcedimentos"] == null)
                    return null;
                else
                    return (SGS.Entidades.Procedimentos)ViewState["SGSProcedimentos"];
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