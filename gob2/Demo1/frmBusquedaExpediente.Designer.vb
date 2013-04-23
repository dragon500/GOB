<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaExpediente
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
        Me.cmbTitulo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstvLibros = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnEliminarLibro = New System.Windows.Forms.Button()
        Me.btnDetalles = New System.Windows.Forms.Button()
        Me.btnEliminarLibro2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 33)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Titulo"
        '
        'cmbTitulo
        '
        Me.cmbTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTitulo.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.cmbTitulo.FormattingEnabled = True
        Me.cmbTitulo.Location = New System.Drawing.Point(124, 90)
        Me.cmbTitulo.Name = "cmbTitulo"
        Me.cmbTitulo.Size = New System.Drawing.Size(262, 41)
        Me.cmbTitulo.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 28.0!)
        Me.Label3.ForeColor = System.Drawing.Color.LightCoral
        Me.Label3.Location = New System.Drawing.Point(116, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(322, 46)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Búsqueda de Acta"
        '
        'lstvLibros
        '
        Me.lstvLibros.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.lstvLibros.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvLibros.FullRowSelect = True
        Me.lstvLibros.GridLines = True
        Me.lstvLibros.Location = New System.Drawing.Point(7, 256)
        Me.lstvLibros.MultiSelect = False
        Me.lstvLibros.Name = "lstvLibros"
        Me.lstvLibros.Size = New System.Drawing.Size(722, 158)
        Me.lstvLibros.TabIndex = 17
        Me.lstvLibros.UseCompatibleStateImageBehavior = False
        Me.lstvLibros.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Titulo"
        Me.ColumnHeader6.Width = 73
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CodReferencia"
        Me.ColumnHeader1.Width = 105
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "CodLibro"
        Me.ColumnHeader2.Width = 72
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "CantFolios"
        Me.ColumnHeader3.Width = 87
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Nivel de descripción"
        Me.ColumnHeader4.Width = 141
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Nombre del Productor"
        Me.ColumnHeader5.Width = 161
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Forma de Ingreso"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Caracteristicas Fisicas"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "N° correlativo de Libro"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "N° correlativo Folio"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "N° Estante"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "N° Nivel"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Fecha de Descripción"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.btnBuscar.Location = New System.Drawing.Point(532, 136)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(108, 40)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Blue
        Me.lblTotal.Location = New System.Drawing.Point(701, 417)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(30, 33)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Text = "0"
        '
        'btnEliminarLibro
        '
        Me.btnEliminarLibro.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.btnEliminarLibro.Location = New System.Drawing.Point(12, 420)
        Me.btnEliminarLibro.Name = "btnEliminarLibro"
        Me.btnEliminarLibro.Size = New System.Drawing.Size(179, 44)
        Me.btnEliminarLibro.TabIndex = 20
        Me.btnEliminarLibro.Text = "&Eliminar libro 1"
        Me.btnEliminarLibro.UseVisualStyleBackColor = True
        '
        'btnDetalles
        '
        Me.btnDetalles.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.btnDetalles.Location = New System.Drawing.Point(370, 420)
        Me.btnDetalles.Name = "btnDetalles"
        Me.btnDetalles.Size = New System.Drawing.Size(179, 44)
        Me.btnDetalles.TabIndex = 21
        Me.btnDetalles.Text = "&Mostrar detalles"
        Me.btnDetalles.UseVisualStyleBackColor = True
        '
        'btnEliminarLibro2
        '
        Me.btnEliminarLibro2.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.btnEliminarLibro2.Location = New System.Drawing.Point(191, 420)
        Me.btnEliminarLibro2.Name = "btnEliminarLibro2"
        Me.btnEliminarLibro2.Size = New System.Drawing.Size(179, 44)
        Me.btnEliminarLibro2.TabIndex = 22
        Me.btnEliminarLibro2.Text = "&Eliminar libro 2"
        Me.btnEliminarLibro2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 33)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Nombre"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(191, 209)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(323, 26)
        Me.TextBox1.TabIndex = 24
        Me.TextBox1.Text = " "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 33)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Codigo Libro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 33)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Fecha"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(191, 144)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(323, 26)
        Me.TextBox2.TabIndex = 27
        Me.TextBox2.Text = " "
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(191, 177)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(323, 26)
        Me.TextBox3.TabIndex = 28
        Me.TextBox3.Text = " "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Button1.Location = New System.Drawing.Point(532, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 40)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "&Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Button2.Location = New System.Drawing.Point(532, 201)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 40)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "&Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmBusquedaExpediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(741, 476)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEliminarLibro2)
        Me.Controls.Add(Me.btnDetalles)
        Me.Controls.Add(Me.btnEliminarLibro)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lstvLibros)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbTitulo)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmBusquedaExpediente"
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.cmbTitulo, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.lstvLibros, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.lblTotal, 0)
        Me.Controls.SetChildIndex(Me.btnEliminarLibro, 0)
        Me.Controls.SetChildIndex(Me.btnDetalles, 0)
        Me.Controls.SetChildIndex(Me.btnEliminarLibro2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.TextBox3, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbTitulo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstvLibros As System.Windows.Forms.ListView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnEliminarLibro As System.Windows.Forms.Button
    Friend WithEvents btnDetalles As System.Windows.Forms.Button
    Friend WithEvents btnEliminarLibro2 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
