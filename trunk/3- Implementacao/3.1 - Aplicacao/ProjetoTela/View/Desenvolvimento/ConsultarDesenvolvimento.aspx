<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ConsultarDesenvolvimento.aspx.cs" Inherits="SGS.View.Profissional.ConsultarProfissional" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<style type="text/css">
        .style6
        {
            width: 100%;
        }
        .style10
        {
        text-align: right;
        width: 200px;
    }
        .style12
    {
        width: 200px;
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

    <table width="850px" align="left">
        <tr>
            <td class="style12"> &nbsp; </td>    
            <td class="style12"> &nbsp; <span class="style6"><strong>Filtro:</strong></span></td>
            <td> &nbsp; </td>
            <td> &nbsp; </td>
        </tr>
        <tr>
            <td class="style12"> &nbsp;</td>    
            <td class="style12"> &nbsp;</td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style12"> &nbsp;</td>    
            <td class="style10"> Assistido</td>
            <td> 
                <asp:DropDownList ID="ddlAssistido" runat="server" Height="22px" Width="148px">
                    <asp:ListItem>Selecione</asp:ListItem>
                    <asp:ListItem>João</asp:ListItem>
                    <asp:ListItem>Maria</asp:ListItem>
                    <asp:ListItem>Luiz</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style12"> &nbsp;</td>    
            <td class="style10"> Atividade</td>
            <td> 
                <asp:DropDownList ID="ddlAtividade" runat="server" Height="22px" 
                    Width="148px">
                    <asp:ListItem>Selecione</asp:ListItem>
                    <asp:ListItem>Curso de Informática</asp:ListItem>
                    <asp:ListItem>Palestra Sobre Educação</asp:ListItem>
                    <asp:ListItem>Seminário de Tecnologia</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style12"> &nbsp;</td>    
            <td style="text-align: right" class="style12"> &nbsp;</td>
            <td> 
                &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style12"> &nbsp;</td>    
            <td style="text-align: right" class="style12"> &nbsp;</td>
            <td> 
                &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style12"> &nbsp;</td>    
            <td style="text-align: right" class="style12"> &nbsp;</td>
            <td> 
                &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style12"> &nbsp;</td>    
            <td style="text-align: right" class="style12"> &nbsp; </td>
            <td> 
                <asp:Button ID="btnLocalizar" runat="server" Text="Localizar" Width="95px" />
&nbsp;<asp:Button ID="btnLimpar" runat="server" Text="Limpar" Width="95px" />
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style12"> &nbsp;</td>    
            <td style="text-align: right" class="style12"> &nbsp;</td>
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
