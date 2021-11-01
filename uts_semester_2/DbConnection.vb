Module DbConnection
    Public conn As New ADODB.Connection
    Public rs As New ADODB.Recordset

    Public Sub openConn()
        conn.Open("DSN=pl")
    End Sub

    Public Sub closeConn()
        conn.Close()
    End Sub
End Module
