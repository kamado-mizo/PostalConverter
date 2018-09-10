<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class List
	Inherits System.Windows.Forms.Form

	'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

	'Windows フォーム デザイナーで必要です。
	Private components As System.ComponentModel.IContainer

	'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
	'Windows フォーム デザイナーを使用して変更できます。  
	'コード エディターを使って変更しないでください。
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.selectButton = New System.Windows.Forms.Button()
		Me.closeButton = New System.Windows.Forms.Button()
		Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowTemplate.Height = 21
		Me.DataGridView1.Size = New System.Drawing.Size(390, 234)
		Me.DataGridView1.TabIndex = 0
		'
		'selectButton
		'
		Me.selectButton.Location = New System.Drawing.Point(301, 252)
		Me.selectButton.Name = "selectButton"
		Me.selectButton.Size = New System.Drawing.Size(100, 40)
		Me.selectButton.TabIndex = 1
		Me.selectButton.Text = "Select"
		Me.selectButton.UseVisualStyleBackColor = True
		'
		'closeButton
		'
		Me.closeButton.Location = New System.Drawing.Point(12, 252)
		Me.closeButton.Name = "closeButton"
		Me.closeButton.Size = New System.Drawing.Size(100, 40)
		Me.closeButton.TabIndex = 2
		Me.closeButton.Text = "Close"
		Me.closeButton.UseVisualStyleBackColor = True
		'
		'List
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(413, 304)
		Me.Controls.Add(Me.closeButton)
		Me.Controls.Add(Me.selectButton)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "List"
		Me.Text = "検索結果"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents selectButton As Button
	Friend WithEvents closeButton As Button
	Friend WithEvents BindingSource1 As BindingSource
End Class
