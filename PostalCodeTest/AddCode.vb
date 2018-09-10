Public Class AddCode


    Dim dataTbl As New DataTable
    Dim idx As Integer = 0
    Dim index As Integer = -1
    Dim str As String


    Private Sub AddCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.ControlBox = False

        dataTbl.Columns.Add(New DataColumn("郵便番号", GetType(String)))
        dataTbl.Columns.Add(New DataColumn("都道府県名"))
        dataTbl.Columns.Add(New DataColumn("市区町村名"))
        dataTbl.Columns.Add(New DataColumn("町域名"))


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
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        str = ComboBox1.SelectedIndex
        addBox.Text = str
    End Sub
End Class