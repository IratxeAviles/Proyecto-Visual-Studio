Imports System.ComponentModel
Imports System.Data.SQLite

Public Class NuevoJuego
    ReadOnly Property TamFuenteIncial As Double = 14.0
    ReadOnly Property PaddingInicial As Double = 2.0
    ReadOnly Property MarginTBBotonInicial As Double = 2.0
    ReadOnly Property MarginLRBotonInicial As Double = 2.0
    ReadOnly Property AnchoInicial As Double = 430.0
    ReadOnly Property AltoInicial As Double = 465.0

    Shared ventana As NuevoJuego
    Private BBDD As New BBDD()


    Function CambioAltura(unidad As Double) As Double
        Return IIf(Me.Height * unidad / AltoInicial < unidad, unidad, Me.Height * unidad / AltoInicial)
    End Function

    Function CambioAnchura(unidad As Double) As Double
        Return IIf(Me.Width * unidad / AnchoInicial < unidad, unidad, Me.Width * unidad / AnchoInicial)
    End Function

    Private Sub Sesion_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim tamFuente As Double = CambioAltura(TamFuenteIncial)
        Dim padding As Double = CambioAnchura(PaddingInicial)
        Dim marginTB As Double = CambioAltura(MarginTBBotonInicial)
        Dim marginLR As Double = CambioAnchura(MarginLRBotonInicial)

        For Each control In RegistroTLP.Controls
            control.Font = New System.Drawing.Font("Segoe UI Symbol; style=Bold", tamFuente)
        Next


    End Sub


    Shared Function GetInstance() As NuevoJuego
        If ventana Is Nothing Then
            ventana = New NuevoJuego
        End If
        Return ventana
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles GenerosL.Click

    End Sub

    Private Sub NuevoJuego_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub GuardarB_Click(sender As Object, e As EventArgs) Handles GuardarB.Click
        If NombreTB.Text <> "" And DescripcionRTB.Text <> "" And GenerosTB.Text <> "" Then
            Dim valorNombre As String = NombreTB.Text
            Dim valorDescripcion As String = DescripcionRTB.Text
            Dim valorGenero As String = GenerosTB.Text
            Dim valorAno As Integer = AnoNUD.Value

            BBDD.NuevoJuego(valorNombre, valorGenero, valorAno, valorDescripcion)

            Me.Close()
        Else
            MsgBox("No puede haber campos vacíos", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub CancelarB_Click(sender As Object, e As EventArgs) Handles CancelarB.Click
        BarraHerramienta.MostrarBiblioteca(Biblioteca)
        Me.Close()
    End Sub

    Private Sub NuevoJuego_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Biblioteca.GetInstance().CargarDatos()
        Biblioteca.GetInstance().Show()
    End Sub
End Class