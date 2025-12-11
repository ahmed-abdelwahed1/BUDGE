Imports System.Data.OleDb

Module DbHelper
    ' مسار قاعدة البيانات
    Public ConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BudgeDB.accdb"
    Public Conn As New OleDbConnection(ConnString)

    ' دالة لجلب البيانات (SELECT)
    Public Function GetData(sql As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim cmd As New OleDbCommand(sql, Conn)
            Dim adapter As New OleDbDataAdapter(cmd)
            adapter.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in GetData: " & ex.Message)
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
            MsgBox("Error in ExecuteQuery: " & ex.Message)
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Return False
        End Try
    End Function

    ' --- أضف هذا الكود في نهاية ملف DbHelper.vb ---

    Public Sub StyleGrid(dgv As DataGridView)
        ' 1. الإعدادات العامة
        dgv.BorderStyle = BorderStyle.None
        dgv.BackgroundColor = Color.White
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv.EnableHeadersVisualStyles = False ' ضروري لتفعيل الألوان

        ' 2. تنسيق رأس الجدول (Header)
        dgv.ColumnHeadersHeight = 40
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 113, 199) ' أزرق الشعار
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' 3. تنسيق الصفوف
        dgv.DefaultCellStyle.BackColor = Color.White
        dgv.DefaultCellStyle.ForeColor = Color.Black
        dgv.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 243, 255) ' أزرق فاتح جداً عند التحديد
        dgv.DefaultCellStyle.SelectionForeColor = Color.Black
        dgv.RowTemplate.Height = 35

        ' 4. إعدادات إضافية
        dgv.RowHeadersVisible = False ' إخفاء العمود الجانبي
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' ملء الشاشة
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect ' تحديد الصف بالكامل
    End Sub

End Module