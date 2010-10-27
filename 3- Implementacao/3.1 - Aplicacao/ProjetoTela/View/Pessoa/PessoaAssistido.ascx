<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PessoaDadosBasico.ascx.cs" Inherits="SGS.View.Pessoa.PessoaDadosBasico" %>
<table width="100%">
    <tr>
        <td colspan="2">
            <strong>Dados Pessoais</strong></td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Nome</td>
        <td colspan="2" style="margin-left: 40px">
            <asp:TextBox ID="txtNome" runat="server" MaxLength="80" Width="400px"></asp:TextBox>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            Data Entrada</td>
        <td>
            <asp:TextBox ID="txtDataEntrada" runat="server" MaxLength="10"></asp:TextBox>
        </td>
        <td>
            Data Saída</td>
        <td>
            <asp:TextBox ID="txtDataSaida" runat="server" MaxLength="10"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Estado Saúde</td>
        <td>
            <asp:DropDownList ID="ddlEstadoSaude" runat="server" Width="130px">
            </asp:DropDownList>
        </td>
        <td>
            Peso</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtPeso" runat="server" MaxLength="6"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Cor</td>
        <td>
            <asp:TextBox ID="txtCor" runat="server" MaxLength="20"></asp:TextBox>
        </td>
        <td>
            Dormitorio</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
</table>

