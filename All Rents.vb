Imports System.IO

Public Class frmAllRents
    Private Sub All_Rents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateViewStatus()
    End Sub

    Public Sub UpdateViewStatus()
        ' Clear existing data in DataGridView
        DataGridView1.Rows.Clear()
        ScanFiles("Customers\")
    End Sub

    Public Sub ScanFiles(rootDirectory As String)
        Dim files As String() = Directory.GetFiles(rootDirectory, "*.txt", SearchOption.AllDirectories)

        For Each file As String In files
            ProcessTextFile(file)
        Next

        DataGridView1.Sort(DataGridView1.Columns("RemainingDay"), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub ProcessTextFile(filePath As String)
        Dim carId As String = ReadFileLine(filePath, 1)
        Dim strName As String = ReadFileLine(filePath, 3)
        Dim remaining As String = ReadFileLine(filePath, 8)
        Dim startDate As DateTime = ReadFileLine(filePath, 10)
        Dim endDate As DateTime = ReadFileLine(filePath, 11)
        DataGridView1.Rows.Add(carId, strName, remaining, startDate.ToString("dd/MM/yyyy"), endDate.ToString("dd/MM/yyyy"))
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
End Class