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
        <td colspan="2">
            <asp:TextBox ID="txtNome" runat="server" MaxLength="80" Width="400px"></asp:TextBox>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            Sexo</td>
        <td>
            <asp:RadioButtonList ID="rdbSexo" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="Masculino">Masculino</asp:ListItem>
                <asp:ListItem Value="Feminino">Feminino</asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td>
            Data nascimento</td>
        <td>
            <asp:TextBox ID="txtDataNascimento" runat="server" MaxLength="10"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            CPF</td>
        <td>
            <asp:TextBox ID="txtCPF" runat="server" MaxLength="14"></asp:TextBox>
        </td>
        <td>
            RG</td>
        <td>
            <asp:TextBox ID="txtRG" runat="server" MaxLength="12"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Cert. Nascimento</td>
        <td>
            <asp:TextBox ID="txtCertidaoNascimento" runat="server" MaxLength="14"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Nacionalidade</td>
        <td>
            <asp:TextBox ID="txtNacionalidade" runat="server" MaxLength="20"></asp:TextBox>
        </td>
        <td>
            Naturalidade</td>
        <td>
            <asp:TextBox ID="txtNaturalidade" runat="server" MaxLength="20"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Foto</td>
        <td colspan="3">
            <asp:FileUpload ID="fileUploadFoto" runat="server" Width="215px" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="2">
            <strong>Dados Endereço</strong></td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            CEP</td>
        <td>
            <asp:TextBox ID="txtCEP" runat="server" MaxLength="20"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Logradouro</td>
        <td>
            <asp:TextBox ID="txtLogradouro" runat="server" MaxLength="50"></asp:TextBox>
        </td>
        <td>
            Número</td>
        <td>
            <asp:TextBox ID="txtNumero" runat="server" MaxLength="6"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Bairro</td>
        <td>
            <asp:TextBox ID="txtBairro" runat="server" MaxLength="25"></asp:TextBox>
        </td>
        <td>
            Cidade</td>
        <td>
            <asp:TextBox ID="txtCidade" runat="server" MaxLength="20"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Estado</td>
        <td>
            <asp:TextBox ID="txtEstado" runat="server" MaxLength="20"></asp:TextBox>
        </td>
        <td>
            País</td>
        <td>
            <asp:TextBox ID="txtPais" runat="server" MaxLength="20"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="2">
            <strong>Dados Contato</strong></td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Telefone Celular</td>
        <td>
            <asp:TextBox ID="txtTelefoneCelular" runat="server" MaxLength="13"></asp:TextBox>
        </td>
        <td>
            Telefone Convencional</td>
        <td>
            <asp:TextBox ID="txtTelefoneConvencional" runat="server" MaxLength="13"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Fax</td>
        <td>
            <asp:TextBox ID="txtFax" runat="server" MaxLength="13"></asp:TextBox>
        </td>
        <td>
            E-mail</td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server" MaxLength="13"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Site</td>
        <td>
            <asp:TextBox ID="txtSite" runat="server" MaxLength="50"></asp:TextBox>
        </td>
        <td>
            Blog</td>
        <td>
            <asp:TextBox ID="txtBlog" runat="server" MaxLength="50"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>

