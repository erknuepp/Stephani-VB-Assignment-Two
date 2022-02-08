Public Class frmMain

    Private Const TwinCost As Double = 39.99
    Private Const FullCost As Double = 49.99
    Private Const QueenCost As Double = 49.99
    Private Const KingCost As Double = 69.99
    Private Const ShippingCost As Double = 5.0


    Private Sub DisplayCostButton_Click(sender As Object, e As EventArgs) Handles DisplayCostButton.Click
        Dim dblCost As Double

        If Not PickUpInStoreCheckBox.Checked Then
            dblCost = dblCost + ShippingCost
        End If

        If TwinRadioButton.Checked Then
            dblCost += TwinCost
        ElseIf FullRadioButton.Checked Then
            dblCost += FullCost
        ElseIf QueenRadioButton.Checked Then
            dblCost += QueenCost
        ElseIf KingRadioButton.Checked Then
            dblCost += KingCost
        End If

        CostTextBox.Text = dblCost.ToString("C2")

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub
End Class
