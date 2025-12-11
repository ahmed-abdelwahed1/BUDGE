Public Class frmAddTransaction

    Private Sub frmAddTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' تحميل التصنيفات في القائمة المنسدلة
        Dim dt As DataTable = GetData("SELECT CategoryID, CategoryName FROM Categories")
        cmbCategories.DataSource = dt
        cmbCategories.DisplayMember = "CategoryName"
        cmbCategories.ValueMember = "CategoryID"
        cmbCategories.SelectedIndex = -1 ' جعلها فارغة في البداية
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtAmount.Text = "" Or cmbCategories.SelectedIndex = -1 Then
            MsgBox("Please fill Amount and select a Category.")
            Exit Sub
        End If

        Dim amount As Double
        If Not Double.TryParse(txtAmount.Text, amount) Then
            MsgBox("Please enter a valid number for Amount.")
            Exit Sub
        End If

        Dim catID As Integer = Convert.ToInt32(cmbCategories.SelectedValue)
        Dim tDate As String = dtpDate.Value.ToString("yyyy-MM-dd")
        Dim desc As String = txtDesc.Text

        Dim sql As String = "INSERT INTO Transactions (Amount, TransDate, Description, CategoryID) " &
                            "VALUES (" & amount & ", '" & tDate & "', '" & desc & "', " & catID & ")"

        If ExecuteQuery(sql) Then
            MsgBox("Saved Successfully!")
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class