Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        edades.Enabled = False
        os.Enabled = False
    End Sub

    'Protected Sub boton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles boton.Click
    '    'valido el txt
    '    If String.IsNullOrWhiteSpace(apellido.Text) Then
    '        MsgBox("Complete con el nombre!")
    '    End If
    'End Sub

 

    'Protected Sub RadioButtonList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged


    '    'If RadioButtonList1.SelectedValue = "SI" Then
    '    '    edades.Enabled = True
    '    '    os.Enabled = True
    '    'Else
    '    '    edades.Enabled = False
    '    '    os.Enabled = False
    '    'End If
    'End Sub
End Class