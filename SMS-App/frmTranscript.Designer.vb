<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTranscript
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpTransDate = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTransGPA = New System.Windows.Forms.TextBox()
        Me.txtTransHall = New System.Windows.Forms.TextBox()
        Me.txtTransProg = New System.Windows.Forms.TextBox()
        Me.txtTransDepartment = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTransLevel = New System.Windows.Forms.TextBox()
        Me.txtTransLN = New System.Windows.Forms.TextBox()
        Me.txtTransFN = New System.Windows.Forms.TextBox()
        Me.txtTransStudID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnPrintTranscript = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnViewResults = New System.Windows.Forms.Button()
        Me.dtpTransDate.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(928, 63)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WAN College"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpTransDate
        '
        Me.dtpTransDate.Controls.Add(Me.Label9)
        Me.dtpTransDate.Controls.Add(Me.txtTransGPA)
        Me.dtpTransDate.Controls.Add(Me.txtTransHall)
        Me.dtpTransDate.Controls.Add(Me.txtTransProg)
        Me.dtpTransDate.Controls.Add(Me.txtTransDepartment)
        Me.dtpTransDate.Controls.Add(Me.Label13)
        Me.dtpTransDate.Controls.Add(Me.Label12)
        Me.dtpTransDate.Controls.Add(Me.Label11)
        Me.dtpTransDate.Controls.Add(Me.txtTransLevel)
        Me.dtpTransDate.Controls.Add(Me.txtTransLN)
        Me.dtpTransDate.Controls.Add(Me.txtTransFN)
        Me.dtpTransDate.Controls.Add(Me.txtTransStudID)
        Me.dtpTransDate.Controls.Add(Me.Label8)
        Me.dtpTransDate.Controls.Add(Me.Label7)
        Me.dtpTransDate.Controls.Add(Me.Label3)
        Me.dtpTransDate.Controls.Add(Me.Label2)
        Me.dtpTransDate.Location = New System.Drawing.Point(42, 76)
        Me.dtpTransDate.Name = "dtpTransDate"
        Me.dtpTransDate.Size = New System.Drawing.Size(785, 167)
        Me.dtpTransDate.TabIndex = 1
        Me.dtpTransDate.TabStop = False
        Me.dtpTransDate.Text = "Student Details"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(509, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "GPA"
        '
        'txtTransGPA
        '
        Me.txtTransGPA.Location = New System.Drawing.Point(607, 30)
        Me.txtTransGPA.Name = "txtTransGPA"
        Me.txtTransGPA.Size = New System.Drawing.Size(129, 20)
        Me.txtTransGPA.TabIndex = 9
        '
        'txtTransHall
        '
        Me.txtTransHall.Location = New System.Drawing.Point(607, 138)
        Me.txtTransHall.Name = "txtTransHall"
        Me.txtTransHall.Size = New System.Drawing.Size(87, 20)
        Me.txtTransHall.TabIndex = 17
        '
        'txtTransProg
        '
        Me.txtTransProg.Location = New System.Drawing.Point(607, 109)
        Me.txtTransProg.Name = "txtTransProg"
        Me.txtTransProg.Size = New System.Drawing.Size(87, 20)
        Me.txtTransProg.TabIndex = 16
        '
        'txtTransDepartment
        '
        Me.txtTransDepartment.Location = New System.Drawing.Point(607, 79)
        Me.txtTransDepartment.Name = "txtTransDepartment"
        Me.txtTransDepartment.Size = New System.Drawing.Size(87, 20)
        Me.txtTransDepartment.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(509, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Hall"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(509, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Programme"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(507, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Department"
        '
        'txtTransLevel
        '
        Me.txtTransLevel.Location = New System.Drawing.Point(212, 131)
        Me.txtTransLevel.Name = "txtTransLevel"
        Me.txtTransLevel.Size = New System.Drawing.Size(129, 20)
        Me.txtTransLevel.TabIndex = 8
        '
        'txtTransLN
        '
        Me.txtTransLN.Location = New System.Drawing.Point(212, 83)
        Me.txtTransLN.Name = "txtTransLN"
        Me.txtTransLN.Size = New System.Drawing.Size(129, 20)
        Me.txtTransLN.TabIndex = 7
        '
        'txtTransFN
        '
        Me.txtTransFN.Location = New System.Drawing.Point(212, 109)
        Me.txtTransFN.Name = "txtTransFN"
        Me.txtTransFN.Size = New System.Drawing.Size(129, 20)
        Me.txtTransFN.TabIndex = 6
        '
        'txtTransStudID
        '
        Me.txtTransStudID.Location = New System.Drawing.Point(212, 27)
        Me.txtTransStudID.Name = "txtTransStudID"
        Me.txtTransStudID.Size = New System.Drawing.Size(129, 20)
        Me.txtTransStudID.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(125, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Level"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(125, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Firstname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(125, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Lastname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student ID"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvResults)
        Me.GroupBox3.Location = New System.Drawing.Point(42, 260)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(785, 231)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Results"
        '
        'dgvResults
        '
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New System.Drawing.Point(104, 67)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.Size = New System.Drawing.Size(546, 128)
        Me.dgvResults.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(726, 50)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(182, 20)
        Me.DateTimePicker1.TabIndex = 18
        '
        'btnPrintTranscript
        '
        Me.btnPrintTranscript.Location = New System.Drawing.Point(833, 391)
        Me.btnPrintTranscript.Name = "btnPrintTranscript"
        Me.btnPrintTranscript.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintTranscript.TabIndex = 19
        Me.btnPrintTranscript.Text = "Print"
        Me.btnPrintTranscript.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(834, 421)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnViewResults
        '
        Me.btnViewResults.Location = New System.Drawing.Point(834, 357)
        Me.btnViewResults.Name = "btnViewResults"
        Me.btnViewResults.Size = New System.Drawing.Size(73, 20)
        Me.btnViewResults.TabIndex = 21
        Me.btnViewResults.Text = "View Results"
        Me.btnViewResults.UseVisualStyleBackColor = True
        '
        'frmTranscript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 503)
        Me.Controls.Add(Me.btnViewResults)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnPrintTranscript)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dtpTransDate)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTranscript"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmTranscript"
        Me.dtpTransDate.ResumeLayout(False)
        Me.dtpTransDate.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtpTransDate As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTransGPA As TextBox
    Friend WithEvents txtTransLevel As TextBox
    Friend WithEvents txtTransLN As TextBox
    Friend WithEvents txtTransFN As TextBox
    Friend WithEvents txtTransStudID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTransHall As TextBox
    Friend WithEvents txtTransProg As TextBox
    Friend WithEvents txtTransDepartment As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnPrintTranscript As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents btnViewResults As Button
End Class
