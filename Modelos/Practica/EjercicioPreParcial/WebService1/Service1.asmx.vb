Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class Service1
    Inherits System.Web.Services.WebService

    <WebMethod(Description:="Mayor a 40 y no OS")> _
    Public Function MayoryNoOS40() As String
        Return "Pedir un Subsidio"
    End Function


    <WebMethod(Description:="Menor a 40 y OS")> _
    Public Function Menor40yOS() As String
        Return "No tiene derecho a pedir subsidio"
    End Function
End Class