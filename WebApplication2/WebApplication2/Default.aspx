<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="WebApplication2._Default" %>

<!DOCTYPE html>

<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="IniciarConexion" runat="server" Text="Iniciar Conexión" />
        <div>
            <asp:Table runat="server" ID="Tabla"></asp:Table>
        </div>
        <div>
        <asp:Label ID="Detalles" runat="server" Text="Inicio" />
        </div>
        <div>
            <asp:TextBox ID="texto" Text="CAT_EMPLEADOS" Visible="false" runat="server" ></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button2" runat="server" Text="Mostrar Datos" Visible ="False" />
        </div>
    </form>
</body>
</html>
