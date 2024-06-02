Imports MessagingToolkit.QRCode.Codec
Imports QRCoder

Public Class frmGeneratedQR
    Private Sub Generated_QR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Public Sub GenerateNewQR(ByVal carID As String)
        Dim enco As QRCodeEncoder = New QRCodeEncoder
        Dim qrImage As Bitmap = enco.Encode(carID)
        picQRCode.Image = qrImage
    End Sub
End Class