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
        Dim NisLabel As System.Windows.Forms.Label
        Dim Nama_siswaLabel As System.Windows.Forms.Label
        Dim KelasLabel As System.Windows.Forms.Label
        Dim JurusanLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Db_siswaDataSet = New test.db_siswaDataSet()
        Me.Tb_siswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_siswaTableAdapter = New test.db_siswaDataSetTableAdapters.tb_siswaTableAdapter()
        Me.TableAdapterManager = New test.db_siswaDataSetTableAdapters.TableAdapterManager()
        Me.Tb_siswaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tb_siswaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NisTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_siswaTextBox = New System.Windows.Forms.TextBox()
        Me.KelasTextBox = New System.Windows.Forms.TextBox()
        Me.JurusanTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TestDataSet = New test.testDataSet()
        Me.AnuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnuTableAdapter = New test.testDataSetTableAdapters.anuTableAdapter()
        Me.TableAdapterManager1 = New test.testDataSetTableAdapters.TableAdapterManager()
        Me.Tb_siswaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        NisLabel = New System.Windows.Forms.Label()
        Nama_siswaLabel = New System.Windows.Forms.Label()
        KelasLabel = New System.Windows.Forms.Label()
        JurusanLabel = New System.Windows.Forms.Label()
        CType(Me.Db_siswaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_siswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_siswaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_siswaBindingNavigator.SuspendLayout()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_siswaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NisLabel
        '
        NisLabel.AutoSize = True
        NisLabel.Font = New System.Drawing.Font("Product Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NisLabel.Location = New System.Drawing.Point(31, 24)
        NisLabel.Name = "NisLabel"
        NisLabel.Size = New System.Drawing.Size(37, 24)
        NisLabel.TabIndex = 1
        NisLabel.Text = "nis:"
        '
        'Nama_siswaLabel
        '
        Nama_siswaLabel.AutoSize = True
        Nama_siswaLabel.Font = New System.Drawing.Font("Product Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nama_siswaLabel.Location = New System.Drawing.Point(31, 50)
        Nama_siswaLabel.Name = "Nama_siswaLabel"
        Nama_siswaLabel.Size = New System.Drawing.Size(110, 24)
        Nama_siswaLabel.TabIndex = 3
        Nama_siswaLabel.Text = "nama siswa:"
        '
        'KelasLabel
        '
        KelasLabel.AutoSize = True
        KelasLabel.Font = New System.Drawing.Font("Product Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KelasLabel.Location = New System.Drawing.Point(31, 76)
        KelasLabel.Name = "KelasLabel"
        KelasLabel.Size = New System.Drawing.Size(56, 24)
        KelasLabel.TabIndex = 5
        KelasLabel.Text = "kelas:"
        '
        'JurusanLabel
        '
        JurusanLabel.AutoSize = True
        JurusanLabel.Font = New System.Drawing.Font("Product Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JurusanLabel.Location = New System.Drawing.Point(31, 102)
        JurusanLabel.Name = "JurusanLabel"
        JurusanLabel.Size = New System.Drawing.Size(74, 24)
        JurusanLabel.TabIndex = 7
        JurusanLabel.Text = "jurusan:"
        '
        'Db_siswaDataSet
        '
        Me.Db_siswaDataSet.DataSetName = "db_siswaDataSet"
        Me.Db_siswaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_siswaBindingSource
        '
        Me.Tb_siswaBindingSource.DataMember = "tb_siswa"
        Me.Tb_siswaBindingSource.DataSource = Me.Db_siswaDataSet
        '
        'Tb_siswaTableAdapter
        '
        Me.Tb_siswaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_siswaTableAdapter = Me.Tb_siswaTableAdapter
        Me.TableAdapterManager.UpdateOrder = test.db_siswaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_siswaBindingNavigator
        '
        Me.Tb_siswaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tb_siswaBindingNavigator.BindingSource = Me.Tb_siswaBindingSource
        Me.Tb_siswaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_siswaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tb_siswaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tb_siswaBindingNavigatorSaveItem})
        Me.Tb_siswaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_siswaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_siswaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_siswaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_siswaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_siswaBindingNavigator.Name = "Tb_siswaBindingNavigator"
        Me.Tb_siswaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_siswaBindingNavigator.Size = New System.Drawing.Size(763, 25)
        Me.Tb_siswaBindingNavigator.TabIndex = 0
        Me.Tb_siswaBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tb_siswaBindingNavigatorSaveItem
        '
        Me.Tb_siswaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tb_siswaBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tb_siswaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tb_siswaBindingNavigatorSaveItem.Name = "Tb_siswaBindingNavigatorSaveItem"
        Me.Tb_siswaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tb_siswaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NisTextBox
        '
        Me.NisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_siswaBindingSource, "nis", True))
        Me.NisTextBox.Location = New System.Drawing.Point(147, 24)
        Me.NisTextBox.Name = "NisTextBox"
        Me.NisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NisTextBox.TabIndex = 2
        '
        'Nama_siswaTextBox
        '
        Me.Nama_siswaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_siswaBindingSource, "nama_siswa", True))
        Me.Nama_siswaTextBox.Location = New System.Drawing.Point(147, 50)
        Me.Nama_siswaTextBox.Name = "Nama_siswaTextBox"
        Me.Nama_siswaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nama_siswaTextBox.TabIndex = 4
        '
        'KelasTextBox
        '
        Me.KelasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_siswaBindingSource, "kelas", True))
        Me.KelasTextBox.Location = New System.Drawing.Point(147, 76)
        Me.KelasTextBox.Name = "KelasTextBox"
        Me.KelasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KelasTextBox.TabIndex = 6
        '
        'JurusanTextBox
        '
        Me.JurusanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_siswaBindingSource, "jurusan", True))
        Me.JurusanTextBox.Location = New System.Drawing.Point(147, 102)
        Me.JurusanTextBox.Name = "JurusanTextBox"
        Me.JurusanTextBox.Size = New System.Drawing.Size(100, 20)
        Me.JurusanTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Product Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(63, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 49)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.anuTableAdapter = Me.AnuTableAdapter
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.siswaTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = test.testDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_siswaDataGridView
        '
        Me.Tb_siswaDataGridView.AutoGenerateColumns = False
        Me.Tb_siswaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_siswaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Tb_siswaDataGridView.DataSource = Me.Tb_siswaBindingSource
        Me.Tb_siswaDataGridView.Location = New System.Drawing.Point(345, 12)
        Me.Tb_siswaDataGridView.Name = "Tb_siswaDataGridView"
        Me.Tb_siswaDataGridView.Size = New System.Drawing.Size(435, 220)
        Me.Tb_siswaDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nis"
        Me.DataGridViewTextBoxColumn1.HeaderText = "nis"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nama_siswa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nama_siswa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "kelas"
        Me.DataGridViewTextBoxColumn3.HeaderText = "kelas"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "jurusan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "jurusan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Product Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 52)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abcdefghaijklmnopqrstuvwxyz"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(485, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 439)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tb_siswaDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(NisLabel)
        Me.Controls.Add(Me.NisTextBox)
        Me.Controls.Add(Nama_siswaLabel)
        Me.Controls.Add(Me.Nama_siswaTextBox)
        Me.Controls.Add(KelasLabel)
        Me.Controls.Add(Me.KelasTextBox)
        Me.Controls.Add(JurusanLabel)
        Me.Controls.Add(Me.JurusanTextBox)
        Me.Controls.Add(Me.Tb_siswaBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Db_siswaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_siswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_siswaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_siswaBindingNavigator.ResumeLayout(False)
        Me.Tb_siswaBindingNavigator.PerformLayout()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_siswaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db_siswaDataSet As db_siswaDataSet
    Friend WithEvents Tb_siswaBindingSource As BindingSource
    Friend WithEvents Tb_siswaTableAdapter As db_siswaDataSetTableAdapters.tb_siswaTableAdapter
    Friend WithEvents TableAdapterManager As db_siswaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_siswaBindingNavigator As BindingNavigator
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
    Friend WithEvents Tb_siswaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NisTextBox As TextBox
    Friend WithEvents Nama_siswaTextBox As TextBox
    Friend WithEvents KelasTextBox As TextBox
    Friend WithEvents JurusanTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TestDataSet As testDataSet
    Friend WithEvents AnuBindingSource As BindingSource
    Friend WithEvents AnuTableAdapter As testDataSetTableAdapters.anuTableAdapter
    Friend WithEvents TableAdapterManager1 As testDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_siswaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
