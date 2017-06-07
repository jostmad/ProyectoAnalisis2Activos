<%@ Page Title="Activos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Activos.aspx.cs" Inherits="ControlActivos.Activos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/forms.css" rel="stylesheet" />
    <div class="contact">
    <h2><%: Title %>.</h2>
    <h3>Agregar Activos.</h3>
    
    <table class="formagre">
    <form  action="Activos.aspx" method="post">
   
    
        <tr><td>
       Codigo:<br>
        <input type="number" name="codigo"><br>
        </td><td>
            Modelo:<br>
    <input type="text" name="modelo"><br>
    </td><td>
            Marca:<br>
        <input type="text" name="marca"><br>
    </td></tr><tr><td>
            S.O.:<br>
        <input type="text" name="so"><br>
    </td><td>Región:<br>
        <input type="text" name="region"><br>
    </td><td>Oficina:<br>
        <input type="text" name="oficina"><br>
    </td><tr><td>Usuario:<br>
        <input type="number" name="usuario"><br>
    </td><td>Tipo Activo:<br>
        <input type="number" name="tipoact"><br>
    </td><td>Imagen:<br>
    <INPUT id="oFile" type="file" runat="server" NAME="oFile">

    </td></tr><tr><td>Fecha:<br>
        <input type="date" name="fecha"><br>

    </td><td>Garantia:<br>
        <input type="number" name="garantia"><br>
        
   <td> <br><input  type="submit" value="Agregar">
    </td></tr>
        
        </form>
    </table>
    <hr>
    

    <h3>Buscar Activo. <input type="number" name="codigoBus"><input  type="submit" value="Buscar"></h3>
    
    <hr>

        </div>
</asp:Content>
