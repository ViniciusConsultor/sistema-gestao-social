<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="Teste.aspx.cs" Inherits="ProjetoTela.Telas.Teste" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Chart ID="Chart1" runat="server" DataSourceID="ObjectDataSource1">
        <Series>
            <asp:Series ChartType="Pie" Name="Series1" YValuesPerPoint="6">
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server">
    </asp:ObjectDataSource>
</asp:Content>
