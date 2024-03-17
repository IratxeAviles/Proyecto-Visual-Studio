<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PrincipalTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.BienvenidoL = New System.Windows.Forms.Label()
        Me.LogoPB = New System.Windows.Forms.PictureBox()
        Me.RegistroB = New System.Windows.Forms.Button()
        Me.IniciarSesionB = New System.Windows.Forms.Button()
        Me.PrincipalTLP.SuspendLayout()
        CType(Me.LogoPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrincipalTLP
        '
        Me.PrincipalTLP.AutoSize = True
        Me.PrincipalTLP.BackColor = System.Drawing.Color.CornflowerBlue
        Me.PrincipalTLP.ColumnCount = 5
        Me.PrincipalTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PrincipalTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PrincipalTLP.Controls.Add(Me.BienvenidoL, 1, 2)
        Me.PrincipalTLP.Controls.Add(Me.LogoPB, 1, 1)
        Me.PrincipalTLP.Controls.Add(Me.RegistroB, 1, 3)
        Me.PrincipalTLP.Controls.Add(Me.IniciarSesionB, 3, 3)
        Me.PrincipalTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrincipalTLP.Location = New System.Drawing.Point(0, 0)
        Me.PrincipalTLP.Name = "PrincipalTLP"
        Me.PrincipalTLP.RowCount = 4
        Me.PrincipalTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307!))
        Me.PrincipalTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.23077!))
        Me.PrincipalTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.30769!))
        Me.PrincipalTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.76923!))
        Me.PrincipalTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PrincipalTLP.Size = New System.Drawing.Size(724, 646)
        Me.PrincipalTLP.TabIndex = 0
        '
        'BienvenidoL
        '
        Me.BienvenidoL.AutoSize = True
        Me.PrincipalTLP.SetColumnSpan(Me.BienvenidoL, 3)
        Me.BienvenidoL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BienvenidoL.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BienvenidoL.Location = New System.Drawing.Point(112, 367)
        Me.BienvenidoL.Name = "BienvenidoL"
        Me.BienvenidoL.Size = New System.Drawing.Size(500, 79)
        Me.BienvenidoL.TabIndex = 2
        Me.BienvenidoL.Text = "¡Bienvenid@ a tu biblioteca de juegos!"
        Me.BienvenidoL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LogoPB
        '
        Me.LogoPB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalTLP.SetColumnSpan(Me.LogoPB, 3)
        Me.LogoPB.Image = Global.Proyecto.My.Resources.Resources.Video_Game_Controller_Logo_Graphics_69127373_1_1695671731
        Me.LogoPB.ImageLocation = ""
        Me.LogoPB.InitialImage = CType(resources.GetObject("LogoPB.InitialImage"), System.Drawing.Image)
        Me.LogoPB.Location = New System.Drawing.Point(112, 52)
        Me.LogoPB.Name = "LogoPB"
        Me.LogoPB.Size = New System.Drawing.Size(500, 312)
        Me.LogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPB.TabIndex = 3
        Me.LogoPB.TabStop = False
        '
        'RegistroB
        '
        Me.RegistroB.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RegistroB.AutoSize = True
        Me.RegistroB.BackColor = System.Drawing.Color.SteelBlue
        Me.RegistroB.Font = New System.Drawing.Font("Segoe UI Symbol", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistroB.Location = New System.Drawing.Point(109, 523)
        Me.RegistroB.Margin = New System.Windows.Forms.Padding(0)
        Me.RegistroB.Name = "RegistroB"
        Me.RegistroB.Padding = New System.Windows.Forms.Padding(5)
        Me.RegistroB.Size = New System.Drawing.Size(136, 45)
        Me.RegistroB.TabIndex = 4
        Me.RegistroB.Text = "Registrarse"
        Me.RegistroB.UseVisualStyleBackColor = False
        '
        'IniciarSesionB
        '
        Me.IniciarSesionB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IniciarSesionB.AutoSize = True
        Me.IniciarSesionB.BackColor = System.Drawing.Color.SteelBlue
        Me.IniciarSesionB.Font = New System.Drawing.Font("Segoe UI Symbol", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IniciarSesionB.Location = New System.Drawing.Point(418, 523)
        Me.IniciarSesionB.Margin = New System.Windows.Forms.Padding(0)
        Me.IniciarSesionB.Name = "IniciarSesionB"
        Me.IniciarSesionB.Padding = New System.Windows.Forms.Padding(5)
        Me.IniciarSesionB.Size = New System.Drawing.Size(158, 45)
        Me.IniciarSesionB.TabIndex = 1
        Me.IniciarSesionB.Text = "Iniciar Sesión"
        Me.IniciarSesionB.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(724, 646)
        Me.Controls.Add(Me.PrincipalTLP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(740, 685)
        Me.MinimumSize = New System.Drawing.Size(740, 685)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PrincipalTLP.ResumeLayout(False)
        Me.PrincipalTLP.PerformLayout()
        CType(Me.LogoPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrincipalTLP As TableLayoutPanel
    Friend WithEvents IniciarSesionB As Button
    Friend WithEvents BienvenidoL As Label
    Friend WithEvents LogoPB As PictureBox
    Friend WithEvents RegistroB As Button
End Class
