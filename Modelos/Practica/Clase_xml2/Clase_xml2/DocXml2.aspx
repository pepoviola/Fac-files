<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DocXml2.aspx.vb" Inherits="Clase_xml2.DocXml2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <font size="4"><strong>XPathNavigator</strong></font>
    <hr width="100%" size="1" />
    <p><strong><font size="3"><em>&nbsp;</em>Seleccione un numero de cuenta</font></strong>&nbsp;
    <asp:DropDownList ID="dd1" runat="server"></asp:DropDownList></p>
    <p><em><strong>saldo cuenta</strong></em>:
    <asp:TextBox ID="tx1" runat="server"></asp:TextBox></p>
    </div>
    </form>
</body>
</html>
