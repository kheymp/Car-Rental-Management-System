Imports System.ComponentModel
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.InteropServices

Public Class frmModify
    Public originalPrice As Double
    Public originalRemain As Integer
    Public addPrice As Double = 0
    Public newRemain As Integer
    Public dailyRate As Double
    Public change As Double
    Public cash As Double
    Public strCarId As String
    Public startDate As DateTime
    Public endDate As DateTime
    Public newEndDate As DateTime = endDate
    Public newStartDate As DateTime
    Public previousValue As Integer
    Public newTotalPrice As Double
    Public bookedRanges As New List(Of Tuple(Of DateTime, DateTime))
    Public Sub New()
        InitializeComponent()

    End Sub

    'Private Sub txtModifyDay_ValueChanged(sender As Object, e As EventArgs) Handles 'txtModifyDay.ValueChanged
    'MsgBox(txtModifyDay.Value)
    'MsgBox(previousValue)
    'newRemain = txtModifyDay.Value

    'If newRemain < originalRemain Then
    '         newTotalPrice = originalPrice + addPrice
    '        newTotalPrice = Math.Round(newTotalPrice, 2)
    '       txtNewPrice.Text = "---"
    '      txtBilling.Text = "No need."
    '      txtBilling.BackColor = Color.SpringGreen
    '      txtBilling.ReadOnly = True
    ' ElseIf newRemain > originalRemain Then
    '        newTotalPrice = originalPrice + addPrice
    '       txtBilling.Text = ""
    '      txtBilling.BackColor = Color.White
    '     txtBilling.ReadOnly = False
    '    newTotalPrice = originalPrice + addPrice
    '   newTotalPrice = Math.Round(newTotalPrice, 2)
    ' ElseIf newRemain = originalRemain Then
    '        txtNewPrice.Text = "---"
    'End If

    'If newRemain = 0 Then
    '       frmRentStatus.DeleteRent()
    'End If
    'End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Dim tempStartDate As DateTime = txtNewStart.Value
        Dim tempEndDate As DateTime = txtNewEnd.Value
        Dim tempIsAvailable As Boolean = IsDateRangeAvailable(tempStartDate, tempEndDate)
        'MsgBox(tempIsAvailable)


        If newTotalPrice = 0 Then
            MessageBox.Show("No changes made.")
            Me.Close()
            ClearBilling()
        ElseIf originalPrice > newTotalPrice Then
            'MsgBox("Reached here")
            If txtNewStart.Value < Date.Today Then
                MessageBox.Show("Invalid time selected.")
                Exit Sub
            ElseIf txtNewEnd.Value < txtNewStart.Value Then
                MessageBox.Show("Invalid time selected.")
                Exit Sub
            ElseIf tempIsAvailable = False Then
                MessageBox.Show("This time slot is already booked.")
                Exit Sub
            End If

            change = addPrice * -1
            change = Math.Round(change, 2)
            MessageBox.Show("Change: " + change.ToString + vbNewLine +
                   "New Total: " + newTotalPrice.ToString + vbNewLine +
                   "New end date: " + newEndDate.ToString("dd/MM/yyyy"))

            ModifyLineInFile(frmRentStatus.tempFilePath, 7, newRemain)
            ModifyLineInFile(frmRentStatus.tempFilePath, 8, newTotalPrice)
            ModifyLineInFile(frmRentStatus.tempFilePath, 9, newStartDate)
            ModifyLineInFile(frmRentStatus.tempFilePath, 10, newEndDate)
            ModifyLineInFile(frmRentStatus.tempFilePath, 1, "Bad")
            ModifyLineInFile("Records\" + frmRentStatus.strName + ".txt", 1, "Bad")

            frmRentStatus.txtRemaining.Text = Integer.Parse(ReadFileLine(frmRentStatus.tempFilePath, 8))
            frmRentStatus.txtTotalPrice.Text = ReadFileLine(frmRentStatus.tempFilePath, 9)
            frmRentStatus.txtStartDate.Text = newStartDate.ToString("dd/MM/yyyy")
            frmRentStatus.txtEndDate.Text = newEndDate.ToString("dd/MM/yyyy")
            frmRentStatus.txtRecord.Text = ReadFileLine(frmRentStatus.tempFilePath, 2)
            frmRentStatus.txtRecord.ForeColor = Color.Red
            frmRentStatus.pnlRecord.BackColor = Color.Red

            addPrice = 0
            newTotalPrice = 0

            previousValue = Integer.Parse(Integer.Parse(ReadFileLine(frmRentStatus.tempFilePath, 8)))
            originalPrice = Double.Parse(ReadFileLine(frmRentStatus.tempFilePath, 9))
            endDate = ReadFileLine(frmRentStatus.tempFilePath, 11)
            txtUnavailableDates.Rows.Clear()
            ClearBilling()
            Me.Close()
        ElseIf originalPrice < newTotalPrice And addPrice <> 0 Then

            If txtNewStart.Value < Date.Today Then
                MessageBox.Show("Invalid time selected.")
                Exit Sub
            ElseIf txtNewEnd.Value < txtNewStart.Value Then
                MessageBox.Show("Invalid time selected.")
                Exit Sub
            ElseIf tempIsAvailable = False Then
                MessageBox.Show("This time slot is already booked.")
                Exit Sub
            End If

            If txtBilling.Text = "" Or IsNumeric(txtBilling.Text) = False Then
                MessageBox.Show("Enter valid number.")
            ElseIf Double.Parse(txtBilling.Text) < addPrice Then
                MessageBox.Show("Enter valid amount.")
            Else
                cash = Double.Parse(txtBilling.Text)
                change = cash - addPrice
                change = Math.Round(change, 2)
                MessageBox.Show("Change: " + change.ToString + vbNewLine +
                       "New Total: " + newTotalPrice.ToString + vbNewLine +
                       "New end date: " + newEndDate.ToString("dd/MM/yyyy"))

                ModifyLineInFile(frmRentStatus.tempFilePath, 7, newRemain)
                ModifyLineInFile(frmRentStatus.tempFilePath, 8, newTotalPrice)
                ModifyLineInFile(frmRentStatus.tempFilePath, 9, newStartDate)
                ModifyLineInFile(frmRentStatus.tempFilePath, 10, newEndDate)
                ModifyLineInFile(frmRentStatus.tempFilePath, 1, "Good")
                ModifyLineInFile("Records\" + frmRentStatus.strName + ".txt", 1, "Good")

                frmRentStatus.txtRemaining.Text = Integer.Parse(ReadFileLine(frmRentStatus.tempFilePath, 8))
                frmRentStatus.txtTotalPrice.Text = ReadFileLine(frmRentStatus.tempFilePath, 9)
                frmRentStatus.txtStartDate.Text = newStartDate.ToString("dd/MM/yyyy")
                frmRentStatus.txtEndDate.Text = newEndDate.ToString("dd/MM/yyyy")
                frmRentStatus.txtRecord.Text = ReadFileLine(frmRentStatus.tempFilePath, 2)
                frmRentStatus.txtRecord.ForeColor = Color.DarkGreen
                frmRentStatus.pnlRecord.BackColor = Color.DarkGreen

                addPrice = 0
                newTotalPrice = 0

                previousValue = Integer.Parse(Integer.Parse(ReadFileLine(frmRentStatus.tempFilePath, 8)))
                originalPrice = Double.Parse(ReadFileLine(frmRentStatus.tempFilePath, 9))
                endDate = ReadFileLine(frmRentStatus.tempFilePath, 11)
                txtUnavailableDates.Rows.Clear()
                ClearBilling()
                Me.Close()
            End If
        Else
            ClearBilling()
            txtUnavailableDates.Rows.Clear()
            Me.Close()
        End If
    End Sub

    Public Sub txtNewStart_ValueChanged(sender As Object, e As EventArgs) Handles txtNewStart.ValueChanged
        If txtNewStart.Value < Date.Today Then
            MessageBox.Show("Invalid time selected.")
        ElseIf txtNewEnd.Value <= txtNewStart.Value Then
            MessageBox.Show("Invalid time selected.")
        Else
            newRemain = DateDiff(DateInterval.Day, txtNewStart.Value, txtNewEnd.Value)
            'MessageBox.Show(newRemain)
            'MessageBox.Show(originalRemain)
            If newRemain < originalRemain Then
                addPrice = dailyRate * (newRemain - originalRemain)
                newTotalPrice = originalPrice + addPrice
                newTotalPrice = Math.Round(newTotalPrice, 2)
                newStartDate = txtNewStart.Value
                newEndDate = txtNewEnd.Value
                txtNewPrice.Text = "---"
                txtBilling.Text = "No need."
                txtBilling.BackColor = Color.SpringGreen
                txtBilling.ReadOnly = True
            ElseIf newRemain > originalRemain Then
                addPrice = dailyRate * (newRemain - originalRemain)
                txtNewPrice.Text = addPrice.ToString
                newTotalPrice = originalPrice + addPrice
                txtBilling.Text = ""
                txtBilling.BackColor = Color.White
                txtBilling.ReadOnly = False
                newTotalPrice = originalPrice + addPrice
                newTotalPrice = Math.Round(newTotalPrice, 2)
                newStartDate = txtNewStart.Value
                newEndDate = txtNewEnd.Value
            ElseIf newRemain = originalRemain Then
                newTotalPrice = 0
                newTotalPrice = Math.Round(newTotalPrice, 2)
                newStartDate = txtNewStart.Value
                newEndDate = txtNewEnd.Value
                txtNewPrice.Text = "---"
            ElseIf txtNewEnd.Value = endDate And txtNewStart.Value = startDate Then
                newTotalPrice = 0
                txtNewPrice.Text = "---"
            End If

            If newRemain = 0 Then
                frmRentStatus.DeleteRent()
            End If
        End If
    End Sub

    Public Sub txtNewEnd_ValueChanged(sender As Object, e As EventArgs) Handles txtNewEnd.ValueChanged
        If txtNewStart.Value < Date.Today Then
            MessageBox.Show("Invalid time selected.")
        ElseIf txtNewEnd.Value <= txtNewStart.Value Then
            MessageBox.Show("Invalid time selected.")
        Else
            newRemain = DateDiff(DateInterval.Day, txtNewStart.Value, txtNewEnd.Value)
            'MessageBox.Show(newRemain)
            'MessageBox.Show(originalRemain)
            If newRemain < originalRemain Then
                addPrice = dailyRate * (newRemain - originalRemain)
                newTotalPrice = originalPrice + addPrice
                newTotalPrice = Math.Round(newTotalPrice, 2)
                newStartDate = txtNewStart.Value
                newEndDate = txtNewEnd.Value
                txtNewPrice.Text = "---"
                txtBilling.Text = "No need."
                txtBilling.BackColor = Color.SpringGreen
                txtBilling.ReadOnly = True
            ElseIf newRemain > originalRemain Then
                addPrice = dailyRate * (newRemain - originalRemain)
                txtNewPrice.Text = addPrice.ToString
                newTotalPrice = originalPrice + addPrice
                txtBilling.Text = ""
                txtBilling.BackColor = Color.White
                txtBilling.ReadOnly = False
                newTotalPrice = originalPrice + addPrice
                newTotalPrice = Math.Round(newTotalPrice, 2)
                newStartDate = txtNewStart.Value
                newEndDate = txtNewEnd.Value
            ElseIf newRemain = originalRemain Then
                newTotalPrice = 0
                newTotalPrice = Math.Round(newTotalPrice, 2)
                newStartDate = txtNewStart.Value
                newEndDate = txtNewEnd.Value
                txtNewPrice.Text = "---"
            ElseIf txtNewEnd.Value = endDate And txtNewStart.Value = startDate Then
                newTotalPrice = 0
                txtNewPrice.Text = "---"
            End If

            If newRemain = 0 Then
                frmRentStatus.DeleteRent()
            End If
        End If
    End Sub

    Private Sub ClearBilling()
        txtBilling.BackColor = Color.SpringGreen
        txtBilling.ReadOnly = True
        txtBilling.Text = "No need."
    End Sub

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

    Private Function IsDateRangeAvailable(startDate As DateTime, endDate As DateTime) As Boolean

        For Each range In bookedRanges
            ' Check for overlap
            'MsgBox(range.Item1.Date)
            If startDate.Date < range.Item2.Date AndAlso endDate.Date >= range.Item1.Date Then

                Return False
            End If


        Next
        Return True
    End Function

    Private Sub frmModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class