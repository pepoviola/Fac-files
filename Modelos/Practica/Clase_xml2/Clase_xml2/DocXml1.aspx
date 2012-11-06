<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DocXml1.aspx.vb" Inherits="Clase_xml2.DocXml1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p><font size="5"><strong>DOM: Elija un producto </strong></font></p>
    <hr width="100%" size="1" />
    <p><strong><em>Producto</em>:</strong>&nbsp;&nbsp;</p>
    <asp:DropDownList ID="dd1" runat="server"></asp:DropDownList> &nbsp;&nbsp; 
    <strong><em>Cantidad</em>:</strong>&nbsp;&nbsp;
    <asp:TextBox ID="tx1" runat="server" Width="34px" ></asp:TextBox>&nbsp;&nbsp; &nbsp;&nbsp; 
    <asp:Button ID="bt1" runat="server" Text="Enviar" Font-Bold="true" />
    <hr width="100%"  size="3"/>
    <p>
    </p>
    <p><em>Precio</em>:
    <asp:Label ID="lb1" runat="server"></asp:Label>
    </p>
    <p></p>
    <p><em>Total</em>:
    <asp:Label ID="lb2" runat="server"></asp:Label>
    </p>

    <hr width="100%" size="3" />
    </div>
    </form>
</body>
</html>
