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

        #endregion

       

    }
}