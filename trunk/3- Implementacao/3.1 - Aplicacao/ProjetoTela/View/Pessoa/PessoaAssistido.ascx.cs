using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGS.View.Pessoa
{
    public partial class PessoaAssistido : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Propriedades

        #region Dados Assistido

        public string StatusAssistido
        {
            get { return ddlStatusAssistido.SelectedValue; }
            set { ddlStatusAssistido.SelectedValue = value; }
        }

        public string DataEntrada
        {
            get { return txtDataEntrada.Text;}
            set { txtDataEntrada.Text = value; }
        }

        public string DataSaida
        {
            get { return txtDataSaida.Text; }
            set { txtDataSaida.Text = value; }
        }

        public string EstadoSaude
        {
            get { return ddlEstadoSaude.SelectedValue; }
            set { ddlEstadoSaude.SelectedValue = value; }
        }

        public string Peso
        {
            get { return txtPeso.Text; }
            set { txtPeso.Text = value; }
        }

        public string Cor
        {
            get { return ddlCor.SelectedValue; }
            set { ddlCor.SelectedValue = value; }
        }

        public string Altura
        {
            get { return txtAltura.Text; }
            set { txtAltura.Text = value; }
        }

        public string Dormitorio
        {
            get { return txtDormitorio.Text; }
            set { txtDormitorio.Text = value; }
        }

        public string TamanhoCamisa
        {
            get { return ddlTamanhoCamisa.SelectedValue; }
            set { ddlTamanhoCamisa.SelectedValue = value; }
        }

        public string TamanhoCalca
        {
            get { return ddlTamanhoCalca.SelectedValue; }
            set { ddlTamanhoCalca.SelectedValue = value; }
        }

        public string TamanhoCalcado
        {
            get { return txtTamanhoCalcado.Text; }
            set { txtTamanhoCalcado.Text = value; }
        }

        public string Deficiente
        {
            get { return rblDeficiente.SelectedValue; }
            set { rblDeficiente.SelectedValue = value; }
        }

        public string Hobby
        {
            get { return txtHobby.Text; }
            set { txtHobby.Text = value; }
        }

        public string HistoricoVida
        {
            get { return txtHistoricoVida.Text; }
            set { txtHistoricoVida.Text = value; }
        }

        #endregion

        #region Dados Família

        public string Pai
        {
            get { return txtPai.Text; }
            set { txtPai.Text = value; }
        }

        public string Mae
        {
            get { return txtMae.Text; }
            set { txtMae.Text = value; }
        }

        public string PaiVivo
        {
            get { return rblPaiVivo.SelectedValue; }
            set { rblPaiVivo.SelectedValue = value; }
        }

        public string MaeViva
        {
            get { return rblMaeViva.SelectedValue; }
            set { rblMaeViva.SelectedValue = value; }
        }

        public string CPFPai
        {
            get { return txtCPFPai.Text; }
            set { txtCPFPai.Text = value; }
        }

        public string CPFMae
        {
            get { return txtCPFMae.Text; }
            set { txtCPFMae.Text = value; }
        }

        public string RGPai
        {
            get { return txtRGPai.Text; }
            set { txtRGPai.Text = value; }
        }

        public string RGMae
        {
            get { return txtRGMae.Text; }
            set { txtRGMae.Text = value; }
        }

        public string TelPai
        {
            get { return txtTelPai.Text; }
            set { txtTelPai.Text = value; }
        }

        public string TelMae
        {
            get { return txtTelMae.Text; }
            set { txtTelMae.Text = value; }
        }

        public int? QtdIrmaos
        {
            get 
            {
                if (txtQtdIrmaos.Text != "")
                    return Convert.ToInt32(txtQtdIrmaos.Text);
                else
                    return null;
            }
            set 
            {
                if (value.HasValue)
                    txtQtdIrmaos.Text = value.Value.ToString();
                else
                    txtQtdIrmaos.Text = "";
            }
        }
        
        #endregion

        #region Dados do Responsável

        public string Responsavel
        {
            get { return txtResponsavel.Text; }
            set { txtResponsavel.Text = value; }
        }

        public string CPFResponsavel
        {
            get { return txtCPFResponsavel.Text; }
            set { txtCPFResponsavel.Text = value; }
        }

        public string TelResponsavel
        {
            get { return txtTelResponsavel.Text; }
            set { txtTelResponsavel.Text = value; }
        }

        public string EmailResponsavel
        {
            get { return txtEmailResponsavel.Text; }
            set { txtEmailResponsavel.Text = value; }
        }

        public string CEPResponsavel
        {
            get { return txtCEPResponsavel.Text; }
            set { txtCEPResponsavel.Text = value; }
        }

        public string LogradouroResponsavel
        {
            get { return txtLogradouroResponsavel.Text; }
            set { txtLogradouroResponsavel.Text = value; }
        }

        public string NumeroResponsavel
        {
            get { return txtNumeroResponsavel.Text; }
            set { txtNumeroResponsavel.Text = value; }
        }

        public string BairroResponsavel
        {
            get { return txtBairroResponsavel.Text; }
            set { txtBairroResponsavel.Text = value; }
        }

        public string CidadeResponsavel
        {
            get { return txtCidadeResponsavel.Text; }
            set { txtCidadeResponsavel.Text = value; }
        }

        public string EstadoResponsavel
        {
            get { return ddlEstadoResponsavel.SelectedValue; }
            set { ddlEstadoResponsavel.SelectedValue = value; }
        }

        public string PaisResponsavel
        {
            get { return ddlPaisResponsavel.SelectedValue; }
            set { ddlPaisResponsavel.SelectedValue = value; }
        }

        #endregion

        #endregion

    }
}