<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ErrorBox.ascx.cs" Inherits="BRQ.SI.SCB.UI.Web.UserControls.MessageBoxTypes.ErrorBox" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!--Janela de Erro - Início-->
<asp:HiddenField ID="ErrorBoxHiddenField" runat="server"></asp:HiddenField>
<asp:Panel ID="ErrorBoxPanelMain" runat="server" Width="480px" CssClass="ErrorBox"  Style="display: none">
    
    <asp:Panel ID="ErrorBoxPanelTitulo" runat="server" Height="20px" CssClass="TituloErrorBox">
        <asp:Image ID="Image1" ImageUrl="~/Content/img/states.gif" runat="server" />&nbsp;
        <asp:Label ID="ErrorBoxLabelTitulo" runat="server" Font-Size="10px"></asp:Label>
    </asp:Panel>
    &nbsp;
    <br />
    <table border="0" cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td style="width: 3%; vertical-align: top;">
                &nbsp;&nbsp;&nbsp;<asp:Image ID="Image2" ImageUrl="~/Content/img/Error.png" runat="server" />&nbsp;&nbsp;
            </td>
            <td style="width: 99%">
                <asp:Label ID="ErrorBoxLabelMessage" runat="server" Font-Size="11px" Style="word-wrap: break-word"></asp:Label>
            </td>
        </tr>
    </table>
    <hr />
    &nbsp;
    <asp:ImageButton ID="ErrorBoxImageButtonOK" ToolTip="Ok" runat="server" ImageUrl="~/Content/img/btnSIM_Vermelho.gif" CausesValidation="False" AlternateText="Ok"></asp:ImageButton>&nbsp;
    <br />
</asp:Panel>
<cc1:ModalPopupExtender ID="ErrorBoxPopUp" runat="server" PopupControlID="ErrorBoxPanelMain" BackgroundCssClass="modalBackground" TargetControlID="ErrorBoxHiddenField">
</cc1:ModalPopupExtender>
<!--Janela de Erro - Fim-->