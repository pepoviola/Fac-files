<%@ import Namespace="System.Xml" %>
<%@ import Namespace="System.Xml.Xsl" %>


<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="xml_xslt_Ejemplo.aspx.vb" Inherits="clase_xml.xml_xslt_Ejemplo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong>Transformaciones XSLT</strong>    
        <asp:Xml ID="transformacionesXSLT" runat="server" DocumentSource="~/Banco2.xml" TransformSource="Banco.xslt"></asp:Xml>
    </div>
    </form>
</body>
</html>
