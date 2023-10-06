<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addscore
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
        lblScore = New Label()
        tbxScore = New TextBox()
        btnCancel = New Button()
        btnAdd = New Button()
        SuspendLayout()
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Location = New Point(25, 11)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(39, 15)
        lblScore.TabIndex = 0
        lblScore.Text = "Score:"
        ' 
        ' tbxScore
        ' 
        tbxScore.Location = New Point(70, 8)
        tbxScore.Name = "tbxScore"
        tbxScore.Size = New Size(185, 23)
        tbxScore.TabIndex = 1
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(180, 49)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 2
        btnCancel.Text = "&Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(70, 49)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 3
        btnAdd.Text = "&Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' addscore
        ' 
        AcceptButton = btnAdd
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancel
        ClientSize = New Size(290, 92)
        Controls.Add(btnAdd)
        Controls.Add(btnCancel)
        Controls.Add(tbxScore)
        Controls.Add(lblScore)
        Name = "addscore"
        Text = "Add Score"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblScore As Label
    Friend WithEvents tbxScore As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
End Class
