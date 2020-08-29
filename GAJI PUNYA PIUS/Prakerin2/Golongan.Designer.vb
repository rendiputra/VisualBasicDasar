<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Golongan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Golongan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtgolongan = New System.Windows.Forms.TextBox()
        Me.txttunjangankeluarga = New System.Windows.Forms.TextBox()
        Me.txttunjangananak = New System.Windows.Forms.TextBox()
        Me.txttunjangantransport = New System.Windows.Forms.TextBox()
        Me.txttunjanganmakan = New System.Windows.Forms.TextBox()
        Me.txttunjanganlembur = New System.Windows.Forms.TextBox()
        Me.txtasuransikesehatan = New System.Windows.Forms.TextBox()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btntutup = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvgolongan = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvgolongan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Golongan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tunjangan Keluarga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(334, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tunjangan Makan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tunjangan Transport"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(334, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Asuransi Kesehatan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(334, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tunjangan Lembur"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(39, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tunjangan Anak"
        '
        'txtgolongan
        '
        Me.txtgolongan.Location = New System.Drawing.Point(205, 27)
        Me.txtgolongan.Name = "txtgolongan"
        Me.txtgolongan.Size = New System.Drawing.Size(100, 20)
        Me.txtgolongan.TabIndex = 7
        '
        'txttunjangankeluarga
        '
        Me.txttunjangankeluarga.Location = New System.Drawing.Point(205, 54)
        Me.txttunjangankeluarga.Name = "txttunjangankeluarga"
        Me.txttunjangankeluarga.Size = New System.Drawing.Size(100, 20)
        Me.txttunjangankeluarga.TabIndex = 8
        '
        'txttunjangananak
        '
        Me.txttunjangananak.Location = New System.Drawing.Point(205, 80)
        Me.txttunjangananak.Name = "txttunjangananak"
        Me.txttunjangananak.Size = New System.Drawing.Size(100, 20)
        Me.txttunjangananak.TabIndex = 9
        '
        'txttunjangantransport
        '
        Me.txttunjangantransport.Location = New System.Drawing.Point(205, 106)
        Me.txttunjangantransport.Name = "txttunjangantransport"
        Me.txttunjangantransport.Size = New System.Drawing.Size(100, 20)
        Me.txttunjangantransport.TabIndex = 10
        '
        'txttunjanganmakan
        '
        Me.txttunjanganmakan.Location = New System.Drawing.Point(489, 28)
        Me.txttunjanganmakan.Name = "txttunjanganmakan"
        Me.txttunjanganmakan.Size = New System.Drawing.Size(100, 20)
        Me.txttunjanganmakan.TabIndex = 11
        '
        'txttunjanganlembur
        '
        Me.txttunjanganlembur.Location = New System.Drawing.Point(489, 54)
        Me.txttunjanganlembur.Name = "txttunjanganlembur"
        Me.txttunjanganlembur.Size = New System.Drawing.Size(100, 20)
        Me.txttunjanganlembur.TabIndex = 12
        '
        'txtasuransikesehatan
        '
        Me.txtasuransikesehatan.Location = New System.Drawing.Point(489, 80)
        Me.txtasuransikesehatan.Name = "txtasuransikesehatan"
        Me.txtasuransikesehatan.Size = New System.Drawing.Size(100, 20)
        Me.txtasuransikesehatan.TabIndex = 13
        '
        'btnsimpan
        '
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.Location = New System.Drawing.Point(50, 144)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(104, 92)
        Me.btnsimpan.TabIndex = 14
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.Location = New System.Drawing.Point(195, 144)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(104, 92)
        Me.btnedit.TabIndex = 15
        Me.btnedit.Text = "EDIT"
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Image = CType(resources.GetObject("btnhapus.Image"), System.Drawing.Image)
        Me.btnhapus.Location = New System.Drawing.Point(340, 144)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(104, 92)
        Me.btnhapus.TabIndex = 16
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btntutup
        '
        Me.btntutup.Image = CType(resources.GetObject("btntutup.Image"), System.Drawing.Image)
        Me.btntutup.Location = New System.Drawing.Point(485, 144)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(104, 92)
        Me.btntutup.TabIndex = 17
        Me.btntutup.Text = "TUTUP"
        Me.btntutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btntutup.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.dgvgolongan)
        Me.Panel1.Controls.Add(Me.btntutup)
        Me.Panel1.Controls.Add(Me.btnhapus)
        Me.Panel1.Controls.Add(Me.btnedit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnsimpan)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtasuransikesehatan)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txttunjanganlembur)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txttunjanganmakan)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txttunjangantransport)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txttunjangananak)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txttunjangankeluarga)
        Me.Panel1.Controls.Add(Me.txtgolongan)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(638, 555)
        Me.Panel1.TabIndex = 18
        '
        'dgvgolongan
        '
        Me.dgvgolongan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvgolongan.Location = New System.Drawing.Point(30, 249)
        Me.dgvgolongan.Name = "dgvgolongan"
        Me.dgvgolongan.Size = New System.Drawing.Size(580, 279)
        Me.dgvgolongan.TabIndex = 19
        '
        'Golongan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 555)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Golongan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Golongan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvgolongan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtgolongan As System.Windows.Forms.TextBox
    Friend WithEvents txttunjangankeluarga As System.Windows.Forms.TextBox
    Friend WithEvents txttunjangananak As System.Windows.Forms.TextBox
    Friend WithEvents txttunjangantransport As System.Windows.Forms.TextBox
    Friend WithEvents txttunjanganmakan As System.Windows.Forms.TextBox
    Friend WithEvents txttunjanganlembur As System.Windows.Forms.TextBox
    Friend WithEvents txtasuransikesehatan As System.Windows.Forms.TextBox
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btntutup As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvgolongan As System.Windows.Forms.DataGridView
End Class
