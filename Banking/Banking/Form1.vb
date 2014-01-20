Public Class Form1

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const baseCharge As Double = 10.0  ' The base charge per month that the bank charges
        Dim numChecks As Integer  ' The number of checks for that month
        Dim bankCharges As Double  ' The total amount that is charged (consists of base charge and additional charge depending on 
                                   ' how many checks the user enter for the month)

        ' The numChecks is assigned the value inside the textbox
        numChecks = txtbox_NumOfChecks.Text

        ' The number of checks changes the additional charge that is added to the base charge
        If numChecks < 20 Then
            bankCharges = baseCharge + (numChecks * 0.2)
        ElseIf numChecks >= 20 And numChecks <= 39 Then
            bankCharges = baseCharge + (numChecks * 0.15)
        ElseIf numChecks >= 40 And numChecks <= 59 Then
            bankCharges = baseCharge + (numChecks * 0.1)
        ElseIf numChecks >= 60 Then
            bankCharges = baseCharge + (numChecks * 0.05)
        End If
        label_DisplayCharges.Text = bankCharges.ToString("c")  ' Displays the total charge to the label
End Sub

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()  ' Closes the form
End Sub
End Class
