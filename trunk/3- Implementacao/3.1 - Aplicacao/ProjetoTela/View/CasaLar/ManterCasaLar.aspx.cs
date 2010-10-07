using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SGS.Servicos;
using SGS.Entidades;

namespace ProjetoTela.View.CasaLar
{
    public partial class ManterCasaLar : System.Web.UI.Page
    {

        #region Eventos

        /// <summary>
        /// Evento OnLoad da tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.CarregarTela();
            }

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            SGSServico sgsServico = new SGSServico();

        //   // SGSCasaLar = sgsServico.SalvarLogin(PegarDadosView());

        //    string url = @"ManterLogin.aspx?tipo=alt&cod=" + SGSCasaLar.CodigoCasaLar.Value.ToString();
        //    Response.Redirect(url);

        //    ClientScript.RegisterStartupScript(Page.GetType(), "DadosSalvos", "<script> alert('Dados salvos com sucesso!'); </script>");
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
            SGSCasaLar = new SGS.Entidades.CasaLar();

            if (Request.QueryString["tipo"] == "alt")
            {
                lblTitulo.Text = "Alterar Login";
                lblDescricao.Text = "Descrição: Permite cadastrar os logins de acesso ao sistema.";
                btnExcluir.Visible = true;
                SGSCasaLar.CodigoCasaLar = Convert.ToInt32(Request.QueryString["cod"]);

                //Preencha a propriedade Casa Lar
                SGSCasaLar = objSGSServico.ObterCasaLar(SGSCasaLar.CodigoCasaLar.Value);

                if (SGSCasaLar != null)
                    this.PreencherDadosView();
                else
                    //TODO: MAycon colocar pagina correta
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
        private SGS.Entidades.CasaLar PegarDadosView()
        {
            SGS.Entidades.CasaLar objCasaLar = SGSCasaLar;

            objCasaLar.NomeCasaLar = txtNome.Text;
            //TODO: Jonathan preencher todos os dados da Propriedade Casa Lar

            return objCasaLar;
        }

        /// <summary>
        /// Preenche a View com os dados que estão na entidade Login
        /// </summary>
        private void PreencherDadosView()
        {
            txtNome.Text = SGSCasaLar.NomeCasaLar;
            //TODO: Jonathan Para todos os outros campos

        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Esta propriedade armazena em memória os dados da Entidade CasaLar
        /// </summary>
        public SGS.Entidades.CasaLar SGSCasaLar
        {
            set
            {
                if (ViewState["SGSCasaLar"] == null)
                    ViewState.Add("SGSCasaLar", value);
                else
                    ViewState["SGSCasaLar"] = value;
            }
            get
            {
                if (ViewState["SGSCasaLar"] == null)
                    return null;
                else
                    return (SGS.Entidades.CasaLar)ViewState["SGSCasaLar"];

            }

        }

        #endregion

        

    }
}