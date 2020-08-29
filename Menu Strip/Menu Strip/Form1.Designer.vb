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
        Me.AplikasiAritmatikaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KalkulatorSederhanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AplikasiHitungLuasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LuasSegitigaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AplikasiKasirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AplikasiSederhanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LuasPersegiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AplikasiAritmatikaToolStripMenuItem, Me.AplikasiKasirToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AplikasiAritmatikaToolStripMenuItem
        '
        Me.AplikasiAritmatikaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AplikasiAritmatikaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KalkulatorSederhanaToolStripMenuItem, Me.AplikasiHitungLuasToolStripMenuItem})
        Me.AplikasiAritmatikaToolStripMenuItem.Name = "AplikasiAritmatikaToolStripMenuItem"
        Me.AplikasiAritmatikaToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.AplikasiAritmatikaToolStripMenuItem.Text = "Aplikasi Aritmatika"
        '
        'KalkulatorSederhanaToolStripMenuItem
        '
        Me.KalkulatorSederhanaToolStripMenuItem.Name = "KalkulatorSederhanaToolStripMenuItem"
        Me.KalkulatorSederhanaToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.KalkulatorSederhanaToolStripMenuItem.Text = "Kalkulator Sederhana"
        '
        'AplikasiHitungLuasToolStripMenuItem
        '
        Me.AplikasiHitungLuasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LuasSegitigaToolStripMenuItem, Me.LuasPersegiToolStripMenuItem})
        Me.AplikasiHitungLuasToolStripMenuItem.Name = "AplikasiHitungLuasToolStripMenuItem"
        Me.AplikasiHitungLuasToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.AplikasiHitungLuasToolStripMenuItem.Text = "Aplikasi Hitung Luas"
        '
        'LuasSegitigaToolStripMenuItem
        '
        Me.LuasSegitigaToolStripMenuItem.Name = "LuasSegitigaToolStripMenuItem"
        Me.LuasSegitigaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LuasSegitigaToolStripMenuItem.Text = "Luas Segitiga"
        '
        'AplikasiKasirToolStripMenuItem1
        '
        Me.AplikasiKasirToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AplikasiSederhanaToolStripMenuItem})
        Me.AplikasiKasirToolStripMenuItem1.Name = "AplikasiKasirToolStripMenuItem1"
        Me.AplikasiKasirToolStripMenuItem1.Size = New System.Drawing.Size(88, 20)
        Me.AplikasiKasirToolStripMenuItem1.Text = "Aplikasi Kasir"
        '
        'AplikasiSederhanaToolStripMenuItem
        '
        Me.AplikasiSederhanaToolStripMenuItem.Name = "AplikasiSederhanaToolStripMenuItem"
        Me.AplikasiSederhanaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AplikasiSederhanaToolStripMenuItem.Text = "Aplikasi Sederhana"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'LuasPersegiToolStripMenuItem
        '
        Me.LuasPersegiToolStripMenuItem.Name = "LuasPersegiToolStripMenuItem"
        Me.LuasPersegiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LuasPersegiToolStripMenuItem.Text = "Luas Persegi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
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
    Friend WithEvents AplikasiAritmatikaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KalkulatorSederhanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AplikasiHitungLuasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LuasSegitigaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AplikasiKasirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AplikasiSederhanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LuasPersegiToolStripMenuItem As ToolStripMenuItem
End Class
