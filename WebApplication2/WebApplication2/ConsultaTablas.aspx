<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ConsultaTablas.aspx.vb" Inherits="WebApplication2.ConsultaTablas" %>

<!DOCTYPE html>
<link rel="stylesheet" href="Content/bootstrap.min.css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            <asp:TextBox ID="texto" Text="CAT_EMPLEADOS" Visible="true" runat="server" ></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button2" runat="server" Text="Mostrar Datos" Visible ="true" />
        </div>
            <div>
            <asp:Button ID="CerrarSesion" runat="server" Text="Salir" Visible ="true" />
        </div>
        </div>
    </form>
</body>
</html>
