Public Class List

	Private clickFlg As Boolean


	Private Sub List_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		'ウィンドウのサイズを変更不可
		Me.FormBorderStyle = FormBorderStyle.FixedSingle
		Me.ControlBox = False
		Me.StartPosition = FormStartPosition.CenterScreen
		'DataGridView1の列の幅をユーザーが変更できないようにする
		DataGridView1.AllowUserToResizeColumns = False
		'DataGridView1の行の高さをユーザーが変更できないようにする
		DataGridView1.AllowUserToResizeRows = False


		'DGVの設定　
		DataGridView1.AllowUserToAddRows = False '一番下に行追加をしないようにする
		DataGridView1.ReadOnly = True


		clickFlg = False
		Dim dataTbl As DataTable
		Dim selectTbl As DataTable
		selectTbl = New DataTable
		dataTbl = New DataTable
		Dim idx As Integer = 0
		selectButton.Enabled = False


		'住所検索用テーブル
		dataTbl.Columns.Add(New DataColumn("郵便番号", GetType(String)))
		dataTbl.Columns.Add(New DataColumn("住所"))
		'検索結果表示用テーブル
		selectTbl.Columns.Add(New DataColumn("郵便番号", GetType(String)))
		selectTbl.Columns.Add(New DataColumn("住所"))


		'読み込み結果用の配列を定義します。
		Dim arrCsvData As New System.Collections.ArrayList()

		'CSVファイル名を設定します。
		Dim strFileName As String
		strFileName = My.Application.Info.DirectoryPath & "\change.csv"

		'Shift JISで読み込みます。
		Dim swText As New FileIO.TextFieldParser(strFileName,
		System.Text.Encoding.GetEncoding(932))

		'フィールドが文字で区切られている設定を行います。
		'（初期値がDelimited）
		swText.TextFieldType = FileIO.FieldType.Delimited

		'区切り文字を「,（カンマ）」に設定します。
		swText.Delimiters = New String() {","}

		'フィールドを"で囲み、改行文字、区切り文字を含めることが 'できるかを設定します。
		'（初期値がtrue）
		swText.HasFieldsEnclosedInQuotes = True

		'フィールドの前後からスペースを削除する設定を行います。
		'（初期値がtrue）
		swText.TrimWhiteSpace = True

		Try
			While Not swText.EndOfData
				'CSVファイルのフィールドを読み込みます。
				Dim fields As String() = swText.ReadFields()
				'配列に追加します。
				arrCsvData.Add(fields)
			End While
		Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
			MsgBox("エラーが発生しました", MsgBoxStyle.OkOnly, "Error")
		Finally
			'ファイルを解放します。
			swText.Close()
		End Try



		Dim count As Integer = 0

		Dim writtenidx As Integer

		'csvの中身を配列にすべて入れる
		For Each arr As String() In arrCsvData

			dataTbl.Rows.Add()
			writtenidx = idx
			dataTbl.Rows(idx).Item("郵便番号") = arr(0) '郵便番号
			dataTbl.Rows(idx).Item("住所") = arr(1) '住所

			count = count + 1
			idx = idx + 1

		Next


		Me.BindingSource1.DataSource = dataTbl

		'検索住所が入力されていたら、dataTblから合致する住所を検索
		'検索結果をDGVにバインドする
		If public_changeAdd.Length > 0 Then
			Me.BindingSource1.Filter = "住所 Like '*" & public_changeAdd & "*'"
			DataGridView1.DataSource = Me.BindingSource1
		End If

		'DGVの設定
		DataGridView1.RowHeadersVisible = False
		DataGridView1.Columns(0).Width = 60
		DataGridView1.Columns(1).Width = 300

		'DGVの列ソートを無効
		For Each c As DataGridViewColumn In DataGridView1.Columns
			c.SortMode = DataGridViewColumnSortMode.NotSortable
		Next c

		'DGVの選択を行単位でのみに設定
		DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

	End Sub


	Private Sub Close_Click(sender As Object, e As EventArgs) Handles closeButton.Click
		AddressCode.Show()
		Me.Close()
	End Sub


	Private Sub Select_Click(sender As Object, e As EventArgs) Handles selectButton.Click

		'clickFlg = Not clickFlg
		'行が選択されていた場合
		If clickFlg = True Then
			'選択されている郵便番号、住所をモジュール変数に代入
			public_selectCode = DataGridView1.CurrentRow.Cells(0).Value
			public_selectAdd = DataGridView1.CurrentRow.Cells(1).Value

			AddressCode.Show()
			Me.Close()
			Me.Dispose()
		End If

	End Sub

	Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
		clickFlg = True
		selectButton.Enabled = True
	End Sub
End Class