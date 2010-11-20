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

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<span class="style4"><strong> 
        <asp:Label ID="Label1" runat="server" Text="Relatório Assistido"></asp:Label>
    </strong> &nbsp;</span><br />
    
    <span class="style4" style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; 
    <asp:Label ID="Label2" runat="server" 
        Text="   Descrição: Permite gerar relatório dos assistidos da casa lar."></asp:Label> 
        
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
                <asp:TextBox ID="txtDataEntrada" runat="server" Width="196px"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                    ErrorMessage="CompareValidator" ControlToValidate="txtDataEntrada" 
                    Enabled="False">*</asp:CompareValidator>
        </td>
            <td class="style26"> 
                 Data Saída:</td>
            <td class="style17" 
                
                style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA; margin-left: 40px;">  
                <asp:TextBox ID="txtDataSaída" runat="server" Width="196px"></asp:TextBox>

                <asp:CompareValidator ID="CompareValidator3" runat="server" 
                    ErrorMessage="CompareValidator" ControlToValidate="txtDataSaída" 
                    Enabled="False">*</asp:CompareValidator>
                <asp:CompareValidator ID="CompareValidator4" runat="server" 
                    ErrorMessage="CompareValidator" ControlToValidate="txtDataSaída" 
                    Enabled="False">*</asp:CompareValidator>

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
