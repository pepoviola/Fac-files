Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Ej2
    Inherits System.Web.UI.Page

    Dim con As SqlConnection
    Dim cantidad As SqlCommand
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Profesores;User ID=uai;Password=uai")
        con.Open()
        cantidad = New SqlCommand("select count(*) from profesor", con)
        Resultado.Text = cantidad.ExecuteScalar()
        con.Close()

    End Sub

End Class