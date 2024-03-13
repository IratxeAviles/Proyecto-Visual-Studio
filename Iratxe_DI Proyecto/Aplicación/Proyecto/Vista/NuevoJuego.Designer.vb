<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoJuego
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
        Me.RegistroTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.DescripcionL = New System.Windows.Forms.Label()
        Me.TituloL = New System.Windows.Forms.Label()
        Me.CancelarB = New System.Windows.Forms.Button()
        Me.GuardarB = New System.Windows.Forms.Button()
        Me.NombreTB = New System.Windows.Forms.TextBox()
        Me.GenerosL = New System.Windows.Forms.Label()
        Me.AnoL = New System.Windows.Forms.Label()
        Me.AnoNUD = New System.Windows.Forms.NumericUpDown()
        Me.GenerosTB = New System.Windows.Forms.TextBox()
        Me.DescripcionRTB = New System.Windows.Forms.RichTextBox()
        Me.RegistroTLP.SuspendLayout()
        CType(Me.AnoNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegistroTLP
        '
        Me.RegistroTLP.BackColor = System.Drawing.Color.CornflowerBlue
        Me.RegistroTLP.ColumnCount = 5
        Me.RegistroTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.RegistroTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.RegistroTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667!))
        Me.RegistroTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667!))
        Me.RegistroTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.RegistroTLP.Controls.Add(Me.NombreL, 1, 1)
        Me.RegistroTLP.Controls.Add(Me.DescripcionL, 1, 2)
        Me.RegistroTLP.Controls.Add(Me.TituloL, 0, 0)
        Me.RegistroTLP.Controls.Add(Me.CancelarB, 2, 5)
        Me.RegistroTLP.Controls.Add(Me.GuardarB, 3, 5)
        Me.RegistroTLP.Controls.Add(Me.NombreTB, 2, 1)
        Me.RegistroTLP.Controls.Add(Me.GenerosL, 1, 3)
        Me.RegistroTLP.Controls.Add(Me.AnoL, 1, 4)
        Me.RegistroTLP.Controls.Add(Me.AnoNUD, 2, 4)
        Me.RegistroTLP.Controls.Add(Me.GenerosTB, 2, 3)
        Me.RegistroTLP.Controls.Add(Me.DescripcionRTB, 2, 2)
        Me.RegistroTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RegistroTLP.Location = New System.Drawing.Point(0, 0)
        Me.RegistroTLP.Margin = New System.Windows.Forms.Padding(6)
        Me.RegistroTLP.Name = "RegistroTLP"
        Me.RegistroTLP.RowCount = 6
        Me.RegistroTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RegistroTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.RegistroTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.RegistroTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.RegistroTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.RegistroTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RegistroTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.RegistroTLP.Size = New System.Drawing.Size(1122, 908)
        Me.RegistroTLP.TabIndex = 1
        '
        'NombreL
        '
        Me.NombreL.AutoSize = True
        Me.NombreL.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold)
        Me.NombreL.Location = New System.Drawing.Point(76, 211)
        Me.NombreL.Margin = New System.Windows.Forms.Padding(6, 29, 6, 29)
        Me.NombreL.Name = "NombreL"
        Me.NombreL.Size = New System.Drawing.Size(197, 59)
        Me.NombreL.TabIndex = 1
        Me.NombreL.Text = "Nombre:"
        '
        'DescripcionL
        '
        Me.DescripcionL.AutoSize = True
        Me.DescripcionL.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold)
        Me.DescripcionL.Location = New System.Drawing.Point(76, 328)
        Me.DescripcionL.Margin = New System.Windows.Forms.Padding(6, 29, 6, 29)
        Me.DescripcionL.Name = "DescripcionL"
        Me.DescripcionL.Size = New System.Drawing.Size(265, 59)
        Me.DescripcionL.TabIndex = 3
        Me.DescripcionL.Text = "Descripción:"
        '
        'TituloL
        '
        Me.TituloL.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TituloL.AutoSize = True
        Me.RegistroTLP.SetColumnSpan(Me.TituloL, 5)
        Me.TituloL.Font = New System.Drawing.Font("Segoe UI Symbol", 25.0!, System.Drawing.FontStyle.Bold)
        Me.TituloL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TituloL.Location = New System.Drawing.Point(6, 46)
        Me.TituloL.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.TituloL.Name = "TituloL"
        Me.TituloL.Size = New System.Drawing.Size(1110, 89)
        Me.TituloL.TabIndex = 0
        Me.TituloL.Text = "Añadir Juego"
        Me.TituloL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CancelarB
        '
        Me.CancelarB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CancelarB.AutoSize = True
        Me.CancelarB.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold)
        Me.CancelarB.Location = New System.Drawing.Point(409, 773)
        Me.CancelarB.Margin = New System.Windows.Forms.Padding(6)
        Me.CancelarB.Name = "CancelarB"
        Me.CancelarB.Size = New System.Drawing.Size(228, 88)
        Me.CancelarB.TabIndex = 5
        Me.CancelarB.Text = "Cancelar"
        Me.CancelarB.UseVisualStyleBackColor = True
        '
        'GuardarB
        '
        Me.GuardarB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GuardarB.AutoSize = True
        Me.GuardarB.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold)
        Me.GuardarB.Location = New System.Drawing.Point(761, 773)
        Me.GuardarB.Margin = New System.Windows.Forms.Padding(6)
        Me.GuardarB.Name = "GuardarB"
        Me.GuardarB.Size = New System.Drawing.Size(228, 88)
        Me.GuardarB.TabIndex = 9
        Me.GuardarB.Text = "Guardar"
        Me.GuardarB.UseVisualStyleBackColor = True
        '
        'NombreTB
        '
        Me.NombreTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegistroTLP.SetColumnSpan(Me.NombreTB, 2)
        Me.NombreTB.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold)
        Me.NombreTB.Location = New System.Drawing.Point(353, 201)
        Me.NombreTB.Margin = New System.Windows.Forms.Padding(6, 19, 6, 0)
        Me.NombreTB.Name = "NombreTB"
        Me.NombreTB.Size = New System.Drawing.Size(692, 64)
        Me.NombreTB.TabIndex = 11
        '
        'GenerosL
        '
        Me.GenerosL.AutoSize = True
        Me.GenerosL.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold)
        Me.GenerosL.Location = New System.Drawing.Point(76, 521)
        Me.GenerosL.Margin = New System.Windows.Forms.Padding(6, 29, 6, 29)
        Me.GenerosL.Name = "GenerosL"
        Me.GenerosL.Size = New System.Drawing.Size(198, 59)
        Me.GenerosL.TabIndex = 12
        Me.GenerosL.Text = "Géneros:"
        '
        'AnoL
        '
        Me.AnoL.AutoSize = True
        Me.AnoL.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold)
        Me.AnoL.Location = New System.Drawing.Point(76, 638)
        Me.AnoL.Margin = New System.Windows.Forms.Padding(6, 29, 6, 29)
        Me.AnoL.Name = "AnoL"
        Me.AnoL.Size = New System.Drawing.Size(115, 59)
        Me.AnoL.TabIndex = 4
        Me.AnoL.Text = "Año:"
        '
        'AnoNUD
        '
        Me.AnoNUD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AnoNUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnoNUD.Location = New System.Drawing.Point(353, 639)
        Me.AnoNUD.Margin = New System.Windows.Forms.Padding(6)
        Me.AnoNUD.Maximum = New Decimal(New Integer() {2024, 0, 0, 0})
        Me.AnoNUD.Minimum = New Decimal(New Integer() {1950, 0, 0, 0})
        Me.AnoNUD.Name = "AnoNUD"
        Me.AnoNUD.Size = New System.Drawing.Size(340, 56)
        Me.AnoNUD.TabIndex = 16
        Me.AnoNUD.Value = New Decimal(New Integer() {1950, 0, 0, 0})
        '
        'GenerosTB
        '
        Me.GenerosTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegistroTLP.SetColumnSpan(Me.GenerosTB, 2)
        Me.GenerosTB.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold)
        Me.GenerosTB.Location = New System.Drawing.Point(353, 511)
        Me.GenerosTB.Margin = New System.Windows.Forms.Padding(6, 19, 6, 0)
        Me.GenerosTB.Name = "GenerosTB"
        Me.GenerosTB.Size = New System.Drawing.Size(692, 64)
        Me.GenerosTB.TabIndex = 18
        '
        'DescripcionRTB
        '
        Me.RegistroTLP.SetColumnSpan(Me.DescripcionRTB, 2)
        Me.DescripcionRTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescripcionRTB.Location = New System.Drawing.Point(353, 305)
        Me.DescripcionRTB.Margin = New System.Windows.Forms.Padding(6)
        Me.DescripcionRTB.Name = "DescripcionRTB"
        Me.DescripcionRTB.Size = New System.Drawing.Size(692, 181)
        Me.DescripcionRTB.TabIndex = 17
        Me.DescripcionRTB.Text = ""
        '
        'NuevoJuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 908)
        Me.Controls.Add(Me.RegistroTLP)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MinimumSize = New System.Drawing.Size(1128, 917)
        Me.Name = "NuevoJuego"
        Me.Text = "NuevoJuego"
        Me.RegistroTLP.ResumeLayout(False)
        Me.RegistroTLP.PerformLayout()
        CType(Me.AnoNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RegistroTLP As TableLayoutPanel
    Friend WithEvents NombreL As Label
    Friend WithEvents DescripcionL As Label
    Friend WithEvents AnoL As Label
    Friend WithEvents TituloL As Label
    Friend WithEvents CancelarB As Button
    Friend WithEvents GuardarB As Button
    Friend WithEvents NombreTB As TextBox
    Friend WithEvents GenerosL As Label
    Friend WithEvents AnoNUD As NumericUpDown
    Friend WithEvents GenerosTB As TextBox
    Friend WithEvents DescripcionRTB As RichTextBox
End Class
