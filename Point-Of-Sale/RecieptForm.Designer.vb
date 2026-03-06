<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecieptForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RecieptItemListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ProceedButton = New System.Windows.Forms.Button()
        Me.PaymentLabel = New System.Windows.Forms.Label()
        Me.TotalAmountLabel = New System.Windows.Forms.Label()
        Me.VatLabel = New System.Windows.Forms.Label()
        Me.ChangeLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RecieptItemListBox
        '
        Me.RecieptItemListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.RecieptItemListBox.Enabled = False
        Me.RecieptItemListBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecieptItemListBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.RecieptItemListBox.FormattingEnabled = True
        Me.RecieptItemListBox.ItemHeight = 22
        Me.RecieptItemListBox.Location = New System.Drawing.Point(192, 103)
        Me.RecieptItemListBox.Name = "RecieptItemListBox"
        Me.RecieptItemListBox.Size = New System.Drawing.Size(229, 202)
        Me.RecieptItemListBox.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(257, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 23)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Reciept"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 386)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Payment:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 442)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 23)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Total Amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(392, 386)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 23)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Vat:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(354, 442)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 23)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Change:"
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.ForeColor = System.Drawing.SystemColors.Control
        Me.CancelButton.Location = New System.Drawing.Point(297, 518)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(139, 33)
        Me.CancelButton.TabIndex = 29
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'ProceedButton
        '
        Me.ProceedButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ProceedButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProceedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProceedButton.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProceedButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ProceedButton.Location = New System.Drawing.Point(442, 518)
        Me.ProceedButton.Name = "ProceedButton"
        Me.ProceedButton.Size = New System.Drawing.Size(139, 33)
        Me.ProceedButton.TabIndex = 28
        Me.ProceedButton.Text = "Print"
        Me.ProceedButton.UseVisualStyleBackColor = False
        '
        'PaymentLabel
        '
        Me.PaymentLabel.AutoSize = True
        Me.PaymentLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentLabel.Location = New System.Drawing.Point(224, 387)
        Me.PaymentLabel.Name = "PaymentLabel"
        Me.PaymentLabel.Size = New System.Drawing.Size(45, 22)
        Me.PaymentLabel.TabIndex = 30
        Me.PaymentLabel.Text = "0.00"
        Me.PaymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalAmountLabel
        '
        Me.TotalAmountLabel.AutoSize = True
        Me.TotalAmountLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmountLabel.Location = New System.Drawing.Point(227, 444)
        Me.TotalAmountLabel.Name = "TotalAmountLabel"
        Me.TotalAmountLabel.Size = New System.Drawing.Size(45, 22)
        Me.TotalAmountLabel.TabIndex = 31
        Me.TotalAmountLabel.Text = "0.00"
        '
        'VatLabel
        '
        Me.VatLabel.AutoSize = True
        Me.VatLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VatLabel.Location = New System.Drawing.Point(459, 388)
        Me.VatLabel.Name = "VatLabel"
        Me.VatLabel.Size = New System.Drawing.Size(45, 22)
        Me.VatLabel.TabIndex = 32
        Me.VatLabel.Text = "0.00"
        '
        'ChangeLabel
        '
        Me.ChangeLabel.AutoSize = True
        Me.ChangeLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeLabel.Location = New System.Drawing.Point(459, 443)
        Me.ChangeLabel.Name = "ChangeLabel"
        Me.ChangeLabel.Size = New System.Drawing.Size(45, 22)
        Me.ChangeLabel.TabIndex = 33
        Me.ChangeLabel.Text = "0.00"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(207, 387)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 24)
        Me.Label7.TabIndex = 34
        Me.Label7.Tag = ""
        Me.Label7.Text = "₱"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(207, 442)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 24)
        Me.Label6.TabIndex = 35
        Me.Label6.Tag = ""
        Me.Label6.Text = "₱"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(440, 386)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 24)
        Me.Label8.TabIndex = 36
        Me.Label8.Tag = ""
        Me.Label8.Text = "₱"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(441, 442)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 22)
        Me.Label9.TabIndex = 37
        Me.Label9.Tag = ""
        Me.Label9.Text = "₱"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(183, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 23)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Product"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(270, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 23)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Quantity"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(366, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 23)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Price"
        '
        'RecieptForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(590, 572)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ChangeLabel)
        Me.Controls.Add(Me.VatLabel)
        Me.Controls.Add(Me.TotalAmountLabel)
        Me.Controls.Add(Me.PaymentLabel)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ProceedButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RecieptItemListBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "RecieptForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RecieptForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RecieptItemListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents ProceedButton As System.Windows.Forms.Button
    Friend WithEvents PaymentLabel As System.Windows.Forms.Label
    Friend WithEvents TotalAmountLabel As System.Windows.Forms.Label
    Friend WithEvents VatLabel As System.Windows.Forms.Label
    Friend WithEvents ChangeLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
