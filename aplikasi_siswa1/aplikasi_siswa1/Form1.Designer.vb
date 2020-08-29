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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_siswa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kelas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nis, Me.nama_siswa, Me.kelas, Me.jurusan})
        Me.DataGridView1.Location = New System.Drawing.Point(30, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(442, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'nis
        '
        Me.nis.HeaderText = "NIS"
        Me.nis.Name = "nis"
        '
        'nama_siswa
        '
        Me.nama_siswa.HeaderText = "Nama Siswa"
        Me.nama_siswa.Name = "nama_siswa"
        '
        'kelas
        '
        Me.kelas.HeaderText = "Kelas"
        Me.kelas.Name = "kelas"
        '
        'jurusan
        '
        Me.jurusan.HeaderText = "Jurusan"
        Me.jurusan.Name = "jurusan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(362, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "TAMBAH DATA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 262)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents nis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_siswa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kelas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jurusan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
