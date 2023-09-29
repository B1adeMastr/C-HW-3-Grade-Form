<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Add = New Button()
        Label1 = New Label()
        lstStudents = New ListBox()
        Update = New Button()
        Delete = New Button()
        btnExit = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblScoreTotal = New Label()
        lblScoreCount = New Label()
        lblAverage = New Label()
        SuspendLayout()
        ' 
        ' Add
        ' 
        Add.Location = New Point(254, 27)
        Add.Margin = New Padding(2)
        Add.Name = "Add"
        Add.Size = New Size(75, 23)
        Add.TabIndex = 0
        Add.Text = "&Add New"
        Add.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 10)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 15)
        Label1.TabIndex = 1
        Label1.Text = "Students"
        ' 
        ' lstStudents
        ' 
        lstStudents.FormattingEnabled = True
        lstStudents.ItemHeight = 15
        lstStudents.Location = New Point(19, 28)
        lstStudents.Margin = New Padding(2)
        lstStudents.Name = "lstStudents"
        lstStudents.Size = New Size(229, 79)
        lstStudents.TabIndex = 1
        ' 
        ' Update
        ' 
        Update.Location = New Point(254, 56)
        Update.Margin = New Padding(2)
        Update.Name = "Update"
        Update.Size = New Size(75, 23)
        Update.TabIndex = 2
        Update.Text = "&Update"
        Update.UseVisualStyleBackColor = True
        ' 
        ' Delete
        ' 
        Delete.Location = New Point(253, 85)
        Delete.Margin = New Padding(2)
        Delete.Name = "Delete"
        Delete.Size = New Size(75, 23)
        Delete.TabIndex = 3
        Delete.Text = "&Delete"
        Delete.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(255, 174)
        btnExit.Margin = New Padding(2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 4
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 5
        Label2.Text = "Score Total:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 15)
        Label3.TabIndex = 6
        Label3.Text = "Score Count:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 167)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 15)
        Label4.TabIndex = 7
        Label4.Text = "Average:"
        ' 
        ' lblScoreTotal
        ' 
        lblScoreTotal.BorderStyle = BorderStyle.Fixed3D
        lblScoreTotal.Location = New Point(99, 113)
        lblScoreTotal.Margin = New Padding(2, 0, 2, 0)
        lblScoreTotal.Name = "lblScoreTotal"
        lblScoreTotal.Size = New Size(44, 23)
        lblScoreTotal.TabIndex = 8
        lblScoreTotal.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblScoreCount
        ' 
        lblScoreCount.BorderStyle = BorderStyle.Fixed3D
        lblScoreCount.Location = New Point(99, 136)
        lblScoreCount.Margin = New Padding(2, 0, 2, 0)
        lblScoreCount.Name = "lblScoreCount"
        lblScoreCount.Size = New Size(44, 23)
        lblScoreCount.TabIndex = 9
        lblScoreCount.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblAverage
        ' 
        lblAverage.BorderStyle = BorderStyle.Fixed3D
        lblAverage.Location = New Point(99, 159)
        lblAverage.Margin = New Padding(2, 0, 2, 0)
        lblAverage.Name = "lblAverage"
        lblAverage.Size = New Size(44, 23)
        lblAverage.TabIndex = 10
        lblAverage.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Main1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(341, 208)
        Controls.Add(lblAverage)
        Controls.Add(lblScoreCount)
        Controls.Add(lblScoreTotal)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnExit)
        Controls.Add(Delete)
        Controls.Add(Update)
        Controls.Add(lstStudents)
        Controls.Add(Label1)
        Controls.Add(Add)
        Name = "Main1"
        Text = "Student Scores"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Add As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstStudents As ListBox
    Friend WithEvents Update As Button
    Friend WithEvents Delete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblScoreTotal As Label
    Friend WithEvents lblScoreCount As Label
    Friend WithEvents lblAverage As Label
End Class
