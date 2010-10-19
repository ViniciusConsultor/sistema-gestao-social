<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ConsultarLogin.aspx.cs" Inherits="SGS.View.LoginUI.ConsultarLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

        <style type="text/css">
            .style6
            {
                font-size: smaller;
                text-align: right;
                text-decoration: underline;
            }
            .style7
            {
                text-align: right;
                width: 55px;
            }
            .style8
            {
                width: 258px;
            }
            .style9
            {
                font-size: smaller;
                text-align: right;
                width: 258px;
            }
        </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <span class="style4"><strong> 
        <asp:Label ID="lblTitulo" runat="server" Text="Consultar Login"></asp:Label>
    </strong> &nbsp;</span><br />
    <span class="style4" style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; <asp:Label ID="lblDescricao" runat="server" 
        Text=" Descrição: Permite localização dos logins de acesso ao sistema. "></asp:Label> 
        
        <br /><br />
    </span>

    <table width="850px" align="left">
        <tr>
            <td class="style7"> &nbsp; </td>    
            <td class="style8" align="right"> &nbsp;<span class="style6"><strong>Filtro</strong></span></td>
            <td> &nbsp; </td>
            <td> &nbsp; </td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td class="style9"> Login:</td>
            <td> 
                <asp:TextBox ID="txtLogin" runat="server" Width="200px" MaxLength="10"></asp:TextBox>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td class="style9"> Nome:</td>
            <td> 
                <asp:TextBox ID="txtNome" runat="server" Width="200px" MaxLength="50"></asp:TextBox>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style7"> &nbsp;</td>    
            <td style="text-align: right" class="style8"> &nbsp; </td>
            <td> 
                <asp:Button ID="btnLocalizar" runat="server" onclick="btnLocalizar_Click" 
                    Text="Localizar" Width="97px" />
&nbsp;<asp:Button ID="btnLimpar" runat="server" Text="Limpar" Width="97px" 
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

   <table border="0" width="850px" align="center">
        <tr>
            <td> 
                <asp:GridView ID="gridLogin" runat="server" CellPadding="4" 
                    EmptyDataText="Nenhum dado foi encontrado." ForeColor="#333333" 
                    GridLines="Horizontal" Width="90%" AutoGenerateColumns="False" 
                    BorderColor="#003399" HorizontalAlign="Center" AllowPaging="True" 
                    onpageindexchanging="gridLogin_PageIndexChanging">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="CodigoLogin" 
                            DataNavigateUrlFormatString="ManterLogin.aspx?tipo=alt&amp;cod=9" 
                            Text="Selecionar">
                        <ItemStyle Width="75px" />
                        </asp:HyperLinkField>
                        <asp:BoundField DataField="Nome" HeaderText="Nome Usuário">
                        <HeaderStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="LoginUsuario" HeaderText="Login">
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Perfil" HeaderText="Perfil">
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Email" HeaderText="E-mail">
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
