<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControlActivos._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
       
        <h1><img src="Images/logo.png" /> PANI</h1>

    </div>

    <div class="row">
        <div class="col-md-4">
            <p>
                Ingreso de empleados para reportar un activo inactivo o dañado.    
            </p>
            <p>
                <a class="btn btn-default" href="Reportes.aspx">Reportes &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <p>
                Ingreso de usuarios para usu del sistema.
            </p>
            <p>
                <a class="btn btn-default" href="Usuarios.aspx">Usuarios &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <p>
                Ingresar activos,modificarlos,etc.
            </p>
            <p>
                <a class="btn btn-default" href="Activos.aspx">Activos &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
