<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true"
    CodeBehind="ManterLogin.aspx.cs" Inherits="SGS.View.LoginUI.ManterLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style6
        {
            width: 100%;
        }
        .style7
        {
            width: 259px;
            text-align: right;
            font-size: small;
        }
        .style8
        {
            text-align: left;
        }
        .style9
        {            margin-left: 40px;
        }
        .style10
        {
            text-align: left;
            width: 269px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <span class="style4"><strong> 
        <asp:Label ID="lblTitulo" runat="server" Text=""></asp:Label>
    </strong> &nbsp;</span><br />
    <span class="style4" style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; <asp:Label ID="lblDescricao" runat="server" Text=""></asp:Label> 
        
        <br /><br />
    </span>

    <table class="style6">
        <tr>
            <td class="style7">
                Nome
            </td>
            <td class="style9" colspan="2">
                <asp:TextBox ID="txtNome" runat="server" Width="330px" MaxLength="50"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="validatorNome" runat="server" 
                    ErrorMessage="Preencha o Nome" ControlToValidate="txtNome" SetFocusOnError="True" 
                    Width="25px" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style7">
                Login
            </td>
            <td class="style9">
                <asp:TextBox ID="txtLogin" runat="server" Width="180px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="validatorLogin" runat="server" 
                    ErrorMessage="Preencha o Login" ControlToValidate="txtLogin" 
                    SetFocusOnError="True" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style7">
                Senha
            </td>
            <td class="style10">
                <asp:TextBox ID="txtSenha" runat="server" MaxLength="10" TextMode="Password" 
                    Width="180px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="validatorSenha" runat="server" 
                    ErrorMessage="Preencha a Senha" ControlToValidate="txtSenha" 
                    SetFocusOnError="True" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style7">
                E-mail
            </td>
            <td class="style8" colspan="2">
                <asp:TextBox ID="txtEmail" runat="server" MaxLength="50" Width="180px"></asp:TextBox>
                &nbsp;&nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style7">
                Confirme o E-mail</td>
            <td class="style8" colspan="2">
                <asp:TextBox ID="txtEmailConfirma" runat="server" MaxLength="50" Width="180px"></asp:TextBox>
                &nbsp;<asp:CompareValidator ID="compareEmail" runat="server" 
                    ControlToCompare="txtEmailConfirma" ControlToValidate="txtEmail" 
                    ErrorMessage="Preencha o campo e-mail e confirme o e-mail com o memso e-mail." 
                    SetFocusOnError="True" style="font-size: small" ForeColor="Red">* Este e-mail não está igual ao e-mail acima</asp:CompareValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                Pessoa no sistema</td>
            <td align="right" class="style9" style="text-align: left">
                <asp:DropDownList ID="ddlPessoaSistema" runat="server" Width="185px" 
                    Height="18px">
                    <asp:ListItem Text="Selecione" Value="Selecione"></asp:ListItem>
                    <asp:ListItem Text="Gestor" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Funcionário" Value="1"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                Perfil
            </td>
            <td align="right" class="style9" style="text-align: left">
                <asp:DropDownList ID="ddlPerfil" runat="server" Width="185px" Height="18px">
                    <asp:ListItem Text="Selecione" Value="Selecione"></asp:ListItem>
                    <asp:ListItem Text="Gestor" Value="Gestor"></asp:ListItem>
                    <asp:ListItem Text="Funcionário" Value="Funcionario"></asp:ListItem>
                </asp:DropDownList>
                &nbsp;<asp:RequiredFieldValidator ID="validatorPerfil" runat="server" 
                    ErrorMessage="Escolha o Perfil" ControlToValidate="ddlPerfil" 
                    InitialValue="Selecione" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>

    <br />
    <table align="center">
        <tr>
            <td>
                <asp:ValidationSummary ID="sumarioErro" runat="server" BorderColor="#3366FF" 
                    BorderStyle="Double" Font-Names="verdana" Font-Size="Small" ForeColor="#CC0000" 
                    HeaderText="Validação:" Width="350px" />
            </td>
        </tr>
    </table>

    <br />

    <table width="100%">
            <tr align="center">
                <td> 
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Width="110px" 
                        onclick="btnSalvar_Click" /> &nbsp; 
                    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" Width="110px" 
                        onclick="btnExcluir_Click" /> &nbsp;
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="110px" 
                        CausesValidation="False" onclick="btnCancelar_Click" />
                </td>
            </tr>
            <tr align="center">
                <td> 
                    &nbsp;</td>
            </tr>
        </table>

</asp:Content>
