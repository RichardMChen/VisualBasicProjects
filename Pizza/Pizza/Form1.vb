' Name: Richard Chen

Public Class Form1
    Const pi As Double = 3.14159  ' The constant of pi used for the calculation

    Private Sub buttonCalculate_Click(sender As Object, e As EventArgs) Handles buttonCalculate.Click
        Dim diameter As Integer  ' Variable to hold the diameter
        Dim numSlices As Integer  ' The number os slices of pizza
        Dim area As Double  ' The area

        diameter = CInt(textBoxGetDiameter.Text)  ' Get the diameter from the text box
        area = pi * ((diameter / 2) * (diameter / 2))  ' Calculates the area. area = pi * r ^ 2
        numSlices = area / 14.125  ' Divides the area by 14.125 to get the number of slices on the pizza
        labelShowNumSlices.Text = numSlices  ' Displays the number of slices in the label
    End Sub

    Private Sub buttonExit_Click(sender As Object, e As EventArgs) Handles buttonExit.Click
        Me.Close()  ' Closes the form
    End Sub
End Class
