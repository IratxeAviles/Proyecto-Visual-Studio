Imports Microsoft.Win32
Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Sesion
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

    Private Sub Sesion_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim tamFuente As Double = CambioAltura(TamFuenteIncial)
        Dim padding As Double = CambioAnchura(PaddingInicial)
        Dim marginTB As Double = CambioAltura(MarginTBBotonInicial)
        Dim marginLR As Double = CambioAnchura(MarginLRBotonInicial)

        For Each control In RegistroTLP.Controls
            control.Font = New System.Drawing.Font("Segoe UI Symbol; style=Bold", tamFuente)
        Next

        RegistroTLP.Padding = New Padding(padding)
        UsuarioL.Margin = New Padding(marginLR, marginTB, marginLR, marginTB)
        UsuarioTB.Margin = New Padding(marginLR, marginTB, marginLR, marginTB)
        ContrasenaL.Margin = New Padding(marginLR, marginTB, marginLR, marginTB)
        ContrasenaTB.Margin = New Padding(marginLR, marginTB, marginLR, marginTB)
        NContrasenaL.Margin = New Padding(marginLR, marginTB, marginLR, marginTB)
        NContrasenaTB.Margin = New Padding(marginLR, marginTB, marginLR, marginTB)
        CancelarB.Margin = New Padding(marginLR, marginTB, marginLR, marginTB)
        GuardarB.Margin = New Padding(marginLR, marginTB, marginLR, marginTB)
    End Sub

    Private Sub CancelarB_Click(sender As Object, e As EventArgs) Handles CancelarB.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub GuardarB_Click(sender As Object, e As EventArgs) Handles GuardarB.Click
        Dim valorUsuario As String = UsuarioTB.Text
        Dim valorContrasena As String = ContrasenaTB.Text
        If UsuarioTB.Text <> "" And ContrasenaTB.Text <> "" Then
            If TituloL.Text = "Registro" Then
                If ContrasenaTB.Text = NContrasenaTB.Text Then
                    Try
                        Dim conexion As SQLiteConnection = New SQLiteConnection(My.Settings.conexion)
                        Dim consulta As String = "SELECT USUARIO FROM USUARIOS WHERE USUARIO = @usuario"
                        conexion.Open()
                        Dim cmd As New SQLiteCommand(consulta, conexion)
                        cmd.Parameters.AddWithValue("@usuario", valorUsuario)
                        Dim lector As SQLiteDataReader = cmd.ExecuteReader()
                        Dim resultado As String = ""

                        While lector.Read()
                            resultado &= lector.GetString(0) & " ya existe en la base de datos." & vbLf
                        End While

                        lector.Close()
                        conexion.Close()
                        If resultado <> "" Then
                            MsgBox(resultado)
                        Else
                            Try
                                Dim sql As String = "INSERT INTO USUARIOS (USUARIO, CONTRASENA) VALUES (@usuario, @contrasena);"
                                Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion)
                                con.Open()
                                Dim cmd2 As New SQLiteCommand(sql, con)
                                cmd2.Parameters.Add("@usuario", DbType.String).Value = valorUsuario
                                cmd2.Parameters.Add("@contrasena", DbType.String).Value = valorContrasena
                                cmd2.ExecuteNonQuery()

                                MsgBox("Usuario guardado correctamente")

                                RemoveHandler Me.FormClosing, AddressOf FormPrincipal_FormClosing
                                lector.Close()
                                conexion.Close()
                                Dim Aplicacion As New BarraHerramienta
                                Aplicacion.Show()
                                Me.Close()
                            Catch ex As Exception
                                MsgBox("Error al guardar usuario", MsgBoxStyle.Critical, "Error")
                            End Try
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    MsgBox("Contraseña repetida incorrectamente", MsgBoxStyle.Critical, "Error")
                End If
            Else
                Try
                    Dim conexion As SQLiteConnection = New SQLiteConnection(My.Settings.conexion)
                    Dim consulta As String = "SELECT USUARIO, CONTRASENA FROM USUARIOS WHERE USUARIO = @usuario"
                    conexion.Open()
                    Dim cmd As New SQLiteCommand(consulta, conexion)
                    cmd.Parameters.AddWithValue("@usuario", valorUsuario)
                    Dim lector As SQLiteDataReader = cmd.ExecuteReader()
                    Dim resultado As String = ""

                    Dim encontrado As Boolean = False

                    While lector.Read()
                        If lector.GetString(0) = valorUsuario Then
                            encontrado = True
                            resultado &= "Bienvenido " & valorUsuario & vbLf
                            Exit While
                        End If
                    End While

                    If Not encontrado Then
                        MsgBox("El usuario no esta registrado", MsgBoxStyle.Critical, "Error")
                    Else
                        If lector.GetString(1) = valorContrasena Then
                            RemoveHandler Me.FormClosing, AddressOf FormPrincipal_FormClosing
                            lector.Close()
                            conexion.Close()
                            Dim Aplicacion As New BarraHerramienta
                            Aplicacion.Show()
                            Me.Close()
                        Else
                            MsgBox("Contraseña incorrecta", MsgBoxStyle.Critical, "Error")
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MsgBox("No puede haber campos vacíos", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Private Sub ContrasenaTB_TextChanged(sender As Object, e As EventArgs) Handles ContrasenaTB.TextChanged

    End Sub

    Private Sub TuFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        Dim y As Integer = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2

        Me.Location = New Point(x, y)
    End Sub

    Private Sub FormPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Form1.Show()
        End If
    End Sub

    Private Sub TituloL_Click(sender As Object, e As EventArgs) Handles TituloL.Click

    End Sub
End Class