using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Entidades.DTO;
using SGS.Servicos;

namespace SGS.View.LoginUI
{
    public partial class ConsultarLogin : System.Web.UI.Page
    {

        #region Eventos

        /// <summary>
        /// Evento onLoad da Página
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {

            // Caso usuário logado não possua acessa redireciona usuário para tela que informa que ele não possui acesso.
            if (DadosAcesso.Perfil != "Gestor")
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
            
            LoginDTO = new LoginDTO();

            LoginDTO.LoginValor = txtLogin.Text;
            LoginDTO.NomeValor = txtNome.Text;

            LoginDTO = objSGSServico.ConsultarLogin(LoginDTO);


            GridLoginDataSource = LoginDTO.LoginLista;

        }

        /// <summary>
        /// Evento onClick do Limpar Login
        /// </summary>
        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            Server.Transfer("ConsultarLogin.aspx");
        }

        /// <summary>
        /// Este método é executado quando o usuário clica em 
        /// algum número do paginador da Grid View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gridLogin_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridLogin.PageIndex = e.NewPageIndex;
            GridLoginDataSource = LoginDTO.LoginLista;
        }

        #endregion

        #region Metodos


        #endregion

        #region Propriedades

        /// <summary>
        /// Propriedade de LoginDTO que fica em memória ViewState
        /// </summary>
        protected LoginDTO LoginDTO
        {
            set 
            {
                ViewState.Add("LoginDTO", value);
            }
            get 
            {
                if (ViewState["LoginDTO"] == null)
                    return null;
                else
                    return (LoginDTO)ViewState["LoginDTO"];
            }
        }


        /// <summary>
        /// Preenche o Grid de Login
        /// </summary>
        protected List<SGS.Entidades.Login> GridLoginDataSource
        {
            set
            {
                gridLogin.DataSource = value;
                gridLogin.DataBind();
            }
        }

        #endregion

    }
}