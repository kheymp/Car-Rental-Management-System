Imports System.IO

Public Class frmBook
    Dim folderPath As String = "Vehicles\"
    Dim vehicles() As String
    Dim indexCar As Integer = 0
    Public Sub New()
        InitializeComponent()
        If Directory.Exists(folderPath) Then
            ' Get all files in the folder
            Dim files() As String = Directory.GetFiles(folderPath)

            ' Display the file names
            For Each fileName As String In files
                InsertValue(Path.GetFileName(fileName))
            Next
        Else
            MessageBox.Show($"Folder '{folderPath}' does not exist.", "Folder Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub frmBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetInfo()
    End Sub

    Public Sub InsertValue(ByVal newValue As String)
        ' Check if the dynamic array is initialized
        If vehicles Is Nothing Then
            ' If not initialized, initialize the dynamic array with the first element
            ReDim vehicles(0)
            vehicles(0) = newValue
        Else
            ' If initialized, resize the array to accommodate the new element
            ReDim Preserve vehicles(vehicles.Length)
            ' Insert the new value at the end of the array
            vehicles(vehicles.Length - 1) = newValue
        End If
    End Sub

    Public Function GetValue(ByVal index As Integer) As String
        ' Check if the dynamic array is initialized and the index is valid
        If vehicles IsNot Nothing AndAlso index >= 0 AndAlso index < vehicles.Length Then
            ' Return the value at the specified index
            Return vehicles(index)
        Else
            ' If the array is not initialized or the index is out of bounds, return a default value (empty string in this case)
            Return ""
        End If
    End Function

    Public Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If IsFolderNotEmpty("Vehicles\") Then
            If indexCar = 0 Then
                indexCar = 0
            Else
                indexCar -= 1
                SetInfo()
            End If
        End If
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsFolderNotEmpty("Vehicles\") Then
            If indexCar = vehicles.Length - 1 Then
                indexCar = vehicles.Length - 1
            Else
                indexCar += 1
                SetInfo()
            End If
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

    Public Sub SetInfo()
        If IsFolderNotEmpty("Vehicles\") Then

            txtCarID.Text = ReadFileLine("Vehicles\" + vehicles(indexCar), 1)
            txtPlateNo.Text = ReadFileLine("Vehicles\" + vehicles(indexCar), 2)
            txtCarColor.Text = ReadFileLine("Vehicles\" + vehicles(indexCar), 3)
            txtType.Text = ReadFileLine("Vehicles\" + vehicles(indexCar), 4)
            txtCapacity.Text = ReadFileLine("Vehicles\" + vehicles(indexCar), 5)
            txtBodyNo.Text = ReadFileLine("Vehicles\" + vehicles(indexCar), 6)
            txtDailyPrice.Text = ReadFileLine("Vehicles\" + vehicles(indexCar), 7)
            txtStatus.Text = ReadFileLine("Vehicles\" + vehicles(indexCar), 8)
            picVehicle.Image = Image.FromFile("Pictures\" + txtCarID.Text + ".jpg")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Billing.txtCarID.Text = txtCarID.Text
        Billing.txtDailyPrice.Text = txtDailyPrice.Text
        UpdateBillingDataGridView()
        frmMain.setPanel(Billing)
    End Sub

    Public Sub UpdateBillingDataGridView()
        Billing.bookedRanges.Clear()
        'Billing.picVehicle.Image = picVehicle.Image

        For Each filePath In Directory.GetFiles("Customers\" + txtCarID.Text + "\", "*.txt")
            If ReadFileLine(filePath, 10) = "Start Date" Or ReadFileLine(filePath, 11) = "End Date" Then

            Else
                Dim tempStartDate As DateTime = DateTime.Parse(ReadFileLine(filePath, 10))
                Dim tempEndDate As DateTime = DateTime.Parse(ReadFileLine(filePath, 11))

                Billing.bookedRanges.Add(Tuple.Create(tempStartDate, tempEndDate))
                PopulateBillingDataGridView(Billing.bookedRanges)
            End If

        Next
    End Sub

    Public Sub PopulateBillingDataGridView(dateRanges As List(Of Tuple(Of DateTime, DateTime)))
        ' Clear existing rows
        Billing.txtUnavailableDates.Rows.Clear()
        dateRanges.Sort(Function(x, y) x.Item1.CompareTo(y.Item1))
        ' Add new rows for each date range
        For Each range In dateRanges
            Billing.txtUnavailableDates.Rows.Add(range.Item1.ToString("yyyy-MM-dd"), range.Item2.ToString("yyyy-MM-dd"))
        Next
    End Sub

    Public Function IsFolderNotEmpty(ByVal folderPath As String) As Boolean
        ' Check if the folder exists
        If Directory.Exists(folderPath) Then
            ' Get all files in the folder
            Dim files() As String = Directory.GetFiles(folderPath)
            ' Check if the folder is not empty
            Return files.Length > 0
        Else
            MessageBox.Show($"Folder '{folderPath}' does not exist.", "Folder Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If System.IO.File.Exists(folderPath + txtCarID.Text + ".txt") Then
            Try
                System.IO.File.Delete(folderPath + txtCarID.Text + ".txt")
                RemoveFromArray(vehicles, vehicles(indexCar))
                If indexCar = 0 And vehicles.Length = 0 Then
                    indexCar = 0
                    picVehicle.Image = Nothing
                    txtCarID.Text = ""
                    txtPlateNo.Text = ""
                    txtCarColor.Text = ""
                    txtType.Text = ""
                    txtCapacity.Text = ""
                    txtBodyNo.Text = ""
                    txtDailyPrice.Text = ""
                    txtStatus.Text = ""
                ElseIf indexCar = 0 Then
                    indexCar = 0
                Else
                    indexCar -= 1
                End If
                SetInfo()
                MessageBox.Show("File deleted successfully.")
            Catch ex As Exception
                MessageBox.Show("Error deleting file: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Car does not exist.")
        End If
    End Sub

    Private Sub RemoveFromArray(ByRef arr() As String, ByVal valueToRemove As String)
        Dim indexToRemove As Integer = -1

        ' Find the index of the value to remove
        For i As Integer = 0 To arr.Length - 1
            If arr(i) = valueToRemove Then
                indexToRemove = i
                Exit For
            End If
        Next

        ' If value is found, remove it by shifting elements
        If indexToRemove <> -1 Then
            For i As Integer = indexToRemove To arr.Length - 2
                arr(i) = arr(i + 1)
            Next
            ' Resize the array to remove the last element
            Array.Resize(arr, arr.Length - 1)
        Else
            MessageBox.Show("Value not found in the array.")
        End If
    End Sub

End Class