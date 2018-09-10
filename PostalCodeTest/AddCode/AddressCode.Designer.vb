<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddressCode
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddressCode))
		Me.Title = New System.Windows.Forms.Label()
		Me.searchButton = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.closeButton = New System.Windows.Forms.Button()
		Me.View = New System.Windows.Forms.DataGridView()
		CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.View, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Title
		'
		Me.Title.AutoSize = True
		Me.Title.Location = New System.Drawing.Point(69, 19)
		Me.Title.Name = "Title"
		Me.Title.Size = New System.Drawing.Size(121, 12)
		Me.Title.TabIndex = 0
		Me.Title.Text = "住所→郵便番号　検索"
		'
		'searchButton
		'
		Me.searchButton.Location = New System.Drawing.Point(162, 137)
		Me.searchButton.Name = "searchButton"
		Me.searchButton.Size = New System.Drawing.Size(90, 29)
		Me.searchButton.TabIndex = 1
		Me.searchButton.Text = "Search!"
		Me.searchButton.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(12, 46)
		Me.TextBox1.MaxLength = 100
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(240, 19)
		Me.TextBox1.TabIndex = 2
		'
		'closeButton
		'
		Me.closeButton.Location = New System.Drawing.Point(11, 137)
		Me.closeButton.Name = "closeButton"
		Me.closeButton.Size = New System.Drawing.Size(90, 29)
		Me.closeButton.TabIndex = 6
		Me.closeButton.Text = "Close"
		Me.closeButton.UseVisualStyleBackColor = True
		'
		'View
		'
		Me.View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.View.Location = New System.Drawing.Point(14, 76)
		Me.View.Name = "View"
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
		Me.View.RowsDefaultCellStyle = DataGridViewCellStyle1
		Me.View.RowTemplate.Height = 21
		Me.View.Size = New System.Drawing.Size(237, 50)
		Me.View.TabIndex = 7
		'
		'AddressCode
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(262, 178)
		Me.Controls.Add(Me.View)
		Me.Controls.Add(Me.closeButton)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.searchButton)
		Me.Controls.Add(Me.Title)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "AddressCode"
		Me.Text = "住所から郵便番号"
		CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.View, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Title As Label
	Friend WithEvents searchButton As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents BindingSource1 As BindingSource
	Friend WithEvents closeButton As Button
	Friend WithEvents View As DataGridView
End Class
