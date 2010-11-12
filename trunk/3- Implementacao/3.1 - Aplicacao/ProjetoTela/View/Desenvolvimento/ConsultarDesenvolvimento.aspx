<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ConsultarDesenvolvimento.aspx.cs" Inherits="SGS.View.Desenvolvimento.ConsultarDesenvolvimento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<style type="text/css">
        .style13
    {
    }
    .style14
    {
        width: 497px;
    }
    .style16
    {
        width: 497px;
        text-decoration: underline;
        font-size: smaller;
    }
    .style17
    {
        width: 187px;
        text-decoration: underline;
        font-size: smaller;
    }
    .style19
    {
        text-align: right;
        width: 119px;
        font-size: smaller;
    }
    .style20
    {
        width: 187px;
    }
    .style21
    {
        width: 119px;
        text-decoration: underline;
        font-size: smaller;
    }
    .style22
    {
        width: 119px;
    }
    .style23
    {
        width: 119px;
        text-decoration: underline;
        font-size: smaller;
        text-align: right;
    }
        .style24
    {
        width: 119px;
        font-size: smaller;
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
            <td class="style17"> &nbsp; </td>    
            <td class="style21"> &nbsp; </td>
            <td class="style16"> &nbsp; </td>
        </tr>
        <tr>
            <td class="style17"> &nbsp;</td>    
            <td class="style23"> <strong style="text-align: right">Filtro:</strong></td>
            <td class="style16"> &nbsp;</td>
        </tr>
        <tr>
            <td class="style20"> &nbsp;</td>    
            <td class="style19"> Assistido</td>
            <td class="style14"> 
                <asp:DropDownList ID="ddlAssistido" runat="server" Width="148px">
                    <asp:ListItem>Selecione</asp:ListItem>
                    <asp:ListItem>João</asp:ListItem>
                    <asp:ListItem>Maria</asp:ListItem>
                    <asp:ListItem>Luiz</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style20"> &nbsp;</td>    
            <td class="style19"> Atividade</td>
            <td class="style14"> 
                <asp:TextBox ID="txtAtividade" runat="server" Width="148px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style20"> &nbsp;</td>    
            <td style="text-align: right" class="style24"> Data Início</td>
            <td class="style14"> 
                <asp:TextBox ID="txtDataInicio" runat="server" Width="148px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style20"> &nbsp;</td>    
            <td style="text-align: right" class="style24"> Data Fim</td>
            <td class="style14"> 
                <asp:TextBox ID="txtDataFim" runat="server" Width="148px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style20"> &nbsp;</td>    
            <td style="text-align: right" class="style22"> &nbsp;</td>
            <td class="style14"> 
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style20"> &nbsp;</td>    
            <td style="text-align: right" class="style22"> &nbsp; </td>
            <td class="style14"> 
                <asp:Button ID="btnLocalizar" runat="server" Text="Localizar" Width="95px" />
&nbsp;<asp:Button ID="btnLimpar" runat="server" Text="Limpar" Width="95px" />
            </td>
        </tr>
        <tr>
            <td class="style20"> &nbsp;</td>    
            <td style="text-align: right" class="style22"> &nbsp;</td>
            <td class="style14"> 
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style13" colspan="3">    
                <asp:GridView ID="gridDesenvolvimento" runat="server" CellPadding="4" 
                    EmptyDataText="Nenhum dado foi encontrado." ForeColor="#333333" 
                    GridLines="Horizontal" Width="96%" AutoGenerateColumns="False" 
                    BorderColor="#003399" HorizontalAlign="Center" Height="161px" 
                    AllowPaging="True" PageSize="2">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="CodigoDesenvolvimento" 
                            DataNavigateUrlFormatString="ManterDesenvolvimento.aspx?tipo=alt&amp;cod={0}" 
                            Text="Selecionar">
                        <ItemStyle Width="75px" />
                        </asp:HyperLinkField>
                        <asp:BoundField DataField="NomeAssistido" HeaderText="Assistido">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Atividade" HeaderText="Atividade">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="DataInicio" HeaderText="Data Inicio" 
                            DataFormatString="{0:dd-MM-yyyy}">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="DataFim" HeaderText="Data Fim" 
                            DataFormatString="{0:dd-MM-yyyy}">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" BorderColor="#003399" />
                    <EmptyDataRowStyle Font-Bold="True" Font-Size="Small" ForeColor="Red" 
                        HorizontalAlign="Center" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" Font-Size="Small" 
                        ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Right" 
                        Font-Size="Smaller" />
                    <RowStyle BackColor="#EFF3FB" Font-Size="Small" BorderColor="#003399" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
                </td>    
        </tr>
        <tr>
            <td class="style20"> &nbsp;</td>    
            <td style="text-align: right" class="style22"> &nbsp;</td>
            <td class="style14"> 
                &nbsp;</td>
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
