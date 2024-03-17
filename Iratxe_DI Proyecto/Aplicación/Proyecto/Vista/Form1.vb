Public Class Form1

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

    Private Sub FormPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Dim resultado As DialogResult = MessageBox.Show("¿Cerrar aplicación?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resultado = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class
