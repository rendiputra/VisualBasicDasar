<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataKaryawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataKaryawan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnip = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtnotelp = New System.Windows.Forms.TextBox()
        Me.txtjeniskelamin = New System.Windows.Forms.TextBox()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.txtjumlahanak = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtkodegolongan = New System.Windows.Forms.TextBox()
        Me.txtkodejabatan = New System.Windows.Forms.TextBox()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btntutup = New System.Windows.Forms.Button()
        Me.btnkodegolongan = New System.Windows.Forms.Button()
        Me.btnkodejabatan = New System.Windows.Forms.Button()
        Me.dgvdatakaryawan = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnlaporan = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.dgvdatakaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No.Telpon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(258, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(258, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Jumlah Anak"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(258, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Email"
        '
        'txtnip
        '
        Me.txtnip.Location = New System.Drawing.Point(88, 20)
        Me.txtnip.Name = "txtnip"
        Me.txtnip.Size = New System.Drawing.Size(164, 20)
        Me.txtnip.TabIndex = 10
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(88, 48)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(164, 20)
        Me.txtnama.TabIndex = 11
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(88, 77)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(164, 20)
        Me.txtalamat.TabIndex = 12
        '
        'txtnotelp
        '
        Me.txtnotelp.Location = New System.Drawing.Point(88, 105)
        Me.txtnotelp.Name = "txtnotelp"
        Me.txtnotelp.Size = New System.Drawing.Size(164, 20)
        Me.txtnotelp.TabIndex = 13
        '
        'txtjeniskelamin
        '
        Me.txtjeniskelamin.Location = New System.Drawing.Point(355, 16)
        Me.txtjeniskelamin.Name = "txtjeniskelamin"
        Me.txtjeniskelamin.Size = New System.Drawing.Size(160, 20)
        Me.txtjeniskelamin.TabIndex = 14
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(355, 45)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(160, 20)
        Me.txtstatus.TabIndex = 15
        '
        'txtjumlahanak
        '
        Me.txtjumlahanak.Location = New System.Drawing.Point(355, 74)
        Me.txtjumlahanak.Name = "txtjumlahanak"
        Me.txtjumlahanak.Size = New System.Drawing.Size(160, 20)
        Me.txtjumlahanak.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(258, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Jenis Kelamin"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(355, 101)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(160, 20)
        Me.txtemail.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(528, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Kode Jabatan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(528, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Kode Golongan"
        '
        'txtkodegolongan
        '
        Me.txtkodegolongan.Location = New System.Drawing.Point(647, 19)
        Me.txtkodegolongan.Name = "txtkodegolongan"
        Me.txtkodegolongan.Size = New System.Drawing.Size(100, 20)
        Me.txtkodegolongan.TabIndex = 21
        '
        'txtkodejabatan
        '
        Me.txtkodejabatan.Location = New System.Drawing.Point(647, 47)
        Me.txtkodejabatan.Name = "txtkodejabatan"
        Me.txtkodejabatan.Size = New System.Drawing.Size(100, 20)
        Me.txtkodejabatan.TabIndex = 22
        '
        'btnsimpan
        '
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.Location = New System.Drawing.Point(14, 137)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(91, 89)
        Me.btnsimpan.TabIndex = 23
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.Location = New System.Drawing.Point(146, 137)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(91, 89)
        Me.btnedit.TabIndex = 24
        Me.btnedit.Text = "EDIT"
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Image = CType(resources.GetObject("btnhapus.Image"), System.Drawing.Image)
        Me.btnhapus.Location = New System.Drawing.Point(297, 137)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(91, 89)
        Me.btnhapus.TabIndex = 25
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btntutup
        '
        Me.btntutup.Image = CType(resources.GetObject("btntutup.Image"), System.Drawing.Image)
        Me.btntutup.Location = New System.Drawing.Point(424, 137)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(91, 89)
        Me.btntutup.TabIndex = 26
        Me.btntutup.Text = "TUTUP"
        Me.btntutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btntutup.UseVisualStyleBackColor = True
        '
        'btnkodegolongan
        '
        Me.btnkodegolongan.Location = New System.Drawing.Point(753, 16)
        Me.btnkodegolongan.Name = "btnkodegolongan"
        Me.btnkodegolongan.Size = New System.Drawing.Size(75, 23)
        Me.btnkodegolongan.TabIndex = 27
        Me.btnkodegolongan.Text = "Lihat Daftar"
        Me.btnkodegolongan.UseVisualStyleBackColor = True
        '
        'btnkodejabatan
        '
        Me.btnkodejabatan.Location = New System.Drawing.Point(753, 46)
        Me.btnkodejabatan.Name = "btnkodejabatan"
        Me.btnkodejabatan.Size = New System.Drawing.Size(75, 23)
        Me.btnkodejabatan.TabIndex = 28
        Me.btnkodejabatan.Text = "Lihat Daftar"
        Me.btnkodejabatan.UseVisualStyleBackColor = True
        '
        'dgvdatakaryawan
        '
        Me.dgvdatakaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdatakaryawan.Location = New System.Drawing.Point(15, 244)
        Me.dgvdatakaryawan.Name = "dgvdatakaryawan"
        Me.dgvdatakaryawan.Size = New System.Drawing.Size(913, 182)
        Me.dgvdatakaryawan.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(652, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 16)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Nama"
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(703, 200)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(164, 26)
        Me.txtsearch.TabIndex = 31
        '
        'btnlaporan
        '
        Me.btnlaporan.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnlaporan.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnlaporan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlaporan.BorderRadius = 0
        Me.btnlaporan.ButtonText = "Laporan"
        Me.btnlaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlaporan.DisabledColor = System.Drawing.Color.Gray
        Me.btnlaporan.Iconcolor = System.Drawing.Color.Transparent
        Me.btnlaporan.Iconimage = CType(resources.GetObject("btnlaporan.Iconimage"), System.Drawing.Image)
        Me.btnlaporan.Iconimage_right = Nothing
        Me.btnlaporan.Iconimage_right_Selected = Nothing
        Me.btnlaporan.Iconimage_Selected = Nothing
        Me.btnlaporan.IconMarginLeft = 0
        Me.btnlaporan.IconMarginRight = 0
        Me.btnlaporan.IconRightVisible = True
        Me.btnlaporan.IconRightZoom = 0.0R
        Me.btnlaporan.IconVisible = True
        Me.btnlaporan.IconZoom = 70.0R
        Me.btnlaporan.IsTab = False
        Me.btnlaporan.Location = New System.Drawing.Point(647, 137)
        Me.btnlaporan.Name = "btnlaporan"
        Me.btnlaporan.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnlaporan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnlaporan.OnHoverTextColor = System.Drawing.Color.White
        Me.btnlaporan.selected = False
        Me.btnlaporan.Size = New System.Drawing.Size(216, 51)
        Me.btnlaporan.TabIndex = 32
        Me.btnlaporan.Text = "Laporan"
        Me.btnlaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlaporan.Textcolor = System.Drawing.Color.White
        Me.btnlaporan.TextFont = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DataKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(940, 493)
        Me.Controls.Add(Me.btnlaporan)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dgvdatakaryawan)
        Me.Controls.Add(Me.btnkodejabatan)
        Me.Controls.Add(Me.btnkodegolongan)
        Me.Controls.Add(Me.btntutup)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtkodejabatan)
        Me.Controls.Add(Me.txtkodegolongan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtjumlahanak)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.txtjeniskelamin)
        Me.Controls.Add(Me.txtnotelp)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnip)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DataKaryawan"
        CType(Me.dgvdatakaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtnip As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtnotelp As System.Windows.Forms.TextBox
    Friend WithEvents txtjeniskelamin As System.Windows.Forms.TextBox
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlahanak As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtkodegolongan As System.Windows.Forms.TextBox
    Friend WithEvents txtkodejabatan As System.Windows.Forms.TextBox
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btntutup As System.Windows.Forms.Button
    Friend WithEvents btnkodegolongan As System.Windows.Forms.Button
    Friend WithEvents btnkodejabatan As System.Windows.Forms.Button
    Friend WithEvents dgvdatakaryawan As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnlaporan As Bunifu.Framework.UI.BunifuFlatButton
End Class
