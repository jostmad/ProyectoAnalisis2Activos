<%@ Page Title="Reportes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="ControlActivos.Reportes" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <link href="Content/forms.css" rel="stylesheet" />
    
    <div class="formrepor">
    <h1><%: Title %>.</h1><br>

    <form  action="Reportes.aspx" method="post">
   
    
    
       Usuario:<br>
       <input type="text" name="usuario"><br>
        Codigo Activo:<br>
        <input type="number" name="codigo"><br>
        Error:<br>
        <input type="number" name="error"><br>
        Comentarios:<br>
        <textarea  name="comentarios">
            </textarea><br>
        Fecha:<br>
        <input type="date" name="fecha"><br>
        <input  type="submit" value="Reportar">
  
        
        </form>
    </div>
    <hr>
    <img src="Images/pani_logo.png" />


</asp:Content>
