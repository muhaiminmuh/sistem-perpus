<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MENU))
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATAPEMINJAMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATABUKUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEMINJAMANBUKUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KELUARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LAPORANPEMINJAMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANBUKUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANTRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LAPORANPEMINJAMToolStripMenuItem, Me.LAPORANBUKUToolStripMenuItem, Me.LAPORANTRANSAKSIToolStripMenuItem})
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.LAPORANToolStripMenuItem.Text = "LAPORAN"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Lime
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MASTERToolStripMenuItem, Me.TRANSAKSIToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.KELUARToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1056, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATAPEMINJAMToolStripMenuItem, Me.DATABUKUToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MASTERToolStripMenuItem.Text = "MASTER"
        '
        'DATAPEMINJAMToolStripMenuItem
        '
        Me.DATAPEMINJAMToolStripMenuItem.Name = "DATAPEMINJAMToolStripMenuItem"
        Me.DATAPEMINJAMToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.DATAPEMINJAMToolStripMenuItem.Text = "DATA PEMINJAM"
        '
        'DATABUKUToolStripMenuItem
        '
        Me.DATABUKUToolStripMenuItem.Name = "DATABUKUToolStripMenuItem"
        Me.DATABUKUToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.DATABUKUToolStripMenuItem.Text = "DATA BUKU"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem2.Text = "...."
        '
        'TRANSAKSIToolStripMenuItem
        '
        Me.TRANSAKSIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PEMINJAMANBUKUToolStripMenuItem})
        Me.TRANSAKSIToolStripMenuItem.Name = "TRANSAKSIToolStripMenuItem"
        Me.TRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.TRANSAKSIToolStripMenuItem.Text = "TRANSAKSI"
        '
        'PEMINJAMANBUKUToolStripMenuItem
        '
        Me.PEMINJAMANBUKUToolStripMenuItem.Name = "PEMINJAMANBUKUToolStripMenuItem"
        Me.PEMINJAMANBUKUToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.PEMINJAMANBUKUToolStripMenuItem.Text = "PEMINJAMAN BUKU"
        '
        'KELUARToolStripMenuItem1
        '
        Me.KELUARToolStripMenuItem1.Name = "KELUARToolStripMenuItem1"
        Me.KELUARToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.KELUARToolStripMenuItem1.Text = "KELUAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(323, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PERPUSTAKAAN SUKSES JAYA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(289, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(429, 296)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'LAPORANPEMINJAMToolStripMenuItem
        '
        Me.LAPORANPEMINJAMToolStripMenuItem.Name = "LAPORANPEMINJAMToolStripMenuItem"
        Me.LAPORANPEMINJAMToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.LAPORANPEMINJAMToolStripMenuItem.Text = "LAPORAN PEMINJAM"
        '
        'LAPORANBUKUToolStripMenuItem
        '
        Me.LAPORANBUKUToolStripMenuItem.Name = "LAPORANBUKUToolStripMenuItem"
        Me.LAPORANBUKUToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.LAPORANBUKUToolStripMenuItem.Text = "LAPORAN BUKU"
        '
        'LAPORANTRANSAKSIToolStripMenuItem
        '
        Me.LAPORANTRANSAKSIToolStripMenuItem.Name = "LAPORANTRANSAKSIToolStripMenuItem"
        Me.LAPORANTRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.LAPORANTRANSAKSIToolStripMenuItem.Text = "LAPORAN TRANSAKSI"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1056, 553)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATAPEMINJAMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATABUKUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSAKSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PEMINJAMANBUKUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KELUARToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LAPORANPEMINJAMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANBUKUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANTRANSAKSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
