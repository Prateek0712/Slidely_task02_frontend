Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.Text
Imports System.Xml

Public Class viewSubmissionForm
    Dim idx As Integer = 0
    Private Sub viewSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'to enable the page to  focused on any  keyborad key  event
        Me.KeyPreview = True
        Button1.BackColor = Color.FromArgb(254, 236, 152)
        Button2.BackColor = Color.FromArgb(164, 216, 255)
        Button3.BackColor = Color.FromArgb(246, 1, 0)
        Dim index As String = idx

        Dim httpClient As New HttpClient()
        httpClient.BaseAddress = New Uri("http://localhost:5000/")

        Dim requestUri As String = $"read?index={index}"

        Dim response As HttpResponseMessage = httpClient.GetAsync(requestUri).Result


        If response.IsSuccessStatusCode Then
            Dim responseContent As String = response.Content.ReadAsStringAsync().Result
            'MessageBox.Show(responseContent)
            Dim jsonObject As JObject = JObject.Parse(responseContent)

            'egregate the JSON object fields and assign them to labels
            Label6.Text = jsonObject("name").ToString()
            Label7.Text = jsonObject("email").ToString()
            Label8.Text = jsonObject("phone").ToString()
            Label9.Text = jsonObject("github_link").ToString()
            Label10.Text = jsonObject("stopwatch_time").ToString()
        Else
            MessageBox.Show("Error: " & response.StatusCode.ToString())
        End If
    End Sub

    Private Sub testConnectivity_Click(sender As Object, e As EventArgs)
        Dim httpClient As New HttpClient
        httpClient.BaseAddress = New Uri("http://localhost:5000/")

        Dim response = httpClient.GetAsync("ping").Result

        If response.IsSuccessStatusCode Then
            Dim responseContent = response.Content.ReadAsStringAsync.Result
            MessageBox.Show("Ping successful! Response: " & responseContent)
        Else
            MessageBox.Show("Error: " & response.StatusCode.ToString)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        idx = idx + 1
        Dim index As String = idx

        Dim httpClient As New HttpClient()
        httpClient.BaseAddress = New Uri("http://localhost:5000/")

        Dim requestUri As String = $"read?index={index}"

        Dim response As HttpResponseMessage = httpClient.GetAsync(requestUri).Result


        If response.IsSuccessStatusCode Then
            Dim responseContent As String = response.Content.ReadAsStringAsync().Result
            'MessageBox.Show(responseContent)
            Dim jsonObject As JObject = JObject.Parse(responseContent)

            'egregate the JSON object fields and assign them to labels
            Label6.Text = jsonObject("name").ToString()
            Label7.Text = jsonObject("email").ToString()
            Label8.Text = jsonObject("phone").ToString()
            Label9.Text = jsonObject("github_link").ToString()
            Label10.Text = jsonObject("stopwatch_time").ToString()
        Else
            MessageBox.Show("Error: " & response.StatusCode.ToString)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If idx = 0 Then
            MessageBox.Show("You can't go previous")
            Exit Sub
        End If
        idx = idx - 1
        Dim index As String = idx

        Dim httpClient As New HttpClient()
        httpClient.BaseAddress = New Uri("http://localhost:5000/")

        Dim requestUri As String = $"read?index={index}"

        Dim response As HttpResponseMessage = httpClient.GetAsync(requestUri).Result


        If response.IsSuccessStatusCode Then
            Dim responseContent As String = response.Content.ReadAsStringAsync().Result
            'MessageBox.Show(responseContent)
            Dim jsonObject As JObject = JObject.Parse(responseContent)

            'egregate the JSON object fields and assign them to labels
            Label6.Text = jsonObject("name").ToString()
            Label7.Text = jsonObject("email").ToString()
            Label8.Text = jsonObject("phone").ToString()
            Label9.Text = jsonObject("github_link").ToString()
            Label10.Text = jsonObject("stopwatch_time").ToString()
        Else
            MessageBox.Show("Error: " & response.StatusCode.ToString)

        End If
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.P Then
            Button1.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.D Then
            Button3.PerformClick()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim index As String = idx

        Dim httpClient As New HttpClient()
        httpClient.BaseAddress = New Uri("http://localhost:5000/")

        Dim requestUri As String = $"delete?index={index}"

        Dim response As HttpResponseMessage = httpClient.GetAsync(requestUri).Result


        If response.IsSuccessStatusCode Then
            Dim responseContent As String = response.Content.ReadAsStringAsync().Result
            'MessageBox.Show(responseContent)
            Dim jsonObject As JObject = JObject.Parse(responseContent)
            MessageBox.Show(jsonObject("message").ToString & " YOU WILL NOW BE REDIRECTED TO PREVIOUS ENTRY")
            'invoking click event on previous button
            Button1.PerformClick()

        Else
            MessageBox.Show("Error: " & response.StatusCode.ToString)
            idx = idx - 1 'going  to same idx which increase
        End If
    End Sub
End Class