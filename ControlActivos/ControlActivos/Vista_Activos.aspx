<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vista_Activos.aspx.cs" Inherits="ControlActivos.Vista_Activos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:SqlDataSource 
  ID="activos"
  runat="server" 
  ConnectionString="Data Source=localhost;Integrated Security=SSPI;Initial Catalog=Pani"
  SelectCommand="SELECT * FROM activos"   /> 
    <br /><br /><br />
    <asp:GridView ID="gv_activos" runat="server" AutoGenerateColumns="false" DataKeyNames="id_activos" DataSourceID="activos">

        <Columns>

            <asp:BoundField DataField="id_activos" HeaderText="Identificador" />
            <asp:BoundField DataField="modelo" HeaderText="Modelo" />
            <asp:BoundField DataField="marca" HeaderText="Marca" />
            <asp:BoundField DataField="so" HeaderText="Sistema Operativo" />
            <asp:BoundField DataField="region" HeaderText="Región" />
            <asp:BoundField DataField="oficina" HeaderText="Oficina" />
            <asp:BoundField DataField="usuario" HeaderText="Usuario" />
            <asp:BoundField DataField="id_tipoact" HeaderText="Id tipo activo" />
            <asp:BoundField DataField="imagen" HeaderText="Imagen" />

        </Columns>

    </asp:GridView>

</asp:Content>
