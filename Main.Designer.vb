<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        pnlMain = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        btnAddVehicle = New Button()
        btnBookCar = New Button()
        Button3 = New Button()
        btnRefreshPage = New Button()
        PictureBox2 = New PictureBox()
        PictureBox4 = New PictureBox()
        animationTimer = New Timer(components)
        animationTimer1 = New Timer(components)
        btnViewAll = New Button()
        pnlMain.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.White
        pnlMain.BorderStyle = BorderStyle.FixedSingle
        pnlMain.Controls.Add(Label3)
        pnlMain.Controls.Add(Label2)
        pnlMain.Controls.Add(PictureBox3)
        pnlMain.Location = New Point(195, 173)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(717, 538)
        pnlMain.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("Rockwell", 18F, FontStyle.Bold)
        Label3.ForeColor = Color.Gold
        Label3.Location = New Point(9, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(697, 38)
        Label3.TabIndex = 1
        Label3.Text = "Click the button on the left side to get started."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Black
        Label2.Font = New Font("Rockwell", 18F, FontStyle.Bold)
        Label2.ForeColor = Color.Gold
        Label2.Location = New Point(146, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(422, 38)
        Label2.TabIndex = 0
        Label2.Text = "Welcome to Wheels 4 Rent!"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.DimGray
        PictureBox3.Dock = DockStyle.Fill
        PictureBox3.Image = My.Resources.Resources.spark_metal
        PictureBox3.Location = New Point(0, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(715, 536)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell Condensed", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(223, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(408, 141)
        Label1.TabIndex = 1
        Label1.Text = "Wheels 4"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell Condensed", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.OrangeRed
        Label4.Location = New Point(620, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(231, 141)
        Label4.TabIndex = 2
        Label4.Text = "Rent"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.white_yellow_stripe_img
        PictureBox1.Location = New Point(184, 163)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(739, 554)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' btnAddVehicle
        ' 
        btnAddVehicle.BackColor = Color.White
        btnAddVehicle.Font = New Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddVehicle.ForeColor = Color.OrangeRed
        btnAddVehicle.Location = New Point(12, 211)
        btnAddVehicle.Name = "btnAddVehicle"
        btnAddVehicle.Size = New Size(166, 32)
        btnAddVehicle.TabIndex = 4
        btnAddVehicle.Text = "Add Vehicle"
        btnAddVehicle.UseVisualStyleBackColor = False
        ' 
        ' btnBookCar
        ' 
        btnBookCar.BackColor = Color.White
        btnBookCar.Font = New Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBookCar.ForeColor = Color.OrangeRed
        btnBookCar.Location = New Point(12, 249)
        btnBookCar.Name = "btnBookCar"
        btnBookCar.Size = New Size(166, 32)
        btnBookCar.TabIndex = 5
        btnBookCar.Text = "Book a Car"
        btnBookCar.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.Font = New Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.OrangeRed
        Button3.Location = New Point(12, 287)
        Button3.Name = "Button3"
        Button3.Size = New Size(166, 32)
        Button3.TabIndex = 6
        Button3.Text = "View Status"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btnRefreshPage
        ' 
        btnRefreshPage.BackColor = Color.White
        btnRefreshPage.Font = New Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefreshPage.ForeColor = Color.OrangeRed
        btnRefreshPage.Location = New Point(929, 211)
        btnRefreshPage.Name = "btnRefreshPage"
        btnRefreshPage.Size = New Size(166, 32)
        btnRefreshPage.TabIndex = 7
        btnRefreshPage.Text = "Refresh"
        btnRefreshPage.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.png_metallic
        PictureBox2.Location = New Point(-9, 163)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1124, 554)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.fire_spark
        PictureBox4.Location = New Point(-9, 0)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(1112, 243)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 9
        PictureBox4.TabStop = False
        ' 
        ' animationTimer
        ' 
        ' 
        ' btnViewAll
        ' 
        btnViewAll.BackColor = Color.White
        btnViewAll.Font = New Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewAll.ForeColor = Color.OrangeRed
        btnViewAll.Location = New Point(12, 325)
        btnViewAll.Name = "btnViewAll"
        btnViewAll.Size = New Size(166, 32)
        btnViewAll.TabIndex = 10
        btnViewAll.Text = "View All"
        btnViewAll.UseVisualStyleBackColor = False
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1106, 721)
        Controls.Add(btnViewAll)
        Controls.Add(btnRefreshPage)
        Controls.Add(Button3)
        Controls.Add(btnBookCar)
        Controls.Add(btnAddVehicle)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(pnlMain)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox4)
        Name = "frmMain"
        Text = "Wheels 4 Rent"
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAddVehicle As Button
    Friend WithEvents btnBookCar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnRefreshPage As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents animationTimer As Timer
    Friend WithEvents animationTimer1 As Timer
    Friend WithEvents btnViewAll As Button

End Class
