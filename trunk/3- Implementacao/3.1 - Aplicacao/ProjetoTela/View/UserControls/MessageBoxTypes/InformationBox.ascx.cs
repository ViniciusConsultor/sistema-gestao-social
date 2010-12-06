using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BRQ.SI.SCB.UI.Web.UserControls.MessageBoxTypes
{
    public partial class InformationBox : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void ShowMessage(string message, string titulo)
        {
            InformationBoxLabelTitulo.Text = titulo;
            InformationBoxLabelMessage.Text = message;
            InformationBoxPopUp.Show();
        }
        public void ShowMessage(string message)
        {
            InformationBoxLabelTitulo.Text = "Informação"; // Resources.Resource.MessageBoxInformationTitle;
            InformationBoxLabelMessage.Text = message;
            InformationBoxPopUp.Show();
        }
    }
}