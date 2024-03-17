Imports Microsoft.VisualBasic.Devices

Public Class BarraHerramienta
    Shared ventana As BarraHerramienta

    Private Sub BarraHerramienta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        Dim y As Integer = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2

        Me.Location = New Point(x, y)
        Me.WindowState = FormWindowState.Maximized


        MostrarBiblioteca(Biblioteca.GetInstance())
    End Sub

    Shared Function GetInstance() As BarraHerramienta
        If ventana Is Nothing Then
            ventana = New BarraHerramienta
        End If
        Return ventana
    End Function

    Sub InsertarVentana(ventana As Form)
        ' Comprobar si hay un formulario secundario activo
        If Me.ActiveMdiChild IsNot Nothing Then
            ' Cerrar y quitar el formulario secundario activo
            Me.ActiveMdiChild.Hide()
        End If

        ventana.MdiParent = Me
        ventana.Dock = DockStyle.Fill
        ventana.Show()
    End Sub


    Sub MostrarBiblioteca(ventana As Form)
        If ventana Is Nothing OrElse ventana.IsDisposed Then
            ventana = New Biblioteca()
        End If

        ventana.MdiParent = Me
        ventana.Dock = DockStyle.Fill
        ventana.Show()
    End Sub

    Sub MostrarNuevoJuego(ventana As Form)
        If ventana Is Nothing OrElse ventana.IsDisposed Then
            ventana = New NuevoJuego()
        End If
        If Me.ActiveMdiChild IsNot Nothing Then
            Me.ActiveMdiChild.Hide()
        End If

        ventana.MdiParent = Me
        ventana.Dock = DockStyle.Fill
        ventana.Show()
    End Sub

    Sub MostrarEdicion(ventana As Form, juego As Juego)
        InsertarVentana(Edicion.GetInstance(juego))

    End Sub


    Private Sub AñadirJuegoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirJuegoToolStripMenuItem.Click
        MostrarNuevoJuego(NuevoJuego.GetInstance)
    End Sub

    Private Sub PerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BibliotecaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BibliotecaToolStripMenuItem.Click
        MostrarBiblioteca(Biblioteca.GetInstance())
    End Sub

    Private Sub BarraHerramienta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub
End Class