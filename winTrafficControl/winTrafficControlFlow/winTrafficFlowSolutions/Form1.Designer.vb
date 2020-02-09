<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainScene

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainScene))
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.btnTotalTrafficflow = New System.Windows.Forms.Button()
        Me.btnDirection = New System.Windows.Forms.Button()
        Me.btnPercentageOfVehicleType = New System.Windows.Forms.Button()
        Me.txtTotalTrafficflow = New System.Windows.Forms.TextBox()
        Me.txtDirection = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblVehicleCounts = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(44, 82)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(216, 20)
        Me.dtpStartDate.TabIndex = 0
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(44, 34)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(216, 20)
        Me.dtpEndDate.TabIndex = 1
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(95, 18)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(136, 13)
        Me.lblStartDate.TabIndex = 2
        Me.lblStartDate.Text = "Please select a Start Date -"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(92, 66)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(139, 13)
        Me.lblEndDate.TabIndex = 3
        Me.lblEndDate.Text = "Please select an End Date -"
        '
        'btnTotalTrafficflow
        '
        Me.btnTotalTrafficflow.Location = New System.Drawing.Point(-3, 131)
        Me.btnTotalTrafficflow.Name = "btnTotalTrafficflow"
        Me.btnTotalTrafficflow.Size = New System.Drawing.Size(149, 23)
        Me.btnTotalTrafficflow.TabIndex = 5
        Me.btnTotalTrafficflow.Text = "Total Trafficflow"
        Me.btnTotalTrafficflow.UseVisualStyleBackColor = True
        '
        'btnDirection
        '
        Me.btnDirection.Location = New System.Drawing.Point(173, 131)
        Me.btnDirection.Name = "btnDirection"
        Me.btnDirection.Size = New System.Drawing.Size(149, 23)
        Me.btnDirection.TabIndex = 6
        Me.btnDirection.Text = "Direction"
        Me.btnDirection.UseVisualStyleBackColor = True
        '
        'btnPercentageOfVehicleType
        '
        Me.btnPercentageOfVehicleType.Location = New System.Drawing.Point(82, 199)
        Me.btnPercentageOfVehicleType.Name = "btnPercentageOfVehicleType"
        Me.btnPercentageOfVehicleType.Size = New System.Drawing.Size(149, 25)
        Me.btnPercentageOfVehicleType.TabIndex = 8
        Me.btnPercentageOfVehicleType.Text = "Number Of Vehicle Types"
        Me.btnPercentageOfVehicleType.UseVisualStyleBackColor = True
        '
        'txtTotalTrafficflow
        '
        Me.txtTotalTrafficflow.Location = New System.Drawing.Point(12, 160)
        Me.txtTotalTrafficflow.Name = "txtTotalTrafficflow"
        Me.txtTotalTrafficflow.ReadOnly = True
        Me.txtTotalTrafficflow.Size = New System.Drawing.Size(119, 20)
        Me.txtTotalTrafficflow.TabIndex = 9
        '
        'txtDirection
        '
        Me.txtDirection.Location = New System.Drawing.Point(191, 160)
        Me.txtDirection.Name = "txtDirection"
        Me.txtDirection.ReadOnly = True
        Me.txtDirection.Size = New System.Drawing.Size(119, 20)
        Me.txtDirection.TabIndex = 10
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(31, 301)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblVehicleCounts
        '
        Me.lblVehicleCounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVehicleCounts.Location = New System.Drawing.Point(106, 227)
        Me.lblVehicleCounts.Name = "lblVehicleCounts"
        Me.lblVehicleCounts.Size = New System.Drawing.Size(100, 60)
        Me.lblVehicleCounts.TabIndex = 16
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(191, 301)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'mainScene
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 347)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblVehicleCounts)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtDirection)
        Me.Controls.Add(Me.txtTotalTrafficflow)
        Me.Controls.Add(Me.btnPercentageOfVehicleType)
        Me.Controls.Add(Me.btnDirection)
        Me.Controls.Add(Me.btnTotalTrafficflow)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainScene"
        Me.Text = "Total Traffic Flow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents btnTotalTrafficflow As System.Windows.Forms.Button
    Friend WithEvents btnDirection As System.Windows.Forms.Button
    Friend WithEvents btnPercentageOfVehicleType As System.Windows.Forms.Button
    Friend WithEvents txtTotalTrafficflow As System.Windows.Forms.TextBox
    Friend WithEvents txtDirection As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblVehicleCounts As System.Windows.Forms.Label
    Friend WithEvents btnSave As Button
End Class

