<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Visualizacion.aspx.cs" Inherits="Examen2.Visualizacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/Estilos.css" rel="stylesheet" />
    <link href="CSS/Estilos%20botones.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Total de encuestas</h2> 
            <asp:GridView ID="GridViewReporte" runat="server"></asp:GridView><br />  <br />  
            <h2>Encuestas de personas con carro</h2>  
            <asp:GridView ID="GridView1" runat="server"></asp:GridView><br />  <br />  
            <h2>Encuestas de personas sin carro</h2> 
            <asp:GridView ID="GridView2" runat="server"></asp:GridView><br />  <br />  
            <asp:Button ID="Bregresar" class="button" runat="server" Text="Regresar" OnClick="Bregresar_Click" />
        </div>
    </form>
</body>
</html>
