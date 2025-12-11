Imports System.Data.OleDb

Public Class frmDashboard

    ' تعريف دالة تحميل البيانات
    Public Sub LoadData()
        Try
            ' 1. حساب الإجماليات
            Dim dtInc As DataTable = GetData("SELECT SUM(Amount) FROM Transactions WHERE CategoryID IN (SELECT CategoryID FROM Categories WHERE CatType='Income')")
            Dim totalIncome As Double = 0
            If dtInc.Rows.Count > 0 AndAlso Not IsDBNull(dtInc.Rows(0)(0)) Then
                totalIncome = Convert.ToDouble(dtInc.Rows(0)(0))
            End If

            Dim dtExp As DataTable = GetData("SELECT SUM(Amount) FROM Transactions WHERE CategoryID IN (SELECT CategoryID FROM Categories WHERE CatType='Expense')")
            Dim totalExpense As Double = 0
            If dtExp.Rows.Count > 0 AndAlso Not IsDBNull(dtExp.Rows(0)(0)) Then
                totalExpense = Convert.ToDouble(dtExp.Rows(0)(0))
            End If

            lblIncome.Text = totalIncome.ToString("N2") & " EGP"
            lblExpense.Text = totalExpense.ToString("N2") & " EGP"
            lblBalance.Text = (totalIncome - totalExpense).ToString("N2") & " EGP"

            ' 2. جلب البيانات للجدول
            Dim sqlGrid As String = "SELECT top 10 T.TransactionID, T.Amount, C.CategoryName, T.TransDate, T.Description " &
                                    "FROM Transactions T INNER JOIN Categories C ON T.CategoryID = C.CategoryID " &
                                    "ORDER BY T.TransDate DESC"

            DataGridView1.DataSource = GetData(sqlGrid)

            ' 3. >>> تطبيق التصميم الجمالي هنا <<<
            StyleGrid(DataGridView1)

            ' 4. تحسينات إضافية (تغيير أسماء الأعمدة لتكون مفهومة)
            If DataGridView1.Columns.Count > 0 Then
                DataGridView1.Columns("TransactionID").Visible = False ' إخفاء المعرف
                DataGridView1.Columns("Amount").HeaderText = "Amount ($)"
                DataGridView1.Columns("Amount").DefaultCellStyle.Format = "N2"
                DataGridView1.Columns("CategoryName").HeaderText = "Category"
                DataGridView1.Columns("TransDate").HeaderText = "Date"
                DataGridView1.Columns("Description").HeaderText = "Description"
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading dashboard: " & ex.Message)
        End Try
    End Sub

    ' حدث تحميل الشاشة
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    ' زر الإضافة
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New frmAddTransaction()
        ' عند إغلاق شاشة الإضافة بنجاح، نقوم بتحديث البيانات
        If frm.ShowDialog() = DialogResult.OK Then
            LoadData()
        End If
    End Sub

    ' زر التصنيفات
    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click
        Dim frm As New frmCategories()
        frm.ShowDialog()
    End Sub

    ' زر التحديث
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData()
    End Sub

    ' إغلاق التطبيق عند إغلاق هذه النافذة
    Private Sub frmDashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

End Class