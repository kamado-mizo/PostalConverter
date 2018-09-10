Public Class converter
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim dataTbl As DataTable
		dataTbl = New DataTable
		dataTbl.Columns.Add(New DataColumn("郵便番号", GetType(String)))
		dataTbl.Columns.Add(New DataColumn("都道府県名"))
		dataTbl.Columns.Add(New DataColumn("市区町村名"))
		dataTbl.Columns.Add(New DataColumn("町域名"))
		dataTbl.Columns.Add(New DataColumn("住所"))
		Dim WriteRecord(124190, 2) As String
		Dim i As Integer
		Dim recordCount As Integer = 0


		'読み込み結果用の配列を定義します。
		Dim arrCsvData As New System.Collections.ArrayList()

		'CSVファイル名を設定します。
		Dim strFileName As String
		strFileName = My.Application.Info.DirectoryPath & "\addcode.csv"

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

		While Not swText.EndOfData
			'CSVファイルのフィールドを読み込みます。
			Dim fields As String() = swText.ReadFields()
			'配列に追加します。
			arrCsvData.Add(fields)
		End While

		'ファイルを解放します。
		swText.Close()

		Dim count As Integer = 0

		Dim writtenidx As Integer
		Dim idx As Integer = 0

		For Each arr As String() In arrCsvData

			dataTbl.Rows.Add()
			writtenidx = idx
			dataTbl.Rows(idx).Item("郵便番号") = arr(0) '郵便番号
			dataTbl.Rows(idx).Item("都道府県名") = arr(1) '都道府県
			dataTbl.Rows(idx).Item("市区町村名") = arr(2) '市区町村名
			dataTbl.Rows(idx).Item("町域名") = arr(3) '町域名
			dataTbl.Rows(idx).Item("住所") = arr(4) '住所

			count = count + 1
			idx = idx + 1

		Next

		dataTbl.Columns.Remove("都道府県名")
		dataTbl.Columns.Remove("市区町村名")
		dataTbl.Columns.Remove("町域名")

		DataGridView1.DataSource = dataTbl

		'Dim textFile As IO.StreamWriter ' -- 出力するファイル
		'Dim textLine As String  ' -- 書き出す１行
		'Dim cellData As String  ' -- セルのデータ
		'' --- ファイルのインスタンスを作る
		'textFile = New IO.StreamWriter _
		'  (My.Application.Info.DirectoryPath & "\change.csv", False, System.Text.Encoding.UTF8)    ' -- ファイル名、上書き、エンコーディング
		'' ---① 列見出しを書き出す
		'textLine = ""   ' -- 行の文字列をクリア
		'' --- １行目（列見出し）を書き出す
		'For myCol As Integer = 0 To Me.DataGridView1.ColumnCount - 1
		'	If myCol = Me.DataGridView1.ColumnCount - 1 Then
		'		textLine += Me.DataGridView1.Columns(myCol).HeaderText  ' -- 最終列ならタブを付けない
		'	Else
		'		textLine += Me.DataGridView1.Columns(myCol).HeaderText & vbTab  ' -- 途中の列ならタブを付加
		'	End If
		'Next
		'textFile.WriteLine(textLine)    ' -- 終端文字付きで１行を書き出す
		'' ---② セルのデータを書き出す
		'For myRow As Integer = 0 To Me.DataGridView1.RowCount - 1
		'	textLine = ""   ' -- 行の文字列をクリア
		'	For myCol As Integer = 0 To Me.DataGridView1.ColumnCount - 1
		'		If IsDBNull(Me.DataGridView1(myCol, myRow).Value) Then
		'			cellData = ""
		'		Else
		'			cellData = Me.DataGridView1(myCol, myRow).Value.ToString
		'		End If
		'		If (myCol = Me.DataGridView1.ColumnCount - 1) Then
		'			textLine += cellData    ' -- 最終列ならタブを付けない
		'		Else
		'			textLine += cellData & vbTab ' -- 途中の列には項目の後にタブを付加する
		'		End If
		'	Next
		'	textFile.WriteLine(textLine)    ' -- 終端文字付きで１行を書き出す
		'Next
		'' ---
		'textFile.Close()    ' -- StreamWriter を閉じて
		'textFile.Dispose()  ' -- StreamWriter を解放
		'' ---
		'MessageBox.Show("CSV ファイルを出力しました")

		recordCount = count

		'csvファイルへの書き込み処理
		Dim sw As System.IO.StreamWriter = Nothing
		Try
			sw = New System.IO.StreamWriter(My.Application.Info.DirectoryPath & "\change.csv", False, System.Text.Encoding.GetEncoding("Shift_jis"))

			For i = 0 To recordCount - 1
				WriteRecord(i, 0) = dataTbl.Rows(i).Item(0).ToString
				WriteRecord(i, 1) = dataTbl.Rows(i).Item(1).ToString
				sw.Write(WriteRecord(i, 0) & ",")
				sw.WriteLine(WriteRecord(i, 1))


			Next
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Errror!")
		Finally
			MessageBox.Show("かきこめました")
			If sw IsNot Nothing Then
				sw.Close()
				sw.Dispose()
			End If
		End Try

	End Sub

	'Private Sub converter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	'	'Dim dataTbl As DataTable
	'	'dataTbl = New DataTable
	'	'dataTbl.Columns.Add(New DataColumn("郵便番号", GetType(String)))
	'	'dataTbl.Columns.Add(New DataColumn("都道府県名"))
	'	'dataTbl.Columns.Add(New DataColumn("市区町村名"))
	'	'dataTbl.Columns.Add(New DataColumn("町域名"))
	'	'dataTbl.Columns.Add(New DataColumn("住所"))


	'	''読み込み結果用の配列を定義します。
	'	'Dim arrCsvData As New System.Collections.ArrayList()

	'	''CSVファイル名を設定します。
	'	'Dim strFileName As String
	'	'strFileName = My.Application.Info.DirectoryPath & "\addcode.csv"

	'	''Shift JISで読み込みます。
	'	'Dim swText As New FileIO.TextFieldParser(strFileName,
	'	'System.Text.Encoding.GetEncoding(932))

	'	''フィールドが文字で区切られている設定を行います。
	'	''（初期値がDelimited）
	'	'swText.TextFieldType = FileIO.FieldType.Delimited

	'	''区切り文字を「,（カンマ）」に設定します。
	'	'swText.Delimiters = New String() {","}

	'	''フィールドを"で囲み、改行文字、区切り文字を含めることが 'できるかを設定します。
	'	''（初期値がtrue）
	'	'swText.HasFieldsEnclosedInQuotes = True

	'	''フィールドの前後からスペースを削除する設定を行います。
	'	''（初期値がtrue）
	'	'swText.TrimWhiteSpace = True

	'	'While Not swText.EndOfData
	'	'	'CSVファイルのフィールドを読み込みます。
	'	'	Dim fields As String() = swText.ReadFields()
	'	'	'配列に追加します。
	'	'	arrCsvData.Add(fields)
	'	'End While

	'	''ファイルを解放します。
	'	'swText.Close()

	'	'Dim count As Integer = 0

	'	'Dim writtenidx As Integer
	'	'Dim idx As Integer = 0

	'	'For Each arr As String() In arrCsvData

	'	'	dataTbl.Rows.Add()
	'	'	writtenidx = idx
	'	'	dataTbl.Rows(idx).Item("郵便番号") = arr(0) '郵便番号
	'	'	dataTbl.Rows(idx).Item("都道府県名") = arr(1) '都道府県
	'	'	dataTbl.Rows(idx).Item("市区町村名") = arr(2) '市区町村名
	'	'	dataTbl.Rows(idx).Item("町域名") = arr(3) '町域名
	'	'	dataTbl.Rows(idx).Item("住所") = arr(4) '住所

	'	'	count = count + 1
	'	'	idx = idx + 1

	'	'Next

	'	'dataTbl.Columns.Remove("都道府県名")
	'	'dataTbl.Columns.Remove("市区町村名")
	'	'dataTbl.Columns.Remove("町域名")

	'	'DataGridView1.DataSource = dataTbl

	'End Sub
End Class