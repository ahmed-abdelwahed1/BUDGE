Imports System.Data.OleDb

Module DbHelper
    ' مسار قاعدة البيانات النسبي
    Public ConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BUDGEDB.accdb"
    Public Conn As New OleDbConnection(ConnString)

    ' دالة لجلب البيانات (SELECT)
    Public Function GetData(sql As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim cmd As New OleDbCommand(sql, Conn)
            Dim adapter As New OleDbDataAdapter(cmd)
            adapter.Fill(dt)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        Return dt
    End Function

    ' دالة لتنفيذ الأوامر (INSERT, UPDATE, DELETE)
    Public Function ExecuteQuery(sql As String) As Boolean
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()
            Dim cmd As New OleDbCommand(sql, Conn)
            cmd.ExecuteNonQuery()
            Conn.Close()
            Return True
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Return False
        End Try
    End Function
End Module