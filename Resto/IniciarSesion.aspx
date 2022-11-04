<%@ Page Title="Iniciar Sesion"  MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="Resto.IniciarSesion" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mx-auto">
       
        <div class="mx-auto">
            <h3>Usuario</h3>
            <asp:TextBox ID="Usuario" runat="server" ></asp:TextBox>
        </div >
        <div class="mx-auto">
            <h3>Contraseña</h3>
            <asp:TextBox ID="Contra" runat="server"></asp:TextBox>
        </div>
        <div class="mx-auto">
            <asp:Button ID="IniciarSesionbtn" runat="server" OnClick="IniciarSesion_Click" Text="Iniciar " CssClass="btn btn-primary mx-auto" />
        </div>
    </div>
    
    
    
</asp:Content>
