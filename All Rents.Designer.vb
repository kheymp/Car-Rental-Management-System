<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAllRents
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label8 = New Label()
        DataGridView1 = New DataGridView()
        CarID = New DataGridViewTextBoxColumn()
        CustomerName = New DataGridViewTextBoxColumn()
        RemainingDay = New DataGridViewTextBoxColumn()
        StartDateCo = New DataGridViewTextBoxColumn()
        EndDate = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell Condensed", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(211, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(276, 94)
        Label8.TabIndex = 17
        Label8.Text = "All Rents"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {CarID, CustomerName, RemainingDay, StartDateCo, EndDate})
        DataGridView1.Location = New Point(12, 97)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 50
        DataGridView1.Size = New Size(675, 371)
        DataGridView1.TabIndex = 18
        ' 
        ' CarID
        ' 
        CarID.HeaderText = "Car ID"
        CarID.MinimumWidth = 6
        CarID.Name = "CarID"
        CarID.Width = 125
        ' 
        ' CustomerName
        ' 
        CustomerName.HeaderText = "Customer Name"
        CustomerName.MinimumWidth = 6
        CustomerName.Name = "CustomerName"
        CustomerName.Width = 125
        ' 
        ' RemainingDay
        ' 
        RemainingDay.HeaderText = "Remaining Day"
        RemainingDay.MinimumWidth = 6
        RemainingDay.Name = "RemainingDay"
        RemainingDay.Width = 125
        ' 
        ' StartDateCo
        ' 
        StartDateCo.HeaderText = "Start Date"
        StartDateCo.MinimumWidth = 6
        StartDateCo.Name = "StartDateCo"
        StartDateCo.Width = 125
        ' 
        ' EndDate
        ' 
        EndDate.HeaderText = "End Date"
        EndDate.MinimumWidth = 6
        EndDate.Name = "EndDate"
        EndDate.Width = 125
        ' 
        ' frmAllRents
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(699, 489)
        Controls.Add(DataGridView1)
        Controls.Add(Label8)
        Name = "frmAllRents"
        Text = "All Rents"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CarID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents RemainingDay As DataGridViewTextBoxColumn
    Friend WithEvents StartDateCo As DataGridViewTextBoxColumn
    Friend WithEvents EndDate As DataGridViewTextBoxColumn
End Class
