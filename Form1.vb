Public Class Form1
    Dim score As Integer = 0
    Dim lives As Integer = 3
    Dim gameOver As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScore.Text = "Score: 0"
        lblLives.Text = "Lives: 3"
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        gameOver = False
        Timer1.Start()
    End Sub

    Protected Overrides Function ProcessCmdKey(
    ByRef msg As Message,
    keyData As Keys
) As Boolean

        If Not gameOver Then
            Select Case keyData
                Case Keys.Left
                    PictureBoxPlayer.Left =
                    Math.Max(0, PictureBoxPlayer.Left - 10)
                    Return True

                Case Keys.Right
                    PictureBoxPlayer.Left =
                    Math.Min(Me.ClientSize.Width - PictureBoxPlayer.Width,
                             PictureBoxPlayer.Left + 10)
                    Return True
            End Select
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If gameOver Then Exit Sub

        PictureBoxEnemy.Top += 5

        If PictureBoxEnemy.Bounds.IntersectsWith(PictureBoxPlayer.Bounds) Then
            score += 1
            lblScore.Text = "Score: " & score.ToString()
            PictureBoxEnemy.Top = 0
        End If

        If PictureBoxEnemy.Top > Me.ClientSize.Height Then
            lives -= 1
            lblLives.Text = "Lives: " & lives.ToString()
            PictureBoxEnemy.Top = 0
        End If

        If lives <= 0 Then
            Timer1.Stop()
            gameOver = True
            MessageBox.Show("Game Over")
        End If
    End Sub

End Class
