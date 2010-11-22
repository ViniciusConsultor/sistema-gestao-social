<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="RelAssistidos.aspx.cs" Inherits="SGS.View.Relatorio.RelAssistidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .style6
        {
            height: 20px;
        }
        .style11
        {
            height: 20px;
            text-decoration: underline;
        }
        .style17
        {
            font-family: Arial, sans-serif;
            font-size: small;
        }
        .style18
        {
            height: 20px;
            width: 169px;
        }
        .style19
        {
            text-align: right;
            }
        .style20
        {
            height: 20px;
            width: 136px;
        }
        .style22
        {
            font-family: Arial, sans-serif;
            font-size: small;
            width: 223px;
        }
        .style26
        {
            text-align: right;
            width: 136px;
        }
        .style27
        {
            width: 223px;
            text-align: left;
        }
        .style28
        {
            text-align: right;
            width: 169px;
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
        <asp:Label ID="lblTitulo" runat="server" Text="Relatório Assistido" CssClass="Titulo"></asp:Label>
    </strong> &nbsp;</span><br />
    
    <span class="style4" style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp; 
    <asp:Label ID="lblDescricao" runat="server" 
        Text="   <b>Descrição:</b> Permite gerar relatório dos assistidos da casa lar." CssClass="Descricao"></asp:Label> 
        
        <br /><br />
   
    </span>

<table width="100%" align="left" style="font-size: small; font-family: verdana">
        <tr>
            <td class="style18"> &nbsp; <span class="style11"><strong style="text-align: left">Filtro</strong></span></td>    
            <td class="style27"> &nbsp;</td>
            <td class="style20"> </td>
            <td class="style6"> </td>
        </tr>
        <tr>
            <td class="style28"> Assistido:</td>    
            <td class="style27">  
                <asp:DropDownList ID="ddlAssistido" runat="server" Height="22px" 
                    Width="200px" DataTextField="Nome" DataValueField="CodigoPessoa" 
                    AutoPostBack="True" 
                    onselectedindexchanged="ddlAssistido_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="style26"> 
                Status Cadastro</td>
            <td>  
                 <asp:DropDownList ID="ddlStatusCadastro" runat="server" Width="200px">
                    <asp:ListItem>Selecione</asp:ListItem>
                    <asp:ListItem Value="true">Ativo</asp:ListItem>
                    <asp:ListItem Value="false">Inativo</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style28"> Status Assistido:</td>    
            <td class="style27">  
                 <asp:DropDownList ID="ddlStatusAssistido" runat="server" Width="200px">
                    <asp:ListItem>Selecione</asp:ListItem>
                    <asp:ListItem>Em Atendimento</asp:ListItem>
                    <asp:ListItem>Retornou Família</asp:ListItem>
                    <asp:ListItem>Adotado</asp:ListItem>
                    <asp:ListItem>Transferido</asp:ListItem>
                    <asp:ListItem>Desaparecido</asp:ListItem>
                     <asp:ListItem>A Passeio</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style26"> 
                 Estado Saúde</td>
            <td>   
            <asp:DropDownList ID="ddlEstadoSaude" runat="server" Width="200px">
                <asp:ListItem>Selecione</asp:ListItem>
                <asp:ListItem Value="Saudavel">Saudável</asp:ListItem>
                <asp:ListItem>Doente</asp:ListItem>
            </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style28"> Data Entrada:</td>   
            <td class="style22" 
                
                
                style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA; margin-left: 40px;"> 
                <asp:TextBox ID="txtDataEntrada" runat="server" Width="196px" 
                    CssClass="mask-data"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                    ErrorMessage="Preencha a Data Entrada com uma data válida" 
                    ControlToValidate="txtDataEntrada" ForeColor="Red" Operator="DataTypeCheck" 
                    Type="Date">*</asp:CompareValidator>
        </td>
            <td class="style26"> 
                 Data Saída:</td>
            <td class="style17" 
                
                style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA; margin-left: 40px;">  
                <asp:TextBox ID="txtDataSaída" runat="server" Width="196px" 
                    CssClass="mask-data"></asp:TextBox>

                <asp:CompareValidator ID="CompareValidator3" runat="server" 
                    ErrorMessage="Preencha a Data Saída com uma data válida" 
                    ControlToValidate="txtDataSaída" ForeColor="Red" Operator="DataTypeCheck" 
                    Type="Date">*</asp:CompareValidator>
                <asp:CompareValidator ID="CompareValidator4" runat="server" 
                    
                    ErrorMessage="Preencha a Data Saída com uma data maior do que a Data Entrada" 
                    ControlToValidate="txtDataSaída" ControlToCompare="txtDataEntrada" 
                    ForeColor="Red" Operator="GreaterThanEqual" Type="Date">*</asp:CompareValidator>

            </td>
        </tr>
        <tr>
            <td class="style28"> &nbsp;</td>   
            <td class="style22" 
                
                style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA"> 
                &nbsp;</td>
            <td class="style26"> 
                 &nbsp;</td>
            <td class="style17" 
                style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">  
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style19" colspan="2">  
                <asp:Button ID="btnGerarRelatorio" runat="server" Text="Gerar Relatório" 
                    Width="160px" Height="26px" onclick="btnGerarRelatorio_Click" 
                     />
            </td>   
            <td colspan="2"> 
                 <asp:Button ID="btnLimpar" runat="server" Text="Limpar" Width="160px" 
                     style="text-align: center" Height="26px" onclick="btnLimpar_Click" 
                     />
            </td>
        </tr>
               
       
        </table>

        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
            <br />


 
    
    <p align="center" >
        &nbsp;</p>

</asp:Content>
