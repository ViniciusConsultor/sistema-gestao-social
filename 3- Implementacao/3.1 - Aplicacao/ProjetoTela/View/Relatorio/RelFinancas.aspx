<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true"
    CodeBehind="RelFinancas.aspx.cs" Inherits="SGS.View.Relatorio.RelFinancas" %>

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
            width: 189px;
        }
        .style19
        {
            text-align: right;
        }
        .style20
        {
            height: 20px;
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
            width: 160px;
        }
        .style27
        {
            width: 223px;
            text-align: left;
        }
        .style28
        {
            text-align: right;
            width: 189px;
        }
        .style29
        {
            width: 105px;
            text-align: left;
        }
    </style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<span class="style4"><strong> 
        <asp:Label ID="Label1" runat="server" Text="Relatório Financeiro"></asp:Label>
    </strong> &nbsp;</span><br />
    
    <span class="style4" style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; 
    <asp:Label ID="Label2" runat="server" 
        Text="Descrição: Permite gerar relatório financeiro da casa lar."></asp:Label> 
        
        <br /><br />
   
    </span>

    <table width="100%" align="left" style="font-size: small; font-family: verdana">
        <tr>
            <td class="style18"> &nbsp; <span class="style11"><strong style="text-align: left">Filtro</strong></span></td>    
            <td class="style29"> &nbsp;</td>
            <td class="style20"> </td>
            <td class="style6"> </td>
        </tr>
        <tr>
            <td class="style18"> &nbsp;</td>    
            <td class="style29"> <strong>Tipo Relatório:</strong></td>
            <td class="style20" colspan="2"> 
            <asp:RadioButtonList ID="rdbSexo" runat="server" RepeatDirection="Horizontal" 
                RepeatLayout="Flow" AutoPostBack="True" 
                    onselectedindexchanged="rdbSexo_SelectedIndexChanged" Width="200px">
                <asp:ListItem Value="Orcamento">Orçamento</asp:ListItem>
                <asp:ListItem Value="Financas">Finanças</asp:ListItem>
            </asp:RadioButtonList>
            </td>
        </tr>
    </table>

    <br /><br /><br />

    <asp:Panel runat="server" ID="pnlFinancas" Visible="false">
    
    <table width="100%" align="left" style="font-size: small; font-family: verdana">
        <tr>
            <td class="style18"> &nbsp; <span class="style11"><strong style="text-align: left">Filtro</strong></span></td>    
            <td class="style27"> &nbsp;</td>
            <td class="style20"> </td>
            <td class="style6"> </td>
        </tr>
        <tr>
            <td class="style28"> Tipo de Lançamento:</td>    
            <td class="style27">  
                <asp:DropDownList ID="ddlTipoLancamento" runat="server" Height="22px" 
                    Width="200px" DataTextField="Nome" DataValueField="CodigoPessoa" 
                    AutoPostBack="True" 
                    >
                    <asp:ListItem>Todos</asp:ListItem>
                    <asp:ListItem>Receita</asp:ListItem>
                    <asp:ListItem>Despesa</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style26"> 
                Natureza Lançamento:</td>
            <td>  
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
        </tr>
        <tr>
            <td class="style28"> Data Início Lançamento:</td>    
            <td class="style27">  
                <asp:TextBox ID="txtDtInicioLancamento" runat="server" Width="196px"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                    ErrorMessage="CompareValidator" ControlToValidate="txtDataEntrada" 
                    Enabled="False">*</asp:CompareValidator>
            </td>
            <td class="style26"> 
                 Data Fim Lançamento:</td>
            <td>   
                <asp:TextBox ID="txtDtFimLancamento" runat="server" Width="196px"></asp:TextBox>

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
                    Width="160px" Height="26px" />
            </td>   
            <td colspan="2"> 
                 <asp:Button ID="btnLimpar" runat="server" Text="Limpar" Width="160px" 
                     style="text-align: center" Height="26px"/>
            </td>
        </tr>
               
       
        </table>
        </asp:Panel>

        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
            <br />


 
    
    <p align="center" >
        &nbsp;</p>


</asp:Content>
