Public Class frmSplash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Dim mainForm As New frmDashboard()
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
