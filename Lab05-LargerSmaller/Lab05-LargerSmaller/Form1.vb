Public Class Form1
    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        Dim intAValue As Integer
        Dim intBValue As Integer

        If Integer.TryParse(txtA.Text, intAValue) Then
            If Integer.TryParse(txtB.Text, intBValue) Then
                If intAValue < intBValue Then
                    lblOutput.Text = "Value B is greatest."
                ElseIf intAValue > intBValue Then
                    lblOutput.Text = "Value A is greatest."
                ElseIf intAValue = intBValue Then
                    lblOutput.Text = "Values are equal."
                End If
            Else
                lblOutput.Text = "Values must be numeric."
            End If
        Else
            lblOutput.Text = "Values must be numeric."
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
