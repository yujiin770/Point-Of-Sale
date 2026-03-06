Public Class SplashScreenForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub SplashScreenForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label2.BackColor = Color.Transparent
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = ProgressBar1.Value & "%"
        ProgressBar1.Value += 5
        If ProgressBar1.Value = 105 Then
            Label2.Visible = False
            Timer1.Dispose()
            Button1.Visible = True
            ProgressBar1.Visible = False
        End If
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.BackColor = Color.FromArgb(255, 192, 173)
        Button1.ForeColor = Color.FromArgb(85, 66, 61)
    End Sub

    Private Sub SplashScreenForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Button1.BackColor = Color.FromArgb(85, 66, 61)
        Button1.ForeColor = Color.White
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub ProgressBar1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ProgressBar1.MouseMove
        Button1.BackColor = Color.FromArgb(85, 66, 61)
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class