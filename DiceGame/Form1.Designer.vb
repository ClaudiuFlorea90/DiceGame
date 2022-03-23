<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Pic_Dice1 = New System.Windows.Forms.PictureBox()
        Me.PicDice2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrgProgressBar = New System.Windows.Forms.ProgressBar()
        Me.TmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        CType(Me.Pic_Dice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDice2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pic_Dice1
        '
        Me.Pic_Dice1.Location = New System.Drawing.Point(12, 12)
        Me.Pic_Dice1.Name = "Pic_Dice1"
        Me.Pic_Dice1.Size = New System.Drawing.Size(150, 150)
        Me.Pic_Dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Dice1.TabIndex = 1
        Me.Pic_Dice1.TabStop = False
        '
        'PicDice2
        '
        Me.PicDice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PicDice2.Location = New System.Drawing.Point(288, 12)
        Me.PicDice2.Name = "PicDice2"
        Me.PicDice2.Size = New System.Drawing.Size(150, 150)
        Me.PicDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicDice2.TabIndex = 1
        Me.PicDice2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(367, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrgProgressBar
        '
        Me.PrgProgressBar.Location = New System.Drawing.Point(12, 357)
        Me.PrgProgressBar.Name = "PrgProgressBar"
        Me.PrgProgressBar.Size = New System.Drawing.Size(426, 29)
        Me.PrgProgressBar.TabIndex = 4
        Me.PrgProgressBar.Visible = False
        '
        'TmrTimer
        '
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button2.Location = New System.Drawing.Point(168, 246)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 105)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Roll Dice!"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(67, 168)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(34, 23)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.Location = New System.Drawing.Point(343, 168)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(32, 23)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox3.Location = New System.Drawing.Point(168, 72)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(114, 58)
        Me.TextBox3.TabIndex = 7
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox4.Location = New System.Drawing.Point(12, 188)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(426, 28)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(450, 396)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PrgProgressBar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PicDice2)
        Me.Controls.Add(Me.Pic_Dice1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Barbut"
        CType(Me.Pic_Dice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDice2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pic_Dice1 As PictureBox
    Friend WithEvents PicDice2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PrgProgressBar As ProgressBar
    Friend WithEvents TmrTimer As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
