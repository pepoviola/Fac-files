
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Ej4
    Inherits System.Web.UI.Page

    Dim con As SqlConnection
    Dim orden As SqlCommand


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ejecutar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ejecutar.Click

        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Profesores;User ID=uai;Password=uai")
        Dim Str As String = "select Asignatura from Profesor where Apellido = @apellido"
        orden = New SqlCommand(Str, con)
        orden.Parameters.AddWithValue("@apellido", apellido.text)
        con.Open()
        resultado.Text = orden.ExecuteScalar()

    End Sub
End Class