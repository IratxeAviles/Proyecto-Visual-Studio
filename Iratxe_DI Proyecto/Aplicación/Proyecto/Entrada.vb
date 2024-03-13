Imports Microsoft.Win32
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Registro
    Private _nombre As String

    Public Event ClickEditar()
    Public Event ClickBorrar()

    Property nombre As String
        Get
            Return NombreL.Text
        End Get
        Set(value As String)
            NombreL.Text = value
        End Set
    End Property


    Private Sub bEditar_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        RaiseEvent ClickEditar()
    End Sub

    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        RaiseEvent ClickBorrar()
    End Sub
End Class
