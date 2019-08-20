Imports System.IO
Imports MPR
Module Module1
    Sub main()
        PlayBackgroundSoundResource()
    End Sub
    Sub PlayBackgroundSoundResource()
        Dim Mp3Player As New Mp3Player()
        Dim fs As New FileStream("temp.mp3", FileMode.Create)
        fs.Write(My.Resources.Resource1.music, 0, My.Resources.Resource1.music.Length)
        fs.Flush()
        fs.Dispose()
        Mp3Player.FileName = Path.GetFullPath("temp.mp3")
        Mp3Player.play()
        '131000
        Do
            Threading.Thread.Sleep(131000)
            Mp3Player = New Mp3Player
            Mp3Player.FileName = Path.GetFullPath("temp.mp3")
            Mp3Player.play()
        Loop
    End Sub
End Module
