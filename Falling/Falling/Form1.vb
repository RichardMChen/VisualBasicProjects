'Name: Richard Chen
Public Class Form1
    Function FallingDistance(ByVal time As Double) As Double
        Const GRAVITY As Double = 9.8   'A constant for the acceleration of gravity
        Dim distance As Double          'The distance which is equal to 0.5 * GRAVITY * (time ^ 2)

        distance = 0.5 * GRAVITY * (time ^ 2)   'The distance formula
        Return distance
    End Function

Private Sub button_Calculate_Click(sender As Object, e As EventArgs) Handles button_Calculate.Click
    Dim distance As Double
    distance = FallingDistance(CDbl(txtbox_FallingTime.Text))   'Distance set to the value returned from FallingDistance function
    label_DisplayDistance.Text = distance                       'Displays the distance to a label
End Sub
End Class
