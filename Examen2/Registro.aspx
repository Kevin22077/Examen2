<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Examen2.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="CSS/Estilos.css" rel="stylesheet" />
    <link href="CSS/Estilos%20botones.css" rel="stylesheet" />
    <title>Registro de datos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="topnav">
            <a class="active" href="Principal.aspx">Inicio</a>
            <a href="Registro.aspx">Registro</a>
            <a href="Reportes.aspx">Reportes</a>
        </div>
        <h1>REGISTRAR UNA NUEVA ENCUESTA</h1>
        <div>
            <div>
                <div>
                    <label for="nombre">Nombre:</label>
                    <input type="text" id="nombre" runat="server" required />
                </div>
                <br />
                <div>
                    <label for="apellidos">Apellidos:</label>
                    <input type="text" id="apellidos" runat="server" required />
                </div>
                <br />
                <div>
                    <label for="fechaNacimiento">Fecha de Nacimiento:</label>
                    <input type="date" id="fechaNacimiento" runat="server" required />
                </div>
                <br />
                <div>
                    <label for="correo">Correo Electrónico:</label>
                    <input type="email" id="correo" runat="server" required />
                </div>
                <br />
                <div>
                    <label for="carroPropio">¿Tiene carro propio?</label>
                    <select id="carroPropio" runat="server" required>
                        <option value="">Seleccionar...</option>
                        <option value="Si">Sí</option>
                        <option value="No">No</option>
                    </select>
                </div>
                <br />
                <div>
                    <asp:Button ID="benviar" Class="button" runat="server" Text="Enviar encuesta" OnClick="benviar_Click" />
                    <asp:Button ID="bborrar" Class="button" runat="server" Text="Limpiar datos" OnClick="bborrar_Click" />
                </div>
            </div>
    </form>
</body>
</html>
