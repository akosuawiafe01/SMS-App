<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHall
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtHallCollege = New System.Windows.Forms.TextBox()
        Me.txtHallLevl = New System.Windows.Forms.TextBox()
        Me.txtHallON = New System.Windows.Forms.TextBox()
        Me.txtHallFN = New System.Windows.Forms.TextBox()
        Me.txtHallLN = New System.Windows.Forms.TextBox()
        Me.txtHallStudID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbAcaYear = New System.Windows.Forms.ComboBox()
        Me.cmbRoomNo = New System.Windows.Forms.ComboBox()
        Me.cmbHallName = New System.Windows.Forms.ComboBox()
        Me.HallBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMS_DataSet = New SMS_App.SMS_DataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelHall = New System.Windows.Forms.Button()
        Me.btnHallUpdate = New System.Windows.Forms.Button()
        Me.btnHallSave = New System.Windows.Forms.Button()
        Me.HallTableAdapter = New SMS_App.SMS_DataSetTableAdapters.HallTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.HallBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(903, 106)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WAN College"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(151, 83)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(57, 148)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.SplitContainer1.Panel1.Controls.Add(Me.Splitter1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtHallCollege)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtHallLevl)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtHallON)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtHallFN)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtHallLN)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtHallStudID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbAcaYear)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbRoomNo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbHallName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Size = New System.Drawing.Size(728, 268)
        Me.SplitContainer1.SplitterDistance = 363
        Me.SplitContainer1.TabIndex = 4
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 268)
        Me.Splitter1.TabIndex = 12
        Me.Splitter1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Info
        Me.Label11.Location = New System.Drawing.Point(36, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Level"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Info
        Me.Label10.Location = New System.Drawing.Point(36, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "College"
        '
        'txtHallCollege
        '
        Me.txtHallCollege.Location = New System.Drawing.Point(134, 175)
        Me.txtHallCollege.Name = "txtHallCollege"
        Me.txtHallCollege.Size = New System.Drawing.Size(140, 20)
        Me.txtHallCollege.TabIndex = 9
        '
        'txtHallLevl
        '
        Me.txtHallLevl.Location = New System.Drawing.Point(132, 217)
        Me.txtHallLevl.Name = "txtHallLevl"
        Me.txtHallLevl.Size = New System.Drawing.Size(142, 20)
        Me.txtHallLevl.TabIndex = 8
        '
        'txtHallON
        '
        Me.txtHallON.Location = New System.Drawing.Point(132, 131)
        Me.txtHallON.Name = "txtHallON"
        Me.txtHallON.Size = New System.Drawing.Size(142, 20)
        Me.txtHallON.TabIndex = 7
        '
        'txtHallFN
        '
        Me.txtHallFN.Location = New System.Drawing.Point(132, 100)
        Me.txtHallFN.Name = "txtHallFN"
        Me.txtHallFN.Size = New System.Drawing.Size(142, 20)
        Me.txtHallFN.TabIndex = 6
        '
        'txtHallLN
        '
        Me.txtHallLN.Location = New System.Drawing.Point(133, 65)
        Me.txtHallLN.Name = "txtHallLN"
        Me.txtHallLN.Size = New System.Drawing.Size(141, 20)
        Me.txtHallLN.TabIndex = 5
        '
        'txtHallStudID
        '
        Me.txtHallStudID.Location = New System.Drawing.Point(134, 36)
        Me.txtHallStudID.Name = "txtHallStudID"
        Me.txtHallStudID.Size = New System.Drawing.Size(140, 20)
        Me.txtHallStudID.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Info
        Me.Label9.Location = New System.Drawing.Point(36, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Other Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Info
        Me.Label8.Location = New System.Drawing.Point(36, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "First Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Info
        Me.Label7.Location = New System.Drawing.Point(36, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Info
        Me.Label6.Location = New System.Drawing.Point(36, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Student ID"
        '
        'cmbAcaYear
        '
        Me.cmbAcaYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAcaYear.FormattingEnabled = True
        Me.cmbAcaYear.Items.AddRange(New Object() {"2016/2017", "2017/2018", "2018/2019", "2019/2020", "2020/2021", "2021/2022", "2022/2023", "2023/2024", "2024/2025"})
        Me.cmbAcaYear.Location = New System.Drawing.Point(160, 156)
        Me.cmbAcaYear.Name = "cmbAcaYear"
        Me.cmbAcaYear.Size = New System.Drawing.Size(150, 21)
        Me.cmbAcaYear.TabIndex = 5
        '
        'cmbRoomNo
        '
        Me.cmbRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRoomNo.FormattingEnabled = True
        Me.cmbRoomNo.Items.AddRange(New Object() {"101", "UG_102", "UG_103", "UG_104", "105"})
        Me.cmbRoomNo.Location = New System.Drawing.Point(160, 102)
        Me.cmbRoomNo.Name = "cmbRoomNo"
        Me.cmbRoomNo.Size = New System.Drawing.Size(150, 21)
        Me.cmbRoomNo.TabIndex = 4
        '
        'cmbHallName
        '
        Me.cmbHallName.DataSource = Me.HallBindingSource
        Me.cmbHallName.DisplayMember = "hallName"
        Me.cmbHallName.FormattingEnabled = True
        Me.cmbHallName.Location = New System.Drawing.Point(160, 44)
        Me.cmbHallName.Name = "cmbHallName"
        Me.cmbHallName.Size = New System.Drawing.Size(150, 21)
        Me.cmbHallName.TabIndex = 3
        Me.cmbHallName.ValueMember = "hall_ID"
        '
        'HallBindingSource
        '
        Me.HallBindingSource.DataMember = "Hall"
        Me.HallBindingSource.DataSource = Me.SMS_DataSet
        '
        'SMS_DataSet
        '
        Me.SMS_DataSet.DataSetName = "SMS_DataSet"
        Me.SMS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Room Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Academic Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hall"
        '
        'btnCancelHall
        '
        Me.btnCancelHall.Location = New System.Drawing.Point(660, 438)
        Me.btnCancelHall.Name = "btnCancelHall"
        Me.btnCancelHall.Size = New System.Drawing.Size(109, 23)
        Me.btnCancelHall.TabIndex = 5
        Me.btnCancelHall.Text = "Cancel"
        Me.btnCancelHall.UseVisualStyleBackColor = True
        '
        'btnHallUpdate
        '
        Me.btnHallUpdate.Location = New System.Drawing.Point(527, 438)
        Me.btnHallUpdate.Name = "btnHallUpdate"
        Me.btnHallUpdate.Size = New System.Drawing.Size(86, 22)
        Me.btnHallUpdate.TabIndex = 6
        Me.btnHallUpdate.Text = "Update"
        Me.btnHallUpdate.UseVisualStyleBackColor = True
        '
        'btnHallSave
        '
        Me.btnHallSave.Location = New System.Drawing.Point(398, 438)
        Me.btnHallSave.Name = "btnHallSave"
        Me.btnHallSave.Size = New System.Drawing.Size(76, 22)
        Me.btnHallSave.TabIndex = 7
        Me.btnHallSave.Text = "Save"
        Me.btnHallSave.UseVisualStyleBackColor = True
        '
        'HallTableAdapter
        '
        Me.HallTableAdapter.ClearBeforeFill = True
        '
        'frmHall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnHallSave)
        Me.Controls.Add(Me.btnHallUpdate)
        Me.Controls.Add(Me.btnCancelHall)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimizeBox = False
        Me.Name = "frmHall"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHall"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.HallBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMS_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbAcaYear As ComboBox
    Friend WithEvents cmbRoomNo As ComboBox
    Friend WithEvents cmbHallName As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCancelHall As Button
    Friend WithEvents btnHallUpdate As Button
    Friend WithEvents btnHallSave As Button
    Friend WithEvents txtHallCollege As TextBox
    Friend WithEvents txtHallLevl As TextBox
    Friend WithEvents txtHallON As TextBox
    Friend WithEvents txtHallFN As TextBox
    Friend WithEvents txtHallLN As TextBox
    Friend WithEvents txtHallStudID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents SMS_DataSet As SMS_DataSet
    Friend WithEvents HallBindingSource As BindingSource
    Friend WithEvents HallTableAdapter As SMS_DataSetTableAdapters.HallTableAdapter
End Class
