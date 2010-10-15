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
        {            margin-left: 80px;
        }
        .style10
        {
            text-align: left;
            }
        </style>

        <!-- Importa todos os script JavaScript-->
        <script type="text/javascript" src="../../Scripts/jquery-1.3.2.min.js"> </script>
        <script type="text/javascript" src="../../Scripts/jquery.maskedinput-1.2.1.js"> </script>
        <script type="text/javascript" src="../../Scripts/jquery.maskMoney.js"> </script>
        
        <!-- Comandos de JavaScript-->
        <script type="text/javascript">
       
            //Diz que quando a página for carregada, irá ser executado o
            //bloco de código contido entre os {};

            $(document).ready(function () {

                //Para usuar as máscaras abaixo coloque a descrição após o . na Propriedade CssClass de cada controle.
                //Exemplo: asp:TextBox ID="txtNome2" runat="server" Width="330px" MaxLength="50" CssClass="mask-real" 

                $('.mask-numero').mask('999999'); //número
                $('.mask-numero2').maskMoney({ precision: 6 }); //número

                $('.mask-data').mask('99/99/9999'); //data
                $('.mask-hora').mask('99:99'); //hora
                $('.mask-fone').mask('(99) 9999-9999'); //telefone
                $('.mask-rg').mask('99.999.999-9'); //RG
                $('.mask-ag').mask('9999-9'); //Agência
                $('.mask-ag').mask('9.999-9'); //Conta
                $(".mask-cpf").mask("999.999.999-99"); //cpf
                $(".mask-cnpj").mask("99.999.999/9999-99"); //cnpj
                $(".mask-cep").mask("99999-999"); //cep
                $(".mask-real-cifrao").maskMoney({ symbol: "R$", decimal: ",", thousands: ".", showSymbol: true }); //real com cifrão R$1.000,00
                $(".mask-real").maskMoney({ symbol: "R$", decimal: ",", thousands: ".", showSymbol: false }); //real sem cifrão 1.000,00
                $(".mask-precision").maskMoney({ precision: 3 }); //com 3 casas de precisão 1,000

                /* Default options are (but you can always change that):
                symbol:'US$',
                decimal:'.',
                precision:2,
                thousands:',',
                allowZero:false,
                showSymbol:false */

            });

        </script>
        
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
                <asp:TextBox ID="txtNome" runat="server" Width="330px" MaxLength="6" 
                    CssClass="MaskInteiro" ></asp:TextBox>
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
                <asp:TextBox ID="txtLogin" runat="server" Width="180px" MaxLength="10"></asp:TextBox>
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
                Confirmar
                Senha
            </td>
            <td class="style10" colspan="2">
                <asp:TextBox ID="txtSenhaConfirma" runat="server" MaxLength="10" TextMode="Password" 
                    Width="180px"></asp:TextBox>
                <asp:CompareValidator ID="compareSenha" runat="server" 
                    ControlToCompare="txtSenhaConfirma" ControlToValidate="txtSenha" 
                    
                    ErrorMessage="Preencha o campo e-mail e confirme o e-mail com o memso e-mail." 
                    style="font-size: small" ForeColor="Red">* Esta senha não está igual a senha acima</asp:CompareValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                E-mail
            </td>
            <td class="style8" colspan="2">
                <asp:TextBox ID="txtEmail" runat="server" MaxLength="6" Width="180px"></asp:TextBox>
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
                Perfil
            </td>
            <td align="right" class="style9" style="text-align: left">
                <asp:DropDownList ID="ddlPerfil" runat="server" Width="185px" Height="22px">
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
                        onclick="btnExcluir_Click" 
                        onclientclick="return confirm('Deseja realmente excluir?')" /> &nbsp;
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
