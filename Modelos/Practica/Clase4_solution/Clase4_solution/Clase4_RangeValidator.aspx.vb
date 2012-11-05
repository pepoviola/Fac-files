Public Class Clase4_RangeValidator
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Enviar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Enviar.Click
        'MsgBox("hola")
        Dim fecha As New RangeValidator
        fecha.MinimumValue = Now.Date
        fecha.MaximumValue = Now.Date.AddMonths(3)
        Dim comparador As New CompareValidator
        comparador.ControlToValidate = "Calendar1"
        comparador.ControlToCompare = "comparador"
        comparador.Operator = ValidationCompareOperator.Equal
        label1.Text = "Fecha es: " & comparador.IsValid()




    End Sub
End Class