<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategories
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
        txtCatName = New TextBox()
        rbIncome = New RadioButton()
        rbExpense = New RadioButton()
        btnSave = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtCatName
        ' 
        txtCatName.Location = New Point(90, 44)
        txtCatName.Name = "txtCatName"
        txtCatName.Size = New Size(125, 27)
        txtCatName.TabIndex = 0
        ' 
        ' rbIncome
        ' 
        rbIncome.AutoSize = True
        rbIncome.Location = New Point(90, 91)
        rbIncome.Name = "rbIncome"
        rbIncome.Size = New Size(121, 24)
        rbIncome.TabIndex = 1
        rbIncome.TabStop = True
        rbIncome.Text = "RadioButton1"
        rbIncome.UseVisualStyleBackColor = True
        ' 
        ' rbExpense
        ' 
        rbExpense.AutoSize = True
        rbExpense.Location = New Point(90, 121)
        rbExpense.Name = "rbExpense"
        rbExpense.Size = New Size(121, 24)
        rbExpense.TabIndex = 2
        rbExpense.TabStop = True
        rbExpense.Text = "RadioButton1"
        rbExpense.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(103, 207)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 3
        btnSave.Text = "Button1"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(273, 207)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(300, 188)
        DataGridView1.TabIndex = 4
        ' 
        ' frmCategories
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(btnSave)
        Controls.Add(rbExpense)
        Controls.Add(rbIncome)
        Controls.Add(txtCatName)
        Name = "frmCategories"
        Text = "frmCategories"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCatName As TextBox
    Friend WithEvents rbIncome As RadioButton
    Friend WithEvents rbExpense As RadioButton
    Friend WithEvents btnSave As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
