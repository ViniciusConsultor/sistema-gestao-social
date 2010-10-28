<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PessoaVoluntario.ascx.cs"
    Inherits="SGS.View.Pessoa.PessoaVoluntario" %>
<%@ Register src="PessoaDadosBancarios.ascx" tagname="PessoaDadosBancarios" tagprefix="uc1" %>
<table width="100%">
    <tr>
        <td colspan="4">
            <strong>Dados Voluntário</strong>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            Grau Escolarida 
        </td>
        <td>
            <asp:DropDownList ID="ddlGrauEscolaridade" runat="server" Width="130px">
                <asp:ListItem>Selecione</asp:ListItem>
                <asp:ListItem>SelecioneFundamentalNão há</asp:ListItem>
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
            Formação Profissional</td>
        <td>
            <asp:TextBox ID="txtFormacao" runat="server" MaxLength="10"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Profissão
        </td>
        <td>
            <asp:TextBox ID="txtProfissao" runat="server" MaxLength="40"></asp:TextBox>
        </td>
        <td>
            N° CTPS
        </td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtNumeroCTPS" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Tempo Disponível</td>
        <td colspan="3">
            <asp:TextBox ID="txtTempoDisponivel" runat="server" MaxLength="50" 
                Width="430px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Especialidades</td>
        <td colspan="3">
            <asp:TextBox ID="txtEspecialidades" runat="server" MaxLength="200" Height="100px" 
                TextMode="MultiLine" Width="430px"></asp:TextBox>
        </td>
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
            Motivo Voluntariado</td>
        <td>
            <asp:TextBox ID="txtMotivoVoluntariado" runat="server" MaxLength="500" Height="100px" 
                TextMode="MultiLine" Width="430px"></asp:TextBox>
        </td>
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
<uc1:PessoaDadosBancarios ID="PessoaDadosBancarios1" runat="server" />

