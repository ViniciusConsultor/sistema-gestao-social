<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="AltAlimentacao.aspx.cs" Inherits="ProjetoTela.Telas.Alimentacao.AltAlimentacao" %>
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

 <strong><span class="style4">Alterar Alimentação</span></strong><br />
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; Descrição: Permite alterar o plano alimentar dos assistidos da Casa Lar.<br />

<br /> &nbsp;&nbsp; Clique na alimentação que deseja modificar abaixo: <br /><br />

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
        </span>


           <table class="style6">
            <tr>
                <td class="style7">
                    Dia da semana</td>
                <td class="style9">
                    <span class="style10">
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="126px" Height="18px" 
                        Enabled="False">
                        <asp:ListItem Text="Selecione" Value="Selecione" ></asp:ListItem>
                        <asp:ListItem Text="Domingo" Value="Domingo" Selected="True" ></asp:ListItem>
                        <asp:ListItem Text="Segunda-Feira" Value="Segunda-Feira"></asp:ListItem>
                        <asp:ListItem>Terça-Feira</asp:ListItem>
                    </asp:DropDownList>
                    *</span></td>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Período</td>
                <td class="style9">
                    <span class="style10">
                    <asp:DropDownList ID="DropDownList3" runat="server" Width="126px" Height="18px" 
                        Enabled="False">
                        <asp:ListItem Text="Selecione" Value="Selecione" ></asp:ListItem>
                        <asp:ListItem Selected="True" >Desjejum</asp:ListItem>
                        <asp:ListItem>Colação</asp:ListItem>
                        <asp:ListItem>Almoço</asp:ListItem>
                        <asp:ListItem>Lanche</asp:ListItem>
                        <asp:ListItem>Jantar</asp:ListItem>
                        <asp:ListItem>Ceia</asp:ListItem>
                    </asp:DropDownList>
                    *</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Horário</td>
                <td class="style8">
                    <asp:TextBox ID="TextBox3" runat="server">07:00h</asp:TextBox>
                    <span class="style10">*</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Alimentos</td>
                <td class="style8">
                    <asp:ListBox ID="ListBox1" runat="server" Height="105px" Width="288px" 
                        SelectionMode="Multiple">
                        <asp:ListItem Selected="True">Café</asp:ListItem>
                        <asp:ListItem Selected="True">Pão</asp:ListItem>
                        <asp:ListItem Selected="True">Suco</asp:ListItem>
                        <asp:ListItem>Arroz</asp:ListItem>
                        <asp:ListItem>Feijão</asp:ListItem>
                        <asp:ListItem>Salada</asp:ListItem>
                        <asp:ListItem>Gelatina</asp:ListItem>
                    </asp:ListBox>
                    <span class="style10">*</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Porção do Alimento</td>
                <td align="right" class="style9" style="text-align: left">
                    <span class="style10">
                    <asp:TextBox ID="TextBox4" runat="server">1/2 Porção</asp:TextBox>
                    *</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Diretiva</td>
                <td align="right" class="style9" style="text-align: left">
                    <span class="style10">
                    <asp:TextBox ID="TextBox5" runat="server" Height="86px" TextMode="MultiLine" 
                        Width="285px"></asp:TextBox>
                    </span></td>
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
            <tr align="center"> 
                <td class="style11">
                     &nbsp;</td>
            </tr>
            <tr align="center">
                <td> 
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Width="110px" /> &nbsp;&nbsp;<asp:Button 
                        ID="btnSalvar0" runat="server" Text="Excluir" Width="110px" /> &nbsp;<asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="110px" />
                </td>
            </tr>
        </table>
        <br />

</asp:Content>
