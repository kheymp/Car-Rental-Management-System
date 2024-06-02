Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Codec.Data
Imports MessagingToolkit.QRCode.ExceptionHandler

Public Class frmQRCamera
    Dim CAMERA As VideoCaptureDevice
    Dim bmp As Bitmap
    Private Sub CaptureMe(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone, Bitmap)
        picCamera.Image = DirectCast(eventArgs.Frame.Clone, Bitmap)
    End Sub

    Private Sub frmQRCamera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameras.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            CAMERA = cameras.VideoDevice
            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf CaptureMe)
            CAMERA.Start()
        End If
    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        picPreview.Image = picCamera.Image
    End Sub

    Private Sub frmQRCamera_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        If picPreview.Image Is Nothing Then
            MessageBox.Show("Take a picture first.")
        Else
            Try
                Dim deco As QRCodeDecoder = New QRCodeDecoder
                frmRentStatus.txtCarID.Text = deco.Decode(New QRCodeBitmapImage(picPreview.Image))
                Dim carIDQR As String = deco.Decode(New QRCodeBitmapImage(picPreview.Image))
                MessageBox.Show("Scanned QR Code: " + carIDQR)
                frmRentStatus.tempFilePath = FindFileInDirectories(carIDQR + ".txt", "Customers\")
                If frmRentStatus.txtCarID.Text = "" Then
                    MsgBox("Enter proper ID.")
                ElseIf File.Exists(frmRentStatus.tempFilePath) = False Then
                    MsgBox("Customer ID not found.")
                ElseIf ReadFileLine(frmRentStatus.tempFilePath, 8) = "Days" Then
                    MessageBox.Show("Not found.")
                Else
                    frmRentStatus.strCarID = ReadFileLine(frmRentStatus.tempFilePath, 1)
                    frmRentStatus.dblDailyRate = Double.Parse(ReadFileLine("Vehicles\" + frmRentStatus.strCarID + ".txt", 7))
                    frmRentStatus.strName = ReadFileLine(frmRentStatus.tempFilePath, 3)
                    frmRentStatus.strBirthDate = Date.Parse(ReadFileLine(frmRentStatus.tempFilePath, 4))
                    frmRentStatus.age = ReadFileLine(frmRentStatus.tempFilePath, 5)
                    frmRentStatus.strGender = ReadFileLine(frmRentStatus.tempFilePath, 6)
                    frmRentStatus.strAddress = ReadFileLine(frmRentStatus.tempFilePath, 7)
                    frmRentStatus.intRemaining = Integer.Parse(ReadFileLine(frmRentStatus.tempFilePath, 8))
                    frmRentStatus.dblTotalPrice = Double.Parse(ReadFileLine(frmRentStatus.tempFilePath, 9))
                    frmRentStatus.startDate = ReadFileLine(frmRentStatus.tempFilePath, 10)
                    frmRentStatus.endDate = ReadFileLine(frmRentStatus.tempFilePath, 11)
                    frmRentStatus.record = ReadFileLine("Records\" + frmRentStatus.strName + ".txt", 2)

                    frmModify.originalRemain = frmRentStatus.intRemaining
                    frmModify.previousValue = frmModify.originalRemain
                    frmModify.endDate = frmRentStatus.endDate
                    frmModify.newEndDate = frmModify.endDate
                    frmModify.addPrice = 0
                    frmModify.txtNewPrice.Text = frmModify.addPrice
                    frmModify.newTotalPrice = 0
                    frmModify.txtNewPrice.Text = "---"
                    frmRentStatus.SetInfo()
                    Me.Close()
                End If
            Catch ex As DecodingFailedException
                ' Handle DecodingFailedException
                MessageBox.Show("Error decoding QR code: " & ex.Message)
            Catch ex As Exception
                ' Handle other exceptions
                MessageBox.Show("Error: " & ex.Message)
            End Try

        End If

    End Sub

    Private Function FindFileInDirectories(fileName As String, rootDirectory As String) As String
        ' Recursively search through all directories
        For Each directoryPath As String In Directory.GetDirectories(rootDirectory)
            Dim filePath As String = Path.Combine(directoryPath, fileName)
            If File.Exists(filePath) Then
                Return filePath ' File with matching name found in current directory
            End If
            Dim subDirectoryFile As String = FindFileInDirectories(fileName, directoryPath)
            If Not String.IsNullOrEmpty(subDirectoryFile) Then
                Return subDirectoryFile ' File with matching name found in subdirectory
            End If
        Next

        Return "" ' No file with matching name found in any directory
    End Function

    Public Function ReadFileLine(ByVal filePath As String, ByVal lineNumber As Integer) As String
        ' Check if the file exists
        If File.Exists(filePath) Then
            Try
                ' Read the specified line from the file
                Using reader As New StreamReader(filePath)
                    Dim currentLineNumber As Integer = 1
                    Dim line As String = ""
                    While currentLineNumber <= lineNumber AndAlso Not reader.EndOfStream
                        line = reader.ReadLine()
                        currentLineNumber += 1
                    End While
                    Return line
                End Using
            Catch ex As Exception
                ' Handle any errors that may occur while reading the file
                MessageBox.Show($"Error reading file: {ex.Message}", "File Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ""
            End Try
        Else
            MessageBox.Show($"File '{filePath}' does not exist.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End If
    End Function
End Class