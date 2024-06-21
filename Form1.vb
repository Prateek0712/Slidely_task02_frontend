Public Class Form1
    Private Sub viewSubmission_Click(sender As Object, e As EventArgs) Handles viewSubmission.Click

        Dim ViewSubmissionsForm As New viewSubmissionForm()
        ViewSubmissionsForm.ShowDialog(Me)


    End Sub

    Private Sub createSubmission_Click(sender As Object, e As EventArgs) Handles createSubmission.Click
        Dim createSubmissionsForm As New CreateSubmissionForm()
        createSubmissionsForm.ShowDialog(Me)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        createSubmission.BackColor = Color.FromArgb(254, 236, 152)
        viewSubmission.BackColor = Color.FromArgb(164, 216, 255)
    End Sub
    'event for handling shortcut
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            createSubmission.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.V Then
            viewSubmission.PerformClick()
        End If
    End Sub
End Class
