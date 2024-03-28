<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="Examen2.Reportes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="CSS/Estilos.css" rel="stylesheet" />
    <link href="CSS/Estilos%20botones.css" rel="stylesheet" />
    <title>Reportes de encuestas</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="topnav">
            <a class="active" href="Principal.aspx">Inicio</a>
            <a href="Registro.aspx">Registro</a>
            <a href="Reportes.aspx">Reportes</a>
        </div>
        <h1>REPORTES DE ENCUESTAS</h1>
        <div>
            Presione en el boton para generar las estadisticas<br />
            <br />
            <asp:Button ID="Button1" Class="button" runat="server" Text="GENERAR REPORTE" OnClick="Button1_Click" /><br />
            <br />

        </div>
    </form>
</body>
</html>
