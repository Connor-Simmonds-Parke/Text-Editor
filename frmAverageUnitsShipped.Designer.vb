<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.AverageUnitsShippedTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblDaysDisplay = New System.Windows.Forms.Label()
        Me.lblUnitsDisplay = New System.Windows.Forms.Label()
        Me.txtUnitsInput = New System.Windows.Forms.TextBox()
        Me.lblEmployeeOneDisplay = New System.Windows.Forms.Label()
        Me.lblEmployeeTwoDisplay = New System.Windows.Forms.Label()
        Me.lblEmployeeThreeDisplay = New System.Windows.Forms.Label()
        Me.txtEmployeeOneUnitsList = New System.Windows.Forms.TextBox()
        Me.txtEmployeeTwoUnitsList = New System.Windows.Forms.TextBox()
        Me.txtEmployeeThreeUnitsList = New System.Windows.Forms.TextBox()
        Me.lblEmployeeOneAverage = New System.Windows.Forms.Label()
        Me.lblEmployeeTwoAverage = New System.Windows.Forms.Label()
        Me.lblEmployeeThreeAverage = New System.Windows.Forms.Label()
        Me.lblTotalAverage = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDaysDisplay
        '
        Me.lblDaysDisplay.Location = New System.Drawing.Point(13, 20)
        Me.lblDaysDisplay.Name = "lblDaysDisplay"
        Me.lblDaysDisplay.Size = New System.Drawing.Size(53, 23)
        Me.lblDaysDisplay.TabIndex = 5
        Me.lblDaysDisplay.Text = "Day 1"
        Me.lblDaysDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUnitsDisplay
        '
        Me.lblUnitsDisplay.Location = New System.Drawing.Point(13, 52)
        Me.lblUnitsDisplay.Name = "lblUnitsDisplay"
        Me.lblUnitsDisplay.Size = New System.Drawing.Size(53, 23)
        Me.lblUnitsDisplay.TabIndex = 0
        Me.lblUnitsDisplay.Text = "&Units:"
        Me.lblUnitsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUnitsInput
        '
        Me.txtUnitsInput.Location = New System.Drawing.Point(79, 54)
        Me.txtUnitsInput.Name = "txtUnitsInput"
        Me.txtUnitsInput.Size = New System.Drawing.Size(51, 20)
        Me.txtUnitsInput.TabIndex = 1
        Me.AverageUnitsShippedTips.SetToolTip(Me.txtUnitsInput, "Enter a whole number between 0 and 1000 for the number of units shipped for this " &
        "day.")
        '
        'lblEmployeeOneDisplay
        '
        Me.lblEmployeeOneDisplay.Location = New System.Drawing.Point(23, 90)
        Me.lblEmployeeOneDisplay.Name = "lblEmployeeOneDisplay"
        Me.lblEmployeeOneDisplay.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployeeOneDisplay.TabIndex = 6
        Me.lblEmployeeOneDisplay.Text = "Employee 1"
        Me.lblEmployeeOneDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeTwoDisplay
        '
        Me.lblEmployeeTwoDisplay.Location = New System.Drawing.Point(153, 90)
        Me.lblEmployeeTwoDisplay.Name = "lblEmployeeTwoDisplay"
        Me.lblEmployeeTwoDisplay.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployeeTwoDisplay.TabIndex = 8
        Me.lblEmployeeTwoDisplay.Text = "Employee 2"
        Me.lblEmployeeTwoDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeThreeDisplay
        '
        Me.lblEmployeeThreeDisplay.Location = New System.Drawing.Point(287, 90)
        Me.lblEmployeeThreeDisplay.Name = "lblEmployeeThreeDisplay"
        Me.lblEmployeeThreeDisplay.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployeeThreeDisplay.TabIndex = 10
        Me.lblEmployeeThreeDisplay.Text = "Employee 3"
        Me.lblEmployeeThreeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmployeeOneUnitsList
        '
        Me.txtEmployeeOneUnitsList.Location = New System.Drawing.Point(15, 116)
        Me.txtEmployeeOneUnitsList.Multiline = True
        Me.txtEmployeeOneUnitsList.Name = "txtEmployeeOneUnitsList"
        Me.txtEmployeeOneUnitsList.Size = New System.Drawing.Size(115, 120)
        Me.txtEmployeeOneUnitsList.TabIndex = 7
        Me.txtEmployeeOneUnitsList.TabStop = False
        Me.AverageUnitsShippedTips.SetToolTip(Me.txtEmployeeOneUnitsList, "Displays the units entered for employee 1.")
        '
        'txtEmployeeTwoUnitsList
        '
        Me.txtEmployeeTwoUnitsList.Location = New System.Drawing.Point(147, 116)
        Me.txtEmployeeTwoUnitsList.Multiline = True
        Me.txtEmployeeTwoUnitsList.Name = "txtEmployeeTwoUnitsList"
        Me.txtEmployeeTwoUnitsList.Size = New System.Drawing.Size(115, 120)
        Me.txtEmployeeTwoUnitsList.TabIndex = 9
        Me.txtEmployeeTwoUnitsList.TabStop = False
        Me.AverageUnitsShippedTips.SetToolTip(Me.txtEmployeeTwoUnitsList, "Displays the units entered for employee 2.")
        '
        'txtEmployeeThreeUnitsList
        '
        Me.txtEmployeeThreeUnitsList.Location = New System.Drawing.Point(281, 116)
        Me.txtEmployeeThreeUnitsList.Multiline = True
        Me.txtEmployeeThreeUnitsList.Name = "txtEmployeeThreeUnitsList"
        Me.txtEmployeeThreeUnitsList.Size = New System.Drawing.Size(115, 120)
        Me.txtEmployeeThreeUnitsList.TabIndex = 11
        Me.txtEmployeeThreeUnitsList.TabStop = False
        Me.AverageUnitsShippedTips.SetToolTip(Me.txtEmployeeThreeUnitsList, "Displays the units entered for employee 3.")
        '
        'lblEmployeeOneAverage
        '
        Me.lblEmployeeOneAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeOneAverage.Location = New System.Drawing.Point(15, 239)
        Me.lblEmployeeOneAverage.Name = "lblEmployeeOneAverage"
        Me.lblEmployeeOneAverage.Size = New System.Drawing.Size(115, 20)
        Me.lblEmployeeOneAverage.TabIndex = 9
        Me.lblEmployeeOneAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedTips.SetToolTip(Me.lblEmployeeOneAverage, "Average of units shipped for employee 1.")
        '
        'lblEmployeeTwoAverage
        '
        Me.lblEmployeeTwoAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeTwoAverage.Location = New System.Drawing.Point(147, 239)
        Me.lblEmployeeTwoAverage.Name = "lblEmployeeTwoAverage"
        Me.lblEmployeeTwoAverage.Size = New System.Drawing.Size(115, 20)
        Me.lblEmployeeTwoAverage.TabIndex = 10
        Me.lblEmployeeTwoAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedTips.SetToolTip(Me.lblEmployeeTwoAverage, "Average of units shipped for employee 2.")
        '
        'lblEmployeeThreeAverage
        '
        Me.lblEmployeeThreeAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeThreeAverage.Location = New System.Drawing.Point(281, 239)
        Me.lblEmployeeThreeAverage.Name = "lblEmployeeThreeAverage"
        Me.lblEmployeeThreeAverage.Size = New System.Drawing.Size(115, 20)
        Me.lblEmployeeThreeAverage.TabIndex = 11
        Me.lblEmployeeThreeAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedTips.SetToolTip(Me.lblEmployeeThreeAverage, "Average of units shipped for employee 3.")
        '
        'lblTotalAverage
        '
        Me.lblTotalAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAverage.Location = New System.Drawing.Point(15, 269)
        Me.lblTotalAverage.Name = "lblTotalAverage"
        Me.lblTotalAverage.Size = New System.Drawing.Size(381, 25)
        Me.lblTotalAverage.TabIndex = 12
        Me.lblTotalAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedTips.SetToolTip(Me.lblTotalAverage, "Total average units shipped for all three employees.")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(16, 299)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(114, 30)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnEnter, "Click this button to enter the units into the list. ")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(147, 299)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(115, 30)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnReset, "Click this button to reset the form to the original state.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(281, 299)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnExit, "Click this button to exit the program.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(411, 338)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblTotalAverage)
        Me.Controls.Add(Me.lblEmployeeThreeAverage)
        Me.Controls.Add(Me.lblEmployeeTwoAverage)
        Me.Controls.Add(Me.lblEmployeeOneAverage)
        Me.Controls.Add(Me.txtEmployeeThreeUnitsList)
        Me.Controls.Add(Me.txtEmployeeTwoUnitsList)
        Me.Controls.Add(Me.txtEmployeeOneUnitsList)
        Me.Controls.Add(Me.lblEmployeeThreeDisplay)
        Me.Controls.Add(Me.lblEmployeeTwoDisplay)
        Me.Controls.Add(Me.lblEmployeeOneDisplay)
        Me.Controls.Add(Me.txtUnitsInput)
        Me.Controls.Add(Me.lblUnitsDisplay)
        Me.Controls.Add(Me.lblDaysDisplay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AverageUnitsShippedTips As ToolTip
    Friend WithEvents lblDaysDisplay As Label
    Friend WithEvents lblUnitsDisplay As Label
    Friend WithEvents txtUnitsInput As TextBox
    Friend WithEvents lblEmployeeOneDisplay As Label
    Friend WithEvents lblEmployeeTwoDisplay As Label
    Friend WithEvents lblEmployeeThreeDisplay As Label
    Friend WithEvents txtEmployeeOneUnitsList As TextBox
    Friend WithEvents txtEmployeeTwoUnitsList As TextBox
    Friend WithEvents txtEmployeeThreeUnitsList As TextBox
    Friend WithEvents lblEmployeeOneAverage As Label
    Friend WithEvents lblEmployeeTwoAverage As Label
    Friend WithEvents lblEmployeeThreeAverage As Label
    Friend WithEvents lblTotalAverage As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
