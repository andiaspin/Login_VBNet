<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BARANGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUPPLIERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PENJUALANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEMBELIANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANHARIANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANBULANANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UTILTYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GANTIPASSWORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.panel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MASTERToolStripMenuItem, Me.TRANSAKSIToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.UTILTYToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(704, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.panel1, Me.panel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 308)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(704, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BARANGToolStripMenuItem, Me.SUPPLIERToolStripMenuItem, Me.USERToolStripMenuItem})
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.MASTERToolStripMenuItem.Text = "MASTER"
        '
        'BARANGToolStripMenuItem
        '
        Me.BARANGToolStripMenuItem.Name = "BARANGToolStripMenuItem"
        Me.BARANGToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.BARANGToolStripMenuItem.Text = "BARANG"
        '
        'SUPPLIERToolStripMenuItem
        '
        Me.SUPPLIERToolStripMenuItem.Name = "SUPPLIERToolStripMenuItem"
        Me.SUPPLIERToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.SUPPLIERToolStripMenuItem.Text = "SUPPLIER"
        '
        'USERToolStripMenuItem
        '
        Me.USERToolStripMenuItem.Name = "USERToolStripMenuItem"
        Me.USERToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.USERToolStripMenuItem.Text = "USER"
        '
        'TRANSAKSIToolStripMenuItem
        '
        Me.TRANSAKSIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PENJUALANToolStripMenuItem, Me.PEMBELIANToolStripMenuItem})
        Me.TRANSAKSIToolStripMenuItem.Name = "TRANSAKSIToolStripMenuItem"
        Me.TRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.TRANSAKSIToolStripMenuItem.Text = "TRANSAKSI"
        '
        'PENJUALANToolStripMenuItem
        '
        Me.PENJUALANToolStripMenuItem.Name = "PENJUALANToolStripMenuItem"
        Me.PENJUALANToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.PENJUALANToolStripMenuItem.Text = "PENJUALAN"
        '
        'PEMBELIANToolStripMenuItem
        '
        Me.PEMBELIANToolStripMenuItem.Name = "PEMBELIANToolStripMenuItem"
        Me.PEMBELIANToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.PEMBELIANToolStripMenuItem.Text = "PEMBELIAN"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LAPORANHARIANToolStripMenuItem, Me.LAPORANBULANANToolStripMenuItem})
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.LAPORANToolStripMenuItem.Text = "LAPORAN"
        '
        'LAPORANHARIANToolStripMenuItem
        '
        Me.LAPORANHARIANToolStripMenuItem.Name = "LAPORANHARIANToolStripMenuItem"
        Me.LAPORANHARIANToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.LAPORANHARIANToolStripMenuItem.Text = "LAPORAN HARIAN"
        '
        'LAPORANBULANANToolStripMenuItem
        '
        Me.LAPORANBULANANToolStripMenuItem.Name = "LAPORANBULANANToolStripMenuItem"
        Me.LAPORANBULANANToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.LAPORANBULANANToolStripMenuItem.Text = "LAPORAN BULANAN"
        '
        'UTILTYToolStripMenuItem
        '
        Me.UTILTYToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GANTIPASSWORDToolStripMenuItem})
        Me.UTILTYToolStripMenuItem.Name = "UTILTYToolStripMenuItem"
        Me.UTILTYToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.UTILTYToolStripMenuItem.Text = "UTILTY"
        '
        'GANTIPASSWORDToolStripMenuItem
        '
        Me.GANTIPASSWORDToolStripMenuItem.Name = "GANTIPASSWORDToolStripMenuItem"
        Me.GANTIPASSWORDToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.GANTIPASSWORDToolStripMenuItem.Text = "GANTI PASSWORD"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'panel1
        '
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(0, 17)
        '
        'panel2
        '
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(0, 17)
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(704, 330)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BARANGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUPPLIERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSAKSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PENJUALANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PEMBELIANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANHARIANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANBULANANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UTILTYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GANTIPASSWORDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents panel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents panel2 As System.Windows.Forms.ToolStripStatusLabel
End Class
