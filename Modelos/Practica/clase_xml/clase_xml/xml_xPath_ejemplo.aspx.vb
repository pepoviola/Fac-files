Imports System.Xml
Imports System.Xml.XPath

Public Class xml_xPath_ejemplo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim xpathdoc As New XPathDocument(Server.MapPath("Banco.xml"))
        Dim xNavegador As XPathNavigator
        Dim Iterator As XPathNodeIterator
        xNavegador = xpathdoc.CreateNavigator()
        Iterator = xNavegador.Select("Banco/Cuenta[child::CuentaSucursal='Barcelona']/CuentaNombre")
        While (Iterator.MoveNext())
            listbox1.Items.Add(Iterator.Current.Value)
        End While

    End Sub

End Class