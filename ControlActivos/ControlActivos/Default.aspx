<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControlActivos._Default" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

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





    <br />
    <asp:SqlDataSource 
        ID="grafico1"
  runat="server" 
  ConnectionString="Data Source=localhost;Integrated Security=SSPI;Initial Catalog=Pani"
  SelectCommand="select so , count(*) as Sistemas
    from activos
group by so;"  /> 

     <asp:SqlDataSource 
        ID="grafico2"
  runat="server" 
  ConnectionString="Data Source=localhost;Integrated Security=SSPI;Initial Catalog=Pani"
  SelectCommand="select YEAR(fecha_compra) as Fecha , count(*) as Cantidad
    from activos
group by fecha_compra;"  /> 

     <asp:SqlDataSource 
        ID="grafico3"
  runat="server" 
  ConnectionString="Data Source=localhost;Integrated Security=SSPI;Initial Catalog=Pani"
  SelectCommand="select t.tipo_error as Error , count(*) as Cantidad
    from reportes r, tipo_error t where r.tipo_error=t.ti_cog_error 
group by t.tipo_error;
"  /> 

<br />
<br />
<br />

    <table>
        <tr>
            <td>
                <h4>Cantidad por SO</h4>
<asp:Chart ID="Chart1" runat="server" DataSourceID="grafico1">
    <series>
        <asp:Series Name="Series1" XValueMember="so" YValueMembers="Sistemas">
        </asp:Series>
    </series>
    <chartareas>
        <asp:ChartArea Name="ChartArea1">
        </asp:ChartArea>
    </chartareas>
</asp:Chart>

            </td>
            <td> 
                
                <h4>Compras por año</h4>
                
    <asp:Chart ID="Chart2" runat="server" DataSourceID="grafico2">
        <series>
            <asp:Series Name="Series1" XValueMember="Fecha" YValueMembers="Cantidad">
            </asp:Series>
        </series>
        <chartareas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </chartareas>
    </asp:Chart>
            </td>
            <td> 
                <h4>Top errores</h4>

    <asp:Chart ID="Chart3" runat="server" DataSourceID="grafico3">
        <series>
            <asp:Series Name="Series1" XValueMember="Error" YValueMembers="Cantidad">
            </asp:Series>
        </series>
        <chartareas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </chartareas>
    </asp:Chart>   </td>
        </tr>
    </table>



    <asp:Button ID="b_Salir" runat="server" Height="47px" onclick="b_Salir_Click"   
Text="SALIR" Width="92px" />  
</asp:Content>
