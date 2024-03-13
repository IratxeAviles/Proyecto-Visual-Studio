<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.RegistroTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.bBorrar = New System.Windows.Forms.Button()
        Me.bEditar = New System.Windows.Forms.Button()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.RegistroTLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'RegistroTLP
        '
        Me.RegistroTLP.AutoSize = True
        Me.RegistroTLP.BackColor = System.Drawing.Color.CornflowerBlue
        Me.RegistroTLP.ColumnCount = 3
        Me.RegistroTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RegistroTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.RegistroTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.RegistroTLP.Controls.Add(Me.bBorrar, 2, 0)
        Me.RegistroTLP.Controls.Add(Me.bEditar, 1, 0)
        Me.RegistroTLP.Controls.Add(Me.NombreL, 0, 0)
        Me.RegistroTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RegistroTLP.Location = New System.Drawing.Point(0, 0)
        Me.RegistroTLP.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.RegistroTLP.Name = "RegistroTLP"
        Me.RegistroTLP.RowCount = 1
        Me.RegistroTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RegistroTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.RegistroTLP.Size = New System.Drawing.Size(1160, 167)
        Me.RegistroTLP.TabIndex = 0
        '
        'bBorrar
        '
        Me.bBorrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bBorrar.AutoSize = True
        Me.bBorrar.BackColor = System.Drawing.Color.SteelBlue
        Me.bBorrar.Font = New System.Drawing.Font("Segoe UI Symbol", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBorrar.Location = New System.Drawing.Point(932, 36)
        Me.bBorrar.Margin = New System.Windows.Forms.Padding(20, 19, 20, 19)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Padding = New System.Windows.Forms.Padding(20, 19, 20, 19)
        Me.bBorrar.Size = New System.Drawing.Size(166, 94)
        Me.bBorrar.TabIndex = 3
        Me.bBorrar.Text = "Borrar"
        Me.bBorrar.UseVisualStyleBackColor = False
        '
        'bEditar
        '
        Me.bEditar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bEditar.AutoSize = True
        Me.bEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.bEditar.Font = New System.Drawing.Font("Segoe UI Symbol", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEditar.Location = New System.Drawing.Point(642, 36)
        Me.bEditar.Margin = New System.Windows.Forms.Padding(20, 19, 20, 19)
        Me.bEditar.Name = "bEditar"
        Me.bEditar.Padding = New System.Windows.Forms.Padding(20, 19, 20, 19)
        Me.bEditar.Size = New System.Drawing.Size(166, 94)
        Me.bEditar.TabIndex = 2
        Me.bEditar.Text = "Editar"
        Me.bEditar.UseVisualStyleBackColor = False
        '
        'NombreL
        '
        Me.NombreL.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NombreL.AutoSize = True
        Me.NombreL.Font = New System.Drawing.Font("Segoe UI Symbol", 10.0!, System.Drawing.FontStyle.Bold)
        Me.NombreL.Location = New System.Drawing.Point(6, 65)
        Me.NombreL.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.NombreL.Name = "NombreL"
        Me.NombreL.Size = New System.Drawing.Size(121, 37)
        Me.NombreL.TabIndex = 4
        Me.NombreL.Text = "Nombre"
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.RegistroTLP)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MinimumSize = New System.Drawing.Size(824, 133)
        Me.Name = "Registro"
        Me.Size = New System.Drawing.Size(1160, 167)
        Me.RegistroTLP.ResumeLayout(False)
        Me.RegistroTLP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RegistroTLP As TableLayoutPanel
    Friend WithEvents bBorrar As Button
    Friend WithEvents bEditar As Button
    Friend WithEvents NombreL As Label
End Class
