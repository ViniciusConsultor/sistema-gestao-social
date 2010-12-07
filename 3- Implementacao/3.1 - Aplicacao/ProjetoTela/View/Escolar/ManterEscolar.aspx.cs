﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Servicos;
using SGS.Entidades;
using SGS.Entidades.DTO;
using BRQ.SI.SCB.UI.Web.UserControls;

namespace SGS.View.Escolar
{
    public partial class ManterEscolar : System.Web.UI.Page
    {
        #region Eventos

        /// <summary>
        /// Evento OnLoad da tela
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageBox1.OnClickButtonYes += new MessageBox.ClickButtonYes(MessageBoxControl_OnConfirmarExcluir);

            if (!Page.IsPostBack)
            {
                this.CarregarTela();
            }
            else if (HiddenField1.Value == "Retorno")
            {
                string url = @"ManterEscolar.aspx?tipo=alt&cod=" + SGSEscolarDTO.Escolar.CodigoEscolar.Value.ToString();
                Response.Redirect(url);
            }
            else if (HiddenField1.Value == "Exclusao")
            {
                Response.Redirect("ConsultarEscolar.aspx");
            }
        }

        /// <summary>
        /// Evento onClick do botão Salvar Escolar
        /// </summary>
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            SGSServico sgsServico = new SGSServico();

            SGSEscolarDTO.Escolar = sgsServico.SalvarEscolar(PegarDadosView());
            MessageBox1.ShowMessage("Dados salvos com sucesso!", BRQ.SI.SCB.UI.Web.UserControls.MessageBoxType.Success);
            HiddenField1.Value = "Retorno";
        }

        /// <summary>
        /// Evento OnClick do Botão Cancelar
        /// </summary>
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            string url;
            if (Request.QueryString["tipo"] == "alt")
                url = @"ManterEscolar.aspx?tipo=alt&cod=" + Request.QueryString["cod"];
            else
                url = "ManterEscolar.aspx";

            Server.Transfer(url);
        }

        /// <summary>
        /// Evento OnClick do Botão Excluir
        /// </summary>
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox1.ShowMessage("Deseja realmente excluir?", BRQ.SI.SCB.UI.Web.UserControls.MessageBoxType.Question);

        }

        #endregion

        #region Metodos

        /// <summary>
        /// Este método preenche os controles da tela de acordo com a operação que está sendo executado "cadastro" ou "edição".
        /// </summary>
        public void CarregarTela()
        {
            SGSServico objSGSServico = new SGSServico();
            SGSEscolarDTO = new SGS.Entidades.DTO.EscolarDTO();

            objSGSServico.ListarAssistido(true);

            this.AssistidoLista = objSGSServico.ListarAssistido(true);

            //Alterar Escolar
            if (Request.QueryString["tipo"] == "alt" && (DadosAcesso.Perfil == "Gestor" || DadosAcesso.Perfil == "Funcionario"))
            {
                lblTitulo.Text = "Alterar Dados Escolares";
                lblDescricao.Text = "<b>Descrição:</b> Permite alterar os dados escolares dos assistidos.";
                btnExcluir.Visible = true;
                //ddlAssistido.Enabled = false;

                int codigoEscolar = Convert.ToInt32(Request.QueryString["cod"]);

                //Preencha a propriedade Escolar
                SGSEscolarDTO.Escolar = objSGSServico.ObterEscolar(codigoEscolar);

                if (SGSEscolarDTO.Escolar != null)
                    this.PreencherDadosView();
                else
                    Server.Transfer("MsgEscolar.aspx"); //transfere usuário para tela de mensagem de Dados Escolares não cadastrados.
            }

            //Cadastrar Escolar
            else if (DadosAcesso.Perfil == "Gestor" || DadosAcesso.Perfil == "Funcionario")
            {
                SGSEscolarDTO = new SGS.Entidades.DTO.EscolarDTO();
                lblTitulo.Text = "Cadastrar Dados Escolares";
                lblDescricao.Text = "<b>Descrição:</b> Permite cadastrar os dados escolares dos assistidos.";
                btnExcluir.Visible = false;
            }

            //Usuário sem permissão
            else
            {
                Server.Transfer("../SemPermissao.aspx");
            }
        }

        /// <summary>
        /// Preencha a entidade Escolar com os dados da View
        /// </summary>
        private SGS.Entidades.Escolar PegarDadosView()
        {
            SGS.Entidades.DTO.EscolarDTO objSGSEscolarDTO = SGSEscolarDTO;

            objSGSEscolarDTO.Escolar.Assistido_CodigoAssistido = Convert.ToInt32(ddlAssistido.SelectedValue);
            objSGSEscolarDTO.Escolar.DataMatricula = Convert.ToDateTime(txtDataMatricula.Text);
            if (!String.IsNullOrEmpty(txtDataSaida.Text))
                objSGSEscolarDTO.Escolar.DataSaida = Convert.ToDateTime(txtDataSaida.Text);
            else
                objSGSEscolarDTO.Escolar.DataSaida = null;
            objSGSEscolarDTO.Escolar.GrauEscolaridade = ddlGrauEscolaridade.SelectedValue;
            objSGSEscolarDTO.Escolar.Instituicao = txtInstituicaoEnsino.Text;
            objSGSEscolarDTO.Escolar.MediaEscola = Convert.ToInt32(txtMediaEscolar.Text);
            objSGSEscolarDTO.Escolar.NumInscricaoInstituicao = txtNumeroInscricao.Text;
            objSGSEscolarDTO.Escolar.SerieCursada = txtSerieCursada.Text;
            objSGSEscolarDTO.Escolar.StatusSerie = ddlStatusSerie.SelectedValue;
            objSGSEscolarDTO.Escolar.Contato.Bairro = txtBairro.Text;
            objSGSEscolarDTO.Escolar.Contato.Blog = txtBlog.Text;
            objSGSEscolarDTO.Escolar.Contato.CEP = txtCEP.Text;
            objSGSEscolarDTO.Escolar.Contato.Cidade = txtCidade.Text;
            objSGSEscolarDTO.Escolar.Contato.Email = txtEmail.Text;
            objSGSEscolarDTO.Escolar.Contato.Estado = ddlEstado.SelectedValue;
            objSGSEscolarDTO.Escolar.Contato.Fax = txtFax.Text;
            objSGSEscolarDTO.Escolar.Contato.Logradouro = txtLogradouro.Text;
            objSGSEscolarDTO.Escolar.Contato.Numero = txtNumero.Text;
            objSGSEscolarDTO.Escolar.Contato.Pais = ddlPais.SelectedValue;
            objSGSEscolarDTO.Escolar.Contato.TelefoneCelular = txtTelefoneCelular.Text;
            objSGSEscolarDTO.Escolar.Contato.TelefoneConvencional = txtTelefone.Text;
            objSGSEscolarDTO.Escolar.Contato.Site = txtSite.Text;


            return objSGSEscolarDTO.Escolar;
        }

        /// <summary>
        /// Preenche a View com os dados que estão na entidade Escolar
        /// </summary>
        private void PreencherDadosView()
        {

            ddlAssistido.SelectedValue = Convert.ToString(SGSEscolarDTO.Escolar.Assistido_CodigoAssistido);
            txtDataMatricula.Text = SGSEscolarDTO.Escolar.DataMatricula.Value.ToString();
            if (SGSEscolarDTO.Escolar.DataSaida.HasValue)
                txtDataSaida.Text = SGSEscolarDTO.Escolar.DataSaida.Value.ToString();
            txtInstituicaoEnsino.Text = SGSEscolarDTO.Escolar.Instituicao;
            txtMediaEscolar.Text = Convert.ToString(SGSEscolarDTO.Escolar.MediaEscola);
            txtNumeroInscricao.Text = SGSEscolarDTO.Escolar.NumInscricaoInstituicao;
            txtSerieCursada.Text = SGSEscolarDTO.Escolar.SerieCursada;
            ddlGrauEscolaridade.SelectedValue = SGSEscolarDTO.Escolar.GrauEscolaridade;
            ddlStatusSerie.SelectedValue = SGSEscolarDTO.Escolar.StatusSerie;
            txtBairro.Text = SGSEscolarDTO.Escolar.Contato.Bairro;
            txtBlog.Text = SGSEscolarDTO.Escolar.Contato.Blog;
            txtCEP.Text = SGSEscolarDTO.Escolar.Contato.CEP;
            txtCidade.Text = SGSEscolarDTO.Escolar.Contato.Cidade;
            txtEmail.Text = SGSEscolarDTO.Escolar.Contato.Email;
            txtFax.Text = SGSEscolarDTO.Escolar.Contato.Fax;
            ddlEstado.SelectedValue = SGSEscolarDTO.Escolar.Contato.Estado;
            ddlPais.SelectedValue = SGSEscolarDTO.Escolar.Contato.Pais;
            txtLogradouro.Text = SGSEscolarDTO.Escolar.Contato.Logradouro;
            txtNumero.Text = SGSEscolarDTO.Escolar.Contato.Numero;
            txtSite.Text = SGSEscolarDTO.Escolar.Contato.Site;
            txtTelefone.Text = SGSEscolarDTO.Escolar.Contato.TelefoneConvencional;
            txtTelefoneCelular.Text = SGSEscolarDTO.Escolar.Contato.TelefoneCelular;
        }

        protected void MessageBoxControl_OnConfirmarExcluir()
        {
            SGSServico objSGSServico = new SGSServico();

            if (objSGSServico.ExcluirEscolar(SGSEscolarDTO.Escolar.CodigoEscolar.Value, SGSEscolarDTO.Escolar.Contato.CodigoContato.Value))
                MessageBox1.ShowMessage("Dado escolar excluído com sucesso!", BRQ.SI.SCB.UI.Web.UserControls.MessageBoxType.Success);
            
            HiddenField1.Value = "Exclusao";
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Esta propriedade armazena em memória os dados da Entidade Escolar
        /// </summary>
        public SGS.Entidades.DTO.EscolarDTO SGSEscolarDTO
        {
            set
            {
                if (ViewState["EscolarDTO"] == null)
                    ViewState.Add("EscolarDTO", value);
                else
                    ViewState["EscolarDTO"] = value;
            }
            get
            {
                if (ViewState["EscolarDTO"] == null)
                    return null;
                else
                    return (SGS.Entidades.DTO.EscolarDTO)ViewState["EscolarDTO"];

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