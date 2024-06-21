<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        viewSubmission = New Button()
        createSubmission = New Button()
        SuspendLayout()
        ' 
        ' viewSubmission
        ' 
        viewSubmission.Location = New Point(280, 260)
        viewSubmission.Name = "viewSubmission"
        viewSubmission.Size = New Size(318, 35)
        viewSubmission.TabIndex = 0
        viewSubmission.Text = "viewSubmission (ctrl+V)"
        viewSubmission.UseVisualStyleBackColor = True
        ' 
        ' createSubmission
        ' 
        createSubmission.Location = New Point(280, 320)
        createSubmission.Name = "createSubmission"
        createSubmission.Size = New Size(318, 33)
        createSubmission.TabIndex = 1
        createSubmission.Text = "Create New Submission (ctrl+N)"
        createSubmission.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 450)
        Controls.Add(createSubmission)
        Controls.Add(viewSubmission)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents viewSubmission As Button
    Friend WithEvents createSubmission As Button

End Class
