Imports System.IO
Imports System.Net.Security

Public Class Billing
    Dim strName As String
    Dim strBirthDate As Date
    Dim strSex As String
    Dim strAddress As String
    Dim age As Integer
    Dim intDays As Integer
    Dim intCash As Integer
    Dim strCarID As String
    Dim totalPrice As Double
    Dim startDate As DateTime
    Dim endDate As DateTime
    Dim tempStartDate As DateTime
    Dim tempEndDate As DateTime
    Dim record As String
    Dim alreadySet As Boolean
    Public bookedRanges As New List(Of Tuple(Of DateTime, DateTime))

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

        strBirthDate = txtBirthDate.Value
        Dim currentDate = Date.Today
        age = currentDate.Year - strBirthDate.Year

        If txtName.Text = "" Then

        Else
            If File.Exists("Customers\" + txtCarID.Text + "\" + txtName.Text + txtCarID.Text + ".txt") Then
                MessageBox.Show(txtName.Text + " already rented the vehicle.")
                Exit Sub
            ElseIf File.Exists("Records\" + txtName.Text + ".txt") And alreadySet = False Then
                record = ReadFileLine("Records\" + txtName.Text + ".txt", 2)
                MessageBox.Show(txtName.Text + " already a previous customer.")
                txtName.Text = ReadFileLine("Records\" + txtName.Text + ".txt", 1)
                txtBirthDate.Value = ReadFileLine("Records\" + txtName.Text + ".txt", 3)
                txtSex.Text = ReadFileLine("Records\" + txtName.Text + ".txt", 5)
                txtAddress.Text = ReadFileLine("Records\" + txtName.Text + ".txt", 6)
                picProfile.Image = Image.FromFile("Records\" + txtName.Text + ".jpg")
                alreadySet = True
                DisableBillingFields()
                Exit Sub
            ElseIf frmBook.txtStatus.Text = "Premium" And record = "Bad" Then
                MsgBox("You can't rent a premium vehicle because of a bad record.")
                Exit Sub
            Else

            End If

        End If




        If txtName.Text = "" Or txtSex.Text = "" Or txtAddress.Text = "" Or txtCash.Text = "" Then
            MsgBox("Answer all fields.")
            Exit Sub
        ElseIf IsNumeric(txtCash.Text) = False Then
            MsgBox("Enter proper cash.")
            Exit Sub
        ElseIf age < 18 Then
            MsgBox("You are a minor. Please contact your guardians.")
            Exit Sub
        ElseIf IsNumeric(txtTotalPrice.Text) = False Then
            MsgBox("Select proper date.")
            Exit Sub
        ElseIf Double.Parse(txtCash.Text) < Double.Parse(txtTotalPrice.Text) Then
            MsgBox("Enter valid amount.")
            Exit Sub
        ElseIf frmBook.txtStatus.Text = "Premium" And record = "Bad" Then
            MsgBox("You can't rent a premium vehicle because of a bad record.")
            Exit Sub
        ElseIf picProfile.Image Is Nothing Then
            MsgBox("Take a picture first.")
            Exit Sub
        Else
            Dim tempIsAvailable As Boolean = IsDateRangeAvailable(tempStartDate, tempEndDate)

            If tempStartDate < DateTime.Today Then
                MessageBox.Show("Invalid start time selected")
                Exit Sub
            ElseIf tempStartDate > tempEndDate Then
                MessageBox.Show("Invalid end time selected")
                Exit Sub
            ElseIf tempIsAvailable = False Then
                MessageBox.Show("Date selected is already booked. Please choose another one.")
                Exit Sub
            ElseIf tempIsAvailable = True Then
                startDate = tempStartDate
                endDate = tempEndDate
                Dim tempTimeSpan As TimeSpan = endDate.AddDays(1) - startDate
                intDays = tempTimeSpan.Days
            End If
            Dim outputFile As StreamWriter = File.CreateText(("Customers\" + txtCarID.Text + "\" + txtName.Text + txtCarID.Text + ".txt"))


            If alreadySet = True Then
                record = ReadFileLine("Records\" + txtName.Text + ".txt", 2)
            Else
                record = "Good"
            End If

            outputFile.WriteLine("Car ID")
            outputFile.WriteLine("Good")
            outputFile.WriteLine("Name")
            outputFile.WriteLine("Birthdate")
            outputFile.WriteLine("Age")
            outputFile.WriteLine("Sex")
            outputFile.WriteLine("Address")
            outputFile.WriteLine("Days")
            outputFile.WriteLine("Total")
            outputFile.WriteLine("Start Date")
            outputFile.WriteLine("End Date")
            outputFile.WriteLine("Current Date")
            outputFile.Close()

            If alreadySet = False Then
                Dim outputFileRecord As StreamWriter = File.CreateText(("Records\" + txtName.Text + ".txt"))
                outputFileRecord.WriteLine("Name")
                outputFileRecord.WriteLine("Good")
                outputFileRecord.WriteLine("Birthdate")
                outputFileRecord.WriteLine("Age")
                outputFileRecord.WriteLine("Sex")
                outputFileRecord.WriteLine("Address")
                outputFileRecord.Close()
            End If

            strName = txtName.Text
            strBirthDate = txtBirthDate.Value
            strSex = txtSex.Text
            strAddress = txtAddress.Text
            'intDays = txtDays.Value
            strCarID = txtCarID.Text
            tempStartDate = txtStartDate.Value
            tempEndDate = txtEndDate.Value



            ModifyLineInFile("Customers\" + txtCarID.Text + "\" + txtName.Text + txtCarID.Text + ".txt", 0, strCarID)
            ModifyLineInFile("Customers\" + txtCarID.Text + "\" + txtName.Text + txtCarID.Text + ".txt", 1, record)
            ModifyLineInFile("Customers\" + txtCarID.Text + "\" + txtName.Text + txtCarID.Text + ".txt", 2, strName)
            ModifyLineInFile("Customers\" + txtCarID.Text + "\" + txtName.Text + txtCarID.Text + ".txt", 3, strBirthDate.ToString)
            ModifyLineInFile("Customers\" + txtCarID.Text + "\" + txtName.Text + txtCarID.Text + ".txt", 4, age.ToString)
            ModifyLineInFile("Customers\" + txtCarID.Text + "\" + txtName.Text + txtCarID.Text + ".txt", 5, strSex)
            ModifyLineInFile("Customers\" + txtCarID.Text + "\" + txtName.Text + txtCarID.Text + ".txt", 6, strAddress)
            ModifyLineInFile("Customers\" + txtCarID.Text + "\" + txtName.Text + txtCarID.Text + ".txt", 7, intDays)
            ModifyLineInFile("Customers\" + txtCarID.Text + "\" + txtName.Text + txtCarID.Text + ".txt", 8, totalPrice)
            ModifyLineInFile("Customers\" + txtCarID.Text + "\" + txtName.Text + txtCarID.Text + ".txt", 9, startDate)
            ModifyLineInFile("Customers\" + txtCarID.Text + "\" + txtName.Text + txtCarID.Text + ".txt", 10, endDate)
            ModifyLineInFile("Customers\" + txtCarID.Text + "\" + txtName.Text + txtCarID.Text + ".txt", 11, startDate)
            ModifyLineInFile("Customers\" + txtCarID.Text + "\" + txtName.Text + txtCarID.Text + ".txt", 1, record)

            'Modifying Customer Records

            ModifyLineInFile("Records\" + strName + ".txt", 0, strName)
            ModifyLineInFile("Records\" + strName + ".txt", 1, record)
            ModifyLineInFile("Records\" + strName + ".txt", 2, strBirthDate)
            ModifyLineInFile("Records\" + strName + ".txt", 3, age)
            ModifyLineInFile("Records\" + strName + ".txt", 4, strSex)
            ModifyLineInFile("Records\" + strName + ".txt", 5, strAddress)

            'picProfile.Image.Save("Customers\" + txtCarID.Text + "\" + txtName.Text + txtCarID.Text + ".jpg", Imaging.ImageFormat.Jpeg)
            If alreadySet = False Then
                picProfile.Image.Save("Records\" + txtName.Text + ".jpg", Imaging.ImageFormat.Jpeg)
            End If

            Dim change As Double = Double.Parse(txtCash.Text) - totalPrice
            change = Math.Round(change, 2)
            MessageBox.Show("Change: " + change.ToString)
            MessageBox.Show("Start date: " + startDate.ToString("dd/MM/yyyy") + vbNewLine +
                            "End date: " + endDate.ToString("dd/MM/yyyy") + vbNewLine +
                            "Total days: " + intDays.ToString)
            MessageBox.Show("Successfully rented vehicle!")
            MessageBox.Show("Your customer ID is: " + strName + strCarID)
            frmGeneratedQR.GenerateNewQR(strName + strCarID)
            frmGeneratedQR.ShowDialog()
            frmBook.UpdateBillingDataGridView()
            EnableBillingFields()

            txtName.Text = ""
            txtAddress.Text = ""
            txtCash.Text = ""
            txtTotalPrice.Text = ""
            picProfile.Image = Nothing
        End If
    End Sub

    Public Sub DisableBillingFields()
        'MsgBox("Hello")
        txtName.ReadOnly = True
        txtBirthDate.Enabled = False
        txtSex.Enabled = False
        txtAddress.ReadOnly = True
        btnTakePic.Enabled = False
    End Sub

    Public Sub EnableBillingFields()
        txtName.ReadOnly = False
        txtBirthDate.Enabled = True
        txtSex.Enabled = True
        txtAddress.ReadOnly = False
        btnTakePic.Enabled = True
        alreadySet = False
    End Sub

    Private Sub txtStartDate_ValueChanged(sender As Object, e As EventArgs) Handles txtStartDate.ValueChanged
        UpdateTotalPrice()
    End Sub

    Private Sub txtEndDate_ValueChanged(sender As Object, e As EventArgs) Handles txtEndDate.ValueChanged
        UpdateTotalPrice()
    End Sub

    Private Function IsDateRangeAvailable(startDate As DateTime, endDate As DateTime) As Boolean
        For Each range In bookedRanges
            ' Check for overlap
            If startDate.Date < range.Item2.Date AndAlso endDate.Date >= range.Item1.Date Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function UpdateTotalPrice()
        tempStartDate = txtStartDate.Value
        tempEndDate = txtEndDate.Value
        Dim tempTimeSpan As TimeSpan = (tempEndDate.AddDays(1) - tempStartDate)
        'MsgBox(tempTimeSpan.Days)
        If tempStartDate < Date.Today Then
            txtTotalPrice.Text = ""
            MessageBox.Show("Invalid start date.")
        ElseIf tempStartDate > tempEndDate Then
            txtTotalPrice.Text = ""
            MessageBox.Show("Invalid start date.")
        ElseIf tempEndDate < tempStartDate Then
            txtTotalPrice.Text = ""
            MessageBox.Show("Invalid end date.")
        ElseIf tempStartDate = tempEndDate Then
            txtTotalPrice.Text = ""
            MessageBox.Show("Invalid duration.")
        Else
            totalPrice = Integer.Parse(txtDailyPrice.Text) * tempTimeSpan.Days
            txtTotalPrice.Text = totalPrice.ToString
        End If
    End Function


    Private Sub ModifyLineInFile(ByVal filePath As String, ByVal lineNumber As Integer, ByVal newContent As String)
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

    Private Sub btnTakePic_Click(sender As Object, e As EventArgs) Handles btnTakePic.Click

        frmCamera.ShowDialog()
    End Sub

    Public Sub ClearBilling()
        picProfile.Image = Nothing
        txtName.Text = ""
        txtAddress.Text = ""
        txtTotalPrice.Text = ""
        txtCash.Text = ""
        txtUnavailableDates.Rows.Clear()
    End Sub

    Private Sub btnAlready_Click(sender As Object, e As EventArgs) Handles btnAlready.Click
        alreadySet = False
        Dim tempName As String
        tempName = InputBox("Please enter your name:", "User Input")
        If File.Exists("Records\" + tempName + ".txt") And alreadySet = False Then
            record = ReadFileLine("Records\" + tempName + ".txt", 2)
            MessageBox.Show(tempName + " already a previous customer.")
            txtName.Text = ReadFileLine("Records\" + tempName + ".txt", 1)
            txtBirthDate.Value = ReadFileLine("Records\" + tempName + ".txt", 3)
            txtSex.Text = ReadFileLine("Records\" + tempName + ".txt", 5)
            txtAddress.Text = ReadFileLine("Records\" + tempName + ".txt", 6)
            picProfile.Image = Image.FromFile("Records\" + tempName + ".jpg")
            alreadySet = True

            DisableBillingFields()
            Exit Sub
        Else
            MessageBox.Show("You are not a previous customer.")
        End If
    End Sub
End Class