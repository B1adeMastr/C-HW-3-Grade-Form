<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updatestudentscore
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
        lblnm = New Label()
        Label1 = New Label()
        lblName = New Label()
        lblscr = New Label()
        ListBox1 = New ListBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnRemove = New Button()
        btnClear = New Button()
        btnCancel = New Button()
        btnOkay = New Button()
        SuspendLayout()
        ' 
        ' lblnm
        ' 
        lblnm.AutoSize = True
        lblnm.Location = New Point(16, 14)
        lblnm.Name = "lblnm"
        lblnm.Size = New Size(42, 15)
        lblnm.TabIndex = 0
        lblnm.Text = "Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(60, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 1
        ' 
        ' lblName
        ' 
        lblName.BorderStyle = BorderStyle.Fixed3D
        lblName.Location = New Point(60, 8)
        lblName.Name = "lblName"
        lblName.Size = New Size(241, 26)
        lblName.TabIndex = 2
        ' 
        ' lblscr
        ' 
        lblscr.AutoSize = True
        lblscr.Location = New Point(16, 50)
        lblscr.Name = "lblscr"
        lblscr.Size = New Size(44, 15)
        lblscr.TabIndex = 3
        lblscr.Text = "Scores:"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(60, 48)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(192, 109)
        ListBox1.TabIndex = 4
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(261, 48)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(82, 23)
        btnAdd.TabIndex = 5
        btnAdd.Text = "&Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(261, 77)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(82, 23)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "&Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(261, 106)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(82, 23)
        btnRemove.TabIndex = 7
        btnRemove.Text = "&Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(261, 135)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(82, 23)
        btnClear.TabIndex = 8
        btnClear.Text = "&Clear Scores "
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(261, 166)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(82, 23)
        btnCancel.TabIndex = 9
        btnCancel.Text = "&Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnOkay
        ' 
        btnOkay.Location = New Point(170, 166)
        btnOkay.Name = "btnOkay"
        btnOkay.Size = New Size(82, 23)
        btnOkay.TabIndex = 10
        btnOkay.Text = "&Okay"
        btnOkay.UseVisualStyleBackColor = True
        ' 
        ' updatestudentscore
        ' 
        AcceptButton = btnOkay
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancel
        ClientSize = New Size(355, 201)
        Controls.Add(btnOkay)
        Controls.Add(btnCancel)
        Controls.Add(btnClear)
        Controls.Add(btnRemove)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(ListBox1)
        Controls.Add(lblscr)
        Controls.Add(lblName)
        Controls.Add(Label1)
        Controls.Add(lblnm)
        Name = "updatestudentscore"
        Text = "Update Student Scores"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblnm As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblscr As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOkay As Button
End Class
