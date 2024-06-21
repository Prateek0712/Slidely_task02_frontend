Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text

Public Class CreateSubmissionForm
    Dim ss, mm, hh As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = False
        Dim uname As String = TextBox1.Text
        Dim uemail As String = TextBox2.Text
        Dim uphone As String = TextBox3.Text
        Dim ugitLink As String = TextBox4.Text
        Dim ustopwatch As String = Label6.Text

        Dim httpClient As New HttpClient()
        httpClient.BaseAddress = New Uri("http://localhost:5000/")

        Dim data As New Dictionary(Of String, String)
        data.Add("name", uname)
        data.Add("email", uemail)
        data.Add("phone", uphone)
        data.Add("github_link", ugitLink)
        data.Add("stopwatch_time", ustopwatch)

        Dim json As String = JsonConvert.SerializeObject(data)

        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Dim response As HttpResponseMessage = httpClient.PostAsync("submit", content).Result

        If response.IsSuccessStatusCode Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            Label6.Text = "00:00:00"
            ss = 0
            hh = 0
            mm = 0
            Dim responseContent As String = response.Content.ReadAsStringAsync().Result
            MessageBox.Show(responseContent)
            Timer1.Enabled = True
        Else
            MessageBox.Show("Error: " & response.StatusCode.ToString())
            Timer1.Enabled = True
        End If
    End Sub



    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = Format(hh, "00:") & Format(mm, "00:") & Format(ss, "00")
        ss = ss + 1
        If ss > 59 Then
            ss = 0
            mm = mm + 1
        End If
        If mm > 59 Then
            mm = 0
            hh = hh + 1
        End If
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.KeyPreview = True
        Button1.BackColor = Color.FromArgb(254, 236, 152)
    End Sub
    'event for handling shortcut
    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            Button1.PerformClick()
        End If
    End Sub
End Class