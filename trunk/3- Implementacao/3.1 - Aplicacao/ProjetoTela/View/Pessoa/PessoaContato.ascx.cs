using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGS.Entidades.DTO;

namespace SGS.View.Pessoa
{
    public partial class PessoaContato : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        #region Propriedade

        /// <summary>
        /// Esta propriedade preenche e retorno os dados do componente automaticamente.
        /// </summary>
        public PessoaContatoDTO PessoaDadosBasicoDTO
        {
            get
            {
                PessoaContatoDTO obj = new PessoaContatoDTO();

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