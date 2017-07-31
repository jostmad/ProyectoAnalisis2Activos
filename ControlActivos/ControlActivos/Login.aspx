<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ControlActivos.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>INGRESO</title>
    <link href="Content/login.css" rel="stylesheet" />
</head>
<body >
    
   
    

        <div id="content"> 
<div id="izquierda"> 
   
    <div id="formu">
     <form  method="post" runat="server" >
   
    <h2>Ingresar</h2>
    <br>
      
         
         Usuario:<br>          
            <asp:TextBox ID="txt_cedula"  TextMode="Number" runat="server"></asp:TextBox><br>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"   
ControlToValidate="txt_cedula" ErrorMessage="Digite Cedula de Usuario"   
ForeColor="Red"></asp:RequiredFieldValidator>    
         <br>
        
            Contraseña:<br>
         
         <asp:TextBox ID="txt_pass" TextMode="Password" runat="server"></asp:TextBox>  <br>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"   
ControlToValidate="txt_pass" ErrorMessage="Digite Contraseña "   
ForeColor="Red"></asp:RequiredFieldValidator> 
  <br><br>
         <asp:Button ID="b_ingresar" runat="server" Text="Ingresar" OnClick="b_ingresar_Click"  />
          <br> <br>
        <asp:Label ID="Label1" runat="server"></asp:Label> 
          </form>
        </div>
</div> 
<div id="derecha"> 

    <br />
    <br /> <br><br>
    <br />
    <br /><br />
   <img src="Images/logo2.png" height="50%" />
    <h1 style="font-family:fantasy">PATRONATO NACIONAL DE LA INFANCIA</h1>
</div> 
</div> 

    </body>
</html>
