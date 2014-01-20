' Name: Richard Chen
Public Class MainForm
Private Sub button_Calculate_Click(sender As Object, e As EventArgs) Handles button_Calculate.Click

    Dim form_SideForm As New SideForm       'Creates an instance of the SideForm
    totalCharge = 0                         'Hold the total charges
    form_SideForm.ShowDialog()              'Shows the Side Form

    'Checks to see which of the apartment radio buttons are selected
    If radbutt_EmpireApt.Checked = True Then
        totalCharge += 1500.0
    ElseIf radbutt_ItalianateApt.Checked = True Then
        totalCharge += 1650.0
    ElseIf radbutt_CharlestownApt.Checked = True Then
        totalCharge += 1900.0
    ElseIf radbutt_RegencyApt.Checked = True Then
        totalCharge += 2000.0
    End If

    'Displays the total charge as a currency in the label
    label_TotalCharge.Text = totalCharge.ToString("c")
End Sub

Private Sub button_Clear_Click(sender As Object, e As EventArgs) Handles button_Clear.Click
    'Clears the label and resets the radio button on to the Empire Apartments
    label_TotalCharge.Text = String.Empty
    radbutt_EmpireApt.Checked = True
End Sub

Private Sub button_Exit_Click(sender As Object, e As EventArgs) Handles button_Exit.Click
    'Closes the form
    Me.Close()
End Sub

End Class
