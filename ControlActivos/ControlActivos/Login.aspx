<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ControlActivos.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>INGRESO</title>
    <link href="Content/login.css" rel="stylesheet" />
</head>
<body >
    
    <form id="form1" runat="server">
    

        <div id="content"> 
<div id="izquierda"> 
   
    <div id="formu">
     <form  method="post" >
   
    <h2>Ingresar</h2>
    <br>
       Cedula:<br><br>
       <input type="number" name="cedula" style="background-color:transparent; color:white"><br>
        <br><br>Contraseña:<br/><br>
        <input type="password" name="pass" style="background-color:transparent; color:white"><br>
        <br><br><br>
        <input  type="submit" value="Ingresar" style="background-color:transparent; color:white">
  <br><br>
         
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

    </form>
</body>
</html>
