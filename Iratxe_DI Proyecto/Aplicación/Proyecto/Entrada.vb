Imports Microsoft.Win32
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Registro
    Private _nombre As String

    Public Event Editar As EventHandler(Of ButtonClickEventArgs)
    Public Event Borrar As EventHandler(Of ButtonClickEventArgs)

    Property nombre As String
        Get
            Return NombreL.Text
        End Get
        Set(value As String)
            NombreL.Text = value
        End Set
    End Property

    Public Sub ClickEditar(sender As Object, e As EventArgs) Handles bEditar.Click
        RaiseEvent Editar(Me, New ButtonClickEventArgs(Me.nombre))
    End Sub

    Public Sub ClickBorrar(sender As Object, e As EventArgs) Handles bBorrar.Click
        RaiseEvent Borrar(Me, New ButtonClickEventArgs(Me.nombre))
    End Sub
End Class

Public Class ButtonClickEventArgs
    Inherits EventArgs

    Public Sub New(nombre As String)
        Me.nombrePulsado = nombre
    End Sub

    Public ReadOnly Property nombrePulsado As String
End Class
