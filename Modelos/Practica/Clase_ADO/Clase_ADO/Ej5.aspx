<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Ej5.aspx.vb" Inherits="Clase_ADO.Ej5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<h3>Actualizar la asignatura del profesor</h3>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="ap" runat="server" Text="Apellido"></asp:Label> <br />
    <asp:TextBox ID="apellido" runat="server" ></asp:TextBox>

    <br /><br />
    <asp:Label ID="Label1" runat="server" Text="Asignatura"></asp:Label> <br />
    <asp:TextBox ID="Asignatura" runat="server" ></asp:TextBox>
        <br /><br />
    <asp:Button ID="actualizar" runat="server" Text="Actualizar" />
    </div>
    </form>
</body>
</html>
