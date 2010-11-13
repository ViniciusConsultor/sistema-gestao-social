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
            set { }
        }

        #endregion

    }
}