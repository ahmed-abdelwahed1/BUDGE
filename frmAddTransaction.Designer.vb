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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddTransaction))
        txtAmount = New TextBox()
        cmbCategories = New ComboBox()
        dtpDate = New DateTimePicker()
        txtDesc = New TextBox()
        btnSave = New Button()
        btnCancel = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtAmount
        ' 
        txtAmount.Font = New Font("Segoe UI", 10F)
        txtAmount.Location = New Point(150, 146)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(346, 30)
        txtAmount.TabIndex = 0
        txtAmount.Text = "$ 00.00"
        ' 
        ' cmbCategories
        ' 
        cmbCategories.Font = New Font("Segoe UI", 10F)
        cmbCategories.FormattingEnabled = True
        cmbCategories.Location = New Point(57, 249)
        cmbCategories.Name = "cmbCategories"
        cmbCategories.Size = New Size(151, 31)
        cmbCategories.TabIndex = 1
        ' 
        ' dtpDate
        ' 
        dtpDate.Font = New Font("Segoe UI", 10F)
        dtpDate.Location = New Point(232, 249)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(264, 30)
        dtpDate.TabIndex = 2
        ' 
        ' txtDesc
        ' 
        txtDesc.Font = New Font("Segoe UI", 10F)
        txtDesc.Location = New Point(57, 337)
        txtDesc.Name = "txtDesc"
        txtDesc.Size = New Size(439, 30)
        txtDesc.TabIndex = 3
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(87), CByte(111), CByte(239))
        btnSave.Font = New Font("Segoe UI", 12F)
        btnSave.ForeColor = SystemColors.Window
        btnSave.Location = New Point(276, 399)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(220, 60)
        btnSave.TabIndex = 4
        btnSave.Text = "Add Transaction"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Font = New Font("Segoe UI", 12F)
        btnCancel.Location = New Point(57, 399)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(180, 60)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(87), CByte(111), CByte(239))
        Label1.Location = New Point(120, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(319, 41)
        Label1.TabIndex = 6
        Label1.Text = "Add New Transaction"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(57, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 28)
        Label2.TabIndex = 7
        Label2.Text = "Amount"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(57, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 28)
        Label3.TabIndex = 8
        Label3.Text = "Category"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.Location = New Point(232, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 28)
        Label4.TabIndex = 9
        Label4.Text = "Date"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.Location = New Point(57, 296)
        Label5.Name = "Label5"
        Label5.Size = New Size(121, 28)
        Label5.TabIndex = 10
        Label5.Text = "Description"
        ' 
        ' frmAddTransaction
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(562, 516)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(txtDesc)
        Controls.Add(dtpDate)
        Controls.Add(cmbCategories)
        Controls.Add(txtAmount)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAddTransaction"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add New Transaction"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtAmount As TextBox
    Friend WithEvents cmbCategories As ComboBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
