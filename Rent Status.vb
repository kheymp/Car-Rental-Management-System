Imports System.IO

Public Class frmRentStatus
    Public strName As String
    Public strBirthDate As Date
    Public age As Integer
    Public strGender As String
    Public strAddress As String
    Public intRemaining As Integer
    Public dblTotalPrice As Double
    Public startDate As DateTime
    Public dblDailyRate As Double
    Public record As String
    Public endDate As DateTime

    Public strCarID As String = ""
    Public tempFilePath As String = ""

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        tempFilePath = FindFileInDirectories(txtCarID.Text + ".txt", "Customers\")
        'MsgBox(tempFilePath)
        If txtCarID.Text = "" Then
            MsgBox("Enter proper ID.")
        ElseIf File.Exists(tempFilePath) = False Then
            MsgBox("Customer ID not found.")
        ElseIf ReadFileLine(tempFilePath, 8) = "Days" Then
            MessageBox.Show("Not found.")
        Else
            strCarID = ReadFileLine(tempFilePath, 1)
            dblDailyRate = Double.Parse(ReadFileLine("Vehicles\" + strCarID + ".txt", 7))
            strName = ReadFileLine(tempFilePath, 3)
            strBirthDate = Date.Parse(ReadFileLine(tempFilePath, 4))
            age = ReadFileLine(tempFilePath, 5)
            strGender = ReadFileLine(tempFilePath, 6)
            strAddress = ReadFileLine(tempFilePath, 7)
            intRemaining = Integer.Parse(ReadFileLine(tempFilePath, 8))
            dblTotalPrice = Double.Parse(ReadFileLine(tempFilePath, 9))
            startDate = ReadFileLine(tempFilePath, 10)
            endDate = ReadFileLine(tempFilePath, 11)
            record = ReadFileLine("Records\" + strName + ".txt", 2)

            frmModify.originalRemain = intRemaining
            frmModify.previousValue = frmModify.originalRemain
            frmModify.endDate = endDate
            frmModify.newEndDate = frmModify.endDate
            frmModify.addPrice = 0
            frmModify.txtNewPrice.Text = frmModify.addPrice
            frmModify.newTotalPrice = 0
            frmModify.txtNewPrice.Text = "---"
            SetInfo()
        End If
    End Sub

    Public Sub UpdateBillingDataGridView()
        frmModify.bookedRanges.Clear()
        'Billing.picVehicle.Image = picVehicle.Image

        For Each filePath In Directory.GetFiles("Customers\" + strCarID + "\", "*.txt")
            'MsgBox(filePath + " this")
            If filePath = "Customers\" + strCarID + "\" + strName + strCarID + ".txt" Then

            Else
                Dim tempStartDate As DateTime = DateTime.Parse(ReadFileLine(filePath, 10))
                Dim tempEndDate As DateTime = DateTime.Parse(ReadFileLine(filePath, 11))

                frmModify.bookedRanges.Add(Tuple.Create(tempStartDate, tempEndDate))
                PopulateBillingDataGridView(frmModify.bookedRanges)
            End If

        Next
    End Sub

    Public Sub PopulateBillingDataGridView(dateRanges As List(Of Tuple(Of DateTime, DateTime)))
        ' Clear existing rows
        frmModify.txtUnavailableDates.Rows.Clear()
        dateRanges.Sort(Function(x, y) x.Item1.CompareTo(y.Item1))
        ' Add new rows for each date range
        For Each range In dateRanges
            frmModify.txtUnavailableDates.Rows.Add(range.Item1.ToString("yyyy-MM-dd"), range.Item2.ToString("yyyy-MM-dd"))
        Next
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If strCarID = "" Then
            MsgBox("Please enter a valid customer ID.")
        Else
            DeleteRent()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If strCarID = "" Then
            MsgBox("Please enter a valid customer ID.")
        Else
            'MsgBox("Executed Modify Button")\
            frmModify.originalPrice = Double.Parse(ReadFileLine(tempFilePath, 9))
            frmModify.originalRemain = Integer.Parse(ReadFileLine(tempFilePath, 8))
            frmModify.dailyRate = Double.Parse(ReadFileLine("Vehicles\" + strCarID + ".txt", 7))
            frmModify.txtOriginalPrice.Text = Double.Parse(ReadFileLine(tempFilePath, 9))
            frmModify.txtDailyRate.Text = Double.Parse(ReadFileLine("Vehicles\" + strCarID + ".txt", 7))
            frmModify.strCarId = strCarID
            frmModify.startDate = ReadFileLine(tempFilePath, 10)
            frmModify.endDate = ReadFileLine(tempFilePath, 11)
            frmModify.newEndDate = ReadFileLine(tempFilePath, 11)
            frmModify.txtNewPrice.Text = "---"
            frmModify.previousValue = Integer.Parse(ReadFileLine(tempFilePath, 8))
            frmModify.txtOriginalStart.Text = frmModify.startDate.ToString("dd/MM/yyyy")
            frmModify.txtOriginalEnd.Text = frmModify.endDate.ToString("dd/MM/yyyy")
            RemoveHandler frmModify.txtNewStart.ValueChanged, AddressOf frmModify.txtNewStart_ValueChanged
            RemoveHandler frmModify.txtNewEnd.ValueChanged, AddressOf frmModify.txtNewEnd_ValueChanged
            frmModify.txtNewStart.Value = frmModify.startDate
            frmModify.txtNewEnd.Value = frmModify.endDate
            AddHandler frmModify.txtNewStart.ValueChanged, AddressOf frmModify.txtNewStart_ValueChanged
            AddHandler frmModify.txtNewEnd.ValueChanged, AddressOf frmModify.txtNewEnd_ValueChanged
            'frmModify.txtNewEnd.Value = frmModify.endDate
            UpdateBillingDataGridView()
            frmModify.ShowDialog()
        End If
    End Sub

    Public Sub SetInfo()
        txtName.Text = strName
        txtBirthDate.Text = strBirthDate.Date
        txtAge.Text = age.ToString
        txtGender.Text = strGender
        txtAddress.Text = strAddress
        txtRemaining.Text = intRemaining.ToString
        txtTotalPrice.Text = dblTotalPrice.ToString
        txtStartDate.Text = startDate.ToString("dd/MM/yyyy")
        txtEndDate.Text = endDate.ToString("dd/MM/yyyy")
        picProfile.Image = Image.FromFile("Records\" + strName + ".jpg")
        picVehicle.Image = Image.FromFile("Pictures\" + strCarID + ".jpg")
        If record = "Good" Then
            txtRecord.Text = record
            txtRecord.ForeColor = Color.DarkGreen
            pnlRecord.BackColor = Color.DarkGreen
        ElseIf record = "Bad" Then
            txtRecord.Text = record
            txtRecord.ForeColor = Color.Red
            pnlRecord.BackColor = Color.Red
        End If
        txtRecord.Text = record
        'SetPicture(ReadFileLine("Vehicles\" + strCarID + ".txt", 4))
    End Sub

    Public Sub SetPicture(ByVal carType As String)
        If carType = "Sedan" Then
            picVehicle.Image = Image.FromFile("Pictures\sedan-img.jpg")
        ElseIf carType = "SUV" Then
            picVehicle.Image = Image.FromFile("Pictures\suv-img.jpg")
        ElseIf carType = "Truck" Then
            picVehicle.Image = Image.FromFile("Pictures\truck-img.jpg")
        ElseIf carType = "Off-Road" Then
            picVehicle.Image = Image.FromFile("Pictures\offroad-img.jpg")
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
                MessageBox.Show($"Error reading file: {ex.Message}", "File Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Public Sub ClearRentStatus()
        strCarID = ""
        picProfile.Image = Nothing
        picVehicle.Image = Nothing
        txtCarID.Text = ""
        txtName.Text = ""
        txtBirthDate.Text = ""
        txtAge.Text = ""
        txtGender.Text = ""
        txtAddress.Text = ""
        txtRemaining.Text = ""
        txtTotalPrice.Text = ""
        txtEndDate.Text = ""
        txtStartDate.Text = ""
        txtRecord.Text = ""
        pnlRecord.BackColor = Color.DarkGray
    End Sub
    Public result As DialogResult = DialogResult.No
    Public Sub DeleteRent()
        result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ClearRentStatus()
            frmModify.Close()
            File.Delete("Customers\" + strCarID + "\" + strName + strCarID + ".jpg")
            File.Delete(tempFilePath)
            MsgBox("Successfully deleted.")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        frmQRCamera.ShowDialog()
    End Sub

End Class