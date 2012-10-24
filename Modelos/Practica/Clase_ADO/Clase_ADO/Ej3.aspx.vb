Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Ej3
    Inherits System.Web.UI.Page

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim sqdr As SqlDataReader
    Dim intfield As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    

    End Sub

    Protected Sub ejecutar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ejecutar.Click
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Profesores;User ID=uai;Password=uai")
        con.Open()
        cmd = New SqlCommand(txtquery.Text, con)

        sqdr = cmd.ExecuteReader()

        txtresultado.Text = String.Empty
        While sqdr.Read()
            txtresultado.Text &= vbNewLine
            For Me.intfield = 0 To sqdr.FieldCount - 1
                txtresultado.Text &= sqdr(intfield).ToString.PadRight(15)
            Next
        End While

    End Sub
End Class