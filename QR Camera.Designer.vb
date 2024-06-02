<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQRCamera
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
        picCamera = New PictureBox()
        picPreview = New PictureBox()
        btnCapture = New Button()
        btnScan = New Button()
        Label8 = New Label()
        CType(picCamera, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPreview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picCamera
        ' 
        picCamera.Location = New Point(10, 102)
        picCamera.Name = "picCamera"
        picCamera.Size = New Size(540, 390)
        picCamera.SizeMode = PictureBoxSizeMode.StretchImage
        picCamera.TabIndex = 0
        picCamera.TabStop = False
        ' 
        ' picPreview
        ' 
        picPreview.Location = New Point(556, 102)
        picPreview.Name = "picPreview"
        picPreview.Size = New Size(540, 390)
        picPreview.SizeMode = PictureBoxSizeMode.StretchImage
        picPreview.TabIndex = 1
        picPreview.TabStop = False
        ' 
        ' btnCapture
        ' 
        btnCapture.BackColor = Color.White
        btnCapture.Font = New Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCapture.ForeColor = Color.OrangeRed
        btnCapture.Location = New Point(470, 537)
        btnCapture.Name = "btnCapture"
        btnCapture.Size = New Size(166, 32)
        btnCapture.TabIndex = 7
        btnCapture.Text = "Capture"
        btnCapture.UseVisualStyleBackColor = False
        ' 
        ' btnScan
        ' 
        btnScan.BackColor = Color.White
        btnScan.Font = New Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnScan.ForeColor = Color.OrangeRed
        btnScan.Location = New Point(470, 575)
        btnScan.Name = "btnScan"
        btnScan.Size = New Size(166, 32)
        btnScan.TabIndex = 8
        btnScan.Text = "Scan"
        btnScan.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell Condensed", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(425, 5)
        Label8.Name = "Label8"
        Label8.Size = New Size(256, 94)
        Label8.TabIndex = 17
        Label8.Text = "QR Scan"
        ' 
        ' frmQRCamera
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1106, 721)
        Controls.Add(Label8)
        Controls.Add(btnScan)
        Controls.Add(btnCapture)
        Controls.Add(picPreview)
        Controls.Add(picCamera)
        Name = "frmQRCamera"
        Text = "QR Camera"
        CType(picCamera, ComponentModel.ISupportInitialize).EndInit()
        CType(picPreview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picCamera As PictureBox
    Friend WithEvents picPreview As PictureBox
    Friend WithEvents btnCapture As Button
    Friend WithEvents btnScan As Button
    Friend WithEvents Label8 As Label
End Class
