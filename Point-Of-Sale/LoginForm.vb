Public Class LoginForm
    Private passwordVisible As Boolean = False
    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim validpassword As String = "1234"
        Dim password As String = TextBox3.Text
        If validpassword = password Then
            MessageBox.Show("Log in Successful", "Success", MessageBoxButtons.OK)
            Dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Log in Failed!", "Error", MessageBoxButtons.OK)
        End If
    End Sub
 
    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox3.PasswordChar = "•"
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If passwordVisible Then
            TextBox3.PasswordChar = "•"
            Button2.Text = "Show"
        Else
            TextBox3.PasswordChar = ""
            Button2.Text = "Hide"
        End If
        passwordVisible = Not passwordVisible
    End Sub
    Private Sub RectangleShape1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RectangleShape1.MouseMove
        Button2.BackColor = Color.FromArgb(85, 66, 61)
        Button2.ForeColor = Color.White
        LineShape1.BorderColor = Color.White
        Button1.BackColor = Color.FromArgb(85, 66, 61)
        Button1.ForeColor = Color.White
        BtnExit.BackColor = Color.FromArgb(85, 66, 61)
        BtnExit.ForeColor = Color.White
    End Sub
    Private Sub Button2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        Button2.BackColor = Color.FromArgb(255, 192, 173)
        Button2.ForeColor = Color.FromArgb(85, 66, 61)
        LineShape1.BorderColor = Color.FromArgb(255, 192, 173)
    End Sub

    Private Sub TextBox3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox3.MouseMove
        Button2.BackColor = Color.FromArgb(85, 66, 61)
        Button2.ForeColor = Color.White
        LineShape1.BorderColor = Color.White
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim validpassword As String = "123"
        Dim password As String = TextBox3.Text
        If validpassword = password Then
            MessageBox.Show("Log in Successful", "Success", MessageBoxButtons.OK)
            Dashboard.Show()
            Dashboard.SalesGroupBox.Visible = False
            Dashboard.SettingsGroupBox.Visible = False
            Dashboard.POSControlGroupBox.Visible = True
            Dashboard.CategoriesComboBox.Text = "Select-Item"
            Dashboard.ProductNameCombobox.Text = "Select-Item"
            Dashboard.AmountLabel.Text = "0.00"
            Dashboard.TotalAmountLabel.Text = "0.00"
            Dashboard.PriceLabel.Text = "0.00"
            Dashboard.ItemListBox.Items.Clear()
            RecieptForm.RecieptItemListBox.Items.Clear()
            Me.Hide()

        Else
            MessageBox.Show("Log in Failed!", "Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.BackColor = Color.FromArgb(255, 192, 173)
        Button1.ForeColor = Color.FromArgb(85, 66, 61)

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        If MsgBox("Are you sure you want to Exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        Else
        End If
    End Sub

    Private Sub BtnExit_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnExit.MouseMove
        BtnExit.BackColor = Color.FromArgb(255, 192, 173)
        BtnExit.ForeColor = Color.FromArgb(85, 66, 61)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        BtnExit.BackColor = Color.FromArgb(85, 66, 61)
        BtnExit.ForeColor = Color.White
    End Sub
End Class