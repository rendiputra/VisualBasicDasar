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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.namatxt = New System.Windows.Forms.TextBox()
        Me.kelastxt = New System.Windows.Forms.TextBox()
        Me.alamattxt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kelas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.nistxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jurusantxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(159, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kelas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(150, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(173, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'namatxt
        '
        Me.namatxt.Location = New System.Drawing.Point(215, 68)
        Me.namatxt.Name = "namatxt"
        Me.namatxt.Size = New System.Drawing.Size(100, 20)
        Me.namatxt.TabIndex = 5
        '
        'kelastxt
        '
        Me.kelastxt.Location = New System.Drawing.Point(215, 107)
        Me.kelastxt.Name = "kelastxt"
        Me.kelastxt.Size = New System.Drawing.Size(100, 20)
        Me.kelastxt.TabIndex = 6
        '
        'alamattxt
        '
        Me.alamattxt.Location = New System.Drawing.Point(215, 140)
        Me.alamattxt.Name = "alamattxt"
        Me.alamattxt.Size = New System.Drawing.Size(100, 20)
        Me.alamattxt.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nama, Me.kelas, Me.alamat, Me.nis, Me.jurusan})
        Me.DataGridView1.Location = New System.Drawing.Point(2, 292)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(536, 150)
        Me.DataGridView1.TabIndex = 8
        '
        'nama
        '
        Me.nama.HeaderText = "nama"
        Me.nama.Name = "nama"
        '
        'kelas
        '
        Me.kelas.HeaderText = "kelas"
        Me.kelas.Name = "kelas"
        '
        'alamat
        '
        Me.alamat.HeaderText = "alamat"
        Me.alamat.Name = "alamat"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(255, 263)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'nistxt
        '
        Me.nistxt.Location = New System.Drawing.Point(215, 176)
        Me.nistxt.Name = "nistxt"
        Me.nistxt.Size = New System.Drawing.Size(100, 20)
        Me.nistxt.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(167, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "NIS"
        '
        'jurusantxt
        '
        Me.jurusantxt.Location = New System.Drawing.Point(215, 216)
        Me.jurusantxt.Name = "jurusantxt"
        Me.jurusantxt.Size = New System.Drawing.Size(100, 20)
        Me.jurusantxt.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(141, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Jurusan"
        '
        'nis
        '
        Me.nis.HeaderText = "nis"
        Me.nis.Name = "nis"
        '
        'jurusan
        '
        Me.jurusan.HeaderText = "jurusan"
        Me.jurusan.Name = "jurusan"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 513)
        Me.Controls.Add(Me.jurusantxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nistxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.alamattxt)
        Me.Controls.Add(Me.kelastxt)
        Me.Controls.Add(Me.namatxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents namatxt As TextBox
    Friend WithEvents kelastxt As TextBox
    Friend WithEvents alamattxt As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents kelas As DataGridViewTextBoxColumn
    Friend WithEvents alamat As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents nis As DataGridViewTextBoxColumn
    Friend WithEvents jurusan As DataGridViewTextBoxColumn
    Friend WithEvents nistxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents jurusantxt As TextBox
    Friend WithEvents Label6 As Label
End Class
