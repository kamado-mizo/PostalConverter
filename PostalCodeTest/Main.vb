Public Class PostalConverter
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles codeAddButton.Click
		CodeAddress.Show()
		Me.Hide()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles addCodeButton.Click
		AddressCode.Show()
		Me.Hide()
	End Sub

	Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.FormBorderStyle = FormBorderStyle.FixedSingle
		Me.ControlBox = False
	End Sub

	Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
		Me.Close()
		Me.Dispose()
	End Sub
End Class