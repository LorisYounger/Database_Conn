Public Class ClsInfo
    Public ID As Integer
    Public Block As String
    Public Nid As String
    Public Info As String
    Sub New(ID As String, Block As String, Nid As String, Info As String)
        Me.ID = ID
        Me.Block = Block
        Me.Nid = Nid
        Me.Info = Info
    End Sub
End Class
