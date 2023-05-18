<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LaboratorioNo14._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 align="center">BIBLIOTECA DE MÚSICA</h1>
        <p class="lead" align="center">Aplicación para llevar el control de albumes y canciones de una biblioteca de música</p>
        <p class="lead" align="center">ALBÚM</p>
        <p class="lead" align="center">Título de albúm:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxTituloAlbum" runat="server" Width="220px"></asp:TextBox>
        </p>
        <p class="lead" align="center">Artista del albúm:&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxNombreArtista" runat="server" Width="215px"></asp:TextBox>
        </p>
        <p class="lead" align="center">Fecha publiación:&nbsp;
            <asp:TextBox ID="TextBoxFechaPublicacion" runat="server" Width="212px"></asp:TextBox>
        </p>
        <p class="lead" align="center">CANCIONES</p>
        <p class="lead" align="center">Nombre canción:&nbsp;
            <asp:TextBox ID="TextBoxNombreCancion" runat="server" Width="210px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
        <p class="lead" align="center">Tiempo de duración:&nbsp;
            <asp:TextBox ID="TextBoxTiempoDuracion" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="ButtonAgregarCancion" runat="server" class="btn btn-warning btn-lg" Text="Agregar Canción" OnClick="ButtonAgregarCancion_Click" />
        </p>
        <p class="lead" align="center"><asp:Button ID="ButtonAgregarAlbum" align="center" runat="server" class="btn btn-primary btn-lg" Text="Agregar Albúm" OnClick="ButtonAgregarAlbum_Click" />
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
