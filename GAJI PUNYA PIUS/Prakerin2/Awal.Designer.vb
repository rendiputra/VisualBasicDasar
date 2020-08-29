<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Awal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Awal))
        Me.btnkaryawan = New System.Windows.Forms.Button()
        Me.btnadmin = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnkaryawan
        '
        Me.btnkaryawan.BackColor = System.Drawing.Color.White
        Me.btnkaryawan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnkaryawan.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkaryawan.ForeColor = System.Drawing.Color.Black
        Me.btnkaryawan.Image = CType(resources.GetObject("btnkaryawan.Image"), System.Drawing.Image)
        Me.btnkaryawan.Location = New System.Drawing.Point(46, 93)
        Me.btnkaryawan.Name = "btnkaryawan"
        Me.btnkaryawan.Size = New System.Drawing.Size(122, 130)
        Me.btnkaryawan.TabIndex = 0
        Me.btnkaryawan.Text = "Karyawan"
        Me.btnkaryawan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnkaryawan.UseVisualStyleBackColor = False
        '
        'btnadmin
        '
        Me.btnadmin.BackColor = System.Drawing.Color.White
        Me.btnadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnadmin.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadmin.ForeColor = System.Drawing.Color.Black
        Me.btnadmin.Image = CType(resources.GetObject("btnadmin.Image"), System.Drawing.Image)
        Me.btnadmin.Location = New System.Drawing.Point(230, 93)
        Me.btnadmin.Name = "btnadmin"
        Me.btnadmin.Size = New System.Drawing.Size(122, 130)
        Me.btnadmin.TabIndex = 1
        Me.btnadmin.Text = "Admin"
        Me.btnadmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnadmin.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(555, -1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 41)
        Me.Button3.TabIndex = 2
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Awal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(604, 316)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnadmin)
        Me.Controls.Add(Me.btnkaryawan)
        Me.Name = "Awal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnkaryawan As System.Windows.Forms.Button
    Friend WithEvents btnadmin As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
