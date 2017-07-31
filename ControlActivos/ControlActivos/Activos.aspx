<%@ Page Title="Activos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Activos.aspx.cs" Inherits="ControlActivos.Activos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/forms.css" rel="stylesheet" />
    <div class="contact">
    <h2><%: Title %>.</h2>
    <h3>Agregar Activos.</h3>
    
        <asp:Label ID="Label1" runat="server"></asp:Label>
    <hr>
    

    <table class="formagre">
    <form  action="Activos.aspx" method="post">
   
    
        <tr><td>
       Codigo:<br>
            <asp:TextBox ID="txt_codigo" runat="server"></asp:TextBox>
            <br>
        </td><td>
            Modelo:<br>
                <asp:TextBox ID="txt_modelo" runat="server"></asp:TextBox>
                <br>
    </td><td>
            Marca:<br>
                <asp:TextBox ID="txt_marca" runat="server"></asp:TextBox>
                <br>
    </td></tr><tr><td>
            S.O.:<br>
            <asp:TextBox ID="txt_so" runat="server"></asp:TextBox>
            <br>
    </td><td>Región:<br>
                <asp:TextBox ID="txt_region" runat="server"></asp:TextBox>
                <br>
    </td><td>Oficina:<br>
                <asp:TextBox ID="txt_oficina" runat="server"></asp:TextBox>
                <br>
    </td><tr><td>Usuario:<br>
            <asp:TextBox ID="txt_usuario" runat="server"></asp:TextBox>
            <br>
    </td><td>Tipo Activo:<br>
                <asp:TextBox ID="txt_tipoactivo" runat="server"></asp:TextBox>
                <br>
    </td><td>Imagen:<br>
    <INPUT id="oFile" type="file" runat="server" NAME="oFile">

    </td></tr><tr><td>Fecha:<br>
            <asp:TextBox ID="txt_fecha" runat="server"></asp:TextBox>
            <br>

    </td><td>Garantia:<br>
                <asp:TextBox ID="txt_garantia" runat="server"></asp:TextBox>
                <br>
        
   <td> <br>
       <asp:Button ID="b_agregar" runat="server" Text="Agregar" OnClick="b_agregar_Click" />
&nbsp;</td></tr>
        
        </form>
    </table>
    

        
        <input type="button" value="Ver" onClick="location.href = 'Vista_Activos.aspx' "></h3>
    
    <hr>

        </div>
</asp:Content>
