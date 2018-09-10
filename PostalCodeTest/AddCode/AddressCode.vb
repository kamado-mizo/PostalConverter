Imports System.Text.RegularExpressions '正規表現を使うため

Public Class AddressCode
	Dim dataTbl As New DataTable
	Dim idx As Integer = 0

	Private Sub AddressCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		'DGVの設定
		View.RowHeadersVisible = False
		View.ColumnHeadersVisible = False
		View.AllowUserToAddRows = False
		View.ReadOnly = True
		View.AllowUserToResizeColumns = False
		View.AllowUserToResizeRows = False

		public_loadFlg = Not public_loadFlg

		'DGVソート無効
		For Each c As DataGridViewColumn In View.Columns
			c.SortMode = DataGridViewColumnSortMode.NotSortable
		Next c


		Me.StartPosition = FormStartPosition.CenterScreen
		Me.FormBorderStyle = FormBorderStyle.FixedSingle
		Me.ControlBox = False


		Dim viewTbl As DataTable
		viewTbl = New DataTable
		TextBox1.Text = public_addString

		Dim nRow As DataRow
		viewTbl.Columns.Add(New DataColumn("data"))
		'検索結果表示用TBLに郵便番号の行を追加
		nRow = viewTbl.NewRow
		nRow("data") = public_selectCode
		viewTbl.Rows.Add(nRow)

		'検索結果表示用TBLに住所の行を追加
		nRow = viewTbl.NewRow
		nRow("data") = public_selectAdd
		viewTbl.Rows.Add(nRow)

		'検索結果TBLをDGVにバインド
		View.DataSource = viewTbl

		'DGVの列の幅を設定
		View.Columns("data").Width = 230

	End Sub

	Private Sub search_Click(sender As Object, e As EventArgs) Handles searchButton.Click

		Dim idx As Integer
		Dim addStr As String
		Dim reng As Integer

		public_addString = TextBox1.Text
		addStr = TextBox1.Text
		reng = addStr.Length

		'入力住所に数字が入力されていた時に、数字以下を除去する処理
		'最初に出てきた数字の位置を探索
		idx = SearchNum(addStr)

		'もし、数字が入っていたら数字以下を除去しaddStrを設定しなおす
		If idx > 0 Then
			addStr = StringMake(addStr, idx, reng)
		End If

		'モジュール変数に代入
		public_changeAdd = addStr


		List.Show()
		Me.Close()

	End Sub

	Private Sub close_Click(sender As Object, e As EventArgs) Handles closeButton.Click
		PostalConverter.Show()
		Me.Close()
		Me.Dispose()
	End Sub


	'数字探索関数
	Public Function SearchNum(addStr As String) As Integer

		Dim arrayNum() As Char
		arrayNum = New Char() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "０", "１", "２", "３", "４", "５", "６", "７", "８", "９"}
		Dim idx As Integer
		'Dim reg As New Regex("[^0-9]")
		''reg.Match(addStr, 0)
		'数字が一番最初に出てきた位置を取得
		idx = addStr.IndexOfAny(arrayNum)

		Return idx

	End Function

	'番地以下なし文字列作成
	Public Function StringMake(addStr As String, idx As Integer, reng As Integer) As String

		Dim returnStr As String
		Dim stringNum As Integer

		stringNum = reng - idx
		stringNum = reng - stringNum

		'文字列の最初から数字が出てくるところまでを
		returnStr = addStr.Substring(0, stringNum)

		Return returnStr

	End Function


End Class