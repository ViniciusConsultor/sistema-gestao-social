using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BRQ.SI.SCB.UI.Web.UserControls.MessageBoxTypes
{
    public partial class SuccessBox : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void ShowMessage(string message, string titulo)
        {
            SuccessBoxLabelTitulo.Text = titulo;
            SuccessBoxLabelMessage.Text = message;
            SuccessBoxPopUp.Show();
        }
        public void ShowMessage(string message)
        {
            SuccessBoxLabelTitulo.Text = "Sucesso";//Resources.Resource.MessageBoxSuccessTitle;
            SuccessBoxLabelMessage.Text = message;
            SuccessBoxPopUp.Show();
        }
    }
}