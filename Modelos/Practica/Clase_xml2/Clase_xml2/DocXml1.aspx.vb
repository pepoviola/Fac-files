Imports System.Xml
Public Class DocXml1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not (IsPostBack) Then
            Dim miDoc As New XmlDocument()
            Dim miLector As New XmlTextReader(Server.MapPath("Inventario2.xml"))
            miLector.WhitespaceHandling = WhitespaceHandling.None
            miDoc.Load(miLector)
            Session.Add("DocumentoEnSesion", miDoc)
            Dim n As Integer
            For n = 0 To (miDoc.DocumentElement.ChildNodes.Count - 1)
                dd1.Items.Add(miDoc.DocumentElement.ChildNodes(n).ChildNodes(1).InnerText)

            Next n
        End If
    End Sub

    Protected Sub bt1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt1.Click
        Dim n As Integer
        Dim cantidad As Integer = 1
        Dim precio As Double
        Dim miDoc As New XmlDocument()
        miDoc = Session("DocumentoEnSesion")
        n = dd1.SelectedIndex
        cantidad = Integer.Parse(tx1.Text)
        precio = Double.Parse(miDoc.DocumentElement.ChildNodes(n).ChildNodes(2).InnerText)
        lb1.Text = FormatCurrency(precio)
        lb2.Text = FormatCurrency(precio * cantidad)

    End Sub
End Class