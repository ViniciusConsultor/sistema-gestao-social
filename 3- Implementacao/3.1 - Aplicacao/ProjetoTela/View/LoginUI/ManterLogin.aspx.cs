using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            if (!Page.IsPostBack)
            {
                this.CarregarTela();
            }
        }

        /// <summary>
        /// Evento onClick do botão Salvar login
        /// </summary>
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            SGSServico sgsServico = new SGSServico();

            SGSLogin = sgsServico.SalvarLogin(PegarDadosView());

            ClientScript.RegisterStartupScript(Page.GetType(), "DadosSalvos", "<script> alert('Dados salvos com sucesso!'); </script>");

            //string url = @"ManterLogin.aspx?tipo=alt&cod=" + SGSLogin.CodigoLogin.Value.ToString();
            //Server.Transfer(url);
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

            if (ddlPessoaSistema.SelectedValue != "Selecione")
                objLogin.Pessoa_CodigoPessoa = Convert.ToInt32(ddlPessoaSistema.SelectedValue);
            else
                objLogin.Pessoa_CodigoPessoa = null;

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

            if (SGSLogin.Pessoa_CodigoPessoa.HasValue)
                ddlPessoaSistema.SelectedValue = SGSLogin.Pessoa_CodigoPessoa.Value.ToString();
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