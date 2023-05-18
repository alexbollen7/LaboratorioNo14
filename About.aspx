<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="LaboratorioNo14.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 align="center">EDICIÓN DE ALBÚM</h2>
    <h3>Ingrese el nombre del albúm a editar:
        <asp:TextBox ID="TextBoxBuscar" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="ButtonBuscarAlbum" runat="server" Height="36px" OnClick="ButtonBuscarAlbum_Click" Text="Buscar" Width="99px" />
&nbsp;<asp:Label ID="LabelAlbum" runat="server" Text="[ALBUM]"></asp:Label>
    </h3>
    <p>Titulo del albúm:
        <asp:TextBox ID="TextBoxTituloAlbum" runat="server"></asp:TextBox>
    </p>
    <p>Artista de albúm:
        <asp:TextBox ID="TextBoxNombreArtista" runat="server"></asp:TextBox>
    </p>
    <p>Fecha de publicación:
        <asp:TextBox ID="TextBoxFechaPublicacion" runat="server"></asp:TextBox>
    </p>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonActualizar" runat="server" Enabled="False" OnClick="ButtonActualizar_Click" Text="Actualizar" />
    </p>
    </asp:Content>
