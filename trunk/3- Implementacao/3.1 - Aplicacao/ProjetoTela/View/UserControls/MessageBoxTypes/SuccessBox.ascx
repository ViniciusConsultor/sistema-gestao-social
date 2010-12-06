<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SuccessBox.ascx.cs" Inherits="BRQ.SI.SCB.UI.Web.UserControls.MessageBoxTypes.SuccessBox" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!--Janela de Sucesso - Início-->
<asp:HiddenField ID="SuccessBoxHiddenField" runat="server"></asp:HiddenField>
<asp:Panel ID="SuccessBoxPanelMain" runat="server" Width="380px" CssClass="SuccessBox" Style="display: none">
    <asp:Panel ID="SuccessBoxPanelTitulo" runat="server" Height="20px" CssClass="TituloSuccessBox">
        <asp:Image ID="Image1" ImageUrl="~/Content/img/states.gif" runat="server" />&nbsp;
        <asp:Label ID="SuccessBoxLabelTitulo" runat="server" Font-Size="10px"></asp:Label>
    </asp:Panel>
    &nbsp;
    <br />
    <table border="0" cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td style="width: 3%; vertical-align: top;">
                &nbsp;&nbsp;&nbsp;<asp:Image ID="Image2" ImageUrl="~/Content/img/Success.png" runat="server" />&nbsp;&nbsp;
            </td>
            <td style="width: 99%">
                <asp:Label ID="SuccessBoxLabelMessage" runat="server" Font-Size="11px" Style="word-wrap: break-word"></asp:Label>
            </td>
        </tr>
    </table>
    <hr />
    &nbsp;
    <asp:ImageButton ID="SuccessBoxImageButtonOK" ToolTip="Ok" runat="server" ImageUrl="~/Content/img/btnOK.png"  CausesValidation="False" AlternateText="Ok"></asp:ImageButton>&nbsp;
    <br />
</asp:Panel>
<cc1:ModalPopupExtender ID="SuccessBoxPopUp" runat="server" PopupControlID="SuccessBoxPanelMain" BackgroundCssClass="modalBackground" TargetControlID="SuccessBoxHiddenField">
</cc1:ModalPopupExtender>
<!--Janela de informação - Fim-->