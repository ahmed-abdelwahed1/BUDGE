<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        lblIncome = New Label()
        lblExpense = New Label()
        lblBalance = New Label()
        DataGridView1 = New DataGridView()
        btnAdd = New Button()
        btnCategories = New Button()
        btnRefresh = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblIncome
        ' 
        lblIncome.AutoSize = True
        lblIncome.Location = New Point(127, 157)
        lblIncome.Name = "lblIncome"
        lblIncome.Size = New Size(53, 20)
        lblIncome.TabIndex = 0
        lblIncome.Text = "Label1"
        ' 
        ' lblExpense
        ' 
        lblExpense.AutoSize = True
        lblExpense.Location = New Point(127, 192)
        lblExpense.Name = "lblExpense"
        lblExpense.Size = New Size(53, 20)
        lblExpense.TabIndex = 1
        lblExpense.Text = "Label1"
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.Location = New Point(127, 234)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(53, 20)
        lblBalance.TabIndex = 2
        lblBalance.Text = "Label1"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(216, 157)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(300, 188)
        DataGridView1.TabIndex = 3
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(127, 386)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Button1"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnCategories
        ' 
        btnCategories.Location = New Point(238, 386)
        btnCategories.Name = "btnCategories"
        btnCategories.Size = New Size(94, 29)
        btnCategories.TabIndex = 5
        btnCategories.Text = "Button1"
        btnCategories.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(357, 386)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(94, 29)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "Button1"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnRefresh)
        Controls.Add(btnCategories)
        Controls.Add(btnAdd)
        Controls.Add(DataGridView1)
        Controls.Add(lblBalance)
        Controls.Add(lblExpense)
        Controls.Add(lblIncome)
        Name = "frmDashboard"
        Text = "BUDGE"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIncome As Label
    Friend WithEvents lblExpense As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCategories As Button
    Friend WithEvents btnRefresh As Button
End Class
