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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label_Charges = New System.Windows.Forms.Label()
        Me.label_DisplayCharges = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtbox_NumOfChecks = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("AR BLANCA", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rob Easy National Bank"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of checks for the month:"
        '
        'label_Charges
        '
        Me.label_Charges.AutoSize = True
        Me.label_Charges.Location = New System.Drawing.Point(151, 132)
        Me.label_Charges.Name = "label_Charges"
        Me.label_Charges.Size = New System.Drawing.Size(49, 13)
        Me.label_Charges.TabIndex = 2
        Me.label_Charges.Text = "Charges:"
        '
        'label_DisplayCharges
        '
        Me.label_DisplayCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_DisplayCharges.Location = New System.Drawing.Point(218, 131)
        Me.label_DisplayCharges.Name = "label_DisplayCharges"
        Me.label_DisplayCharges.Size = New System.Drawing.Size(100, 23)
        Me.label_DisplayCharges.TabIndex = 4
        Me.label_DisplayCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtbox_NumOfChecks
        '
        Me.txtbox_NumOfChecks.Location = New System.Drawing.Point(218, 103)
        Me.txtbox_NumOfChecks.Name = "txtbox_NumOfChecks"
        Me.txtbox_NumOfChecks.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_NumOfChecks.TabIndex = 6
        Me.txtbox_NumOfChecks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(218, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 232)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtbox_NumOfChecks)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.label_DisplayCharges)
        Me.Controls.Add(Me.label_Charges)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents label_Charges As System.Windows.Forms.Label
    Friend WithEvents label_DisplayCharges As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtbox_NumOfChecks As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
