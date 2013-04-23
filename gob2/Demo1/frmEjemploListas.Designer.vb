<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjemploListas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lstDatos = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Button1.Location = New System.Drawing.Point(408, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 44)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 33)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Agregar"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(157, 96)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(245, 40)
        Me.txtNombre.TabIndex = 21
        '
        'lstDatos
        '
        Me.lstDatos.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.lstDatos.FormattingEnabled = True
        Me.lstDatos.ItemHeight = 33
        Me.lstDatos.Location = New System.Drawing.Point(47, 154)
        Me.lstDatos.Name = "lstDatos"
        Me.lstDatos.Size = New System.Drawing.Size(499, 268)
        Me.lstDatos.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 30.0!)
        Me.Label1.Location = New System.Drawing.Point(146, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 48)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Ejemplo de listas"
        '
        'frmEjemploListas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 475)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstDatos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEjemploListas"
        Me.Text = "frmEjemploListas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lstDatos As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
