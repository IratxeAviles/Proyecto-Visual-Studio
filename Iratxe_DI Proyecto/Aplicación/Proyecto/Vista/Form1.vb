Public Class Form1
    ReadOnly Property TamFuenteIncial As Double = 14.0
    ReadOnly Property PaddingInicial As Double = 2.0
    ReadOnly Property MarginTBBotonInicial As Double = 2.0
    ReadOnly Property MarginLRBotonInicial As Double = 2.0
    ReadOnly Property AnchoInicial As Double = 430.0
    ReadOnly Property AltoInicial As Double = 465.0


    Function CambioAltura(unidad As Double) As Double
        Return IIf(Me.Height * unidad / AltoInicial < unidad, unidad, Me.Height * unidad / AltoInicial)
    End Function

    Function CambioAnchura(unidad As Double) As Double
        Return IIf(Me.Width * unidad / AnchoInicial < unidad, unidad, Me.Width * unidad / AnchoInicial)
    End Function

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim tamFuente As Double = cambioAltura(TamFuenteIncial)
        Dim padding As Double = cambioAnchura(PaddingInicial)
        Dim marginTB As Double = cambioAltura(MarginTBBotonInicial)
        Dim marginLR As Double = cambioAnchura(MarginLRBotonInicial)

        For Each control In PrincipalTLP.Controls
            control.Font = New System.Drawing.Font("Segoe UI Symbol; style=Bold", tamFuente)
        Next

        PrincipalTLP.Padding = New Padding(padding)
        LogoPB.Margin = New Padding(marginLR, marginTB, marginLR, marginTB)
        RegistroB.Margin = New Padding(marginLR, marginTB, marginLR, marginTB)
        IniciarSesionB.Margin = New Padding(marginLR, marginTB, marginLR, marginTB)
        EscalarImagen()
    End Sub

    Private Sub EscalarImagen()
        Dim nuevaAnchura As Integer = CInt(LogoPB.Width * 1.1)
        Dim nuevaAltura As Integer = CInt(LogoPB.Height * 1.1)

        Dim imagenOriginal As Image = LogoPB.Image
        Dim imagenEscalada As New Bitmap(imagenOriginal, nuevaAnchura, nuevaAltura)

        LogoPB.Image = imagenEscalada
    End Sub

    Private Sub IniciarSesionB_Click(sender As Object, e As EventArgs) Handles IniciarSesionB.Click
        Dim SecondForm As New Sesion
        SecondForm.Show()
        SecondForm.TituloL.Text = "Inicio de Sesión"
        SecondForm.NContrasenaL.Hide()
        SecondForm.NContrasenaTB.Hide()
        SecondForm.GuardarB.Text = "Iniciar sesión"
        Me.Hide()
    End Sub

    Private Sub RegistroB_Click(sender As Object, e As EventArgs) Handles RegistroB.Click
        Dim SecondForm As New Sesion
        SecondForm.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        Dim y As Integer = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2

        Me.Location = New Point(x, y)
    End Sub

    Private Sub PrincipalTLP_Paint(sender As Object, e As PaintEventArgs) Handles PrincipalTLP.Paint

    End Sub

    Private Sub LogoPB_Click(sender As Object, e As EventArgs) Handles LogoPB.Click

    End Sub
    Private Sub FormPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Dim resultado As DialogResult = MessageBox.Show("¿Cerrar aplicación?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resultado = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class
