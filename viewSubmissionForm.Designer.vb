<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewSubmissionForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(132, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 0
        Label1.Text = "Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(132, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 1
        Label2.Text = "Email :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(132, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 15)
        Label3.TabIndex = 2
        Label3.Text = "Phone :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(132, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 15)
        Label4.TabIndex = 3
        Label4.Text = "Github Link :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(132, 274)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 15)
        Label5.TabIndex = 4
        Label5.Text = "Stopwatch :"
        ' 
        ' Label6
        ' 
        Label6.BackColor = SystemColors.ControlLight
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.Location = New Point(229, 115)
        Label6.Name = "Label6"
        Label6.Size = New Size(270, 23)
        Label6.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.BackColor = SystemColors.ControlLight
        Label7.BorderStyle = BorderStyle.FixedSingle
        Label7.Location = New Point(229, 153)
        Label7.Name = "Label7"
        Label7.Size = New Size(270, 23)
        Label7.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.BackColor = SystemColors.ControlLight
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Location = New Point(229, 193)
        Label8.Name = "Label8"
        Label8.Size = New Size(270, 23)
        Label8.TabIndex = 7
        ' 
        ' Label9
        ' 
        Label9.BackColor = SystemColors.ControlLight
        Label9.BorderStyle = BorderStyle.FixedSingle
        Label9.Location = New Point(229, 232)
        Label9.Name = "Label9"
        Label9.Size = New Size(270, 23)
        Label9.TabIndex = 8
        ' 
        ' Label10
        ' 
        Label10.BackColor = SystemColors.ControlLight
        Label10.BorderStyle = BorderStyle.FixedSingle
        Label10.Location = New Point(229, 273)
        Label10.Name = "Label10"
        Label10.Size = New Size(270, 23)
        Label10.TabIndex = 9
        Label10.Text = "00:00:00"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(132, 315)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 35)
        Button1.TabIndex = 10
        Button1.Text = "PREVIOUS  (ctrl+P)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(393, 315)
        Button2.Name = "Button2"
        Button2.Size = New Size(106, 35)
        Button2.TabIndex = 11
        Button2.Text = "NEXT  (ctrl+N)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(272, 315)
        Button3.Name = "Button3"
        Button3.Size = New Size(102, 35)
        Button3.TabIndex = 12
        Button3.Text = "Del (ctrl+D)"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' viewSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(610, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "viewSubmissionForm"
        Text = "viewSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
