using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SGS.Entidades;
using SGS.Entidades.DTO;
using SGS.Servicos;

namespace SGS.View.Pessoa
{
    public partial class ConsultarAssistido : System.Web.UI.Page
    {

        #region Eventos

        protected void Page_Load(object sender, EventArgs e)
        {
            if (DadosAcesso.Perfil == "Gestor" || DadosAcesso.Perfil == "Funcionario")
            {
                if (!Page.IsPostBack)
                    CarregarPagina();
            }
            else
            {
                Server.Transfer("../SemPermissao.aspx");
            }
        }

        protected void btnLocalizar_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            PegarDadosView();
            SGSConsultarAssistidoDTO.AssistidoLista = objSGSServico.ConsultarAssistido(SGSConsultarAssistidoDTO);
            GridAssistidoDataSource = SGSConsultarAssistidoDTO.AssistidoLista;
        }

        protected void ddlAssistido_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddl = (DropDownList)sender;

            if (ddl.SelectedValue == "Selecione")
            {
                ddlStatusAssistido.Enabled = true;
                ddlStatusCadastro.Enabled = true;
                txtNome.Enabled = true;
            }
            else
            {
                ddlStatusAssistido.SelectedValue = "Selecione";
                ddlStatusAssistido.Enabled = false;
                ddlStatusCadastro.SelectedValue = "Selecione";
                ddlStatusCadastro.Enabled = false;
                txtNome.Text = "";
                txtNome.Enabled = false;
            }

        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            Server.Transfer("ConsultarAssistido.aspx");
        }

        protected void gridAssistido_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridAssistido.PageIndex = e.NewPageIndex;
            GridAssistidoDataSource = SGSConsultarAssistidoDTO.AssistidoLista;
        }

        #endregion

        #region Metodos

        public void CarregarPagina()
        {
            SGSServico objSGSServico = new SGSServico();
            SGSConsultarAssistidoDTO = new ConsultarAssistidoDTO();

            SGSConsultarAssistidoDTO.AssistidoLista = objSGSServico.ListarAssistido(null);
            AssistidoDataSource = SGSConsultarAssistidoDTO.AssistidoLista;

            //if (DadosAcesso.Perfil != "Gestor")
            //{
            //    Server.Transfer("../SemPermissao.aspx");
            //}

        }

        public void PegarDadosView()
        {
            if (ddlAssistido.SelectedValue != "Selecione")
                SGSConsultarAssistidoDTO.CodigoAssisitoValor = Convert.ToInt32(ddlAssistido.SelectedValue);
            else
                SGSConsultarAssistidoDTO.CodigoAssisitoValor = null;

            if (ddlStatusAssistido.SelectedValue != "Selecione")
                SGSConsultarAssistidoDTO.StatusAssistidoValor = ddlStatusAssistido.SelectedValue;
            else
                SGSConsultarAssistidoDTO.StatusAssistidoValor = "";

            if (ddlStatusCadastro.SelectedValue != "Selecione")
                SGSConsultarAssistidoDTO.StatusCadastroValor = Convert.ToBoolean(ddlStatusCadastro.SelectedValue);
            else
                SGSConsultarAssistidoDTO.StatusCadastroValor = null;

            SGSConsultarAssistidoDTO.NomeAssistidoValor = txtNome.Text;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Esta propriedade representa o ConsultarAssistidoDTO e fica em memória
        /// </summary>
        public ConsultarAssistidoDTO SGSConsultarAssistidoDTO
        {
            set
            {
                if (ViewState["SGSConsultarAssistidoDTO"] == null)
                    ViewState.Add("SGSConsultarAssistidoDTO", value);
                else
                    ViewState["SGSConsultarAssistidoDTO"] = value;
            }
            get
            {
                if (ViewState["SGSConsultarAssistidoDTO"] == null)
                    return null;
                else
                    return (ConsultarAssistidoDTO)ViewState["SGSConsultarAssistidoDTO"];
            }
        }

        /// <summary>
        /// Preenche o campo ddlAssistido
        /// </summary>
        public List<Entidades.Assistido> AssistidoDataSource
        {
            set
            {
                ddlAssistido.DataSource = value;
                ddlAssistido.DataBind();
                ddlAssistido.Items.Insert(0, new ListItem("Selecione", "Selecione"));
            }
        }

        /// <summary>
        /// Preenche o campo ddlAssistido
        /// </summary>
        public List<Entidades.Assistido> GridAssistidoDataSource
        {
            set
            {
                gridAssistido.DataSource = value;
                gridAssistido.DataBind();
            }
        }

        #endregion

    }

}