Public Class CodeAdd

    Dim dataTbl As New DataTable
    Dim idx As Integer = 0
    Dim index As Integer = -1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.ControlBox = False

        dataTbl.Columns.Add(New DataColumn("郵便番号", GetType(String)))
        dataTbl.Columns.Add(New DataColumn("都道府県名"))
        dataTbl.Columns.Add(New DataColumn("市区町村名"))
        dataTbl.Columns.Add(New DataColumn("町域名"))
        'dataTbl.Columns.Add(New DataColumn("例外郵便番号フラグ"))
        'dataTbl.Columns.Add(New DataColumn("番地起番フラグ"))
        'dataTbl.Columns.Add(New DataColumn("丁目フラグ"))
        'dataTbl.Columns.Add(New DataColumn("例外町域フラグ"))
        'dataTbl.Columns.Add(New DataColumn("更新フラグ"))
        'dataTbl.Columns.Add(New DataColumn("変更理由"))

        '読み込み結果用の配列を定義します。
        Dim arrCsvData As New System.Collections.ArrayList()

        'CSVファイル名を設定します。
        Dim strFileName As String
        strFileName = My.Application.Info.DirectoryPath & "\KEN_ALL_small.csv"

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
        For Each arr As String() In arrCsvData

            dataTbl.Rows.Add()
            writtenidx = idx
            dataTbl.Rows(idx).Item("郵便番号") = arr(0) '郵便番号
            dataTbl.Rows(idx).Item("都道府県名") = arr(1) '都道府県
            dataTbl.Rows(idx).Item("市区町村名") = arr(2) '市区町村名
            dataTbl.Rows(idx).Item("町域名") = arr(3) '町域名
            'dataTbl.Rows(idx).Item(4) = arr(4)
            'dataTbl.Rows(idx).Item(5) = arr(5)
            'dataTbl.Rows(idx).Item(6) = arr(6) '都道府県名
            'dataTbl.Rows(idx).Item(7) = arr(7)　'市区町村名
            'dataTbl.Rows(idx).Item(8) = arr(8)
            'dataTbl.Rows(idx).Item(9) = arr(9)
            'dataTbl.Rows(idx).Item(10) = arr(10)
            'dataTbl.Rows(idx).Item(11) = arr(11)
            'dataTbl.Rows(idx).Item(12) = arr(12)
            'dataTbl.Rows(idx).Item(13) = arr(13)
            'dataTbl.Rows(idx).Item(14) = arr(14)


            count = count + 1
            idx = idx + 1

        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rows As DataRow()


        If IsNumeric(code.Text) Then

            errorLabel.Visible = False
            rows = dataTbl.Select("郵便番号= '" & code.Text & "'")

            If rows.Length <> 0 Then
                'addBox.Text = dataTbl.Rows(0).Item(0)

                addBox.Text = rows(0)(2) & rows(0)(3)
                index = ComboBox1.FindString(rows(0)(1))
                ComboBox1.SelectedIndex = index
            Else
                ComboBox1.SelectedIndex = 47
                addBox.Text = "ないよ！"
            End If

        Else

            errorLabel.Visible = True
            errorLabel.Text = "7桁の数値を" & vbCrLf & "入力してください"

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class
