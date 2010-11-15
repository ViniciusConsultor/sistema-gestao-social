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
            if (!Page.IsPostBack)
            {
                CarregarPagina();
            }
        }

        #endregion

        #region Metodos

        public void CarregarPagina()
        {
            SGSServico objSGSServico = new SGSServico();
            
            SGSConsultarAssistidoDTO.AssistidoLista = objSGSServico.ListarAssistido(true);
            AssistidoDataSource = SGSConsultarAssistidoDTO.AssistidoLista;

            //if (DadosAcesso.Perfil != "Gestor")
            //{
            //    Server.Transfer("../SemPermissao.aspx");
            //}

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

        #endregion
    }

}