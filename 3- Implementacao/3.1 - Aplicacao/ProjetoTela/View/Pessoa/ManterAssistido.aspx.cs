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
    public partial class ManterPessoa : System.Web.UI.Page
    {

        #region Eventos

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.CarregarPagina();
            }

            //// Valida se o usuário logado possui acesso.
            //if (DadosAcesso.Perfil == "Gestor" || DadosAcesso.Perfil == "Funcionario")
            //{
            //    if (!Page.IsPostBack)
            //    {
            //        this.CarregarPagina();
            //    }
            //}
            // //Caso usuário logado não possua acessa redireciona usuário para tela que informa que ele não possui acesso.
            //else
            //{
            //    Server.Transfer("../SemPermissao.aspx");
            //}
        }

        protected void ddlTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList objDropDownList = (DropDownList)sender;

            if (objDropDownList.SelectedValue == "Selecione")
            {
                ucPessoaDadosBasico.Visible = false;
            }
            else if (objDropDownList.SelectedValue == "Assistido")
            {
                ucPessoaDadosBasico.Visible = true;
            }
            else if (objDropDownList.SelectedValue == "Funcionario")
            {
                ucPessoaDadosBasico.Visible = true;
            }
            else if (objDropDownList.SelectedValue == "Voluntario")
            {

                ucPessoaDadosBasico.Visible = true;
            }

        }

        protected void ddlTipoPessoa_SelectedIndexChan(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            SGSAssistidoDTO.Assistido = objSGSServico.SalvarAssistido(PegarDadosView());

            string url = @"ManterAssistido.aspx?tipo=alt&cod=" + SGSAssistidoDTO.Assistido.CodigoAssistido.Value.ToString();
            Response.Redirect(url);

            //TODO: Maycon exibir alerta na tela
            ClientScript.RegisterStartupScript(Page.GetType(), "DadosSalvos", "<script> alert('Dados salvos com sucesso!'); </script>");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            List<Assistido> lista = objSGSServico.ListarAssistido(true);

            /*  string url;
              if (Request.QueryString["tipo"] == "alt")
                  url = @"ManterAssistido.aspx?tipo=alt&cod=" + Request.QueryString["cod"].ToString();
              else
                  url = "ManterAssistido.aspx";

              Server.Transfer(url); */

        }

        /// <summary>
        /// Este evento Ativa ou Desativa o Assistido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAtivarDesativar_Click(object sender, EventArgs e)
        {
            SGSServico objSGSServico = new SGSServico();

            SGSAssistidoDTO.Assistido = PegarDadosView();
            SGSAssistidoDTO.Assistido.Ativo = !SGSAssistidoDTO.Assistido.Ativo;
            SGSAssistidoDTO.Assistido = objSGSServico.SalvarAssistido(SGSAssistidoDTO.Assistido);

            if (SGSAssistidoDTO.Assistido.Ativo == true)
                ClientScript.RegisterStartupScript(Page.GetType(), "AtivarDesativar", "<script> alert('Assistido ativado com sucesso!'); </script>");
            else
                ClientScript.RegisterStartupScript(Page.GetType(), "AtivarDesativar", "<script> alert('Assistido desativado com sucesso!'); </script>");

            string url = @"ManterAssistido.aspx?tipo=alt&cod=" + SGSAssistidoDTO.Assistido.CodigoAssistido.Value.ToString();
            Response.Redirect(url);
        }

        protected void btnCarregarDadosTela_Click(object sender, EventArgs e)
        {

            ddlCasaLar.SelectedValue = "13";
            ucPessoaAssistido.StatusAssistido = "Em Atendimento";

            ucPessoaDadosBasico.Nome = "Paulo Vitor";
            ucPessoaDadosBasico.Sexo = "Masculino";

            ucPessoaDadosBasico.DataNascimento = "06/11/2010";

            ucPessoaDadosBasico.CPF = "113.698.937-11";
            ucPessoaDadosBasico.RG = "21.842.55.11";
            ucPessoaDadosBasico.Nacionalidade = "Brasileiro";
            ucPessoaDadosBasico.Naturalidade = "Fluminense";
           
            #region Dados Assistido

            //Dados Assistido

            ucPessoaAssistido.DataEntrada = "06/11/2010";
            ucPessoaAssistido.DataSaida = "06/11/2010";
            ucPessoaAssistido.EstadoSaude = "Doente";
            ucPessoaAssistido.Peso = "50,00";
            ucPessoaAssistido.Cor = "Branco";
            ucPessoaAssistido.Dormitorio = "Corredor 5A";
            ucPessoaAssistido.Altura = "1,60";
            ucPessoaAssistido.TamanhoCamisa = "PP";
            ucPessoaAssistido.TamanhoCalca = "PP";
            ucPessoaAssistido.TamanhoCalcado = "36";
            ucPessoaAssistido.Deficiente = "N";
            ucPessoaAssistido.Hobby = "Futebol, Volei, Basquete, Xadrez.";
            ucPessoaAssistido.HistoricoVida = "Pais com baixas condiçoes financeiras para cuidar da criança";

            //Dados Família
            ucPessoaAssistido.Pai = "Antônio Carlos";
            ucPessoaAssistido.Mae = "Cristina Araujo";
            ucPessoaAssistido.PaiVivo = "S";
            ucPessoaAssistido.MaeViva = "S";
            ucPessoaAssistido.CPFPai = "113.698.937.11";
            ucPessoaAssistido.CPFMae = "113.698.937.11";
            ucPessoaAssistido.RGPai = "21.842.55.44";
            ucPessoaAssistido.RGMae = "21.842.55.44";
            ucPessoaAssistido.TelPai = "(21) 2415-7501";
            ucPessoaAssistido.TelMae = "(21) 2415-7502";
            ucPessoaAssistido.QtdIrmaos = 1;


            //Dados do Responsável
            ucPessoaAssistido.Responsavel = "Tiago é o Responsavel";
            ucPessoaAssistido.CPFResponsavel = "113.698.937.33";
            ucPessoaAssistido.TelResponsavel = "(21) 8777-1234";
            ucPessoaAssistido.EmailResponsavel = "tiago@email.com";
            ucPessoaAssistido.CEPResponsavel = "23076-280";
            ucPessoaAssistido.LogradouroResponsavel = "Rua nova guine";
            ucPessoaAssistido.NumeroResponsavel = "20";
            ucPessoaAssistido.BairroResponsavel = "Santa Rosa";
            ucPessoaAssistido.CidadeResponsavel = "Rio de Janeiro";
            ucPessoaAssistido.EstadoResponsavel = "RJ";
            ucPessoaAssistido.PaisResponsavel = "Brasil";

            #endregion

        }

        #endregion

        #region Métodos

        public void CarregarPagina()
        {
            SGSAssistidoDTO = new Entidades.DTO.AssistidoDTO();
            SGSServico objSGSServico = new SGSServico();

            SGSAssistidoDTO.CasaLarLista = objSGSServico.ListarCasaLar();
            CasaLarDataSource = SGSAssistidoDTO.CasaLarLista;

            if (Request.QueryString["tipo"] == "alt")
            {
                lblTitulo.Text = "Alterar Assistido";
                lblDescricao.Text = "Descrição: Permite alterar um Assistido.";

                int codigoAssistido = Convert.ToInt32(Request.QueryString["cod"]);
                SGSAssistidoDTO.Assistido = objSGSServico.ObterAssistido(codigoAssistido);

                btnAtivarDesativar.Visible = true;
                if (SGSAssistidoDTO.Assistido.Ativo == true)
                {
                    btnAtivarDesativar.Text = "Desativar";
                    btnAtivarDesativar.OnClientClick = "return confirm('Deseja realmente desativar este assistido?')";
                }
                else
                {
                    btnAtivarDesativar.Text = "Ativar";
                    btnAtivarDesativar.OnClientClick = "return confirm('Deseja realmente ativar este assistido?')";
                }

                PreencherDadosView();
            }
            else
            {
                lblTitulo.Text = "Cadastrar Assistido";
                lblDescricao.Text = "Descrição: Permite cadastrar um Assistido.";

                btnAtivarDesativar.Visible = false;

                PreencherDadosView();
            }

        }

        public Assistido PegarDadosView()
        {
            AssistidoDTO objSGSAssistidoDTO = SGSAssistidoDTO;

            #region Pessoa Dados Basico

            if (ddlCasaLar.SelectedValue != "Selecione")
                SGSAssistidoDTO.Assistido.CodigoCasaLar = Convert.ToInt32(ddlCasaLar.SelectedValue);
            else
                SGSAssistidoDTO.Assistido.CodigoCasaLar = null;

            SGSAssistidoDTO.Assistido.TipoPessoa = "Assistido";
            SGSAssistidoDTO.Assistido.Nome = ucPessoaDadosBasico.Nome;
            SGSAssistidoDTO.Assistido.Sexo = ucPessoaDadosBasico.Sexo;

            if (ucPessoaDadosBasico.DataNascimento != "")
                SGSAssistidoDTO.Assistido.DataNascimento = Convert.ToDateTime(ucPessoaDadosBasico.DataNascimento);
            else
                SGSAssistidoDTO.Assistido.DataNascimento = null;

            SGSAssistidoDTO.Assistido.CPF = ucPessoaDadosBasico.CPF;
            SGSAssistidoDTO.Assistido.RG = ucPessoaDadosBasico.RG;
            SGSAssistidoDTO.Assistido.CertidaoNascimento = ucPessoaDadosBasico.CertidaoNascimento;
            SGSAssistidoDTO.Assistido.Nacionalidade = ucPessoaDadosBasico.Nacionalidade;
            SGSAssistidoDTO.Assistido.Naturalidade = ucPessoaDadosBasico.Naturalidade;
           
            #endregion

            #region Dados Assistido

            //Dados Assistido
            if (ucPessoaAssistido.StatusAssistido != "Selecione")
                SGSAssistidoDTO.Assistido.StatusAssistido = ucPessoaAssistido.StatusAssistido;
            else
                SGSAssistidoDTO.Assistido.StatusAssistido = "";

            if (ucPessoaAssistido.DataEntrada != "")
                SGSAssistidoDTO.Assistido.DataEntrada = Convert.ToDateTime(ucPessoaAssistido.DataEntrada);
            else
                SGSAssistidoDTO.Assistido.DataEntrada = null;

            if (ucPessoaAssistido.DataSaida != "")
                SGSAssistidoDTO.Assistido.DataSaida = Convert.ToDateTime(ucPessoaAssistido.DataSaida);
            else
                SGSAssistidoDTO.Assistido.DataSaida = null;
            SGSAssistidoDTO.Assistido.EstadoSaude = ucPessoaAssistido.EstadoSaude;
            if (ucPessoaAssistido.Peso != "")
                SGSAssistidoDTO.Assistido.Peso = Convert.ToDecimal(ucPessoaAssistido.Peso);
            else
                SGSAssistidoDTO.Assistido.Peso = null;
            SGSAssistidoDTO.Assistido.Cor = ucPessoaAssistido.Cor;
            if (ucPessoaAssistido.Altura != "")
                SGSAssistidoDTO.Assistido.Altura = Convert.ToDecimal(ucPessoaAssistido.Altura);
            SGSAssistidoDTO.Assistido.Dormitorio = ucPessoaAssistido.Dormitorio;
            SGSAssistidoDTO.Assistido.TamanhoCamisa = ucPessoaAssistido.TamanhoCamisa;
            SGSAssistidoDTO.Assistido.TamanhoCalca = ucPessoaAssistido.TamanhoCalca;
            SGSAssistidoDTO.Assistido.TamanhoCalcado = ucPessoaAssistido.TamanhoCalcado;
            SGSAssistidoDTO.Assistido.Deficiente = ucPessoaAssistido.Deficiente;
            SGSAssistidoDTO.Assistido.Hobby = ucPessoaAssistido.Hobby;
            SGSAssistidoDTO.Assistido.HistoricoVida = ucPessoaAssistido.HistoricoVida;

            //Dados Família
            SGSAssistidoDTO.Assistido.Pai = ucPessoaAssistido.Pai;
            SGSAssistidoDTO.Assistido.Mae = ucPessoaAssistido.Mae;
            SGSAssistidoDTO.Assistido.PaiVivo = ucPessoaAssistido.PaiVivo;
            SGSAssistidoDTO.Assistido.MaeViva = ucPessoaAssistido.MaeViva;
            SGSAssistidoDTO.Assistido.CPFPai = ucPessoaAssistido.CPFPai;
            SGSAssistidoDTO.Assistido.CPFMae = ucPessoaAssistido.CPFMae;
            SGSAssistidoDTO.Assistido.RGPai = ucPessoaAssistido.RGPai;
            SGSAssistidoDTO.Assistido.RGMae = ucPessoaAssistido.RGMae;
            SGSAssistidoDTO.Assistido.TelefonePai = ucPessoaAssistido.TelPai;
            SGSAssistidoDTO.Assistido.TelefoneMae = ucPessoaAssistido.TelMae;
            SGSAssistidoDTO.Assistido.QtdIrmaos = ucPessoaAssistido.QtdIrmaos;

            //Dados do Responsável
            SGSAssistidoDTO.Assistido.ResponsavelLegal = ucPessoaAssistido.Responsavel;
            SGSAssistidoDTO.Assistido.CPFResponsavel = ucPessoaAssistido.CPFResponsavel;
            SGSAssistidoDTO.Assistido.ContatoResponsavel.TelefoneConvencional = ucPessoaAssistido.TelResponsavel;
            SGSAssistidoDTO.Assistido.ContatoResponsavel.Email = ucPessoaAssistido.EmailResponsavel;
            SGSAssistidoDTO.Assistido.ContatoResponsavel.CEP = ucPessoaAssistido.CEPResponsavel;
            SGSAssistidoDTO.Assistido.ContatoResponsavel.Logradouro = ucPessoaAssistido.LogradouroResponsavel;
            SGSAssistidoDTO.Assistido.ContatoResponsavel.Numero = ucPessoaAssistido.NumeroResponsavel;
            SGSAssistidoDTO.Assistido.ContatoResponsavel.Bairro = ucPessoaAssistido.BairroResponsavel;
            SGSAssistidoDTO.Assistido.ContatoResponsavel.Cidade = ucPessoaAssistido.CidadeResponsavel;
            SGSAssistidoDTO.Assistido.ContatoResponsavel.Estado = ucPessoaAssistido.EstadoResponsavel;
            SGSAssistidoDTO.Assistido.ContatoResponsavel.Pais = ucPessoaAssistido.PaisResponsavel;

            //Verifica se algum dado de contato do Responsável foi inserido, caso não tem o Contato Responsável recebe null
            Contato contato = SGSAssistidoDTO.Assistido.ContatoResponsavel;
            if (String.IsNullOrEmpty(contato.TelefoneConvencional) && String.IsNullOrEmpty(contato.Email) && String.IsNullOrEmpty(contato.CEP) &&
                String.IsNullOrEmpty(contato.Logradouro) && String.IsNullOrEmpty(contato.Numero) && String.IsNullOrEmpty(contato.Bairro) &&
                String.IsNullOrEmpty(contato.Cidade) && String.IsNullOrEmpty(contato.Estado) && String.IsNullOrEmpty(contato.Pais))
            {
                SGSAssistidoDTO.Assistido.ContatoResponsavel = null;
            }

            #endregion

            return SGSAssistidoDTO.Assistido;

        }

        public void PreencherDadosView()
        {
            ddlCasaLar.DataSource = SGSAssistidoDTO.CasaLarLista;
            ddlCasaLar.DataBind();


            if (SGSAssistidoDTO.Assistido.CodigoCasaLar.HasValue)
                ddlCasaLar.SelectedValue = SGSAssistidoDTO.Assistido.CodigoCasaLar.Value.ToString();
            else
                ddlCasaLar.SelectedValue = "Selecione";

            ucPessoaDadosBasico.Nome = SGSAssistidoDTO.Assistido.Nome;
            ucPessoaDadosBasico.Sexo = SGSAssistidoDTO.Assistido.Sexo;

            if (SGSAssistidoDTO.Assistido.DataNascimento.HasValue)
                ucPessoaDadosBasico.DataNascimento = SGSAssistidoDTO.Assistido.DataNascimento.Value.ToString("dd/MM/yyyy");
            else
                ucPessoaDadosBasico.DataNascimento = "";

            ucPessoaDadosBasico.CPF = SGSAssistidoDTO.Assistido.CPF;
            ucPessoaDadosBasico.RG = SGSAssistidoDTO.Assistido.RG;
            ucPessoaDadosBasico.CertidaoNascimento = SGSAssistidoDTO.Assistido.CertidaoNascimento;
            ucPessoaDadosBasico.Nacionalidade = SGSAssistidoDTO.Assistido.Nacionalidade;
            ucPessoaDadosBasico.Naturalidade = SGSAssistidoDTO.Assistido.Naturalidade;
            
            #region Dados Assistido

            //Dados Assistido

            ucPessoaAssistido.StatusAssistido = SGSAssistidoDTO.Assistido.StatusAssistido;
            if (SGSAssistidoDTO.Assistido.DataEntrada.HasValue)
                ucPessoaAssistido.DataEntrada = SGSAssistidoDTO.Assistido.DataEntrada.Value.ToString("dd/MM/yyyy");
            else
                ucPessoaAssistido.DataEntrada = "";

            if (SGSAssistidoDTO.Assistido.DataSaida.HasValue)
                ucPessoaAssistido.DataSaida = SGSAssistidoDTO.Assistido.DataSaida.Value.ToString("dd/MM/yyyy");
            else
                ucPessoaAssistido.DataSaida = "";
            ucPessoaAssistido.EstadoSaude = SGSAssistidoDTO.Assistido.EstadoSaude;
            if (SGSAssistidoDTO.Assistido.Peso.HasValue)
                ucPessoaAssistido.Peso = SGSAssistidoDTO.Assistido.Peso.ToString();
            else
                ucPessoaAssistido.Peso = "";
            ucPessoaAssistido.Cor = SGSAssistidoDTO.Assistido.Cor;

            if (SGSAssistidoDTO.Assistido.Altura.HasValue)
                ucPessoaAssistido.Altura = SGSAssistidoDTO.Assistido.Altura.ToString();
            else
                ucPessoaAssistido.Altura = null;

            ucPessoaAssistido.Dormitorio = SGSAssistidoDTO.Assistido.Dormitorio;
            ucPessoaAssistido.TamanhoCamisa = SGSAssistidoDTO.Assistido.TamanhoCamisa;
            ucPessoaAssistido.TamanhoCalca = SGSAssistidoDTO.Assistido.TamanhoCalca;
            ucPessoaAssistido.TamanhoCalcado = SGSAssistidoDTO.Assistido.TamanhoCalcado;
            ucPessoaAssistido.Deficiente = SGSAssistidoDTO.Assistido.Deficiente;
            ucPessoaAssistido.Hobby = SGSAssistidoDTO.Assistido.Hobby;
            ucPessoaAssistido.HistoricoVida = SGSAssistidoDTO.Assistido.HistoricoVida;

            //Dados Família
            ucPessoaAssistido.Pai = SGSAssistidoDTO.Assistido.Pai;
            ucPessoaAssistido.Mae = SGSAssistidoDTO.Assistido.Mae;
            ucPessoaAssistido.PaiVivo = SGSAssistidoDTO.Assistido.PaiVivo;
            ucPessoaAssistido.MaeViva = SGSAssistidoDTO.Assistido.MaeViva;
            ucPessoaAssistido.CPFPai = SGSAssistidoDTO.Assistido.CPFPai;
            ucPessoaAssistido.CPFMae = SGSAssistidoDTO.Assistido.CPFMae;
            ucPessoaAssistido.RGPai = SGSAssistidoDTO.Assistido.RGPai;
            ucPessoaAssistido.RGMae = SGSAssistidoDTO.Assistido.RGMae;
            ucPessoaAssistido.TelPai = SGSAssistidoDTO.Assistido.TelefonePai;
            ucPessoaAssistido.TelMae = SGSAssistidoDTO.Assistido.TelefoneMae;
            ucPessoaAssistido.QtdIrmaos = SGSAssistidoDTO.Assistido.QtdIrmaos;


            //Dados do Responsável
            ucPessoaAssistido.Responsavel = SGSAssistidoDTO.Assistido.ResponsavelLegal;
            ucPessoaAssistido.CPFResponsavel = SGSAssistidoDTO.Assistido.CPFResponsavel;
            ucPessoaAssistido.TelResponsavel = SGSAssistidoDTO.Assistido.ContatoResponsavel.TelefoneCelular;
            ucPessoaAssistido.EmailResponsavel = SGSAssistidoDTO.Assistido.ContatoResponsavel.Email;
            ucPessoaAssistido.CEPResponsavel = SGSAssistidoDTO.Assistido.ContatoResponsavel.CEP;
            ucPessoaAssistido.LogradouroResponsavel = SGSAssistidoDTO.Assistido.ContatoResponsavel.Logradouro;
            ucPessoaAssistido.NumeroResponsavel = SGSAssistidoDTO.Assistido.ContatoResponsavel.Numero;
            ucPessoaAssistido.BairroResponsavel = SGSAssistidoDTO.Assistido.ContatoResponsavel.Bairro;
            ucPessoaAssistido.CidadeResponsavel = SGSAssistidoDTO.Assistido.ContatoResponsavel.Cidade;
            ucPessoaAssistido.EstadoResponsavel = SGSAssistidoDTO.Assistido.ContatoResponsavel.Estado;
            ucPessoaAssistido.PaisResponsavel = SGSAssistidoDTO.Assistido.ContatoResponsavel.Pais;

            #endregion

        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Esta propriedade representa o AssistidoDTO e fica em memória
        /// </summary>
        public AssistidoDTO SGSAssistidoDTO
        {
            set
            {
                if (ViewState["SGSAssistidoDTO"] == null)
                    ViewState.Add("SGSAssistidoDTO", value);
                else
                    ViewState["SGSAssistidoDTO"] = value;
            }
            get
            {
                if (ViewState["SGSAssistidoDTO"] == null)
                    return null;
                else
                    return (AssistidoDTO)ViewState["SGSAssistidoDTO"];
            }
        }

        /// <summary>
        /// Preenche o campo ddlCasaLar
        /// </summary>
        public List<Entidades.CasaLar> CasaLarDataSource
        {
            set
            {
                ddlCasaLar.DataSource = value;
                ddlCasaLar.DataBind();
            }
        }



        #endregion

    }
}