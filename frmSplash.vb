Public Class frmSplash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Dim mainForm As New frmDashboard()
        mainForm.Show()
        Me.Hide()
    End Sub
End Class
