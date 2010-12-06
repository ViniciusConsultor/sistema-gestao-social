<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QuestionBox.ascx.cs" Inherits="BRQ.SI.SCB.UI.Web.UserControls.MessageBoxTypes.QuestionBox" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>


<!--Janela de Questão - Início-->
<asp:HiddenField ID="QuestionBoxHiddenField" runat="server"></asp:HiddenField>
<asp:Panel ID="QuestionBoxPanelMain" runat="server" Width="380px" CssClass="QuestionBox"
    Style="display: none">
    <asp:Panel ID="QuestionBoxPanelTitulo" runat="server" Height="20px" CssClass="TituloQuestionBox">
        <asp:Image ID="Image1" ImageUrl="~/Content/img/states.gif" runat="server" />&nbsp;
        <asp:Label ID="QuestionBoxLabelTitulo" runat="server" Font-Size="10px"></asp:Label>
    </asp:Panel>
    &nbsp;
    <br />
    <table border="0" cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td style="width: 3%; vertical-align: top;">
                &nbsp;&nbsp;&nbsp;<asp:Image ID="Image2" ImageUrl="~/Content/img/Question.png" runat="server" />&nbsp;&nbsp;
            </td>
            <td style="width: 99%">
                <asp:Label ID="QuestionBoxLabelMessage" runat="server" Font-Size="11px" Style="word-wrap: break-word"></asp:Label>
            </td>
        </tr>
    </table>
    <hr />
    &nbsp;
    <asp:ImageButton ID="QuestionBoxImageButtonSIM" runat="server" ToolTip="Sim"
        ImageUrl="~/Content/img/btnSIM.png" meta:Resourcekey="MessageBoxQuestionButtonYesImage"
        CausesValidation="False" AlternateText="Sim" OnClick="QuestionBoxImageButtonYes_Click">
    </asp:ImageButton>&nbsp;&nbsp;
    <asp:ImageButton ID="QuestionBoxImageButtonNAO" runat="server" ToolTip="Não"
        ImageUrl="~/Content/img/btnNAO.png" meta:Resourcekey="MessageBoxQuestionButtonNoImage"
        CausesValidation="False" AlternateText="Não">
    </asp:ImageButton>
    <br />
</asp:Panel>
<cc1:ModalPopupExtender ID="QuestionBoxPopUp" runat="server" PopupControlID="QuestionBoxPanelMain"
    BackgroundCssClass="modalBackground" TargetControlID="QuestionBoxHiddenField">
</cc1:ModalPopupExtender>
<!--Janela de Questão - Fim-->
