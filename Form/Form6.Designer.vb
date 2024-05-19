<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.oven = New System.Windows.Forms.PictureBox()
        Me.finish = New System.Windows.Forms.PictureBox()
        Me.trashcan = New System.Windows.Forms.PictureBox()
        Me.eggbox = New System.Windows.Forms.PictureBox()
        Me.chocolatebox = New System.Windows.Forms.PictureBox()
        Me.hoenybox = New System.Windows.Forms.PictureBox()
        Me.flourbox = New System.Windows.Forms.PictureBox()
        Me.strawbarrybox = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.item = New System.Windows.Forms.PictureBox()
        Me.character = New System.Windows.Forms.PictureBox()
        Me.plateitem3 = New System.Windows.Forms.PictureBox()
        Me.plateitem2 = New System.Windows.Forms.PictureBox()
        Me.plateitem1 = New System.Windows.Forms.PictureBox()
        Me.plate = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.oven, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.finish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trashcan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eggbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chocolatebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hoenybox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flourbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.strawbarrybox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.character, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plateitem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plateitem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plateitem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(858, 486)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 12)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(683, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1337, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 12)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "0"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 873)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 12)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'oven
        '
        Me.oven.Image = Global.CookingMaster.My.Resources.Resources.桌子_烤箱_空_
        Me.oven.Location = New System.Drawing.Point(246, 888)
        Me.oven.Name = "oven"
        Me.oven.Size = New System.Drawing.Size(196, 158)
        Me.oven.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.oven.TabIndex = 60
        Me.oven.TabStop = False
        Me.oven.Tag = "0"
        '
        'finish
        '
        Me.finish.Image = Global.CookingMaster.My.Resources.Resources.出餐口
        Me.finish.Location = New System.Drawing.Point(597, 888)
        Me.finish.Name = "finish"
        Me.finish.Size = New System.Drawing.Size(198, 158)
        Me.finish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.finish.TabIndex = 58
        Me.finish.TabStop = False
        Me.finish.Visible = False
        '
        'trashcan
        '
        Me.trashcan.Image = Global.CookingMaster.My.Resources.Resources.垃圾桶
        Me.trashcan.Location = New System.Drawing.Point(1137, 500)
        Me.trashcan.Margin = New System.Windows.Forms.Padding(2)
        Me.trashcan.Name = "trashcan"
        Me.trashcan.Size = New System.Drawing.Size(162, 172)
        Me.trashcan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.trashcan.TabIndex = 56
        Me.trashcan.TabStop = False
        Me.trashcan.Visible = False
        '
        'eggbox
        '
        Me.eggbox.Image = Global.CookingMaster.My.Resources.Resources.食材箱_雞蛋
        Me.eggbox.Location = New System.Drawing.Point(1295, 186)
        Me.eggbox.Name = "eggbox"
        Me.eggbox.Size = New System.Drawing.Size(175, 135)
        Me.eggbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.eggbox.TabIndex = 55
        Me.eggbox.TabStop = False
        Me.eggbox.Visible = False
        '
        'chocolatebox
        '
        Me.chocolatebox.Image = Global.CookingMaster.My.Resources.Resources.食材箱_巧克力
        Me.chocolatebox.Location = New System.Drawing.Point(953, 186)
        Me.chocolatebox.Name = "chocolatebox"
        Me.chocolatebox.Size = New System.Drawing.Size(175, 135)
        Me.chocolatebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.chocolatebox.TabIndex = 54
        Me.chocolatebox.TabStop = False
        Me.chocolatebox.Visible = False
        '
        'hoenybox
        '
        Me.hoenybox.Image = Global.CookingMaster.My.Resources.Resources.食材箱_蜂蜜
        Me.hoenybox.Location = New System.Drawing.Point(1122, 186)
        Me.hoenybox.Name = "hoenybox"
        Me.hoenybox.Size = New System.Drawing.Size(177, 135)
        Me.hoenybox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hoenybox.TabIndex = 53
        Me.hoenybox.TabStop = False
        Me.hoenybox.Visible = False
        '
        'flourbox
        '
        Me.flourbox.Image = Global.CookingMaster.My.Resources.Resources.食材箱_麵粉
        Me.flourbox.Location = New System.Drawing.Point(1467, 186)
        Me.flourbox.Name = "flourbox"
        Me.flourbox.Size = New System.Drawing.Size(171, 135)
        Me.flourbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.flourbox.TabIndex = 52
        Me.flourbox.TabStop = False
        Me.flourbox.Visible = False
        '
        'strawbarrybox
        '
        Me.strawbarrybox.Image = Global.CookingMaster.My.Resources.Resources.食材箱_草莓
        Me.strawbarrybox.Location = New System.Drawing.Point(780, 186)
        Me.strawbarrybox.Name = "strawbarrybox"
        Me.strawbarrybox.Size = New System.Drawing.Size(180, 135)
        Me.strawbarrybox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.strawbarrybox.TabIndex = 51
        Me.strawbarrybox.TabStop = False
        Me.strawbarrybox.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(381, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(167, 198)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 50
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(185, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(167, 198)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CookingMaster.My.Resources.Resources.DishList1
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 198)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'item
        '
        Me.item.Location = New System.Drawing.Point(710, 377)
        Me.item.Margin = New System.Windows.Forms.Padding(2)
        Me.item.Name = "item"
        Me.item.Size = New System.Drawing.Size(27, 27)
        Me.item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.item.TabIndex = 40
        Me.item.TabStop = False
        '
        'character
        '
        Me.character.Image = Global.CookingMaster.My.Resources.Resources.ch1
        Me.character.Location = New System.Drawing.Point(710, 377)
        Me.character.Name = "character"
        Me.character.Size = New System.Drawing.Size(74, 74)
        Me.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.character.TabIndex = 38
        Me.character.TabStop = False
        '
        'plateitem3
        '
        Me.plateitem3.Location = New System.Drawing.Point(894, 529)
        Me.plateitem3.Margin = New System.Windows.Forms.Padding(0)
        Me.plateitem3.Name = "plateitem3"
        Me.plateitem3.Size = New System.Drawing.Size(30, 32)
        Me.plateitem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.plateitem3.TabIndex = 44
        Me.plateitem3.TabStop = False
        Me.plateitem3.Visible = False
        '
        'plateitem2
        '
        Me.plateitem2.Location = New System.Drawing.Point(849, 529)
        Me.plateitem2.Margin = New System.Windows.Forms.Padding(2)
        Me.plateitem2.Name = "plateitem2"
        Me.plateitem2.Size = New System.Drawing.Size(30, 32)
        Me.plateitem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.plateitem2.TabIndex = 43
        Me.plateitem2.TabStop = False
        Me.plateitem2.Visible = False
        '
        'plateitem1
        '
        Me.plateitem1.Location = New System.Drawing.Point(799, 529)
        Me.plateitem1.Margin = New System.Windows.Forms.Padding(2)
        Me.plateitem1.Name = "plateitem1"
        Me.plateitem1.Size = New System.Drawing.Size(30, 32)
        Me.plateitem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.plateitem1.TabIndex = 42
        Me.plateitem1.TabStop = False
        Me.plateitem1.Visible = False
        '
        'plate
        '
        Me.plate.BackColor = System.Drawing.SystemColors.Control
        Me.plate.Image = Global.CookingMaster.My.Resources.Resources.桌子_攪拌機_空_
        Me.plate.Location = New System.Drawing.Point(799, 513)
        Me.plate.Name = "plate"
        Me.plate.Size = New System.Drawing.Size(143, 159)
        Me.plate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.plate.TabIndex = 41
        Me.plate.TabStop = False
        Me.plate.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1337, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 12)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "得分:"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CookingMaster.My.Resources.Resources.蛋糕店背景圖
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.oven)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.finish)
        Me.Controls.Add(Me.trashcan)
        Me.Controls.Add(Me.eggbox)
        Me.Controls.Add(Me.chocolatebox)
        Me.Controls.Add(Me.hoenybox)
        Me.Controls.Add(Me.flourbox)
        Me.Controls.Add(Me.strawbarrybox)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.item)
        Me.Controls.Add(Me.character)
        Me.Controls.Add(Me.plateitem3)
        Me.Controls.Add(Me.plateitem2)
        Me.Controls.Add(Me.plateitem1)
        Me.Controls.Add(Me.plate)
        Me.DoubleBuffered = True
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.oven, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.finish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trashcan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eggbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chocolatebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hoenybox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flourbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.strawbarrybox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.character, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plateitem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plateitem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plateitem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents item As PictureBox
    Friend WithEvents plateitem3 As PictureBox
    Friend WithEvents plateitem2 As PictureBox
    Friend WithEvents plateitem1 As PictureBox
    Friend WithEvents plate As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents Label1 As Label
    Friend WithEvents eggbox As PictureBox
    Friend WithEvents chocolatebox As PictureBox
    Friend WithEvents hoenybox As PictureBox
    Friend WithEvents flourbox As PictureBox
    Friend WithEvents strawbarrybox As PictureBox
    Friend WithEvents trashcan As PictureBox
    Friend WithEvents finish As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents oven As PictureBox
    Friend WithEvents Timer3 As Timer
    Public WithEvents character As PictureBox
    Friend WithEvents Label4 As Label
    Public WithEvents Label3 As Label
End Class
