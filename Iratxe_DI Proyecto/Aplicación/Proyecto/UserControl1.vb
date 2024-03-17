Public Class EditarJuego
    Private _nombre As String
    Private _genero As String
    Private _ano As Integer
    Private _descripcion As String

    Public Event Guardar As EventHandler(Of ButtonClickEventArgs)
    Public Event Cancelar As EventHandler(Of ButtonClickEventArgs)

    Property nombre As String
        Get
            Return NombreTB.Text
        End Get
        Set(value As String)
            NombreTB.Text = value
        End Set
    End Property
    Property genero As String
        Get
            Return GeneroTB.Text
        End Get
        Set(value As String)
            GeneroTB.Text = value
        End Set
    End Property
    Property ano As Integer
        Get
            Return AnoNUD.Value
        End Get
        Set(value As Integer)
            AnoNUD.Value = value
        End Set
    End Property
    Property descripcion As String
        Get
            Return DescripcionRTB.Text
        End Get
        Set(value As String)
            DescripcionRTB.Text = value
        End Set
    End Property

    Private Sub Cancelarb_Click(sender As Object, e As EventArgs) Handles Cancelarb.Click
        RaiseEvent Cancelar(Me, New ButtonClickEventArgs(Me.nombre))
    End Sub

    Private Sub GuardarB_Click(sender As Object, e As EventArgs) Handles GuardarB.Click
        RaiseEvent Guardar(Me, New ButtonClickEventArgs(Me.nombre))
    End Sub

    Private Sub NombreTB_TextChanged(sender As Object, e As EventArgs) Handles NombreTB.TextChanged

    End Sub

    Public Class ButtonClickEventArgs
        Inherits EventArgs

        Public Sub New(nombre As String)
            Me.nombrePulsado = nombre
        End Sub

        Public ReadOnly Property nombrePulsado As String
    End Class
End Class
