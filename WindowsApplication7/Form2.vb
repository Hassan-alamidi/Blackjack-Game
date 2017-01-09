Public Class frmplayerdetails

    Public Sub btnread_Click(sender As Object, e As EventArgs) Handles btnread.Click
        If filesListBox.SelectedItem Is Nothing Then
            MsgBox("Please select a file.(usually found in G:/savefold) ")
            Exit Sub
        End If
        Dim filelocation = filesListBox.SelectedItem.ToString
        'auto save feature when game is closed the game will save new data (score) to the file it started up on (only works if closed using the exit button)
        If filesListBox.SelectedItem = Module1.strfilename2 Then
            autosave = 1
        ElseIf filesListBox.SelectedItem = Module1.strfilename Then
            autosave = 2
        End If
        Dim fileInfoText As String = readfileinfoforoutput(filelocation)
        txtplayerdetails.Text = fileInfoText
    End Sub

    Private Sub browseButton_Click(sender As Object, e As EventArgs) Handles browseButton.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            ListFiles(FolderBrowserDialog1.SelectedPath)
        End If
    End Sub
    Private Sub ListFiles(ByVal folderPath As String)
        filesListBox.Items.Clear()

        Dim fileNames = My.Computer.FileSystem.GetFiles(
            folderPath, FileIO.SearchOption.SearchTopLevelOnly, "*.txt")

        For Each fileName As String In fileNames
            filesListBox.Items.Add(fileName)
        Next
    End Sub

    Private Sub btnsaveuser_Click(sender As Object, e As EventArgs) Handles btnsaveuser.Click

        Dim strnewsave3 As String
        strsave = txtplayername.Text
        strsave2 = Txtplayerage.Text
        If System.IO.File.Exists(Module1.strfilename) = True And System.IO.File.Exists(Module1.strfilename2) = False Then
            Try
                strnewsave3 = ("1000")
                FW = New System.IO.StreamWriter(strfilename2, True)
                FW.WriteLine(strsave)
                FW.WriteLine(strsave2)
                FW.WriteLine(strnewsave3)
                FW.Close()
                txtplayername.Text = ""
                Txtplayerage.Text = ""

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf System.IO.File.Exists(Module1.strfilename) = False Then
            Try
                strnewsave3 = ("1000")
                FW = New System.IO.StreamWriter(strfilename, True)
                FW.WriteLine(strsave)
                FW.WriteLine(strsave2)
                FW.WriteLine(strnewsave3)
                FW.Close()
                txtplayername.Text = ""
                Txtplayerage.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Maximum number of saves please find save files folder(usually found in G:\savetestfold) and delete the save file that is no longer wanted")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btnentergame.Click
        Dim AForm As frmIngameScreen
        If filesListBox.SelectedItem Is Nothing Then
            MsgBox("Please select a file. (usually found in G:/savefold)")
            Exit Sub
        End If
        AForm = New frmIngameScreen()
        AForm.Show()
        AForm = Nothing
        Me.Hide()


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btntutorial.Click
        Dim CForm As blackjacktot
        CForm = New blackjacktot()
        CForm.Show()
        CForm = Nothing
    End Sub

End Class
