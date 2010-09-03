<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ConAlimentacao.aspx.cs" Inherits="ProjetoTela.Telas.Alimentacao.ConAlimentacao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .style12
    {
        width: 85%;
    }
    .style13
    {
        height: 20px;
        text-align: center;
        font-weight: bold;
    }
    .style14
    {
        text-align: center;
    }
    .style15
    {
        height: 20px;
        text-align: center;
        font-weight: bold;
        width: 125px;
    }
    .style16
    {
        width: 125px;
    }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <strong><span class="style4">Consultar Alimentação</span></strong><br />
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; Descrição: Permite consultar o plano alimentar dos assistidos da Casa Lar.<br />
<br />
<table class="style12" style="border: thin solid #000000;" align="center">
    <tr>
        <td class="style13">
            Período</td>
        <td class="style13">
            Horário</td>
        <td class="style15">
            Domingo</td>
        <td class="style13">
            Segunda</td>
        <td class="style13">
            Terça</td>
        <td class="style13">
            Quarta</td>
        <td class="style13">
            Quinta</td>
        <td class="style13">
            Sexta</td>
        <td class="style13">
            Sábado</td>
    </tr>
    <tr>
        <td>
            Desjejum</td>
        <td class="style14">
            07:00h</td>
        <td class="style16">
            <asp:LinkButton ID="LinkButton1" runat="server">Café, Pão c/ queijo, <br> suco</br></asp:LinkButton>
        </td>
        <td>
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
            <asp:LinkButton ID="LinkButton7" runat="server">Nescau, Suco, <br> Biscoito</br></asp:LinkButton>
        </span>

        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Colação</td>
        <td class="style14">
            09:00h</td>
        <td class="style16">
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
            <asp:LinkButton ID="LinkButton2" runat="server">Banana</asp:LinkButton>
        </span>

        </td>
        <td>
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
            <asp:LinkButton ID="LinkButton9" runat="server">Maça</asp:LinkButton>
        </span>

        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Almoço</td>
        <td class="style14">
            12:00h</td>
        <td class="style16">
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
            <asp:LinkButton ID="LinkButton3" runat="server">Arroz, Feijão, <br> Carne</br></asp:LinkButton>
        </span>

        </td>
        <td>
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
            <asp:LinkButton ID="LinkButton10" runat="server">Carne, Macarrão</asp:LinkButton>
        </span>

        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Lanche</td>
        <td class="style14">
            15:00h</td>
        <td class="style16">
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
            <asp:LinkButton ID="LinkButton4" runat="server">Biscoito</asp:LinkButton>
        </span>

        </td>
        <td>
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
            <asp:LinkButton ID="LinkButton11" runat="server">Pera</asp:LinkButton>
        </span>

        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Jantar</td>
        <td class="style14">
            18:30h</td>
        <td class="style16">
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
            <asp:LinkButton ID="LinkButton5" runat="server">Lasanha</asp:LinkButton>
        </span>

        </td>
        <td>
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
            <asp:LinkButton ID="LinkButton12" runat="server">Macarrão c/ carne</asp:LinkButton>
        </span>

        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Ceia</td>
        <td class="style14">
            21:30h</td>
        <td class="style16">
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
            <asp:LinkButton ID="LinkButton8" runat="server">Vitamina</asp:LinkButton>
        </span>

        </td>
        <td>
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
            <asp:LinkButton ID="LinkButton13" runat="server">Vitamina</asp:LinkButton>
        </span>

        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style16">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
&nbsp;<br />
        <br />
        </span>

</asp:Content>
