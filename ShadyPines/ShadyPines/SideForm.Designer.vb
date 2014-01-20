<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SideForm
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radbutt_21MealsPerWeek = New System.Windows.Forms.RadioButton()
        Me.radbutt_14MealsPerWeek = New System.Windows.Forms.RadioButton()
        Me.radbutt_7MealsPerWeek = New System.Windows.Forms.RadioButton()
        Me.button_Confirm = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radbutt_NumPeople1 = New System.Windows.Forms.RadioButton()
        Me.radbutt_NumPeople2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radbutt_21MealsPerWeek)
        Me.GroupBox2.Controls.Add(Me.radbutt_14MealsPerWeek)
        Me.GroupBox2.Controls.Add(Me.radbutt_7MealsPerWeek)
        Me.GroupBox2.Location = New System.Drawing.Point(170, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Meal Plan"
        '
        'radbutt_21MealsPerWeek
        '
        Me.radbutt_21MealsPerWeek.AutoSize = True
        Me.radbutt_21MealsPerWeek.Location = New System.Drawing.Point(6, 65)
        Me.radbutt_21MealsPerWeek.Name = "radbutt_21MealsPerWeek"
        Me.radbutt_21MealsPerWeek.Size = New System.Drawing.Size(212, 17)
        Me.radbutt_21MealsPerWeek.TabIndex = 2
        Me.radbutt_21MealsPerWeek.TabStop = True
        Me.radbutt_21MealsPerWeek.Text = "21 meals per week - $980.00 per month"
        Me.radbutt_21MealsPerWeek.UseVisualStyleBackColor = True
        '
        'radbutt_14MealsPerWeek
        '
        Me.radbutt_14MealsPerWeek.AutoSize = True
        Me.radbutt_14MealsPerWeek.Location = New System.Drawing.Point(6, 42)
        Me.radbutt_14MealsPerWeek.Name = "radbutt_14MealsPerWeek"
        Me.radbutt_14MealsPerWeek.Size = New System.Drawing.Size(212, 17)
        Me.radbutt_14MealsPerWeek.TabIndex = 1
        Me.radbutt_14MealsPerWeek.TabStop = True
        Me.radbutt_14MealsPerWeek.Text = "14 meals per week - $710.00 per month"
        Me.radbutt_14MealsPerWeek.UseVisualStyleBackColor = True
        '
        'radbutt_7MealsPerWeek
        '
        Me.radbutt_7MealsPerWeek.AutoSize = True
        Me.radbutt_7MealsPerWeek.Checked = True
        Me.radbutt_7MealsPerWeek.Location = New System.Drawing.Point(6, 19)
        Me.radbutt_7MealsPerWeek.Name = "radbutt_7MealsPerWeek"
        Me.radbutt_7MealsPerWeek.Size = New System.Drawing.Size(209, 17)
        Me.radbutt_7MealsPerWeek.TabIndex = 0
        Me.radbutt_7MealsPerWeek.TabStop = True
        Me.radbutt_7MealsPerWeek.Text = "7 meals per week  - $400.00 per month"
        Me.radbutt_7MealsPerWeek.UseVisualStyleBackColor = True
        '
        'button_Confirm
        '
        Me.button_Confirm.Location = New System.Drawing.Point(171, 127)
        Me.button_Confirm.Name = "button_Confirm"
        Me.button_Confirm.Size = New System.Drawing.Size(75, 23)
        Me.button_Confirm.TabIndex = 3
        Me.button_Confirm.Text = "Confirm"
        Me.button_Confirm.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radbutt_NumPeople2)
        Me.GroupBox3.Controls.Add(Me.radbutt_NumPeople1)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(137, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Number of People"
        '
        'radbutt_NumPeople1
        '
        Me.radbutt_NumPeople1.AutoSize = True
        Me.radbutt_NumPeople1.Checked = True
        Me.radbutt_NumPeople1.Location = New System.Drawing.Point(3, 16)
        Me.radbutt_NumPeople1.Name = "radbutt_NumPeople1"
        Me.radbutt_NumPeople1.Size = New System.Drawing.Size(31, 17)
        Me.radbutt_NumPeople1.TabIndex = 0
        Me.radbutt_NumPeople1.TabStop = True
        Me.radbutt_NumPeople1.Text = "1"
        Me.radbutt_NumPeople1.UseVisualStyleBackColor = True
        '
        'radbutt_NumPeople2
        '
        Me.radbutt_NumPeople2.AutoSize = True
        Me.radbutt_NumPeople2.Location = New System.Drawing.Point(3, 39)
        Me.radbutt_NumPeople2.Name = "radbutt_NumPeople2"
        Me.radbutt_NumPeople2.Size = New System.Drawing.Size(31, 17)
        Me.radbutt_NumPeople2.TabIndex = 1
        Me.radbutt_NumPeople2.TabStop = True
        Me.radbutt_NumPeople2.Text = "2"
        Me.radbutt_NumPeople2.UseVisualStyleBackColor = True
        '
        'SideForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 162)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.button_Confirm)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "SideForm"
        Me.Text = "Side Form"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radbutt_21MealsPerWeek As System.Windows.Forms.RadioButton
    Friend WithEvents radbutt_14MealsPerWeek As System.Windows.Forms.RadioButton
    Friend WithEvents radbutt_7MealsPerWeek As System.Windows.Forms.RadioButton
    Friend WithEvents button_Confirm As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radbutt_NumPeople2 As System.Windows.Forms.RadioButton
    Friend WithEvents radbutt_NumPeople1 As System.Windows.Forms.RadioButton
End Class
