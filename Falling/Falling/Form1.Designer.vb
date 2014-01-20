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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbox_FallingTime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label_DisplayDistance = New System.Windows.Forms.Label()
        Me.button_Calculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Falling time (in seconds)"
        '
        'txtbox_FallingTime
        '
        Me.txtbox_FallingTime.Location = New System.Drawing.Point(187, 32)
        Me.txtbox_FallingTime.Name = "txtbox_FallingTime"
        Me.txtbox_FallingTime.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_FallingTime.TabIndex = 1
        Me.txtbox_FallingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Distance (in meters)"
        '
        'label_DisplayDistance
        '
        Me.label_DisplayDistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_DisplayDistance.Location = New System.Drawing.Point(187, 72)
        Me.label_DisplayDistance.Name = "label_DisplayDistance"
        Me.label_DisplayDistance.Size = New System.Drawing.Size(100, 23)
        Me.label_DisplayDistance.TabIndex = 3
        Me.label_DisplayDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button_Calculate
        '
        Me.button_Calculate.Location = New System.Drawing.Point(138, 127)
        Me.button_Calculate.Name = "button_Calculate"
        Me.button_Calculate.Size = New System.Drawing.Size(75, 23)
        Me.button_Calculate.TabIndex = 4
        Me.button_Calculate.Text = "Calculate"
        Me.button_Calculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 182)
        Me.Controls.Add(Me.button_Calculate)
        Me.Controls.Add(Me.label_DisplayDistance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbox_FallingTime)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Falling Distance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbox_FallingTime As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents label_DisplayDistance As System.Windows.Forms.Label
    Friend WithEvents button_Calculate As System.Windows.Forms.Button

End Class
