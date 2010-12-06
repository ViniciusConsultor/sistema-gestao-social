<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MessageBox.ascx.cs" Inherits="BRQ.SI.SCB.UI.Web.UserControls.MessageBox" %>

<%@ Register src="~/View/UserControls/MessageBoxTypes/AlertBox.ascx" tagname="AlertBox" tagprefix="SPG" %>
<%@ Register src="~/View/UserControls/MessageBoxTypes/ErrorBox.ascx" tagname="ErrorBox" tagprefix="SPG" %>
<%@ Register src="~/View/UserControls/MessageBoxTypes/InformationBox.ascx" tagname="InformationBox" tagprefix="SPG" %>
<%@ Register src="~/View/UserControls/MessageBoxTypes/QuestionBox.ascx" tagname="QuestionBox" tagprefix="SPG" %>
<%@ Register src="~/View/UserControls/MessageBoxTypes/SuccessBox.ascx" tagname="SuccessBox" tagprefix="SPG" %>

<SPG:AlertBox ID="AlertBox1" runat="server" />
<SPG:ErrorBox ID="ErrorBox1" runat="server" />
<SPG:InformationBox ID="InformationBox1" runat="server" />
<SPG:QuestionBox ID="QuestionBox1" runat="server" />
<SPG:SuccessBox ID="SuccessBox1" runat="server" />