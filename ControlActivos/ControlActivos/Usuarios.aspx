<%@ Page Title="Usuarios" EnableEventValidation="false" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="ControlActivos.Usuarios" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <link href="Content/forms.css" rel="stylesheet" />
    
   
    

    <div class="formrepor">
    <h1><%: Title %>.</h1>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br>

    <form  action="Usuarios.aspx" method="post">
   
    
    
        Nombre:<br>
        <asp:TextBox ID="txt_usua" runat="server"></asp:TextBox>
        <br>
        Cédula:<br>
        <asp:TextBox ID="txt_cedu" runat="server"></asp:TextBox>
        <br>
        Contraseña:<br>
        <asp:TextBox ID="txt_pass" runat="server"></asp:TextBox>
        <br>
        Tipo de Rol<br>
        <asp:TextBox ID="txt_rol" runat="server"></asp:TextBox>
        <br>
       
        &nbsp;</form>
        <asp:Button ID="b_modificar" runat="server" OnClick="b_modificar_Click" Text="Modificar" />
    </div>




</asp:Content>
