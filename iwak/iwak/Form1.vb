Public Class Form1
    Dim detik As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CountDown.Start()
        Timer1.Start()


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If (Ikan.Left) < CDbl(TujuanX.Text) Then
            Ikan.Image = kekanan.Image
            Ikan.Left = (Ikan.Left) + CDbl(Speed.Text)
        End If
        If (Ikan.Left) > CDbl(TujuanX.Text) Then
            Ikan.Image = kekiri.Image
            Ikan.Left = (Ikan.Left) - CDbl(Speed.Text)
        End If
        If Ikan.Top < CDbl(TujuanY.Text) Then
            Ikan.Top = (Ikan.Top) + CDbl(Speed.Text)
        End If
        If Ikan.Top > CDbl(TujuanY.Text) Then
            Ikan.Top = (Ikan.Top) - CDbl(Speed.Text)
        End If
    End Sub

    Private Sub Ikan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ikan.Click
        Score.Text = CStr(CDbl(Score.Text) + 1)
        Speed.Text = CStr(CDbl(Speed.Text) + 20)
        Ikan.Tag = Int(Rnd() * 4)
        If CDbl(Ikan.Tag) = 0 Then
            Ikan.Top = (-3000)
        End If
        If CDbl(Ikan.Tag) = 1 Then
            Ikan.Top = (-3000)
        End If
        If CDbl(Ikan.Tag) = 2 Then
            Ikan.Left = (-3000)
        End If
        If CDbl(Ikan.Tag) = 3 Then
            Ikan.Left = (-3000)
        End If
        Time.Text = CStr(CDbl(Time.Text) + 2 + 150 \ CDbl(Speed.Text))
    End Sub

    Private Sub randomtujuan_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles randomtujuan.Tick
        TujuanY.Text = CStr(Int(Rnd() * (Height) - (Ikan.Height)))
        TujuanX.Text = CStr(Int(Rnd() * (Width) - (Ikan.Width)))
        randomtujuan.Interval = 100 + Int(Rnd() * 3000)
    End Sub

    Private Sub CountDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountDown.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 2
        ElseIf ProgressBar1.Value = 100 Then
            CountDown.Stop()
            Timer1.Stop()
            MessageBox.Show("Maaf Waktu Telah Habis ", "info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub kekanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kekanan.Click

    End Sub
End Class
