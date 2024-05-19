<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.halfood_pan = New System.Windows.Forms.PictureBox()
        Me.finish = New System.Windows.Forms.PictureBox()
        Me.pan = New System.Windows.Forms.PictureBox()
        Me.vegetablebox = New System.Windows.Forms.PictureBox()
        Me.cheesebox = New System.Windows.Forms.PictureBox()
        Me.tomatobox = New System.Windows.Forms.PictureBox()
        Me.meatbox = New System.Windows.Forms.PictureBox()
        Me.breadbox = New System.Windows.Forms.PictureBox()
        Me.HalfFood = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.item = New System.Windows.Forms.PictureBox()
        Me.character = New System.Windows.Forms.PictureBox()
        Me.plateitem3 = New System.Windows.Forms.PictureBox()
        Me.plateitem2 = New System.Windows.Forms.PictureBox()
        Me.plateitem1 = New System.Windows.Forms.PictureBox()
        Me.plate = New System.Windows.Forms.PictureBox()
        Me.namaita = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.trashcan = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.halfood_pan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.finish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vegetablebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheesebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tomatobox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meatbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.breadbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HalfFood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.character, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plateitem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plateitem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plateitem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.namaita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trashcan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(291, 888)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 12)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1095, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1533, 888)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 12)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'halfood_pan
        '
        Me.halfood_pan.Location = New System.Drawing.Point(1535, 927)
        Me.halfood_pan.Margin = New System.Windows.Forms.Padding(2)
        Me.halfood_pan.Name = "halfood_pan"
        Me.halfood_pan.Size = New System.Drawing.Size(30, 32)
        Me.halfood_pan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.halfood_pan.TabIndex = 46
        Me.halfood_pan.TabStop = False
        Me.halfood_pan.Visible = False
        '
        'finish
        '
        Me.finish.Image = Global.CookingMaster.My.Resources.Resources.出餐口
        Me.finish.Location = New System.Drawing.Point(1290, 186)
        Me.finish.Name = "finish"
        Me.finish.Size = New System.Drawing.Size(178, 139)
        Me.finish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.finish.TabIndex = 44
        Me.finish.TabStop = False
        Me.finish.Visible = False
        '
        'pan
        '
        Me.pan.Image = Global.CookingMaster.My.Resources.Resources.桌子_鍋架_平底鍋
        Me.pan.Location = New System.Drawing.Point(1465, 914)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(193, 126)
        Me.pan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pan.TabIndex = 43
        Me.pan.TabStop = False
        Me.pan.Tag = ""
        Me.pan.UseWaitCursor = True
        Me.pan.Visible = False
        '
        'vegetablebox
        '
        Me.vegetablebox.Image = Global.CookingMaster.My.Resources.Resources.食材箱_生菜
        Me.vegetablebox.Location = New System.Drawing.Point(605, 551)
        Me.vegetablebox.Name = "vegetablebox"
        Me.vegetablebox.Size = New System.Drawing.Size(174, 126)
        Me.vegetablebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.vegetablebox.TabIndex = 42
        Me.vegetablebox.TabStop = False
        Me.vegetablebox.Visible = False
        '
        'cheesebox
        '
        Me.cheesebox.Image = Global.CookingMaster.My.Resources.Resources.食材箱_起司
        Me.cheesebox.Location = New System.Drawing.Point(949, 551)
        Me.cheesebox.Name = "cheesebox"
        Me.cheesebox.Size = New System.Drawing.Size(171, 128)
        Me.cheesebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cheesebox.TabIndex = 41
        Me.cheesebox.TabStop = False
        Me.cheesebox.Visible = False
        '
        'tomatobox
        '
        Me.tomatobox.Image = Global.CookingMaster.My.Resources.Resources.食材箱_番茄
        Me.tomatobox.Location = New System.Drawing.Point(775, 551)
        Me.tomatobox.Name = "tomatobox"
        Me.tomatobox.Size = New System.Drawing.Size(180, 128)
        Me.tomatobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tomatobox.TabIndex = 40
        Me.tomatobox.TabStop = False
        Me.tomatobox.Visible = False
        '
        'meatbox
        '
        Me.meatbox.Image = Global.CookingMaster.My.Resources.Resources.食材箱_生漢堡肉
        Me.meatbox.Location = New System.Drawing.Point(1126, 553)
        Me.meatbox.Name = "meatbox"
        Me.meatbox.Size = New System.Drawing.Size(168, 126)
        Me.meatbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.meatbox.TabIndex = 39
        Me.meatbox.TabStop = False
        Me.meatbox.Visible = False
        '
        'breadbox
        '
        Me.breadbox.Image = Global.CookingMaster.My.Resources.Resources.食材箱_麵包
        Me.breadbox.Location = New System.Drawing.Point(1290, 553)
        Me.breadbox.Name = "breadbox"
        Me.breadbox.Size = New System.Drawing.Size(190, 128)
        Me.breadbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.breadbox.TabIndex = 38
        Me.breadbox.TabStop = False
        Me.breadbox.UseWaitCursor = True
        Me.breadbox.Visible = False
        '
        'HalfFood
        '
        Me.HalfFood.Location = New System.Drawing.Point(293, 927)
        Me.HalfFood.Margin = New System.Windows.Forms.Padding(2)
        Me.HalfFood.Name = "HalfFood"
        Me.HalfFood.Size = New System.Drawing.Size(30, 32)
        Me.HalfFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HalfFood.TabIndex = 37
        Me.HalfFood.TabStop = False
        Me.HalfFood.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(424, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(167, 198)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(228, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(167, 198)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CookingMaster.My.Resources.Resources.DishList1
        Me.PictureBox1.Location = New System.Drawing.Point(38, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 198)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'item
        '
        Me.item.Location = New System.Drawing.Point(539, 375)
        Me.item.Margin = New System.Windows.Forms.Padding(2)
        Me.item.Name = "item"
        Me.item.Size = New System.Drawing.Size(33, 34)
        Me.item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.item.TabIndex = 28
        Me.item.TabStop = False
        '
        'character
        '
        Me.character.Image = Global.CookingMaster.My.Resources.Resources.ch1
        Me.character.Location = New System.Drawing.Point(517, 335)
        Me.character.Name = "character"
        Me.character.Size = New System.Drawing.Size(74, 74)
        Me.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.character.TabIndex = 25
        Me.character.TabStop = False
        '
        'plateitem3
        '
        Me.plateitem3.Location = New System.Drawing.Point(382, 235)
        Me.plateitem3.Margin = New System.Windows.Forms.Padding(0)
        Me.plateitem3.Name = "plateitem3"
        Me.plateitem3.Size = New System.Drawing.Size(30, 32)
        Me.plateitem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.plateitem3.TabIndex = 32
        Me.plateitem3.TabStop = False
        Me.plateitem3.Visible = False
        '
        'plateitem2
        '
        Me.plateitem2.Location = New System.Drawing.Point(341, 235)
        Me.plateitem2.Margin = New System.Windows.Forms.Padding(2)
        Me.plateitem2.Name = "plateitem2"
        Me.plateitem2.Size = New System.Drawing.Size(30, 32)
        Me.plateitem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.plateitem2.TabIndex = 31
        Me.plateitem2.TabStop = False
        Me.plateitem2.Visible = False
        '
        'plateitem1
        '
        Me.plateitem1.Location = New System.Drawing.Point(298, 235)
        Me.plateitem1.Margin = New System.Windows.Forms.Padding(2)
        Me.plateitem1.Name = "plateitem1"
        Me.plateitem1.Size = New System.Drawing.Size(30, 32)
        Me.plateitem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.plateitem1.TabIndex = 30
        Me.plateitem1.TabStop = False
        Me.plateitem1.Visible = False
        '
        'plate
        '
        Me.plate.BackColor = System.Drawing.SystemColors.Control
        Me.plate.Image = Global.CookingMaster.My.Resources.Resources.plate
        Me.plate.Location = New System.Drawing.Point(274, 196)
        Me.plate.Name = "plate"
        Me.plate.Size = New System.Drawing.Size(162, 119)
        Me.plate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.plate.TabIndex = 29
        Me.plate.TabStop = False
        Me.plate.Visible = False
        '
        'namaita
        '
        Me.namaita.Cursor = System.Windows.Forms.Cursors.Default
        Me.namaita.Image = Global.CookingMaster.My.Resources.Resources.桌子_砧板
        Me.namaita.Location = New System.Drawing.Point(265, 914)
        Me.namaita.Margin = New System.Windows.Forms.Padding(2)
        Me.namaita.Name = "namaita"
        Me.namaita.Size = New System.Drawing.Size(171, 126)
        Me.namaita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.namaita.TabIndex = 27
        Me.namaita.TabStop = False
        Me.namaita.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1217, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 12)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "0"
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'trashcan
        '
        Me.trashcan.Image = Global.CookingMaster.My.Resources.Resources.垃圾桶
        Me.trashcan.Location = New System.Drawing.Point(471, 544)
        Me.trashcan.Margin = New System.Windows.Forms.Padding(2)
        Me.trashcan.Name = "trashcan"
        Me.trashcan.Size = New System.Drawing.Size(120, 148)
        Me.trashcan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.trashcan.TabIndex = 48
        Me.trashcan.TabStop = False
        Me.trashcan.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1219, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 12)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "得分:"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CookingMaster.My.Resources.Resources.美式餐廳背景圖
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.finish)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.trashcan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.halfood_pan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pan)
        Me.Controls.Add(Me.vegetablebox)
        Me.Controls.Add(Me.cheesebox)
        Me.Controls.Add(Me.tomatobox)
        Me.Controls.Add(Me.meatbox)
        Me.Controls.Add(Me.breadbox)
        Me.Controls.Add(Me.HalfFood)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.item)
        Me.Controls.Add(Me.character)
        Me.Controls.Add(Me.plateitem3)
        Me.Controls.Add(Me.plateitem2)
        Me.Controls.Add(Me.plateitem1)
        Me.Controls.Add(Me.plate)
        Me.Controls.Add(Me.namaita)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Form7"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.halfood_pan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.finish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vegetablebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheesebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tomatobox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meatbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.breadbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HalfFood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.character, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plateitem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plateitem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plateitem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.namaita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trashcan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HalfFood As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents item As PictureBox
    Friend WithEvents plateitem3 As PictureBox
    Friend WithEvents plateitem2 As PictureBox
    Friend WithEvents plateitem1 As PictureBox
    Friend WithEvents plate As PictureBox
    Friend WithEvents namaita As PictureBox
    Public WithEvents Label1 As Label
    Friend WithEvents breadbox As PictureBox
    Friend WithEvents meatbox As PictureBox
    Friend WithEvents tomatobox As PictureBox
    Friend WithEvents cheesebox As PictureBox
    Friend WithEvents vegetablebox As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents pan As PictureBox
    Friend WithEvents finish As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents halfood_pan As PictureBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents trashcan As PictureBox
    Public WithEvents character As PictureBox
    Public WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
