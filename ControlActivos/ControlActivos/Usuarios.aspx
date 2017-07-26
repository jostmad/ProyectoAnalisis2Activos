<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="ControlActivos.Usuarios" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <link href="Content/forms.css" rel="stylesheet" />
    
   
    

    <div class="formrepor">
    <h1><%: Title %>.</h1><br>

    <form  action="Usuarios.aspx" method="post">
   
    
    
       Usuario:<br>
       <input type="text" name="usuario"><br>
        Codigo Activo:<br>
        <input type="number" name="codigo"><br>
        Telefono:<br>
        <input type="number" name="telefono"><br>
        Estado<br>
        <input type="text" name="estado"><br>
       
        <input  type="submit" value="Agregar">
  
        
        </form>
    </div>




</asp:Content>
