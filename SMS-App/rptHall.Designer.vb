<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptHall
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SMS_DataSet = New SMS_App.SMS_DataSet()
        Me.HallBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HallTableAdapter = New SMS_App.SMS_DataSetTableAdapters.HallTableAdapter()
        Me.HallIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HallNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HallTutorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcaYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HallBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HallIDDataGridViewTextBoxColumn, Me.HallNameDataGridViewTextBoxColumn, Me.HallTutorDataGridViewTextBoxColumn, Me.RoomNoDataGridViewTextBoxColumn, Me.RegDateDataGridViewTextBoxColumn, Me.AcaYearDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HallBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(32, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(752, 382)
        Me.DataGridView1.TabIndex = 0
        '
        'SMS_DataSet
        '
        Me.SMS_DataSet.DataSetName = "SMS_DataSet"
        Me.SMS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HallBindingSource
        '
        Me.HallBindingSource.DataMember = "Hall"
        Me.HallBindingSource.DataSource = Me.SMS_DataSet
        '
        'HallTableAdapter
        '
        Me.HallTableAdapter.ClearBeforeFill = True
        '
        'HallIDDataGridViewTextBoxColumn
        '
        Me.HallIDDataGridViewTextBoxColumn.DataPropertyName = "hall_ID"
        Me.HallIDDataGridViewTextBoxColumn.HeaderText = "hall_ID"
        Me.HallIDDataGridViewTextBoxColumn.Name = "HallIDDataGridViewTextBoxColumn"
        '
        'HallNameDataGridViewTextBoxColumn
        '
        Me.HallNameDataGridViewTextBoxColumn.DataPropertyName = "hallName"
        Me.HallNameDataGridViewTextBoxColumn.HeaderText = "hallName"
        Me.HallNameDataGridViewTextBoxColumn.Name = "HallNameDataGridViewTextBoxColumn"
        '
        'HallTutorDataGridViewTextBoxColumn
        '
        Me.HallTutorDataGridViewTextBoxColumn.DataPropertyName = "hall_Tutor"
        Me.HallTutorDataGridViewTextBoxColumn.HeaderText = "hall_Tutor"
        Me.HallTutorDataGridViewTextBoxColumn.Name = "HallTutorDataGridViewTextBoxColumn"
        '
        'RoomNoDataGridViewTextBoxColumn
        '
        Me.RoomNoDataGridViewTextBoxColumn.DataPropertyName = "roomNo"
        Me.RoomNoDataGridViewTextBoxColumn.HeaderText = "roomNo"
        Me.RoomNoDataGridViewTextBoxColumn.Name = "RoomNoDataGridViewTextBoxColumn"
        '
        'RegDateDataGridViewTextBoxColumn
        '
        Me.RegDateDataGridViewTextBoxColumn.DataPropertyName = "RegDate"
        Me.RegDateDataGridViewTextBoxColumn.HeaderText = "RegDate"
        Me.RegDateDataGridViewTextBoxColumn.Name = "RegDateDataGridViewTextBoxColumn"
        '
        'AcaYearDataGridViewTextBoxColumn
        '
        Me.AcaYearDataGridViewTextBoxColumn.DataPropertyName = "acaYear"
        Me.AcaYearDataGridViewTextBoxColumn.HeaderText = "acaYear"
        Me.AcaYearDataGridViewTextBoxColumn.Name = "AcaYearDataGridViewTextBoxColumn"
        '
        'rptHall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "rptHall"
        Me.Text = "rptHall"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMS_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HallBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SMS_DataSet As SMS_DataSet
    Friend WithEvents HallBindingSource As BindingSource
    Friend WithEvents HallTableAdapter As SMS_DataSetTableAdapters.HallTableAdapter
    Friend WithEvents HallIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HallNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HallTutorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcaYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
