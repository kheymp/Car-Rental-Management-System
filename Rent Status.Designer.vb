<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentStatus
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
        txtCarID = New TextBox()
        Label1 = New Label()
        btnView = New Button()
        picVehicle = New PictureBox()
        Label5 = New Label()
        txtName = New TextBox()
        Label2 = New Label()
        txtBirthDate = New TextBox()
        Label3 = New Label()
        txtAge = New TextBox()
        txtGender = New TextBox()
        Label4 = New Label()
        Label6 = New Label()
        txtAddress = New TextBox()
        Label7 = New Label()
        txtRemaining = New TextBox()
        Label8 = New Label()
        txtTotalPrice = New TextBox()
        btnDelete = New Button()
        btnModify = New Button()
        txtStartDate = New TextBox()
        txtEndDate = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        txtRecord = New TextBox()
        picProfile = New PictureBox()
        btnScan = New Button()
        pnlRecord = New Panel()
        CType(picVehicle, ComponentModel.ISupportInitialize).BeginInit()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtCarID
        ' 
        txtCarID.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCarID.Location = New Point(204, 7)
        txtCarID.Name = "txtCarID"
        txtCarID.Size = New Size(148, 43)
        txtCarID.TabIndex = 31
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 35)
        Label1.TabIndex = 30
        Label1.Text = "Customer ID"
        ' 
        ' btnView
        ' 
        btnView.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnView.ForeColor = Color.OrangeRed
        btnView.Location = New Point(358, 11)
        btnView.Name = "btnView"
        btnView.Size = New Size(111, 39)
        btnView.TabIndex = 37
        btnView.Text = "View"
        btnView.UseVisualStyleBackColor = True
        ' 
        ' picVehicle
        ' 
        picVehicle.BackColor = Color.DimGray
        picVehicle.Location = New Point(16, 112)
        picVehicle.Name = "picVehicle"
        picVehicle.Size = New Size(416, 267)
        picVehicle.SizeMode = PictureBoxSizeMode.StretchImage
        picVehicle.TabIndex = 38
        picVehicle.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(453, 279)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 22)
        Label5.TabIndex = 39
        Label5.Text = "Rented by"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(562, 276)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(125, 25)
        txtName.TabIndex = 40
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(28, 385)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 22)
        Label2.TabIndex = 41
        Label2.Text = "Birthdate"
        ' 
        ' txtBirthDate
        ' 
        txtBirthDate.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBirthDate.Location = New Point(128, 382)
        txtBirthDate.Name = "txtBirthDate"
        txtBirthDate.ReadOnly = True
        txtBirthDate.Size = New Size(125, 25)
        txtBirthDate.TabIndex = 42
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(74, 416)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 22)
        Label3.TabIndex = 43
        Label3.Text = "Age"
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAge.Location = New Point(128, 413)
        txtAge.Name = "txtAge"
        txtAge.ReadOnly = True
        txtAge.Size = New Size(125, 25)
        txtAge.TabIndex = 44
        ' 
        ' txtGender
        ' 
        txtGender.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGender.Location = New Point(345, 382)
        txtGender.Name = "txtGender"
        txtGender.ReadOnly = True
        txtGender.Size = New Size(125, 25)
        txtGender.TabIndex = 45
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(259, 385)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 22)
        Label4.TabIndex = 46
        Label4.Text = "Gender"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(259, 416)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 22)
        Label6.TabIndex = 47
        Label6.Text = "Address"
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAddress.Location = New Point(345, 413)
        txtAddress.Name = "txtAddress"
        txtAddress.ReadOnly = True
        txtAddress.Size = New Size(125, 25)
        txtAddress.TabIndex = 48
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(455, 326)
        Label7.Name = "Label7"
        Label7.Size = New Size(164, 44)
        Label7.TabIndex = 49
        Label7.Text = "Remaining Days " & vbCrLf & "From Start Date"
        ' 
        ' txtRemaining
        ' 
        txtRemaining.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRemaining.Location = New Point(625, 336)
        txtRemaining.Name = "txtRemaining"
        txtRemaining.ReadOnly = True
        txtRemaining.Size = New Size(62, 25)
        txtRemaining.TabIndex = 50
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(388, 457)
        Label8.Name = "Label8"
        Label8.Size = New Size(168, 22)
        Label8.TabIndex = 51
        Label8.Text = "Total Price (Paid)"
        ' 
        ' txtTotalPrice
        ' 
        txtTotalPrice.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTotalPrice.Location = New Point(562, 454)
        txtTotalPrice.Name = "txtTotalPrice"
        txtTotalPrice.ReadOnly = True
        txtTotalPrice.Size = New Size(125, 25)
        txtTotalPrice.TabIndex = 52
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.OrangeRed
        btnDelete.Location = New Point(133, 67)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(111, 39)
        btnDelete.TabIndex = 53
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnModify
        ' 
        btnModify.Font = New Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnModify.ForeColor = Color.OrangeRed
        btnModify.Location = New Point(16, 67)
        btnModify.Name = "btnModify"
        btnModify.Size = New Size(111, 39)
        btnModify.TabIndex = 54
        btnModify.Text = "Modify"
        btnModify.UseVisualStyleBackColor = True
        ' 
        ' txtStartDate
        ' 
        txtStartDate.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStartDate.Location = New Point(592, 392)
        txtStartDate.Name = "txtStartDate"
        txtStartDate.ReadOnly = True
        txtStartDate.Size = New Size(95, 25)
        txtStartDate.TabIndex = 55
        ' 
        ' txtEndDate
        ' 
        txtEndDate.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEndDate.Location = New Point(592, 423)
        txtEndDate.Name = "txtEndDate"
        txtEndDate.ReadOnly = True
        txtEndDate.Size = New Size(95, 25)
        txtEndDate.TabIndex = 56
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(491, 426)
        Label9.Name = "Label9"
        Label9.Size = New Size(95, 22)
        Label9.TabIndex = 57
        Label9.Text = "End Date"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(486, 395)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 22)
        Label10.TabIndex = 58
        Label10.Text = "Start Date"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(466, 58)
        Label11.Name = "Label11"
        Label11.Size = New Size(75, 22)
        Label11.TabIndex = 59
        Label11.Text = "Record"
        ' 
        ' txtRecord
        ' 
        txtRecord.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRecord.ForeColor = Color.DarkGreen
        txtRecord.Location = New Point(547, 55)
        txtRecord.Name = "txtRecord"
        txtRecord.ReadOnly = True
        txtRecord.Size = New Size(125, 25)
        txtRecord.TabIndex = 60
        ' 
        ' picProfile
        ' 
        picProfile.BackColor = Color.DimGray
        picProfile.Location = New Point(438, 112)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(249, 158)
        picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        picProfile.TabIndex = 61
        picProfile.TabStop = False
        ' 
        ' btnScan
        ' 
        btnScan.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnScan.ForeColor = Color.OrangeRed
        btnScan.Location = New Point(475, 11)
        btnScan.Name = "btnScan"
        btnScan.Size = New Size(111, 39)
        btnScan.TabIndex = 62
        btnScan.Text = "QR"
        btnScan.UseVisualStyleBackColor = True
        ' 
        ' pnlRecord
        ' 
        pnlRecord.BackColor = Color.Gray
        pnlRecord.Location = New Point(647, 24)
        pnlRecord.Name = "pnlRecord"
        pnlRecord.Size = New Size(25, 25)
        pnlRecord.TabIndex = 63
        ' 
        ' frmRentStatus
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(699, 491)
        Controls.Add(pnlRecord)
        Controls.Add(btnScan)
        Controls.Add(picProfile)
        Controls.Add(txtRecord)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(txtEndDate)
        Controls.Add(txtStartDate)
        Controls.Add(btnModify)
        Controls.Add(btnDelete)
        Controls.Add(txtTotalPrice)
        Controls.Add(Label8)
        Controls.Add(txtRemaining)
        Controls.Add(Label7)
        Controls.Add(txtAddress)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(txtGender)
        Controls.Add(txtAge)
        Controls.Add(Label3)
        Controls.Add(txtBirthDate)
        Controls.Add(Label2)
        Controls.Add(txtName)
        Controls.Add(Label5)
        Controls.Add(picVehicle)
        Controls.Add(btnView)
        Controls.Add(txtCarID)
        Controls.Add(Label1)
        Name = "frmRentStatus"
        Text = "Rent_Status"
        CType(picVehicle, ComponentModel.ISupportInitialize).EndInit()
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCarID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnView As Button
    Friend WithEvents picVehicle As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBirthDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRemaining As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents txtStartDate As TextBox
    Friend WithEvents txtEndDate As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRecord As TextBox
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents btnScan As Button
    Friend WithEvents pnlRecord As Panel
End Class
