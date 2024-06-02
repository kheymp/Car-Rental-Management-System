<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBook
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
        btnBack = New Button()
        Button1 = New Button()
        Label8 = New Label()
        picVehicle = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label9 = New Label()
        txtPlateNo = New TextBox()
        txtStatus = New TextBox()
        txtCarID = New TextBox()
        txtCarColor = New TextBox()
        txtDailyPrice = New TextBox()
        txtType = New TextBox()
        txtBodyNo = New TextBox()
        txtCapacity = New TextBox()
        Button2 = New Button()
        btnDelete = New Button()
        CType(picVehicle, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.OrangeRed
        btnBack.Font = New Font("Rockwell", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(12, 205)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(80, 80)
        btnBack.TabIndex = 0
        btnBack.Text = "←"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.OrangeRed
        Button1.Font = New Font("Rockwell", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(607, 205)
        Button1.Name = "Button1"
        Button1.Size = New Size(80, 80)
        Button1.TabIndex = 1
        Button1.Text = "→"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell Condensed", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(136, 12)
        Label8.Name = "Label8"
        Label8.Size = New Size(427, 94)
        Label8.TabIndex = 16
        Label8.Text = "Book a Vehicle"
        ' 
        ' picVehicle
        ' 
        picVehicle.Location = New Point(141, 142)
        picVehicle.Name = "picVehicle"
        picVehicle.Size = New Size(416, 267)
        picVehicle.SizeMode = PictureBoxSizeMode.StretchImage
        picVehicle.TabIndex = 17
        picVehicle.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(259, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 22)
        Label1.TabIndex = 18
        Label1.Text = "Car ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 288)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 22)
        Label2.TabIndex = 19
        Label2.Text = "Plate No"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(15, 394)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 22)
        Label3.TabIndex = 20
        Label3.Text = "Color"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(563, 341)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 22)
        Label4.TabIndex = 21
        Label4.Text = "Type"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(563, 288)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 22)
        Label5.TabIndex = 22
        Label5.Text = "Capacity"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(563, 394)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 22)
        Label6.TabIndex = 23
        Label6.Text = "Body No"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(229, 418)
        Label7.Name = "Label7"
        Label7.Size = New Size(110, 22)
        Label7.TabIndex = 24
        Label7.Text = "Daily Price"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(12, 341)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 22)
        Label9.TabIndex = 25
        Label9.Text = "Status"
        ' 
        ' txtPlateNo
        ' 
        txtPlateNo.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPlateNo.Location = New Point(12, 313)
        txtPlateNo.Name = "txtPlateNo"
        txtPlateNo.ReadOnly = True
        txtPlateNo.Size = New Size(125, 25)
        txtPlateNo.TabIndex = 27
        ' 
        ' txtStatus
        ' 
        txtStatus.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStatus.Location = New Point(12, 366)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(125, 25)
        txtStatus.TabIndex = 28
        ' 
        ' txtCarID
        ' 
        txtCarID.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCarID.Location = New Point(335, 111)
        txtCarID.Name = "txtCarID"
        txtCarID.ReadOnly = True
        txtCarID.Size = New Size(125, 25)
        txtCarID.TabIndex = 29
        ' 
        ' txtCarColor
        ' 
        txtCarColor.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCarColor.Location = New Point(15, 419)
        txtCarColor.Name = "txtCarColor"
        txtCarColor.ReadOnly = True
        txtCarColor.Size = New Size(125, 25)
        txtCarColor.TabIndex = 30
        ' 
        ' txtDailyPrice
        ' 
        txtDailyPrice.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDailyPrice.Location = New Point(345, 419)
        txtDailyPrice.Name = "txtDailyPrice"
        txtDailyPrice.ReadOnly = True
        txtDailyPrice.Size = New Size(125, 25)
        txtDailyPrice.TabIndex = 31
        ' 
        ' txtType
        ' 
        txtType.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtType.Location = New Point(562, 366)
        txtType.Name = "txtType"
        txtType.ReadOnly = True
        txtType.Size = New Size(125, 25)
        txtType.TabIndex = 32
        ' 
        ' txtBodyNo
        ' 
        txtBodyNo.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBodyNo.Location = New Point(562, 419)
        txtBodyNo.Name = "txtBodyNo"
        txtBodyNo.ReadOnly = True
        txtBodyNo.Size = New Size(125, 25)
        txtBodyNo.TabIndex = 33
        ' 
        ' txtCapacity
        ' 
        txtCapacity.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCapacity.Location = New Point(562, 313)
        txtCapacity.Name = "txtCapacity"
        txtCapacity.ReadOnly = True
        txtCapacity.Size = New Size(125, 25)
        txtCapacity.TabIndex = 35
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.OrangeRed
        Button2.Location = New Point(576, 449)
        Button2.Name = "Button2"
        Button2.Size = New Size(111, 39)
        Button2.TabIndex = 36
        Button2.Text = "Rent"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.OrangeRed
        btnDelete.Location = New Point(12, 57)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(118, 39)
        btnDelete.TabIndex = 37
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' frmBook
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(699, 491)
        Controls.Add(btnDelete)
        Controls.Add(Button2)
        Controls.Add(txtCapacity)
        Controls.Add(txtBodyNo)
        Controls.Add(txtType)
        Controls.Add(txtDailyPrice)
        Controls.Add(txtCarColor)
        Controls.Add(txtCarID)
        Controls.Add(txtStatus)
        Controls.Add(txtPlateNo)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(picVehicle)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(btnBack)
        Name = "frmBook"
        Text = "Book"
        CType(picVehicle, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents picVehicle As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPlateNo As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtCarID As TextBox
    Friend WithEvents txtCarColor As TextBox
    Friend WithEvents txtDailyPrice As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtBodyNo As TextBox
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnDelete As Button
End Class
