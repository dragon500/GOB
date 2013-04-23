<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DemoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpedienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpedienteJudicialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExploradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilitariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DemoToolStripMenuItem, Me.ExpedienteToolStripMenuItem, Me.LibrosToolStripMenuItem, Me.BusquedaToolStripMenuItem, Me.ReporteToolStripMenuItem, Me.UtilitariosToolStripMenuItem, Me.MantenimientoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(848, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DemoToolStripMenuItem
        '
        Me.DemoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroDeUsuariosToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.DemoToolStripMenuItem.Name = "DemoToolStripMenuItem"
        Me.DemoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.DemoToolStripMenuItem.Text = "Sistema"
        '
        'RegistroDeUsuariosToolStripMenuItem
        '
        Me.RegistroDeUsuariosToolStripMenuItem.Name = "RegistroDeUsuariosToolStripMenuItem"
        Me.RegistroDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegistroDeUsuariosToolStripMenuItem.Text = "Registro de usuarios"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ExpedienteToolStripMenuItem
        '
        Me.ExpedienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExpedienteJudicialToolStripMenuItem})
        Me.ExpedienteToolStripMenuItem.Name = "ExpedienteToolStripMenuItem"
        Me.ExpedienteToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ExpedienteToolStripMenuItem.Text = "Libro"
        '
        'ExpedienteJudicialToolStripMenuItem
        '
        Me.ExpedienteJudicialToolStripMenuItem.Name = "ExpedienteJudicialToolStripMenuItem"
        Me.ExpedienteJudicialToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ExpedienteJudicialToolStripMenuItem.Text = "Expediente Judicial"
        '
        'LibrosToolStripMenuItem
        '
        Me.LibrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExploradorToolStripMenuItem})
        Me.LibrosToolStripMenuItem.Name = "LibrosToolStripMenuItem"
        Me.LibrosToolStripMenuItem.Size = New System.Drawing.Size(135, 20)
        Me.LibrosToolStripMenuItem.Text = "LibrosBusquedaDemo"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RegistroToolStripMenuItem.Text = "Registro"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(149, 6)
        '
        'ExploradorToolStripMenuItem
        '
        Me.ExploradorToolStripMenuItem.Name = "ExploradorToolStripMenuItem"
        Me.ExploradorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExploradorToolStripMenuItem.Text = "Explorador"
        '
        'BusquedaToolStripMenuItem
        '
        Me.BusquedaToolStripMenuItem.Name = "BusquedaToolStripMenuItem"
        Me.BusquedaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.BusquedaToolStripMenuItem.Text = "Busqueda"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'UtilitariosToolStripMenuItem
        '
        Me.UtilitariosToolStripMenuItem.Name = "UtilitariosToolStripMenuItem"
        Me.UtilitariosToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.UtilitariosToolStripMenuItem.Text = "Utilitarios"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Demo1.My.Resources.Resources.foto_ace199_ori
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(848, 477)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DemoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LibrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExploradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpedienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusquedaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilitariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpedienteJudicialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
