Public Class Dashboard

    Public ApplePrice As Decimal = 75
    Public BananaPrice As Decimal = 85
    Public CherryPrice As Decimal = 79.99
    Public CarrotPrice As Decimal = 59.99
    Public BroccoliPrice As Decimal = 39.99
    Public LettucePrice As Decimal = 70
    Public CokePrice As Decimal = 99.99
    Public JuicePrice As Decimal = 90
    Public WaterPrice As Decimal = 120
    Public Amount As Decimal = 0.0

    Private Sub POSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POSButton.Click
        POSControlGroupBox.Visible = True
        SalesGroupBox.Visible = False
        SettingsGroupBox.Visible = False
    End Sub

    Private Sub SalesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesButton.Click
        SalesGroupBox.Visible = True
        POSControlGroupBox.Visible = False
        SettingsGroupBox.Visible = False
    End Sub

    Private Sub SettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsButton.Click
        SettingsGroupBox.Visible = True
        POSControlGroupBox.Visible = False
        SalesGroupBox.Visible = False
    End Sub


    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CategoriesComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        ProductNameCombobox.DropDownStyle = ComboBoxStyle.DropDownList
        CategoriesComboBox.Items.Add("Select-Item")
        CategoriesComboBox.Items.Add("EXPRESSO")
        CategoriesComboBox.Items.Add("ICED")
        CategoriesComboBox.Items.Add("DESSERT")
        CategoriesComboBox.SelectedIndex = 0

        ProductNameCombobox.Items.Add("Select-Item")
        ProductNameCombobox.SelectedIndex = 0
    End Sub


    Private Sub CategoriesComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriesComboBox.SelectedIndexChanged
        ProductNameCombobox.Items.Clear()
        ProductNameCombobox.Text = ""
        If CategoriesComboBox.SelectedIndex = 1 Then
            ProductNameCombobox.Items.Clear()
            ProductNameCombobox.Items.Add("Cafe Latte")
            ProductNameCombobox.Items.Add("Cafe Americano")
            ProductNameCombobox.Items.Add("Capuccino")
        ElseIf CategoriesComboBox.SelectedIndex = 2 Then
            ProductNameCombobox.Items.Clear()
            ProductNameCombobox.Items.Add("Iced-Coffee")
            ProductNameCombobox.Items.Add("Milk-Tea")
            ProductNameCombobox.Items.Add("Frappe")
        ElseIf CategoriesComboBox.SelectedIndex = 3 Then
            ProductNameCombobox.Items.Clear()
            ProductNameCombobox.Items.Add("Cheesecake")
            ProductNameCombobox.Items.Add("Brownies")
            ProductNameCombobox.Items.Add("Chocolate-Cake")
        Else
            ProductNameCombobox.Items.Clear()
        End If
    End Sub

    Private Sub ProductNameCombobox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductNameCombobox.SelectedIndexChanged
        PriceLabel.Text = 0.0
        If ProductNameCombobox.SelectedItem.ToString = "Cafe Latte" Then
            PriceLabel.Text = ApplePrice
        ElseIf ProductNameCombobox.SelectedItem.ToString = "Cafe Americano" Then
            PriceLabel.Text = BananaPrice
        ElseIf ProductNameCombobox.SelectedItem.ToString = "Capuccino" Then
            PriceLabel.Text = CherryPrice
        ElseIf ProductNameCombobox.SelectedItem.ToString = "Iced-Coffee" Then
            PriceLabel.Text = CarrotPrice
        ElseIf ProductNameCombobox.SelectedItem.ToString = "Milk-Tea" Then
            PriceLabel.Text = BroccoliPrice
        ElseIf ProductNameCombobox.SelectedItem.ToString = "Frappe" Then
            PriceLabel.Text = LettucePrice
        ElseIf ProductNameCombobox.SelectedItem.ToString = "Cheesecake" Then
            PriceLabel.Text = CokePrice
        ElseIf ProductNameCombobox.SelectedItem.ToString = "Brownies" Then
            PriceLabel.Text = JuicePrice
        ElseIf ProductNameCombobox.SelectedItem.ToString = "Chocolate-Cake" Then
            PriceLabel.Text = WaterPrice
        Else
            PriceLabel.Text = 0.0
        End If
    End Sub

    Private Sub QuantityTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles QuantityTextBox.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
        If e.KeyChar = "." AndAlso QuantityTextBox.Text.Contains(".") Then
            e.Handled = True

        End If
    End Sub
    Private Sub QuantityTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuantityTextBox.TextChanged
        AmountLabel.Text = Val(PriceLabel.Text) * Val(QuantityTextBox.Text)
    End Sub

    Private Sub AddItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItemButton.Click
        If ProductNameCombobox.SelectedItem Is Nothing OrElse ProductNameCombobox.SelectedItem.ToString() = "Select-Item" Then
            MsgBox("Please select Product!", MsgBoxStyle.OkOnly, "Selection Error")
            QuantityTextBox.Text = Nothing

            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(QuantityTextBox.Text) OrElse Val(QuantityTextBox.Text) <= 0 Then
            MsgBox("Please enter a valid quantity!", MsgBoxStyle.OkOnly, "Quantity Error")
            Exit Sub
        End If


        If Val(AmountLabel.Text) <= 0 Then
            MsgBox("Invalid price! Please select a valid product.", MsgBoxStyle.OkOnly, "Price Error")
            Exit Sub
        End If

        Dim itemDetails As String = ProductNameCombobox.SelectedItem.ToString() & "     " & Val(QuantityTextBox.Text) & "     " & Val(AmountLabel.Text)
        ItemListBox.Items.Add(itemDetails)
        RecieptForm.RecieptItemListBox.Items.Add(itemDetails)

        Dim amount As Decimal = Val(AmountLabel.Text)
        TotalAmountLabel.Text = (Val(TotalAmountLabel.Text) + amount).ToString("0.00")
    
        AmountLabel.Text = "0.00"
        QuantityTextBox.Text = Nothing
        SubmitButton.Enabled = True
    End Sub

    Private Sub VoidButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoidButton.Click
        If ItemListBox.SelectedItem IsNot Nothing Then

            Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to void this item?", "Confirm Void", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmResult = DialogResult.Yes Then
                Dim selectedItem As String = ItemListBox.SelectedItem.ToString()
                Dim itemParts As String() = selectedItem.Split(New String() {"     "}, StringSplitOptions.None)

                If itemParts.Length >= 3 Then
                    Dim itemAmount As Decimal
                    If Decimal.TryParse(itemParts(2).Trim(), itemAmount) Then
                        TotalAmountLabel.Text = (Val(TotalAmountLabel.Text) - itemAmount).ToString("0.00")

                    End If
                End If

                ItemListBox.Items.Remove(ItemListBox.SelectedItem)


                For i As Integer = RecieptForm.RecieptItemListBox.Items.Count - 1 To 0 Step -1
                    Dim receiptItem As String = RecieptForm.RecieptItemListBox.Items(i).ToString()
                    If receiptItem.Contains(itemParts(0)) AndAlso receiptItem.Contains(itemParts(1)) AndAlso receiptItem.Contains(itemParts(2)) Then
                        RecieptForm.RecieptItemListBox.Items.RemoveAt(i)
                        Exit For
                    End If
                Next
                ItemListBox.Refresh()
            End If
        Else
            MessageBox.Show("Please select an item to void", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        CategoriesComboBox.Text = Nothing
        ProductNameCombobox.Text = Nothing
        RecieptForm.RecieptItemListBox.Text = Nothing
        PriceLabel.Text = "0.00"
        QuantityTextBox.Text = Nothing
        AmountLabel.Text = "0.00"
        RecieptForm.RecieptItemListBox.Items.Clear()
        ItemListBox.Items.Clear()
        TotalAmountLabel.Text = "0.00"
        If SubmitButton.Enabled Then
            SubmitButton.Enabled = False
            SubmitButton.ForeColor = Color.White
        End If
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        PaymentForm.Show()
    End Sub

    Private Sub POSControlGroupBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles POSControlGroupBox.MouseMove
        AddItemButton.BackColor = Color.FromArgb(85, 66, 61)
        AddItemButton.ForeColor = Color.White
        VoidButton.BackColor = Color.FromArgb(85, 66, 61)
        VoidButton.ForeColor = Color.White
        ClearButton.BackColor = Color.FromArgb(85, 66, 61)
        ClearButton.ForeColor = Color.White
        SubmitButton.BackColor = Color.FromArgb(85, 66, 61)
        SubmitButton.ForeColor = Color.White
    End Sub

    Private Sub LogOutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutButton.Click
        If MsgBox("Are you sure you want to Logout?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            LoginForm.Show()
            Me.Hide()
        Else
        End If
        LoginForm.TextBox3.Text = Nothing
    End Sub

    Private Sub Dashboard_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        POSButton.BackColor = Color.FromArgb(85, 66, 61)
        POSButton.ForeColor = Color.White
        SalesButton.BackColor = Color.FromArgb(85, 66, 61)
        SalesButton.ForeColor = Color.White
        SettingsButton.ForeColor = Color.FromArgb(85, 66, 61)
        SettingsButton.ForeColor = Color.White

    End Sub

    Private Sub POSButton_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles POSButton.MouseMove
        POSButton.BackColor = Color.FromArgb(255, 192, 173)
        POSButton.ForeColor = Color.FromArgb(85, 66, 61)

    End Sub

    Private Sub SalesButton_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SalesButton.MouseMove
        SalesButton.BackColor = Color.FromArgb(255, 192, 173)
        SalesButton.ForeColor = Color.FromArgb(85, 66, 61)
    End Sub


    Private Sub MainMenuGroupBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MainMenuGroupBox.MouseMove
        POSButton.BackColor = Color.FromArgb(85, 66, 61)
        POSButton.ForeColor = Color.White
        SalesButton.BackColor = Color.FromArgb(85, 66, 61)
        SalesButton.ForeColor = Color.White
        SettingsButton.BackColor = Color.FromArgb(85, 66, 61)
        SettingsButton.ForeColor = Color.White

    End Sub

    Private Sub SettingsButton_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SettingsButton.MouseMove
        SettingsButton.BackColor = Color.FromArgb(255, 192, 173)
        SettingsButton.ForeColor = Color.FromArgb(85, 66, 61)
    End Sub

    Private Sub AddItemButton_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles AddItemButton.MouseMove
        AddItemButton.BackColor = Color.FromArgb(255, 192, 173)
        AddItemButton.ForeColor = Color.FromArgb(85, 66, 61)
    End Sub

    Private Sub VoidButton_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VoidButton.MouseMove
        VoidButton.BackColor = Color.FromArgb(255, 192, 173)
        VoidButton.ForeColor = Color.FromArgb(85, 66, 61)
    End Sub

    Private Sub ClearButton_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ClearButton.MouseMove
        ClearButton.BackColor = Color.FromArgb(255, 192, 173)
        ClearButton.ForeColor = Color.FromArgb(85, 66, 61)
    End Sub

    Private Sub SubmitButton_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SubmitButton.MouseMove
        SubmitButton.BackColor = Color.FromArgb(255, 192, 173)
        SubmitButton.ForeColor = Color.FromArgb(85, 66, 61)
    End Sub

    Private Sub PrintButton_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PrintButton.MouseMove
        PrintButton.BackColor = Color.FromArgb(255, 192, 173)
        PrintButton.ForeColor = Color.FromArgb(85, 66, 61)
    End Sub

    Private Sub SalesGroupBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SalesGroupBox.MouseMove
        PrintButton.BackColor = Color.FromArgb(85, 66, 61)
        PrintButton.ForeColor = Color.White
    End Sub

    Private Sub LogOutButton_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LogOutButton.MouseMove
        LogOutButton.BackColor = Color.FromArgb(255, 192, 173)
        LogOutButton.ForeColor = Color.FromArgb(85, 66, 61)
    End Sub
    Private Sub SettingsGroupBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SettingsGroupBox.MouseMove
        LogOutButton.BackColor = Color.FromArgb(85, 66, 61)
        LogOutButton.ForeColor = Color.White
    End Sub

    Private Sub SalesGroupBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesGroupBox.Enter

    End Sub

    Private Sub POSControlGroupBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POSControlGroupBox.Enter

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub
End Class