using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Entidades;
using SGS.Entidades.DTO;
using SGS.Servicos;
using SGS.Entidades.DTO;
using SGS.Entidades;

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

            string url = @"ManterAssitido.aspx?tipo=alt&cod=" + SGSAssistidoDTO.Assistido.CodigoAssistido.Value.ToString();
            Response.Redirect(url);

            //TODO: Maycon exibir alerta na tela
            ClientScript.RegisterStartupScript(Page.GetType(), "DadosSalvos", "<script> alert('Dados salvos com sucesso!'); </script>");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            string url;
            if (Request.QueryString["tipo"] == "alt")
                url = @"ManterAssistido.aspx?tipo=alt&cod=" + Request.QueryString["cod"].ToString();
            else
                url = "ManterAssistido.aspx";

            Server.Transfer(url);

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            SGSServico umSGSServico = new SGSServico();

            umSGSServico.ExcluirAssistido(SGSAssistidoDTO.Assistido);
            ClientScript.RegisterStartupScript(Page.GetType(), "excluir", "<script> alert('Dados excluídos com sucesso!'); </script>");

            Server.Transfer("ConPessoa.aspx");
        }

        #endregion

        #region Métodos

        public void CarregarPagina()
        {
            SGSAssistidoDTO = new Entidades.DTO.AssistidoDTO();
            SGSServico objSGSServico = new SGSServico();

            SGSAssistidoDTO.CasaLarLista = objSGSServico.ListarCasaLar();

            if (Request.QueryString["tipo"] == "alt")
            {
                lblTitulo.Text = "Alterar Assistido";
                lblDescricao.Text = "Descrição: Permite alterar um Assistido.";

                int codigoAssistido = Convert.ToInt32(Request.QueryString["cod"]);
                SGSAssistidoDTO.Assistido = objSGSServico.ObterAssistido(codigoAssistido);

                btnExcluir.Visible = true;

                PreencherDadosView();
            }
            else
            {
                lblTitulo.Text = "Cadastrar Assistido";
                lblDescricao.Text = "Descrição: Permite cadastrar um Assistido.";

                btnExcluir.Visible = false;

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
            SGSAssistidoDTO.Assistido.Contato.CEP = ucPessoaDadosBasico.CEP;
            SGSAssistidoDTO.Assistido.Contato.Logradouro = ucPessoaDadosBasico.Logradouro;

            if (ucPessoaDadosBasico.Numero.HasValue)
                SGSAssistidoDTO.Assistido.Contato.Numero = ucPessoaDadosBasico.Numero.Value.ToString();
            else
                SGSAssistidoDTO.Assistido.Contato.Numero = "";
            
            SGSAssistidoDTO.Assistido.Contato.Bairro = ucPessoaDadosBasico.Bairro;
            SGSAssistidoDTO.Assistido.Contato.Cidade = ucPessoaDadosBasico.Cidade;
            SGSAssistidoDTO.Assistido.Contato.Estado = ucPessoaDadosBasico.Estado;
            SGSAssistidoDTO.Assistido.Contato.Pais = ucPessoaDadosBasico.Pais;
            SGSAssistidoDTO.Assistido.Contato.TelefoneCelular = ucPessoaDadosBasico.TelefoneCelular;
            SGSAssistidoDTO.Assistido.Contato.TelefoneConvencional = ucPessoaDadosBasico.TelefoneConvencional;
            SGSAssistidoDTO.Assistido.Contato.FAX = ucPessoaDadosBasico.Fax;
            SGSAssistidoDTO.Assistido.Contato.Email = ucPessoaDadosBasico.Email;
            SGSAssistidoDTO.Assistido.Contato.Site = ucPessoaDadosBasico.Site;
            SGSAssistidoDTO.Assistido.Contato.Blog = ucPessoaDadosBasico.Blog;
          
            #endregion

            #region Dados Assistido

            //Dados Assistido

            if (ucPessoaAssistido.StatusAssistido != "Selecione")
                SGSAssistidoDTO.Assistido.StatusAssistido = ucPessoaAssistido.StatusAssistido;
            else
                SGSAssistidoDTO.Assistido.StatusAssistido = "";

            SGSAssistidoDTO.Assistido.DataEntrada = ucPessoaAssistido.DataEntrada;
            SGSAssistidoDTO.Assistido.DataSaida = ucPessoaAssistido.DataSaida;
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
            SGSAssistidoDTO.Assistido.Mae = ucPessoaAssistido.MaeViva ;
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
            ucPessoaDadosBasico.CEP = SGSAssistidoDTO.Assistido.Contato.CEP;
            ucPessoaDadosBasico.Logradouro = SGSAssistidoDTO.Assistido.Contato.Logradouro;
            if (SGSAssistidoDTO.Assistido.Contato.Numero != "")
                ucPessoaDadosBasico.Numero = Convert.ToInt32(SGSAssistidoDTO.Assistido.Contato.Numero);
            else
                ucPessoaDadosBasico.Numero = null;

            ucPessoaDadosBasico.Bairro = SGSAssistidoDTO.Assistido.Contato.Bairro;
            ucPessoaDadosBasico.Cidade = SGSAssistidoDTO.Assistido.Contato.Cidade;
            ucPessoaDadosBasico.Estado  = SGSAssistidoDTO.Assistido.Contato.Estado;
            ucPessoaDadosBasico.Pais = SGSAssistidoDTO.Assistido.Contato.Pais;
            ucPessoaDadosBasico.TelefoneCelular = SGSAssistidoDTO.Assistido.Contato.TelefoneCelular;
            ucPessoaDadosBasico.TelefoneConvencional  = SGSAssistidoDTO.Assistido.Contato.TelefoneConvencional;
            ucPessoaDadosBasico.Fax = SGSAssistidoDTO.Assistido.Contato.FAX;
            ucPessoaDadosBasico.Email = SGSAssistidoDTO.Assistido.Contato.Email;
            ucPessoaDadosBasico.Site = SGSAssistidoDTO.Assistido.Contato.Site;
            ucPessoaDadosBasico.Blog = SGSAssistidoDTO.Assistido.Contato.Blog;


            #region Dados Assistido

            //Dados Assistido

            ucPessoaAssistido.StatusAssistido = SGSAssistidoDTO.Assistido.StatusAssistido;
            ucPessoaAssistido.DataEntrada = SGSAssistidoDTO.Assistido.DataEntrada;
            ucPessoaAssistido.DataSaida = SGSAssistidoDTO.Assistido.DataSaida;
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
            ucPessoaAssistido.MaeViva = SGSAssistidoDTO.Assistido.Mae;
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

        #endregion

        protected void btnCarregarDadosTela_Click(object sender, EventArgs e)
        {

            ddlCasaLar.SelectedValue = "4";

            ucPessoaDadosBasico.Nome = "Paulo Vitor";
            ucPessoaDadosBasico.Sexo = "Masculino";

            ucPessoaDadosBasico.DataNascimento = "06/11/2010";

            ucPessoaDadosBasico.CPF = "113.698.937-11";
            ucPessoaDadosBasico.RG = "21.842.55.11";
            ucPessoaDadosBasico.Nacionalidade = "Brasileiro";
            ucPessoaDadosBasico.Naturalidade = "Fluminense";
            ucPessoaDadosBasico.CEP = "23.0762-10";
            ucPessoaDadosBasico.Logradouro = "Rua Campo Grande";
            ucPessoaDadosBasico.Numero = 10;

            ucPessoaDadosBasico.Bairro = "Campo Grande";
            ucPessoaDadosBasico.Cidade = "Rio de Janeiro";
            ucPessoaDadosBasico.Estado = "Rio de Janeiro";
            ucPessoaDadosBasico.Pais = "Brasil";
            ucPessoaDadosBasico.TelefoneCelular = "(21) 9999-9999";
            ucPessoaDadosBasico.TelefoneConvencional = "(21) 1234-5678";
            ucPessoaDadosBasico.Fax = "(21) 5432-9876";
            ucPessoaDadosBasico.Site = @"http://www.davidgomes.com";
            ucPessoaDadosBasico.Blog = "blogspost.com";

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


  

    }
}