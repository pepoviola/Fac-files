Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Ej5
    Inherits System.Web.UI.Page
    Dim con As SqlConnection
    Dim orden As SqlCommand
    Dim cmss As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub actualizar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles actualizar.Click
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Profesores;User ID=uai;Password=uai")
        Dim cmss = "update Profesor set Asignatura = @Asignatura where Apellido = @Apellido"
        orden = New SqlCommand(cmss, con)
        orden.Parameters.AddWithValue("@Asignatura", Asignatura.Text)
        orden.Parameters.AddWithValue("@Apellido", apellido.Text)

        con.Open()
        orden.ExecuteNonQuery()

        con.Close()
    End Sub
End Class