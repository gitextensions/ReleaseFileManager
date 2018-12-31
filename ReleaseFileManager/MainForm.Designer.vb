<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
		  Me.dgvPortable = New System.Windows.Forms.DataGridView()
		  Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		  Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		  Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		  Me.CommentedOutDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		  Me.Output = New System.Windows.Forms.DataGridViewTextBoxColumn()
		  Me.LineTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		  Me.XCopyArgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
		  Me.FilePathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		  Me.PortableBuildLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		  Me.cboConfiguration = New System.Windows.Forms.ComboBox()
		  CType(Me.dgvPortable, System.ComponentModel.ISupportInitialize).BeginInit()
		  CType(Me.PortableBuildLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		  Me.SuspendLayout()
		  '
		  'dgvPortable
		  '
		  Me.dgvPortable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
				Or System.Windows.Forms.AnchorStyles.Left) _
				Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		  Me.dgvPortable.AutoGenerateColumns = False
		  Me.dgvPortable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		  Me.dgvPortable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CommentedOutDataGridViewCheckBoxColumn, Me.Output, Me.LineTypeDataGridViewTextBoxColumn, Me.XCopyArgs, Me.FilePathDataGridViewTextBoxColumn})
		  Me.dgvPortable.DataSource = Me.PortableBuildLineBindingSource
		  Me.dgvPortable.Location = New System.Drawing.Point(12, 23)
		  Me.dgvPortable.Name = "dgvPortable"
		  Me.dgvPortable.Size = New System.Drawing.Size(776, 282)
		  Me.dgvPortable.TabIndex = 1
		  '
		  'DataGridViewTextBoxColumn2
		  '
		  Me.DataGridViewTextBoxColumn2.DataPropertyName = "XCopyArgs"
		  Me.DataGridViewTextBoxColumn2.HeaderText = "XCopyArgs"
		  Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		  Me.DataGridViewTextBoxColumn2.ReadOnly = True
		  '
		  'DataGridViewTextBoxColumn3
		  '
		  Me.DataGridViewTextBoxColumn3.DataPropertyName = "XCopyArgs"
		  Me.DataGridViewTextBoxColumn3.HeaderText = "XCopyArgs"
		  Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		  Me.DataGridViewTextBoxColumn3.ReadOnly = True
		  '
		  'DataGridViewTextBoxColumn1
		  '
		  Me.DataGridViewTextBoxColumn1.DataPropertyName = "Output"
		  Me.DataGridViewTextBoxColumn1.HeaderText = "Output"
		  Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		  Me.DataGridViewTextBoxColumn1.ReadOnly = True
		  '
		  'CommentedOutDataGridViewCheckBoxColumn
		  '
		  Me.CommentedOutDataGridViewCheckBoxColumn.DataPropertyName = "CommentedOut"
		  Me.CommentedOutDataGridViewCheckBoxColumn.HeaderText = "Commented Out"
		  Me.CommentedOutDataGridViewCheckBoxColumn.Name = "CommentedOutDataGridViewCheckBoxColumn"
		  '
		  'Output
		  '
		  Me.Output.DataPropertyName = "Output"
		  Me.Output.HeaderText = "Output"
		  Me.Output.Name = "Output"
		  Me.Output.ReadOnly = True
		  '
		  'LineTypeDataGridViewTextBoxColumn
		  '
		  Me.LineTypeDataGridViewTextBoxColumn.DataPropertyName = "LineType"
		  Me.LineTypeDataGridViewTextBoxColumn.HeaderText = "LineType"
		  Me.LineTypeDataGridViewTextBoxColumn.Name = "LineTypeDataGridViewTextBoxColumn"
		  Me.LineTypeDataGridViewTextBoxColumn.ReadOnly = True
		  '
		  'XCopyArgs
		  '
		  Me.XCopyArgs.DataPropertyName = "XCopyArgs"
		  Me.XCopyArgs.HeaderText = "XCopy Args"
		  Me.XCopyArgs.Name = "XCopyArgs"
		  Me.XCopyArgs.ReadOnly = True
		  '
		  'FilePathDataGridViewTextBoxColumn
		  '
		  Me.FilePathDataGridViewTextBoxColumn.DataPropertyName = "FilePath"
		  Me.FilePathDataGridViewTextBoxColumn.HeaderText = "FilePath"
		  Me.FilePathDataGridViewTextBoxColumn.Name = "FilePathDataGridViewTextBoxColumn"
		  Me.FilePathDataGridViewTextBoxColumn.ReadOnly = True
		  '
		  'PortableBuildLineBindingSource
		  '
		  Me.PortableBuildLineBindingSource.DataSource = GetType(ReleaseFileManager.PortableBuildLine)
		  '
		  'cboConfiguration
		  '
		  Me.cboConfiguration.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		  Me.cboConfiguration.FormattingEnabled = True
		  Me.cboConfiguration.Items.AddRange(New Object() {"Debug", "Release"})
		  Me.cboConfiguration.Location = New System.Drawing.Point(84, 374)
		  Me.cboConfiguration.Name = "cboConfiguration"
		  Me.cboConfiguration.Size = New System.Drawing.Size(121, 21)
		  Me.cboConfiguration.TabIndex = 2
		  '
		  'MainForm
		  '
		  Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		  Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		  Me.ClientSize = New System.Drawing.Size(800, 450)
		  Me.Controls.Add(Me.cboConfiguration)
		  Me.Controls.Add(Me.dgvPortable)
		  Me.Name = "MainForm"
		  Me.Text = "Form1"
		  CType(Me.dgvPortable, System.ComponentModel.ISupportInitialize).EndInit()
		  CType(Me.PortableBuildLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		  Me.ResumeLayout(False)

	 End Sub
	 Friend WithEvents dgvPortable As DataGridView
	 Friend WithEvents PortableBuildLineBindingSource As BindingSource
	 Friend WithEvents ArgsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	 Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	 Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
	 Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
	 Friend WithEvents CommentedOutDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
	 Friend WithEvents Output As DataGridViewTextBoxColumn
	 Friend WithEvents LineTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	 Friend WithEvents XCopyArgs As DataGridViewTextBoxColumn
	 Friend WithEvents FilePathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	 Friend WithEvents cboConfiguration As ComboBox
End Class
