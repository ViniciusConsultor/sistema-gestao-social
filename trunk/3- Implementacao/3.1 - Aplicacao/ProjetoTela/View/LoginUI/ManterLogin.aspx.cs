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
    public partial class ManterLogin : System.Web.UI.Page
    {


        #region Eventos

        /// <summary>
        /// Evento OnLoad da tela
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
            // Caso usuário logado não possua acessa redireciona usuário para tela que informa que ele não possui acesso.
            else
            {
                Server.Transfer("../SemPermissao.aspx");
            }
        }

        /// <summary>
        /// Evento onClick do botão Salvar login
        /// </summary>
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            SGSServico sgsServico = new SGSServico();

            SGSLogin = sgsServico.SalvarLogin(PegarDadosView());

            string url = @"ManterLogin.aspx?tipo=alt&cod=" + SGSLogin.CodigoLogin.Value.ToString();
            Response.Redirect(url);

            ClientScript.RegisterStartupScript(Page.GetType(), "DadosSalvos", "<script> alert('Dados salvos com sucesso!'); </script>");
        }

        /// <summary>
        /// Evento OnClick do Botão Cancelar
        /// </summary>
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            string url;
            if (Request.QueryString["tipo"] == "alt")
                url = @"ManterLogin.aspx?tipo=alt&cod=" + Request.QueryString["cod"].ToString();
            else
                url = "ManterLogin.aspx";

            Server.Transfer(url);
        }

        /// <summary>
        /// Evento OnClick do Botão Excluir
        /// </summary>
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            if (objSGSServico.ExcluirLogin(SGSLogin.CodigoLogin.Value))
                ClientScript.RegisterStartupScript(Page.GetType(), "DadosExcluidos", "<script> alert('Login excluído com sucesso!'); </script>");

            Response.Redirect("ConsultarLogin.aspx");
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Este método valida se o usuário possui permissão de acesso
        /// </summary>
        /// <returns></returns>
        public bool ValidarPermissao()
        {
            return true;
        }


        /// <summary>
        /// Este método preenche os controles da tela de acordo com a operação que
        /// está sendo executado "cadastro" ou "edição".
        /// </summary>
        public void CarregarTela()
        {
            SGSServico objSGSServico = new SGSServico();
            SGSLogin = new Entidades.Login();

            if (Request.QueryString["tipo"] == "alt")
            {
                ////* View/LoginUI/ManterLogin.aspx?tipo=alt&cod=1
                lblTitulo.Text = "Alterar Login";
                lblDescricao.Text = "Descrição: Permite cadastrar os logins de acesso ao sistema.";
                btnExcluir.Visible = true;
                SGSLogin.CodigoLogin = Convert.ToInt32(Request.QueryString["cod"]);
                //SGSLogin.CodigoLogin = 1;

                SGSLogin = objSGSServico.ObterLogin(SGSLogin.CodigoLogin.Value);

                if (SGSLogin != null)
                    this.PreencherDadosView();
                else
                    Server.Transfer("bla.aspx"); //transfere usuário para tela de usuário não encontrado
            }
            else
            {
                lblTitulo.Text = "Cadastrar Login";
                lblDescricao.Text = "Descrição: Permite cadastrar os logins de acesso ao sistema.";
                btnExcluir.Visible = false;
            }
        }

        /// <summary>
        /// Preencha a entidade Login com os dados da View
        /// </summary>
        private SGS.Entidades.Login PegarDadosView()
        {
            SGS.Entidades.Login objLogin = SGSLogin;
            objLogin.Email = txtEmail.Text;
            objLogin.LoginUsuario = txtLogin.Text;
            objLogin.Nome = txtNome.Text;
            objLogin.Perfil = ddlPerfil.SelectedValue;
            objLogin.Senha = txtSenha.Text;

            return objLogin;
        }

        /// <summary>
        /// Preenche a View com os dados que estão na entidade Login
        /// </summary>
        private void PreencherDadosView()
        {
            txtEmail.Text = SGSLogin.Email;
            txtEmailConfirma.Text = SGSLogin.Email;
            txtLogin.Text = SGSLogin.LoginUsuario;
            txtNome.Text = SGSLogin.Nome;
            txtSenha.Text = SGSLogin.Senha;
            ddlPerfil.SelectedValue = SGSLogin.Perfil;

        }
        
        #endregion

        #region Propriedades

        /// <summary>
        /// Esta propriedade armazena em memória os dados da Entidade Login
        /// </summary>
        public SGS.Entidades.Login SGSLogin
        {
            set
            {
                if (ViewState["SGSLogin"] == null)
                    ViewState.Add("SGSLogin", value);
                else
                    ViewState["SGSLogin"] = value;
            }
            get
            {
                if (ViewState["SGSLogin"] == null)
                    return null;
                else
                    return (SGS.Entidades.Login)ViewState["SGSLogin"];
            }

        }

        #endregion


    }
}