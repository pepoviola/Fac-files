Public Class clase4_vuelta_cookies
    Inherits System.Web.UI.Page
    Dim pepe2 As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Write((Request.Cookies("cookiePrueba").Value))
        label4.Text = Request.Cookies("cookiePrueba")("Usuario")
        label5.Text = Request.Cookies("cookiePrueba")("preferencia")
        label6.Text = Request.Cookies("cookiePrueba")("ultimaVisita")
    End Sub

End Class