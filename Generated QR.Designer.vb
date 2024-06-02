<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneratedQR
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
        picQRCode = New PictureBox()
        Label8 = New Label()
        CType(picQRCode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picQRCode
        ' 
        picQRCode.Location = New Point(174, 118)
        picQRCode.Name = "picQRCode"
        picQRCode.Size = New Size(350, 350)
        picQRCode.SizeMode = PictureBoxSizeMode.StretchImage
        picQRCode.TabIndex = 0
        picQRCode.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell Condensed", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(151, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(397, 94)
        Label8.TabIndex = 17
        Label8.Text = "Your QR Code"
        ' 
        ' frmGeneratedQR
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(699, 489)
        Controls.Add(Label8)
        Controls.Add(picQRCode)
        Name = "frmGeneratedQR"
        Text = "Generated QR"
        CType(picQRCode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picQRCode As PictureBox
    Friend WithEvents Label8 As Label
End Class
