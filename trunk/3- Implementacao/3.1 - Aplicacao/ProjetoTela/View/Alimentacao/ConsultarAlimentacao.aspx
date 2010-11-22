<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ConsultarAlimentacao.aspx.cs" Inherits="SGS.View.Alimentacao.ConsultarAlimentacao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<style type="text/css">
        .style7
        {
        width: 137px;
        text-align: right;
        font-size: small;
    }
        .style12
    {
        width: 200px;
    }
    .style13
    {
        text-align: right;
        width: 200px;
    }
        .style10
        {
            color: #FF0000;
        }
        </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<span class="style4"><strong> 
        <asp:Label ID="lblTitulo" runat="server" Text="Consultar Alimentação" CssClass="Titulo"></asp:Label>
    </strong> &nbsp;</span><br />
    <span class="style4" style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp; 
    <asp:Label ID="lblDescricao" runat="server" 
        Text=" <b>Descrição:</b> Permite consultar a Alimentação da Casa Lar." CssClass="Descricao"></asp:Label> 
        
        <br /><br />
</span>

<table width="850px" align="left">
        <tbody style="font-size: small; font-family: Verdana">
        <tr>
            <td class="style7"> &nbsp; </td>    
            <td align="right"> &nbsp; <strong>Filtro:</strong></span></td>
            <td> &nbsp; </td>
            <td> &nbsp; </td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td class="style13"> Dia da Semana:</td>
            <td> 
                    <span class="style10">
                    <asp:DropDownList ID="ddlDiaSemana" runat="server" Width="200px" Height="22px" 
                        onselectedindexchanged="ddlDiaSemana_SelectedIndexChanged">
                        <asp:ListItem Text="Domingo" Value="Domingo" ></asp:ListItem>
                        <asp:ListItem Text="Segunda-Feira" Value="Segunda-Feira"></asp:ListItem>
                        <asp:ListItem Text="Terça-Feira" Value="Terca-Feira"></asp:ListItem>
                        <asp:ListItem Text="Quarta-Feira" Value="Quarta-Feira"></asp:ListItem>
                        <asp:ListItem Text="Quinta-Feira" Value="Quinta-Feira"></asp:ListItem>
                        <asp:ListItem Text="Sexta-Feira" Value="Sexta-Feira"></asp:ListItem>
                        <asp:ListItem Value="Sabado">Sábado</asp:ListItem>
                    </asp:DropDownList>
                    </span>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td style="text-align: right" class="style12"> &nbsp; </td>
            <td> 
                <asp:Button ID="btnLocalizar" runat="server" Text="Localizar" Width="95px" 
                    onclick="btnLocalizar_Click" />
&nbsp;<asp:Button ID="btnLimpar" runat="server" Text="Limpar" Width="95px" 
                    onclick="btnLimpar_Click" />
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
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

    
    <asp:Repeater ID="rptDia" runat="server" onitemcreated="rptDia_ItemCreated">
        <HeaderTemplate>
            <table width="80%" style="border: thin solid #4986E1; font-size: small; font-family: Verdana" align="center">
        </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td style="background-color: #3366CC; color: #FFFFFF;"><b> <%# DataBinder.Eval(Container.DataItem, "DiaSemana")%> </b> </td>
                </tr>

                <asp:Repeater ID="rptPeriodo" runat="server">
                <ItemTemplate>
                    <tr>
                        <td>&nbsp;&nbsp;&nbsp; <strong> <%# DataBinder.Eval(Container.DataItem, "NomePeriodo")%>: </strong>  <%# DataBinder.Eval(Container.DataItem, "Alimentos")%> </td>
                    </tr>
                    <tr>
                        <td>&nbsp;&nbsp;&nbsp; <strong>Horário:</strong> <%# DataBinder.Eval(Container.DataItem, "Horario")%> </td>
                    </tr>
                    <tr>
                        <td>&nbsp;&nbsp;&nbsp; <strong>Diretiva:</strong> <%# DataBinder.Eval(Container.DataItem, "Diretiva")%>  <br /> <br /></td>
                    </tr>
                 </ItemTemplate>
                 </asp:Repeater>
           
            </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    <asp:Panel ID="pnlInformacao" runat="server" Visible="false">
        <table cellspacing="0" cellpadding="4" align="Center" rules="rows" border="1" id="Table1" style="color:#333333;border-color:#003399;width:80%;border-collapse:collapse;">
		    <tr align="center" style="color:Red;font-size:Small;font-weight:bold;">
			    <td colspan="5">Nenhum dado foi encontrado.</td>
		    </tr>
	    </table>
    </asp:Panel>
    <br />

   </asp:Content>
