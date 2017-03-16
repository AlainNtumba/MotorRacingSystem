<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DriverMaintForm
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.dtBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.dtDateJoined = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbDisplayId = New System.Windows.Forms.Label()
        Me.gpGender = New System.Windows.Forms.GroupBox()
        Me.rdFemale = New System.Windows.Forms.RadioButton()
        Me.rdMale = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbEventList = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.btnSaveDriver = New System.Windows.Forms.Button()
        Me.btnCancelDriver = New System.Windows.Forms.Button()
        Me.gpGender.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(121, 24)
        Me.txtName.MaxLength = 14
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(139, 20)
        Me.txtName.TabIndex = 0
        Me.txtName.Tag = "Name"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(121, 53)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(139, 20)
        Me.txtSurname.TabIndex = 1
        Me.txtSurname.Tag = "Surname"
        '
        'dtBirthDate
        '
        Me.dtBirthDate.Location = New System.Drawing.Point(121, 82)
        Me.dtBirthDate.Name = "dtBirthDate"
        Me.dtBirthDate.Size = New System.Drawing.Size(139, 20)
        Me.dtBirthDate.TabIndex = 3
        Me.dtBirthDate.Tag = "Birth Date"
        '
        'dtDateJoined
        '
        Me.dtDateJoined.Location = New System.Drawing.Point(121, 111)
        Me.dtDateJoined.Name = "dtDateJoined"
        Me.dtDateJoined.Size = New System.Drawing.Size(139, 20)
        Me.dtDateJoined.TabIndex = 4
        Me.dtDateJoined.Tag = "Join Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Birth Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Join Date"
        '
        'lbDisplayId
        '
        Me.lbDisplayId.AutoSize = True
        Me.lbDisplayId.Location = New System.Drawing.Point(266, 24)
        Me.lbDisplayId.Name = "lbDisplayId"
        Me.lbDisplayId.Size = New System.Drawing.Size(21, 13)
        Me.lbDisplayId.TabIndex = 8
        Me.lbDisplayId.Text = "ID:"
        '
        'gpGender
        '
        Me.gpGender.Controls.Add(Me.rdFemale)
        Me.gpGender.Controls.Add(Me.rdMale)
        Me.gpGender.Location = New System.Drawing.Point(269, 40)
        Me.gpGender.Name = "gpGender"
        Me.gpGender.Size = New System.Drawing.Size(159, 46)
        Me.gpGender.TabIndex = 9
        Me.gpGender.TabStop = False
        Me.gpGender.Text = "Gender"
        '
        'rdFemale
        '
        Me.rdFemale.AutoSize = True
        Me.rdFemale.Location = New System.Drawing.Point(62, 20)
        Me.rdFemale.Name = "rdFemale"
        Me.rdFemale.Size = New System.Drawing.Size(59, 17)
        Me.rdFemale.TabIndex = 7
        Me.rdFemale.TabStop = True
        Me.rdFemale.Text = "Female"
        Me.rdFemale.UseVisualStyleBackColor = True
        '
        'rdMale
        '
        Me.rdMale.AutoSize = True
        Me.rdMale.Location = New System.Drawing.Point(7, 20)
        Me.rdMale.Name = "rdMale"
        Me.rdMale.Size = New System.Drawing.Size(48, 17)
        Me.rdMale.TabIndex = 6
        Me.rdMale.TabStop = True
        Me.rdMale.Text = "Male"
        Me.rdMale.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPosition)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbEventList)
        Me.GroupBox1.Location = New System.Drawing.Point(269, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 68)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Event"
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(85, 40)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(68, 20)
        Me.txtPosition.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Enter Position"
        '
        'cbEventList
        '
        Me.cbEventList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEventList.FormattingEnabled = True
        Me.cbEventList.Location = New System.Drawing.Point(7, 15)
        Me.cbEventList.Name = "cbEventList"
        Me.cbEventList.Size = New System.Drawing.Size(146, 21)
        Me.cbEventList.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Outstanding Fee"
        '
        'txtFee
        '
        Me.txtFee.Location = New System.Drawing.Point(121, 140)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(66, 20)
        Me.txtFee.TabIndex = 5
        Me.txtFee.Tag = "Outstanding Fee"
        '
        'btnSaveDriver
        '
        Me.btnSaveDriver.Location = New System.Drawing.Point(15, 177)
        Me.btnSaveDriver.Name = "btnSaveDriver"
        Me.btnSaveDriver.Size = New System.Drawing.Size(206, 23)
        Me.btnSaveDriver.TabIndex = 13
        Me.btnSaveDriver.Text = "Save"
        Me.btnSaveDriver.UseVisualStyleBackColor = True
        '
        'btnCancelDriver
        '
        Me.btnCancelDriver.Location = New System.Drawing.Point(222, 177)
        Me.btnCancelDriver.Name = "btnCancelDriver"
        Me.btnCancelDriver.Size = New System.Drawing.Size(206, 23)
        Me.btnCancelDriver.TabIndex = 14
        Me.btnCancelDriver.Text = "Cancel"
        Me.btnCancelDriver.UseVisualStyleBackColor = True
        '
        'DriverMaintForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 210)
        Me.Controls.Add(Me.btnCancelDriver)
        Me.Controls.Add(Me.btnSaveDriver)
        Me.Controls.Add(Me.txtFee)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gpGender)
        Me.Controls.Add(Me.lbDisplayId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtDateJoined)
        Me.Controls.Add(Me.dtBirthDate)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtName)
        Me.Name = "DriverMaintForm"
        Me.Text = "Driver Maintenance Form"
        Me.gpGender.ResumeLayout(False)
        Me.gpGender.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents dtBirthDate As DateTimePicker
    Friend WithEvents dtDateJoined As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbDisplayId As Label
    Friend WithEvents gpGender As GroupBox
    Friend WithEvents rdFemale As RadioButton
    Friend WithEvents rdMale As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbEventList As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFee As TextBox
    Friend WithEvents btnSaveDriver As Button
    Friend WithEvents btnCancelDriver As Button
End Class
