<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Edicion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.InfoTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.editando = New Proyecto.EditarJuego()
        Me.InfoTLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'InfoTLP
        '
        Me.InfoTLP.ColumnCount = 1
        Me.InfoTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InfoTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.InfoTLP.Controls.Add(Me.editando, 0, 0)
        Me.InfoTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoTLP.Location = New System.Drawing.Point(0, 0)
        Me.InfoTLP.Name = "InfoTLP"
        Me.InfoTLP.RowCount = 1
        Me.InfoTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InfoTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450.0!))
        Me.InfoTLP.Size = New System.Drawing.Size(800, 450)
        Me.InfoTLP.TabIndex = 0
        '
        'editando
        '
        Me.editando.ano = 1950
        Me.editando.descripcion = "Descripción"
        Me.editando.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editando.genero = "Géneros"
        Me.editando.Location = New System.Drawing.Point(3, 3)
        Me.editando.Name = "editando"
        Me.editando.nombre = "Nombre"
        Me.editando.Size = New System.Drawing.Size(794, 444)
        Me.editando.TabIndex = 0
        '
        'Edicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.InfoTLP)
        Me.Name = "Edicion"
        Me.Text = "Edicion"
        Me.InfoTLP.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InfoTLP As TableLayoutPanel
    Friend WithEvents editando As EditarJuego
End Class
