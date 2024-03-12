<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sesion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sesion))
        Me.RegistroTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.UsuarioL = New System.Windows.Forms.Label()
        Me.ContrasenaL = New System.Windows.Forms.Label()
        Me.NContrasenaL = New System.Windows.Forms.Label()
        Me.ContrasenaTB = New System.Windows.Forms.TextBox()
        Me.NContrasenaTB = New System.Windows.Forms.TextBox()
        Me.TituloL = New System.Windows.Forms.Label()
        Me.UsuarioTB = New System.Windows.Forms.TextBox()
        Me.CancelarB = New System.Windows.Forms.Button()
        Me.GuardarB = New System.Windows.Forms.Button()
        Me.RegistroTLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'RegistroTLP
        '
        Me.RegistroTLP.BackColor = System.Drawing.Color.CornflowerBlue
        Me.RegistroTLP.ColumnCount = 9
        Me.RegistroTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.RegistroTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.RegistroTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.RegistroTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.RegistroTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.RegistroTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.RegistroTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.RegistroTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.RegistroTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.RegistroTLP.Controls.Add(Me.UsuarioL, 1, 1)
        Me.RegistroTLP.Controls.Add(Me.ContrasenaL, 1, 2)
        Me.RegistroTLP.Controls.Add(Me.NContrasenaL, 1, 3)
        Me.RegistroTLP.Controls.Add(Me.ContrasenaTB, 3, 2)
        Me.RegistroTLP.Controls.Add(Me.NContrasenaTB, 4, 3)
        Me.RegistroTLP.Controls.Add(Me.TituloL, 0, 0)
        Me.RegistroTLP.Controls.Add(Me.UsuarioTB, 2, 1)
        Me.RegistroTLP.Controls.Add(Me.CancelarB, 3, 4)
        Me.RegistroTLP.Controls.Add(Me.GuardarB, 5, 4)
        Me.RegistroTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RegistroTLP.Location = New System.Drawing.Point(0, 0)
        Me.RegistroTLP.Name = "RegistroTLP"
        Me.RegistroTLP.RowCount = 5
        Me.RegistroTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RegistroTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.RegistroTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.RegistroTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.RegistroTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RegistroTLP.Size = New System.Drawing.Size(636, 284)
        Me.RegistroTLP.TabIndex = 0
        '
        'UsuarioL
        '
        Me.UsuarioL.AutoSize = True
        Me.UsuarioL.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold)
        Me.UsuarioL.Location = New System.Drawing.Point(45, 67)
        Me.UsuarioL.Margin = New System.Windows.Forms.Padding(3, 15, 3, 15)
        Me.UsuarioL.Name = "UsuarioL"
        Me.UsuarioL.Size = New System.Drawing.Size(99, 30)
        Me.UsuarioL.TabIndex = 1
        Me.UsuarioL.Text = "Usuario:"
        '
        'ContrasenaL
        '
        Me.ContrasenaL.AutoSize = True
        Me.RegistroTLP.SetColumnSpan(Me.ContrasenaL, 2)
        Me.ContrasenaL.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ContrasenaL.Location = New System.Drawing.Point(45, 127)
        Me.ContrasenaL.Margin = New System.Windows.Forms.Padding(3, 15, 3, 15)
        Me.ContrasenaL.Name = "ContrasenaL"
        Me.ContrasenaL.Size = New System.Drawing.Size(138, 30)
        Me.ContrasenaL.TabIndex = 3
        Me.ContrasenaL.Text = "Contraseña:"
        '
        'NContrasenaL
        '
        Me.NContrasenaL.AutoSize = True
        Me.RegistroTLP.SetColumnSpan(Me.NContrasenaL, 3)
        Me.NContrasenaL.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold)
        Me.NContrasenaL.Location = New System.Drawing.Point(45, 187)
        Me.NContrasenaL.Margin = New System.Windows.Forms.Padding(3, 15, 3, 15)
        Me.NContrasenaL.Name = "NContrasenaL"
        Me.NContrasenaL.Size = New System.Drawing.Size(208, 30)
        Me.NContrasenaL.TabIndex = 4
        Me.NContrasenaL.Text = "Nueva contraseña:"
        '
        'ContrasenaTB
        '
        Me.ContrasenaTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegistroTLP.SetColumnSpan(Me.ContrasenaTB, 4)
        Me.ContrasenaTB.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ContrasenaTB.Location = New System.Drawing.Point(189, 122)
        Me.ContrasenaTB.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.ContrasenaTB.Name = "ContrasenaTB"
        Me.ContrasenaTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ContrasenaTB.Size = New System.Drawing.Size(317, 36)
        Me.ContrasenaTB.TabIndex = 7
        '
        'NContrasenaTB
        '
        Me.NContrasenaTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegistroTLP.SetColumnSpan(Me.NContrasenaTB, 4)
        Me.NContrasenaTB.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold)
        Me.NContrasenaTB.Location = New System.Drawing.Point(259, 182)
        Me.NContrasenaTB.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.NContrasenaTB.Name = "NContrasenaTB"
        Me.NContrasenaTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NContrasenaTB.Size = New System.Drawing.Size(331, 36)
        Me.NContrasenaTB.TabIndex = 8
        '
        'TituloL
        '
        Me.TituloL.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TituloL.AutoSize = True
        Me.RegistroTLP.SetColumnSpan(Me.TituloL, 9)
        Me.TituloL.Font = New System.Drawing.Font("Segoe UI Symbol", 25.0!, System.Drawing.FontStyle.Bold)
        Me.TituloL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TituloL.Location = New System.Drawing.Point(3, 3)
        Me.TituloL.Name = "TituloL"
        Me.TituloL.Size = New System.Drawing.Size(630, 46)
        Me.TituloL.TabIndex = 0
        Me.TituloL.Text = "Registro"
        Me.TituloL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UsuarioTB
        '
        Me.UsuarioTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegistroTLP.SetColumnSpan(Me.UsuarioTB, 4)
        Me.UsuarioTB.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold)
        Me.UsuarioTB.Location = New System.Drawing.Point(150, 62)
        Me.UsuarioTB.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.UsuarioTB.Name = "UsuarioTB"
        Me.UsuarioTB.Size = New System.Drawing.Size(272, 36)
        Me.UsuarioTB.TabIndex = 2
        '
        'CancelarB
        '
        Me.CancelarB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CancelarB.AutoSize = True
        Me.RegistroTLP.SetColumnSpan(Me.CancelarB, 2)
        Me.CancelarB.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold)
        Me.CancelarB.Location = New System.Drawing.Point(206, 238)
        Me.CancelarB.Name = "CancelarB"
        Me.CancelarB.Size = New System.Drawing.Size(114, 40)
        Me.CancelarB.TabIndex = 5
        Me.CancelarB.Text = "Cancelar"
        Me.CancelarB.UseVisualStyleBackColor = True
        '
        'GuardarB
        '
        Me.GuardarB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GuardarB.AutoSize = True
        Me.RegistroTLP.SetColumnSpan(Me.GuardarB, 2)
        Me.GuardarB.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold)
        Me.GuardarB.Location = New System.Drawing.Point(343, 238)
        Me.GuardarB.Name = "GuardarB"
        Me.GuardarB.Size = New System.Drawing.Size(163, 40)
        Me.GuardarB.TabIndex = 9
        Me.GuardarB.Text = "Crear usuario"
        Me.GuardarB.UseVisualStyleBackColor = True
        '
        'Sesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 284)
        Me.Controls.Add(Me.RegistroTLP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(652, 323)
        Me.Name = "Sesion"
        Me.Text = "Registro"
        Me.RegistroTLP.ResumeLayout(False)
        Me.RegistroTLP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RegistroTLP As TableLayoutPanel
    Friend WithEvents TituloL As Label
    Friend WithEvents UsuarioL As Label
    Friend WithEvents UsuarioTB As TextBox
    Friend WithEvents ContrasenaL As Label
    Friend WithEvents NContrasenaL As Label
    Friend WithEvents CancelarB As Button
    Friend WithEvents ContrasenaTB As TextBox
    Friend WithEvents NContrasenaTB As TextBox
    Friend WithEvents GuardarB As Button
End Class
