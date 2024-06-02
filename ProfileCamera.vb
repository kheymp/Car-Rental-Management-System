Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Public Class frmCamera
    Dim CAMERA As VideoCaptureDevice
    Dim bmp As Bitmap


    Private Sub CaptureMe(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone, Bitmap)
        picCamera.Image = DirectCast(eventArgs.Frame.Clone, Bitmap)
    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        picPreview.Image = picCamera.Image
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Dim saveFileDialog As New SaveFileDialog()
        'SaveFileDialog.DefaultExt = ".jpg"
        'If saveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        'picPreview.Image.Save(saveFileDialog.FileName, Imaging.ImageFormat.Jpeg)
        'End If
        'picPreview.Image.Save("Customers\" + Billing.txtName.Text + ".jpg", Imaging.ImageFormat.Jpeg)
        Billing.picProfile.Image = picPreview.Image
        MessageBox.Show("Picture taken successfully.")
        Me.Close()
    End Sub

    Private Sub frmCamera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameras.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            CAMERA = cameras.VideoDevice
            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf CaptureMe)
            CAMERA.Start()
        End If
    End Sub

    Private Sub frmCamera_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            ' Stop the camera
            picPreview.Image = Nothing
            CAMERA.SignalToStop()
            CAMERA.WaitForStop()


        Catch ex As Exception
            ' Handle the exception
            MessageBox.Show("An error occurred while stopping the camera: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class