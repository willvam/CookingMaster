Public Class Form7
    '美式漢堡關
    Dim second As Integer = 3

    Dim f2 = New Form2
    Dim f1 = New Form1
    Private Sub form7_keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 37 '左
                character.Left = character.Left - 30
                item.Left = item.Left - 30
            Case 38 '上
                character.Top = character.Top - 30
                item.Top = item.Top - 30
            Case 39 '右
                character.Left = character.Left + 30
                item.Left = item.Left + 30
            Case 40 '下
                character.Top = character.Top + 30
                item.Top = item.Top + 30

            Case 32 '空白鍵互動
                If (character.Left <= breadbox.Left + breadbox.Width) And (character.Left >= breadbox.Left - character.Width) And (character.Top <= breadbox.Top + breadbox.Height) And (character.Top >= breadbox.Top - character.Height) And item.Tag = 0 Then
                    item.Image = CType(My.Resources.ResourceManager.GetObject("麵包"), Image)
                    item.Tag = 5
                    '麵包
                ElseIf (character.Left <= cheesebox.Left + cheesebox.Width) And (character.Left >= cheesebox.Left - character.Width) And (character.Top <= cheesebox.Top + cheesebox.Height) And (character.Top >= cheesebox.Top - character.Height) And item.Tag = 0 Then
                    item.Image = CType(My.Resources.ResourceManager.GetObject("起司"), Image)
                    item.Tag = 8
                    '起司
                ElseIf (character.Left <= tomatobox.Left + tomatobox.Width) And (character.Left >= tomatobox.Left - character.Width) And (character.Top <= tomatobox.Top + tomatobox.Height) And (character.Top >= tomatobox.Top - character.Height) And item.Tag = 0 Then
                    item.Image = CType(My.Resources.ResourceManager.GetObject("番茄"), Image)
                    item.Tag = 6
                    '番茄
                ElseIf (character.Left <= vegetablebox.Left + vegetablebox.Width) And (character.Left >= vegetablebox.Left - character.Width) And (character.Top <= vegetablebox.Top + vegetablebox.Height) And (character.Top >= vegetablebox.Top - character.Height) And item.Tag = 0 Then
                    item.Image = CType(My.Resources.ResourceManager.GetObject("生菜_前_"), Image)
                    item.Tag = 1
                    '生菜
                ElseIf (character.Left <= meatbox.Left + meatbox.Width) And (character.Left >= meatbox.Left - character.Width) And (character.Top <= meatbox.Top + meatbox.Height) And (character.Top >= meatbox.Top - character.Height) And item.Tag = 0 Then
                    item.Image = CType(My.Resources.ResourceManager.GetObject("生漢堡肉"), Image)
                    item.Tag = 3
                    '漢堡肉
                ElseIf (character.Left <= namaita.Left + namaita.Width) And (character.Left >= namaita.Left - character.Width) And (character.Top <= namaita.Top + namaita.Height) And (character.Top >= namaita.Top - character.Height) Then
                    If item.Tag = 1 And HalfFood.Tag = 0 Then
                        Timer1.Enabled = True
                        HalfFood.Image = CType(My.Resources.ResourceManager.GetObject("生菜_前_"), Image)
                        HalfFood.Visible = True
                        HalfFood.Tag = 1
                        item.Tag = 0
                        item.Image = Nothing
                    ElseIf item.Tag = 6 And HalfFood.Tag = 0 Then
                        Timer1.Enabled = True
                        HalfFood.Image = CType(My.Resources.ResourceManager.GetObject("番茄"), Image)
                        HalfFood.Visible = True
                        HalfFood.Tag = 6
                        item.Tag = 0
                        item.Image = Nothing
                    ElseIf HalfFood.Tag = 2 And item.Tag = 0 Then '後 生菜
                        item.Image = CType(My.Resources.ResourceManager.GetObject("生菜"), Image)

                        'HalfFood.Visible = True
                        item.Tag = 2
                        HalfFood.Image = Nothing
                        HalfFood.Visible = False
                        HalfFood.Tag = 0
                    ElseIf HalfFood.Tag = 7 And item.Tag = 0 Then '後 番茄
                        item.Image = CType(My.Resources.ResourceManager.GetObject("番茄切片"), Image)

                        'HalfFood.Visible = True
                        item.Tag = 7
                        HalfFood.Image = Nothing
                        HalfFood.Visible = False
                        HalfFood.Tag = 0
                        '砧板
                    End If

                ElseIf (character.Left <= pan.Left + pan.Width) And (character.Left >= pan.Left - character.Width) And (character.Top <= pan.Top + pan.Height) And (character.Top >= pan.Top - character.Height) Then
                    If item.Tag = 3 And halfood_pan.Tag = 0 Then
                        Timer3.Enabled = True
                        halfood_pan.Visible = True
                        halfood_pan.Image = CType(My.Resources.ResourceManager.GetObject("生漢堡肉"), Image)
                        halfood_pan.Tag = 3
                        item.Tag = 0
                        item.Image = Nothing
                    ElseIf halfood_pan.Tag = 4 And item.Tag = 0 Then '後 漢堡排

                        item.Image = CType(My.Resources.ResourceManager.GetObject("漢堡肉"), Image)
                        item.Tag = 4
                        halfood_pan.Image = Nothing
                        halfood_pan.Visible = False
                        halfood_pan.Tag = 0
                    End If
                    '平底鍋

                ElseIf (character.Left <= plate.Left + plate.Width) And (character.Left >= plate.Left - character.Width) And (character.Top <= plate.Top + plate.Height) And (character.Top >= plate.Top - character.Height) Then
                    If plateitem1.Tag = 0 And item.Tag <> 9 And item.Tag <> 10 Then '做好的不能放盤子
                        plateitem1.Visible = True
                        plateitem1.Image = item.Image
                        plateitem1.Tag = item.Tag
                        item.Image = Nothing
                        item.Tag = 0
                    ElseIf plateitem1.Tag <> 0 And plateitem2.Tag = 0 And item.Tag <> 9 And item.Tag <> 10 Then
                        plateitem2.Visible = True
                        plateitem2.Image = item.Image
                        plateitem2.Tag = item.Tag
                        item.Image = Nothing
                        item.Tag = 0
                    ElseIf plateitem1.Tag <> 0 And plateitem2.Tag <> 0 And plateitem3.Tag = 0 And item.Tag <> 9 And item.Tag <> 10 Then
                        plateitem3.Visible = True
                        plateitem3.Image = item.Image
                        plateitem3.Tag = item.Tag
                        item.Image = Nothing
                        item.Tag = 0
                        If plateitem1.Tag = 5 And plateitem2.Tag = 2 And plateitem3.Tag = 4 Then '生菜漢堡排漢堡
                            plateitem1.Image = Nothing
                            plateitem2.Image = Nothing
                            plateitem3.Image = Nothing
                            plateitem1.Tag = 0
                            plateitem2.Tag = 0
                            plateitem3.Tag = 0
                            plateitem1.Visible = False
                            plateitem2.Visible = False
                            plateitem3.Visible = False
                            item.Image = CType(My.Resources.ResourceManager.GetObject("完整漢堡1"), Image)
                            item.Tag = 9
                            ' Else
                            ' plateitem3.Visible = True
                            'plateitem3.Image = item.Image
                            '  plateitem3.Tag = item.Tag
                            '   item.Image = Nothing
                            '   item.Tag = 0
                        End If
                    ElseIf plateitem1.Tag <> 0 And plateitem2.Tag <> 0 And plateitem3.Tag <> 0 Then
                        If plateitem1.Tag = 5 And plateitem2.Tag = 7 And plateitem3.Tag = 8 Then '番茄氣死漢堡
                            plateitem1.Image = Nothing
                            plateitem2.Image = Nothing
                            plateitem3.Image = Nothing
                            plateitem1.Tag = 0
                            plateitem2.Tag = 0
                            plateitem3.Tag = 0
                            plateitem1.Visible = False
                            plateitem2.Visible = False
                            plateitem3.Visible = False
                            item.Image = CType(My.Resources.ResourceManager.GetObject("完整漢堡2"), Image)
                            item.Tag = 10
                        End If
                    End If
                    '盤子


                ElseIf (character.Left <= finish.Left + finish.Width) And (character.Left >= finish.Left - character.Width) And (character.Top <= finish.Top + finish.Height) And (character.Top >= finish.Top - character.Height) Then
                    If item.Tag = 9 Then '生菜漢堡
                        If PictureBox1.Tag = 9 Then
                            PictureBox1.Visible = False
                            PictureBox1.Image = Nothing
                            PictureBox1.Tag = 0
                            Label2.Text = Val(Label2.Text) + 100
                            item.Image = Nothing
                            item.Tag = 0
                        ElseIf PictureBox2.Tag = 9 Then
                            PictureBox2.Visible = False
                            PictureBox2.Image = Nothing
                            PictureBox2.Tag = 0
                            Label2.Text = Val(Label2.Text) + 100
                            item.Image = Nothing
                            item.Tag = 0
                        ElseIf PictureBox3.Tag = 9 Then
                            PictureBox3.Visible = False
                            PictureBox3.Image = Nothing
                            PictureBox3.Tag = 0
                            Label2.Text = Val(Label2.Text) + 100
                            item.Image = Nothing
                            item.Tag = 0
                        End If

                    ElseIf item.Tag = 10 Then '番茄漢堡
                        If PictureBox1.Tag = 10 Then
                            PictureBox1.Visible = False
                            PictureBox1.Image = Nothing
                            PictureBox1.Tag = 0
                            Label2.Text = Val(Label2.Text) + 100
                            item.Image = Nothing
                            item.Tag = 0
                        ElseIf PictureBox2.Tag = 10 Then
                            PictureBox2.Visible = False
                            PictureBox2.Image = Nothing
                            PictureBox2.Tag = 0
                            Label2.Text = Val(Label2.Text) + 100
                            item.Image = Nothing
                            item.Tag = 0
                        ElseIf PictureBox3.Tag = 10 Then
                            PictureBox3.Visible = False
                            PictureBox3.Image = Nothing
                            PictureBox3.Tag = 0
                            Label2.Text = Val(Label2.Text) + 100
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
    Private Sub Form7_closing(sender As Object, e As EventArgs) Handles MyBase.Closed
        End
    End Sub
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If HalfFood.Tag = 1 Then '如果砧板上是vegetable
                HalfFood.Image = CType(My.Resources.ResourceManager.GetObject("生菜"), Image)
                HalfFood.Tag = 2
                second = 3
                Timer1.Enabled = False
                Label5.Visible = False
            ElseIf HalfFood.Tag = 6 Then '如果砧板上是tomato
                HalfFood.Image = CType(My.Resources.ResourceManager.GetObject("番茄切片"), Image)
                HalfFood.Tag = 7
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
            a = Rnd.Next(1, 3) '隨機菜單
            If a = 1 Then
                PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject("訂單完整漢堡1"), Image)
                PictureBox1.Tag = 9
            ElseIf a = 2 Then
                PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject("訂單完整漢堡2"), Image)
                PictureBox1.Tag = 10
            End If

            PictureBox1.Visible = True
            Timer2.Enabled = False
            Timer2.Interval = 5000
            Timer2.Enabled = True

        ElseIf PictureBox2.Visible = False Then
            a = Rnd.Next(1, 3)
            If a = 1 Then
                PictureBox2.Image = CType(My.Resources.ResourceManager.GetObject("訂單完整漢堡1"), Image)
                PictureBox2.Tag = 9
            ElseIf a = 2 Then
                PictureBox2.Image = CType(My.Resources.ResourceManager.GetObject("訂單完整漢堡2"), Image)
                PictureBox2.Tag = 10
            End If
            PictureBox2.Visible = True
            Timer2.Enabled = False
            Timer2.Interval = 5000
            Timer2.Enabled = True

        ElseIf PictureBox3.Visible = False Then
            a = Rnd.Next(1, 3)
            If a = 1 Then
                PictureBox3.Image = CType(My.Resources.ResourceManager.GetObject("訂單完整漢堡1"), Image)
                PictureBox3.Tag = 9
            ElseIf a = 2 Then
                PictureBox3.Image = CType(My.Resources.ResourceManager.GetObject("訂單完整漢堡2"), Image)
                PictureBox3.Tag = 10
            End If

            PictureBox3.Visible = True
            Timer2.Enabled = False
            Timer2.Interval = 5000
            Timer2.Enabled = True

        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick '平底鍋
        Label3.Visible = True
        Label3.Text = Val(second)
        second -= 1
        If second = 0 Then
            If halfood_pan.Tag = 3 Then '如x果平底鍋上有肉                
                halfood_pan.Image = CType(My.Resources.ResourceManager.GetObject("漢堡肉"), Image)
                halfood_pan.Tag = 4
                second = 3
                Timer3.Enabled = False
                Label3.Visible = False
            End If
        End If
    End Sub


End Class
