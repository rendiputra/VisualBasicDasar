<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtapotek = New System.Windows.Forms.TextBox()
        Me.txtdokter = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.barisbuffer = New System.Windows.Forms.TextBox()
        Me.cbsatuan = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txtnama_obat = New System.Windows.Forms.TextBox()
        Me.txtkode_obat = New System.Windows.Forms.TextBox()
        Me.ListViewdataobat = New System.Windows.Forms.ListView()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Obat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kode Obat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Satuan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Jumlah Obat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Harga Satuan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtapotek)
        Me.GroupBox1.Controls.Add(Me.txtdokter)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.barisbuffer)
        Me.GroupBox1.Controls.Add(Me.cbsatuan)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtharga)
        Me.GroupBox1.Controls.Add(Me.txtjumlah)
        Me.GroupBox1.Controls.Add(Me.txtnama_obat)
        Me.GroupBox1.Controls.Add(Me.txtkode_obat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 268)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LIST VIEW"
        '
        'txtapotek
        '
        Me.txtapotek.Location = New System.Drawing.Point(132, 212)
        Me.txtapotek.Name = "txtapotek"
        Me.txtapotek.Size = New System.Drawing.Size(100, 21)
        Me.txtapotek.TabIndex = 19
        '
        'txtdokter
        '
        Me.txtdokter.Location = New System.Drawing.Point(132, 185)
        Me.txtdokter.Name = "txtdokter"
        Me.txtdokter.Size = New System.Drawing.Size(100, 21)
        Me.txtdokter.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Nama Apotek"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Nama Dokter"
        '
        'barisbuffer
        '
        Me.barisbuffer.Location = New System.Drawing.Point(360, 195)
        Me.barisbuffer.Name = "barisbuffer"
        Me.barisbuffer.Size = New System.Drawing.Size(100, 21)
        Me.barisbuffer.TabIndex = 15
        '
        'cbsatuan
        '
        Me.cbsatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbsatuan.FormattingEnabled = True
        Me.cbsatuan.Items.AddRange(New Object() {"pil", "tablet", "dus"})
        Me.cbsatuan.Location = New System.Drawing.Point(132, 93)
        Me.cbsatuan.Name = "cbsatuan"
        Me.cbsatuan.Size = New System.Drawing.Size(129, 24)
        Me.cbsatuan.TabIndex = 14
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(360, 123)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 41)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "&exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(360, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 48)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "&simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(360, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 48)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "&tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtharga
        '
        Me.txtharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtharga.Location = New System.Drawing.Point(132, 157)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(100, 22)
        Me.txtharga.TabIndex = 10
        '
        'txtjumlah
        '
        Me.txtjumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlah.Location = New System.Drawing.Point(132, 128)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(100, 22)
        Me.txtjumlah.TabIndex = 9
        '
        'txtnama_obat
        '
        Me.txtnama_obat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama_obat.Location = New System.Drawing.Point(132, 58)
        Me.txtnama_obat.Name = "txtnama_obat"
        Me.txtnama_obat.Size = New System.Drawing.Size(208, 22)
        Me.txtnama_obat.TabIndex = 7
        '
        'txtkode_obat
        '
        Me.txtkode_obat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode_obat.Location = New System.Drawing.Point(132, 19)
        Me.txtkode_obat.Name = "txtkode_obat"
        Me.txtkode_obat.Size = New System.Drawing.Size(100, 22)
        Me.txtkode_obat.TabIndex = 6
        '
        'ListViewdataobat
        '
        Me.ListViewdataobat.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListViewdataobat.Location = New System.Drawing.Point(0, 274)
        Me.ListViewdataobat.Name = "ListViewdataobat"
        Me.ListViewdataobat.Size = New System.Drawing.Size(552, 185)
        Me.ListViewdataobat.TabIndex = 7
        Me.ListViewdataobat.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 459)
        Me.Controls.Add(Me.ListViewdataobat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents barisbuffer As TextBox
    Friend WithEvents cbsatuan As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txtnama_obat As TextBox
    Friend WithEvents txtkode_obat As TextBox
    Friend WithEvents ListViewdataobat As System.Windows.Forms.ListView
    Friend WithEvents txtapotek As TextBox
    Friend WithEvents txtdokter As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
