Public Class frmCategories
    Private Sub LoadCategories()
        DataGridView1.DataSource = GetData("SELECT * FROM Categories")
    End Sub

    Private Sub frmCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCatName.Text = "" Then Exit Sub

        Dim cType As String = If(rbIncome.Checked, "Income", "Expense")
        ' جملة الإدراج
        Dim sql As String = "INSERT INTO Categories (CategoryName, CatType) VALUES ('" & txtCatName.Text & "', '" & CType & "')"

    If ExecuteQuery(sql) Then
            MsgBox("Category Added!")
            LoadCategories()
            txtCatName.Clear()
        End If
    End Sub
End Class