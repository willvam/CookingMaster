Public Class Form6
    '蛋糕關
    Dim second As Integer = 3

    Dim f2 = New Form2
    Dim f1 = New Form1

    Private Sub form6_keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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
                If (character.Left <= strawbarrybox.Left + strawbarrybox.Width) And (character.Left >= strawbarrybox.Left - character.Width) And (character.Top <= strawbarrybox.Top + strawbarrybox.Height) And (character.Top >= strawbarrybox.Top - character.Height) And item.Tag = 0 Then
                    item.Image = CType(My.Resources.ResourceManager.GetObject("草莓"), Image)
                    item.Tag = 7
                    '草莓
                ElseIf (character.Left <= chocolatebox.Left + chocolatebox.Width) And (character.Left >= chocolatebox.Left - character.Width) And (character.Top <= chocolatebox.Top + chocolatebox.Height) And (character.Top >= chocolatebox.Top - character.Height) And item.Tag = 0 Then
                    item.Image = CType(My.Resources.ResourceManager.GetObject("巧克力"), Image)
                    item.Tag = 5
                    '巧克力
                ElseIf (character.Left <= hoenybox.Left + hoenybox.Width) And (character.Left >= hoenybox.Left - character.Width) And (character.Top <= hoenybox.Top + hoenybox.Height) And (character.Top >= hoenybox.Top - character.Height) And item.Tag = 0 Then
                    item.Image = CType(My.Resources.ResourceManager.GetObject("蜂蜜"), Image)
                    item.Tag = 3
                    '蜂蜜
                ElseIf (character.Left <= eggbox.Left + eggbox.Width) And (character.Left >= eggbox.Left - character.Width) And (character.Top <= eggbox.Top + eggbox.Height) And (character.Top >= eggbox.Top - character.Height) And item.Tag = 0 Then
                    item.Image = CType(My.Resources.ResourceManager.GetObject("雞蛋"), Image)
                    item.Tag = 2
                    '雞蛋
                ElseIf (character.Left <= flourbox.Left + flourbox.Width) And (character.Left >= flourbox.Left - character.Width) And (character.Top <= flourbox.Top + flourbox.Height) And (character.Top >= flourbox.Top - character.Height) And item.Tag = 0 Then
                    item.Image = CType(My.Resources.ResourceManager.GetObject("麵粉"), Image)
                    item.Tag = 1
                    '麵粉


                ElseIf (character.Left <= oven.Left + oven.Width) And (character.Left >= oven.Left - character.Width) And (character.Top <= oven.Top + oven.Height) And (character.Top >= oven.Top - character.Height) Then
                    If item.Tag = 4 And oven.Tag = 0 Then
                        Timer3.Enabled = True
                        oven.Visible = True
                        oven.Image = CType(My.Resources.ResourceManager.GetObject("桌子_烤箱_有蛋糕_"), Image)
                        oven.Tag = 4
                        item.Tag = 0
                        item.Image = Nothing
                    ElseIf oven.Tag = 9 And item.Tag = 0 Then '考完的蜂蜜
                        item.Image = CType(My.Resources.ResourceManager.GetObject("蜂蜜蛋糕"), Image)
                        oven.Image = CType(My.Resources.ResourceManager.GetObject("桌子_烤箱_空_"), Image)
                        item.Tag = 9
                        'halfood_pan.Image = Nothing
                        'halfood_pan.Visible = False
                        oven.Tag = 0

                    ElseIf item.Tag = 6 And oven.Tag = 0 Then
                        Timer3.Enabled = True
                        oven.Visible = True
                        oven.Image = CType(My.Resources.ResourceManager.GetObject("桌子_烤箱_有蛋糕_"), Image)
                        oven.Tag = 6
                        item.Tag = 0
                        item.Image = Nothing
                    ElseIf oven.Tag = 10 And item.Tag = 0 Then '考完的巧克力
                        item.Image = CType(My.Resources.ResourceManager.GetObject("巧克力蛋糕"), Image)
                        oven.Image = CType(My.Resources.ResourceManager.GetObject("桌子_烤箱_空_"), Image)
                        item.Tag = 10
                        'halfood_pan.Image = Nothing
                        'halfood_pan.Visible = False
                        oven.Tag = 0

                    ElseIf item.Tag = 8 And oven.Tag = 0 Then
                        Timer3.Enabled = True
                        oven.Visible = True
                        oven.Image = CType(My.Resources.ResourceManager.GetObject("桌子_烤箱_有蛋糕_"), Image)
                        oven.Tag = 8
                        item.Tag = 0
                        item.Image = Nothing
                    ElseIf oven.Tag = 11 And item.Tag = 0 Then '考完的草莓
                        item.Image = CType(My.Resources.ResourceManager.GetObject("草莓蛋糕"), Image)
                        oven.Image = CType(My.Resources.ResourceManager.GetObject("桌子_烤箱_空_"), Image)
                        item.Tag = 11
                        'halfood_pan.Image = Nothing
                        'halfood_pan.Visible = False
                        oven.Tag = 0

                    End If
                    '烤箱

                ElseIf (character.Left <= plate.Left + plate.Width) And (character.Left >= plate.Left - character.Width) And (character.Top <= plate.Top + plate.Height) And (character.Top >= plate.Top - character.Height) Then
                    If plateitem1.Tag = 0 And item.Tag <> 4 And item.Tag <> 6 And item.Tag <> 8 And item.Tag <> 9 And item.Tag <> 10 And item.Tag <> 11 Then '做好的不能放盤子
                        plateitem1.Visible = True
                        plateitem1.Image = item.Image
                        plateitem1.Tag = item.Tag
                        item.Image = Nothing
                        item.Tag = 0
                    ElseIf plateitem1.Tag <> 0 And plateitem2.Tag = 0 And item.Tag <> 4 And item.Tag <> 6 And item.Tag <> 8 And item.Tag <> 9 And item.Tag <> 10 And item.Tag <> 11 Then
                        plateitem2.Visible = True
                        plateitem2.Image = item.Image
                        plateitem2.Tag = item.Tag
                        item.Image = Nothing
                        item.Tag = 0
                    ElseIf plateitem1.Tag <> 0 And plateitem2.Tag <> 0 And plateitem3.Tag = 0 And item.Tag <> 4 And item.Tag <> 6 And item.Tag <> 8 And item.Tag <> 9 And item.Tag <> 10 And item.Tag <> 11 Then
                        plateitem3.Visible = True
                        plateitem3.Image = item.Image
                        plateitem3.Tag = item.Tag
                        item.Image = Nothing
                        item.Tag = 0
                        If plateitem1.Tag = 1 And plateitem2.Tag = 2 And plateitem3.Tag = 3 Then '蜂蜜蛋糕生麵團

                            plateitem1.Image = Nothing
                            plateitem2.Image = Nothing
                            plateitem3.Image = Nothing
                            plateitem1.Tag = 0
                            plateitem2.Tag = 0
                            plateitem3.Tag = 0
                            plateitem1.Visible = False
                            plateitem2.Visible = False
                            plateitem3.Visible = False
                            item.Image = CType(My.Resources.ResourceManager.GetObject("蜂蜜麵團"), Image)
                            item.Tag = 4
                            ' Else
                            ' plateitem3.Visible = True
                            'plateitem3.Image = item.Image
                            '  plateitem3.Tag = item.Tag
                            '   item.Image = Nothing
                            '   item.Tag = 0
                            'ElseIf plateitem1.Tag <> 0 And plateitem2.Tag <> 0 And plateitem3.Tag <> 0 Then
                        ElseIf plateitem1.Tag = 1 And plateitem2.Tag = 2 And plateitem3.Tag = 5 Then '巧克力蛋糕生麵團
                            'Timer1.Enabled = True

                            plateitem1.Image = Nothing
                                plateitem2.Image = Nothing
                                plateitem3.Image = Nothing
                                plateitem1.Tag = 0
                                plateitem2.Tag = 0
                                plateitem3.Tag = 0
                                plateitem1.Visible = False
                                plateitem2.Visible = False
                                plateitem3.Visible = False
                            item.Image = CType(My.Resources.ResourceManager.GetObject("巧克力麵團"), Image)
                            item.Tag = 6
                            'End If
                            'ElseIf plateitem1.Tag <> 0 And plateitem2.Tag <> 0 And plateitem3.Tag <> 0 Then
                        ElseIf plateitem1.Tag = 1 And plateitem2.Tag = 2 And plateitem3.Tag = 7 Then '草莓蛋糕生麵團
                            ' Timer1.Enabled = True

                            plateitem1.Image = Nothing
                                plateitem2.Image = Nothing
                                plateitem3.Image = Nothing
                                plateitem1.Tag = 0
                                plateitem2.Tag = 0
                                plateitem3.Tag = 0
                                plateitem1.Visible = False
                                plateitem2.Visible = False
                                plateitem3.Visible = False
                            item.Image = CType(My.Resources.ResourceManager.GetObject("草莓麵團"), Image)
                            item.Tag = 8
                            End If
                        End If


                    '攪拌機

                ElseIf (character.Left <= finish.Left + finish.Width) And (character.Left >= finish.Left - character.Width) And (character.Top <= finish.Top + finish.Height) And (character.Top >= finish.Top - character.Height) Then
                    If item.Tag = 9 Then '蜂蜜
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

                    ElseIf item.Tag = 10 Then '巧克
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
                    ElseIf item.Tag = 11 Then '草莓
                        If PictureBox1.Tag = 11 Then
                            PictureBox1.Visible = False
                            PictureBox1.Image = Nothing
                            PictureBox1.Tag = 0
                            Label3.Text = Val(Label3.Text) + 100
                            item.Image = Nothing
                            item.Tag = 0
                        ElseIf PictureBox2.Tag = 11 Then
                            PictureBox2.Visible = False
                            PictureBox2.Image = Nothing
                            PictureBox2.Tag = 0
                            Label3.Text = Val(Label3.Text) + 100
                            item.Image = Nothing
                            item.Tag = 0
                        ElseIf PictureBox3.Tag = 11 Then
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



    Private Sub Form7_closing(sender As Object, e As EventArgs) Handles MyBase.Closed
        End
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        item.Location = character.Location
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick '攪拌機
        Label5.Visible = True
        Label5.Text = Val(second)
        second -= 1
        If second = 0 Then
            second = 3
            Timer1.Enabled = False
            Label5.Visible = False

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick '菜單
        Randomize()
        Dim Rnd As New Random
        Dim a As Integer

        If PictureBox1.Visible = False Then
            a = Rnd.Next(1, 4) '隨機菜單
            If a = 1 Then
                PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject("訂單蜂蜜蛋糕"), Image)
                PictureBox1.Tag = 9
            ElseIf a = 2 Then
                PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject("訂單巧克力蛋糕"), Image)
                PictureBox1.Tag = 10
            ElseIf a = 3 Then
                PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject("訂單草莓蛋糕"), Image)
                PictureBox1.Tag = 11
            End If

            PictureBox1.Visible = True
            Timer2.Enabled = False
            Timer2.Interval = 5000
            Timer2.Enabled = True

        ElseIf PictureBox2.Visible = False Then
            a = Rnd.Next(1, 3)
            If a = 1 Then
                PictureBox2.Image = CType(My.Resources.ResourceManager.GetObject("訂單蜂蜜蛋糕"), Image)
                PictureBox2.Tag = 9
            ElseIf a = 2 Then
                PictureBox2.Image = CType(My.Resources.ResourceManager.GetObject("訂單巧克力蛋糕"), Image)
                PictureBox2.Tag = 10
            ElseIf a = 3 Then
                PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject("訂單草莓蛋糕"), Image)
                PictureBox1.Tag = 11
            End If
            PictureBox2.Visible = True
            Timer2.Enabled = False
            Timer2.Interval = 5000
            Timer2.Enabled = True

        ElseIf PictureBox3.Visible = False Then
            a = Rnd.Next(1, 3)
            If a = 1 Then
                PictureBox3.Image = CType(My.Resources.ResourceManager.GetObject("訂單蜂蜜蛋糕"), Image)
                PictureBox3.Tag = 9
            ElseIf a = 2 Then
                PictureBox3.Image = CType(My.Resources.ResourceManager.GetObject("訂單巧克力蛋糕"), Image)
                PictureBox3.Tag = 10
            ElseIf a = 3 Then
                PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject("訂單草莓蛋糕"), Image)
                PictureBox1.Tag = 11
            End If

            PictureBox3.Visible = True
            Timer2.Enabled = False
            Timer2.Interval = 5000
            Timer2.Enabled = True

        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick '烤箱
        Label2.Visible = True
        Label2.Text = Val(second)
        second -= 1
        If second = 0 Then
            If oven.Tag = 4 Then '如果平底鍋上有蜂蜜           
                'oven.Image = CType(My.Resources.ResourceManager.GetObject("桌子_鍋架_平底鍋_漢堡肉"), Image)
                oven.Image = CType(My.Resources.ResourceManager.GetObject("桌子_烤箱_有蛋糕_"), Image)
                oven.Tag = 9
                second = 3
                Timer3.Enabled = False
                Label2.Visible = False
            End If
            If oven.Tag = 6 Then '如果平底鍋上有巧克力              
                'oven.Image = CType(My.Resources.ResourceManager.GetObject("桌子_鍋架_平底鍋_漢堡肉"), Image)
                oven.Image = CType(My.Resources.ResourceManager.GetObject("桌子_烤箱_有蛋糕_"), Image)
                oven.Tag = 10
                second = 3
                Timer3.Enabled = False
                Label2.Visible = False
            End If
            If oven.Tag = 8 Then '如果平底鍋上有草莓               
                ' halfood_pan.Image = CType(My.Resources.ResourceManager.GetObject("桌子_鍋架_平底鍋_漢堡肉"), Image)
                oven.Image = CType(My.Resources.ResourceManager.GetObject("桌子_烤箱_有蛋糕_"), Image)
                oven.Tag = 11
                second = 3
                Timer3.Enabled = False
                Label2.Visible = False
            End If
        End If
    End Sub

    Private Sub Form6_closing(sender As Object, e As EventArgs) Handles MyBase.Closed
        End
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub


End Class