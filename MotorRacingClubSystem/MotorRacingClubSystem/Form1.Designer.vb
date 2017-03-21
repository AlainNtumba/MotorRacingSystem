<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.DriverForm = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEnterId = New System.Windows.Forms.TextBox()
        Me.btnSearchId = New System.Windows.Forms.Button()
        Me.btnExitDriver = New System.Windows.Forms.Button()
        Me.btnEditDriver = New System.Windows.Forms.Button()
        Me.btnDeleteDriver = New System.Windows.Forms.Button()
        Me.btnAddDriver = New System.Windows.Forms.Button()
        Me.lstDrivers = New System.Windows.Forms.ListBox()
        Me.EventsForm = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEnterEvent = New System.Windows.Forms.TextBox()
        Me.btnSearchEvent = New System.Windows.Forms.Button()
        Me.btnExitEvent = New System.Windows.Forms.Button()
        Me.btnEditEvent = New System.Windows.Forms.Button()
        Me.btnDeleteEvent = New System.Windows.Forms.Button()
        Me.btnAddEvent = New System.Windows.Forms.Button()
        Me.lstEvents = New System.Windows.Forms.ListBox()
        Me.ResultsForm = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cbRacerList = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.DriverForm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.EventsForm.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ResultsForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.DriverForm)
        Me.TabControl1.Controls.Add(Me.EventsForm)
        Me.TabControl1.Controls.Add(Me.ResultsForm)
        Me.TabControl1.Location = New System.Drawing.Point(4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(623, 241)
        Me.TabControl1.TabIndex = 0
        '
        'DriverForm
        '
        Me.DriverForm.Controls.Add(Me.GroupBox1)
        Me.DriverForm.Controls.Add(Me.btnExitDriver)
        Me.DriverForm.Controls.Add(Me.btnEditDriver)
        Me.DriverForm.Controls.Add(Me.btnDeleteDriver)
        Me.DriverForm.Controls.Add(Me.btnAddDriver)
        Me.DriverForm.Controls.Add(Me.lstDrivers)
        Me.DriverForm.Location = New System.Drawing.Point(4, 22)
        Me.DriverForm.Name = "DriverForm"
        Me.DriverForm.Padding = New System.Windows.Forms.Padding(3)
        Me.DriverForm.Size = New System.Drawing.Size(615, 215)
        Me.DriverForm.TabIndex = 0
        Me.DriverForm.Text = "Drivers Form"
        Me.DriverForm.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEnterId)
        Me.GroupBox1.Controls.Add(Me.btnSearchId)
        Me.GroupBox1.Location = New System.Drawing.Point(501, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(107, 82)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Id"
        '
        'txtEnterId
        '
        Me.txtEnterId.Location = New System.Drawing.Point(7, 49)
        Me.txtEnterId.Name = "txtEnterId"
        Me.txtEnterId.Size = New System.Drawing.Size(94, 20)
        Me.txtEnterId.TabIndex = 7
        Me.txtEnterId.Tag = "Member ID"
        '
        'btnSearchId
        '
        Me.btnSearchId.Location = New System.Drawing.Point(6, 19)
        Me.btnSearchId.Name = "btnSearchId"
        Me.btnSearchId.Size = New System.Drawing.Size(95, 23)
        Me.btnSearchId.TabIndex = 6
        Me.btnSearchId.Tag = "Member ID Search"
        Me.btnSearchId.Text = "Search"
        Me.btnSearchId.UseVisualStyleBackColor = True
        '
        'btnExitDriver
        '
        Me.btnExitDriver.Location = New System.Drawing.Point(500, 94)
        Me.btnExitDriver.Name = "btnExitDriver"
        Me.btnExitDriver.Size = New System.Drawing.Size(108, 23)
        Me.btnExitDriver.TabIndex = 4
        Me.btnExitDriver.Text = "Exit"
        Me.btnExitDriver.UseVisualStyleBackColor = True
        '
        'btnEditDriver
        '
        Me.btnEditDriver.Location = New System.Drawing.Point(501, 65)
        Me.btnEditDriver.Name = "btnEditDriver"
        Me.btnEditDriver.Size = New System.Drawing.Size(108, 23)
        Me.btnEditDriver.TabIndex = 3
        Me.btnEditDriver.Text = "Edit Driver"
        Me.btnEditDriver.UseVisualStyleBackColor = True
        '
        'btnDeleteDriver
        '
        Me.btnDeleteDriver.Location = New System.Drawing.Point(500, 36)
        Me.btnDeleteDriver.Name = "btnDeleteDriver"
        Me.btnDeleteDriver.Size = New System.Drawing.Size(108, 23)
        Me.btnDeleteDriver.TabIndex = 2
        Me.btnDeleteDriver.Text = "Delete Driver"
        Me.btnDeleteDriver.UseVisualStyleBackColor = True
        '
        'btnAddDriver
        '
        Me.btnAddDriver.Location = New System.Drawing.Point(501, 7)
        Me.btnAddDriver.Name = "btnAddDriver"
        Me.btnAddDriver.Size = New System.Drawing.Size(108, 23)
        Me.btnAddDriver.TabIndex = 1
        Me.btnAddDriver.Text = "Add Driver"
        Me.btnAddDriver.UseVisualStyleBackColor = True
        '
        'lstDrivers
        '
        Me.lstDrivers.FormattingEnabled = True
        Me.lstDrivers.Location = New System.Drawing.Point(7, 7)
        Me.lstDrivers.Name = "lstDrivers"
        Me.lstDrivers.Size = New System.Drawing.Size(487, 199)
        Me.lstDrivers.TabIndex = 0
        '
        'EventsForm
        '
        Me.EventsForm.Controls.Add(Me.GroupBox2)
        Me.EventsForm.Controls.Add(Me.btnExitEvent)
        Me.EventsForm.Controls.Add(Me.btnEditEvent)
        Me.EventsForm.Controls.Add(Me.btnDeleteEvent)
        Me.EventsForm.Controls.Add(Me.btnAddEvent)
        Me.EventsForm.Controls.Add(Me.lstEvents)
        Me.EventsForm.Location = New System.Drawing.Point(4, 22)
        Me.EventsForm.Name = "EventsForm"
        Me.EventsForm.Padding = New System.Windows.Forms.Padding(3)
        Me.EventsForm.Size = New System.Drawing.Size(615, 215)
        Me.EventsForm.TabIndex = 1
        Me.EventsForm.Text = "Events Form"
        Me.EventsForm.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtEnterEvent)
        Me.GroupBox2.Controls.Add(Me.btnSearchEvent)
        Me.GroupBox2.Location = New System.Drawing.Point(500, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(107, 82)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Id"
        '
        'txtEnterEvent
        '
        Me.txtEnterEvent.Location = New System.Drawing.Point(7, 50)
        Me.txtEnterEvent.Name = "txtEnterEvent"
        Me.txtEnterEvent.Size = New System.Drawing.Size(94, 20)
        Me.txtEnterEvent.TabIndex = 7
        '
        'btnSearchEvent
        '
        Me.btnSearchEvent.Location = New System.Drawing.Point(6, 20)
        Me.btnSearchEvent.Name = "btnSearchEvent"
        Me.btnSearchEvent.Size = New System.Drawing.Size(95, 23)
        Me.btnSearchEvent.TabIndex = 6
        Me.btnSearchEvent.Text = "Search"
        Me.btnSearchEvent.UseVisualStyleBackColor = True
        '
        'btnExitEvent
        '
        Me.btnExitEvent.Location = New System.Drawing.Point(499, 94)
        Me.btnExitEvent.Name = "btnExitEvent"
        Me.btnExitEvent.Size = New System.Drawing.Size(108, 23)
        Me.btnExitEvent.TabIndex = 9
        Me.btnExitEvent.Text = "Exit"
        Me.btnExitEvent.UseVisualStyleBackColor = True
        '
        'btnEditEvent
        '
        Me.btnEditEvent.Location = New System.Drawing.Point(500, 65)
        Me.btnEditEvent.Name = "btnEditEvent"
        Me.btnEditEvent.Size = New System.Drawing.Size(108, 23)
        Me.btnEditEvent.TabIndex = 8
        Me.btnEditEvent.Text = "Edit Event"
        Me.btnEditEvent.UseVisualStyleBackColor = True
        '
        'btnDeleteEvent
        '
        Me.btnDeleteEvent.Location = New System.Drawing.Point(499, 36)
        Me.btnDeleteEvent.Name = "btnDeleteEvent"
        Me.btnDeleteEvent.Size = New System.Drawing.Size(108, 23)
        Me.btnDeleteEvent.TabIndex = 7
        Me.btnDeleteEvent.Text = "Delete Events"
        Me.btnDeleteEvent.UseVisualStyleBackColor = True
        '
        'btnAddEvent
        '
        Me.btnAddEvent.Location = New System.Drawing.Point(500, 7)
        Me.btnAddEvent.Name = "btnAddEvent"
        Me.btnAddEvent.Size = New System.Drawing.Size(108, 23)
        Me.btnAddEvent.TabIndex = 6
        Me.btnAddEvent.Text = "Add Event"
        Me.btnAddEvent.UseVisualStyleBackColor = True
        '
        'lstEvents
        '
        Me.lstEvents.FormattingEnabled = True
        Me.lstEvents.Location = New System.Drawing.Point(6, 7)
        Me.lstEvents.Name = "lstEvents"
        Me.lstEvents.Size = New System.Drawing.Size(487, 199)
        Me.lstEvents.TabIndex = 1
        '
        'ResultsForm
        '
        Me.ResultsForm.Controls.Add(Me.TextBox2)
        Me.ResultsForm.Controls.Add(Me.TextBox1)
        Me.ResultsForm.Controls.Add(Me.Label7)
        Me.ResultsForm.Controls.Add(Me.Label6)
        Me.ResultsForm.Controls.Add(Me.Label5)
        Me.ResultsForm.Controls.Add(Me.Label4)
        Me.ResultsForm.Controls.Add(Me.Label3)
        Me.ResultsForm.Controls.Add(Me.Label2)
        Me.ResultsForm.Controls.Add(Me.Label1)
        Me.ResultsForm.Controls.Add(Me.ComboBox7)
        Me.ResultsForm.Controls.Add(Me.ComboBox6)
        Me.ResultsForm.Controls.Add(Me.ComboBox5)
        Me.ResultsForm.Controls.Add(Me.ComboBox4)
        Me.ResultsForm.Controls.Add(Me.ComboBox3)
        Me.ResultsForm.Controls.Add(Me.ComboBox2)
        Me.ResultsForm.Controls.Add(Me.ComboBox1)
        Me.ResultsForm.Controls.Add(Me.cbRacerList)
        Me.ResultsForm.Location = New System.Drawing.Point(4, 22)
        Me.ResultsForm.Name = "ResultsForm"
        Me.ResultsForm.Size = New System.Drawing.Size(615, 215)
        Me.ResultsForm.TabIndex = 2
        Me.ResultsForm.Text = "Driver's Race Results "
        Me.ResultsForm.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(346, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(66, 20)
        Me.TextBox2.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(346, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(66, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(268, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Enter Position"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(268, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Enter Position"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(268, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Enter Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(268, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Enter Position"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(268, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Enter Position"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(268, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Enter Position"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(268, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Enter Position"
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(141, 178)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox7.TabIndex = 7
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(141, 151)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox6.TabIndex = 6
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(141, 124)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox5.TabIndex = 5
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(141, 97)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 4
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(141, 70)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 3
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(141, 43)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(141, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'cbRacerList
        '
        Me.cbRacerList.FormattingEnabled = True
        Me.cbRacerList.Location = New System.Drawing.Point(13, 17)
        Me.cbRacerList.Name = "cbRacerList"
        Me.cbRacerList.Size = New System.Drawing.Size(121, 21)
        Me.cbRacerList.TabIndex = 0
        Me.cbRacerList.Tag = "Driver"
        Me.cbRacerList.Text = "Select a Driver"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 251)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Motor Racing Club System"
        Me.TabControl1.ResumeLayout(False)
        Me.DriverForm.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.EventsForm.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResultsForm.ResumeLayout(False)
        Me.ResultsForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents DriverForm As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtEnterId As TextBox
    Friend WithEvents btnSearchId As Button
    Friend WithEvents btnExitDriver As Button
    Friend WithEvents btnEditDriver As Button
    Friend WithEvents btnDeleteDriver As Button
    Friend WithEvents btnAddDriver As Button
    Friend WithEvents lstDrivers As ListBox
    Friend WithEvents EventsForm As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtEnterEvent As TextBox
    Friend WithEvents btnSearchEvent As Button
    Friend WithEvents btnExitEvent As Button
    Friend WithEvents btnEditEvent As Button
    Friend WithEvents btnDeleteEvent As Button
    Friend WithEvents btnAddEvent As Button
    Friend WithEvents lstEvents As ListBox
    Friend WithEvents ResultsForm As TabPage
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cbRacerList As ComboBox
End Class
