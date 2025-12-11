Public Class frmSplash

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ... كود تفعيل Access الموجود سابقاً ...
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)

        ' إجبار النافذة أن تكون بمقاس الصورة بالضبط
        Me.ClientSize = New Size(800, 450)

        Timer1.Interval = 3000
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