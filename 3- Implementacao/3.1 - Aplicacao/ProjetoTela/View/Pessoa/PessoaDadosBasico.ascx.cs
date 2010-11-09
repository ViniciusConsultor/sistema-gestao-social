using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Entidades.DTO;

namespace SGS.View.Pessoa
{
    public partial class PessoaDadosBasico : System.Web.UI.UserControl
    {

        #region Eventos

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Esta propriedade preenche e retorno os dados do componente automaticamente.
        /// </summary>
        public PessoaDadosBasicoDTO PessoaDadosBasicoDTO
        {
            get 
            {
                PessoaDadosBasicoDTO obj = new PessoaDadosBasicoDTO();
                
                //Dados Pessoais
                obj.Nome = txtNome.Text;
                obj.Sexo = rdbSexo.SelectedValue;
                obj.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                obj.CPF = txtCPF.Text;
                obj.RG = txtRG.Text;
                obj.Nacionalidade = txtNacionalidade.Text;
                obj.Naturalidade = txtNaturalidade.Text;
                //Todo: Maycon foto;
                //fileUploadFoto.

                //Dados Endereço
                obj.Cep = txtCEP.Text;
                obj.Logradouro = txtLogradouro.Text;
                obj.Bairro = txtBairro.Text;
                obj.Cidade = txtCidade.Text;
                obj.Estado = txtEstado.Text;
                obj.Pais = txtPais.Text;

                //Dados Contato
                obj.TelCelular = txtTelefoneCelular.Text;
                obj.TelConvencional = txtTelefoneConvencional.Text;
                obj.Fax = txtFax.Text;
                obj.Site = txtSite.Text;
                obj.Blog = txtBlog.Text;

                return obj;
            }
            set 
            {
                //Dados Pessoais
                txtNome.Text = value.Nome;
                rdbSexo.SelectedValue = value.Sexo;
                txtDataNascimento.Text = value.DataNascimento.ToString("dd/MM/yyyy");
                txtCPF.Text = value.CPF;
                txtRG.Text = value.RG;
                txtNacionalidade.Text = value.Nacionalidade;
                txtNaturalidade.Text = value.Naturalidade;
                //Todo: Maycon foto;
                //fileUploadFoto.

                //Dados Endereço
                txtCEP.Text = value.Cep;
                txtLogradouro.Text = value.Logradouro;
                txtBairro.Text = value.Bairro;
                txtCidade.Text = value.Cidade;
                txtEstado.Text = value.Estado;
                txtPais.Text = value.Pais;

                //Dados Contato
                txtTelefoneCelular.Text = value.TelCelular;
                txtTelefoneConvencional.Text = value.TelConvencional;
                txtFax.Text = value.Fax;
                txtSite.Text = value.Site;
                txtBlog.Text = value.Blog;
            }
        }

        
        // Dados Pessoais 

        public string Nome
        {
            get { return txtNome.Text; }
            set { txtNome.Text = value; }
        }

        public string Sexo
        {
            get { return rdbSexo.SelectedValue; }
            set { rdbSexo.SelectedValue = value; }
        }

        public string DataNascimento
        {
            get { return txtDataNascimento.Text; }
            set { txtDataNascimento.Text = value; }
        }

        public string CPF
        {
            get { return txtCPF.Text; }
            set { txtCPF.Text = value; }
        }

        public string RG
        {
            get { return txtRG.Text; }
            set { txtRG.Text = value; }
        }
        
        public string CertidaoNascimento
        {
            get { return txtCertidaoNascimento.Text; }
            set { txtCertidaoNascimento.Text = value; }
        }

        public string Nacionalidade
        {
            get { return txtNacionalidade.Text; }
            set { txtNacionalidade.Text = value; }
        }

        public string Naturalidade
        {
            get { return txtNaturalidade.Text; }
            set { txtNaturalidade.Text = value; }
        }

        public string Foto
        {
            get { return fileUploadFoto.FileName; }
            set {  }
        }

        // Dados Endereço
        public string CEP
        {
            get { return txtCEP.Text; }
            set { txtCEP.Text = value; }
        }

        public string Logradouro
        {
            get { return txtLogradouro.Text; }
            set { txtLogradouro.Text = value; }
        }

        public int? Numero
        {
            get 
            { 
                if (txtNumero.Text == "") return null; 
                else return Convert.ToInt32(txtNumero.Text); 
            }
            set
            {
                if (value.HasValue) txtNumero.Text = value.ToString();
                else txtNumero.Text = "";
            }
        }

        public string Bairro
        {
            get { return txtBairro.Text; }
            set { txtBairro.Text = value; }
        }

        public string Cidade
        {
            get { return txtCidade.Text; }
            set { txtCidade.Text = value; }
        }

        public string Estado
        {
            get { return txtEstado.Text; }
            set { txtEstado.Text = value; }
        }

        public string Pais
        {
            get { return txtPais.Text; }
            set { txtPais.Text = value; }
        }

        //Dados Contato
        
        public string TelefoneCelular
        {
            get { return txtTelefoneCelular.Text; }
            set { txtTelefoneCelular.Text = value; }
        }

        public string TelefoneConvencional
        {
            get { return txtTelefoneConvencional.Text; }
            set { txtTelefoneConvencional.Text = value; }
        }

        public string Fax
        {
            get { return txtFax.Text; }
            set { txtFax.Text = value; }
        }

        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }

        public string Site
        {
            get { return txtSite.Text; }
            set { txtSite.Text = value; }
        }

        public string Blog
        {
            get { return txtBlog.Text; }
            set { txtBlog.Text = value; }
        }

        #endregion

    }
}