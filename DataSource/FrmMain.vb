Imports System.IO
Imports System.Net

Public Class FrmMain
    Dim Key As Integer = DateAndTime.Day(Now)+ Month(Now) +Year(Now)

    'Public Function Upload(Namekey As String, Info As String) As String
    '    'Dim tmp As WebBrowser
    '    Return Conn(Key, "Install",)
    'End Function
    Public Function Conn(Key As String, Action As String, Optional Block As String = "NoF", Optional Nid As String = "NoF", Optional Info As String = "NoF") As String
        Try
            Dim UrlAdress As String = "http://" & TextBoxPath.Text & "?Key=" & Key & "&Action=" & Action & "&Block=" & Block & "&Nid=" & Nid & "&Info=" & Info
            Dim stream As IO.Stream = WebRequest.Create(UrlAdress).GetResponse().GetResponseStream()
            '注意urladress为你上面的网页地址。
            Dim sr As StreamReader = New StreamReader(stream, System.Text.Encoding.UTF8)
            Dim ReadText As String = sr.ReadToEnd '由于这里并非读取全部文件，有空的可能性
            sr.Dispose() '关闭流
            Return ReadText
        Catch ex As Exception
            Return "Error:" & vbCrLf & ex.ToString
        End Try
    End Function

    Private Sub ButtonCal_Click(sender As Object, e As EventArgs) Handles ButtonCal.Click
        TextBoxKey.Text = DateAndTime.Day(Now)+ Month(Now) +Year(Now)
    End Sub

    Private Sub TextBoxKey_TextChanged(sender As Object, e As EventArgs) Handles TextBoxKey.TextChanged
        If IsNumeric(TextBoxKey.Text) Then Key = TextBoxKey.Text
    End Sub

    Private Sub ButtonCon_Click(sender As Object, e As EventArgs) Handles ButtonCon.Click
        Dim Tmp As String = Conn(TextBoxKey.Text, ComboBoxFun.Text, TextBoxBlock.Text, TextBoxNid.Text, TextBoxInfo.Text)
        Dim InfoList As New List(Of ClsInfo)
        Dim tmps() As String = Split(Tmp, vbCrLf)
        Dim tmpss() As String
        Dim tmpsss As New List(Of String)
        For i = 0 To tmps.Length - 1
            tmpss = Split(tmps(i), ":|")
            If tmpss.Length > 2 Then
                tmpsss.Clear()
                For b = 0 To tmpss.Length - 2
                    tmpsss.Add(Split(tmpss(b), "#")(1))
                Next
                InfoList.Add(New ClsInfo(tmpsss(0), tmpsss(1), tmpsss(2), tmpss(3)))
            End If
        Next
        TextBoxOutPut.Text = Tmp & vbCrLf & Now
        ListViewOutPut.Items.Clear()
        For i = 0 To InfoList.Count - 1
            ListViewOutPut.Items.Add(InfoList(i).ID)
            ListViewOutPut.Items.Item(i).SubItems.Add(InfoList(i).Block)
            ListViewOutPut.Items.Item(i).SubItems.Add(InfoList(i).Nid)
            ListViewOutPut.Items.Item(i).SubItems.Add(InfoList(i).Info)
        Next
    End Sub

    Private Sub ListViewOutPut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewOutPut.SelectedIndexChanged
        If ListViewOutPut.SelectedIndices.Count <> 0 Then
            If ListViewOutPut.SelectedIndices(0) <> -1 Then
                TextBoxBlock.Text = ListViewOutPut.SelectedItems(0).SubItems(1).Text
                TextBoxNid.Text = ListViewOutPut.SelectedItems(0).SubItems(2).Text
                TextBoxInfo.Text = ListViewOutPut.SelectedItems(0).SubItems(3).Text
            End If
        End If
    End Sub
End Class
