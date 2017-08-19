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
    </td><td>Fecha de vencimiento<br>
                <asp:TextBox ID="txt_fechavencer" runat="server"></asp:TextBox>
                <br>
    </td><td><br>
    &nbsp;</td></tr><tr><td>Fecha:<br>
            <asp:TextBox ID="txt_fecha" runat="server" ToolTip="0000/00/00"></asp:TextBox>
            <br>

    </td><td>Garantia:<br>
                <asp:TextBox ID="txt_garantia" runat="server"></asp:TextBox>
                <br>
        
   <td> <br>
       <asp:Button ID="b_agregar" runat="server" Text="Agregar" OnClick="b_agregar_Click" />
&nbsp;<asp:Button ID="b_modificar" runat="server" OnClick="b_modificar_Click" Text="Modificar" />
            </td></tr>
        
        </form>
    </table>
    
       
    </h3>
    
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" DataSourceID="activos"
        AutoGenerateEditButton="true" DataKeyNames="codigo_activo">
                <Columns>
                <asp:CommandField ShowSelectButton="false" />
            </Columns>
        </asp:GridView>
       
        <asp:SqlDataSource 
  ID="activos"
  runat="server" 
  ConnectionString="Data Source=localhost;Integrated Security=SSPI;Initial Catalog=Pani"
  SelectCommand="SELECT * FROM activos"   UpdateCommand="UPDATE activos set fecha_compra = @fecha_compra, fecha_vencerse=@fecha_vencerse, garantia = @garantia,
	marca = @marca, usuario = @usuario, modelo =@modelo, so= @so, oficina=@oficina, region=@region where codigo_activo = @codigo_activo;"/> 
     <br />
        <br />

        </div>
</asp:Content>
