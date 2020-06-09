<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.lblSchName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRegisterStudent = New System.Windows.Forms.Label()
        Me.txtStudID = New System.Windows.Forms.TextBox()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSchName
        '
        Me.lblSchName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblSchName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSchName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSchName.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchName.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblSchName.Location = New System.Drawing.Point(0, 0)
        Me.lblSchName.Name = "lblSchName"
        Me.lblSchName.Size = New System.Drawing.Size(1202, 70)
        Me.lblSchName.TabIndex = 0
        Me.lblSchName.Text = "University of Ghana"
        Me.lblSchName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(273, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student's Management System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRegisterStudent
        '
        Me.lblRegisterStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRegisterStudent.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblRegisterStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRegisterStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterStudent.ForeColor = System.Drawing.Color.Navy
        Me.lblRegisterStudent.Location = New System.Drawing.Point(402, 471)
        Me.lblRegisterStudent.Name = "lblRegisterStudent"
        Me.lblRegisterStudent.Size = New System.Drawing.Size(800, 28)
        Me.lblRegisterStudent.TabIndex = 3
        Me.lblRegisterStudent.Text = "Register here"
        Me.lblRegisterStudent.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txtStudID
        '
        Me.txtStudID.Location = New System.Drawing.Point(148, 32)
        Me.txtStudID.Name = "txtStudID"
        Me.txtStudID.Size = New System.Drawing.Size(279, 20)
        Me.txtStudID.TabIndex = 4
        '
        'txtPin
        '
        Me.txtPin.Location = New System.Drawing.Point(148, 75)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPin.Size = New System.Drawing.Size(279, 20)
        Me.txtPin.TabIndex = 5
        Me.txtPin.Tag = "Student Pin"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPin)
        Me.GroupBox1.Controls.Add(Me.txtStudID)
        Me.GroupBox1.Location = New System.Drawing.Point(233, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 151)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Pin"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(364, 122)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Student Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(658, 436)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "New Student?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(658, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Lecturer"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 499)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblRegisterStudent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSchName)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSchName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRegisterStudent As Label
    Friend WithEvents txtStudID As TextBox
    Friend WithEvents txtPin As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
