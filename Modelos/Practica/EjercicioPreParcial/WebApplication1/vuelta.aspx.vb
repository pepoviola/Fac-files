Public Class vuelta
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        apellido.Text = "apellido: " + Session("Apellido")
        edad.Text = "edad: " + Session("Edad")
        fuma.Text = "Fuma ?: " + Session("Fuma")
        If Session("OS") Then
            os.Text = "Tiene obra social"
        Else
            os.Text = "No tiene obra social"
        End If

        'llamo al web service
        If Session("Fuma") = "SI" Then
            Dim operacion As New localhost.Service1
            If Session("Edad") = "mayor" AndAlso Not Session("OS") Then


                retorno.Text = operacion.MayoryNoOS40()
            ElseIf Session("Edad") = "menor" AndAlso Session("OS") Then
                retorno.Text = operacion.Menor40yOS()

            End If
        End If

    End Sub

End Class