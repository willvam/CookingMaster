Imports System.Reflection.Emit
Imports System.Threading
Imports System.Timers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form3

    Dim a As Integer
    Dim count As Integer = 0
    Dim myTimer1 As Integer = 0
    Dim myTimer2 As Integer = 0
    Dim myTimer3 As Integer = 0
    Dim f4 = New Form4
    Dim f5 = New Form5
    Dim f6 = New Form6
    Dim f7 = New Form7
    Dim f2 = New Form2
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Enabled = False

    End Sub


    Sub PlayLoopingBackgroundSoundResource()
        Select Case a
            Case "1"
                My.Computer.Audio.Play(My.Resources.japan, AudioPlayMode.BackgroundLoop)
            Case "2"
                My.Computer.Audio.Play(My.Resources.hamberger2, AudioPlayMode.BackgroundLoop)
            Case "3"
                My.Computer.Audio.Play(My.Resources.coffee, AudioPlayMode.BackgroundLoop)
        End Select
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        myTimer1 = myTimer1 - 1
        Dim dtime As New TimeSpan(0, 0, myTimer1)
        Dim temp = Split(dtime.ToString(), ":")



        f4.Label1.Text = temp(1) + ":" + temp(2)  '僅顯示分鐘數和秒數'Me.Label1.Text
        f4.Show()
        f4.Owner = Me '認爹

        If Label2.Text = "1" Then '選角
            f4.character.image = CType(My.Resources.ResourceManager.GetObject("ch1"), Image)
        ElseIf Label2.Text = "2" Then
            f4.character.image = CType(My.Resources.ResourceManager.GetObject("ch2"), Image)
        End If

        If myTimer1 <= 0 Then
            Timer1.Enabled = False
            f4.Label1.Text = "！時間到！"  ' 顯示提示文字
            '轉結算畫面
            f5.show()
            f5.Owner = Me '認爹
            f5.Label1.Text = f4.Label3.Text

            If 0 <= Val(f4.Label3.Text) And Val(f4.Label3.Text) < 400 Then
                f5.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("ed1"), Image)
            ElseIf 400 <= Val(f4.Label3.Text) And Val(f4.Label3.Text) < 800 Then
                f5.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("ed2"), Image)
            ElseIf 800 <= Val(f4.Label3.Text) Then
                f5.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("ed3"), Image)
            End If

            My.Computer.Audio.Stop()
            'Form1.Close()
            'Form2.Close()
            'Me.Close()
            'f4.Close() '不能用form4來寫
            f4.hide
        End If



    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = 1

        'If Form1.Label3.Text = 1 Then
        'Call PlayLoopingBackgroundSoundResource()
        'End If


        'button1 = 遊戲開始的鍵
        '要先確定有選擇時間不然會出bug

        If RadioButton3.Checked = True Then
            myTimer1 = 240
            Timer1.Enabled = True
            Dim f4 As New Form4
            If Form1.Label3.Text = 1 Then '靜音等等
                Call PlayLoopingBackgroundSoundResource()
            End If
            Me.Hide()
        ElseIf RadioButton1.Checked = True Then
            myTimer1 = 120
            Timer1.Enabled = True
            Dim f4 As New Form4
            If Form1.Label3.Text = 1 Then
                Call PlayLoopingBackgroundSoundResource()
            End If
            Me.Hide()
        ElseIf RadioButton2.Checked = True Then
            myTimer1 = 180
            Timer1.Enabled = True
            Dim f4 As New Form4
            If Form1.Label3.Text = 1 Then
                Call PlayLoopingBackgroundSoundResource()
            End If
            Me.Hide()
        ElseIf RadioButton4.Checked = True Then
            myTimer1 = 300
            Timer1.Enabled = True
            Dim f4 As New Form4
            If Form1.Label3.Text = 1 Then
                Call PlayLoopingBackgroundSoundResource()
            End If
            Me.Hide()
        Else
            MessageBox.Show("選擇時間")
        End If

        'Timer1.Enabled = True ' 啟動計時器

        'Dim f4 As New Form4

        'f4.Show() 出現過了timetick那邊

        'Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = 2

        If RadioButton3.Checked = True Then
            myTimer2 = 240
            Timer2.Enabled = True

            If Form1.Label3.Text = 1 Then
                Call PlayLoopingBackgroundSoundResource()
            End If
            Me.Hide()
        ElseIf RadioButton1.Checked = True Then
            myTimer2 = 120
            Timer2.Enabled = True

            If Form1.Label3.Text = 1 Then
                Call PlayLoopingBackgroundSoundResource()
            End If
            Me.Hide()
        ElseIf RadioButton2.Checked = True Then
            myTimer2 = 180
            Timer2.Enabled = True

            If Form1.Label3.Text = 1 Then
                Call PlayLoopingBackgroundSoundResource()
            End If
            Me.Hide()
        ElseIf RadioButton4.Checked = True Then
            myTimer2 = 300
            Timer2.Enabled = True

            If Form1.Label3.Text = 1 Then
                Call PlayLoopingBackgroundSoundResource()
            End If
            Me.Hide()
        Else
            MessageBox.Show("選擇時間")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click '漢堡
        a = 3

        If RadioButton3.Checked = True Then
            myTimer3 = 240
            Timer3.Enabled = True

            If Form1.Label3.Text = 1 Then
                Call PlayLoopingBackgroundSoundResource()
            End If
            Me.Hide()
        ElseIf RadioButton1.Checked = True Then
            myTimer3 = 120
            Timer3.Enabled = True

            If Form1.Label3.Text = 1 Then
                Call PlayLoopingBackgroundSoundResource()
            End If
            Me.Hide()
        ElseIf RadioButton2.Checked = True Then
            myTimer3 = 180
            Timer3.Enabled = True

            If Form1.Label3.Text = 1 Then
                Call PlayLoopingBackgroundSoundResource()
            End If
            Me.Hide()
        ElseIf RadioButton4.Checked = True Then
            myTimer3 = 300
            Timer3.Enabled = True

            If Form1.Label3.Text = 1 Then
                Call PlayLoopingBackgroundSoundResource()
            End If
            Me.Hide()
        Else
            MessageBox.Show("選擇時間")
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        myTimer2 = myTimer2 - 1
        Dim dtime As New TimeSpan(0, 0, myTimer2)
        Dim temp = Split(dtime.ToString(), ":")



        f6.Label1.Text = temp(1) + ":" + temp(2)  '僅顯示分鐘數和秒數'Me.Label1.Text
        f6.Show()
        f6.Owner = Me

        If Label2.Text = "1" Then '選角
            f6.character.image = CType(My.Resources.ResourceManager.GetObject("ch1"), Image)
        ElseIf Label2.Text = "2" Then
            f6.character.image = CType(My.Resources.ResourceManager.GetObject("ch2"), Image)
        End If


        If myTimer2 <= 0 Then
            Timer2.Enabled = False
            f6.Label1.Text = "！時間到！"  ' 顯示提示文字
            '轉結算畫面
            f5.show()
            f5.Owner = Me
            f5.Label1.Text = f6.Label3.Text

            If 0 <= Val(f6.Label3.Text) And Val(f6.Label3.Text) < 400 Then
                f5.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("ed1"), Image)
            ElseIf 400 <= Val(f6.Label3.Text) And Val(f6.Label3.Text) < 800 Then
                f5.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("ed2"), Image)
            ElseIf 800 <= Val(f6.Label3.Text) Then
                f5.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("ed3"), Image)
            End If

            My.Computer.Audio.Stop()
            'Form1.Close()
            'Form2.Close()
            'Me.Close()
            'f6.Close() '不能用form4來寫
            f6.hide
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        myTimer3 = myTimer3 - 1
        Dim dtime As New TimeSpan(0, 0, myTimer3)
        Dim temp = Split(dtime.ToString(), ":")


        f7.Label1.Text = temp(1) + ":" + temp(2)  '僅顯示分鐘數和秒數'Me.Label1.Text
        f7.Show()
        f7.Owner = Me

        If Label2.Text = "1" Then '選角
            f7.character.image = CType(My.Resources.ResourceManager.GetObject("ch1"), Image)
        ElseIf Label2.Text = "2" Then
            f7.character.image = CType(My.Resources.ResourceManager.GetObject("ch2"), Image)
        End If

        If myTimer3 <= 0 Then
            Timer3.Enabled = False
            f7.Label1.Text = "！時間到！"  ' 顯示提示文字
            '轉結算畫面
            f5.show()
            My.Computer.Audio.Stop()
            f5.Owner = Me '認爹
            f5.Label1.Text = f7.Label2.Text

            If 0 <= Val(f7.Label2.Text) And Val(f7.Label2.Text) < 400 Then
                f5.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("ed1"), Image)
            ElseIf 400 <= Val(f7.Label2.Text) And Val(f7.Label2.Text) < 800 Then
                f5.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("ed2"), Image)
            ElseIf 800 <= Val(f7.Label2.Text) Then
                f5.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("ed3"), Image)
            End If
            'Form1.Close()
            'Form2.Close()
            'Me.Close()
            'f7.Close() '不能用form4來寫
            f7.hide
        End If
    End Sub
End Class
