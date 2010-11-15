﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ConsultarAssistido.aspx.cs" Inherits="SGS.View.Pessoa.ConsultarAssistido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style6
        {
            height: 20px;
        }
        .style7
        {
            text-align: right;
        }
        .style8
        {
            width: 183px;
        }
        .style9
        {
            height: 20px;
            width: 183px;
        }
        .style10
        {
            text-align: right;
            width: 183px;
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

<table width="850px" align="left" style="font-size: small; font-family: verdana">
        <tr>
            <td class="style7"> &nbsp; </td>    
            <td class="style8"> &nbsp; <span class="style6"><strong>Filtro:</strong></span></td>
            <td> &nbsp; </td>
            <td> &nbsp; </td>
        </tr>
        <tr>
            <td class="style6"> </td>    
            <td class="style9"> </td>
            <td class="style6"> </td>
            <td class="style6"> </td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td class="style10"> Assistido</td>
            <td> 
                <asp:DropDownList ID="ddlAssistido" runat="server" Height="22px" 
                    Width="200px">
                    <asp:ListItem>Selecione</asp:ListItem>
                    <asp:ListItem>Funcionário</asp:ListItem>
                    <asp:ListItem>Voluntário</asp:ListItem>
                    <asp:ListItem>Assistido</asp:ListItem>
                    <asp:ListItem>Patrocinador</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td class="style10"> Status Assistido</td>
            <td> 
                 <asp:DropDownList ID="ddlStatusAssistido" runat="server" Width="200px">
                    <asp:ListItem Value="Selecione">Selecione</asp:ListItem>
                    <asp:ListItem>Em Atendimento</asp:ListItem>
                    <asp:ListItem>Retornou Família</asp:ListItem>
                    <asp:ListItem>Adotado</asp:ListItem>
                    <asp:ListItem>Transferido</asp:ListItem>
                    <asp:ListItem>Desaparecido</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td class="style10"> Nome</td>
            <td> 
                <asp:TextBox ID="txtNome" runat="server" Height="22px" Width="195px"></asp:TextBox>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td style="text-align: right" class="style8"> </td>
            <td> 
                <asp:Button ID="btnLocalizar" runat="server" Text="Localizar" Width="98px" />
&nbsp;<asp:Button ID="btnLimpar" runat="server" Text="Limpar" Width="98px" />
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td style="text-align: right" class="style8"> &nbsp;</td>
            <td> 
                 &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td style="text-align: right" class="style8"> &nbsp;</td>
            <td> 
                &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td style="text-align: right" class="style8"> &nbsp;</td>
            <td> 
                &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td style="text-align: right" class="style8"> &nbsp;</td>
            <td> 
                &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td style="text-align: right" class="style8"> &nbsp; </td>
            <td> 
&nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td style="text-align: right" class="style8"> &nbsp;</td>
            <td> 
                &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
    </table>
    <br />

     
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

</asp:Content>
