Public Class frmDashboard
    Public Sub LoadData()
        ' 1. حساب الإجماليات
        Dim dtInc As DataTable = GetData("SELECT SUM(Amount) FROM Transactions WHERE CategoryID IN (SELECT CategoryID FROM Categories WHERE CatType='Income')")
        Dim dtExp As DataTable = GetData("SELECT SUM(Amount) FROM Transactions WHERE CategoryID IN (SELECT CategoryID FROM Categories WHERE CatType='Expense')")

        Dim totalIncome As Double = If(IsDBNull(dtInc.Rows(0)(0)), 0, dtInc.Rows(0)(0))
        Dim totalExpense As Double = If(IsDBNull(dtExp.Rows(0)(0)), 0, dtExp.Rows(0)(0))

        lblIncome.Text = "Income: $" & totalIncome
        lblExpense.Text = "Expense: $" & totalExpense
        lblBalance.Text = "Balance: $" & (totalIncome - totalExpense)

        ' 2. عرض آخر العمليات مع اسم التصنيف
        Dim sql As String = "SELECT top 10 T.TransactionID, T.Amount, C.CategoryName, T.TransDate, T.Description " &
                        "FROM Transactions T INNER JOIN Categories C ON T.CategoryID = C.CategoryID " &
                        "ORDER BY T.TransDate DESC"
        DataGridView1.DataSource = GetData(sql)
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New frmAddTransaction()
        If frm.ShowDialog() = DialogResult.OK Then
            LoadData() ' تحديث البيانات بعد الإضافة
        End If
    End Sub

    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click
        Dim frm As New frmCategories()
        frm.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData()
    End Sub

    ' إغلاق التطبيق بالكامل عند إغلاق هذه الشاشة
    Private Sub frmDashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class