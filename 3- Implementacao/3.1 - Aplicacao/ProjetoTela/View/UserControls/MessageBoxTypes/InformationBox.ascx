<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="InformationBox.ascx.cs" Inherits="BRQ.SI.SCB.UI.Web.UserControls.MessageBoxTypes.InformationBox" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!--Janela de informação - Início-->
<asp:HiddenField ID="InformationBoxHiddenField" runat="server"></asp:HiddenField>
<asp:Panel ID="InformationBoxPanelMain" runat="server" Width="380px" CssClass="InformationBox" Style="display: none">
    <asp:Panel ID="InformationBoxPanelTitulo" runat="server" Height="20px" CssClass="TituloInformationBox">
        <asp:Image ID="Image1" ImageUrl="~/Content/img/states.gif" runat="server" />&nbsp;
        <asp:Label ID="InformationBoxLabelTitulo" runat="server" Font-Size="10px"></asp:Label>
    </asp:Panel>
    &nbsp;
    <br />
    <table border="0" cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td style="width: 3%; vertical-align: top;">
                &nbsp;&nbsp;&nbsp;<asp:Image ID="Image2" ImageUrl="~/Content/img/information.png" runat="server" />&nbsp;&nbsp;
            </td>
            <td style="width: 99%">
                <asp:Label ID="InformationBoxLabelMessage" runat="server" Font-Size="11px" Style="word-wrap: break-word"></asp:Label>
            </td>
        </tr>
    </table>
    <hr />
    &nbsp;
    <asp:ImageButton ID="InformationBoxImageButtonOK" ToolTip="Ok" runat="server" ImageUrl="~/Content/img/btnOK.png" CausesValidation="False" AlternateText="Ok"></asp:ImageButton>&nbsp;
    <br />
</asp:Panel>
<cc1:ModalPopupExtender ID="InformationBoxPopUp" runat="server" PopupControlID="InformationBoxPanelMain" BackgroundCssClass="modalBackground" TargetControlID="InformationBoxHiddenField">
</cc1:ModalPopupExtender>
<!--Janela de informação - Fim-->