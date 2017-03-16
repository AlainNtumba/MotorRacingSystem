<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventMaintForm
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
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtRegFee = New System.Windows.Forms.TextBox()
        Me.txtLapNum = New System.Windows.Forms.TextBox()
        Me.dtEventDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSaveEvent = New System.Windows.Forms.Button()
        Me.btnCancelEvent = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(104, 12)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(112, 20)
        Me.txtTitle.TabIndex = 0
        Me.txtTitle.Tag = "Event Title"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(104, 38)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(112, 20)
        Me.txtLocation.TabIndex = 1
        Me.txtLocation.Tag = "Event Location"
        '
        'txtRegFee
        '
        Me.txtRegFee.Location = New System.Drawing.Point(157, 91)
        Me.txtRegFee.Name = "txtRegFee"
        Me.txtRegFee.Size = New System.Drawing.Size(59, 20)
        Me.txtRegFee.TabIndex = 4
        Me.txtRegFee.Tag = "Registration Fee"
        '
        'txtLapNum
        '
        Me.txtLapNum.Location = New System.Drawing.Point(157, 117)
        Me.txtLapNum.Name = "txtLapNum"
        Me.txtLapNum.Size = New System.Drawing.Size(59, 20)
        Me.txtLapNum.TabIndex = 5
        Me.txtLapNum.Tag = "Number Of Lap(s)"
        '
        'dtEventDate
        '
        Me.dtEventDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEventDate.Location = New System.Drawing.Point(104, 65)
        Me.dtEventDate.Name = "dtEventDate"
        Me.dtEventDate.Size = New System.Drawing.Size(112, 20)
        Me.dtEventDate.TabIndex = 3
        Me.dtEventDate.Tag = "Event Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Location"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Registration Fee"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Number Of Lap(s)"
        '
        'btnSaveEvent
        '
        Me.btnSaveEvent.Location = New System.Drawing.Point(16, 153)
        Me.btnSaveEvent.Name = "btnSaveEvent"
        Me.btnSaveEvent.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveEvent.TabIndex = 6
        Me.btnSaveEvent.Text = "&Save"
        Me.btnSaveEvent.UseVisualStyleBackColor = True
        '
        'btnCancelEvent
        '
        Me.btnCancelEvent.Location = New System.Drawing.Point(141, 153)
        Me.btnCancelEvent.Name = "btnCancelEvent"
        Me.btnCancelEvent.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelEvent.TabIndex = 7
        Me.btnCancelEvent.Text = "&Cancel"
        Me.btnCancelEvent.UseVisualStyleBackColor = True
        '
        'EventMaintForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 191)
        Me.Controls.Add(Me.btnCancelEvent)
        Me.Controls.Add(Me.btnSaveEvent)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtEventDate)
        Me.Controls.Add(Me.txtLapNum)
        Me.Controls.Add(Me.txtRegFee)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtTitle)
        Me.Name = "EventMaintForm"
        Me.Text = "Event Maintenance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtRegFee As TextBox
    Friend WithEvents txtLapNum As TextBox
    Friend WithEvents dtEventDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSaveEvent As Button
    Friend WithEvents btnCancelEvent As Button
End Class
