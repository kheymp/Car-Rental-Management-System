<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModify
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
        btnOk = New Button()
        txtNewPrice = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtOriginalPrice = New TextBox()
        txtBilling = New TextBox()
        Label3 = New Label()
        txtDailyRate = New TextBox()
        Label4 = New Label()
        txtUnavailableDates = New DataGridView()
        strStartDate = New DataGridViewTextBoxColumn()
        strEndDate = New DataGridViewTextBoxColumn()
        txtNewStart = New DateTimePicker()
        txtNewEnd = New DateTimePicker()
        Label5 = New Label()
        Label6 = New Label()
        txtOriginalEnd = New TextBox()
        txtOriginalStart = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label12 = New Label()
        CType(txtUnavailableDates, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnOk
        ' 
        btnOk.Font = New Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOk.ForeColor = Color.OrangeRed
        btnOk.Location = New Point(233, 501)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(111, 39)
        btnOk.TabIndex = 54
        btnOk.Text = "OK"
        btnOk.UseVisualStyleBackColor = True
        ' 
        ' txtNewPrice
        ' 
        txtNewPrice.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNewPrice.Location = New Point(214, 381)
        txtNewPrice.Name = "txtNewPrice"
        txtNewPrice.ReadOnly = True
        txtNewPrice.Size = New Size(148, 43)
        txtNewPrice.TabIndex = 55
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(209, 356)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 22)
        Label1.TabIndex = 56
        Label1.Text = "Additional Price"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(45, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 22)
        Label2.TabIndex = 57
        Label2.Text = "Original Price"
        ' 
        ' txtOriginalPrice
        ' 
        txtOriginalPrice.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtOriginalPrice.Location = New Point(45, 105)
        txtOriginalPrice.Name = "txtOriginalPrice"
        txtOriginalPrice.ReadOnly = True
        txtOriginalPrice.Size = New Size(148, 43)
        txtOriginalPrice.TabIndex = 58
        ' 
        ' txtBilling
        ' 
        txtBilling.BackColor = Color.SpringGreen
        txtBilling.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBilling.ForeColor = SystemColors.WindowText
        txtBilling.Location = New Point(214, 452)
        txtBilling.Name = "txtBilling"
        txtBilling.ReadOnly = True
        txtBilling.Size = New Size(148, 43)
        txtBilling.TabIndex = 59
        txtBilling.Text = "No Need."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(250, 427)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 22)
        Label3.TabIndex = 60
        Label3.Text = "Billing:"
        ' 
        ' txtDailyRate
        ' 
        txtDailyRate.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDailyRate.Location = New Point(45, 34)
        txtDailyRate.Name = "txtDailyRate"
        txtDailyRate.ReadOnly = True
        txtDailyRate.Size = New Size(148, 43)
        txtDailyRate.TabIndex = 61
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(45, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 22)
        Label4.TabIndex = 62
        Label4.Text = "Daily Rate"
        ' 
        ' txtUnavailableDates
        ' 
        txtUnavailableDates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        txtUnavailableDates.Columns.AddRange(New DataGridViewColumn() {strStartDate, strEndDate})
        txtUnavailableDates.Location = New Point(233, 80)
        txtUnavailableDates.Name = "txtUnavailableDates"
        txtUnavailableDates.RowHeadersWidth = 51
        txtUnavailableDates.Size = New Size(300, 127)
        txtUnavailableDates.TabIndex = 65
        ' 
        ' strStartDate
        ' 
        strStartDate.HeaderText = "Start Date"
        strStartDate.MinimumWidth = 6
        strStartDate.Name = "strStartDate"
        strStartDate.Width = 125
        ' 
        ' strEndDate
        ' 
        strEndDate.HeaderText = "End Date"
        strEndDate.MinimumWidth = 6
        strEndDate.Name = "strEndDate"
        strEndDate.Width = 125
        ' 
        ' txtNewStart
        ' 
        txtNewStart.CalendarFont = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNewStart.Font = New Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNewStart.Location = New Point(293, 244)
        txtNewStart.Name = "txtNewStart"
        txtNewStart.Size = New Size(240, 31)
        txtNewStart.TabIndex = 66
        ' 
        ' txtNewEnd
        ' 
        txtNewEnd.CalendarFont = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNewEnd.Font = New Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNewEnd.Location = New Point(293, 317)
        txtNewEnd.Name = "txtNewEnd"
        txtNewEnd.Size = New Size(240, 31)
        txtNewEnd.TabIndex = 67
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(293, 219)
        Label5.Name = "Label5"
        Label5.Size = New Size(145, 22)
        Label5.TabIndex = 68
        Label5.Text = "New Start Date"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(293, 292)
        Label6.Name = "Label6"
        Label6.Size = New Size(140, 22)
        Label6.TabIndex = 69
        Label6.Text = "New End Date"
        ' 
        ' txtOriginalEnd
        ' 
        txtOriginalEnd.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtOriginalEnd.Location = New Point(45, 271)
        txtOriginalEnd.Name = "txtOriginalEnd"
        txtOriginalEnd.ReadOnly = True
        txtOriginalEnd.Size = New Size(148, 31)
        txtOriginalEnd.TabIndex = 71
        ' 
        ' txtOriginalStart
        ' 
        txtOriginalStart.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtOriginalStart.Location = New Point(45, 198)
        txtOriginalStart.Name = "txtOriginalStart"
        txtOriginalStart.ReadOnly = True
        txtOriginalStart.Size = New Size(148, 31)
        txtOriginalStart.TabIndex = 72
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(45, 173)
        Label7.Name = "Label7"
        Label7.Size = New Size(182, 22)
        Label7.TabIndex = 73
        Label7.Text = "Original Start Date"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(45, 246)
        Label8.Name = "Label8"
        Label8.Size = New Size(177, 22)
        Label8.TabIndex = 74
        Label8.Text = "Original End Date"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(248, 24)
        Label12.Name = "Label12"
        Label12.Size = New Size(285, 38)
        Label12.TabIndex = 75
        Label12.Text = "Unavailable Dates"
        ' 
        ' frmModify
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(576, 552)
        ControlBox = False
        Controls.Add(Label12)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txtOriginalStart)
        Controls.Add(txtOriginalEnd)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtNewEnd)
        Controls.Add(txtNewStart)
        Controls.Add(txtUnavailableDates)
        Controls.Add(Label4)
        Controls.Add(txtDailyRate)
        Controls.Add(Label3)
        Controls.Add(txtBilling)
        Controls.Add(txtOriginalPrice)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNewPrice)
        Controls.Add(btnOk)
        Name = "frmModify"
        Text = "Modify Rent"
        CType(txtUnavailableDates, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnOk As Button
    Friend WithEvents txtNewPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOriginalPrice As TextBox
    Friend WithEvents txtBilling As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDailyRate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUnavailableDates As DataGridView
    Friend WithEvents strStartDate As DataGridViewTextBoxColumn
    Friend WithEvents strEndDate As DataGridViewTextBoxColumn
    Friend WithEvents txtNewStart As DateTimePicker
    Friend WithEvents txtNewEnd As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtOriginalEnd As TextBox
    Friend WithEvents txtOriginalStart As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
End Class
