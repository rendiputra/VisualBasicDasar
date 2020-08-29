<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim NISLabel As System.Windows.Forms.Label
        Dim NAMALabel As System.Windows.Forms.Label
        Dim KELASLabel As System.Windows.Forms.Label
        Dim JURUSANLabel As System.Windows.Forms.Label
        Dim HOBBYLabel As System.Windows.Forms.Label
        Me.Ulangan_cahya_vallenioDataSet = New splashscreen.ulangan_cahya_vallenioDataSet()
        Me.Siswa7BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Siswa7TableAdapter = New splashscreen.ulangan_cahya_vallenioDataSetTableAdapters.siswa7TableAdapter()
        Me.TableAdapterManager = New splashscreen.ulangan_cahya_vallenioDataSetTableAdapters.TableAdapterManager()
        Me.Siswa7BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Siswa7BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NISTextBox = New System.Windows.Forms.TextBox()
        Me.NAMATextBox = New System.Windows.Forms.TextBox()
        Me.KELASTextBox = New System.Windows.Forms.TextBox()
        Me.JURUSANTextBox = New System.Windows.Forms.TextBox()
        Me.HOBBYTextBox = New System.Windows.Forms.TextBox()
        NISLabel = New System.Windows.Forms.Label()
        NAMALabel = New System.Windows.Forms.Label()
        KELASLabel = New System.Windows.Forms.Label()
        JURUSANLabel = New System.Windows.Forms.Label()
        HOBBYLabel = New System.Windows.Forms.Label()
        CType(Me.Ulangan_cahya_vallenioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Siswa7BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Siswa7BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Siswa7BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ulangan_cahya_vallenioDataSet
        '
        Me.Ulangan_cahya_vallenioDataSet.DataSetName = "ulangan_cahya_vallenioDataSet"
        Me.Ulangan_cahya_vallenioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Siswa7BindingSource
        '
        Me.Siswa7BindingSource.DataMember = "siswa7"
        Me.Siswa7BindingSource.DataSource = Me.Ulangan_cahya_vallenioDataSet
        '
        'Siswa7TableAdapter
        '
        Me.Siswa7TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.siswa7TableAdapter = Me.Siswa7TableAdapter
        Me.TableAdapterManager.siswa8TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = splashscreen.ulangan_cahya_vallenioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Siswa7BindingNavigator
        '
        Me.Siswa7BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Siswa7BindingNavigator.BindingSource = Me.Siswa7BindingSource
        Me.Siswa7BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Siswa7BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Siswa7BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Siswa7BindingNavigatorSaveItem})
        Me.Siswa7BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Siswa7BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Siswa7BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Siswa7BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Siswa7BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Siswa7BindingNavigator.Name = "Siswa7BindingNavigator"
        Me.Siswa7BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Siswa7BindingNavigator.Size = New System.Drawing.Size(313, 25)
        Me.Siswa7BindingNavigator.TabIndex = 0
        Me.Siswa7BindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
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
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
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
        'Siswa7BindingNavigatorSaveItem
        '
        Me.Siswa7BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Siswa7BindingNavigatorSaveItem.Image = CType(resources.GetObject("Siswa7BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Siswa7BindingNavigatorSaveItem.Name = "Siswa7BindingNavigatorSaveItem"
        Me.Siswa7BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Siswa7BindingNavigatorSaveItem.Text = "Save Data"
        '
        'NISLabel
        '
        NISLabel.AutoSize = True
        NISLabel.Location = New System.Drawing.Point(45, 57)
        NISLabel.Name = "NISLabel"
        NISLabel.Size = New System.Drawing.Size(28, 13)
        NISLabel.TabIndex = 1
        NISLabel.Text = "NIS:"
        '
        'NISTextBox
        '
        Me.NISTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Siswa7BindingSource, "NIS", True))
        Me.NISTextBox.Location = New System.Drawing.Point(112, 54)
        Me.NISTextBox.Name = "NISTextBox"
        Me.NISTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NISTextBox.TabIndex = 2
        '
        'NAMALabel
        '
        NAMALabel.AutoSize = True
        NAMALabel.Location = New System.Drawing.Point(45, 83)
        NAMALabel.Name = "NAMALabel"
        NAMALabel.Size = New System.Drawing.Size(41, 13)
        NAMALabel.TabIndex = 3
        NAMALabel.Text = "NAMA:"
        '
        'NAMATextBox
        '
        Me.NAMATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Siswa7BindingSource, "NAMA", True))
        Me.NAMATextBox.Location = New System.Drawing.Point(112, 80)
        Me.NAMATextBox.Name = "NAMATextBox"
        Me.NAMATextBox.Size = New System.Drawing.Size(100, 20)
        Me.NAMATextBox.TabIndex = 4
        '
        'KELASLabel
        '
        KELASLabel.AutoSize = True
        KELASLabel.Location = New System.Drawing.Point(45, 109)
        KELASLabel.Name = "KELASLabel"
        KELASLabel.Size = New System.Drawing.Size(44, 13)
        KELASLabel.TabIndex = 5
        KELASLabel.Text = "KELAS:"
        '
        'KELASTextBox
        '
        Me.KELASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Siswa7BindingSource, "KELAS", True))
        Me.KELASTextBox.Location = New System.Drawing.Point(112, 106)
        Me.KELASTextBox.Name = "KELASTextBox"
        Me.KELASTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KELASTextBox.TabIndex = 6
        '
        'JURUSANLabel
        '
        JURUSANLabel.AutoSize = True
        JURUSANLabel.Location = New System.Drawing.Point(45, 135)
        JURUSANLabel.Name = "JURUSANLabel"
        JURUSANLabel.Size = New System.Drawing.Size(61, 13)
        JURUSANLabel.TabIndex = 7
        JURUSANLabel.Text = "JURUSAN:"
        '
        'JURUSANTextBox
        '
        Me.JURUSANTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Siswa7BindingSource, "JURUSAN", True))
        Me.JURUSANTextBox.Location = New System.Drawing.Point(112, 132)
        Me.JURUSANTextBox.Name = "JURUSANTextBox"
        Me.JURUSANTextBox.Size = New System.Drawing.Size(100, 20)
        Me.JURUSANTextBox.TabIndex = 8
        '
        'HOBBYLabel
        '
        HOBBYLabel.AutoSize = True
        HOBBYLabel.Location = New System.Drawing.Point(45, 161)
        HOBBYLabel.Name = "HOBBYLabel"
        HOBBYLabel.Size = New System.Drawing.Size(47, 13)
        HOBBYLabel.TabIndex = 9
        HOBBYLabel.Text = "HOBBY:"
        '
        'HOBBYTextBox
        '
        Me.HOBBYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Siswa7BindingSource, "HOBBY", True))
        Me.HOBBYTextBox.Location = New System.Drawing.Point(112, 158)
        Me.HOBBYTextBox.Name = "HOBBYTextBox"
        Me.HOBBYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HOBBYTextBox.TabIndex = 10
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 261)
        Me.Controls.Add(NISLabel)
        Me.Controls.Add(Me.NISTextBox)
        Me.Controls.Add(NAMALabel)
        Me.Controls.Add(Me.NAMATextBox)
        Me.Controls.Add(KELASLabel)
        Me.Controls.Add(Me.KELASTextBox)
        Me.Controls.Add(JURUSANLabel)
        Me.Controls.Add(Me.JURUSANTextBox)
        Me.Controls.Add(HOBBYLabel)
        Me.Controls.Add(Me.HOBBYTextBox)
        Me.Controls.Add(Me.Siswa7BindingNavigator)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.Ulangan_cahya_vallenioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Siswa7BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Siswa7BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Siswa7BindingNavigator.ResumeLayout(False)
        Me.Siswa7BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ulangan_cahya_vallenioDataSet As ulangan_cahya_vallenioDataSet
    Friend WithEvents Siswa7BindingSource As BindingSource
    Friend WithEvents Siswa7TableAdapter As ulangan_cahya_vallenioDataSetTableAdapters.siswa7TableAdapter
    Friend WithEvents TableAdapterManager As ulangan_cahya_vallenioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Siswa7BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Siswa7BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NISTextBox As TextBox
    Friend WithEvents NAMATextBox As TextBox
    Friend WithEvents KELASTextBox As TextBox
    Friend WithEvents JURUSANTextBox As TextBox
    Friend WithEvents HOBBYTextBox As TextBox
End Class
