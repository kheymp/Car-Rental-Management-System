<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCamera
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
        btnSave = New Button()
        Label8 = New Label()
        CType(picCamera, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPreview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picCamera
        ' 
        picCamera.BackColor = Color.DarkGray
        picCamera.Location = New Point(86, 106)
        picCamera.Name = "picCamera"
        picCamera.Size = New Size(835, 467)
        picCamera.SizeMode = PictureBoxSizeMode.StretchImage
        picCamera.TabIndex = 0
        picCamera.TabStop = False
        ' 
        ' picPreview
        ' 
        picPreview.BackColor = Color.DarkGray
        picPreview.Location = New Point(86, 579)
        picPreview.Name = "picPreview"
        picPreview.Size = New Size(199, 130)
        picPreview.SizeMode = PictureBoxSizeMode.StretchImage
        picPreview.TabIndex = 1
        picPreview.TabStop = False
        ' 
        ' btnCapture
        ' 
        btnCapture.BackColor = Color.White
        btnCapture.Font = New Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCapture.ForeColor = Color.OrangeRed
        btnCapture.Location = New Point(420, 579)
        btnCapture.Name = "btnCapture"
        btnCapture.Size = New Size(166, 32)
        btnCapture.TabIndex = 6
        btnCapture.Text = "Capture"
        btnCapture.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.White
        btnSave.Font = New Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.OrangeRed
        btnSave.Location = New Point(420, 617)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(166, 32)
        btnSave.TabIndex = 7
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell Condensed", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(375, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(256, 94)
        Label8.TabIndex = 18
        Label8.Text = "Smile :-)"
        ' 
        ' frmCamera
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1006, 721)
        Controls.Add(Label8)
        Controls.Add(btnSave)
        Controls.Add(btnCapture)
        Controls.Add(picPreview)
        Controls.Add(picCamera)
        Name = "frmCamera"
        Text = "Smile :-)"
        CType(picCamera, ComponentModel.ISupportInitialize).EndInit()
        CType(picPreview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picCamera As PictureBox
    Friend WithEvents picPreview As PictureBox
    Friend WithEvents btnCapture As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label8 As Label
End Class
