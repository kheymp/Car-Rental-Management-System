Imports System.IO
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Security.Cryptography.X509Certificates
Imports System.Threading
Imports System.Xml

Public Class frmMain
    Sub setPanel(ByVal panel As Form)
        pnlMain.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        pnlMain.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnAddVehicle_Click(sender As Object, e As EventArgs) Handles btnAddVehicle.Click
        setPanel(frmAddVehicle)
        Billing.ClearBilling()
    End Sub

    Private Sub btnBookCar_Click(sender As Object, e As EventArgs) Handles btnBookCar.Click
        frmBook.SetInfo()
        setPanel(frmBook)
        Billing.EnableBillingFields()
        Billing.ClearBilling()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        setPanel(frmRentStatus)
        frmRentStatus.ClearRentStatus()
        Billing.ClearBilling()
    End Sub
    ' --- Animation Methods ---
    Private Const MovementSpeed As Integer = 5
    Private Enum Direction
        Left
        Right
    End Enum

    Private currentDirection As Direction = Direction.Right

    Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer.Tick
        If currentDirection = Direction.Right Then
            ' Move label to the right
            Label1.Left += MovementSpeed
            Label4.Left += MovementSpeed

            ' Check if label reaches the form's right edge
            If Label1.Right >= Me.ClientSize.Width - Label4.Width Then
                ' Change direction to left
                currentDirection = Direction.Left
            End If

            If Label4.Right >= Me.ClientSize.Width Then
                ' Change direction to left
                currentDirection = Direction.Left
            End If
        Else
            ' Move label to the left
            Label1.Left -= MovementSpeed
            Label4.Left -= MovementSpeed

            ' Check if label reaches the form's left edge
            If Label1.Left <= 0 Then
                ' Change direction to right
                currentDirection = Direction.Right
            End If

            If Label4.Left <= 0 + Label1.Width Then
                ' Change direction to right
                currentDirection = Direction.Right
            End If
        End If
    End Sub

    '--- End of Animation Methods (Erase if Not Working) ---
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        animationTimer.Interval = 50 ' Adjust the interval for desired speed
        animationTimer.Start()
        RefreshFiles("Customers\")
        RefreshFiles("Customers\")
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

    Private Sub btnRefreshPage_Click(sender As Object, e As EventArgs) Handles btnRefreshPage.Click
        RefreshFiles("Customers\")
        RefreshFiles("Customers\")
    End Sub

    Public Sub RefreshFiles(rootDirectory As String)
        Dim files As String() = Directory.GetFiles(rootDirectory, "*.txt", SearchOption.AllDirectories)
        For Each file As String In files
            Dim carID As String = ReadFileLine(file, 1)
            Dim dailyCost As Double = Double.Parse(ReadFileLine("Vehicles\" + carID + ".txt", 7))
            Dim remainingDay As Integer = Integer.Parse(ReadFileLine(file, 8))
            Dim totalCost As Double = Double.Parse(ReadFileLine(file, 9))
            Dim startDate As DateTime = ReadFileLine(file, 10)
            Dim endDate As DateTime = ReadFileLine(file, 11)
            Dim name As String = ReadFileLine(file, 3)
            Dim currentDate As DateTime = ReadFileLine(file, 12)

            If Date.Today > startDate Then
                remainingDay = DateDiff(DateInterval.Day, currentDate, endDate)
                totalCost = dailyCost * remainingDay
                currentDate = Date.Today
                'MessageBox.Show(remainingDay)
                'MessageBox.Show(totalCost)
                ModifyLineInFile(file, 7, remainingDay)
                ModifyLineInFile(file, 8, totalCost)
                ModifyLineInFile(file, 11, currentDate)

                If frmRentStatus.txtCarID.Text = "" Then
                Else
                    frmRentStatus.txtRemaining.Text = ReadFileLine(file, 8)
                    frmRentStatus.txtTotalPrice.Text = ReadFileLine(file, 9)
                End If

                If remainingDay <= 0 Then
                    frmRentStatus.ClearRentStatus()
                    frmModify.Close()
                    System.IO.File.Delete("Customers\" + carID + "\" + name + carID + ".jpg")
                    System.IO.File.Delete(file)
                End If

                frmAllRents.UpdateViewStatus()
            End If


        Next
    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        setPanel(frmAllRents)
        frmAllRents.UpdateViewStatus()
        Billing.ClearBilling()
    End Sub
End Class
