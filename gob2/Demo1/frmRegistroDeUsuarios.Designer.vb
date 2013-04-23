<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroDeUsuarios
    Inherits Demo1.frmPlantilla

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre de usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(172, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 33)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Clave"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 33)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(183, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 33)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tipo"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreUsuario.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreUsuario.Location = New System.Drawing.Point(252, 105)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(245, 40)
        Me.txtNombreUsuario.TabIndex = 0
        '
        'txtClave
        '
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClave.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(252, 151)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(162, 40)
        Me.txtClave.TabIndex = 1
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"ADMINISTRADOR", "REGISTRADOR"})
        Me.cmbTipo.Location = New System.Drawing.Point(252, 197)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(245, 41)
        Me.cmbTipo.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(252, 244)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(428, 165)
        Me.txtDescripcion.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Button1.Location = New System.Drawing.Point(702, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 113)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 30.0!)
        Me.Label7.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label7.Location = New System.Drawing.Point(118, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(379, 48)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Registro de usuarios"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Button2.Location = New System.Drawing.Point(702, 296)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 113)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "&Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmRegistroDeUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(842, 428)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmRegistroDeUsuarios"
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtNombreUsuario, 0)
        Me.Controls.SetChildIndex(Me.txtClave, 0)
        Me.Controls.SetChildIndex(Me.cmbTipo, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
