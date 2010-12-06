using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BRQ.SI.SCB.UI.Web.UserControls.MessageBoxTypes
{
    public partial class ErrorBox : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void ShowMessage(string message, string titulo)
        {
            ErrorBoxLabelTitulo.Text = titulo;
            ErrorBoxLabelMessage.Text = message;
            ErrorBoxPopUp.Show();
        }
        public void ShowMessage(string message)
        {
            ErrorBoxLabelTitulo.Text = "Erro"; //Resources.Resource.MessageBoxErrorTitle;
            ErrorBoxLabelMessage.Text = message;
            ErrorBoxPopUp.Show();
        }
    }
}