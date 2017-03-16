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
        Me.TabControl1.SuspendLayout()
        Me.DriverForm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.EventsForm.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.DriverForm)
        Me.TabControl1.Controls.Add(Me.EventsForm)
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
End Class
