<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PessoaContato.ascx.cs"
    Inherits="SGS.View.Pessoa.PessoaContato" %>
<table width="100%" style="font-size: small; font-family: Verdana;">
    <tr>
        <td colspan="2">
            <strong>Dados Endereço</strong>
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            CEP
        </td>
        <td>
            <asp:TextBox ID="txtCEP" runat="server" MaxLength="20"></asp:TextBox>
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            Logradouro
        </td>
        <td>
            <asp:TextBox ID="txtLogradouro" runat="server" MaxLength="50"></asp:TextBox>
        </td>
        <td>
            Número
        </td>
        <td>
            <asp:TextBox ID="txtNumero" runat="server" MaxLength="6"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Bairro
        </td>
        <td>
            <asp:TextBox ID="txtBairro" runat="server" MaxLength="25"></asp:TextBox>
        </td>
        <td>
            Cidade
        </td>
        <td>
            <asp:TextBox ID="txtCidade" runat="server" MaxLength="20"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Estado
        </td>
        <td>
            <asp:TextBox ID="txtEstado" runat="server" MaxLength="20"></asp:TextBox>
        </td>
        <td>
            País
        </td>
        <td>
            <asp:TextBox ID="txtPais" runat="server" MaxLength="20"></asp:TextBox>
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
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <strong>Dados Contato</strong>
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            Telefone Celular
        </td>
        <td>
            <asp:TextBox ID="txtTelefoneCelular" runat="server" MaxLength="14"></asp:TextBox>
        </td>
        <td>
            Telefone Convencional
        </td>
        <td>
            <asp:TextBox ID="txtTelefoneConvencional" runat="server" MaxLength="14"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Fax
        </td>
        <td>
            <asp:TextBox ID="txtFax" runat="server" MaxLength="14"></asp:TextBox>
        </td>
        <td>
            E-mail
        </td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server" MaxLength="50"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Site
        </td>
        <td>
            <asp:TextBox ID="txtSite" runat="server" MaxLength="50"></asp:TextBox>
        </td>
        <td>
            Blog
        </td>
        <td>
            <asp:TextBox ID="txtBlog" runat="server" MaxLength="50"></asp:TextBox>
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
        <td>
            &nbsp;
        </td>
    </tr>
</table>
