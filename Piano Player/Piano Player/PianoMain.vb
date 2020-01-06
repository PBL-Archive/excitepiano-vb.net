Public Class PianoMainForm
    Private Sub PianoMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PianoMainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        MessageBox.Show("Turn")
        If e.KeyCode = Keys.NumPad4 Then
            HighPitchRadioButton.Checked = True
        End If
        If e.KeyCode = Keys.NumPad3 Then
            Mid_HighPitchRadioButton.Checked = True
        End If
        If e.KeyCode = Keys.NumPad2 Then
            Mid_LowPitchRadioButton.Checked = True
        End If
        If e.KeyCode = Keys.NumPad1 Then
            LowPitchRadioButton.Checked = True
        End If
    End Sub

    Private Sub ExitWindow_Click(sender As Object, e As EventArgs) Handles exitWindow.Click
        Me.Close()
    End Sub

    Private Sub HighPitchRadioButton_KeyDown(sender As Object, e As KeyEventArgs) Handles HighPitchRadioButton.KeyDown
        If HighPitchRadioButton.Checked Then

            '___________________________________________Key_Q_____________________________________________'
            If e.KeyCode = Keys.Q Then
                My.Computer.Audio.Play(My.Resources._39148__jobro__piano_ff_001, AudioPlayMode.Background)
                cKeyBackPictureBox.BackColor = Color.Chartreuse
                cLabel.ForeColor = Color.Chartreuse
            Else
                cKeyBackPictureBox.BackColor = Color.White
                cLabel.ForeColor = Color.Black
            End If

            '___________________________________________Key_D2_____________________________________________'
            If e.KeyCode = Keys.D2 Then
                My.Computer.Audio.Play(My.Resources._39149__jobro__piano_ff_002, AudioPlayMode.Background)
                cSharpKeyBackPictureBox.BackColor = Color.Cyan
                cSharpLabel.ForeColor = Color.Cyan
            Else
                cSharpKeyBackPictureBox.BackColor = Color.Black
                cSharpLabel.ForeColor = Color.White
            End If

            '___________________________________________Key_W______________________________________________'
            If e.KeyCode = Keys.W Then
                My.Computer.Audio.Play(My.Resources._39150__jobro__piano_ff_003, AudioPlayMode.Background)
                dKeyBackPictureBox.BackColor = Color.Chartreuse
                dLabel.ForeColor = Color.Chartreuse
            Else
                dKeyBackPictureBox.BackColor = Color.White
                dLabel.ForeColor = Color.Black
            End If

            '___________________________________________Key_D3_____________________________________________'
            If e.KeyCode = Keys.D3 Then
                My.Computer.Audio.Play(My.Resources._39151__jobro__piano_ff_004, AudioPlayMode.Background)
                dSharpKeyBackPictureBox.BackColor = Color.Cyan
                dSharpLabel.ForeColor = Color.Cyan
            Else
                dSharpKeyBackPictureBox.BackColor = Color.Black
                dSharpLabel.ForeColor = Color.White
            End If

            '___________________________________________Key_E______________________________________________'
            If e.KeyCode = Keys.E Then
                My.Computer.Audio.Play(My.Resources._39152__jobro__piano_ff_005, AudioPlayMode.Background)
                eKeyBackPictureBox.BackColor = Color.Chartreuse
                eLabel.ForeColor = Color.Chartreuse
            Else
                eKeyBackPictureBox.BackColor = Color.White
                eLabel.ForeColor = Color.Black
            End If

            '___________________________________________Key_R______________________________________________'
            If e.KeyCode = Keys.R Then
                My.Computer.Audio.Play(My.Resources._39153__jobro__piano_ff_006, AudioPlayMode.Background)
                fKeyBackPictureBox.BackColor = Color.Chartreuse
                fLabel.ForeColor = Color.Chartreuse
            Else
                fKeyBackPictureBox.BackColor = Color.White
                fLabel.ForeColor = Color.Black
            End If

            '___________________________________________Key_D5_____________________________________________'
            If e.KeyCode = Keys.D5 Then
                My.Computer.Audio.Play(My.Resources._39154__jobro__piano_ff_007, AudioPlayMode.Background)
                fSharpKeyBackPictureBox.BackColor = Color.Cyan
                fSharpLabel.ForeColor = Color.Cyan
            Else
                fSharpKeyBackPictureBox.BackColor = Color.Black
                fSharpLabel.ForeColor = Color.White
            End If

            '___________________________________________Key_T______________________________________________'
            If e.KeyCode = Keys.T Then
                My.Computer.Audio.Play(My.Resources._39155__jobro__piano_ff_008, AudioPlayMode.Background)
                gKeyBackPictureBox.BackColor = Color.Chartreuse
                gLabel.ForeColor = Color.Chartreuse
            Else
                gKeyBackPictureBox.BackColor = Color.White
                gLabel.ForeColor = Color.Black
            End If

            '___________________________________________Key_D6_____________________________________________'
            If e.KeyCode = Keys.D6 Then
                My.Computer.Audio.Play(My.Resources._39156__jobro__piano_ff_009, AudioPlayMode.Background)
                gSharpKeyBackPictureBox.BackColor = Color.Cyan
                gSharpLabel.ForeColor = Color.Cyan
            Else
                gSharpKeyBackPictureBox.BackColor = Color.Black
                gSharpLabel.ForeColor = Color.White
            End If

            '___________________________________________Key_Y______________________________________________'
            If e.KeyCode = Keys.Y Then
                My.Computer.Audio.Play(My.Resources._39157__jobro__piano_ff_010, AudioPlayMode.Background)
                aKeyBackPictureBox.BackColor = Color.Chartreuse
                aLabel.ForeColor = Color.Chartreuse
            Else
                aKeyBackPictureBox.BackColor = Color.White
                aLabel.ForeColor = Color.Black
            End If

            '___________________________________________Key_D7_____________________________________________'
            If e.KeyCode = Keys.D7 Then
                My.Computer.Audio.Play(My.Resources._39158__jobro__piano_ff_011, AudioPlayMode.Background)
                aSharpKeyBackPictureBox.BackColor = Color.Cyan
                aSharpLabel.ForeColor = Color.Cyan
            Else
                aSharpKeyBackPictureBox.BackColor = Color.Black
                aSharpLabel.ForeColor = Color.White
            End If

            '___________________________________________Key_U______________________________________________'
            If e.KeyCode = Keys.U Then
                My.Computer.Audio.Play(My.Resources._39159__jobro__piano_ff_012, AudioPlayMode.Background)
                bKeyBackPictureBox.BackColor = Color.Chartreuse
                bLabel.ForeColor = Color.Chartreuse
            Else
                bKeyBackPictureBox.BackColor = Color.White
                bLabel.ForeColor = Color.Black
            End If

            '___________________________________________Key_I______________________________________________'
            If e.KeyCode = Keys.I Then
                My.Computer.Audio.Play(My.Resources._39160__jobro__piano_ff_013, AudioPlayMode.Background)
                cEndKeyBackPictureBox.BackColor = Color.Chartreuse
                cEndLabel.ForeColor = Color.Chartreuse
            Else
                cEndKeyBackPictureBox.BackColor = Color.White
                cEndLabel.ForeColor = Color.Black
            End If

        End If
    End Sub

    Private Sub Mid_highPitchRadioButton_KeyDown(sender As Object, e As KeyEventArgs) Handles Mid_HighPitchRadioButton.KeyDown
        If Mid_HighPitchRadioButton.Checked Then

            '___________________________________________Key_Q_____________________________________________'
            If e.KeyCode = Keys.Q Then
                My.Computer.Audio.Play(My.Resources._39165__jobro__piano_ff_018, AudioPlayMode.Background)
                cKeyBackPictureBox.BackColor = Color.Chartreuse
                cLabel.ForeColor = Color.Chartreuse
            Else
                cKeyBackPictureBox.BackColor = Color.White
                cLabel.ForeColor = Color.Black
            End If

            '___________________________________________Key_D2_____________________________________________'
            If e.KeyCode = Keys.D2 Then
                My.Computer.Audio.Play(My.Resources._39166__jobro__piano_ff_019, AudioPlayMode.Background)
                cSharpKeyBackPictureBox.BackColor = Color.Cyan
                cSharpLabel.ForeColor = Color.Cyan
            Else
                cSharpKeyBackPictureBox.BackColor = Color.Black
                cSharpLabel.ForeColor = Color.White
            End If

            '___________________________________________Key_W______________________________________________'
            If e.KeyCode = Keys.W Then
                My.Computer.Audio.Play(My.Resources._39167__jobro__piano_ff_020, AudioPlayMode.Background)
                dKeyBackPictureBox.BackColor = Color.Chartreuse
                dLabel.ForeColor = Color.Chartreuse
            Else
                dKeyBackPictureBox.BackColor = Color.White
                dLabel.ForeColor = Color.Black
            End If

            '___________________________________________Key_D3_____________________________________________'
            If e.KeyCode = Keys.D3 Then
                My.Computer.Audio.Play(My.Resources._39168__jobro__piano_ff_021, AudioPlayMode.Background)
                dSharpKeyBackPictureBox.BackColor = Color.Cyan
                dSharpLabel.ForeColor = Color.Cyan
            Else
                dSharpKeyBackPictureBox.BackColor = Color.Black
                dSharpLabel.ForeColor = Color.White
            End If

            '___________________________________________Key_E______________________________________________'
            If e.KeyCode = Keys.E Then
                My.Computer.Audio.Play(My.Resources._39169__jobro__piano_ff_022, AudioPlayMode.Background)
                eKeyBackPictureBox.BackColor = Color.Chartreuse
                eLabel.ForeColor = Color.Chartreuse
            Else
                eKeyBackPictureBox.BackColor = Color.White
                eLabel.ForeColor = Color.Black
            End If

            '___________________________________________Key_R______________________________________________'
            If e.KeyCode = Keys.R Then
                My.Computer.Audio.Play(My.Resources._39170__jobro__piano_ff_023, AudioPlayMode.Background)
                fKeyBackPictureBox.BackColor = Color.Chartreuse
                fLabel.ForeColor = Color.Chartreuse
            Else
                fKeyBackPictureBox.BackColor = Color.White
                fLabel.ForeColor = Color.Black
            End If


            '___________________________________________Key_D5_____________________________________________'
            If e.KeyCode = Keys.D5 Then
                My.Computer.Audio.Play(My.Resources._39171__jobro__piano_ff_024, AudioPlayMode.Background)
                fSharpKeyBackPictureBox.BackColor = Color.Cyan
                fSharpLabel.ForeColor = Color.Cyan
            Else
                fSharpKeyBackPictureBox.BackColor = Color.Black
                fSharpLabel.ForeColor = Color.White
            End If

            '___________________________________________Key_T______________________________________________'
            If e.KeyCode = Keys.T Then
                My.Computer.Audio.Play(My.Resources._39172__jobro__piano_ff_025, AudioPlayMode.Background)
                gKeyBackPictureBox.BackColor = Color.Chartreuse
                gLabel.ForeColor = Color.Chartreuse
            Else
                gKeyBackPictureBox.BackColor = Color.White
                gLabel.ForeColor = Color.Black
            End If

            '___________________________________________Key_D6_____________________________________________'
            If e.KeyCode = Keys.D6 Then
                My.Computer.Audio.Play(My.Resources._39173__jobro__piano_ff_026, AudioPlayMode.Background)
                gSharpKeyBackPictureBox.BackColor = Color.Cyan
                gSharpLabel.ForeColor = Color.Cyan
            Else
                gSharpKeyBackPictureBox.BackColor = Color.Black
                gSharpLabel.ForeColor = Color.White
            End If

            '___________________________________________Key_Y______________________________________________'
            If e.KeyCode = Keys.Y Then
                My.Computer.Audio.Play(My.Resources._39174__jobro__piano_ff_027, AudioPlayMode.Background)
                aKeyBackPictureBox.BackColor = Color.Chartreuse
                aLabel.ForeColor = Color.Chartreuse
            Else
                aKeyBackPictureBox.BackColor = Color.White
                aLabel.ForeColor = Color.Black
            End If

            '___________________________________________Key_D7_____________________________________________'
            If e.KeyCode = Keys.D7 Then
                My.Computer.Audio.Play(My.Resources._39175__jobro__piano_ff_028, AudioPlayMode.Background)
                aSharpKeyBackPictureBox.BackColor = Color.Cyan
                aSharpLabel.ForeColor = Color.Cyan
            Else
                aSharpKeyBackPictureBox.BackColor = Color.Black
                aSharpLabel.ForeColor = Color.White
            End If

            '___________________________________________Key_U______________________________________________'
            If e.KeyCode = Keys.U Then
                My.Computer.Audio.Play(My.Resources._39176__jobro__piano_ff_029, AudioPlayMode.Background)
                bKeyBackPictureBox.BackColor = Color.Chartreuse
                bLabel.ForeColor = Color.Chartreuse
            Else
                bKeyBackPictureBox.BackColor = Color.White
                bLabel.ForeColor = Color.Black
            End If

            '___________________________________________Key_I______________________________________________'
            If e.KeyCode = Keys.I Then
                My.Computer.Audio.Play(My.Resources._39177__jobro__piano_ff_030, AudioPlayMode.Background)
                cEndKeyBackPictureBox.BackColor = Color.Chartreuse
                cEndLabel.ForeColor = Color.Chartreuse
            Else
                cEndKeyBackPictureBox.BackColor = Color.White
                cEndLabel.ForeColor = Color.Black
            End If

        End If
    End Sub

    Private Sub Mid_LowPitchRadioButton_KeyDown(sender As Object, e As KeyEventArgs) Handles Mid_LowPitchRadioButton.KeyDown
        If Mid_LowPitchRadioButton.Checked Then

            '___________________________________________Key_Q_____________________________________________'
            If e.KeyCode = Keys.Q Then
                My.Computer.Audio.Play(My.Resources._39182__jobro__piano_ff_035, AudioPlayMode.Background)
                cKeyBackPictureBox.BackColor = Color.Chartreuse
                cLabel.ForeColor = Color.Chartreuse
            Else
                cKeyBackPictureBox.BackColor = Color.White
                cLabel.ForeColor = Color.Black
            End If


            '___________________________________________Key_D2_____________________________________________'
            If e.KeyCode = Keys.D2 Then
                My.Computer.Audio.Play(My.Resources._39183__jobro__piano_ff_036, AudioPlayMode.Background)
                cSharpKeyBackPictureBox.BackColor = Color.Cyan
                cSharpLabel.ForeColor = Color.Cyan
            Else
                cSharpKeyBackPictureBox.BackColor = Color.Black
                cSharpLabel.ForeColor = Color.White
            End If


            '___________________________________________Key_W______________________________________________'
            If e.KeyCode = Keys.W Then
                My.Computer.Audio.Play(My.Resources._39184__jobro__piano_ff_037, AudioPlayMode.Background)
                dKeyBackPictureBox.BackColor = Color.Chartreuse
                dLabel.ForeColor = Color.Chartreuse
            Else
                dKeyBackPictureBox.BackColor = Color.White
                dLabel.ForeColor = Color.Black
            End If


            '___________________________________________Key_D3_____________________________________________'
            If e.KeyCode = Keys.D3 Then
                My.Computer.Audio.Play(My.Resources._39185__jobro__piano_ff_038, AudioPlayMode.Background)
                dSharpKeyBackPictureBox.BackColor = Color.Cyan
                dSharpLabel.ForeColor = Color.Cyan
            Else
                dSharpKeyBackPictureBox.BackColor = Color.Black
                dSharpLabel.ForeColor = Color.White
            End If


            '___________________________________________Key_E______________________________________________'
            If e.KeyCode = Keys.E Then
                My.Computer.Audio.Play(My.Resources._39186__jobro__piano_ff_039, AudioPlayMode.Background)
                eKeyBackPictureBox.BackColor = Color.Chartreuse
                eLabel.ForeColor = Color.Chartreuse
            Else
                eKeyBackPictureBox.BackColor = Color.White
                eLabel.ForeColor = Color.Black
            End If


            '___________________________________________Key_R______________________________________________'
            If e.KeyCode = Keys.R Then
                My.Computer.Audio.Play(My.Resources._39187__jobro__piano_ff_040, AudioPlayMode.Background)
                fKeyBackPictureBox.BackColor = Color.Chartreuse
                fLabel.ForeColor = Color.Chartreuse
            Else
                fKeyBackPictureBox.BackColor = Color.White
                fLabel.ForeColor = Color.Black
            End If


            '___________________________________________Key_D5_____________________________________________'
            If e.KeyCode = Keys.D5 Then
                My.Computer.Audio.Play(My.Resources._39188__jobro__piano_ff_041, AudioPlayMode.Background)
                fSharpKeyBackPictureBox.BackColor = Color.Cyan
                fSharpLabel.ForeColor = Color.Cyan
            Else
                fSharpKeyBackPictureBox.BackColor = Color.Black
                fSharpLabel.ForeColor = Color.White
            End If


            '___________________________________________Key_T______________________________________________'
            If e.KeyCode = Keys.T Then
                My.Computer.Audio.Play(My.Resources._39189__jobro__piano_ff_042, AudioPlayMode.Background)
                gKeyBackPictureBox.BackColor = Color.Chartreuse
                gLabel.ForeColor = Color.Chartreuse
            Else
                gKeyBackPictureBox.BackColor = Color.White
                gLabel.ForeColor = Color.Black
            End If


            '___________________________________________Key_D6_____________________________________________'
            If e.KeyCode = Keys.D6 Then
                My.Computer.Audio.Play(My.Resources._39190__jobro__piano_ff_043, AudioPlayMode.Background)
                gSharpKeyBackPictureBox.BackColor = Color.Cyan
                gSharpLabel.ForeColor = Color.Cyan
            Else
                gSharpKeyBackPictureBox.BackColor = Color.Black
                gSharpLabel.ForeColor = Color.White
            End If


            '___________________________________________Key_Y______________________________________________'
            If e.KeyCode = Keys.Y Then
                My.Computer.Audio.Play(My.Resources._39191__jobro__piano_ff_044, AudioPlayMode.Background)
                aKeyBackPictureBox.BackColor = Color.Chartreuse
                aLabel.ForeColor = Color.Chartreuse
            Else
                aKeyBackPictureBox.BackColor = Color.White
                aLabel.ForeColor = Color.Black
            End If


            '___________________________________________Key_D7_____________________________________________'
            If e.KeyCode = Keys.D7 Then
                My.Computer.Audio.Play(My.Resources._39193__jobro__piano_ff_045, AudioPlayMode.Background)
                aSharpKeyBackPictureBox.BackColor = Color.Cyan
                aSharpLabel.ForeColor = Color.Cyan
            Else
                aSharpKeyBackPictureBox.BackColor = Color.Black
                aSharpLabel.ForeColor = Color.White
            End If


            '___________________________________________Key_U______________________________________________'
            If e.KeyCode = Keys.U Then
                My.Computer.Audio.Play(My.Resources._39194__jobro__piano_ff_046, AudioPlayMode.Background)
                bKeyBackPictureBox.BackColor = Color.Chartreuse
                bLabel.ForeColor = Color.Chartreuse
            Else
                bKeyBackPictureBox.BackColor = Color.White
                bLabel.ForeColor = Color.Black
            End If


            '___________________________________________Key_I______________________________________________'
            If e.KeyCode = Keys.I Then
                My.Computer.Audio.Play(My.Resources._39195__jobro__piano_ff_047, AudioPlayMode.Background)
                cEndKeyBackPictureBox.BackColor = Color.Chartreuse
                cEndLabel.ForeColor = Color.Chartreuse
            Else
                cEndKeyBackPictureBox.BackColor = Color.White
                cEndLabel.ForeColor = Color.Black
            End If

        End If
    End Sub

    Private Sub LowPitchRadioButton_KeyDown(sender As Object, e As KeyEventArgs) Handles LowPitchRadioButton.KeyDown
        If LowPitchRadioButton.Checked Then

            '___________________________________________Key_Q_____________________________________________'
            If e.KeyCode = Keys.Q Then
                My.Computer.Audio.Play(My.Resources._39196__jobro__piano_ff_048, AudioPlayMode.Background)
                cKeyBackPictureBox.BackColor = Color.Chartreuse
                cLabel.ForeColor = Color.Chartreuse
            Else
                cKeyBackPictureBox.BackColor = Color.White
                cLabel.ForeColor = Color.Black
            End If


            '___________________________________________Key_D2_____________________________________________'
            If e.KeyCode = Keys.D2 Then
                My.Computer.Audio.Play(My.Resources._39197__jobro__piano_ff_049, AudioPlayMode.Background)
                cSharpKeyBackPictureBox.BackColor = Color.Cyan
                cSharpLabel.ForeColor = Color.Cyan
            Else
                cSharpKeyBackPictureBox.BackColor = Color.Black
                cSharpLabel.ForeColor = Color.White
            End If


            '___________________________________________Key_W______________________________________________'
            If e.KeyCode = Keys.W Then
                My.Computer.Audio.Play(My.Resources._39198__jobro__piano_ff_050, AudioPlayMode.Background)
                dKeyBackPictureBox.BackColor = Color.Chartreuse
                dLabel.ForeColor = Color.Chartreuse
            Else
                dKeyBackPictureBox.BackColor = Color.White
                dLabel.ForeColor = Color.Black
            End If


            '___________________________________________Key_D3_____________________________________________'
            If e.KeyCode = Keys.D3 Then
                My.Computer.Audio.Play(My.Resources._39199__jobro__piano_ff_051, AudioPlayMode.Background)
                dSharpKeyBackPictureBox.BackColor = Color.Cyan
                dSharpLabel.ForeColor = Color.Cyan
            Else
                dSharpKeyBackPictureBox.BackColor = Color.Black
                dSharpLabel.ForeColor = Color.White
            End If


            '___________________________________________Key_E______________________________________________'
            If e.KeyCode = Keys.E Then
                My.Computer.Audio.Play(My.Resources._39200__jobro__piano_ff_052, AudioPlayMode.Background)
                eKeyBackPictureBox.BackColor = Color.Chartreuse
                eLabel.ForeColor = Color.Chartreuse
            Else
                eKeyBackPictureBox.BackColor = Color.White
                eLabel.ForeColor = Color.Black
            End If


            '___________________________________________Key_R______________________________________________'
            If e.KeyCode = Keys.R Then
                My.Computer.Audio.Play(My.Resources._39201__jobro__piano_ff_053, AudioPlayMode.Background)
                fKeyBackPictureBox.BackColor = Color.Chartreuse
                fLabel.ForeColor = Color.Chartreuse
            Else
                fKeyBackPictureBox.BackColor = Color.White
                fLabel.ForeColor = Color.Black
            End If


            '___________________________________________Key_D5_____________________________________________'
            If e.KeyCode = Keys.D5 Then
                My.Computer.Audio.Play(My.Resources._39202__jobro__piano_ff_054, AudioPlayMode.Background)
                fSharpKeyBackPictureBox.BackColor = Color.Cyan
                fSharpLabel.ForeColor = Color.Cyan
            Else
                fSharpKeyBackPictureBox.BackColor = Color.Black
                fSharpLabel.ForeColor = Color.White
            End If


            '___________________________________________Key_T______________________________________________'
            If e.KeyCode = Keys.T Then
                My.Computer.Audio.Play(My.Resources._39203__jobro__piano_ff_055, AudioPlayMode.Background)
                gKeyBackPictureBox.BackColor = Color.Chartreuse
                gLabel.ForeColor = Color.Chartreuse
            Else
                gKeyBackPictureBox.BackColor = Color.White
                gLabel.ForeColor = Color.Black
            End If


            '___________________________________________Key_D6_____________________________________________'
            If e.KeyCode = Keys.D6 Then
                My.Computer.Audio.Play(My.Resources._39204__jobro__piano_ff_056, AudioPlayMode.Background)
                gSharpKeyBackPictureBox.BackColor = Color.Cyan
                gSharpLabel.ForeColor = Color.Cyan
            Else
                gSharpKeyBackPictureBox.BackColor = Color.Black
                gSharpLabel.ForeColor = Color.White
            End If


            '___________________________________________Key_Y______________________________________________'
            If e.KeyCode = Keys.Y Then
                My.Computer.Audio.Play(My.Resources._39205__jobro__piano_ff_057, AudioPlayMode.Background)
                aKeyBackPictureBox.BackColor = Color.Chartreuse
                aLabel.ForeColor = Color.Chartreuse
            Else
                aKeyBackPictureBox.BackColor = Color.White
                aLabel.ForeColor = Color.Black
            End If


            '___________________________________________Key_D7_____________________________________________'
            If e.KeyCode = Keys.D7 Then
                My.Computer.Audio.Play(My.Resources._39206__jobro__piano_ff_058, AudioPlayMode.Background)
                aSharpKeyBackPictureBox.BackColor = Color.Cyan
                aSharpLabel.ForeColor = Color.Cyan
            Else
                aSharpKeyBackPictureBox.BackColor = Color.Black
                aSharpLabel.ForeColor = Color.White
            End If


            '___________________________________________Key_U______________________________________________'
            If e.KeyCode = Keys.U Then
                My.Computer.Audio.Play(My.Resources._39207__jobro__piano_ff_059, AudioPlayMode.Background)
                bKeyBackPictureBox.BackColor = Color.Chartreuse
                bLabel.ForeColor = Color.Chartreuse
            Else
                bKeyBackPictureBox.BackColor = Color.White
                bLabel.ForeColor = Color.Black
            End If


            '___________________________________________Key_I______________________________________________'
            If e.KeyCode = Keys.I Then
                My.Computer.Audio.Play(My.Resources._39208__jobro__piano_ff_060, AudioPlayMode.Background)
                cEndKeyBackPictureBox.BackColor = Color.Chartreuse
                cEndLabel.ForeColor = Color.Chartreuse
            Else
                cEndKeyBackPictureBox.BackColor = Color.White
                cEndLabel.ForeColor = Color.Black
            End If

        End If
    End Sub
    Private Sub question_Click(sender As Object, e As EventArgs) Handles question.Click
        MessageBox.Show("Turn On NumPad and Press '1 for Low Pitch', '2 for Mid-Low Pitch', '3 for Mid-High Pitch', '4 for High Pitch' OR Turn Off NumPad and use '2','4','6' or '8' as toggle button for changing pitch.")
    End Sub
End Class
