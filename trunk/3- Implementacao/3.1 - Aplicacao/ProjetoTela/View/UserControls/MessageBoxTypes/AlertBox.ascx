<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AlertBox.ascx.cs" Inherits="BRQ.SI.SCB.UI.Web.UserControls.MessageBoxTypes.AlertBox" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!--Janela de Alerta - Início-->
<cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
</cc1:ToolkitScriptManager>
<asp:HiddenField ID="AlertBoxHiddenField" runat="server"></asp:HiddenField>
<asp:Panel ID="AlertBoxPanelMain" runat="server" Width="380px" CssClass="AlertBox" Style="display: none">
    <asp:Panel ID="AlertBoxPanelTitulo" runat="server" Height="20px" CssClass="TituloAlertBox">
        <asp:Image ID="Image1" ImageUrl="~/Content/img/states.gif" runat="server" />&nbsp;
        <asp:Label ID="AlertBoxLabelTitulo" runat="server" Font-Size="10px"></asp:Label>
    </asp:Panel>
    
    &nbsp;
    <br />
    
    <table border="0" cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td style="width: 3%; vertical-align: top;">
                &nbsp;&nbsp;&nbsp;<asp:Image ID="Image2" ImageUrl="~/Content/img/Alert.png" runat="server" />&nbsp;&nbsp;
            </td>
            <td style="width: 99%">
                <asp:Label ID="AlertBoxLabelMessage" runat="server" Font-Size="11px" Style="word-wrap: break-word"></asp:Label>
            </td>
        </tr>
    </table>
    <hr />
    &nbsp;
    <asp:ImageButton ID="AlertBoxImageButtonOK" runat="server" ToolTip="Ok" ImageUrl="~/Content/img/btnOK.png" CausesValidation="False" AlternateText="Ok"></asp:ImageButton>&nbsp;
    <br />
</asp:Panel>

<cc1:ModalPopupExtender ID="AlertBoxPopUp" runat="server" PopupControlID="AlertBoxPanelMain"  BackgroundCssClass="modalBackground" TargetControlID="AlertBoxHiddenField">
</cc1:ModalPopupExtender>
<!--Janela de Alerta - Fim-->