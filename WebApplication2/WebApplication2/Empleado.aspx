<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Empleado.aspx.vb" Inherits="WebApplication2.Empleado" %>

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
            <p><asp:TextBox ID="K_EMPLEADO" CssClass="jumbotron" runat="server"></asp:TextBox>
            <p><asp:TextBox ID="CEM_NOMBRE" runat="server"></asp:TextBox>
            <p><asp:TextBox ID="CEM_DEPTO" runat="server"></asp:TextBox>
        </div>
    </form> 
</body>
</html>
