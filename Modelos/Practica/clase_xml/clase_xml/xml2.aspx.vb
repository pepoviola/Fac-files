Imports System.Xml
Public Class xml2
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim miLector As New XmlTextReader(Server.MapPath("inventario2.xml"))
        Dim n As Integer
        While (miLector.Read())
            Response.Write(miLector.NodeType.ToString() + " : " + miLector.Name + " : " + miLector.Value + "<br/>")
            If miLector.HasAttributes Then
                For n = 0 To (miLector.AttributeCount - 1)
                    miLector.MoveToAttribute(n)
                    Response.Write(miLector.NodeType.ToString() + " : " + miLector.Name + " : " + miLector.Value + "<br/>")
                Next
                miLector.MoveToElement()
            End If
        End While
        miLector.Close()
    End Sub

End Class