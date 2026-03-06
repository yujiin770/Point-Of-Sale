Public Class RecieptForm

    Private Sub RecieptForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub PaymentLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentLabel.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub TotalAmountLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalAmountLabel.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub VatLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VatLabel.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub ChangeLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeLabel.Click

    End Sub

    Private Sub ProceedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProceedButton.Click
        Dim totalAmount As Decimal = Val(Dashboard.TotalAmountLabel.Text)
        Dashboard.lblTotalSales.Text = (Val(Dashboard.lblTotalSales.Text) + totalAmount).ToString("0.00")

        For Each item In Dashboard.ItemListBox.Items
            Dashboard.ItemSoldListBox.Items.Add(item)
        Next
        Dashboard.ItemListBox.Items.Clear()

        Dashboard.CategoriesComboBox.Text = "Select-Item"
        Dashboard.ProductNameCombobox.Text = "Select-Item"
        Dashboard.AmountLabel.Text = "0.00"
        Dashboard.TotalAmountLabel.Text = "0.00"
        Dashboard.PriceLabel.Text = "0.00"
        Dashboard.ItemListBox.Items.Clear()

        RecieptItemListBox.Text = Nothing
        Dashboard.QuantityTextBox.Text = Nothing
        PrintReceipt.Show()
        PrintReceipt.Panel1.Width = 5
        PrintReceipt.Timer1.Start()
        ProceedButton.Enabled = False
        CancelButton.Enabled = False
        Me.Enabled = False
        ProceedButton.ForeColor = Color.White
        CancelButton.ForeColor = Color.White
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click

        If MsgBox("Are you sure you want to cancel the transaction?", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
            Dashboard.Show()
            Me.Hide()
        Else

        End If

        Dashboard.Refresh()
    End Sub

    Private Sub ProceedButton_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ProceedButton.MouseMove
        ProceedButton.BackColor = Color.FromArgb(255, 192, 173)
        ProceedButton.ForeColor = Color.FromArgb(85, 66, 61)
    End Sub

    Private Sub RecieptForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        ProceedButton.BackColor = Color.FromArgb(85, 66, 61)
        ProceedButton.ForeColor = Color.White
        CancelButton.BackColor = Color.FromArgb(85, 66, 61)
        CancelButton.ForeColor = Color.White
    End Sub

    Private Sub CancelButton_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CancelButton.MouseMove
        CancelButton.BackColor = Color.FromArgb(255, 192, 173)
        CancelButton.ForeColor = Color.FromArgb(85, 66, 61)
    End Sub
End Class