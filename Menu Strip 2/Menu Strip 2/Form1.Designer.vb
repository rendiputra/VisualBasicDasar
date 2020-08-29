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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LuasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LuasPersegiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LuasPersegiPanjangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LuasBangunRuangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolumeKubusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolumeBalokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.LuasToolStripMenuItem, Me.LuasBangunRuangToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(308, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'LuasToolStripMenuItem
        '
        Me.LuasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LuasPersegiToolStripMenuItem, Me.LuasPersegiPanjangToolStripMenuItem})
        Me.LuasToolStripMenuItem.Name = "LuasToolStripMenuItem"
        Me.LuasToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.LuasToolStripMenuItem.Text = "Luas Bangun Datar"
        '
        'LuasPersegiToolStripMenuItem
        '
        Me.LuasPersegiToolStripMenuItem.Name = "LuasPersegiToolStripMenuItem"
        Me.LuasPersegiToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.LuasPersegiToolStripMenuItem.Text = "Luas Persegi"
        '
        'LuasPersegiPanjangToolStripMenuItem
        '
        Me.LuasPersegiPanjangToolStripMenuItem.Name = "LuasPersegiPanjangToolStripMenuItem"
        Me.LuasPersegiPanjangToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.LuasPersegiPanjangToolStripMenuItem.Text = "Luas Persegi Panjang"
        '
        'LuasBangunRuangToolStripMenuItem
        '
        Me.LuasBangunRuangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolumeKubusToolStripMenuItem, Me.VolumeBalokToolStripMenuItem})
        Me.LuasBangunRuangToolStripMenuItem.Name = "LuasBangunRuangToolStripMenuItem"
        Me.LuasBangunRuangToolStripMenuItem.Size = New System.Drawing.Size(140, 20)
        Me.LuasBangunRuangToolStripMenuItem.Text = "Volume Bangun Ruang"
        '
        'VolumeKubusToolStripMenuItem
        '
        Me.VolumeKubusToolStripMenuItem.Name = "VolumeKubusToolStripMenuItem"
        Me.VolumeKubusToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VolumeKubusToolStripMenuItem.Text = "Volume Kubus"
        '
        'VolumeBalokToolStripMenuItem
        '
        Me.VolumeBalokToolStripMenuItem.Name = "VolumeBalokToolStripMenuItem"
        Me.VolumeBalokToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VolumeBalokToolStripMenuItem.Text = "Volume Balok"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LuasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LuasPersegiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LuasPersegiPanjangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LuasBangunRuangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolumeKubusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolumeBalokToolStripMenuItem As ToolStripMenuItem
End Class
