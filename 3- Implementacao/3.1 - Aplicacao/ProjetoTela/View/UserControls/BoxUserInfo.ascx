<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BoxUserInfo.ascx.cs" Inherits="BRQ.SI.SCB.UI.Web.UserControls.BoxUserInfo" %>
<table cellspacing="0" cellpadding="0" class="hdlt" id="Table1" border="0">
    <tr valign="middle" style="height: 25px;">
        <td rowspan="3" style="width: 3px;"></td>
        <td>
            <table cellspacing="0" cellpadding="0" style="width: 100%; table-layout:fixed;" class="ip">
                <tr>
                    <td style="width: 140px;">
                        <div runat="server" id="dvUserInfo" title="" style="white-space:nowrap; width:150px; overflow:hidden; text-overflow:ellipsis;">
                            <asp:Image ID="Image1" ImageAlign="AbsMiddle" ImageUrl="~/App_Themes/Default/Images/ulstart.gif" width="12" height="16" runat="server" />
                            <asp:Label runat="Server" ID="lblUserInfo"></asp:Label>
                        </div>
                    </td>
                    <td align="right">
                        (<asp:LinkButton ID="lnkLogout" runat="server" ToolTip="<%$ Resources:Resource, LabelLogout %>" 
                            Text="<%$ Resources:Resource, LabelLogout %>" meta:Resourcekey="lnkLogout" 
                            onclick="lnkLogout_Click"></asp:LinkButton>)
                    </td>
                </tr>
            </table>
        </td>
        <td rowspan="3" style="width: 3px;"></td>				
    </tr>
   
</table>