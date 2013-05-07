<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.kekiri = New System.Windows.Forms.PictureBox
        Me.kekanan = New System.Windows.Forms.PictureBox
        Me.Ikan = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Score = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.HighScore = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TujuanX = New System.Windows.Forms.TextBox
        Me.TujuanY = New System.Windows.Forms.TextBox
        Me.Speed = New System.Windows.Forms.TextBox
        Me.Interval = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.randomtujuan = New System.Windows.Forms.Timer(Me.components)
        Me.CountDown = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Time = New System.Windows.Forms.Label
        CType(Me.kekiri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kekanan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ikan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'kekiri
        '
        Me.kekiri.BackColor = System.Drawing.Color.Transparent
        Me.kekiri.Image = Global.iwak.My.Resources.Resources._2
        Me.kekiri.Location = New System.Drawing.Point(26, 12)
        Me.kekiri.Name = "kekiri"
        Me.kekiri.Size = New System.Drawing.Size(158, 143)
        Me.kekiri.TabIndex = 1
        Me.kekiri.TabStop = False
        '
        'kekanan
        '
        Me.kekanan.BackColor = System.Drawing.Color.Transparent
        Me.kekanan.Image = Global.iwak.My.Resources.Resources._1
        Me.kekanan.Location = New System.Drawing.Point(608, 233)
        Me.kekanan.Name = "kekanan"
        Me.kekanan.Size = New System.Drawing.Size(163, 145)
        Me.kekanan.TabIndex = 0
        Me.kekanan.TabStop = False
        '
        'Ikan
        '
        Me.Ikan.BackColor = System.Drawing.Color.Transparent
        Me.Ikan.Location = New System.Drawing.Point(403, 34)
        Me.Ikan.Name = "Ikan"
        Me.Ikan.Size = New System.Drawing.Size(163, 134)
        Me.Ikan.TabIndex = 2
        Me.Ikan.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Score"
        '
        'Score
        '
        Me.Score.AutoSize = True
        Me.Score.Location = New System.Drawing.Point(134, 29)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(13, 13)
        Me.Score.TabIndex = 4
        Me.Score.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "High Score"
        '
        'HighScore
        '
        Me.HighScore.AutoSize = True
        Me.HighScore.Location = New System.Drawing.Point(134, 61)
        Me.HighScore.Name = "HighScore"
        Me.HighScore.Size = New System.Drawing.Size(13, 13)
        Me.HighScore.TabIndex = 6
        Me.HighScore.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Speed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Interval"
        '
        'TujuanX
        '
        Me.TujuanX.AcceptsReturn = True
        Me.TujuanX.Location = New System.Drawing.Point(181, 22)
        Me.TujuanX.Name = "TujuanX"
        Me.TujuanX.Size = New System.Drawing.Size(23, 20)
        Me.TujuanX.TabIndex = 11
        Me.TujuanX.Text = "0"
        '
        'TujuanY
        '
        Me.TujuanY.AcceptsReturn = True
        Me.TujuanY.Location = New System.Drawing.Point(181, 58)
        Me.TujuanY.Name = "TujuanY"
        Me.TujuanY.Size = New System.Drawing.Size(23, 20)
        Me.TujuanY.TabIndex = 12
        Me.TujuanY.Text = "0"
        '
        'Speed
        '
        Me.Speed.AcceptsReturn = True
        Me.Speed.Location = New System.Drawing.Point(104, 101)
        Me.Speed.Name = "Speed"
        Me.Speed.Size = New System.Drawing.Size(100, 20)
        Me.Speed.TabIndex = 13
        Me.Speed.Text = "20"
        '
        'Interval
        '
        Me.Interval.AcceptsReturn = True
        Me.Interval.Location = New System.Drawing.Point(104, 128)
        Me.Interval.Name = "Interval"
        Me.Interval.Size = New System.Drawing.Size(100, 20)
        Me.Interval.TabIndex = 14
        Me.Interval.Text = "50"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'randomtujuan
        '
        Me.randomtujuan.Enabled = True
        Me.randomtujuan.Interval = 1
        '
        'CountDown
        '
        Me.CountDown.Interval = 1000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 161)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(204, 22)
        Me.ProgressBar1.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Interval)
        Me.GroupBox1.Controls.Add(Me.Time)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Speed)
        Me.GroupBox1.Controls.Add(Me.TujuanY)
        Me.GroupBox1.Controls.Add(Me.TujuanX)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.HighScore)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Score)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 360)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 189)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Setting"
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.Location = New System.Drawing.Point(92, 166)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(13, 13)
        Me.Time.TabIndex = 16
        Me.Time.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.iwak.My.Resources.Resources.FindingNemoWallpaper800
        Me.ClientSize = New System.Drawing.Size(800, 544)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Ikan)
        Me.Controls.Add(Me.kekiri)
        Me.Controls.Add(Me.kekanan)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        CType(Me.kekiri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kekanan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ikan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents kekanan As System.Windows.Forms.PictureBox
    Friend WithEvents kekiri As System.Windows.Forms.PictureBox
    Friend WithEvents Ikan As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Score As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HighScore As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TujuanX As System.Windows.Forms.TextBox
    Friend WithEvents TujuanY As System.Windows.Forms.TextBox
    Friend WithEvents Speed As System.Windows.Forms.TextBox
    Friend WithEvents Interval As System.Windows.Forms.TextBox
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents randomtujuan As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents CountDown As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Time As System.Windows.Forms.Label

End Class
