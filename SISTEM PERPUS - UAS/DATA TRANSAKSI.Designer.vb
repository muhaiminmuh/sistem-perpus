<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.date2 = New System.Windows.Forms.DateTimePicker()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ttotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbiaya = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.talamat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tnama_peminjam = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tlama = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kode_peminjaman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_peminjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_peminjaman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_pengembalian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.biaya_adm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_biaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ttahun = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cb2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tpenerbit = New System.Windows.Forms.TextBox()
        Me.tjudul = New System.Windows.Forms.TextBox()
        Me.tpengarang = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tkode_peminjaman = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'date2
        '
        Me.date2.Location = New System.Drawing.Point(170, 388)
        Me.date2.Name = "date2"
        Me.date2.Size = New System.Drawing.Size(164, 20)
        Me.date2.TabIndex = 127
        '
        'date1
        '
        Me.date1.Location = New System.Drawing.Point(170, 349)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(164, 20)
        Me.date1.TabIndex = 126
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(270, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(317, 24)
        Me.Label16.TabIndex = 125
        Me.Label16.Text = "PERPUSTAKAAN SUKSES JAYA"
        '
        'ttotal
        '
        Me.ttotal.Location = New System.Drawing.Point(170, 502)
        Me.ttotal.Name = "ttotal"
        Me.ttotal.Size = New System.Drawing.Size(71, 20)
        Me.ttotal.TabIndex = 124
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 468)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 13)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "BIAYA ADMINISTRASI"
        '
        'tbiaya
        '
        Me.tbiaya.Location = New System.Drawing.Point(170, 465)
        Me.tbiaya.Name = "tbiaya"
        Me.tbiaya.Size = New System.Drawing.Size(71, 20)
        Me.tbiaya.TabIndex = 123
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(21, 505)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 122
        Me.Label15.Text = "TOTAL BIAYA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 355)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 13)
        Me.Label10.TabIndex = 117
        Me.Label10.Text = "TANGGAL PEMINJAMAN"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Fuchsia
        Me.GroupBox2.Controls.Add(Me.talamat)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cb1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tnama_peminjam)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 168)
        Me.GroupBox2.TabIndex = 114
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Peminjam"
        '
        'talamat
        '
        Me.talamat.Location = New System.Drawing.Point(115, 115)
        Me.talamat.Name = "talamat"
        Me.talamat.Size = New System.Drawing.Size(71, 20)
        Me.talamat.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "ID PEMINJAM"
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(115, 25)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(140, 21)
        Me.cb1.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "NAMA PEMINJAM"
        '
        'tnama_peminjam
        '
        Me.tnama_peminjam.Location = New System.Drawing.Point(115, 70)
        Me.tnama_peminjam.Name = "tnama_peminjam"
        Me.tnama_peminjam.Size = New System.Drawing.Size(178, 20)
        Me.tnama_peminjam.TabIndex = 55
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "ALAMAT"
        '
        'tlama
        '
        Me.tlama.Location = New System.Drawing.Point(170, 428)
        Me.tlama.Name = "tlama"
        Me.tlama.Size = New System.Drawing.Size(71, 20)
        Me.tlama.TabIndex = 120
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 314)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "KODE PEMINJAMAN"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 394)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 13)
        Me.Label11.TabIndex = 118
        Me.Label11.Text = "TANGGAL PENGEMBALIAN"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode_peminjaman, Me.id_peminjam, Me.kode, Me.tanggal_peminjaman, Me.tanggal_pengembalian, Me.lama, Me.biaya_adm, Me.total_biaya})
        Me.DataGridView1.Location = New System.Drawing.Point(340, 330)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(821, 135)
        Me.DataGridView1.TabIndex = 112
        '
        'kode_peminjaman
        '
        Me.kode_peminjaman.HeaderText = "KODE PEMINJAMAN"
        Me.kode_peminjaman.Name = "kode_peminjaman"
        '
        'id_peminjam
        '
        Me.id_peminjam.HeaderText = "ID PEMINJAM"
        Me.id_peminjam.Name = "id_peminjam"
        '
        'kode
        '
        Me.kode.HeaderText = "KODE BUKU"
        Me.kode.Name = "kode"
        '
        'tanggal_peminjaman
        '
        Me.tanggal_peminjaman.HeaderText = "TANGGAL PEMINJAMAN"
        Me.tanggal_peminjaman.Name = "tanggal_peminjaman"
        '
        'tanggal_pengembalian
        '
        Me.tanggal_pengembalian.HeaderText = "TANGGAL PENGEMBALIAN"
        Me.tanggal_pengembalian.Name = "tanggal_pengembalian"
        '
        'lama
        '
        Me.lama.HeaderText = "LAMA"
        Me.lama.Name = "lama"
        '
        'biaya_adm
        '
        Me.biaya_adm.HeaderText = "BIAYA ADMINISTRASI"
        Me.biaya_adm.Name = "biaya_adm"
        '
        'total_biaya
        '
        Me.total_biaya.HeaderText = "TOTAL BIAYA"
        Me.total_biaya.Name = "total_biaya"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.ttahun)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cb2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tpenerbit)
        Me.GroupBox1.Controls.Add(Me.tjudul)
        Me.GroupBox1.Controls.Add(Me.tpengarang)
        Me.GroupBox1.Location = New System.Drawing.Point(340, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 245)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buku yang diambil"
        '
        'ttahun
        '
        Me.ttahun.Location = New System.Drawing.Point(107, 198)
        Me.ttahun.Name = "ttahun"
        Me.ttahun.Size = New System.Drawing.Size(100, 20)
        Me.ttahun.TabIndex = 59
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 201)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "TAHUN"
        '
        'cb2
        '
        Me.cb2.FormattingEnabled = True
        Me.cb2.Location = New System.Drawing.Point(107, 25)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(140, 21)
        Me.cb2.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "PENERBIT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "KODE BUKU"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "JUDUL BUKU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "PENGARANG"
        '
        'tpenerbit
        '
        Me.tpenerbit.Location = New System.Drawing.Point(107, 156)
        Me.tpenerbit.Name = "tpenerbit"
        Me.tpenerbit.Size = New System.Drawing.Size(208, 20)
        Me.tpenerbit.TabIndex = 54
        '
        'tjudul
        '
        Me.tjudul.Location = New System.Drawing.Point(107, 68)
        Me.tjudul.Name = "tjudul"
        Me.tjudul.Size = New System.Drawing.Size(208, 20)
        Me.tjudul.TabIndex = 39
        '
        'tpengarang
        '
        Me.tpengarang.Location = New System.Drawing.Point(107, 113)
        Me.tpengarang.Name = "tpengarang"
        Me.tpengarang.Size = New System.Drawing.Size(208, 20)
        Me.tpengarang.TabIndex = 40
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(722, 110)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 108
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Yellow
        Me.Button5.Location = New System.Drawing.Point(687, 291)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 111
        Me.Button5.Text = "REFRESH"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Yellow
        Me.Button4.Location = New System.Drawing.Point(722, 198)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 110
        Me.Button4.Text = "EXIT"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(722, 153)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 109
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'tkode_peminjaman
        '
        Me.tkode_peminjaman.Location = New System.Drawing.Point(170, 311)
        Me.tkode_peminjaman.Name = "tkode_peminjaman"
        Me.tkode_peminjaman.Size = New System.Drawing.Size(71, 20)
        Me.tkode_peminjaman.TabIndex = 115
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 431)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 119
        Me.Label12.Text = "LAMA "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(722, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 107
        Me.Button1.Text = "NEW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Yellow
        Me.Button6.Location = New System.Drawing.Point(722, 241)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 128
        Me.Button6.Text = "REPORT"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1172, 540)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.date2)
        Me.Controls.Add(Me.date1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ttotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tbiaya)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tlama)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.tkode_peminjaman)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbiaya As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents talamat As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cb1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tnama_peminjam As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tlama As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents kode_peminjaman As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_peminjam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tanggal_peminjaman As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tanggal_pengembalian As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents biaya_adm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_biaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ttahun As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cb2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tpenerbit As System.Windows.Forms.TextBox
    Friend WithEvents tjudul As System.Windows.Forms.TextBox
    Friend WithEvents tpengarang As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents tkode_peminjaman As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
