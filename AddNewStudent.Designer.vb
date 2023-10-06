<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewStudent
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
        lblName = New Label()
        tbxName = New TextBox()
        lblScore = New Label()
        tbxScore = New TextBox()
        Label1 = New Label()
        lblScores = New Label()
        lblScoresBox = New Label()
        AddScore = New Button()
        btnClear = New Button()
        btnCancel = New Button()
        btnOK = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(14, 13)
        lblName.Name = "lblName"
        lblName.Size = New Size(42, 15)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' tbxName
        ' 
        tbxName.Location = New Point(59, 5)
        tbxName.Name = "tbxName"
        tbxName.Size = New Size(185, 23)
        tbxName.TabIndex = 1
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Location = New Point(17, 40)
        lblScore.Margin = New Padding(2, 0, 2, 0)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(39, 15)
        lblScore.TabIndex = 2
        lblScore.Text = "Score:"
        ' 
        ' tbxScore
        ' 
        tbxScore.Location = New Point(59, 32)
        tbxScore.Name = "tbxScore"
        tbxScore.Size = New Size(105, 23)
        tbxScore.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 4
        ' 
        ' lblScores
        ' 
        lblScores.AutoSize = True
        lblScores.Location = New Point(17, 75)
        lblScores.Margin = New Padding(2, 0, 2, 0)
        lblScores.Name = "lblScores"
        lblScores.Size = New Size(44, 15)
        lblScores.TabIndex = 5
        lblScores.Text = "Scores:"
        ' 
        ' lblScoresBox
        ' 
        lblScoresBox.BackColor = SystemColors.Control
        lblScoresBox.BorderStyle = BorderStyle.Fixed3D
        lblScoresBox.FlatStyle = FlatStyle.Flat
        lblScoresBox.Location = New Point(59, 74)
        lblScoresBox.Margin = New Padding(2, 0, 2, 0)
        lblScoresBox.Name = "lblScoresBox"
        lblScoresBox.Size = New Size(185, 17)
        lblScoresBox.TabIndex = 6
        ' 
        ' AddScore
        ' 
        AddScore.Location = New Point(169, 31)
        AddScore.Name = "AddScore"
        AddScore.Size = New Size(75, 23)
        AddScore.TabIndex = 7
        AddScore.Text = "&Add Score"
        AddScore.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(160, 113)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(84, 23)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear &Scores"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(160, 144)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(84, 23)
        btnCancel.TabIndex = 9
        btnCancel.Text = "&Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnOK
        ' 
        btnOK.Location = New Point(59, 144)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(84, 23)
        btnOK.TabIndex = 10
        btnOK.Text = "&Okay"
        btnOK.UseVisualStyleBackColor = True
        ' 
        ' AddNewStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(300, 179)
        Controls.Add(btnOK)
        Controls.Add(btnCancel)
        Controls.Add(btnClear)
        Controls.Add(AddScore)
        Controls.Add(lblScoresBox)
        Controls.Add(lblScores)
        Controls.Add(Label1)
        Controls.Add(tbxScore)
        Controls.Add(lblScore)
        Controls.Add(tbxName)
        Controls.Add(lblName)
        Name = "AddNewStudent"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add New Student"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents tbxName As TextBox
    Friend WithEvents lblScore As Label
    Friend WithEvents tbxScore As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblScores As Label
    Friend WithEvents lblScoresBox As Label
    Friend WithEvents AddScore As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
End Class
