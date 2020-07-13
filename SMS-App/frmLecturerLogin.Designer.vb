<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLecturerLogin
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtlectId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSchName = New System.Windows.Forms.Label()
        Me.btnCancelHall = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancelHall)
        Me.GroupBox1.Controls.Add(Me.txtlectId)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Location = New System.Drawing.Point(150, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 151)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'txtlectId
        '
        Me.txtlectId.Location = New System.Drawing.Point(148, 32)
        Me.txtlectId.Name = "txtlectId"
        Me.txtlectId.Size = New System.Drawing.Size(279, 20)
        Me.txtlectId.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Password"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(225, 122)
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
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Id"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(148, 75)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(279, 20)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.Tag = "Student Pin"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(250, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 37)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Lecturer Login"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.lblSchName.Size = New System.Drawing.Size(800, 70)
        Me.lblSchName.TabIndex = 8
        Me.lblSchName.Text = "Lecturer Login"
        Me.lblSchName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelHall
        '
        Me.btnCancelHall.Location = New System.Drawing.Point(318, 122)
        Me.btnCancelHall.Name = "btnCancelHall"
        Me.btnCancelHall.Size = New System.Drawing.Size(109, 23)
        Me.btnCancelHall.TabIndex = 10
        Me.btnCancelHall.Text = "Back"
        Me.btnCancelHall.UseVisualStyleBackColor = True
        '
        'frmLecturerLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSchName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLecturerLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLecturerLogin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtlectId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSchName As Label
    Friend WithEvents btnCancelHall As Button
End Class
