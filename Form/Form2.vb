Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim f3 As New Form3
        f3.Owner = Me
        f3.Show()
        If RadioButton1.Checked = True Then
            f3.Label2.Text = "1"
        ElseIf RadioButton1.Checked = False Then
            f3.Label2.Text = "2"
        End If
        Me.Hide()
    End Sub
    Private Sub GroupBox1_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox1.Paint
        e.Graphics.Clear(SystemColors.Control)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    '同上
End Class