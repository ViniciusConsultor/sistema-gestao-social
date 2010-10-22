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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.CarregarTela();
            }

        }

        /// <summary>
        /// Evento onClick do botão Salvar CasaLar
        /// </summary>
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            SGSServico sgsServico = new SGSServico();

            SGSCasaLar = sgsServico.SalvarCasaLar(PegarDadosView());

            string url = @"ManterCasaLar.aspx?tipo=alt&cod=" + SGSCasaLar.CodigoCasaLar.Value.ToString();
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
                url = @"ManterCasaLar.aspx?tipo=alt&cod=" + Request.QueryString["cod"].ToString();
            else
                url = "ManterCasaLar.aspx";

            Server.Transfer(url);
        }

        /// <summary>
        /// Evento OnClick do Botão Excluir
        /// </summary>
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

           if (objSGSServico.ExcluirCasaLar(SGSCasaLar.CodigoCasaLar.Value, SGSCasaLar.Contato.CodigoContato.Value))
                ClientScript.RegisterStartupScript(Page.GetType(), "DadosExcluidos", "<script> alert('Casa Lar excluída com sucesso!'); </script>");

            Response.Redirect("ConsultarCasaLar.aspx");
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
                lblTitulo.Text = "Alterar Casa Lar";
                lblDescricao.Text = "Descrição: Permite alterar os dados da Casa Lar.";
                btnExcluir.Visible = true;
                SGSCasaLar.CodigoCasaLar = Convert.ToInt32(Request.QueryString["cod"]);

                //Preencha a propriedade Casa Lar
                SGSCasaLar = objSGSServico.ObterCasaLar(SGSCasaLar.CodigoCasaLar.Value);

                if (SGSCasaLar != null)
                    this.PreencherDadosView();
                else
                    Server.Transfer("ConsultarCasaLar.aspx"); //transfere usuário para tela de Consulta
            }
            else
            {
                lblTitulo.Text = "Cadastrar Casa Lar";
                lblDescricao.Text = "Descrição: Permite cadastrar os dados da Casa Lar.";
                btnExcluir.Visible = false;
            }
        }

        /// <summary>
        /// Preencha a entidade CasaLar com os dados da View
        /// </summary>
        private SGS.Entidades.CasaLar PegarDadosView()
        {
            SGS.Entidades.CasaLar objCasaLar = SGSCasaLar;

            objCasaLar.NomeCasaLar = txtNome.Text;
            objCasaLar.Alvara = txtAlvara.Text;
            objCasaLar.CNPJ = txtCNPJ.Text;
            objCasaLar.DataFundacao = Convert.ToDateTime(txtDataFundacao.Text);
            objCasaLar.EmailGestor = txtEmailGestor.Text;
            objCasaLar.Gestor = txtGestor.Text;
            objCasaLar.Historia = txtHistoria.Text;
            objCasaLar.QtdAssistidos = Convert.ToInt32(txtQtdAssistidos.Text);
            objCasaLar.QtdMaxAssistidos = Convert.ToInt32(txtQtdMaximo.Text);
            objCasaLar.StatusCasaLar = ddlStatus.SelectedValue;
            objCasaLar.TelefoneGestor = txtTelefoneGestor.Text;
           ///TODO: Maycon
            objCasaLar.Foto = "bla";
            objCasaLar.Contato.Bairro = txtBairro.Text;
            objCasaLar.Contato.Blog = txtBlog.Text;
            objCasaLar.Contato.CEP = txtCEP.Text;
            objCasaLar.Contato.Cidade = txtCidade.Text;
            objCasaLar.Contato.Email = txtEmail.Text;
            objCasaLar.Contato.Estado = ddlEstado.SelectedValue;
            objCasaLar.Contato.FAX = txtFax.Text;
            objCasaLar.Contato.Logradouro = txtLogradouro.Text;
            objCasaLar.Contato.Numero = txtNumero.Text;
            objCasaLar.Contato.Pais = ddlPais.SelectedValue;
            objCasaLar.Contato.TelefoneCelular = txtTelefoneCelular.Text;
            objCasaLar.Contato.TelefoneConvencional = txtTelefone.Text;
            objCasaLar.Contato.Site = txtSite.Text;
            
      
            return objCasaLar;
        }

        /// <summary>
        /// Preenche a View com os dados que estão na entidade CasaLar
        /// </summary>
        private void PreencherDadosView()
        {
            txtNome.Text = SGSCasaLar.NomeCasaLar;
            txtAlvara.Text = SGSCasaLar.Alvara;
            txtBairro.Text = SGSCasaLar.Contato.Bairro;
            txtBlog.Text = SGSCasaLar.Contato.Blog;
            txtCEP.Text = SGSCasaLar.Contato.CEP;
            txtCidade.Text = SGSCasaLar.Contato.Cidade;
            txtCNPJ.Text = SGSCasaLar.CNPJ;
            txtDataFundacao.Text = SGSCasaLar.DataFundacao.Value.ToString();
            txtEmail.Text = SGSCasaLar.Contato.Email;
            txtEmailGestor.Text = SGSCasaLar.EmailGestor;
            txtFax.Text = SGSCasaLar.Contato.FAX;
            ddlEstado.SelectedValue = SGSCasaLar.Contato.Estado;
            ddlPais.SelectedValue = SGSCasaLar.Contato.Pais;
            ddlStatus.SelectedValue = SGSCasaLar.StatusCasaLar;
            txtGestor.Text = SGSCasaLar.Gestor;
            txtHistoria.Text = SGSCasaLar.Historia;
            ///TODO: Maycon
            ///uploadFoto
            txtLogradouro.Text = SGSCasaLar.Contato.Logradouro;
            txtNumero.Text = SGSCasaLar.Contato.Numero;
            txtQtdAssistidos.Text = SGSCasaLar.QtdAssistidos.Value.ToString();
            txtQtdMaximo.Text = Convert.ToString(SGSCasaLar.QtdMaxAssistidos.Value);
            txtSite.Text = SGSCasaLar.Contato.Site;
            txtTelefone.Text = SGSCasaLar.Contato.TelefoneConvencional;
            txtTelefoneCelular.Text = SGSCasaLar.Contato.TelefoneCelular;
            txtTelefoneGestor.Text = SGSCasaLar.TelefoneGestor;
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