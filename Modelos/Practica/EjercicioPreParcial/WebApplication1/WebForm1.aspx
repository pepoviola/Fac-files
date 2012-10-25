<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">
    Protected Sub habilitar(ByVal sender As Object, ByVal e As System.EventArgs)
        If RadioButtonList1.SelectedValue = "SI" Then
            edades.Enabled = True
            os.Enabled = True
        Else
            edades.Enabled = False
            os.Enabled = False
        End If
    End Sub
    
    Protected Sub enviar_click(ByVal sender As Object, ByVal e As System.EventArgs)
        'If String.IsNullOrWhiteSpace(apellido.Text) Then
        'MsgBox("Complete el apellido")
        'Else
        Session("Apellido") = apellido.Text
        Session("Edad") = edades.SelectedValue
        Session("Fuma") = RadioButtonList1.SelectedValue
        Session("OS") = os.Checked
            
        Response.Redirect("vuelta.aspx")
        'End If
    End Sub
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>IDA</title>
</head>
<body>
    <form id="form1" runat="server" >
    <div>
    <asp:Label ID="lbFuma" runat="server" Text="Apellido"></asp:Label>
    <br />
    <asp:TextBox ID="apellido" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator runat="server" ControlToValidate="apellido" Text="rellene este campo" ID="rfv"></asp:RequiredFieldValidator>
<br />
<br />
fuma ?
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="habilitar">
        <asp:ListItem Text="SI" Value="SI"></asp:ListItem>
        <asp:ListItem Text="NO" Value="NO"></asp:ListItem>
        </asp:RadioButtonList>
      

<br />
<br />
Rango de edad: <asp:DropDownList ID="edades" runat="server">
                <asp:ListItem Value="menor" Text="entre 16 y 40" ></asp:ListItem>
                <asp:ListItem Value="mayor" Text="Más de 40" ></asp:ListItem>
                </asp:DropDownList>

<br />
<br />
Con obra social?  <asp:CheckBox  runat="server" ID="os" />

<br />
<br />

<asp:Button ID="boton" Text="Enviar" runat="server" onclick="enviar_click"/>

                    
                    

    </div>
    </form>
</body>
</html>
