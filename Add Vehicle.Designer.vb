<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddVehicle
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtPlateNo = New TextBox()
        txtBodyNo = New TextBox()
        Label8 = New Label()
        btnSubmitVehicle = New Button()
        txtCarType = New ComboBox()
        Label9 = New Label()
        txtDailyPrice = New TextBox()
        txtCarCapacity = New NumericUpDown()
        txtColor = New ComboBox()
        picVehicle = New PictureBox()
        btnImage = New Button()
        CType(txtCarCapacity, ComponentModel.ISupportInitialize).BeginInit()
        CType(picVehicle, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(77, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 38)
        Label2.TabIndex = 1
        Label2.Text = "Plate #"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(100, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 38)
        Label3.TabIndex = 2
        Label3.Text = "Color"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(107, 226)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 38)
        Label4.TabIndex = 3
        Label4.Text = "Type"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(48, 275)
        Label5.Name = "Label5"
        Label5.Size = New Size(150, 38)
        Label5.TabIndex = 4
        Label5.Text = "Capacity"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(78, 324)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 38)
        Label6.TabIndex = 5
        Label6.Text = "Body #"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(14, 373)
        Label7.Name = "Label7"
        Label7.Size = New Size(184, 38)
        Label7.TabIndex = 6
        Label7.Text = "Daily Price"
        ' 
        ' txtPlateNo
        ' 
        txtPlateNo.Font = New Font("Rockwell", 18F)
        txtPlateNo.ForeColor = Color.Black
        txtPlateNo.Location = New Point(204, 123)
        txtPlateNo.Name = "txtPlateNo"
        txtPlateNo.Size = New Size(240, 43)
        txtPlateNo.TabIndex = 13
        ' 
        ' txtBodyNo
        ' 
        txtBodyNo.Font = New Font("Rockwell", 18F)
        txtBodyNo.ForeColor = Color.Black
        txtBodyNo.Location = New Point(204, 319)
        txtBodyNo.Name = "txtBodyNo"
        txtBodyNo.Size = New Size(240, 43)
        txtBodyNo.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell Condensed", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(175, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(348, 94)
        Label8.TabIndex = 15
        Label8.Text = "Add Vehicle"
        ' 
        ' btnSubmitVehicle
        ' 
        btnSubmitVehicle.BackColor = Color.White
        btnSubmitVehicle.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmitVehicle.ForeColor = Color.OrangeRed
        btnSubmitVehicle.Location = New Point(283, 439)
        btnSubmitVehicle.Name = "btnSubmitVehicle"
        btnSubmitVehicle.Size = New Size(240, 43)
        btnSubmitVehicle.TabIndex = 16
        btnSubmitVehicle.Text = "Submit"
        btnSubmitVehicle.UseVisualStyleBackColor = False
        ' 
        ' txtCarType
        ' 
        txtCarType.DropDownStyle = ComboBoxStyle.DropDownList
        txtCarType.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCarType.ForeColor = Color.Black
        txtCarType.FormattingEnabled = True
        txtCarType.Items.AddRange(New Object() {"Sedan", "SUV", "Off-Road", "Truck"})
        txtCarType.Location = New Point(204, 221)
        txtCarType.Name = "txtCarType"
        txtCarType.Size = New Size(240, 43)
        txtCarType.TabIndex = 17
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(210, 370)
        Label9.Name = "Label9"
        Label9.Size = New Size(39, 38)
        Label9.TabIndex = 19
        Label9.Text = "₱"
        ' 
        ' txtDailyPrice
        ' 
        txtDailyPrice.Font = New Font("Rockwell", 18F)
        txtDailyPrice.ForeColor = Color.Black
        txtDailyPrice.Location = New Point(255, 365)
        txtDailyPrice.Name = "txtDailyPrice"
        txtDailyPrice.Size = New Size(189, 43)
        txtDailyPrice.TabIndex = 21
        ' 
        ' txtCarCapacity
        ' 
        txtCarCapacity.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCarCapacity.Location = New Point(204, 270)
        txtCarCapacity.Name = "txtCarCapacity"
        txtCarCapacity.ReadOnly = True
        txtCarCapacity.Size = New Size(240, 43)
        txtCarCapacity.TabIndex = 22
        ' 
        ' txtColor
        ' 
        txtColor.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtColor.FormattingEnabled = True
        txtColor.Items.AddRange(New Object() {"Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Black", "White", "Silver"})
        txtColor.Location = New Point(204, 172)
        txtColor.Name = "txtColor"
        txtColor.Size = New Size(240, 43)
        txtColor.TabIndex = 23
        ' 
        ' picVehicle
        ' 
        picVehicle.BackColor = Color.DarkGray
        picVehicle.Location = New Point(450, 123)
        picVehicle.Name = "picVehicle"
        picVehicle.Size = New Size(237, 141)
        picVehicle.SizeMode = PictureBoxSizeMode.StretchImage
        picVehicle.TabIndex = 25
        picVehicle.TabStop = False
        ' 
        ' btnImage
        ' 
        btnImage.BackColor = Color.White
        btnImage.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnImage.ForeColor = Color.OrangeRed
        btnImage.Location = New Point(560, 269)
        btnImage.Name = "btnImage"
        btnImage.Size = New Size(127, 43)
        btnImage.TabIndex = 26
        btnImage.Text = "Image"
        btnImage.UseVisualStyleBackColor = False
        ' 
        ' frmAddVehicle
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(699, 491)
        Controls.Add(btnImage)
        Controls.Add(picVehicle)
        Controls.Add(txtColor)
        Controls.Add(txtCarCapacity)
        Controls.Add(txtDailyPrice)
        Controls.Add(Label9)
        Controls.Add(txtCarType)
        Controls.Add(btnSubmitVehicle)
        Controls.Add(Label8)
        Controls.Add(txtBodyNo)
        Controls.Add(txtPlateNo)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "frmAddVehicle"
        Text = "Add_Vehicle"
        CType(txtCarCapacity, ComponentModel.ISupportInitialize).EndInit()
        CType(picVehicle, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents txtPlateNo As TextBox
    Friend WithEvents txtBodyNo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSubmitVehicle As Button
    Friend WithEvents txtCarType As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDailyPrice As TextBox
    Friend WithEvents txtCarCapacity As NumericUpDown
    Friend WithEvents txtColor As ComboBox
    Friend WithEvents picVehicle As PictureBox
    Friend WithEvents btnImage As Button
End Class
