<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jabatan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jabatan))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvjabatan = New System.Windows.Forms.DataGridView()
        Me.btntutup = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txttunjanganjabatan = New System.Windows.Forms.TextBox()
        Me.txtgajipokok = New System.Windows.Forms.TextBox()
        Me.txtnamajabatan = New System.Windows.Forms.TextBox()
        Me.txtkodejabatan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvjabatan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.dgvjabatan)
        Me.Panel1.Controls.Add(Me.btntutup)
        Me.Panel1.Controls.Add(Me.btnhapus)
        Me.Panel1.Controls.Add(Me.btnedit)
        Me.Panel1.Controls.Add(Me.btnsimpan)
        Me.Panel1.Controls.Add(Me.txttunjanganjabatan)
        Me.Panel1.Controls.Add(Me.txtgajipokok)
        Me.Panel1.Controls.Add(Me.txtnamajabatan)
        Me.Panel1.Controls.Add(Me.txtkodejabatan)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(638, 555)
        Me.Panel1.TabIndex = 2
        '
        'dgvjabatan
        '
        Me.dgvjabatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvjabatan.Location = New System.Drawing.Point(47, 251)
        Me.dgvjabatan.Name = "dgvjabatan"
        Me.dgvjabatan.Size = New System.Drawing.Size(434, 150)
        Me.dgvjabatan.TabIndex = 19
        '
        'btntutup
        '
        Me.btntutup.Image = CType(resources.GetObject("btntutup.Image"), System.Drawing.Image)
        Me.btntutup.Location = New System.Drawing.Point(377, 137)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(104, 92)
        Me.btntutup.TabIndex = 18
        Me.btntutup.Text = "TUTUP"
        Me.btntutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btntutup.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Image = CType(resources.GetObject("btnhapus.Image"), System.Drawing.Image)
        Me.btnhapus.Location = New System.Drawing.Point(267, 137)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(104, 92)
        Me.btnhapus.TabIndex = 17
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.Location = New System.Drawing.Point(157, 137)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(104, 92)
        Me.btnedit.TabIndex = 16
        Me.btnedit.Text = "EDIT"
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.Location = New System.Drawing.Point(47, 137)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(104, 92)
        Me.btnsimpan.TabIndex = 15
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txttunjanganjabatan
        '
        Me.txttunjanganjabatan.Location = New System.Drawing.Point(209, 105)
        Me.txttunjanganjabatan.Name = "txttunjanganjabatan"
        Me.txttunjanganjabatan.Size = New System.Drawing.Size(100, 20)
        Me.txttunjanganjabatan.TabIndex = 7
        '
        'txtgajipokok
        '
        Me.txtgajipokok.Location = New System.Drawing.Point(209, 82)
        Me.txtgajipokok.Name = "txtgajipokok"
        Me.txtgajipokok.Size = New System.Drawing.Size(100, 20)
        Me.txtgajipokok.TabIndex = 6
        '
        'txtnamajabatan
        '
        Me.txtnamajabatan.Location = New System.Drawing.Point(209, 59)
        Me.txtnamajabatan.Name = "txtnamajabatan"
        Me.txtnamajabatan.Size = New System.Drawing.Size(100, 20)
        Me.txtnamajabatan.TabIndex = 5
        '
        'txtkodejabatan
        '
        Me.txtkodejabatan.Location = New System.Drawing.Point(209, 36)
        Me.txtkodejabatan.Name = "txtkodejabatan"
        Me.txtkodejabatan.Size = New System.Drawing.Size(100, 20)
        Me.txtkodejabatan.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tunjangan Jabatan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gaji Pokok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Jabatan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Jabatan"
        '
        'Jabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 555)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Jabatan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jabatan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvjabatan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttunjanganjabatan As System.Windows.Forms.TextBox
    Friend WithEvents txtgajipokok As System.Windows.Forms.TextBox
    Friend WithEvents txtnamajabatan As System.Windows.Forms.TextBox
    Friend WithEvents txtkodejabatan As System.Windows.Forms.TextBox
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents dgvjabatan As System.Windows.Forms.DataGridView
    Friend WithEvents btntutup As System.Windows.Forms.Button
End Class
