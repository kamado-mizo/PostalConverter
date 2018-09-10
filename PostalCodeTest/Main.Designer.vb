<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PostalConverter
	Inherits System.Windows.Forms.Form

	'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

	'Windows フォーム デザイナーで必要です。
	Private components As System.ComponentModel.IContainer

	'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
	'Windows フォーム デザイナーを使用して変更できます。  
	'コード エディターを使って変更しないでください。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.codeAddButton = New System.Windows.Forms.Button()
		Me.addCodeButton = New System.Windows.Forms.Button()
		Me.closeButton = New System.Windows.Forms.Button()
		Me.creatorLabel = New System.Windows.Forms.Label()
		Me.titleLabel = New System.Windows.Forms.Label()
		Me.versionLabel = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'codeAddButton
		'
		Me.codeAddButton.Location = New System.Drawing.Point(12, 62)
		Me.codeAddButton.Name = "codeAddButton"
		Me.codeAddButton.Size = New System.Drawing.Size(123, 62)
		Me.codeAddButton.TabIndex = 0
		Me.codeAddButton.Text = "Code → Address"
		Me.codeAddButton.UseVisualStyleBackColor = True
		'
		'addCodeButton
		'
		Me.addCodeButton.Location = New System.Drawing.Point(149, 62)
		Me.addCodeButton.Name = "addCodeButton"
		Me.addCodeButton.Size = New System.Drawing.Size(123, 62)
		Me.addCodeButton.TabIndex = 1
		Me.addCodeButton.Text = "Address → Code"
		Me.addCodeButton.UseVisualStyleBackColor = True
		'
		'closeButton
		'
		Me.closeButton.Location = New System.Drawing.Point(12, 145)
		Me.closeButton.Name = "closeButton"
		Me.closeButton.Size = New System.Drawing.Size(92, 27)
		Me.closeButton.TabIndex = 2
		Me.closeButton.Text = "Close"
		Me.closeButton.UseVisualStyleBackColor = True
		'
		'creatorLabel
		'
		Me.creatorLabel.AutoSize = True
		Me.creatorLabel.Location = New System.Drawing.Point(174, 38)
		Me.creatorLabel.Name = "creatorLabel"
		Me.creatorLabel.Size = New System.Drawing.Size(98, 12)
		Me.creatorLabel.TabIndex = 3
		Me.creatorLabel.Text = "Project by Yosaku"
		'
		'titleLabel
		'
		Me.titleLabel.AutoSize = True
		Me.titleLabel.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.titleLabel.Location = New System.Drawing.Point(56, 9)
		Me.titleLabel.Name = "titleLabel"
		Me.titleLabel.Size = New System.Drawing.Size(160, 20)
		Me.titleLabel.TabIndex = 4
		Me.titleLabel.Text = "PostalConverter"
		'
		'versionLabel
		'
		Me.versionLabel.AutoSize = True
		Me.versionLabel.Location = New System.Drawing.Point(222, 16)
		Me.versionLabel.Name = "versionLabel"
		Me.versionLabel.Size = New System.Drawing.Size(25, 12)
		Me.versionLabel.TabIndex = 5
		Me.versionLabel.Text = "v1.0"
		'
		'PostalConverter
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 184)
		Me.Controls.Add(Me.versionLabel)
		Me.Controls.Add(Me.titleLabel)
		Me.Controls.Add(Me.creatorLabel)
		Me.Controls.Add(Me.closeButton)
		Me.Controls.Add(Me.addCodeButton)
		Me.Controls.Add(Me.codeAddButton)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "PostalConverter"
		Me.Text = "PostalConverter"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents codeAddButton As Button
	Friend WithEvents addCodeButton As Button
	Friend WithEvents closeButton As Button
	Friend WithEvents creatorLabel As Label
	Friend WithEvents titleLabel As Label
	Friend WithEvents versionLabel As Label
End Class
