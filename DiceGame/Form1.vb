Public Class Form1

    Dim Dice1, Dice2 As Integer
    Dim Random As Random


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TmrTimer.Start()
        My.Computer.Audio.Play(My.Resources.dice_roll, AudioPlayMode.Background)
    End Sub

    Private Sub Lbl_DiceRoll_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub PrgProgressBar_Click(sender As Object, e As EventArgs) Handles PrgProgressBar.Click

    End Sub

    Private Sub TmrTimer_Tick(sender As Object, e As EventArgs) Handles TmrTimer.Tick

        Random = New Random
        PrgProgressBar.Increment(5)

        If PrgProgressBar.Value = 100 Then
            TmrTimer.Stop()
            PrgProgressBar.Value = 0
            PrgProgressBar.Hide()
            Button1.Show()
            Button2.Show()
            TextBox1.Hide()
            TextBox2.Hide()
            TextBox3.Show()
            TextBox4.Show()
        Else
            PrgProgressBar.Show()
            Button1.Hide()
            Button2.Hide()
            TextBox1.Show()
            TextBox2.Show()
            TextBox3.Hide()
            TextBox4.Hide()
            Dice1 = Random.Next(1, 7)
            Dice2 = Random.Next(1, 7)
            TextBox1.Text = Dice1
            TextBox2.Text = Dice2
            TextBox3.Text = Dice1 + Dice2

            Dim num As Integer
            num = Dice1 + Dice2

            If num = 2 Then
                TextBox4.Text = "2 BOSS? Du-te acasa ca esti slab"
            ElseIf num = 3 Then
                TextBox4.Text = "Pai ce facem aici sefule pierdem vremea?"
            ElseIf num = 4 Then
                TextBox4.Text = "Pfaaii the plm sa dus casa!"
            ElseIf num = 5 Then
                TextBox4.Text = "5? sa-mi bag pl am piedut masina!"
            ElseIf num = 6 Then
                TextBox4.Text = "Sa moara Veta daca nu zarurile sunt masluite"
            ElseIf num = 7 Then
                TextBox4.Text = "Ma omoara femeia acasa"
            ElseIf num = 8 Then
                TextBox4.Text = "Sa ma bata mama mai bine mergeam la pacanele"
            ElseIf num = 9 Then
                TextBox4.Text = "9? asta e tot ce aveam nevoie"
            ElseIf num = 10 Then
                TextBox4.Text = "Sa moara Gina, 10!"
            ElseIf num = 11 Then
                TextBox4.Text = "Ai de plm am pierdut banii de paine"
            ElseIf num = 12 Then
                TextBox4.Text = "Ai sa-mi da-i o tigara? manca-ti-as ochii!"
            End If


            If Dice1 = 1 Then
                Pic_Dice1.Image = My.Resources.dice_1
            ElseIf Dice1 = 2 Then
                Pic_Dice1.Image = My.Resources.dice_2
            ElseIf Dice1 = 3 Then
                Pic_Dice1.Image = My.Resources.dice_3
            ElseIf Dice1 = 4 Then
                Pic_Dice1.Image = My.Resources.dice_4
            ElseIf Dice1 = 5 Then
                Pic_Dice1.Image = My.Resources.dice_5
            ElseIf Dice1 = 6 Then
                Pic_Dice1.Image = My.Resources.dice_6
            End If

            If Dice2 = 1 Then
                PicDice2.Image = My.Resources.dice_1
            ElseIf Dice2 = 2 Then
                PicDice2.Image = My.Resources.dice_2
            ElseIf Dice2 = 3 Then
                PicDice2.Image = My.Resources.dice_3
            ElseIf Dice2 = 4 Then
                PicDice2.Image = My.Resources.dice_4
            ElseIf Dice2 = 5 Then
                PicDice2.Image = My.Resources.dice_5
            ElseIf Dice2 = 6 Then
                PicDice2.Image = My.Resources.dice_6
            End If



        End If

    End Sub
End Class
