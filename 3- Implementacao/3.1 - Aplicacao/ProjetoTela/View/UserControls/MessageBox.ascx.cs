using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BRQ.SI.SCB.UI.Web.UserControls
{
    #region Enum MessageBoxType
    public enum MessageBoxType
    {
        Error,
        Alert,
        Question,
        Information,
        Success
    }
    #endregion

    public partial class MessageBox : System.Web.UI.UserControl
    {

        public delegate void ClickButtonYes();

        public event ClickButtonYes OnClickButtonYes;


        protected void Page_Load(object sender, EventArgs e)
        {
            this.QuestionBox1.OnClickButtonYes += new BRQ.SI.SCB.UI.Web.UserControls.MessageBoxTypes.QuestionBox.ClickButtonYes(QuestionBox_OnClickButtonYes);
        }


        void QuestionBox_OnClickButtonYes()
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

        public void ShowMessage(string message, string titulo, MessageBoxType TypeMessage)
        {
            switch (TypeMessage)
            {
                case MessageBoxType.Error:
                    this.ErrorBox1.ShowMessage(message, titulo);
                    break;
                case MessageBoxType.Alert:
                    this.AlertBox1.ShowMessage(message, titulo);
                    break;
                case MessageBoxType.Question:
                    this.QuestionBox1.ShowMessage(message, titulo);
                    break;
                case MessageBoxType.Information:
                    this.InformationBox1.ShowMessage(message, titulo);
                    break;
                case MessageBoxType.Success:
                    this.SuccessBox1.ShowMessage(message, titulo);
                    break;
                default:
                    throw new Exception("Invalid MessageBoxType!");
                    break;
            }

        }

        public void ShowMessage(string message, MessageBoxType TypeMessage)
        {
            switch (TypeMessage)
            {
                case MessageBoxType.Error:
                    this.ErrorBox1.ShowMessage(message);
                    break;
                case MessageBoxType.Alert:
                    this.AlertBox1.ShowMessage(message);
                    break;
                case MessageBoxType.Question:
                    this.QuestionBox1.ShowMessage(message);
                    break;
                case MessageBoxType.Information:
                    this.InformationBox1.ShowMessage(message);
                    break;
                case MessageBoxType.Success:
                    this.SuccessBox1.ShowMessage(message);
                    break;
                default:
                    throw new Exception("Invalid MessageBoxType!");
                    break;
            }
        }



    }
}