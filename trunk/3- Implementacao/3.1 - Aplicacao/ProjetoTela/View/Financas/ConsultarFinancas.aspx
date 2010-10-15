<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ConsultarFinancas.aspx.cs" Inherits="SGS.View.Financas.ConsultarFinancas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<style type="text/css">
        .style6
        {
            width: 100%;
        }
        .style7
        {
        text-align: right;
        font-size: small;
    }
        .style11
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
        <asp:Label ID="lblTitulo" runat="server" Text="Consultar Finanças"></asp:Label>
    </strong> &nbsp;</span><br />
    <span class="style4" style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; <asp:Label ID="lblDescricao" runat="server" 
        Text="Descrição: Permite buscar as finanças cadastradas no sistema."></asp:Label> 
        
        <br /><br />
   
    </span>

    <table width="850px" align="left">
        <tr>
            <td class="style7"> &nbsp; </td>    
            <td class="style12"> &nbsp; <span class="style6"><strong>Filtro:</strong></span></td>
            <td> &nbsp; </td>
            <td> &nbsp; </td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td class="style12"> &nbsp;</td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td class="style11"> Tipo de Lançamento</td>
            <td> 
                <asp:DropDownList ID="ddlTipoLancamento" runat="server" Height="22px" 
                    Width="148px">
                    <asp:ListItem>Selecione</asp:ListItem>
                    <asp:ListItem>Receita</asp:ListItem>
                    <asp:ListItem>Despesa</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td class="style11"> Data de Lançamento</td>
            <td> 
                <asp:TextBox ID="txtDataLancamento" runat="server" Height="22px" Width="148px"></asp:TextBox>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td style="text-align: right" class="style12"> Descrição </td>
            <td> 
                <asp:TextBox ID="txtDescricao" runat="server" Height="22px" Width="148px"></asp:TextBox>
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
        <tr>
            <td class="style7" colspan="4">  
                <asp:GridView ID="gridFinancas" runat="server" CellPadding="4" 
                    EmptyDataText="Nenhum dado foi encontrado." ForeColor="#333333" 
                    GridLines="Horizontal" Width="90%" AutoGenerateColumns="False" 
                    BorderColor="#003399" HorizontalAlign="Center">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="CodigoFinancas" 
                            DataNavigateUrlFormatString="ManterFinancas.aspx?tipo=alt&amp;cod={0}" 
                            Text="Selecionar">
                        <ItemStyle Width="75px" />
                        </asp:HyperLinkField>
                        <asp:BoundField DataField="TipoLancamento" HeaderText="Tipo Lançamento">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Observacao" HeaderText="Descrição">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Valor" HeaderText="Valor">
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
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
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
            <td class="style7"> &nbsp;</td>    
            <td style="text-align: right" class="style12"> &nbsp;</td>
            <td> 
                &nbsp;</td>
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
    <br />

</asp:Content>
