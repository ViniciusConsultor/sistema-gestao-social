using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using Resources;

namespace BRQ.SI.SCB.UI.Web.UserControls.MessageBoxTypes
{
    public partial class AlertBox : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void ShowMessage(string message, string titulo)
        {
            AlertBoxLabelTitulo.Text = titulo;
            AlertBoxLabelMessage.Text = message;
            AlertBoxPopUp.Show();
        }
        public void ShowMessage(string message)
        {
            AlertBoxLabelTitulo.Text = "SGS"; //Resources.Resource.MessageBoxAlertTitle;
            AlertBoxLabelMessage.Text = message;
            AlertBoxPopUp.Show();
        }
    }
}