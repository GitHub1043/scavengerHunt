Public Class Form1

    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        Randomize()

        Const TWO As Integer = 2
        Const THREE As Integer = 3
        Const FOUR As Integer = 4
        Dim intItems As Integer
        Dim intScore As Integer
        Dim intBonus As Integer

        If chkDinosaur.Checked = True Then
            intItems = intItems + 1
        End If
        If chkPizza.Checked = True Then
            intItems = intItems + 1
        End If
        If chkDog.Checked = True Then
            intItems = intItems + 1
        End If
        If chkPaper.Checked = True Then
            intItems = intItems + 1
        End If
        If chkPicture.Checked = True Then
            intItems = intItems + 1
        End If
        If chkPhone.Checked = True Then
            intItems = intItems + 1
        End If
        If chkLight.Checked = True Then
            intItems = intItems + 1
        End If

        If radTwo.Checked = True Then
            intScore = (5 - TWO) * intItems
        ElseIf radThree.Checked = True Then
            intScore = (5 - THREE) * intItems
        ElseIf radFour.Checked = True Then
            intScore = (5 - FOUR) * intItems
        End If

        intBonus = Int(Rnd() * 7) + 1

        If intBonus = 1 And chkDinosaur.Checked = True Then
            intScore = intScore + 5
            MessageBox.Show("You Found The Seceret Item!")
        ElseIf intBonus = 2 And chkPizza.Checked = True Then
            intScore = intScore + 5
            MessageBox.Show("You Found The Seceret Item!")
        ElseIf intBonus = 3 And chkDog.Checked = True Then
            intScore = intScore + 5
            MessageBox.Show("You Found The Seceret Item!")
        ElseIf intBonus = 4 And chkPaper.Checked = True Then
            intScore = intScore + 5
            MessageBox.Show("You Found The Seceret Item!")
        ElseIf intBonus = 5 And chkPicture.Checked = True Then
            intScore = intScore + 5
            MessageBox.Show("You Found The Seceret Item!")
        ElseIf intBonus = 6 And chkPhone.Checked = True Then
            intScore = intScore + 5
            MessageBox.Show("You Found The Seceret Item!")
        ElseIf intBonus = 7 And chkLight.Checked = True Then
            intScore = intScore + 5
            MessageBox.Show("You Found The Seceret Item!")
        End If

        lblScore.Text = "Total Score: " & intScore
    End Sub
End Class
