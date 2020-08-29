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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALAMATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LatihanDataSet = New Aplikasi_Database.latihanDataSet()
        Me.Table1TableAdapter = New Aplikasi_Database.latihanDataSetTableAdapters.Table1TableAdapter()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.btnbuttom = New System.Windows.Forms.Button()
        Me.btnprevesios = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LatihanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NIPDataGridViewTextBoxColumn, Me.NAMADataGridViewTextBoxColumn, Me.ALAMATDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(421, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'NIPDataGridViewTextBoxColumn
        '
        Me.NIPDataGridViewTextBoxColumn.DataPropertyName = "NIP"
        Me.NIPDataGridViewTextBoxColumn.HeaderText = "NIP"
        Me.NIPDataGridViewTextBoxColumn.Name = "NIPDataGridViewTextBoxColumn"
        '
        'NAMADataGridViewTextBoxColumn
        '
        Me.NAMADataGridViewTextBoxColumn.DataPropertyName = "NAMA"
        Me.NAMADataGridViewTextBoxColumn.HeaderText = "NAMA"
        Me.NAMADataGridViewTextBoxColumn.Name = "NAMADataGridViewTextBoxColumn"
        '
        'ALAMATDataGridViewTextBoxColumn
        '
        Me.ALAMATDataGridViewTextBoxColumn.DataPropertyName = "ALAMAT"
        Me.ALAMATDataGridViewTextBoxColumn.HeaderText = "ALAMAT"
        Me.ALAMATDataGridViewTextBoxColumn.Name = "ALAMATDataGridViewTextBoxColumn"
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.LatihanDataSet
        '
        'LatihanDataSet
        '
        Me.LatihanDataSet.DataSetName = "latihanDataSet"
        Me.LatihanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'btnfirst
        '
        Me.btnfirst.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnfirst.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnfirst.Location = New System.Drawing.Point(25, 189)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(79, 27)
        Me.btnfirst.TabIndex = 1
        Me.btnfirst.Text = "First"
        Me.btnfirst.UseVisualStyleBackColor = False
        '
        'btnbuttom
        '
        Me.btnbuttom.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnbuttom.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbuttom.Location = New System.Drawing.Point(25, 234)
        Me.btnbuttom.Name = "btnbuttom"
        Me.btnbuttom.Size = New System.Drawing.Size(79, 27)
        Me.btnbuttom.TabIndex = 2
        Me.btnbuttom.Text = "Buttom"
        Me.btnbuttom.UseVisualStyleBackColor = False
        '
        'btnprevesios
        '
        Me.btnprevesios.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnprevesios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnprevesios.Location = New System.Drawing.Point(128, 189)
        Me.btnprevesios.Name = "btnprevesios"
        Me.btnprevesios.Size = New System.Drawing.Size(79, 27)
        Me.btnprevesios.TabIndex = 3
        Me.btnprevesios.Text = "Prevesios"
        Me.btnprevesios.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnnext.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnnext.Location = New System.Drawing.Point(128, 234)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(79, 27)
        Me.btnnext.TabIndex = 4
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnadd.Location = New System.Drawing.Point(228, 189)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(79, 27)
        Me.btnadd.TabIndex = 5
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndelete.Location = New System.Drawing.Point(228, 234)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(79, 27)
        Me.btndelete.TabIndex = 6
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsave.Location = New System.Drawing.Point(323, 189)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(79, 27)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnclose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnclose.Location = New System.Drawing.Point(323, 234)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(79, 27)
        Me.btnclose.TabIndex = 8
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 335)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnprevesios)
        Me.Controls.Add(Me.btnbuttom)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LatihanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LatihanDataSet As latihanDataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As latihanDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents NIPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ALAMATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnfirst As Button
    Friend WithEvents btnbuttom As Button
    Friend WithEvents btnprevesios As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnclose As Button
End Class
