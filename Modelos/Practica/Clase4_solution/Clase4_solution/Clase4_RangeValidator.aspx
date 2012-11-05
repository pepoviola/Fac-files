<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Clase4_RangeValidator.aspx.vb" Inherits="Clase4_solution.Clase4_RangeValidator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
  <asp:Label ID="label1" Text="Seleccione una fecha para la reunion, no mayor a 3 meses desde hoy"
  runat="server" />
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <br /><br />
    <asp:Button ID="Enviar" Text="enviar" OnClick="Enviar_Click" runat="server" />

      </div>
    </form>
</body>
</html>
