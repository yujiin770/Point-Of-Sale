<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.MainMenuGroupBox = New System.Windows.Forms.GroupBox()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.SalesButton = New System.Windows.Forms.Button()
        Me.POSButton = New System.Windows.Forms.Button()
        Me.POSControlGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TotalAmountLabel = New System.Windows.Forms.Label()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.VoidButton = New System.Windows.Forms.Button()
        Me.AddItemButton = New System.Windows.Forms.Button()
        Me.ItemListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.ProductNameCombobox = New System.Windows.Forms.ComboBox()
        Me.CategoriesComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.SalesGroupBox = New System.Windows.Forms.GroupBox()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ItemSoldListBox = New System.Windows.Forms.ListBox()
        Me.SettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MainMenuGroupBox.SuspendLayout()
        Me.POSControlGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SalesGroupBox.SuspendLayout()
        Me.SettingsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenuGroupBox
        '
        Me.MainMenuGroupBox.Controls.Add(Me.SettingsButton)
        Me.MainMenuGroupBox.Controls.Add(Me.SalesButton)
        Me.MainMenuGroupBox.Controls.Add(Me.POSButton)
        Me.MainMenuGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.MainMenuGroupBox.Name = "MainMenuGroupBox"
        Me.MainMenuGroupBox.Size = New System.Drawing.Size(700, 69)
        Me.MainMenuGroupBox.TabIndex = 0
        Me.MainMenuGroupBox.TabStop = False
        '
        'SettingsButton
        '
        Me.SettingsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingsButton.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsButton.ForeColor = System.Drawing.SystemColors.Control
        Me.SettingsButton.Location = New System.Drawing.Point(471, 19)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(185, 33)
        Me.SettingsButton.TabIndex = 15
        Me.SettingsButton.Text = "SETTINGS"
        Me.SettingsButton.UseVisualStyleBackColor = False
        '
        'SalesButton
        '
        Me.SalesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.SalesButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesButton.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesButton.ForeColor = System.Drawing.SystemColors.Control
        Me.SalesButton.Location = New System.Drawing.Point(258, 18)
        Me.SalesButton.Name = "SalesButton"
        Me.SalesButton.Size = New System.Drawing.Size(185, 33)
        Me.SalesButton.TabIndex = 14
        Me.SalesButton.Text = "SALES"
        Me.SalesButton.UseVisualStyleBackColor = False
        '
        'POSButton
        '
        Me.POSButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.POSButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.POSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.POSButton.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POSButton.ForeColor = System.Drawing.SystemColors.Control
        Me.POSButton.Location = New System.Drawing.Point(43, 19)
        Me.POSButton.Name = "POSButton"
        Me.POSButton.Size = New System.Drawing.Size(185, 33)
        Me.POSButton.TabIndex = 13
        Me.POSButton.Text = "POS"
        Me.POSButton.UseVisualStyleBackColor = False
        '
        'POSControlGroupBox
        '
        Me.POSControlGroupBox.Controls.Add(Me.Label14)
        Me.POSControlGroupBox.Controls.Add(Me.Label13)
        Me.POSControlGroupBox.Controls.Add(Me.Label11)
        Me.POSControlGroupBox.Controls.Add(Me.GroupBox1)
        Me.POSControlGroupBox.Controls.Add(Me.QuantityTextBox)
        Me.POSControlGroupBox.Controls.Add(Me.SubmitButton)
        Me.POSControlGroupBox.Controls.Add(Me.ClearButton)
        Me.POSControlGroupBox.Controls.Add(Me.VoidButton)
        Me.POSControlGroupBox.Controls.Add(Me.AddItemButton)
        Me.POSControlGroupBox.Controls.Add(Me.ItemListBox)
        Me.POSControlGroupBox.Controls.Add(Me.GroupBox3)
        Me.POSControlGroupBox.Controls.Add(Me.PriceLabel)
        Me.POSControlGroupBox.Controls.Add(Me.ProductNameCombobox)
        Me.POSControlGroupBox.Controls.Add(Me.CategoriesComboBox)
        Me.POSControlGroupBox.Controls.Add(Me.Label4)
        Me.POSControlGroupBox.Controls.Add(Me.Label3)
        Me.POSControlGroupBox.Controls.Add(Me.Label2)
        Me.POSControlGroupBox.Controls.Add(Me.Label1)
        Me.POSControlGroupBox.Controls.Add(Me.Label10)
        Me.POSControlGroupBox.Controls.Add(Me.ShapeContainer1)
        Me.POSControlGroupBox.ForeColor = System.Drawing.SystemColors.Control
        Me.POSControlGroupBox.Location = New System.Drawing.Point(12, 87)
        Me.POSControlGroupBox.Name = "POSControlGroupBox"
        Me.POSControlGroupBox.Size = New System.Drawing.Size(700, 490)
        Me.POSControlGroupBox.TabIndex = 1
        Me.POSControlGroupBox.TabStop = False
        Me.POSControlGroupBox.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(632, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 19)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Price"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(537, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 19)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Quantity"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(440, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 19)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Product"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TotalAmountLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(499, 279)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 124)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(14, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 23)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Total Amount"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(19, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 24)
        Me.Label9.TabIndex = 21
        Me.Label9.Tag = ""
        Me.Label9.Text = "₱"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalAmountLabel
        '
        Me.TotalAmountLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmountLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TotalAmountLabel.Location = New System.Drawing.Point(49, 61)
        Me.TotalAmountLabel.Name = "TotalAmountLabel"
        Me.TotalAmountLabel.Size = New System.Drawing.Size(97, 26)
        Me.TotalAmountLabel.TabIndex = 4
        Me.TotalAmountLabel.Text = "0.00"
        Me.TotalAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.QuantityTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(216, 191)
        Me.QuantityTextBox.MaxLength = 5
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(145, 22)
        Me.QuantityTextBox.TabIndex = 18
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubmitButton.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.SubmitButton.Location = New System.Drawing.Point(541, 432)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(139, 33)
        Me.SubmitButton.TabIndex = 17
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ClearButton.Location = New System.Drawing.Point(369, 432)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(139, 33)
        Me.ClearButton.TabIndex = 16
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'VoidButton
        '
        Me.VoidButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.VoidButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VoidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VoidButton.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VoidButton.ForeColor = System.Drawing.SystemColors.Control
        Me.VoidButton.Location = New System.Drawing.Point(201, 432)
        Me.VoidButton.Name = "VoidButton"
        Me.VoidButton.Size = New System.Drawing.Size(139, 33)
        Me.VoidButton.TabIndex = 15
        Me.VoidButton.Text = "Void"
        Me.VoidButton.UseVisualStyleBackColor = False
        '
        'AddItemButton
        '
        Me.AddItemButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.AddItemButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddItemButton.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddItemButton.ForeColor = System.Drawing.SystemColors.Control
        Me.AddItemButton.Location = New System.Drawing.Point(43, 432)
        Me.AddItemButton.Name = "AddItemButton"
        Me.AddItemButton.Size = New System.Drawing.Size(139, 33)
        Me.AddItemButton.TabIndex = 14
        Me.AddItemButton.Text = "Add Item"
        Me.AddItemButton.UseVisualStyleBackColor = False
        '
        'ItemListBox
        '
        Me.ItemListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.ItemListBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemListBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ItemListBox.FormattingEnabled = True
        Me.ItemListBox.ItemHeight = 23
        Me.ItemListBox.Location = New System.Drawing.Point(444, 65)
        Me.ItemListBox.Name = "ItemListBox"
        Me.ItemListBox.Size = New System.Drawing.Size(236, 188)
        Me.ItemListBox.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.AmountLabel)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(43, 269)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(155, 124)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'AmountLabel
        '
        Me.AmountLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.AmountLabel.Location = New System.Drawing.Point(49, 62)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(81, 26)
        Me.AmountLabel.TabIndex = 4
        Me.AmountLabel.Text = "0.00"
        Me.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(32, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Amount"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(23, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 24)
        Me.Label7.TabIndex = 20
        Me.Label7.Tag = ""
        Me.Label7.Text = "₱"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PriceLabel
        '
        Me.PriceLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLabel.Location = New System.Drawing.Point(236, 148)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(64, 27)
        Me.PriceLabel.TabIndex = 6
        Me.PriceLabel.Text = "0.00"
        Me.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProductNameCombobox
        '
        Me.ProductNameCombobox.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameCombobox.FormattingEnabled = True
        Me.ProductNameCombobox.Location = New System.Drawing.Point(216, 92)
        Me.ProductNameCombobox.Name = "ProductNameCombobox"
        Me.ProductNameCombobox.Size = New System.Drawing.Size(145, 31)
        Me.ProductNameCombobox.TabIndex = 5
        '
        'CategoriesComboBox
        '
        Me.CategoriesComboBox.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriesComboBox.FormattingEnabled = True
        Me.CategoriesComboBox.Location = New System.Drawing.Point(216, 45)
        Me.CategoriesComboBox.Name = "CategoriesComboBox"
        Me.CategoriesComboBox.Size = New System.Drawing.Size(145, 31)
        Me.CategoriesComboBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "QUANTITY:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PRICE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PRODUCT NAME:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CATEGORIES:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(218, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 22)
        Me.Label10.TabIndex = 21
        Me.Label10.Tag = ""
        Me.Label10.Text = "₱"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(694, 471)
        Me.ShapeContainer1.TabIndex = 25
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.White
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.CornerRadius = 12
        Me.RectangleShape3.Location = New System.Drawing.Point(204, 165)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(162, 40)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.RectangleShape2.CornerRadius = 30
        Me.RectangleShape2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.RectangleShape2.Location = New System.Drawing.Point(484, 256)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(178, 142)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.RectangleShape1.CornerRadius = 23
        Me.RectangleShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.RectangleShape1.Location = New System.Drawing.Point(28, 244)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(178, 142)
        '
        'SalesGroupBox
        '
        Me.SalesGroupBox.Controls.Add(Me.lblTotalSales)
        Me.SalesGroupBox.Controls.Add(Me.Label19)
        Me.SalesGroupBox.Controls.Add(Me.Label18)
        Me.SalesGroupBox.Controls.Add(Me.Label17)
        Me.SalesGroupBox.Controls.Add(Me.Label16)
        Me.SalesGroupBox.Controls.Add(Me.Label15)
        Me.SalesGroupBox.Controls.Add(Me.PrintButton)
        Me.SalesGroupBox.Controls.Add(Me.Label12)
        Me.SalesGroupBox.Controls.Add(Me.ItemSoldListBox)
        Me.SalesGroupBox.ForeColor = System.Drawing.SystemColors.Control
        Me.SalesGroupBox.Location = New System.Drawing.Point(12, 97)
        Me.SalesGroupBox.Name = "SalesGroupBox"
        Me.SalesGroupBox.Size = New System.Drawing.Size(700, 480)
        Me.SalesGroupBox.TabIndex = 5
        Me.SalesGroupBox.TabStop = False
        Me.SalesGroupBox.Visible = False
        '
        'lblTotalSales
        '
        Me.lblTotalSales.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.Location = New System.Drawing.Point(308, 349)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(93, 20)
        Me.lblTotalSales.TabIndex = 44
        Me.lblTotalSales.Text = "0.00"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(280, 349)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 20)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "₱"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(247, 316)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(166, 33)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Total's Sales"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(408, 73)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 23)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Price"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(308, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 23)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Quantity"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(219, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 23)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Product"
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.PrintButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintButton.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.ForeColor = System.Drawing.SystemColors.Control
        Me.PrintButton.Location = New System.Drawing.Point(258, 395)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(139, 33)
        Me.PrintButton.TabIndex = 17
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(247, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(196, 33)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "TODAY'S SALE"
        '
        'ItemSoldListBox
        '
        Me.ItemSoldListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.ItemSoldListBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemSoldListBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ItemSoldListBox.FormattingEnabled = True
        Me.ItemSoldListBox.ItemHeight = 22
        Me.ItemSoldListBox.Location = New System.Drawing.Point(216, 99)
        Me.ItemSoldListBox.Name = "ItemSoldListBox"
        Me.ItemSoldListBox.Size = New System.Drawing.Size(250, 202)
        Me.ItemSoldListBox.TabIndex = 18
        '
        'SettingsGroupBox
        '
        Me.SettingsGroupBox.Controls.Add(Me.LogOutButton)
        Me.SettingsGroupBox.Controls.Add(Me.Label5)
        Me.SettingsGroupBox.ForeColor = System.Drawing.SystemColors.Control
        Me.SettingsGroupBox.Location = New System.Drawing.Point(12, 87)
        Me.SettingsGroupBox.Name = "SettingsGroupBox"
        Me.SettingsGroupBox.Size = New System.Drawing.Size(700, 490)
        Me.SettingsGroupBox.TabIndex = 6
        Me.SettingsGroupBox.TabStop = False
        Me.SettingsGroupBox.Visible = False
        '
        'LogOutButton
        '
        Me.LogOutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOutButton.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutButton.ForeColor = System.Drawing.SystemColors.Control
        Me.LogOutButton.Location = New System.Drawing.Point(284, 224)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(139, 33)
        Me.LogOutButton.TabIndex = 17
        Me.LogOutButton.Text = "Logout"
        Me.LogOutButton.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(300, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "SETTINGS"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(727, 578)
        Me.Controls.Add(Me.MainMenuGroupBox)
        Me.Controls.Add(Me.SalesGroupBox)
        Me.Controls.Add(Me.SettingsGroupBox)
        Me.Controls.Add(Me.POSControlGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.MainMenuGroupBox.ResumeLayout(False)
        Me.POSControlGroupBox.ResumeLayout(False)
        Me.POSControlGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.SalesGroupBox.ResumeLayout(False)
        Me.SalesGroupBox.PerformLayout()
        Me.SettingsGroupBox.ResumeLayout(False)
        Me.SettingsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainMenuGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents POSControlGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SettingsButton As System.Windows.Forms.Button
    Friend WithEvents SalesButton As System.Windows.Forms.Button
    Friend WithEvents POSButton As System.Windows.Forms.Button
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents VoidButton As System.Windows.Forms.Button
    Friend WithEvents AddItemButton As System.Windows.Forms.Button
    Friend WithEvents ItemListBox As System.Windows.Forms.ListBox
    Friend WithEvents PriceLabel As System.Windows.Forms.Label
    Friend WithEvents ProductNameCombobox As System.Windows.Forms.ComboBox
    Friend WithEvents CategoriesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SalesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ItemSoldListBox As System.Windows.Forms.ListBox
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SettingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents LogOutButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TotalAmountLabel As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents AmountLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblTotalSales As System.Windows.Forms.Label
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
