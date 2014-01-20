Public Class SideForm

Private Sub button_Confirm_Click(sender As Object, e As EventArgs) Handles button_Confirm.Click
    Dim form_MainForm As New MainForm       'Creates and instance of the MainForm

    'Checks to which number of people radio buttons were selected
    'and to check which meal plan was selected and multiply by 2 if
    '2 people were selected
    If radbutt_NumPeople1.Checked = True Then
        If radbutt_7MealsPerWeek.Checked = True Then
            totalCharge += 400.0
        ElseIf radbutt_14MealsPerWeek.Checked = True Then
            totalCharge += 710.0
        ElseIf radbutt_21MealsPerWeek.Checked = True Then
            totalCharge += 980.0
        End If
    ElseIf radbutt_NumPeople2.Checked = True Then
        If radbutt_7MealsPerWeek.Checked = True Then
            totalCharge += 400.0 * 2
        ElseIf radbutt_14MealsPerWeek.Checked = True Then
            totalCharge += 710.0 * 2
        ElseIf radbutt_21MealsPerWeek.Checked = True Then
            totalCharge += 980.0 * 2
        End If
    End If

    'Adds on to the total charges and closes the form when the Confirm button is pressed
    Me.Close()
End Sub
End Class