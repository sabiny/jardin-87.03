<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmDocente.aspx.cs" Inherits="Jardin_87P1.frmDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    Bienvenido <asp:Label ID="lblLogin" runat="server" Text="Label"></asp:Label>
    <asp:LoginName ID="LoginName1" runat="server" FormatString="" ValidateRequestMode="Enabled" ViewStateMode="Enabled" Visible="False" />
<asp:LoginStatus ID="LoginStatus1" runat="server" CssClass="glyphicon-align-center" />
    <br />
    <br />
    Estudiante<br />
    <br />
    <asp:TextBox ID="txtnombreinforme" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btninforme" runat="server" Text="Realizar informe" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
</asp:Content>
