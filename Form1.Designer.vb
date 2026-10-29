<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnStart = New Button()
        PictureBoxEnemy = New PictureBox()
        lblScore = New Label()
        lblLives = New Label()
        PictureBoxPlayer = New PictureBox()
        Timer1 = New Timer(components)
        CType(PictureBoxEnemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxPlayer, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(298, 338)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(128, 41)
        btnStart.TabIndex = 0
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' PictureBoxEnemy
        ' 
        PictureBoxEnemy.Image = CType(resources.GetObject("PictureBoxEnemy.Image"), Image)
        PictureBoxEnemy.Location = New Point(281, 152)
        PictureBoxEnemy.Name = "PictureBoxEnemy"
        PictureBoxEnemy.Size = New Size(59, 43)
        PictureBoxEnemy.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxEnemy.TabIndex = 1
        PictureBoxEnemy.TabStop = False
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Location = New Point(28, 84)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(46, 20)
        lblScore.TabIndex = 2
        lblScore.Text = "Score"
        ' 
        ' lblLives
        ' 
        lblLives.AutoSize = True
        lblLives.Location = New Point(28, 129)
        lblLives.Name = "lblLives"
        lblLives.Size = New Size(41, 20)
        lblLives.TabIndex = 2
        lblLives.Text = "Lives"
        ' 
        ' PictureBoxPlayer
        ' 
        PictureBoxPlayer.Image = CType(resources.GetObject("PictureBoxPlayer.Image"), Image)
        PictureBoxPlayer.Location = New Point(136, 317)
        PictureBoxPlayer.Name = "PictureBoxPlayer"
        PictureBoxPlayer.Size = New Size(52, 37)
        PictureBoxPlayer.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxPlayer.TabIndex = 3
        PictureBoxPlayer.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBoxPlayer)
        Controls.Add(lblLives)
        Controls.Add(lblScore)
        Controls.Add(PictureBoxEnemy)
        Controls.Add(btnStart)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBoxEnemy, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxPlayer, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents PictureBoxEnemy As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents lblLives As Label
    Friend WithEvents PictureBoxPlayer As PictureBox
    Friend WithEvents Timer1 As Timer

End Class
