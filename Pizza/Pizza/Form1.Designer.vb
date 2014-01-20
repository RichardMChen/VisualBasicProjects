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
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.labelGetDiameter = New System.Windows.Forms.Label()
        Me.textBoxGetDiameter = New System.Windows.Forms.TextBox()
        Me.labelNumberOfSlices = New System.Windows.Forms.Label()
        Me.labelShowNumSlices = New System.Windows.Forms.Label()
        Me.buttonCalculate = New System.Windows.Forms.Button()
        Me.buttonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelTitle
        '
        Me.labelTitle.AutoSize = True
        Me.labelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.Location = New System.Drawing.Point(70, 20)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(259, 31)
        Me.labelTitle.TabIndex = 0
        Me.labelTitle.Text = "Joe's Pizza Palace"
        '
        'labelGetDiameter
        '
        Me.labelGetDiameter.Location = New System.Drawing.Point(21, 80)
        Me.labelGetDiameter.Name = "labelGetDiameter"
        Me.labelGetDiameter.Size = New System.Drawing.Size(202, 29)
        Me.labelGetDiameter.TabIndex = 1
        Me.labelGetDiameter.Text = "Enter the diameter of the pizza in inches"
        '
        'textBoxGetDiameter
        '
        Me.textBoxGetDiameter.Location = New System.Drawing.Point(242, 77)
        Me.textBoxGetDiameter.Name = "textBoxGetDiameter"
        Me.textBoxGetDiameter.Size = New System.Drawing.Size(100, 20)
        Me.textBoxGetDiameter.TabIndex = 2
        Me.textBoxGetDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelNumberOfSlices
        '
        Me.labelNumberOfSlices.AutoSize = True
        Me.labelNumberOfSlices.Location = New System.Drawing.Point(125, 137)
        Me.labelNumberOfSlices.Name = "labelNumberOfSlices"
        Me.labelNumberOfSlices.Size = New System.Drawing.Size(85, 13)
        Me.labelNumberOfSlices.TabIndex = 3
        Me.labelNumberOfSlices.Text = "Number of slices"
        '
        'labelShowNumSlices
        '
        Me.labelShowNumSlices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelShowNumSlices.Location = New System.Drawing.Point(242, 127)
        Me.labelShowNumSlices.Name = "labelShowNumSlices"
        Me.labelShowNumSlices.Size = New System.Drawing.Size(100, 23)
        Me.labelShowNumSlices.TabIndex = 4
        Me.labelShowNumSlices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'buttonCalculate
        '
        Me.buttonCalculate.Location = New System.Drawing.Point(76, 187)
        Me.buttonCalculate.Name = "buttonCalculate"
        Me.buttonCalculate.Size = New System.Drawing.Size(75, 23)
        Me.buttonCalculate.TabIndex = 5
        Me.buttonCalculate.Text = "Calculate"
        Me.buttonCalculate.UseVisualStyleBackColor = True
        '
        'buttonExit
        '
        Me.buttonExit.Location = New System.Drawing.Point(254, 187)
        Me.buttonExit.Name = "buttonExit"
        Me.buttonExit.Size = New System.Drawing.Size(75, 23)
        Me.buttonExit.TabIndex = 6
        Me.buttonExit.Text = "Exit"
        Me.buttonExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 236)
        Me.Controls.Add(Me.buttonExit)
        Me.Controls.Add(Me.buttonCalculate)
        Me.Controls.Add(Me.labelShowNumSlices)
        Me.Controls.Add(Me.labelNumberOfSlices)
        Me.Controls.Add(Me.textBoxGetDiameter)
        Me.Controls.Add(Me.labelGetDiameter)
        Me.Controls.Add(Me.labelTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelTitle As System.Windows.Forms.Label
    Friend WithEvents labelGetDiameter As System.Windows.Forms.Label
    Friend WithEvents textBoxGetDiameter As System.Windows.Forms.TextBox
    Friend WithEvents labelNumberOfSlices As System.Windows.Forms.Label
    Friend WithEvents labelShowNumSlices As System.Windows.Forms.Label
    Friend WithEvents buttonCalculate As System.Windows.Forms.Button
    Friend WithEvents buttonExit As System.Windows.Forms.Button

End Class
