<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PessoaPatrocinador.ascx.cs"
    Inherits="SGS.View.Pessoa.PessoaPatrocinador" %>
<table width="100%">
    <tr>
        <td colspan="4">
            <strong>Dados Patrocinador</strong>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            Tipo
        </td>
        <td>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                RepeatDirection="Horizontal">
                <asp:ListItem>Física</asp:ListItem>
                <asp:ListItem>Jurídica</asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td>
            Data Saída
        </td>
        <td>
            <asp:TextBox ID="txtDataSaida" runat="server" MaxLength="10"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Patrocinador</td>
        <td colspan="3">
            <asp:TextBox ID="txtPatrocinador" runat="server" MaxLength="80" Width="400px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            CNPJ/CPF</td>
        <td>
            <asp:TextBox ID="txtCnpjCpf" runat="server" MaxLength="10"></asp:TextBox>
        </td>
        <td>
            Ramo Atividade</td>
        <td>
            <asp:TextBox ID="txtRamoAtividade" runat="server" MaxLength="10"></asp:TextBox>
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
            <strong>Dados Contribuição</strong></td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Valor</td>
        <td>
            <asp:TextBox ID="txtValorContribuicao" runat="server" MaxLength="10"></asp:TextBox>
        </td>
        <td>
            Periodicidade</td>
        <td>
            <asp:DropDownList ID="ddlPais" runat="server" Height="16px" Width="125px">
                <asp:ListItem>Selecione</asp:ListItem>
                <asp:ListItem>Não há</asp:ListItem>
                <asp:ListItem>Semanal</asp:ListItem>
                <asp:ListItem>Mensal</asp:ListItem>
                <asp:ListItem>Bimenstral</asp:ListItem>
                <asp:ListItem>Trimestral</asp:ListItem>
                <asp:ListItem>Semestral</asp:ListItem>
                <asp:ListItem>Anual</asp:ListItem>
            </asp:DropDownList>
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
            Nome Banco</td>
        <td>
            <asp:TextBox ID="txtNomeBanco" runat="server" MaxLength="25"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Agência</td>
        <td>
            <asp:TextBox ID="txtAgencia" runat="server" MaxLength="10"></asp:TextBox>
        </td>
        <td>
            Conta</td>
        <td>
            <asp:TextBox ID="txtConta" runat="server" MaxLength="9"></asp:TextBox>
        </td>
    </tr>
</table>
