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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategories))
        txtCatName = New TextBox()
        rbIncome = New RadioButton()
        rbExpense = New RadioButton()
        btnSave = New Button()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtCatName
        ' 
        txtCatName.Location = New Point(41, 146)
        txtCatName.Name = "txtCatName"
        txtCatName.Size = New Size(253, 27)
        txtCatName.TabIndex = 0
        ' 
        ' rbIncome
        ' 
        rbIncome.AutoSize = True
        rbIncome.Font = New Font("Segoe UI", 12F)
        rbIncome.Location = New Point(45, 237)
        rbIncome.Name = "rbIncome"
        rbIncome.Size = New Size(116, 32)
        rbIncome.TabIndex = 1
        rbIncome.TabStop = True
        rbIncome.Text = "+ Income"
        rbIncome.UseVisualStyleBackColor = True
        ' 
        ' rbExpense
        ' 
        rbExpense.AutoSize = True
        rbExpense.Font = New Font("Segoe UI", 12F)
        rbExpense.Location = New Point(178, 237)
        rbExpense.Name = "rbExpense"
        rbExpense.Size = New Size(116, 32)
        rbExpense.TabIndex = 2
        rbExpense.TabStop = True
        rbExpense.Text = "- Expense"
        rbExpense.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(87), CByte(111), CByte(239))
        btnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnSave.ForeColor = SystemColors.Window
        btnSave.Location = New Point(41, 291)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(253, 60)
        btnSave.TabIndex = 3
        btnSave.Text = "Save Category"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(341, 117)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(428, 234)
        DataGridView1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(87), CByte(111), CByte(239))
        Label2.Location = New Point(41, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(286, 41)
        Label2.TabIndex = 14
        Label2.Text = "Add New Category"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(41, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 28)
        Label1.TabIndex = 15
        Label1.Text = "Category Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(41, 197)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 28)
        Label3.TabIndex = 16
        Label3.Text = "Type"
        ' 
        ' frmCategories
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 380)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(btnSave)
        Controls.Add(rbExpense)
        Controls.Add(rbIncome)
        Controls.Add(txtCatName)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmCategories"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Categories"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCatName As TextBox
    Friend WithEvents rbIncome As RadioButton
    Friend WithEvents rbExpense As RadioButton
    Friend WithEvents btnSave As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
