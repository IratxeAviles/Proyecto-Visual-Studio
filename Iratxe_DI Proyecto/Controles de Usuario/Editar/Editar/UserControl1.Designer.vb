<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarJuego
    Inherits System.Windows.Forms.UserControl

    'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.DatosDGV = New System.Windows.Forms.DataGridView()
        Me.ControlTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.DescripcionRTB = New System.Windows.Forms.RichTextBox()
        Me.GeneroTB = New System.Windows.Forms.TextBox()
        Me.NombreTB = New System.Windows.Forms.TextBox()
        Me.AnoNUD = New System.Windows.Forms.NumericUpDown()
        Me.AnyoL = New System.Windows.Forms.Label()
        Me.GeneroL = New System.Windows.Forms.Label()
        Me.TituloL = New System.Windows.Forms.Label()
        Me.DescripcionL = New System.Windows.Forms.Label()
        Me.Cancelarb = New System.Windows.Forms.Button()
        Me.GuardarB = New System.Windows.Forms.Button()
        CType(Me.DatosDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ControlTLP.SuspendLayout()
        CType(Me.AnoNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatosDGV
        '
        Me.DatosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatosDGV.Location = New System.Drawing.Point(0, 0)
        Me.DatosDGV.Name = "DatosDGV"
        Me.DatosDGV.Size = New System.Drawing.Size(800, 450)
        Me.DatosDGV.TabIndex = 0
        '
        'ControlTLP
        '
        Me.ControlTLP.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ControlTLP.ColumnCount = 5
        Me.ControlTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ControlTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ControlTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ControlTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ControlTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ControlTLP.Controls.Add(Me.DescripcionRTB, 2, 4)
        Me.ControlTLP.Controls.Add(Me.GeneroTB, 2, 2)
        Me.ControlTLP.Controls.Add(Me.NombreTB, 2, 1)
        Me.ControlTLP.Controls.Add(Me.AnoNUD, 2, 3)
        Me.ControlTLP.Controls.Add(Me.AnyoL, 1, 3)
        Me.ControlTLP.Controls.Add(Me.GeneroL, 1, 2)
        Me.ControlTLP.Controls.Add(Me.TituloL, 1, 1)
        Me.ControlTLP.Controls.Add(Me.DescripcionL, 1, 4)
        Me.ControlTLP.Controls.Add(Me.Cancelarb, 2, 5)
        Me.ControlTLP.Controls.Add(Me.GuardarB, 3, 5)
        Me.ControlTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlTLP.Location = New System.Drawing.Point(0, 0)
        Me.ControlTLP.Name = "ControlTLP"
        Me.ControlTLP.RowCount = 6
        Me.ControlTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ControlTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ControlTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ControlTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ControlTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ControlTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ControlTLP.Size = New System.Drawing.Size(800, 450)
        Me.ControlTLP.TabIndex = 1
        '
        'DescripcionRTB
        '
        Me.DescripcionRTB.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ControlTLP.SetColumnSpan(Me.DescripcionRTB, 2)
        Me.DescripcionRTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescripcionRTB.Enabled = False
        Me.DescripcionRTB.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DescripcionRTB.Location = New System.Drawing.Point(161, 281)
        Me.DescripcionRTB.Name = "DescripcionRTB"
        Me.DescripcionRTB.Size = New System.Drawing.Size(616, 80)
        Me.DescripcionRTB.TabIndex = 11
        Me.DescripcionRTB.Text = "Descripción"
        '
        'GeneroTB
        '
        Me.GeneroTB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GeneroTB.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GeneroTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ControlTLP.SetColumnSpan(Me.GeneroTB, 2)
        Me.GeneroTB.Enabled = False
        Me.GeneroTB.Font = New System.Drawing.Font("Segoe UI Symbol", 15.0!, System.Drawing.FontStyle.Bold)
        Me.GeneroTB.Location = New System.Drawing.Point(161, 132)
        Me.GeneroTB.Multiline = True
        Me.GeneroTB.Name = "GeneroTB"
        Me.GeneroTB.Size = New System.Drawing.Size(616, 33)
        Me.GeneroTB.TabIndex = 12
        Me.GeneroTB.Text = "Géneros"
        '
        'NombreTB
        '
        Me.NombreTB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NombreTB.BackColor = System.Drawing.Color.CornflowerBlue
        Me.NombreTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ControlTLP.SetColumnSpan(Me.NombreTB, 2)
        Me.NombreTB.Enabled = False
        Me.NombreTB.Font = New System.Drawing.Font("Segoe UI Symbol", 15.0!, System.Drawing.FontStyle.Bold)
        Me.NombreTB.Location = New System.Drawing.Point(161, 49)
        Me.NombreTB.Name = "NombreTB"
        Me.NombreTB.Size = New System.Drawing.Size(616, 27)
        Me.NombreTB.TabIndex = 13
        Me.NombreTB.Text = "Nombre"
        '
        'AnoNUD
        '
        Me.AnoNUD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AnoNUD.BackColor = System.Drawing.Color.CornflowerBlue
        Me.AnoNUD.Font = New System.Drawing.Font("Segoe UI Symbol", 15.0!, System.Drawing.FontStyle.Bold)
        Me.AnoNUD.Location = New System.Drawing.Point(161, 218)
        Me.AnoNUD.Maximum = New Decimal(New Integer() {2024, 0, 0, 0})
        Me.AnoNUD.Minimum = New Decimal(New Integer() {1950, 0, 0, 0})
        Me.AnoNUD.Name = "AnoNUD"
        Me.AnoNUD.Size = New System.Drawing.Size(83, 34)
        Me.AnoNUD.TabIndex = 10
        Me.AnoNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AnoNUD.Value = New Decimal(New Integer() {1950, 0, 0, 0})
        Me.AnoNUD.Visible = False
        '
        'AnyoL
        '
        Me.AnyoL.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AnyoL.AutoSize = True
        Me.AnyoL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnyoL.Location = New System.Drawing.Point(97, 222)
        Me.AnyoL.Name = "AnyoL"
        Me.AnyoL.Size = New System.Drawing.Size(58, 25)
        Me.AnyoL.TabIndex = 14
        Me.AnyoL.Text = "Año:"
        '
        'GeneroL
        '
        Me.GeneroL.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GeneroL.AutoSize = True
        Me.GeneroL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneroL.Location = New System.Drawing.Point(65, 136)
        Me.GeneroL.Name = "GeneroL"
        Me.GeneroL.Size = New System.Drawing.Size(90, 25)
        Me.GeneroL.TabIndex = 16
        Me.GeneroL.Text = "Género:"
        '
        'TituloL
        '
        Me.TituloL.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TituloL.AutoSize = True
        Me.TituloL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloL.Location = New System.Drawing.Point(82, 50)
        Me.TituloL.Name = "TituloL"
        Me.TituloL.Size = New System.Drawing.Size(73, 25)
        Me.TituloL.TabIndex = 17
        Me.TituloL.Text = "Titulo:"
        '
        'DescripcionL
        '
        Me.DescripcionL.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DescripcionL.AutoSize = True
        Me.DescripcionL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionL.Location = New System.Drawing.Point(23, 308)
        Me.DescripcionL.Name = "DescripcionL"
        Me.DescripcionL.Size = New System.Drawing.Size(132, 25)
        Me.DescripcionL.TabIndex = 18
        Me.DescripcionL.Text = "Descripción:"
        '
        'Cancelarb
        '
        Me.Cancelarb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancelarb.AutoSize = True
        Me.Cancelarb.BackColor = System.Drawing.Color.SteelBlue
        Me.Cancelarb.Font = New System.Drawing.Font("Segoe UI Symbol", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelarb.Location = New System.Drawing.Point(261, 385)
        Me.Cancelarb.Name = "Cancelarb"
        Me.Cancelarb.Size = New System.Drawing.Size(104, 43)
        Me.Cancelarb.TabIndex = 15
        Me.Cancelarb.Text = "Cancelar"
        Me.Cancelarb.UseVisualStyleBackColor = False
        '
        'GuardarB
        '
        Me.GuardarB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GuardarB.AutoSize = True
        Me.GuardarB.BackColor = System.Drawing.Color.SteelBlue
        Me.GuardarB.Font = New System.Drawing.Font("Segoe UI Symbol", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardarB.Location = New System.Drawing.Point(575, 385)
        Me.GuardarB.Name = "GuardarB"
        Me.GuardarB.Size = New System.Drawing.Size(98, 44)
        Me.GuardarB.TabIndex = 1
        Me.GuardarB.Text = "Guardar"
        Me.GuardarB.UseVisualStyleBackColor = False
        '
        'EditarJuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ControlTLP)
        Me.Controls.Add(Me.DatosDGV)
        Me.Name = "EditarJuego"
        Me.Size = New System.Drawing.Size(800, 450)
        CType(Me.DatosDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ControlTLP.ResumeLayout(False)
        Me.ControlTLP.PerformLayout()
        CType(Me.AnoNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DatosDGV As DataGridView
    Friend WithEvents ControlTLP As TableLayoutPanel
    Friend WithEvents GuardarB As Button
    Friend WithEvents AnoNUD As NumericUpDown
    Friend WithEvents DescripcionRTB As RichTextBox
    Friend WithEvents GeneroTB As TextBox
    Friend WithEvents NombreTB As TextBox
    Friend WithEvents AnyoL As Label
    Friend WithEvents Cancelarb As Button
    Friend WithEvents GeneroL As Label
    Friend WithEvents TituloL As Label
    Friend WithEvents DescripcionL As Label
End Class
