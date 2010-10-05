<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjetoTela.Telas.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style6
    {
        width: 100%;
    }
    .style7
    {
        width: 346px;
    }
    .style8
    {
        width: 346px;
        font-size: small;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<br />
<br />
<table class="style6">
    <tr>
        <td class="style8" style="text-align: right">
            Login</td>
        <td>
            <asp:TextBox ID="txtNome" runat="server" Width="150px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validatorNome" runat="server" 
                ControlToValidate="txtNome" ErrorMessage="Preencha o campo Login" 
                ForeColor="#CC0000" style="text-align: center">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style8" style="text-align: right">
            Senha</td>
        <td>
            <asp:TextBox ID="txtSenha" runat="server" Width="151px" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtSenha" ErrorMessage="Preencha o campo Senha" 
                ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style7" style="text-align: right">
            &nbsp;</td>
        <td>
            <asp:Button ID="btnLogar" runat="server" BackColor="#A6B4C6" Text="Logar" 
                Width="76px" onclick="Page_Load" />
            <asp:Button ID="btnLimpar" runat="server" BackColor="#A6B4C6" Text="Limpar" 
                Width="75px" CausesValidation="False" onclick="btnLimpar_Click" />
        </td>
    </tr>
</table>
<br />
<br />
<table align="center">
    <tr>
        <td>
            <asp:ValidationSummary ID="sumarioErro" runat="server" BorderColor="#3366FF" 
            BorderStyle="Double" Font-Names="verdana" Font-Size="Small" Width="250px" 
                ForeColor="#CC0000" HeaderText="Validação:"  />    
        </td>
    </tr>
    
</table>
<br />
<br />
<br />
</asp:Content>
