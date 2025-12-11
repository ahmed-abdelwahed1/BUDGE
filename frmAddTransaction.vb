Public Class frmAddTransaction
    Private Sub frmAddTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' تعبئة القائمة بالتصنيفات الموجودة
        Dim dt As DataTable = GetData("SELECT CategoryID, CategoryName FROM Categories")
        cmbCategories.DataSource = dt
        cmbCategories.DisplayMember = "CategoryName"
        cmbCategories.ValueMember = "CategoryID"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtAmount.Text = "" Or cmbCategories.SelectedIndex = -1 Then
            MsgBox("Please fill data")
            Exit Sub
        End If

        Dim amount As Double = Val(txtAmount.Text)
        Dim catID As Integer = cmbCategories.SelectedValue
        Dim tDate As String = dtpDate.Value.ToString("yyyy-MM-dd") ' تنسيق التاريخ للأكسس
        Dim desc As String = txtDesc.Text

        Dim sql As String = "INSERT INTO Transactions (Amount, TransDate, Description, CategoryID) " &
                        "VALUES (" & amount & ", '" & tDate & "', '" & desc & "', " & catID & ")"

        If ExecuteQuery(sql) Then
            MsgBox("Transaction Saved!")
            Me.DialogResult = DialogResult.OK ' إشارة للشاشة الرئيسية أن الحفظ تم
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class