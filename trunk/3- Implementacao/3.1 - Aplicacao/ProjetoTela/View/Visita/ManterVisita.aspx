<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ManterVisita.aspx.cs" Inherits="SGS.View.Visita.ManterVisita" %>
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
            width: 365px;
        }
        .style9
        {
            width: 365px;
        }
        .style10
        {
            color: #FF0000;
        }
        .style11
        {
            font-size: small;
            color: #FF0000;
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
                    Visitante</td>
                <td class="style9">
                    <span class="style10">
                    <asp:TextBox ID="txtVisitante" runat="server" Width="148px" Height="22px"></asp:TextBox>
                    *</span></td>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Assistido</td>
                <td class="style9">
                    <span class="style10">
                    <asp:DropDownList ID="ddlAssistido" runat="server" Width="148px" Height="22px">
                        <asp:ListItem Text="Selecione" Value="Selecione" ></asp:ListItem>
                        <asp:ListItem >Tiago Pereira</asp:ListItem>
                        <asp:ListItem>Junior Ferraz</asp:ListItem>
                    </asp:DropDownList>
                    *</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Data</td>
                <td class="style8">
                    <asp:TextBox ID="txtDataVisita" runat="server" Height="22px" Width="148px"></asp:TextBox>
                    <span class="style10">*</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Hoário Início</td>
                <td class="style8">
                    <asp:TextBox ID="txtHoraInicio" runat="server" Height="22px" Width="148px"></asp:TextBox>
                    <span class="style10">*</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Horário Fim</td>
                <td class="style8">
                    <asp:TextBox ID="txtHoraFim" runat="server" Height="22px" Width="148px"></asp:TextBox>
                    <span class="style10">*</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Motivo da Visita</td>
                <td class="style8">
                    <span class="style10">
                    <asp:TextBox ID="txtMotivoVisita" runat="server" Height="86px" TextMode="MultiLine" 
                        Width="285px"></asp:TextBox>
                    *</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Feedback</td>
                <td class="style8">
                    <span class="style10">
                    <asp:TextBox ID="txtFeedbackVisita" runat="server" Height="86px" TextMode="MultiLine" 
                        Width="285px"></asp:TextBox>
                    *</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Status</td>
                <td class="style8">
                    <span class="style10">
                    <asp:DropDownList ID="ddlStatusVisita" runat="server" Width="148px" 
                        Height="22px">
                        <asp:ListItem Text="Selecione" Value="Selecione" ></asp:ListItem>
                        <asp:ListItem >Marcada</asp:ListItem>
                        <asp:ListItem>Rejeitada</asp:ListItem>
                        <asp:ListItem>Efetuada</asp:ListItem>
                    </asp:DropDownList>
                    *</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            </table>
         <br />
        <table width="100%">
            <tr align="center"> 
                <td class="style11">
                     Os campos que possuem * são obrigatórios.
                </td>
            </tr>
            </table>
        <br />

        <table width="100%">
            <tr align="center">
                <td> 
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Width="110px" 
                        /> &nbsp; 
                    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" Width="110px" 
                        /> &nbsp;
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="110px" 
                        CausesValidation="False" />
                </td>
            </tr>
            <tr align="center">
                <td> 
                    &nbsp;</td>
            </tr>
        </table>

</asp:Content>
