<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radbutt_RegencyApt = New System.Windows.Forms.RadioButton()
        Me.radbutt_CharlestownApt = New System.Windows.Forms.RadioButton()
        Me.radbutt_ItalianateApt = New System.Windows.Forms.RadioButton()
        Me.radbutt_EmpireApt = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label_TotalCharge = New System.Windows.Forms.Label()
        Me.button_Calculate = New System.Windows.Forms.Button()
        Me.button_Clear = New System.Windows.Forms.Button()
        Me.button_Exit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Shady Pines Retirement Villiage"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radbutt_RegencyApt)
        Me.GroupBox1.Controls.Add(Me.radbutt_CharlestownApt)
        Me.GroupBox1.Controls.Add(Me.radbutt_ItalianateApt)
        Me.GroupBox1.Controls.Add(Me.radbutt_EmpireApt)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 118)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Apartment Tyoe"
        '
        'radbutt_RegencyApt
        '
        Me.radbutt_RegencyApt.AutoSize = True
        Me.radbutt_RegencyApt.Location = New System.Drawing.Point(6, 88)
        Me.radbutt_RegencyApt.Name = "radbutt_RegencyApt"
        Me.radbutt_RegencyApt.Size = New System.Drawing.Size(229, 17)
        Me.radbutt_RegencyApt.TabIndex = 3
        Me.radbutt_RegencyApt.TabStop = True
        Me.radbutt_RegencyApt.Text = "Regency Apartment - $ 2,000.00 per month"
        Me.radbutt_RegencyApt.UseVisualStyleBackColor = True
        '
        'radbutt_CharlestownApt
        '
        Me.radbutt_CharlestownApt.AutoSize = True
        Me.radbutt_CharlestownApt.Location = New System.Drawing.Point(6, 65)
        Me.radbutt_CharlestownApt.Name = "radbutt_CharlestownApt"
        Me.radbutt_CharlestownApt.Size = New System.Drawing.Size(244, 17)
        Me.radbutt_CharlestownApt.TabIndex = 2
        Me.radbutt_CharlestownApt.TabStop = True
        Me.radbutt_CharlestownApt.Text = "Charlestown Apartment - $ 1,900.00 per month"
        Me.radbutt_CharlestownApt.UseVisualStyleBackColor = True
        '
        'radbutt_ItalianateApt
        '
        Me.radbutt_ItalianateApt.AutoSize = True
        Me.radbutt_ItalianateApt.Location = New System.Drawing.Point(6, 42)
        Me.radbutt_ItalianateApt.Name = "radbutt_ItalianateApt"
        Me.radbutt_ItalianateApt.Size = New System.Drawing.Size(226, 17)
        Me.radbutt_ItalianateApt.TabIndex = 1
        Me.radbutt_ItalianateApt.Text = "Italianate Apartment - $1,650.00 per month"
        Me.radbutt_ItalianateApt.UseVisualStyleBackColor = True
        '
        'radbutt_EmpireApt
        '
        Me.radbutt_EmpireApt.AutoSize = True
        Me.radbutt_EmpireApt.Checked = True
        Me.radbutt_EmpireApt.Location = New System.Drawing.Point(6, 19)
        Me.radbutt_EmpireApt.Name = "radbutt_EmpireApt"
        Me.radbutt_EmpireApt.Size = New System.Drawing.Size(215, 17)
        Me.radbutt_EmpireApt.TabIndex = 0
        Me.radbutt_EmpireApt.TabStop = True
        Me.radbutt_EmpireApt.Text = "Empire Apartment - $1,500.00 per month"
        Me.radbutt_EmpireApt.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total Charge"
        '
        'label_TotalCharge
        '
        Me.label_TotalCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_TotalCharge.Location = New System.Drawing.Point(111, 195)
        Me.label_TotalCharge.Name = "label_TotalCharge"
        Me.label_TotalCharge.Size = New System.Drawing.Size(100, 23)
        Me.label_TotalCharge.TabIndex = 3
        Me.label_TotalCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button_Calculate
        '
        Me.button_Calculate.Location = New System.Drawing.Point(32, 245)
        Me.button_Calculate.Name = "button_Calculate"
        Me.button_Calculate.Size = New System.Drawing.Size(75, 23)
        Me.button_Calculate.TabIndex = 4
        Me.button_Calculate.Text = "Calculate"
        Me.button_Calculate.UseVisualStyleBackColor = True
        '
        'button_Clear
        '
        Me.button_Clear.Location = New System.Drawing.Point(122, 245)
        Me.button_Clear.Name = "button_Clear"
        Me.button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.button_Clear.TabIndex = 5
        Me.button_Clear.Text = "Clear"
        Me.button_Clear.UseVisualStyleBackColor = True
        '
        'button_Exit
        '
        Me.button_Exit.Location = New System.Drawing.Point(214, 245)
        Me.button_Exit.Name = "button_Exit"
        Me.button_Exit.Size = New System.Drawing.Size(75, 23)
        Me.button_Exit.TabIndex = 6
        Me.button_Exit.Text = "Exit"
        Me.button_Exit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "per month"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 288)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.button_Exit)
        Me.Controls.Add(Me.button_Clear)
        Me.Controls.Add(Me.button_Calculate)
        Me.Controls.Add(Me.label_TotalCharge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.Text = "Shady Pines"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radbutt_EmpireApt As System.Windows.Forms.RadioButton
    Friend WithEvents radbutt_RegencyApt As System.Windows.Forms.RadioButton
    Friend WithEvents radbutt_CharlestownApt As System.Windows.Forms.RadioButton
    Friend WithEvents radbutt_ItalianateApt As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents label_TotalCharge As System.Windows.Forms.Label
    Friend WithEvents button_Calculate As System.Windows.Forms.Button
    Friend WithEvents button_Clear As System.Windows.Forms.Button
    Friend WithEvents button_Exit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
