Public Class PrintReceipt

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Panel1.Width += 1
        If Panel1.Width >= 240 Then
            Label1.Visible = False
            LblComplete.Visible = True

            Timer1.Dispose()
            MsgBox("Transaction Complete", MsgBoxStyle.OkOnly)


            RecieptForm.Show()
            Me.Hide()
            Dashboard.Show()

            RecieptForm.Hide()
            RecieptForm.RecieptItemListBox.Items.Clear()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PrintReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PrintReceipt_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class