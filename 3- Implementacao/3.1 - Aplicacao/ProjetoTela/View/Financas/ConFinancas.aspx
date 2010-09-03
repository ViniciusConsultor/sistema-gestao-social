<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ConFinancas.aspx.cs" Inherits="ProjetoTela.Telas.Financas.ConFinancas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .style6
        {
            width: 85%;
        }
        .style7
        {
            width: 105px;
        }
        .style8
        {
            width: 124px;
        }
        .style9
        {
            width: 15px;
            text-align: center;
        }
        .style10
        {
            width: 105px;
            height: 53px;
        }
        .style11
        {
            height: 53px;
        }
        .style12
        {
            width: 124px;
            height: 53px;
        }
        .style13
        {
            width: 15px;
            text-align: center;
            height: 53px;
        }
        .style14
        {
            width: 173px;
        }
        .style15
        {
            height: 53px;
            width: 173px;
            text-align: right;
        }
        .style16
        {
            font-size: small;
            font-weight: bold;
        }
        .style17
        {
            font-weight: bold;
            text-align: center;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


 <strong><span class="style4">Consultar Finanças</span></strong><br />
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">&nbsp;&nbsp; Descrição: 
Permite ao gestor consultar as receitas e despesas da Casa Lar.<br />
    <br />
    <table class="style6" align="center">
        <tr>
            <td class="style7">
                <strong>Filtro</strong></td>
            <td>
                &nbsp;</td>
            <td class="style14">
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style10">
                Tipo lançamento:</td>
            <td class="style11">
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="22px" 
                    Width="120px">
                        <asp:ListItem>Todos</asp:ListItem>
                        <asp:ListItem>Receita</asp:ListItem>
                        <asp:ListItem>Despesa</asp:ListItem>
                    </asp:DropDownList>
                </td>
            <td class="style15">
                Data lançamento entre:</td>
            <td class="style12">
                <asp:TextBox ID="TextBox1" runat="server" Width="100px"></asp:TextBox>
            </td>
            <td class="style13">
                e</td>
            <td class="style11">
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                <asp:TextBox ID="TextBox2" runat="server" Width="100px"></asp:TextBox>
        </span>


            </td>
            <td class="style11">
                <asp:Button ID="Button1" runat="server" Text="Localizar" />
            </td>
        </tr>
    </table>
    <br /> <span class="style16">Resultado: 
    <br />
    </span>
    <br />
    <table class="style6">
        <tr>
            <td class="style17">
                    Tipo Lançamento</td>
            <td class="style17">
                    Data Lançamento</td>
            <td class="style17">
                    Valor</td>
        </tr>
        <tr>
            <td>
                Receita</td>
            <td>
                01/10/2010</td>
            <td>
                R$ 5.000,00</td>
        </tr>
    </table>
    <br />
    <br />
        </span><span class="style16"> 
    <br />
    </span>
         

</asp:Content>
    