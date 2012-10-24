Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class _Default
    Inherits System.Web.UI.Page


    Dim con As SqlConnection
    Dim orden As SqlCommand
    Dim sqdr As SqlDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Profesores;User ID=uai;Password=uai")
        orden = New SqlCommand("select Apellido from Profesor", con)
        con.Open()
        sqdr = orden.ExecuteReader()
        While (sqdr.Read())
            Response.Write("<li>")
            Response.Write(sqdr("Apellido"))
        End While

        sqdr.Close()
        con.Close()

    End Sub

End Class