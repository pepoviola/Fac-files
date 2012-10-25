
<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Crear_xml.aspx.vb" Inherits="clase_xml.Crear_xml" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crear XML clientes.xml</title>
</head>
<body>
    <form id="form1"  runat="server">
    <div>
    <asp:Label ID="label1" runat="server"> Nombre: </asp:Label> &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="NombreTxt" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="label2" runat="server"> Apellido: </asp:Label> &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="ApellidoTxt" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="label3" runat="server"> Direccion: </asp:Label> &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="DirTxt" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Button ID="btn1" runat="server" text="Crear Doc"/>


    </div>
    </form>
</body>
</html>
