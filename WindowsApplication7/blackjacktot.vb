Public Class blackjacktot
    Dim counttut As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        counttut = counttut + 1
        If counttut = 1 Then
            lbltuthelp.BackColor = Color.DarkGreen
            lbltuthelp.Text = ("Welcome to the world of gambling a world filled with debt, poverty and sometimes success. ") & vbNewLine & ("here I will be showing you how to play blackjacks ") & vbNewLine & ("A game made for men with balls of steel but played by men with money to burn or nothing left to lose")
        ElseIf counttut = 2 Then
            lbltuthelp.Text = ("Anyway let's get started. The rules of this game are simple you have got to try to get as close to 21 without going bust, for those who dont know bust is when you go over 21. At first this sounds easy but it's not just you playing.....")
        ElseIf counttut = 3 Then
            lbltuthelp.Text = ("Your oppentent is the dealer and whoever gets the highest number without going bust wins. The dealer has specific rules by which he must follow for example at the end of the game the dealer draws his cards he must keep going until he reaches 17 he cannot stop before or keep going after. This can be good or bad depending on how you play your cards........")
        ElseIf counttut = 4 Then
            lbltuthelp.Text = ("When it comes to who wins in certain scenarios depends on the table you're playing at for this table the rules are if it's a draw dealer wins unless both of you get blackjack then player wins blackjack is when you land on 21, if both player and dealer are bust dealer wins.")
        ElseIf counttut = 5 Then
            lbltuthelp.Text = ("As for how score and controls work you start out with 1000 chips as seen below and for every game it costs 50 chips if you win you earn 50 chips along with the chips you paid into the game and in the bottom right hand corner there is the number 19 this is the current combined number of all your cards currently drawn. Each circle you see on the background image is normally used for each individual player to store their cards but here they are used to display your cards one by one")
        ElseIf counttut = 6 Then
            lbltuthelp.Text = ("There are four buttons below each have their own uses. The hit me button is used to draw another card, the 'hold' button his to stop drawing cards all together, the 'reset' button resets the entire game including chips and the 'save and exit button' is pretty self-explanatory when you are finished playing press save and exit and the game will save your name and chips then exit the game")
        ElseIf counttut = 7 Then
            lbltuthelp.Text = ("And there you have it the game of blackjacks.....hope you enjoy")
        ElseIf counttut = 8 Then
            Me.Close()
        End If
    End Sub

End Class