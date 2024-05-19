Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Form1
    Dim a As Integer
    Dim count As Integer = 0
    Dim piccheck_1 As Integer = 1



    Private Sub Form1_closing(sender As Object, e As EventArgs) Handles MyBase.Closed
        End
    End Sub


    Sub PlayLoopingBackgroundSoundResource()
        Select Case a
            Case "1"
                My.Computer.Audio.Play(My.Resources.hamberger2, AudioPlayMode.BackgroundLoop)
            Case "2"
                My.Computer.Audio.Play(My.Resources.coffee, AudioPlayMode.BackgroundLoop)
            Case "3"
                My.Computer.Audio.Play(My.Resources.japan, AudioPlayMode.BackgroundLoop)
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f2 As New Form2

        f2.Show()

        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim B = CType(sender, PictureBox)
        If piccheck_1 = 1 Then '關音量
            B.Image = Nothing
            B.BackgroundImageLayout = ImageLayout.Stretch
            piccheck_1 = -1
            Label3.Text = -1

        Else '開音量
            B.Image = CType(My.Resources.ResourceManager.GetObject("voice_open"), Image)
            piccheck_1 = 1
            PlayLoopingBackgroundSoundResource()
            Label3.Text = 1
        End If

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
