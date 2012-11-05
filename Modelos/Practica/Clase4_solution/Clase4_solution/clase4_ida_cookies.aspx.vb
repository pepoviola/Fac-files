Public Class WebForm1
    Inherits System.Web.UI.Page

    Dim pepe As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Cookies("cookiePrueba")("Usuario") = "perez"
        Response.Cookies("cookiePrueba")("Contraseña") = "superalumno"
        Response.Cookies("cookiePrueba")("añoscursados") = "4"
        Response.Cookies("cookiePrueba")("preferencia") = "redes"
        Response.Cookies("cookiePrueba")("ultimaVisita") = _
                            DateTime.Now.ToString
        Response.Cookies("cookiePrueba")("VariableServer") = _
                            Request.ServerVariables("HTTP_USER_AGENT")

        'para ver la coleccion en la pagina de ida
        ' probarlo deshabilitando el response.redirect

        For Each pepe In Response.Cookies("cookiePrueba").Values
            label1.text += Request.Cookies("cookiePrueba")(pepe) & "<br>"

        Next

        Response.Redirect("clase4_vuelta_cookies.aspx")
    End Sub

End Class