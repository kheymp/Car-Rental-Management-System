Imports System.IO
Imports System.Security.Cryptography.X509Certificates

Public Class frmAddVehicle
    Dim strCarID As String
    Dim strPlateNo As String
    Dim strColor As String
    Dim strType As String
    Dim intCarCapacity As String
    Dim strBodyNo As String
    Dim intDailyPrice As Double
    Dim strIsPremium As String
    Dim intReferenceID As Integer
    Private Sub btnAddVehicle_Click(sender As Object, e As EventArgs) Handles btnSubmitVehicle.Click
        If txtPlateNo.Text = "" Or txtColor.Text = "" Or txtCarType.Text = "" Or txtCarCapacity.Value = 0 Or txtBodyNo.Text = "" Or txtDailyPrice.Text = "" Or IsNumeric(txtDailyPrice.Text) = False Then
            MessageBox.Show("Please answer all required values or enter proper values.")
        ElseIf picVehicle.Image Is Nothing Then
            MessageBox.Show("Upload proper image.")
        Else
            intReferenceID = Integer.Parse(ReadFileLine("Reference\Reference.txt", 1))
            ModifyLineInFile("Reference/Reference.txt", 0, intReferenceID + 1)

            strCarID = intReferenceID
            strPlateNo = txtPlateNo.Text
            strColor = txtColor.Text
            strType = txtCarType.Text
            intCarCapacity = txtCarCapacity.Value
            strBodyNo = txtBodyNo.Text
            intDailyPrice = txtDailyPrice.Text

            If intDailyPrice > 10000 Then
                strIsPremium = "Premium"
            Else
                strIsPremium = "Not Premium"
            End If

            Dim outputFile As StreamWriter = File.CreateText("Vehicles\" + strCarID + ".txt")
            'File.CreateText("Rents\" + strCarID + "rents" + ".txt")
            Directory.CreateDirectory("Customers\" + strCarID)
            outputFile.WriteLine(strCarID)
            outputFile.WriteLine(strPlateNo)
            outputFile.WriteLine(strColor)
            outputFile.WriteLine(strType)
            outputFile.WriteLine(intCarCapacity.ToString)
            outputFile.WriteLine(strBodyNo)
            outputFile.WriteLine(intDailyPrice.ToString)
            outputFile.WriteLine(strIsPremium)
            outputFile.WriteLine("Available")
            outputFile.WriteLine("Name")
            outputFile.WriteLine("Birthdate")
            outputFile.WriteLine("Age")
            outputFile.WriteLine("Sex")
            outputFile.WriteLine("Address")
            outputFile.WriteLine("Days")
            outputFile.WriteLine("Total")
            outputFile.WriteLine("Start Date")
            outputFile.WriteLine("End Date")
            outputFile.Close()

            picVehicle.Image.Save("Pictures\" + strCarID + ".jpg", Imaging.ImageFormat.Jpeg)

            MessageBox.Show("Successfully added vehicle!")

            txtPlateNo.Text = ""
            txtColor.Text = ""
            txtCarCapacity.Value = 0
            txtBodyNo.Text = ""
            txtDailyPrice.Text = ""

            frmBook.InsertValue(strCarID + ".txt")
        End If
    End Sub

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
                MessageBox.Show($"ThenError reading file: {ex.Message}", "File Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ""
            End Try
        Else
            MessageBox.Show($"File '{filePath}' does not exist.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End If
    End Function

    Public Sub ModifyLineInFile(ByVal filePath As String, ByVal lineNumber As Integer, ByVal newContent As String)
        Try
            ' Read all lines from the file
            Dim lines() As String = File.ReadAllLines(filePath)

            ' Check if the specified line number is within the range of lines
            If lineNumber >= 0 AndAlso lineNumber < lines.Length Then
                ' Modify the content of the specified line
                lines(lineNumber) = newContent

                ' Write the modified content back to the file
                File.WriteAllLines(filePath, lines)
            Else
                MessageBox.Show($"Line number {lineNumber} is out of range.", "Line Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Handle any errors that may occur while reading or writing to the file
            MessageBox.Show($"Error modifying line in file: {ex.Message}", "File Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set the filter to show only image files
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        ' Set the title of the dialog
        openFileDialog.Title = "Select an Image File"

        ' Show the dialog and check if the user selected a file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            Dim selectedFilePath As String = openFileDialog.FileName

            ' Load the selected image into the PictureBox
            picVehicle.Image = Image.FromFile(selectedFilePath)
        End If
    End Sub

End Class