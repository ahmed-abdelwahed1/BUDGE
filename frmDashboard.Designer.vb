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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        lblIncome = New Label()
        lblExpense = New Label()
        lblBalance = New Label()
        DataGridView1 = New DataGridView()
        btnAdd = New Button()
        btnCategories = New Button()
        btnRefresh = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label1 = New Label()
        PictureBox5 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblIncome
        ' 
        lblIncome.AutoSize = True
        lblIncome.BackColor = SystemColors.Window
        lblIncome.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblIncome.ForeColor = Color.FromArgb(CByte(87), CByte(111), CByte(239))
        lblIncome.Location = New Point(423, 193)
        lblIncome.Name = "lblIncome"
        lblIncome.Size = New Size(226, 46)
        lblIncome.TabIndex = 0
        lblIncome.Text = "Total Income"
        ' 
        ' lblExpense
        ' 
        lblExpense.AutoSize = True
        lblExpense.BackColor = SystemColors.Window
        lblExpense.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblExpense.ForeColor = Color.FromArgb(CByte(87), CByte(111), CByte(239))
        lblExpense.Location = New Point(751, 193)
        lblExpense.Name = "lblExpense"
        lblExpense.Size = New Size(253, 46)
        lblExpense.TabIndex = 1
        lblExpense.Text = "Total Expenses"
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.BackColor = Color.FromArgb(CByte(87), CByte(111), CByte(239))
        lblBalance.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblBalance.ForeColor = SystemColors.Window
        lblBalance.Location = New Point(55, 193)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(274, 46)
        lblBalance.TabIndex = 2
        lblBalance.Text = "Current Balance"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(40, 396)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(980, 253)
        DataGridView1.TabIndex = 3
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(87), CByte(111), CByte(239))
        btnAdd.Font = New Font("Segoe UI", 12F)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(800, 320)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(220, 60)
        btnAdd.TabIndex = 4
        btnAdd.Text = "+ New Transaction"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnCategories
        ' 
        btnCategories.Font = New Font("Segoe UI", 12F)
        btnCategories.Location = New Point(561, 320)
        btnCategories.Name = "btnCategories"
        btnCategories.Size = New Size(220, 60)
        btnCategories.TabIndex = 5
        btnCategories.Text = "Manage Categories"
        btnCategories.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Font = New Font("Segoe UI", 12F)
        btnRefresh.Location = New Point(818, 24)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(220, 60)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "Refresh Data"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(24, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(222, 49)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(24, 145)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(328, 140)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(367, 145)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(328, 140)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(710, 145)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(328, 140)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 10
        PictureBox4.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Window
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(40, 314)
        Label1.Name = "Label1"
        Label1.Size = New Size(296, 41)
        Label1.TabIndex = 11
        Label1.Text = "Recent Transactions"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(24, 308)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(1014, 373)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 12
        PictureBox5.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(24, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(268, 41)
        Label2.TabIndex = 13
        Label2.Text = "Balance Summary"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Window
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.ForeColor = Color.FromArgb(CByte(87), CByte(111), CByte(239))
        Label3.Location = New Point(43, 355)
        Label3.Name = "Label3"
        Label3.Size = New Size(309, 23)
        Label3.TabIndex = 14
        Label3.Text = "List of the last 10 recorded transactions"
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1062, 693)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(btnRefresh)
        Controls.Add(btnCategories)
        Controls.Add(btnAdd)
        Controls.Add(DataGridView1)
        Controls.Add(lblBalance)
        Controls.Add(lblExpense)
        Controls.Add(lblIncome)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox5)
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BUDGE"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
