<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PessoaFuncionario.ascx.cs"
    Inherits="SGS.View.Pessoa.PessoaFuncionario" %>
<%@ Register src="PessoaDadosBancarios.ascx" tagname="PessoaDadosBancarios" tagprefix="uc1" %>
<table width="100%">
    <tr>
        <td colspan="4">
            <strong>Dados Funcionário</strong>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            &nbsp;
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <strong>Dados Pessoais</strong>
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
            Cargo
        </td>
        <td>
            <asp:TextBox ID="txtCargo" runat="server" MaxLength="25"></asp:TextBox>
        </td>
        <td>
            Salário</td>
        <td>
            <asp:TextBox ID="txtSalario" runat="server" MaxLength="12"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Data Contratação
        </td>
        <td>
            <asp:TextBox ID="txtDataContratacao" runat="server" MaxLength="10"></asp:TextBox>
        </td>
        <td>
            N° CTPS</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtNumeroCTPS" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            PIS</td>
        <td>
            <asp:TextBox ID="txtPIS" runat="server"></asp:TextBox>
        </td>
        <td>
            Título Eleitor</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtTituloEleitor" runat="server" MaxLength="12"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Grau Escolaridade</td>
        <td>
            <asp:DropDownList ID="ddlGrauEscolaridade" runat="server" Width="130px">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>SelecioneNão há</asp:ListItem>
                <asp:ListItem>Fundamental</asp:ListItem>
                <asp:ListItem>Médio</asp:ListItem>
                <asp:ListItem>Superior Incompleto</asp:ListItem>
                <asp:ListItem>Superior Completo</asp:ListItem>
                <asp:ListItem>Pós-Graduação</asp:ListItem>
                <asp:ListItem>Mestrado</asp:ListItem>
                <asp:ListItem>Doutorado</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            Curso Formação</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtCursoFormacao" runat="server" MaxLength="40"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Estado Civil</td>
        <td>
            <asp:DropDownList ID="ddlEstadoCivil" runat="server" Width="130px">
                <asp:ListItem>Selecione</asp:ListItem>
                <asp:ListItem>SelecioneFundamentalSolteiro</asp:ListItem>
                <asp:ListItem>Casado</asp:ListItem>
                <asp:ListItem>Viúvo</asp:ListItem>
                <asp:ListItem>Separado</asp:ListItem>
                <asp:ListItem>Divorciado</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            Qtd. Filhos</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtQtdFilhos" runat="server" MaxLength="2"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Certificado Reservista</td>
        <td>
            <asp:TextBox ID="txtCertificadoReservista" runat="server"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Experiência Profissional</td>
        <td colspan="3">
            <asp:TextBox ID="txtExperienciaProfissional" runat="server" MaxLength="500" Height="100px" 
                TextMode="MultiLine" Width="430px"></asp:TextBox>
        </td>
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
<uc1:PessoaDadosBancarios ID="PessoaDadosBancarios1" runat="server" />

