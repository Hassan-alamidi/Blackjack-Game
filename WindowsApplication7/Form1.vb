Public Class frmIngameScreen
    'Declare varibles 
    Dim strsave3 As String
    Dim count As Integer
    Dim dealer As Integer
    Dim rndCard As New Random
    Dim dealercard As New Random
    Dim intCardValue As Integer
    Dim intCardValue2 As Integer
    Dim intCardValue3 As Integer
    Dim intCardValue4 As Integer
    Dim intCardValue5 As Integer
    Dim intcardTotal As Integer
    Dim intScore As Integer


    Private Sub btncard_Click(sender As Object, e As EventArgs) Handles btncard.Click
        'call main program
        Call MainSub()

    End Sub
    Private Sub MainSub()
        'hold cannot be pressed untill you pick atleast 2 cards
        btnHold.Enabled = False
        ' this sub is used for generating players results
        count = count + 1
        If count = 1 Then
            lblResultlose.Visible = False
            lblresultwin.Visible = False
            btncard.Text = "Hit Me"
            If intScore > 0 Then
                intScore = intScore - 50
            Else
                lblResultlose.Visible = True
                lblResultlose.Text = ("YOU ARE OUT OF CHIPS PLEASE RESET THE GAME!!!!")
                btncard.Enabled = False
            End If
            'dealer draws two cards
            dealer = dealercard.Next(4, 22)
            'You draw your first card
            Call firstcard()
            picCard.Visible = True
            lblvalue.Text = intCardValue.ToString
            intcardTotal = intCardValue
        ElseIf count = 2 Then
            Call secondcard()
            picCard2.Visible = True
            lblvalue2.Text = intCardValue2.ToString
            intcardTotal = intCardValue + intCardValue2
            'the dealer must continue to draw cards untill he reaches 17
            If dealer < 17 Then
                dealer = dealer + dealercard.Next(2, 11)
            End If
        ElseIf count = 3 Then
            Call thridcard()
            picCard3.Visible = True
            LblValue3.Text = intCardValue3.ToString
            intcardTotal = intcardTotal + intCardValue3
            'dealer must continue to draw cards untill he reahes 17
            If dealer < 17 Then
                dealer = dealer + dealercard.Next(2, 11)
            End If
        ElseIf count = 4 Then
            Call forthcard()
            picCard4.Visible = True
            LblValue4.Text = intCardValue4.ToString
            intcardTotal = intcardTotal + intCardValue4
            'dealers last card
            If dealer < 17 Then
                dealer = dealer + dealercard.Next(2, 11)
            End If
            If dealer > 21 Then
                dealer = 0
            End If
        ElseIf count = 5 Then
            Call fifthcard()
            picCard5.Visible = True
            Lblvalue5.Text = intCardValue5.ToString
            intcardTotal = intcardTotal + intCardValue5
            'end result if person actually makes it to 5 cards
            If dealer > intcardTotal Then
                My.Computer.Audio.Play(My.Resources.SuperMariolose, AudioPlayMode.Background)
                lblResultlose.Visible = True
                lblResultlose.Text = ("Dealer Wins") & vbNewLine & ("Dealers score was ") & vbNewLine & dealer.ToString
                btncard.Text = "continue"
                lblResultlose.BackColor = Color.DarkGreen
                Call resetgame()
            ElseIf intcardTotal > 21 Then
                My.Computer.Audio.Play(My.Resources.SuperMariolose, AudioPlayMode.Background)
                lblResultlose.Visible = True
                lblResultlose.Text = ("Bust")
                btncard.Text = "continue"
                lblResultlose.BackColor = Color.DarkGreen
                Call resetgame()
            Else
                My.Computer.Audio.Play(My.Resources.zelda, AudioPlayMode.Background)
                lblresultwin.Visible = True
                lblresultwin.Text = ("Congratulations You Win") & vbNewLine & ("Your Score= ") & intcardTotal.ToString & vbNewLine & ("Dealers Score= ") & dealer.ToString
                intScore = intScore + 100
                btncard.Text = "continue"
                lblresultwin.BackColor = Color.DarkGreen
                Call resetgame()
            End If
        End If
        If count >= 2 Then
            btnHold.Enabled = True
        End If
        If intcardTotal > 21 Then
            My.Computer.Audio.Play(My.Resources.SuperMariolose, AudioPlayMode.Background)
            lblResultlose.Visible = True
            lblResultlose.Text = ("Bust")
            btncard.Text = "continue"
            lblResultlose.BackColor = Color.DarkGreen
            Call resetgame()
        ElseIf intcardTotal = 21 Then
            My.Computer.Audio.Play(My.Resources.zelda, AudioPlayMode.Background)
            lblresultwin.Visible = True
            lblresultwin.Text = ("Congratulations You Got Blackjack You Win")
            intScore = intScore + 100
            btncard.Text = "continue"
            lblresultwin.BackColor = Color.DarkGreen
            Call resetgame()
        End If

        lblScore.Text = intScore.ToString
        lblTotal.Text = intcardTotal.ToString
        'For testing purposes
        lbldealertest.Text = dealer.ToString


    End Sub

    Private Sub firstcard()
        'ALOT of redundant code, What was I thinking back then
        Dim intCard As Integer
        'first card values
        intCard = rndCard.Next(1, 53)
        picCard.Image = imglstCard.Images(intCard)
        Select Case intCard
            Case 1 To 4
                intCardValue = 2
            Case 5 To 8
                intCardValue = 3
            Case 9 To 12
                intCardValue = 4
            Case 13 To 16
                intCardValue = 5
            Case 17 To 20
                intCardValue = 6
            Case 21 To 24
                intCardValue = 7
            Case 25 To 28
                intCardValue = 8
            Case 29 To 32
                intCardValue = 9
            Case 33 To 48
                intCardValue = 10
            Case 49 To 52
                intCardValue = 11
        End Select

    End Sub
    Private Sub secondcard()
        Dim intCard2 As Integer
        'second card values
        intCard2 = rndCard.Next(1, 53)
        picCard2.Image = imglstCard.Images(intCard2)
        Select Case intCard2
            Case 1 To 4
                intCardValue2 = 2
            Case 5 To 8
                intCardValue2 = 3
            Case 9 To 12
                intCardValue2 = 4
            Case 13 To 16
                intCardValue2 = 5
            Case 17 To 20
                intCardValue2 = 6
            Case 21 To 24
                intCardValue2 = 7
            Case 25 To 28
                intCardValue2 = 8
            Case 29 To 32
                intCardValue2 = 9
            Case 33 To 48
                intCardValue2 = 10
            Case 49 To 52
                intCardValue2 = 11
        End Select

    End Sub
    Private Sub thridcard()
        Dim intCard3 As Integer
        'thrid card values
        intCard3 = rndCard.Next(1, 53)
        picCard3.Image = imglstCard.Images(intCard3)

        Select Case intCard3
            Case 1 To 4
                intCardValue3 = 2
            Case 5 To 8
                intCardValue3 = 3
            Case 9 To 12
                intCardValue3 = 4
            Case 13 To 16
                intCardValue3 = 5
            Case 17 To 20
                intCardValue3 = 6
            Case 21 To 24
                intCardValue3 = 7
            Case 25 To 28
                intCardValue3 = 8
            Case 29 To 32
                intCardValue3 = 9
            Case 33 To 48
                intCardValue3 = 10
            Case 49 To 52
                intCardValue3 = 11
        End Select
    End Sub
    Private Sub forthcard()
        Dim intCard4 As Integer
        'forth card values
        intCard4 = rndCard.Next(1, 53)
        picCard4.Image = imglstCard.Images(intCard4)

        Select Case intCard4
            Case 1 To 4
                intCardValue4 = 2
            Case 5 To 8
                intCardValue4 = 3
            Case 9 To 12
                intCardValue4 = 4
            Case 13 To 16
                intCardValue4 = 5
            Case 17 To 20
                intCardValue4 = 6
            Case 21 To 24
                intCardValue4 = 7
            Case 25 To 28
                intCardValue4 = 8
            Case 29 To 32
                intCardValue4 = 9
            Case 33 To 48
                intCardValue4 = 10
            Case 49 To 52
                intCardValue4 = 11
        End Select
    End Sub
    Private Sub fifthcard()
        Dim intcard5 As Integer
        'fifth card values
        intcard5 = rndCard.Next(1, 53)
        picCard5.Image = imglstCard.Images(intcard5)
        Select Case intcard5
            Case 1 To 4
                intCardValue5 = 2
            Case 5 To 8
                intCardValue5 = 3
            Case 9 To 12
                intCardValue5 = 4
            Case 13 To 16
                intCardValue5 = 5
            Case 17 To 20
                intCardValue5 = 6
            Case 21 To 24
                intCardValue5 = 7
            Case 25 To 28
                intCardValue5 = 8
            Case 29 To 32
                intCardValue5 = 9
            Case 33 To 48
                intCardValue5 = 10
            Case 49 To 52
                intCardValue5 = 11
        End Select
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        btncard.Enabled = True
        intScore = 1000
        lblScore.Text = intScore.ToString
        Call resetgame()
    End Sub
    Private Sub resetgame()
        'restarts the game
        picCard.Visible = False
        picCard2.Visible = False
        picCard3.Visible = False
        picCard4.Visible = False
        picCard5.Visible = False
        count = 0
        intcardTotal = 0
        dealer = 0
        'checks if player still has chips done in this sub because it wont interfer with gameplay when player is on last chips
        If intScore <= 0 Then
            My.Computer.Audio.Play(My.Resources.SuperMariolose, AudioPlayMode.Background)
            lblResultlose.Visible = True
            lblResultlose.Text = ("you are are out of chips please reset game")
        End If
        lblTotal.Text = intcardTotal.ToString
        lbldealertest.Text = dealer.ToString
    End Sub

    Private Sub btnHold_Click(sender As Object, e As EventArgs) Handles btnHold.Click
        'this sub decides whos winner if user presses hold
        'this decides what the last score of the dealer should be
        If dealer > 0 And dealer < 17 Then
            dealer = dealer + dealercard.Next(2, 11)
        End If
        If dealer > 21 Then
            dealer = 0
        End If
        'this holds the cards by setting count to 10 the counter will still count but will not activate any if statements not needed in current version but i keep it incase player encounters bug
        count = 10
        If intcardTotal > dealer And dealer > 0 Then
            My.Computer.Audio.Play(My.Resources.zelda, AudioPlayMode.Background)
            lblresultwin.Visible = True
            lblresultwin.Text = ("Congratulations You Win") & vbNewLine & ("Your Score= ") & intcardTotal.ToString & vbNewLine & ("Dealers Score= ") & dealer.ToString
            intScore = intScore + 100
            btncard.Text = "continue"
            lblresultwin.BackColor = Color.DarkGreen
            Call resetgame()
        ElseIf dealer = 0 Then
            My.Computer.Audio.Play(My.Resources.zelda, AudioPlayMode.Background)
            lblresultwin.Visible = True
            lblresultwin.Text = ("Congratulations You Win") & vbNewLine & ("Your Score= ") & intcardTotal.ToString & vbNewLine & ("Dealers is bust")
            intScore = intScore + 100
            btncard.Text = "continue"
            lblresultwin.BackColor = Color.DarkGreen
            Call resetgame()
        ElseIf intcardTotal = dealer Then
            My.Computer.Audio.Play(My.Resources.SuperMariolose, AudioPlayMode.Background)
            lblResultlose.Visible = True
            lblResultlose.Text = ("You tied with the Dealer") & vbNewLine & ("both Scores were= ") & intcardTotal.ToString & vbNewLine & ("dealer wins all ties below 21")
            btncard.Text = "continue"
            lblResultlose.BackColor = Color.DarkGreen
            Call resetgame()
        Else
            My.Computer.Audio.Play(My.Resources.SuperMariolose, AudioPlayMode.Background)
            lblResultlose.Visible = True
            lblResultlose.Text = ("Dealer Wins") & vbNewLine & ("Dealers score was ") & vbNewLine & dealer.ToString
            btncard.Text = "continue"
            lblResultlose.BackColor = Color.DarkGreen
            Call resetgame()
        End If
        'updates score
        lblScore.Text = intScore.ToString
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        strsave = frmplayerdetails.txtplayerdetails.Text
        strsave3 = intScore.ToString
        If autosave = 1 Then
            Try
                'there is no true because i want this to overwrite file every save 
                FW = New System.IO.StreamWriter(strfilename2)
                FW.WriteLine(strsave)
                FW.WriteLine(strsave3)
                FW.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf autosave = 2 Then
            Try
                FW = New System.IO.StreamWriter(strfilename)
                FW.WriteLine(strsave)
                FW.WriteLine(strsave3)
                FW.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("something went wrong")

        End If

        End
    End Sub

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        'testing features quick way of turning them on and off
        lblvalue.Visible = False
        lblvalue2.Visible = False
        LblValue3.Visible = False
        LblValue4.Visible = False
        Lblvalue5.Visible = False
        lbldealertest.Visible = False
        btnHold.Enabled = False
        'setup game
        If autosave = 1 Then
            Dim lines As String() = IO.File.ReadAllLines(Module1.strfilename2)
            Dim line3 As String = lines(2)
            intScore = Val(line3)
        ElseIf autosave = 2 Then
            Dim lines As String() = IO.File.ReadAllLines(Module1.strfilename)
            Dim line3 As String = lines(2)
            intScore = Val(line3)
        End If
        btncard.Visible = True
        btnHold.Visible = True
        btnreset.Visible = True
        btnexit.Visible = True
        btnstart.Visible = False
        btnstart.Enabled = False
        lblScore.Text = intScore.ToString
        lblsaveinfo.Text = frmplayerdetails.txtplayerdetails.Text
    End Sub

    Private Sub frmIngameScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
