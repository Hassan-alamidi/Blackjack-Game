Module Module1
    Public autosave As Integer = 0
    'folder destination
    Public fileDestination As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\PokerSave"
    Public strfilename As String = fileDestination + "\playerprofile1.txt"
    Public strfilename2 As String = fileDestination + "\playerprofile2.txt"
    Public strsave As String
    Public strsave2 As String
    'Public strsave3 As String
    Public FW As System.IO.StreamWriter


    Public Function readfileinfoforoutput(ByVal filePath As String) As String
        ' Verify that the file exists. 
        If My.Computer.FileSystem.FileExists(filePath) = False Then
            Throw New Exception("File Not Found: " & filePath)
        End If

        Dim sb As New System.Text.StringBuilder()
        Dim savegame As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(filePath)
        Dim sr As System.IO.StreamReader =
            My.Computer.FileSystem.OpenTextFileReader(filePath)


        If sr.Peek() >= 0 Then
            sb.Append(sr.ReadLine())
            sb.Append(vbNewLine & sr.ReadLine())
            'sb.Append(vbNewLine & "Score " & sr.ReadLine()) 
        End If
        sr.Close()

        Return sb.ToString
    End Function
End Module
