using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BRQ.SI.SCB.UI.Web.UserControls.MessageBoxTypes
{
    public partial class QuestionBox : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public delegate void ClickButtonYes();

        public event ClickButtonYes OnClickButtonYes;

        public void ShowMessage(string message, string titulo)
        {
            QuestionBoxLabelTitulo.Text = titulo;
            QuestionBoxLabelMessage.Text = message;
            QuestionBoxPopUp.Show();
        }
        public void ShowMessage(string message)
        {
            QuestionBoxLabelTitulo.Text = "Questão"; //Resources.Resource.MessageBoxQuestionTitle;
            QuestionBoxLabelMessage.Text = message;
            QuestionBoxPopUp.Show();
        }
        protected void QuestionBoxImageButtonYes_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                if (OnClickButtonYes != null)
                {
                    this.OnClickButtonYes();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}