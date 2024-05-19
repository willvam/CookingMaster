<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.trashcan = New System.Windows.Forms.PictureBox()
        Me.HalfFood = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tofuskinbox = New System.Windows.Forms.PictureBox()
        Me.shrimpbox = New System.Windows.Forms.PictureBox()
        Me.item = New System.Windows.Forms.PictureBox()
        Me.character = New System.Windows.Forms.PictureBox()
        Me.finish = New System.Windows.Forms.PictureBox()
        Me.seaweed = New System.Windows.Forms.PictureBox()
        Me.plateitem3 = New System.Windows.Forms.PictureBox()
        Me.plateitem2 = New System.Windows.Forms.PictureBox()
        Me.plateitem1 = New System.Windows.Forms.PictureBox()
        Me.rice = New System.Windows.Forms.PictureBox()
        Me.plate = New System.Windows.Forms.PictureBox()
        Me.fishbox = New System.Windows.Forms.PictureBox()
        Me.namaita = New System.Windows.Forms.PictureBox()
        CType(Me.trashcan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HalfFood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tofuskinbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shrimpbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.character, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.finish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seaweed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plateitem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plateitem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plateitem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fishbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.namaita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(688, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1147, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 12)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "得分:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1156, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 12)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(843, 536)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 12)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 5000
        '
        'trashcan
        '
        Me.trashcan.Image = Global.CookingMaster.My.Resources.Resources.垃圾桶
        Me.trashcan.Location = New System.Drawing.Point(479, 554)
        Me.trashcan.Margin = New System.Windows.Forms.Padding(2)
        Me.trashcan.Name = "trashcan"
        Me.trashcan.Size = New System.Drawing.Size(111, 114)
        Me.trashcan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.trashcan.TabIndex = 25
        Me.trashcan.TabStop = False
        Me.trashcan.Visible = False
        '
        'HalfFood
        '
        Me.HalfFood.Location = New System.Drawing.Point(803, 574)
        Me.HalfFood.Margin = New System.Windows.Forms.Padding(2)
        Me.HalfFood.Name = "HalfFood"
        Me.HalfFood.Size = New System.Drawing.Size(30, 32)
        Me.HalfFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HalfFood.TabIndex = 24
        Me.HalfFood.TabStop = False
        Me.HalfFood.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(386, 1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(167, 151)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(190, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(167, 152)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CookingMaster.My.Resources.Resources.DishList1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'tofuskinbox
        '
        Me.tofuskinbox.Image = Global.CookingMaster.My.Resources.Resources.食材箱_豆皮
        Me.tofuskinbox.Location = New System.Drawing.Point(793, 216)
        Me.tofuskinbox.Margin = New System.Windows.Forms.Padding(2)
        Me.tofuskinbox.Name = "tofuskinbox"
        Me.tofuskinbox.Size = New System.Drawing.Size(142, 99)
        Me.tofuskinbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tofuskinbox.TabIndex = 18
        Me.tofuskinbox.TabStop = False
        Me.tofuskinbox.Visible = False
        '
        'shrimpbox
        '
        Me.shrimpbox.Image = Global.CookingMaster.My.Resources.Resources.食材箱_蝦
        Me.shrimpbox.Location = New System.Drawing.Point(629, 216)
        Me.shrimpbox.Margin = New System.Windows.Forms.Padding(2)
        Me.shrimpbox.Name = "shrimpbox"
        Me.shrimpbox.Size = New System.Drawing.Size(132, 99)
        Me.shrimpbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.shrimpbox.TabIndex = 16
        Me.shrimpbox.TabStop = False
        Me.shrimpbox.Visible = False
        '
        'item
        '
        Me.item.Location = New System.Drawing.Point(501, 374)
        Me.item.Margin = New System.Windows.Forms.Padding(2)
        Me.item.Name = "item"
        Me.item.Size = New System.Drawing.Size(33, 34)
        Me.item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.item.TabIndex = 4
        Me.item.TabStop = False
        '
        'character
        '
        Me.character.Image = Global.CookingMaster.My.Resources.Resources.ch1
        Me.character.Location = New System.Drawing.Point(501, 374)
        Me.character.Name = "character"
        Me.character.Size = New System.Drawing.Size(74, 74)
        Me.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.character.TabIndex = 1
        Me.character.TabStop = False
        '
        'finish
        '
        Me.finish.BackColor = System.Drawing.Color.Gold
        Me.finish.Location = New System.Drawing.Point(1482, 933)
        Me.finish.Margin = New System.Windows.Forms.Padding(2)
        Me.finish.Name = "finish"
        Me.finish.Size = New System.Drawing.Size(131, 96)
        Me.finish.TabIndex = 12
        Me.finish.TabStop = False
        Me.finish.Visible = False
        '
        'seaweed
        '
        Me.seaweed.Image = Global.CookingMaster.My.Resources.Resources.食材箱_海苔
        Me.seaweed.Location = New System.Drawing.Point(275, 216)
        Me.seaweed.Margin = New System.Windows.Forms.Padding(2)
        Me.seaweed.Name = "seaweed"
        Me.seaweed.Size = New System.Drawing.Size(156, 99)
        Me.seaweed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.seaweed.TabIndex = 11
        Me.seaweed.TabStop = False
        Me.seaweed.Visible = False
        '
        'plateitem3
        '
        Me.plateitem3.Location = New System.Drawing.Point(375, 957)
        Me.plateitem3.Margin = New System.Windows.Forms.Padding(0)
        Me.plateitem3.Name = "plateitem3"
        Me.plateitem3.Size = New System.Drawing.Size(30, 32)
        Me.plateitem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.plateitem3.TabIndex = 10
        Me.plateitem3.TabStop = False
        Me.plateitem3.Visible = False
        '
        'plateitem2
        '
        Me.plateitem2.Location = New System.Drawing.Point(339, 957)
        Me.plateitem2.Margin = New System.Windows.Forms.Padding(2)
        Me.plateitem2.Name = "plateitem2"
        Me.plateitem2.Size = New System.Drawing.Size(30, 32)
        Me.plateitem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.plateitem2.TabIndex = 9
        Me.plateitem2.TabStop = False
        Me.plateitem2.Visible = False
        '
        'plateitem1
        '
        Me.plateitem1.Location = New System.Drawing.Point(305, 957)
        Me.plateitem1.Margin = New System.Windows.Forms.Padding(2)
        Me.plateitem1.Name = "plateitem1"
        Me.plateitem1.Size = New System.Drawing.Size(30, 32)
        Me.plateitem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.plateitem1.TabIndex = 8
        Me.plateitem1.TabStop = False
        Me.plateitem1.Visible = False
        '
        'rice
        '
        Me.rice.Image = Global.CookingMaster.My.Resources.Resources.食材箱_米飯
        Me.rice.Location = New System.Drawing.Point(963, 216)
        Me.rice.Name = "rice"
        Me.rice.Size = New System.Drawing.Size(144, 99)
        Me.rice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rice.TabIndex = 7
        Me.rice.TabStop = False
        Me.rice.Visible = False
        '
        'plate
        '
        Me.plate.BackColor = System.Drawing.SystemColors.Control
        Me.plate.Image = Global.CookingMaster.My.Resources.Resources.plate
        Me.plate.Location = New System.Drawing.Point(294, 933)
        Me.plate.Name = "plate"
        Me.plate.Size = New System.Drawing.Size(128, 96)
        Me.plate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.plate.TabIndex = 6
        Me.plate.TabStop = False
        Me.plate.Visible = False
        '
        'fishbox
        '
        Me.fishbox.Image = Global.CookingMaster.My.Resources.Resources.食材箱_魚
        Me.fishbox.Location = New System.Drawing.Point(452, 216)
        Me.fishbox.Margin = New System.Windows.Forms.Padding(2)
        Me.fishbox.Name = "fishbox"
        Me.fishbox.Size = New System.Drawing.Size(145, 99)
        Me.fishbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fishbox.TabIndex = 5
        Me.fishbox.TabStop = False
        Me.fishbox.Visible = False
        '
        'namaita
        '
        Me.namaita.Cursor = System.Windows.Forms.Cursors.Default
        Me.namaita.Image = Global.CookingMaster.My.Resources.Resources.桌子_砧板
        Me.namaita.Location = New System.Drawing.Point(803, 574)
        Me.namaita.Margin = New System.Windows.Forms.Padding(2)
        Me.namaita.Name = "namaita"
        Me.namaita.Size = New System.Drawing.Size(133, 94)
        Me.namaita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.namaita.TabIndex = 3
        Me.namaita.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CookingMaster.My.Resources.Resources.日式餐廳背景圖
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.trashcan)
        Me.Controls.Add(Me.HalfFood)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tofuskinbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.shrimpbox)
        Me.Controls.Add(Me.item)
        Me.Controls.Add(Me.character)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.finish)
        Me.Controls.Add(Me.seaweed)
        Me.Controls.Add(Me.plateitem3)
        Me.Controls.Add(Me.plateitem2)
        Me.Controls.Add(Me.plateitem1)
        Me.Controls.Add(Me.rice)
        Me.Controls.Add(Me.plate)
        Me.Controls.Add(Me.fishbox)
        Me.Controls.Add(Me.namaita)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.trashcan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HalfFood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tofuskinbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shrimpbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.character, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.finish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seaweed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plateitem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plateitem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plateitem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fishbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.namaita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Label1 As Label
    Friend WithEvents namaita As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents item As PictureBox
    Friend WithEvents fishbox As PictureBox
    Friend WithEvents plate As PictureBox
    Friend WithEvents rice As PictureBox
    Friend WithEvents plateitem1 As PictureBox
    Friend WithEvents plateitem2 As PictureBox
    Friend WithEvents plateitem3 As PictureBox
    Friend WithEvents seaweed As PictureBox
    Friend WithEvents finish As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents shrimpbox As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tofuskinbox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents HalfFood As PictureBox
    Public WithEvents Label3 As Label
    Friend WithEvents trashcan As PictureBox
    Public WithEvents character As PictureBox
End Class
