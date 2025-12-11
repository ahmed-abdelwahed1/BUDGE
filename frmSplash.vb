Public Class frmSplash

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' هذا السطر ضروري جداً لتشغيل Access في نسخ .NET الحديثة
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)

        Timer1.Interval = 3000 ' 3 ثواني
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Dim mainForm As New frmDashboard()
        mainForm.Show()
        Me.Hide()
    End Sub
End Class