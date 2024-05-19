Imports System.Reflection.Emit

Public Class Form4
    '壽司關
    Dim second As Integer = 3

    Dim f2 = New Form2
    Dim f1 = New Form1
    Private Sub form1_keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 37 '左
                character.Left = character.Left - 50
                item.Left = item.Left - 50
            Case 38 '上
                character.Top = character.Top - 50
                item.Top = item.Top - 50
            Case 39 '右
                character.Left = character.Left + 50
                item.Left = item.Left + 50
            Case 40 '下
                character.Top = character.Top + 50
                item.Top = item.Top + 50

                'Case 87 'W
                'PictureBox1.Top = PictureBox1.Top - 10
                'Case 68 'A
                'PictureBox1.Left = PictureBox1.Left + 10
                'Case 83 'S
                'PictureBox1.Top = PictureBox1.Top + 10
                'Case 65 'A
                'PictureBox1.Left = PictureBox1.Left - 10

            Case 32 '空白鍵互動
                If (character.Left <= fishbox.Left + fishbox.Width) And (character.Left >= fishbox.Left - character.Width) And (character.Top <= fishbox.Top + fishbox.Height) And (character.Top >= fishbox.Top - character.Height) And item.Tag = 0 Then
                    item.Image = CType(My.Resources.ResourceManager.GetObject("魚"), Image)
                    item.Tag = 2
                    '魚箱
                ElseIf (character.Left <= rice.Left + rice.Width) And (character.Left >= rice.Left - character.Width) And (character.Top <= rice.Top + rice.Height) And (character.Top >= rice.Top - character.Height) And item.Tag = 0 Then
                    item.Image = CType(My.Resources.ResourceManager.GetObject("rice"), Image)
                    item.Tag = 1
                    '白飯
                ElseIf (character.Left <= seaweed.Left + seaweed.Width) And (character.Left >= seaweed.Left - character.Width) And (character.Top <= seaweed.Top + seaweed.Height) And (character.Top >= seaweed.Top - character.Height) And item.Tag = 0 Then
                    item.Image = CType(My.Resources.ResourceManager.GetObject("海苔"), Image)
                    item.Tag = 4
                    '海苔
                ElseIf (character.Left <= shrimpbox.Left + shrimpbox.Width) And (character.Left >= shrimpbox.Left - character.Width) And (character.Top <= shrimpbox.Top + shrimpbox.Height) And (character.Top >= shrimpbox.Top - character.Height) And item.Tag = 0 Then
                    item.Image = CType(My.Resources.ResourceManager.GetObject("蝦後"), Image)
                    item.Tag = 5
                    '蝦箱
                ElseIf (character.Left <= tofuskinbox.Left + tofuskinbox.Width) And (character.Left >= tofuskinbox.Left - character.Width) And (character.Top <= tofuskinbox.Top + tofuskinbox.Height) And (character.Top >= tofuskinbox.Top - character.Height) And item.Tag = 0 Then
                    item.Image = CType(My.Resources.ResourceManager.GetObject("豆皮"), Image)
                    item.Tag = 7
                    '豆皮箱
                ElseIf (character.Left <= namaita.Left + namaita.Width) And (character.Left >= namaita.Left - character.Width) And (character.Top <= namaita.Top + namaita.Height) And (character.Top >= namaita.Top - character.Height) Then
                    If item.Tag = 2 And HalfFood.Tag = 0 Then
                        Timer1.Enabled = True
                        HalfFood.Image = CType(My.Resources.ResourceManager.GetObject("魚"), Image)
                        HalfFood.Visible = True
                        HalfFood.Tag = 2
                        item.Tag = 0
                        item.Image = Nothing
                    ElseIf item.Tag = 5 And HalfFood.Tag = 0 Then
                        Timer1.Enabled = True
                        HalfFood.Image = CType(My.Resources.ResourceManager.GetObject("蝦後"), Image)
                        HalfFood.Visible = True
                        HalfFood.Tag = 5
                        item.Tag = 0
                        item.Image = Nothing
                    ElseIf HalfFood.Tag = 3 And item.Tag = 0 Then '後 魚
                        item.Image = CType(My.Resources.ResourceManager.GetObject("魚切後"), Image)
                        'HalfFood.Visible = True
                        item.Tag = 3
                        HalfFood.Image = Nothing
                        HalfFood.Visible = False
                        HalfFood.Tag = 0
                    ElseIf HalfFood.Tag = 6 And item.Tag = 0 Then '後蝦
                        item.Image = CType(My.Resources.ResourceManager.GetObject("蝦前"), Image)
                        'HalfFood.Visible = True
                        item.Tag = 6
                        HalfFood.Image = Nothing
                        HalfFood.Visible = False
                        HalfFood.Tag = 0
                    End If

                    '砧板
                ElseIf (character.Left <= plate.Left + plate.Width) And (character.Left >= plate.Left - character.Width) And (character.Top <= plate.Top + plate.Height) And (character.Top >= plate.Top - character.Height) Then
                    If plateitem1.Tag = 0 And item.Tag <> 8 And item.Tag <> 9 And item.Tag <> 10 Then
                        plateitem1.Visible = True
                        plateitem1.Image = item.Image
                        plateitem1.Tag = item.Tag
                        item.Image = Nothing
                        item.Tag = 0
                    ElseIf plateitem1.Tag <> 0 And plateitem2.Tag = 0 And item.Tag <> 8 And item.Tag <> 9 And item.Tag <> 10 Then
                        plateitem2.Visible = True
                        plateitem2.Image = item.Image
                        plateitem2.Tag = item.Tag
                        item.Image = Nothing
                        item.Tag = 0
                    ElseIf plateitem1.Tag <> 0 And plateitem2.Tag <> 0 And plateitem3.Tag = 0 And item.Tag <> 8 And item.Tag <> 9 And item.Tag <> 10 Then
                        If plateitem1.Tag = 1 And plateitem2.Tag = 7 Then '豆皮壽司
                            plateitem1.Image = Nothing
                            plateitem2.Image = Nothing
                            plateitem1.Tag = 0
                            plateitem2.Tag = 0
                            plateitem1.Visible = False
                            plateitem2.Visible = False
                            plateitem3.Visible = False
                            item.Image = CType(My.Resources.ResourceManager.GetObject("豆皮壽司1"), Image)
                            item.Tag = 10
                        Else
                            plateitem3.Visible = True
                            plateitem3.Image = item.Image
                            plateitem3.Tag = item.Tag
                            item.Image = Nothing
                            item.Tag = 0
                        End If
                    ElseIf plateitem1.Tag <> 0 And plateitem2.Tag <> 0 And plateitem3.Tag <> 0 Then
                        If plateitem1.Tag = 1 And plateitem2.Tag = 3 And plateitem3.Tag = 4 Then '鮮魚壽司
                            plateitem1.Image = Nothing
                            plateitem2.Image = Nothing
                            plateitem3.Image = Nothing
                            plateitem1.Tag = 0
                            plateitem2.Tag = 0
                            plateitem3.Tag = 0
                            plateitem1.Visible = False
                            plateitem2.Visible = False
                            plateitem3.Visible = False
                            item.Image = CType(My.Resources.ResourceManager.GetObject("鮮魚壽司"), Image)
                            item.Tag = 8
                        ElseIf plateitem1.Tag = 1 And plateitem2.Tag = 6 And plateitem3.Tag = 4 Then '鮮蝦壽司
                            plateitem1.Image = Nothing
                            plateitem2.Image = Nothing
                            plateitem3.Image = Nothing
                            plateitem1.Tag = 0
                            plateitem2.Tag = 0
                            plateitem3.Tag = 0
                            plateitem1.Visible = False
                            plateitem2.Visible = False
                            plateitem3.Visible = False
                            item.Image = CType(My.Resources.ResourceManager.GetObject("鮮蝦壽司"), Image)
                            item.Tag = 9
                        End If
                    End If
                    '盤子
                ElseIf (character.Left <= finish.Left + finish.Width) And (character.Left >= finish.Left - character.Width) And (character.Top <= finish.Top + finish.Height) And (character.Top >= finish.Top - character.Height) Then
                    If item.Tag = 8 Then '鮮魚壽司
                        If PictureBox1.Tag = 8 Then
                            PictureBox1.Visible = False
                            PictureBox1.Image = Nothing
                            PictureBox1.Tag = 0
                            Label3.Text = Val(Label3.Text) + 100
                            item.Image = Nothing
                            item.Tag = 0
                        ElseIf PictureBox2.Tag = 8 Then
                            PictureBox2.Visible = False
                            PictureBox2.Image = Nothing
                            PictureBox2.Tag = 0
                            Label3.Text = Val(Label3.Text) + 100
                            item.Image = Nothing
                            item.Tag = 0
                        ElseIf PictureBox3.Tag = 8 Then
                            PictureBox3.Visible = False
                            PictureBox3.Image = Nothing
                            PictureBox3.Tag = 0
                            Label3.Text = Val(Label3.Text) + 100
                            item.Image = Nothing
                            item.Tag = 0
                        End If

                    ElseIf item.Tag = 9 Then '鮮蝦壽司
                        If PictureBox1.Tag = 9 Then
                            PictureBox1.Visible = False
                            PictureBox1.Image = Nothing
                            PictureBox1.Tag = 0
                            Label3.Text = Val(Label3.Text) + 100
                            item.Image = Nothing
                            item.Tag = 0
                        ElseIf PictureBox2.Tag = 9 Then
                            PictureBox2.Visible = False
                            PictureBox2.Image = Nothing
                            PictureBox2.Tag = 0
                            Label3.Text = Val(Label3.Text) + 100
                            item.Image = Nothing
                            item.Tag = 0
                        ElseIf PictureBox3.Tag = 9 Then
                            PictureBox3.Visible = False
                            PictureBox3.Image = Nothing
                            PictureBox3.Tag = 0
                            Label3.Text = Val(Label3.Text) + 100
                            item.Image = Nothing
                            item.Tag = 0
                        End If
                    ElseIf item.Tag = 10 Then '豆皮壽司
                        If PictureBox1.Tag = 10 Then
                            PictureBox1.Visible = False
                            PictureBox1.Image = Nothing
                            PictureBox1.Tag = 0
                            Label3.Text = Val(Label3.Text) + 100
                            item.Image = Nothing
                            item.Tag = 0
                        ElseIf PictureBox2.Tag = 10 Then
                            PictureBox2.Visible = False
                            PictureBox2.Image = Nothing
                            PictureBox2.Tag = 0
                            Label3.Text = Val(Label3.Text) + 100
                            item.Image = Nothing
                            item.Tag = 0
                        ElseIf PictureBox3.Tag = 10 Then
                            PictureBox3.Visible = False
                            PictureBox3.Image = Nothing
                            PictureBox3.Tag = 0
                            Label3.Text = Val(Label3.Text) + 100
                            item.Image = Nothing
                            item.Tag = 0
                        End If
                        '出餐口
                    End If
                ElseIf (character.Left <= trashcan.Left + trashcan.Width) And (character.Left >= trashcan.Left - character.Width) And (character.Top <= trashcan.Top + trashcan.Height) And (character.Top >= trashcan.Top - character.Height) Then
                    item.Image = Nothing
                    item.Tag = 0
                End If
                '垃圾桶
            Case Keys.Z 'Z鍵(丟棄鍵)
                If (character.Left <= plate.Left + plate.Width) And (character.Left >= plate.Left - character.Width) And (character.Top <= plate.Top + plate.Height) And (character.Top >= plate.Top - character.Height) Then
                    plateitem1.Image = Nothing
                    plateitem2.Image = Nothing
                    plateitem3.Image = Nothing
                    plateitem1.Tag = 0
                    plateitem2.Tag = 0
                    plateitem3.Tag = 0
                    plateitem1.Visible = False
                    plateitem2.Visible = False
                    plateitem3.Visible = False
                End If
        End Select


    End Sub



    Private Sub Form4_closing(sender As Object, e As EventArgs) Handles MyBase.Closed
        ' f1.Close()
        'f2.Close()
        End
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        item.Location = character.Location
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick '砧板

        Label5.Visible = True
        Label5.Text = Val(second)
        second -= 1
        If second = 0 Then
            If HalfFood.Tag = 2 Then '如果砧板上是魚
                HalfFood.Image = CType(My.Resources.ResourceManager.GetObject("魚切後"), Image)
                HalfFood.Tag = 3
                second = 3
                Timer1.Enabled = False
                Label5.Visible = False
            ElseIf HalfFood.Tag = 5 Then '如果砧板上是蝦
                HalfFood.Image = CType(My.Resources.ResourceManager.GetObject("蝦前"), Image)
                HalfFood.Tag = 6
                second = 3
                Timer1.Enabled = False
                Label5.Visible = False

            End If
        End If


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick '菜單
        Randomize()
        Dim Rnd As New Random
        Dim a As Integer

        If PictureBox1.Visible = False Then
            a = Rnd.Next(1, 4) '隨機菜單
            If a = 1 Then
                PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject("訂單鮮魚壽司"), Image)
                PictureBox1.Tag = 8
            ElseIf a = 2 Then
                PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject("訂單鮮蝦壽司"), Image)
                PictureBox1.Tag = 9
            ElseIf a = 3 Then
                PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject("訂單豆皮壽司"), Image)
                PictureBox1.Tag = 10
            End If

            PictureBox1.Visible = True
            Timer2.Enabled = False
            Timer2.Interval = 5000
            Timer2.Enabled = True

        ElseIf PictureBox2.Visible = False Then
            a = Rnd.Next(1, 4)
            If a = 1 Then
                PictureBox2.Image = CType(My.Resources.ResourceManager.GetObject("訂單鮮魚壽司"), Image)
                PictureBox2.Tag = 8
            ElseIf a = 2 Then
                PictureBox2.Image = CType(My.Resources.ResourceManager.GetObject("訂單鮮蝦壽司"), Image)
                PictureBox2.Tag = 9
            ElseIf a = 3 Then
                PictureBox2.Image = CType(My.Resources.ResourceManager.GetObject("訂單豆皮壽司"), Image)
                PictureBox2.Tag = 10
            End If
            PictureBox2.Visible = True
            Timer2.Enabled = False
            Timer2.Interval = 5000
            Timer2.Enabled = True

        ElseIf PictureBox3.Visible = False Then
            a = Rnd.Next(1, 4)
            If a = 1 Then
                PictureBox3.Image = CType(My.Resources.ResourceManager.GetObject("訂單鮮魚壽司"), Image)
                PictureBox3.Tag = 8
            ElseIf a = 2 Then
                PictureBox3.Image = CType(My.Resources.ResourceManager.GetObject("訂單鮮蝦壽司"), Image)
                PictureBox3.Tag = 9
            ElseIf a = 3 Then
                PictureBox3.Image = CType(My.Resources.ResourceManager.GetObject("訂單豆皮壽司"), Image)
                PictureBox3.Tag = 10
            End If

            PictureBox3.Visible = True
            Timer2.Enabled = False
            Timer2.Interval = 5000
            Timer2.Enabled = True

        End If
    End Sub

    Private Sub trashcan_Click(sender As Object, e As EventArgs) Handles trashcan.Click

    End Sub
End Class