Public Class frmMain
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim Amount, Over As Double
        Dim Dollars, Quarters, Dimes, Nickels, Pennies As Integer

        Double.TryParse(txtAmount.Text, Amount)


        Dollars = Int(Amount / 100)
        Over = Amount Mod 100
        lblDollar.Text = Dollars

        Amount = Amount - (100 * Dollars)

        Quarters = Int(Amount / 25)
        Over = Amount Mod 25
        lblQuarters.Text = Quarters

        Amount = Amount - (25 * Quarters)

        Dimes = Int(Amount / 10)
        Over = Amount Mod 10
        lblDimes.Text = Dimes

        Amount = Amount - (10 * Dimes)

        Nickels = Int(Amount / 5)
        Over = Amount Mod 5
        lblNickles.Text = Nickels

        Amount = Amount - (5 * Nickels)

        Pennies = Int(Amount / 1)
        Over = Amount Mod 1
        lblPennies.Text = Pennies

        Amount = Amount - (1 * Pennies)



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmount.Clear()
        lblDollar.Clear()
        lblQuarters.Clear()
        lblDimes.Clear()
        lblNickles.Clear()
        lblPennies.Clear()
        txtAmount.Focus()

    End Sub
End Class
