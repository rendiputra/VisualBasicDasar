<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Dim NoLabel As System.Windows.Forms.Label
        Dim KoranLabel As System.Windows.Forms.Label
        Me.TestDataSet = New test.testDataSet()
        Me.AnuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnuTableAdapter = New test.testDataSetTableAdapters.anuTableAdapter()
        Me.TableAdapterManager = New test.testDataSetTableAdapters.TableAdapterManager()
        Me.AnuBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AnuBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NoTextBox = New System.Windows.Forms.TextBox()
        Me.KoranTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        NoLabel = New System.Windows.Forms.Label()
        KoranLabel = New System.Windows.Forms.Label()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnuBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnuBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TestDataSet
        '
        Me.TestDataSet.DataSetName = "testDataSet"
        Me.TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnuBindingSource
        '
        Me.AnuBindingSource.DataMember = "anu"
        Me.AnuBindingSource.DataSource = Me.TestDataSet
        '
        'AnuTableAdapter
        '
        Me.AnuTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.anuTableAdapter = Me.AnuTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.siswaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = test.testDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AnuBindingNavigator
        '
        Me.AnuBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AnuBindingNavigator.BindingSource = Me.AnuBindingSource
        Me.AnuBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AnuBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AnuBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AnuBindingNavigatorSaveItem})
        Me.AnuBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AnuBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AnuBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AnuBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AnuBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AnuBindingNavigator.Name = "AnuBindingNavigator"
        Me.AnuBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AnuBindingNavigator.Size = New System.Drawing.Size(362, 25)
        Me.AnuBindingNavigator.TabIndex = 0
        Me.AnuBindingNavigator.Text = "BindingNavigator1"
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
        'AnuBindingNavigatorSaveItem
        '
        Me.AnuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AnuBindingNavigatorSaveItem.Image = CType(resources.GetObject("AnuBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AnuBindingNavigatorSaveItem.Name = "AnuBindingNavigatorSaveItem"
        Me.AnuBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.AnuBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NoLabel
        '
        NoLabel.AutoSize = True
        NoLabel.Location = New System.Drawing.Point(50, 83)
        NoLabel.Name = "NoLabel"
        NoLabel.Size = New System.Drawing.Size(22, 13)
        NoLabel.TabIndex = 1
        NoLabel.Text = "no:"
        '
        'NoTextBox
        '
        Me.NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnuBindingSource, "no", True))
        Me.NoTextBox.Location = New System.Drawing.Point(93, 80)
        Me.NoTextBox.Name = "NoTextBox"
        Me.NoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NoTextBox.TabIndex = 2
        '
        'KoranLabel
        '
        KoranLabel.AutoSize = True
        KoranLabel.Location = New System.Drawing.Point(50, 109)
        KoranLabel.Name = "KoranLabel"
        KoranLabel.Size = New System.Drawing.Size(37, 13)
        KoranLabel.TabIndex = 3
        KoranLabel.Text = "koran:"
        '
        'KoranTextBox
        '
        Me.KoranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnuBindingSource, "koran", True))
        Me.KoranTextBox.Location = New System.Drawing.Point(93, 106)
        Me.KoranTextBox.Name = "KoranTextBox"
        Me.KoranTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KoranTextBox.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(151, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(NoLabel)
        Me.Controls.Add(Me.NoTextBox)
        Me.Controls.Add(KoranLabel)
        Me.Controls.Add(Me.KoranTextBox)
        Me.Controls.Add(Me.AnuBindingNavigator)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnuBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnuBindingNavigator.ResumeLayout(False)
        Me.AnuBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TestDataSet As testDataSet
    Friend WithEvents AnuBindingSource As BindingSource
    Friend WithEvents AnuTableAdapter As testDataSetTableAdapters.anuTableAdapter
    Friend WithEvents TableAdapterManager As testDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AnuBindingNavigator As BindingNavigator
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
    Friend WithEvents AnuBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NoTextBox As TextBox
    Friend WithEvents KoranTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
