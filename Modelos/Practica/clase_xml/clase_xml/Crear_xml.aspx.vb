Imports System.Xml
Public Class Crear_xml
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn1.Click
        Dim miEscritor As New XmlTextWriter(Server.MapPath("Clientes.xml"), Nothing)
        miEscritor.Formatting = Formatting.Indented
        miEscritor.WriteStartDocument()
        miEscritor.WriteComment("escribir datos en xml")
        miEscritor.WriteStartElement("DatosClientes")
        miEscritor.WriteAttributeString("NombreTipo", "Guardar")
        miEscritor.WriteStartElement("NombreNumero", "")
        miEscritor.WriteString(NombreTxt.Text)
        miEscritor.WriteEndElement()

        miEscritor.WriteStartElement("Apellidos", "")
        miEscritor.WriteString(ApellidoTxt.Text)
        miEscritor.WriteEndElement()

        miEscritor.WriteStartElement("Direccion", "")
        miEscritor.WriteString(DirTxt.Text)
        miEscritor.WriteEndElement()

        miEscritor.WriteEndDocument()
        miEscritor.Flush()
        miEscritor.Close()


    End Sub
End Class