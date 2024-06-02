<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing
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
        Label8 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtName = New TextBox()
        txtBirthDate = New DateTimePicker()
        txtSex = New ComboBox()
        txtAddress = New TextBox()
        txtCarID = New TextBox()
        btnPay = New Button()
        txtCash = New TextBox()
        Label7 = New Label()
        txtDailyPrice = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        txtTotalPrice = New TextBox()
        picProfile = New PictureBox()
        btnTakePic = New Button()
        txtStartDate = New DateTimePicker()
        txtEndDate = New DateTimePicker()
        Label6 = New Label()
        Label11 = New Label()
        txtUnavailableDates = New DataGridView()
        strStartDate = New DataGridViewTextBoxColumn()
        strEndDate = New DataGridViewTextBoxColumn()
        Label12 = New Label()
        btnAlready = New Button()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtUnavailableDates, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell Condensed", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(248, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(203, 94)
        Label8.TabIndex = 16
        Label8.Text = "Billing"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(43, 160)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 38)
        Label1.TabIndex = 17
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 18F, FontStyle.Bold)
        Label2.Location = New Point(13, 201)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 38)
        Label2.TabIndex = 18
        Label2.Text = "Birthday"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 18F, FontStyle.Bold)
        Label3.Location = New Point(81, 248)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 38)
        Label3.TabIndex = 19
        Label3.Text = "Sex"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 18F, FontStyle.Bold)
        Label4.Location = New Point(12, 297)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 38)
        Label4.TabIndex = 20
        Label4.Text = "Address"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 18F, FontStyle.Bold)
        Label5.Location = New Point(434, 61)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 38)
        Label5.TabIndex = 21
        Label5.Text = "Car ID"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Rockwell", 18F)
        txtName.ForeColor = Color.Black
        txtName.Location = New Point(154, 155)
        txtName.Name = "txtName"
        txtName.Size = New Size(240, 43)
        txtName.TabIndex = 23
        ' 
        ' txtBirthDate
        ' 
        txtBirthDate.CalendarFont = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBirthDate.Font = New Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBirthDate.Location = New Point(154, 206)
        txtBirthDate.Name = "txtBirthDate"
        txtBirthDate.Size = New Size(240, 31)
        txtBirthDate.TabIndex = 30
        ' 
        ' txtSex
        ' 
        txtSex.DropDownStyle = ComboBoxStyle.DropDownList
        txtSex.Font = New Font("Rockwell", 18F)
        txtSex.FormattingEnabled = True
        txtSex.Items.AddRange(New Object() {"Male", "Female"})
        txtSex.Location = New Point(154, 243)
        txtSex.Name = "txtSex"
        txtSex.Size = New Size(240, 43)
        txtSex.TabIndex = 31
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Rockwell", 18F)
        txtAddress.ForeColor = Color.Black
        txtAddress.Location = New Point(154, 292)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(240, 43)
        txtAddress.TabIndex = 32
        ' 
        ' txtCarID
        ' 
        txtCarID.Font = New Font("Rockwell", 18F)
        txtCarID.ForeColor = Color.Black
        txtCarID.Location = New Point(554, 53)
        txtCarID.Name = "txtCarID"
        txtCarID.ReadOnly = True
        txtCarID.Size = New Size(134, 43)
        txtCarID.TabIndex = 33
        ' 
        ' btnPay
        ' 
        btnPay.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPay.ForeColor = Color.OrangeRed
        btnPay.Location = New Point(577, 448)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(111, 39)
        btnPay.TabIndex = 37
        btnPay.Text = "Pay"
        btnPay.UseVisualStyleBackColor = True
        ' 
        ' txtCash
        ' 
        txtCash.Font = New Font("Rockwell", 18F)
        txtCash.ForeColor = Color.Black
        txtCash.Location = New Point(448, 444)
        txtCash.Name = "txtCash"
        txtCash.Size = New Size(124, 43)
        txtCash.TabIndex = 38
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 18F, FontStyle.Bold)
        Label7.Location = New Point(351, 449)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 38)
        Label7.TabIndex = 39
        Label7.Text = "Cash"
        ' 
        ' txtDailyPrice
        ' 
        txtDailyPrice.Font = New Font("Rockwell", 18F)
        txtDailyPrice.ForeColor = Color.Black
        txtDailyPrice.Location = New Point(270, 340)
        txtDailyPrice.Name = "txtDailyPrice"
        txtDailyPrice.ReadOnly = True
        txtDailyPrice.Size = New Size(124, 43)
        txtDailyPrice.TabIndex = 40
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Rockwell", 18F, FontStyle.Bold)
        Label9.Location = New Point(81, 346)
        Label9.Name = "Label9"
        Label9.Size = New Size(184, 38)
        Label9.TabIndex = 41
        Label9.Text = "Daily Price"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Rockwell", 18F, FontStyle.Bold)
        Label10.Location = New Point(378, 395)
        Label10.Name = "Label10"
        Label10.Size = New Size(179, 38)
        Label10.TabIndex = 42
        Label10.Text = "Total Price"
        ' 
        ' txtTotalPrice
        ' 
        txtTotalPrice.Font = New Font("Rockwell", 18F)
        txtTotalPrice.ForeColor = Color.Black
        txtTotalPrice.Location = New Point(563, 390)
        txtTotalPrice.Name = "txtTotalPrice"
        txtTotalPrice.ReadOnly = True
        txtTotalPrice.Size = New Size(124, 43)
        txtTotalPrice.TabIndex = 43
        ' 
        ' picProfile
        ' 
        picProfile.BackColor = Color.DarkGray
        picProfile.Location = New Point(19, 12)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(185, 140)
        picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        picProfile.TabIndex = 44
        picProfile.TabStop = False
        ' 
        ' btnTakePic
        ' 
        btnTakePic.Enabled = False
        btnTakePic.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTakePic.ForeColor = Color.OrangeRed
        btnTakePic.Location = New Point(210, 113)
        btnTakePic.Name = "btnTakePic"
        btnTakePic.Size = New Size(111, 39)
        btnTakePic.TabIndex = 45
        btnTakePic.Text = "Pic"
        btnTakePic.UseVisualStyleBackColor = True
        ' 
        ' txtStartDate
        ' 
        txtStartDate.CalendarFont = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStartDate.Font = New Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStartDate.Location = New Point(448, 288)
        txtStartDate.Name = "txtStartDate"
        txtStartDate.Size = New Size(240, 31)
        txtStartDate.TabIndex = 46
        ' 
        ' txtEndDate
        ' 
        txtEndDate.CalendarFont = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEndDate.Font = New Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEndDate.Location = New Point(448, 325)
        txtEndDate.Name = "txtEndDate"
        txtEndDate.Size = New Size(240, 31)
        txtEndDate.TabIndex = 47
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(398, 302)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 17)
        Label6.TabIndex = 48
        Label6.Text = "From"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(416, 339)
        Label11.Name = "Label11"
        Label11.Size = New Size(26, 17)
        Label11.TabIndex = 49
        Label11.Text = "To"
        ' 
        ' txtUnavailableDates
        ' 
        txtUnavailableDates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        txtUnavailableDates.Columns.AddRange(New DataGridViewColumn() {strStartDate, strEndDate})
        txtUnavailableDates.Location = New Point(400, 155)
        txtUnavailableDates.Name = "txtUnavailableDates"
        txtUnavailableDates.RowHeadersWidth = 51
        txtUnavailableDates.Size = New Size(300, 127)
        txtUnavailableDates.TabIndex = 50
        ' 
        ' strStartDate
        ' 
        strStartDate.HeaderText = "Start Date"
        strStartDate.MinimumWidth = 6
        strStartDate.Name = "strStartDate"
        strStartDate.Width = 125
        ' 
        ' strEndDate
        ' 
        strEndDate.HeaderText = "End Date"
        strEndDate.MinimumWidth = 6
        strEndDate.Name = "strEndDate"
        strEndDate.Width = 125
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(400, 113)
        Label12.Name = "Label12"
        Label12.Size = New Size(285, 38)
        Label12.TabIndex = 51
        Label12.Text = "Unavailable Dates"
        ' 
        ' btnAlready
        ' 
        btnAlready.Location = New Point(12, 450)
        btnAlready.Name = "btnAlready"
        btnAlready.Size = New Size(147, 29)
        btnAlready.TabIndex = 52
        btnAlready.Text = "Already a Customer"
        btnAlready.UseVisualStyleBackColor = True
        ' 
        ' Billing
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(699, 491)
        Controls.Add(btnAlready)
        Controls.Add(Label12)
        Controls.Add(txtUnavailableDates)
        Controls.Add(Label11)
        Controls.Add(Label6)
        Controls.Add(txtEndDate)
        Controls.Add(txtStartDate)
        Controls.Add(btnTakePic)
        Controls.Add(picProfile)
        Controls.Add(txtTotalPrice)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(txtDailyPrice)
        Controls.Add(Label7)
        Controls.Add(txtCash)
        Controls.Add(btnPay)
        Controls.Add(txtCarID)
        Controls.Add(txtAddress)
        Controls.Add(txtSex)
        Controls.Add(txtBirthDate)
        Controls.Add(txtName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label8)
        Name = "Billing"
        Text = "Billing"
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        CType(txtUnavailableDates, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtBirthDate As DateTimePicker
    Friend WithEvents txtSex As ComboBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCarID As TextBox
    Friend WithEvents btnPay As Button
    Friend WithEvents txtCash As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDailyPrice As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents btnTakePic As Button
    Friend WithEvents txtStartDate As DateTimePicker
    Friend WithEvents txtEndDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUnavailableDates As DataGridView
    Friend WithEvents strStartDate As DataGridViewTextBoxColumn
    Friend WithEvents strEndDate As DataGridViewTextBoxColumn
    Friend WithEvents Label12 As Label
    Friend WithEvents btnAlready As Button
End Class
