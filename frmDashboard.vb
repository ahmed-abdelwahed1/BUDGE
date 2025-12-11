Imports System.Data.OleDb

Public Class frmDashboard

    ' تعريف دالة تحميل البيانات
    Public Sub LoadData()
        Try
            ' --- الجزء الأول: حساب الدخل ---
            ' جملة الاستعلام للدخل
            Dim sqlInc As String = "SELECT SUM(Amount) FROM Transactions WHERE CategoryID IN (SELECT CategoryID FROM Categories WHERE CatType='Income')"
            Dim dtInc As DataTable = GetData(sqlInc)

            Dim totalIncome As Double = 0
            ' التأكد من وجود بيانات قبل التحويل لتجنب الأخطاء
            If dtInc.Rows.Count > 0 Then
                If Not IsDBNull(dtInc.Rows(0)(0)) Then
                    totalIncome = Convert.ToDouble(dtInc.Rows(0)(0))
                End If
            End If

            ' --- الجزء الثاني: حساب المصروفات ---
            ' جملة الاستعلام للمصروفات
            Dim sqlExp As String = "SELECT SUM(Amount) FROM Transactions WHERE CategoryID IN (SELECT CategoryID FROM Categories WHERE CatType='Expense')"
            Dim dtExp As DataTable = GetData(sqlExp)

            Dim totalExpense As Double = 0
            ' التأكد من وجود بيانات قبل التحويل
            If dtExp.Rows.Count > 0 Then
                If Not IsDBNull(dtExp.Rows(0)(0)) Then
                    totalExpense = Convert.ToDouble(dtExp.Rows(0)(0))
                End If
            End If

            ' --- الجزء الثالث: عرض الملخص ---
            lblIncome.Text = "Income: $" & totalIncome.ToString("N2")
            lblExpense.Text = "Expense: $" & totalExpense.ToString("N2")
            lblBalance.Text = "Balance: $" & (totalIncome - totalExpense).ToString("N2")

            ' --- الجزء الرابع: تعبئة الجدول ---
            ' لاحظ طريقة كتابة النص الطويل باستخدام العلامة (&) بشكل صحيح
            Dim sqlGrid As String = "SELECT top 10 T.TransactionID, T.Amount, C.CategoryName, T.TransDate, T.Description " &
                                    "FROM Transactions T INNER JOIN Categories C ON T.CategoryID = C.CategoryID " &
                                    "ORDER BY T.TransDate DESC"

            DataGridView1.DataSource = GetData(sqlGrid)

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

End Class