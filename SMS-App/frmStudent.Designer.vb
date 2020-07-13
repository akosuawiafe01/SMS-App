<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbMaritalStatus = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtPostalAddress = New System.Windows.Forms.TextBox()
        Me.txtOtherName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHomeLang = New System.Windows.Forms.TextBox()
        Me.txtCitizenship = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMS_DataSet = New SMS_App.SMS_DataSet()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.DepartmentTableAdapter = New SMS_App.SMS_DataSetTableAdapters.DepartmentTableAdapter()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtStudentPin = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.cmbCollege = New System.Windows.Forms.ComboBox()
        Me.cmbStudentLevel = New System.Windows.Forms.ComboBox()
        Me.cmbProgramme = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Cursor = System.Windows.Forms.Cursors.No
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1301, 60)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Students Registration"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.cmbMaritalStatus)
        Me.GroupBox1.Controls.Add(Me.cmbGender)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.dtpDOB)
        Me.GroupBox1.Controls.Add(Me.txtPostalAddress)
        Me.GroupBox1.Controls.Add(Me.txtOtherName)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(74, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 299)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Information"
        '
        'cmbMaritalStatus
        '
        Me.cmbMaritalStatus.FormattingEnabled = True
        Me.cmbMaritalStatus.Items.AddRange(New Object() {"Single ", "Married"})
        Me.cmbMaritalStatus.Location = New System.Drawing.Point(152, 262)
        Me.cmbMaritalStatus.Name = "cmbMaritalStatus"
        Me.cmbMaritalStatus.Size = New System.Drawing.Size(144, 21)
        Me.cmbMaritalStatus.TabIndex = 34
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male ", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(152, 157)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(144, 21)
        Me.cmbGender.TabIndex = 33
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(32, 265)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(71, 13)
        Me.Label24.TabIndex = 27
        Me.Label24.Text = "Marital Status"
        '
        'dtpDOB
        '
        Me.dtpDOB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpDOB.Location = New System.Drawing.Point(152, 128)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(144, 20)
        Me.dtpDOB.TabIndex = 26
        '
        'txtPostalAddress
        '
        Me.txtPostalAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPostalAddress.Location = New System.Drawing.Point(152, 236)
        Me.txtPostalAddress.Name = "txtPostalAddress"
        Me.txtPostalAddress.Size = New System.Drawing.Size(144, 20)
        Me.txtPostalAddress.TabIndex = 24
        '
        'txtOtherName
        '
        Me.txtOtherName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtOtherName.Location = New System.Drawing.Point(152, 93)
        Me.txtOtherName.Name = "txtOtherName"
        Me.txtOtherName.Size = New System.Drawing.Size(144, 20)
        Me.txtOtherName.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Other Name"
        '
        'txtContact
        '
        Me.txtContact.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtContact.Location = New System.Drawing.Point(152, 183)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(144, 20)
        Me.txtContact.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(32, 236)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Postal Address"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "DOB"
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFirstName.Location = New System.Drawing.Point(152, 41)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(144, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Last Name"
        '
        'TextBox13
        '
        Me.TextBox13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox13.Location = New System.Drawing.Point(334, 320)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(144, 20)
        Me.TextBox13.TabIndex = 21
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.Location = New System.Drawing.Point(152, 209)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(144, 20)
        Me.txtEmail.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Email"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First Name"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Contact"
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLastName.Location = New System.Drawing.Point(152, 67)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(144, 20)
        Me.txtLastName.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Home Language"
        '
        'txtHomeLang
        '
        Me.txtHomeLang.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHomeLang.Location = New System.Drawing.Point(140, 91)
        Me.txtHomeLang.Name = "txtHomeLang"
        Me.txtHomeLang.Size = New System.Drawing.Size(144, 20)
        Me.txtHomeLang.TabIndex = 7
        '
        'txtCitizenship
        '
        Me.txtCitizenship.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCitizenship.Location = New System.Drawing.Point(140, 63)
        Me.txtCitizenship.Name = "txtCitizenship"
        Me.txtCitizenship.Size = New System.Drawing.Size(144, 20)
        Me.txtCitizenship.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtCitizenship)
        Me.GroupBox3.Controls.Add(Me.txtHomeLang)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(74, 406)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(442, 146)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Language and Citizenship"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Citizenship"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(644, 313)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 13)
        Me.Label13.TabIndex = 18
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.SMS_DataSet
        '
        'SMS_DataSet
        '
        Me.SMS_DataSet.DataSetName = "SMS_DataSet"
        Me.SMS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.Location = New System.Drawing.Point(815, 549)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(74, 26)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.Location = New System.Drawing.Point(924, 549)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 26)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Back"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(40, 63)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 13)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "Department"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(42, 91)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 13)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Programme"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Enabled = False
        Me.Label18.Location = New System.Drawing.Point(40, 103)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 13)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Student Pin"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(40, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 13)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "College"
        '
        'txtStudentPin
        '
        Me.txtStudentPin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStudentPin.Enabled = False
        Me.txtStudentPin.Location = New System.Drawing.Point(187, 96)
        Me.txtStudentPin.Name = "txtStudentPin"
        Me.txtStudentPin.Size = New System.Drawing.Size(144, 20)
        Me.txtStudentPin.TabIndex = 18
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(40, 116)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(33, 13)
        Me.Label23.TabIndex = 29
        Me.Label23.Text = "Level"
        '
        'cmbDepartment
        '
        Me.cmbDepartment.DataSource = Me.DepartmentBindingSource
        Me.cmbDepartment.DisplayMember = "deptName"
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(187, 55)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(144, 21)
        Me.cmbDepartment.TabIndex = 31
        Me.cmbDepartment.ValueMember = "deptID"
        '
        'cmbCollege
        '
        Me.cmbCollege.FormattingEnabled = True
        Me.cmbCollege.Items.AddRange(New Object() {"Health Sciences", "Basic and Applied Sciences", "Humanities", "Education"})
        Me.cmbCollege.Location = New System.Drawing.Point(187, 28)
        Me.cmbCollege.Name = "cmbCollege"
        Me.cmbCollege.Size = New System.Drawing.Size(144, 21)
        Me.cmbCollege.TabIndex = 32
        '
        'cmbStudentLevel
        '
        Me.cmbStudentLevel.FormattingEnabled = True
        Me.cmbStudentLevel.Items.AddRange(New Object() {"100", "200", "300", "400", "500 ", "600"})
        Me.cmbStudentLevel.Location = New System.Drawing.Point(188, 107)
        Me.cmbStudentLevel.Name = "cmbStudentLevel"
        Me.cmbStudentLevel.Size = New System.Drawing.Size(144, 21)
        Me.cmbStudentLevel.TabIndex = 33
        '
        'cmbProgramme
        '
        Me.cmbProgramme.DropDownWidth = 160
        Me.cmbProgramme.FormattingEnabled = True
        Me.cmbProgramme.Items.AddRange(New Object() {"Bachelor of Arts", "Bachelor of Fine Arts", "Bachelor of Law", "Bachelor of Science in Administration", "Bachelor of Science in Agriculture", "Doctor of Veterinary Medicine", "Bachelor of Science in Engineering", "Bachelor of Science in Family and Consumer Sciences", "Bachelor of Science in Natural Sciences", "Bachelor of Dental Surgery", "Bachelor of Medicine and Bachelor of Surgery", "B.Sc. Dietetics", "B.Sc. Medical Laboratory Sciences", "B.Sc. Occupational Therapy", "B.Sc. Physiotherapy", "B.Sc. Radiography"})
        Me.cmbProgramme.Location = New System.Drawing.Point(187, 82)
        Me.cmbProgramme.Name = "cmbProgramme"
        Me.cmbProgramme.Size = New System.Drawing.Size(144, 21)
        Me.cmbProgramme.TabIndex = 34
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.cmbProgramme)
        Me.GroupBox4.Controls.Add(Me.cmbStudentLevel)
        Me.GroupBox4.Controls.Add(Me.cmbCollege)
        Me.GroupBox4.Controls.Add(Me.cmbDepartment)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Location = New System.Drawing.Point(558, 200)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(443, 185)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Other Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 35
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.Enabled = False
        Me.Label21.Location = New System.Drawing.Point(40, 66)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 13)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Student ID"
        '
        'txtStudentID
        '
        Me.txtStudentID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStudentID.Enabled = False
        Me.txtStudentID.Location = New System.Drawing.Point(187, 59)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(144, 20)
        Me.txtStudentID.TabIndex = 8
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.txtStudentID)
        Me.GroupBox5.Controls.Add(Me.txtStudentPin)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Location = New System.Drawing.Point(558, 406)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(444, 137)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Viital credentials"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(40, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(345, 33)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "These will be your Identification credentials and logins." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Do not share your Stud" &
    "ent Pin with anyone" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 606)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStudent"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMS_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtHomeLang As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtCitizenship As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPostalAddress As TextBox
    Friend WithEvents txtOtherName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents SMS_DataSet As SMS_DataSet
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentTableAdapter As SMS_DataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents cmbMaritalStatus As ComboBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtStudentPin As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents cmbCollege As ComboBox
    Friend WithEvents cmbStudentLevel As ComboBox
    Friend WithEvents cmbProgramme As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
End Class
