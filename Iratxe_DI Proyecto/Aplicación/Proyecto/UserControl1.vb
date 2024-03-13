Public Class EditarJuego
    Private _nombre As String
    Private _genero As String
    Private _ano As Integer
    Private _descripcion As String
    Public Event ClickCancelar()
    Public Event ClickGuardar()

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
    Property ano As String
        Get
            Return AnoNUD.Value
        End Get
        Set(value As String)
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
        RaiseEvent ClickCancelar()
    End Sub

    Private Sub GuardarB_Click(sender As Object, e As EventArgs) Handles GuardarB.Click
        RaiseEvent ClickGuardar()
    End Sub

    Private Sub NombreTB_TextChanged(sender As Object, e As EventArgs) Handles NombreTB.TextChanged

    End Sub
End Class
