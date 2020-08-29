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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim NISLabel As System.Windows.Forms.Label
        Dim NISNLabel As System.Windows.Forms.Label
        Dim NAMALabel As System.Windows.Forms.Label
        Dim KELASLabel As System.Windows.Forms.Label
        Dim JURUSANLabel As System.Windows.Forms.Label
        Me.SiswaDataSet = New APPLIKASI_SISIWA.siswaDataSet()
        Me.KelasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelasTableAdapter = New APPLIKASI_SISIWA.siswaDataSetTableAdapters.kelasTableAdapter()
        Me.TableAdapterManager = New APPLIKASI_SISIWA.siswaDataSetTableAdapters.TableAdapterManager()
        Me.KelasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.KelasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NISTextBox = New System.Windows.Forms.TextBox()
        Me.NISNTextBox = New System.Windows.Forms.TextBox()
        Me.NAMATextBox = New System.Windows.Forms.TextBox()
        Me.KELASTextBox = New System.Windows.Forms.TextBox()
        Me.JURUSANTextBox = New System.Windows.Forms.TextBox()
        NISLabel = New System.Windows.Forms.Label()
        NISNLabel = New System.Windows.Forms.Label()
        NAMALabel = New System.Windows.Forms.Label()
        KELASLabel = New System.Windows.Forms.Label()
        JURUSANLabel = New System.Windows.Forms.Label()
        CType(Me.SiswaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KelasBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SiswaDataSet
        '
        Me.SiswaDataSet.DataSetName = "siswaDataSet"
        Me.SiswaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KelasBindingSource
        '
        Me.KelasBindingSource.DataMember = "kelas"
        Me.KelasBindingSource.DataSource = Me.SiswaDataSet
        '
        'KelasTableAdapter
        '
        Me.KelasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.kelasTableAdapter = Me.KelasTableAdapter
        Me.TableAdapterManager.UpdateOrder = APPLIKASI_SISIWA.siswaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KelasBindingNavigator
        '
        Me.KelasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.KelasBindingNavigator.BindingSource = Me.KelasBindingSource
        Me.KelasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.KelasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.KelasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.KelasBindingNavigatorSaveItem})
        Me.KelasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.KelasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.KelasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.KelasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.KelasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.KelasBindingNavigator.Name = "KelasBindingNavigator"
        Me.KelasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.KelasBindingNavigator.Size = New System.Drawing.Size(590, 27)
        Me.KelasBindingNavigator.TabIndex = 0
        Me.KelasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 20)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'KelasBindingNavigatorSaveItem
        '
        Me.KelasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KelasBindingNavigatorSaveItem.Image = CType(resources.GetObject("KelasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.KelasBindingNavigatorSaveItem.Name = "KelasBindingNavigatorSaveItem"
        Me.KelasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.KelasBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NISLabel
        '
        NISLabel.AutoSize = True
        NISLabel.Location = New System.Drawing.Point(28, 65)
        NISLabel.Name = "NISLabel"
        NISLabel.Size = New System.Drawing.Size(34, 17)
        NISLabel.TabIndex = 1
        NISLabel.Text = "NIS:"
        '
        'NISTextBox
        '
        Me.NISTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KelasBindingSource, "NIS", True))
        Me.NISTextBox.Location = New System.Drawing.Point(111, 62)
        Me.NISTextBox.Name = "NISTextBox"
        Me.NISTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NISTextBox.TabIndex = 2
        '
        'NISNLabel
        '
        NISNLabel.AutoSize = True
        NISNLabel.Location = New System.Drawing.Point(28, 93)
        NISNLabel.Name = "NISNLabel"
        NISNLabel.Size = New System.Drawing.Size(44, 17)
        NISNLabel.TabIndex = 3
        NISNLabel.Text = "NISN:"
        '
        'NISNTextBox
        '
        Me.NISNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KelasBindingSource, "NISN", True))
        Me.NISNTextBox.Location = New System.Drawing.Point(111, 90)
        Me.NISNTextBox.Name = "NISNTextBox"
        Me.NISNTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NISNTextBox.TabIndex = 4
        '
        'NAMALabel
        '
        NAMALabel.AutoSize = True
        NAMALabel.Location = New System.Drawing.Point(28, 121)
        NAMALabel.Name = "NAMALabel"
        NAMALabel.Size = New System.Drawing.Size(51, 17)
        NAMALabel.TabIndex = 5
        NAMALabel.Text = "NAMA:"
        '
        'NAMATextBox
        '
        Me.NAMATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KelasBindingSource, "NAMA", True))
        Me.NAMATextBox.Location = New System.Drawing.Point(111, 118)
        Me.NAMATextBox.Name = "NAMATextBox"
        Me.NAMATextBox.Size = New System.Drawing.Size(100, 22)
        Me.NAMATextBox.TabIndex = 6
        '
        'KELASLabel
        '
        KELASLabel.AutoSize = True
        KELASLabel.Location = New System.Drawing.Point(28, 149)
        KELASLabel.Name = "KELASLabel"
        KELASLabel.Size = New System.Drawing.Size(56, 17)
        KELASLabel.TabIndex = 7
        KELASLabel.Text = "KELAS:"
        '
        'KELASTextBox
        '
        Me.KELASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KelasBindingSource, "KELAS", True))
        Me.KELASTextBox.Location = New System.Drawing.Point(111, 146)
        Me.KELASTextBox.Name = "KELASTextBox"
        Me.KELASTextBox.Size = New System.Drawing.Size(100, 22)
        Me.KELASTextBox.TabIndex = 8
        '
        'JURUSANLabel
        '
        JURUSANLabel.AutoSize = True
        JURUSANLabel.Location = New System.Drawing.Point(28, 177)
        JURUSANLabel.Name = "JURUSANLabel"
        JURUSANLabel.Size = New System.Drawing.Size(77, 17)
        JURUSANLabel.TabIndex = 9
        JURUSANLabel.Text = "JURUSAN:"
        '
        'JURUSANTextBox
        '
        Me.JURUSANTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KelasBindingSource, "JURUSAN", True))
        Me.JURUSANTextBox.Location = New System.Drawing.Point(111, 174)
        Me.JURUSANTextBox.Name = "JURUSANTextBox"
        Me.JURUSANTextBox.Size = New System.Drawing.Size(100, 22)
        Me.JURUSANTextBox.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 422)
        Me.Controls.Add(NISLabel)
        Me.Controls.Add(Me.NISTextBox)
        Me.Controls.Add(NISNLabel)
        Me.Controls.Add(Me.NISNTextBox)
        Me.Controls.Add(NAMALabel)
        Me.Controls.Add(Me.NAMATextBox)
        Me.Controls.Add(KELASLabel)
        Me.Controls.Add(Me.KELASTextBox)
        Me.Controls.Add(JURUSANLabel)
        Me.Controls.Add(Me.JURUSANTextBox)
        Me.Controls.Add(Me.KelasBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SiswaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KelasBindingNavigator.ResumeLayout(False)
        Me.KelasBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SiswaDataSet As APPLIKASI_SISIWA.siswaDataSet
    Friend WithEvents KelasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KelasTableAdapter As APPLIKASI_SISIWA.siswaDataSetTableAdapters.kelasTableAdapter
    Friend WithEvents TableAdapterManager As APPLIKASI_SISIWA.siswaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KelasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KelasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NISTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NISNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAMATextBox As System.Windows.Forms.TextBox
    Friend WithEvents KELASTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JURUSANTextBox As System.Windows.Forms.TextBox

End Class
