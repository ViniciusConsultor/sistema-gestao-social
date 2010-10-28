<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PessoaDadosBancarios.ascx.cs"
    Inherits="SGS.View.Pessoa.PessoaDadosBancarios" %>
<table width="100%">
    <tr>
        <td>
            <strong>Dados Bancários</strong>
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td style="margin-left: 40px">
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            Código Banco
        </td>
        <td>
            <asp:TextBox ID="txtCodigoBanco" runat="server" MaxLength="25"></asp:TextBox>
        </td>
        <td>
            Nome Banco
        </td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtNomeBanco" runat="server" MaxLength="25"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Agência
        </td>
        <td>
            <asp:TextBox ID="txtAgencia" runat="server" MaxLength="10"></asp:TextBox>
        </td>
        <td>
            Conta
        </td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtConta" runat="server" MaxLength="9"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td style="margin-left: 40px">
            &nbsp;
        </td>
    </tr>
</table>
