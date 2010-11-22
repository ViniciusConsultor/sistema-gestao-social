<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ConsultarAssistido.aspx.cs" Inherits="SGS.View.Pessoa.ConsultarAssistido" %>
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
            width: 313px;
        }
        .style10
        {
            text-align: right;
            width: 313px;
        }
        .style11
        {
            height: 20px;
            text-decoration: underline;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<span class="style4"><strong> 
        <asp:Label ID="lblTitulo" runat="server" Text="Consultar Assistido" CssClass="Titulo"></asp:Label>
    </strong> &nbsp;</span><br />
    
    <span class="style4" style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp; <asp:Label ID="lblDescricao" runat="server" 
        Text="<b>Descrição:</b> Permite localização dos assistidos da casa lar." CssClass="Descricao"></asp:Label> 
        
        <br /><br />
   
    </span>

<table width="100%" align="left" style="font-size: small; font-family: verdana">
        <tr>
            <td class="style7"> &nbsp; </td>    
            <td class="style8"> &nbsp;</td>
            <td> &nbsp; </td>
            <td> &nbsp; </td>
        </tr>
        <tr>
            <td class="style6"> &nbsp;</td>    
            <td class="style8" align="right"> &nbsp; <span class="style11"><strong style="text-align: right">Filtro</strong></span></td>
            <td class="style6"> </td>
            <td class="style6"> </td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td class="style10"> Assistido:</td>
            <td> 
                <asp:DropDownList ID="ddlAssistido" runat="server" Height="22px" 
                    Width="200px" DataTextField="Nome" DataValueField="CodigoPessoa" 
                    AutoPostBack="True" onselectedindexchanged="ddlAssistido_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td class="style10"> Status Assistido:</td>
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
            <td class="style10"> Status Cadastro:</td>
            <td> 
                 <asp:DropDownList ID="ddlStatusCadastro" runat="server" Width="200px">
                    <asp:ListItem Value="Selecione">Selecione</asp:ListItem>
                    <asp:ListItem Value="true">Ativo</asp:ListItem>
                    <asp:ListItem Value="false">Inativo</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td class="style10"> Nome:</td>
            <td> 
                <asp:TextBox ID="txtNome" runat="server" Height="22px" Width="195px" 
                    MaxLength="80"></asp:TextBox>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td style="text-align: right" class="style8"> </td>
            <td> 
                <asp:Button ID="btnLocalizar" runat="server" Text="Localizar" Width="96px" 
                    onclick="btnLocalizar_Click" />
&nbsp;<asp:Button ID="btnLimpar" runat="server" Text="Limpar" Width="96px" 
                    onclick="btnLimpar_Click" />
            </td>
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
    <br />
    <br />
    <br />
    <br />

       <table border="0" width="100%" align="left">
        <tr>
            <td> 
                <asp:GridView ID="gridAssistido" runat="server" CellPadding="4" 
                    EmptyDataText="Nenhum dado foi encontrado." ForeColor="#333333" 
                    GridLines="Horizontal" Width="90%" AutoGenerateColumns="False" 
                    BorderColor="#003399" HorizontalAlign="Center" AllowPaging="True" 
                    PageSize="2" onpageindexchanging="gridAssistido_PageIndexChanging">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="CodigoAssistido" 
                            DataNavigateUrlFormatString="ManterAssistido.aspx?tipo=alt&amp;cod={0}" 
                            Text="Selecionar">
                        <ItemStyle Width="75px" />
                        </asp:HyperLinkField>
                        <asp:BoundField DataField="Nome" HeaderText="Assistido">
                        <HeaderStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="DataNascimento" HeaderText="Data Nascimento" 
                            DataFormatString="{0:dd-MM-yyyy}">
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="StatusAssistido" HeaderText="Status ">
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="AssistidoAtivo" HeaderText="Cadastro Ativo">
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" BorderColor="#003399" />
                    <EmptyDataRowStyle Font-Bold="True" Font-Size="Small" ForeColor="Red" 
                        HorizontalAlign="Center" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" 
                        Font-Size="Smaller" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" Font-Size="Small" 
                        ForeColor="White" />
                    <PagerSettings Mode="NumericFirstLast" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Right" 
                        Font-Names="Verdana,Tahoma" Font-Size="Smaller" />
                    <RowStyle BackColor="#EFF3FB" Font-Size="Small" BorderColor="#003399" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
                <br />
            </td>
        </tr>
    </table>


</asp:Content>
