<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Ej3.aspx.vb" Inherits="Clase_ADO.Ej3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="txtquery" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Button id="ejecutar" runat="server" text="Ejecutar"/>
    <br /><br />
    <asp:TextBox ID="txtresultado" runat="server" TextMode="MultiLine"></asp:TextBox>

    </div>
    </form>
</body>
</html>
