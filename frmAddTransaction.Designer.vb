<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddTransaction
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtAmount = New TextBox()
        cmbCategories = New ComboBox()
        dtpDate = New DateTimePicker()
        txtDesc = New TextBox()
        btnSave = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(38, 29)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(125, 27)
        txtAmount.TabIndex = 0
        ' 
        ' cmbCategories
        ' 
        cmbCategories.FormattingEnabled = True
        cmbCategories.Location = New Point(38, 86)
        cmbCategories.Name = "cmbCategories"
        cmbCategories.Size = New Size(151, 28)
        cmbCategories.TabIndex = 1
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(38, 144)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(250, 27)
        dtpDate.TabIndex = 2
        ' 
        ' txtDesc
        ' 
        txtDesc.Location = New Point(38, 200)
        txtDesc.Name = "txtDesc"
        txtDesc.Size = New Size(125, 27)
        txtDesc.TabIndex = 3
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(38, 288)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 4
        btnSave.Text = "Button1"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(150, 288)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Button1"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' frmAddTransaction
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(txtDesc)
        Controls.Add(dtpDate)
        Controls.Add(cmbCategories)
        Controls.Add(txtAmount)
        Name = "frmAddTransaction"
        Text = "frmAddTransaction"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtAmount As TextBox
    Friend WithEvents cmbCategories As ComboBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
