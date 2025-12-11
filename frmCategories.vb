Imports System.Data.OleDb

Public Class frmCategories

    ' دالة تحميل البيانات
    Private Sub LoadCategories()
        Try
            Dim sql As String = "SELECT CategoryID, CategoryName, CatType FROM Categories"
            DataGridView1.DataSource = GetData(sql)

            ' 1. تطبيق الستايل الجمالي العام
            StyleGrid(DataGridView1)

            ' 2. تحسينات خاصة بجدول التصنيفات
            If DataGridView1.Columns.Count > 0 Then
                ' إخفاء رقم المعرف لأنه لا يهم المستخدم
                DataGridView1.Columns("CategoryID").Visible = False

                ' تغيير عناوين الأعمدة لتكون أوضح
                DataGridView1.Columns("CategoryName").HeaderText = "Category Name"
                DataGridView1.Columns("CatType").HeaderText = "Type"

                ' توسيط عمود النوع لجمال أكثر
                DataGridView1.Columns("CatType").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading: " & ex.Message)
        End Try
    End Sub

    ' حدث تحميل الشاشة
    Private Sub frmCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    ' زر الحفظ
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' التحقق من الاسم
        If txtCatName.Text.Trim() = "" Then
            MessageBox.Show("Please enter a name.")
            Exit Sub
        End If

        ' تحديد النوع (تم تغيير اسم المتغير هنا لحل مشكلة الصورة الثانية)
        Dim myCatType As String = "Expense"
        If rbIncome.Checked = True Then
            myCatType = "Income"
        End If

        ' الحفظ
        Try
            Dim sql As String = "INSERT INTO Categories (CategoryName, CatType) VALUES ('" & txtCatName.Text & "', '" & myCatType & "')"

            If ExecuteQuery(sql) Then
                MessageBox.Show("Saved!")
                LoadCategories()
                txtCatName.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class