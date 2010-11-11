<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ConsultarProcedimentos.aspx.cs" Inherits="SGS.View.Procedimentos.ConsultarProcedimentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<style type="text/css">
        .style6
        {
            width: 100%;
        }
        .style10
    {
        text-align: right;
        width: 288px;
    }
    .style11
    {
        width: 288px;
        text-align: right;
    }
    .style12
    {
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
            <td class="style11"> &nbsp; </td>
            <td> &nbsp; </td>
            <td> &nbsp; </td>
        </tr>
        <tr>
            <td class="style12"> &nbsp;</td>    
            <td class="style11"> <span class="style6"><strong>Filtro:</strong></span></td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style12"> &nbsp;</td>    
            <td class="style10"> Assistido</td>
            <td> 
                <asp:DropDownList ID="ddlAssistido" runat="server" Height="21px" Width="271px">
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
            <td style="text-align: right" class="style11"> Data Agendada&nbsp; </td>
            <td> 
                <asp:TextBox ID="txtDataAgendada" runat="server" Width="200px" 
                    CssClass="mask-data"></asp:TextBox>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style12"> &nbsp;</td>    
            <td style="text-align: right" class="style11"> Data Efetuada </td>
            <td> 
                <asp:TextBox ID="txtDataEfetuada" runat="server" Width="200px" 
                    CssClass="mask-data"></asp:TextBox>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style12"> &nbsp;</td>    
            <td style="text-align: right" class="style11"> &nbsp;</td>
            <td> 
                &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style12"> &nbsp;</td>    
            <td style="text-align: right" class="style11"> &nbsp; </td>
            <td> 
                <asp:Button ID="btnLocalizar" runat="server" Text="Localizar" Width="95px" />
&nbsp;<asp:Button ID="btnLimpar" runat="server" Text="Limpar" Width="95px" />
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style12"> &nbsp;</td>    
            <td style="text-align: right" class="style11"> &nbsp;</td>
            <td> 
                &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style12" colspan="4">   
                <asp:GridView ID="gridProcedimentos" runat="server" CellPadding="4" 
                    EmptyDataText="Nenhum dado foi encontrado." ForeColor="#333333" 
                    GridLines="Horizontal" Width="96%" AutoGenerateColumns="False" 
                    BorderColor="#003399" HorizontalAlign="Center" Height="161px" 
                    AllowPaging="True" onpageindexchanging="gridProcedimentos_PageIndexChanging" 
                    PageSize="2">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="CodigoProcedimento" 
                            DataNavigateUrlFormatString="ManterProcedimentos.aspx?tipo=alt&amp;cod={0}" 
                            Text="Selecionar">
                        <ItemStyle Width="75px" />
                        </asp:HyperLinkField>
                        <asp:BoundField DataField="CodigoAssistido" HeaderText="Assistido">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="TipoProcedimento" HeaderText="Tipo de Procedimento">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Procedimento" HeaderText="Procedimento">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="DataMarcada" HeaderText="Data de Agendada" 
                            DataFormatString="{0:dd-M-yyyy}">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="DataRealizada" DataFormatString="{0:dd-M-yyyy}" 
                            HeaderText="Data Efetuada">
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
            <td class="style12"> &nbsp;</td>    
            <td style="text-align: right" class="style11"> &nbsp;</td>
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
