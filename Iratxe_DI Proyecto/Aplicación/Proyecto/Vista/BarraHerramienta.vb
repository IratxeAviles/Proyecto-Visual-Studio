Public Class BarraHerramienta

    Private Sub BarraHerramienta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        Dim y As Integer = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2

        Me.Location = New Point(x, y)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized


        MostrarBiblioteca(Biblioteca.GetInstance())
    End Sub


    Sub MostrarBiblioteca(ventana As Form)
        If ventana Is Nothing OrElse ventana.IsDisposed Then
            ventana = New Biblioteca()
        End If
        If Me.ActiveMdiChild IsNot Nothing Then
            Me.ActiveMdiChild.Hide()
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



    Private Sub AñadirJuegoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirJuegoToolStripMenuItem.Click
        MostrarNuevoJuego(NuevoJuego.GetInstance)
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub PerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub BibliotecaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BibliotecaToolStripMenuItem.Click
        MostrarBiblioteca(Biblioteca.GetInstance())
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class