Public Class PaymentForm



    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub


    Private Sub PayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayButton.Click
        If Dashboard.ItemListBox.Items.Count = 0 Then
            MsgBox("Select an item to purchase!", MsgBoxStyle.OkOnly, "Transaction Error")
            Exit Sub
        End If
        Dim paymentAmount As Decimal = Val(PaymentAmountTextBox.Text)
        Dim totalAmount As Decimal = Val(Dashboard.TotalAmountLabel.Text)

        If paymentAmount >= totalAmount Then
            RecieptForm.PaymentLabel.Text = paymentAmount
            RecieptForm.TotalAmountLabel.Text = totalAmount
            RecieptForm.VatLabel.Text = totalAmount * 0.12
            RecieptForm.ChangeLabel.Text = paymentAmount - totalAmount

            PrintReceipt.Timer1.Stop()
            PrintReceipt.Label1.Visible = True
            RecieptForm.Show()
            Me.Close()
            RecieptForm.ProceedButton.Enabled = True
            RecieptForm.CancelButton.Enabled = True
            RecieptForm.Enabled = True
            Dashboard.Hide()
        Else

            MsgBox("Insufficient Amount!", MsgBoxStyle.OkOnly, "Transaction Error")
        End If
    End Sub

    Private Sub PayButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PayButton.MouseHover

    End Sub

    Private Sub PayButton_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PayButton.MouseMove
        PayButton.BackColor = Color.FromArgb(255, 192, 173)
        PayButton.ForeColor = Color.FromArgb(85, 66, 61)
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GroupBox1.MouseMove
        PayButton.BackColor = Color.FromArgb(85, 66, 61)
        PayButton.ForeColor = Color.White
        CancelButton.BackColor = Color.FromArgb(85, 66, 61)
        CancelButton.ForeColor = Color.White
    End Sub

   
    Private Sub CancelButton_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CancelButton.MouseMove
        CancelButton.BackColor = Color.FromArgb(255, 192, 173)
        CancelButton.ForeColor = Color.FromArgb(85, 66, 61)
    End Sub

    Private Sub PaymentAmountTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PaymentAmountTextBox.GotFocus
   
    End Sub

    Private Sub PaymentAmountTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PaymentAmountTextBox.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
        If e.KeyChar = "." AndAlso PaymentAmountTextBox.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub PaymentAmountTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PaymentAmountTextBox.LostFocus

    End Sub

    Private Sub PaymentAmountTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentAmountTextBox.TextChanged

    End Sub

    Private Sub PaymentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
End Class