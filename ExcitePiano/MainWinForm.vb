Public Class MainWinForm
    Private Sub MainWinForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles ClosePictureBox.Click
        Me.Close()
    End Sub
    Private Sub RadioButton1_KeyDown(sender As Object, e As KeyEventArgs) Handles TuneOneRadioButton.KeyDown
        '______________________Radio_Button_1____________________'

        If TuneOneRadioButton.Checked Then

            '___________________________________________Key_Q_____________________________________________'
            If e.KeyCode = Keys.Q Then
                My.Computer.Audio.Play(My.Resources._39148__jobro__piano_ff_001, AudioPlayMode.Background)
                PictureBox5.BackColor = Color.Chartreuse
                Label2.ForeColor = Color.Chartreuse
            Else
                PictureBox5.BackColor = Color.White
                Label2.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D2_____________________________________________'
            If e.KeyCode = Keys.D2 Then
                My.Computer.Audio.Play(My.Resources._39149__jobro__piano_ff_002, AudioPlayMode.Background)
                PictureBox1.BackColor = Color.Cyan
                Label3.ForeColor = Color.Cyan
            Else
                PictureBox1.BackColor = Color.Black
                Label3.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_W______________________________________________'
            If e.KeyCode = Keys.W Then
                My.Computer.Audio.Play(My.Resources._39150__jobro__piano_ff_003, AudioPlayMode.Background)
                PictureBox6.BackColor = Color.Chartreuse
                Label4.ForeColor = Color.Chartreuse
            Else
                PictureBox6.BackColor = Color.White
                Label4.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D3_____________________________________________'
            If e.KeyCode = Keys.D3 Then
                My.Computer.Audio.Play(My.Resources._39151__jobro__piano_ff_004, AudioPlayMode.Background)
                PictureBox29.BackColor = Color.Cyan
                Label5.ForeColor = Color.Cyan
            Else
                PictureBox29.BackColor = Color.Black
                Label5.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_E______________________________________________'
            If e.KeyCode = Keys.E Then
                My.Computer.Audio.Play(My.Resources._39152__jobro__piano_ff_005, AudioPlayMode.Background)
                PictureBox7.BackColor = Color.Chartreuse
                Label6.ForeColor = Color.Chartreuse
            Else
                PictureBox7.BackColor = Color.White
                Label6.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_R______________________________________________'
            If e.KeyCode = Keys.R Then
                My.Computer.Audio.Play(My.Resources._39153__jobro__piano_ff_006, AudioPlayMode.Background)
                PictureBox8.BackColor = Color.Chartreuse
                Label7.ForeColor = Color.Chartreuse
            Else
                PictureBox8.BackColor = Color.White
                Label7.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D5_____________________________________________'
            If e.KeyCode = Keys.D5 Then
                My.Computer.Audio.Play(My.Resources._39154__jobro__piano_ff_007, AudioPlayMode.Background)
                PictureBox31.BackColor = Color.Cyan
                Label8.ForeColor = Color.Cyan
            Else
                PictureBox31.BackColor = Color.Black
                Label8.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_T______________________________________________'
            If e.KeyCode = Keys.T Then
                My.Computer.Audio.Play(My.Resources._39155__jobro__piano_ff_008, AudioPlayMode.Background)
                PictureBox9.BackColor = Color.Chartreuse
                Label9.ForeColor = Color.Chartreuse
            Else
                PictureBox9.BackColor = Color.White
                Label9.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D6_____________________________________________'
            If e.KeyCode = Keys.D6 Then
                My.Computer.Audio.Play(My.Resources._39156__jobro__piano_ff_009, AudioPlayMode.Background)
                PictureBox33.BackColor = Color.Cyan
                Label10.ForeColor = Color.Cyan
            Else
                PictureBox33.BackColor = Color.Black
                Label10.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_Y______________________________________________'
            If e.KeyCode = Keys.Y Then
                My.Computer.Audio.Play(My.Resources._39157__jobro__piano_ff_010, AudioPlayMode.Background)
                PictureBox10.BackColor = Color.Chartreuse
                Label11.ForeColor = Color.Chartreuse
            Else
                PictureBox10.BackColor = Color.White
                Label11.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D7_____________________________________________'
            If e.KeyCode = Keys.D7 Then
                My.Computer.Audio.Play(My.Resources._39158__jobro__piano_ff_011, AudioPlayMode.Background)
                PictureBox35.BackColor = Color.Cyan
                Label12.ForeColor = Color.Cyan
            Else
                PictureBox35.BackColor = Color.Black
                Label12.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_U______________________________________________'
            If e.KeyCode = Keys.U Then
                My.Computer.Audio.Play(My.Resources._39159__jobro__piano_ff_012, AudioPlayMode.Background)
                PictureBox11.BackColor = Color.Chartreuse
                Label13.ForeColor = Color.Chartreuse
            Else
                PictureBox11.BackColor = Color.White
                Label13.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_I______________________________________________'
            If e.KeyCode = Keys.I Then
                My.Computer.Audio.Play(My.Resources._39160__jobro__piano_ff_013, AudioPlayMode.Background)
                PictureBox12.BackColor = Color.Chartreuse
                Label14.ForeColor = Color.Chartreuse
            Else
                PictureBox12.BackColor = Color.White
                Label14.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D9_____________________________________________'
            If e.KeyCode = Keys.D9 Then
                My.Computer.Audio.Play(My.Resources._39161__jobro__piano_ff_014, AudioPlayMode.Background)
                PictureBox37.BackColor = Color.Cyan
                Label15.ForeColor = Color.Cyan
            Else
                PictureBox37.BackColor = Color.Black
                Label15.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_O______________________________________________'
            If e.KeyCode = Keys.O Then
                My.Computer.Audio.Play(My.Resources._39162__jobro__piano_ff_015, AudioPlayMode.Background)
                PictureBox13.BackColor = Color.Chartreuse
                Label16.ForeColor = Color.Chartreuse
            Else
                PictureBox13.BackColor = Color.White
                Label16.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D0_____________________________________________'
            If e.KeyCode = Keys.D0 Then
                My.Computer.Audio.Play(My.Resources._39163__jobro__piano_ff_016, AudioPlayMode.Background)
                PictureBox26.BackColor = Color.Cyan
                Label17.ForeColor = Color.Cyan
            Else
                PictureBox26.BackColor = Color.Black
                Label17.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_P______________________________________________'
            If e.KeyCode = Keys.P Then
                My.Computer.Audio.Play(My.Resources._39164__jobro__piano_ff_017, AudioPlayMode.Background)
                PictureBox14.BackColor = Color.Chartreuse
                Label18.ForeColor = Color.Chartreuse
            Else
                PictureBox14.BackColor = Color.White
                Label18.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'
        End If
    End Sub
    Private Sub RadioButton2_KeyDown(sender As Object, e As KeyEventArgs) Handles TuneTwoRadioButton.KeyDown
        '______________________Radio_Button_2____________________'

        If TuneTwoRadioButton.Checked Then

            '___________________________________________Key_Q_____________________________________________'
            If e.KeyCode = Keys.Q Then
                My.Computer.Audio.Play(My.Resources._39165__jobro__piano_ff_018, AudioPlayMode.Background)
                PictureBox5.BackColor = Color.Chartreuse
                Label2.ForeColor = Color.Chartreuse
            Else
                PictureBox5.BackColor = Color.White
                Label2.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D2_____________________________________________'
            If e.KeyCode = Keys.D2 Then
                My.Computer.Audio.Play(My.Resources._39166__jobro__piano_ff_019, AudioPlayMode.Background)
                PictureBox1.BackColor = Color.Cyan
                Label3.ForeColor = Color.Cyan
            Else
                PictureBox1.BackColor = Color.Black
                Label3.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_W______________________________________________'
            If e.KeyCode = Keys.W Then
                My.Computer.Audio.Play(My.Resources._39167__jobro__piano_ff_020, AudioPlayMode.Background)
                PictureBox6.BackColor = Color.Chartreuse
                Label4.ForeColor = Color.Chartreuse
            Else
                PictureBox6.BackColor = Color.White
                Label4.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D3_____________________________________________'
            If e.KeyCode = Keys.D3 Then
                My.Computer.Audio.Play(My.Resources._39168__jobro__piano_ff_021, AudioPlayMode.Background)
                PictureBox29.BackColor = Color.Cyan
                Label5.ForeColor = Color.Cyan
            Else
                PictureBox29.BackColor = Color.Black
                Label5.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_E______________________________________________'
            If e.KeyCode = Keys.E Then
                My.Computer.Audio.Play(My.Resources._39169__jobro__piano_ff_022, AudioPlayMode.Background)
                PictureBox7.BackColor = Color.Chartreuse
                Label6.ForeColor = Color.Chartreuse
            Else
                PictureBox7.BackColor = Color.White
                Label6.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_R______________________________________________'
            If e.KeyCode = Keys.R Then
                My.Computer.Audio.Play(My.Resources._39170__jobro__piano_ff_023, AudioPlayMode.Background)
                PictureBox8.BackColor = Color.Chartreuse
                Label7.ForeColor = Color.Chartreuse
            Else
                PictureBox8.BackColor = Color.White
                Label7.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D5_____________________________________________'
            If e.KeyCode = Keys.D5 Then
                My.Computer.Audio.Play(My.Resources._39171__jobro__piano_ff_024, AudioPlayMode.Background)
                PictureBox31.BackColor = Color.Cyan
                Label8.ForeColor = Color.Cyan
            Else
                PictureBox31.BackColor = Color.Black
                Label8.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_T______________________________________________'
            If e.KeyCode = Keys.T Then
                My.Computer.Audio.Play(My.Resources._39172__jobro__piano_ff_025, AudioPlayMode.Background)
                PictureBox9.BackColor = Color.Chartreuse
                Label9.ForeColor = Color.Chartreuse
            Else
                PictureBox9.BackColor = Color.White
                Label9.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D6_____________________________________________'
            If e.KeyCode = Keys.D6 Then
                My.Computer.Audio.Play(My.Resources._39173__jobro__piano_ff_026, AudioPlayMode.Background)
                PictureBox33.BackColor = Color.Cyan
                Label10.ForeColor = Color.Cyan
            Else
                PictureBox33.BackColor = Color.Black
                Label10.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_Y______________________________________________'
            If e.KeyCode = Keys.Y Then
                My.Computer.Audio.Play(My.Resources._39174__jobro__piano_ff_027, AudioPlayMode.Background)
                PictureBox10.BackColor = Color.Chartreuse
                Label11.ForeColor = Color.Chartreuse
            Else
                PictureBox10.BackColor = Color.White
                Label11.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D7_____________________________________________'
            If e.KeyCode = Keys.D7 Then
                My.Computer.Audio.Play(My.Resources._39175__jobro__piano_ff_028, AudioPlayMode.Background)
                PictureBox35.BackColor = Color.Cyan
                Label12.ForeColor = Color.Cyan
            Else
                PictureBox35.BackColor = Color.Black
                Label12.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_U______________________________________________'
            If e.KeyCode = Keys.U Then
                My.Computer.Audio.Play(My.Resources._39176__jobro__piano_ff_029, AudioPlayMode.Background)
                PictureBox11.BackColor = Color.Chartreuse
                Label13.ForeColor = Color.Chartreuse
            Else
                PictureBox11.BackColor = Color.White
                Label13.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_I______________________________________________'
            If e.KeyCode = Keys.I Then
                My.Computer.Audio.Play(My.Resources._39177__jobro__piano_ff_030, AudioPlayMode.Background)
                PictureBox12.BackColor = Color.Chartreuse
                Label14.ForeColor = Color.Chartreuse
            Else
                PictureBox12.BackColor = Color.White
                Label14.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D9_____________________________________________'
            If e.KeyCode = Keys.D9 Then
                My.Computer.Audio.Play(My.Resources._39178__jobro__piano_ff_031, AudioPlayMode.Background)
                PictureBox37.BackColor = Color.Cyan
                Label15.ForeColor = Color.Cyan
            Else
                PictureBox37.BackColor = Color.Black
                Label15.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_O______________________________________________'
            If e.KeyCode = Keys.O Then
                My.Computer.Audio.Play(My.Resources._39179__jobro__piano_ff_032, AudioPlayMode.Background)
                PictureBox13.BackColor = Color.Chartreuse
                Label16.ForeColor = Color.Chartreuse
            Else
                PictureBox13.BackColor = Color.White
                Label16.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D0_____________________________________________'
            If e.KeyCode = Keys.D0 Then
                My.Computer.Audio.Play(My.Resources._39180__jobro__piano_ff_033, AudioPlayMode.Background)
                PictureBox26.BackColor = Color.Cyan
                Label17.ForeColor = Color.Cyan
            Else
                PictureBox26.BackColor = Color.Black
                Label17.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_P______________________________________________'
            If e.KeyCode = Keys.P Then
                My.Computer.Audio.Play(My.Resources._39181__jobro__piano_ff_034, AudioPlayMode.Background)
                PictureBox14.BackColor = Color.Chartreuse
                Label18.ForeColor = Color.Chartreuse
            Else
                PictureBox14.BackColor = Color.White
                Label18.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'
        End If
    End Sub
    Private Sub RadioButton3_KeyDown(sender As Object, e As KeyEventArgs) Handles TuneThreeRadioButton.KeyDown
        '______________________Radio_Button_3____________________'

        If TuneThreeRadioButton.Checked Then

            '___________________________________________Key_Q_____________________________________________'
            If e.KeyCode = Keys.Q Then
                My.Computer.Audio.Play(My.Resources._39182__jobro__piano_ff_035, AudioPlayMode.Background)
                PictureBox5.BackColor = Color.Chartreuse
                Label2.ForeColor = Color.Chartreuse
            Else
                PictureBox5.BackColor = Color.White
                Label2.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D2_____________________________________________'
            If e.KeyCode = Keys.D2 Then
                My.Computer.Audio.Play(My.Resources._39183__jobro__piano_ff_036, AudioPlayMode.Background)
                PictureBox1.BackColor = Color.Cyan
                Label3.ForeColor = Color.Cyan
            Else
                PictureBox1.BackColor = Color.Black
                Label3.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_W______________________________________________'
            If e.KeyCode = Keys.W Then
                My.Computer.Audio.Play(My.Resources._39184__jobro__piano_ff_037, AudioPlayMode.Background)
                PictureBox6.BackColor = Color.Chartreuse
                Label4.ForeColor = Color.Chartreuse
            Else
                PictureBox6.BackColor = Color.White
                Label4.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D3_____________________________________________'
            If e.KeyCode = Keys.D3 Then
                My.Computer.Audio.Play(My.Resources._39185__jobro__piano_ff_038, AudioPlayMode.Background)
                PictureBox29.BackColor = Color.Cyan
                Label5.ForeColor = Color.Cyan
            Else
                PictureBox29.BackColor = Color.Black
                Label5.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_E______________________________________________'
            If e.KeyCode = Keys.E Then
                My.Computer.Audio.Play(My.Resources._39186__jobro__piano_ff_039, AudioPlayMode.Background)
                PictureBox7.BackColor = Color.Chartreuse
                Label6.ForeColor = Color.Chartreuse
            Else
                PictureBox7.BackColor = Color.White
                Label6.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_R______________________________________________'
            If e.KeyCode = Keys.R Then
                My.Computer.Audio.Play(My.Resources._39187__jobro__piano_ff_040, AudioPlayMode.Background)
                PictureBox8.BackColor = Color.Chartreuse
                Label7.ForeColor = Color.Chartreuse
            Else
                PictureBox8.BackColor = Color.White
                Label7.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D5_____________________________________________'
            If e.KeyCode = Keys.D5 Then
                My.Computer.Audio.Play(My.Resources._39188__jobro__piano_ff_041, AudioPlayMode.Background)
                PictureBox31.BackColor = Color.Cyan
                Label8.ForeColor = Color.Cyan
            Else
                PictureBox31.BackColor = Color.Black
                Label8.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_T______________________________________________'
            If e.KeyCode = Keys.T Then
                My.Computer.Audio.Play(My.Resources._39189__jobro__piano_ff_042, AudioPlayMode.Background)
                PictureBox9.BackColor = Color.Chartreuse
                Label9.ForeColor = Color.Chartreuse
            Else
                PictureBox9.BackColor = Color.White
                Label9.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D6_____________________________________________'
            If e.KeyCode = Keys.D6 Then
                My.Computer.Audio.Play(My.Resources._39190__jobro__piano_ff_043, AudioPlayMode.Background)
                PictureBox33.BackColor = Color.Cyan
                Label10.ForeColor = Color.Cyan
            Else
                PictureBox33.BackColor = Color.Black
                Label10.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_Y______________________________________________'
            If e.KeyCode = Keys.Y Then
                My.Computer.Audio.Play(My.Resources._39191__jobro__piano_ff_044, AudioPlayMode.Background)
                PictureBox10.BackColor = Color.Chartreuse
                Label11.ForeColor = Color.Chartreuse
            Else
                PictureBox10.BackColor = Color.White
                Label11.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D7_____________________________________________'
            If e.KeyCode = Keys.D7 Then
                My.Computer.Audio.Play(My.Resources._39193__jobro__piano_ff_045, AudioPlayMode.Background)
                PictureBox35.BackColor = Color.Cyan
                Label12.ForeColor = Color.Cyan
            Else
                PictureBox35.BackColor = Color.Black
                Label12.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_U______________________________________________'
            If e.KeyCode = Keys.U Then
                My.Computer.Audio.Play(My.Resources._39194__jobro__piano_ff_046, AudioPlayMode.Background)
                PictureBox11.BackColor = Color.Chartreuse
                Label13.ForeColor = Color.Chartreuse
            Else
                PictureBox11.BackColor = Color.White
                Label13.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_I______________________________________________'
            If e.KeyCode = Keys.I Then
                My.Computer.Audio.Play(My.Resources._39195__jobro__piano_ff_047, AudioPlayMode.Background)
                PictureBox12.BackColor = Color.Chartreuse
                Label14.ForeColor = Color.Chartreuse
            Else
                PictureBox12.BackColor = Color.White
                Label14.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D9_____________________________________________'
            If e.KeyCode = Keys.D9 Then
                My.Computer.Audio.Play(My.Resources._39196__jobro__piano_ff_048, AudioPlayMode.Background)
                PictureBox37.BackColor = Color.Cyan
                Label15.ForeColor = Color.Cyan
            Else
                PictureBox37.BackColor = Color.Black
                Label15.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_O______________________________________________'
            If e.KeyCode = Keys.O Then
                My.Computer.Audio.Play(My.Resources._39197__jobro__piano_ff_049, AudioPlayMode.Background)
                PictureBox13.BackColor = Color.Chartreuse
                Label16.ForeColor = Color.Chartreuse
            Else
                PictureBox13.BackColor = Color.White
                Label16.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D0_____________________________________________'
            If e.KeyCode = Keys.D0 Then
                My.Computer.Audio.Play(My.Resources._39198__jobro__piano_ff_050, AudioPlayMode.Background)
                PictureBox26.BackColor = Color.Cyan
                Label17.ForeColor = Color.Cyan
            Else
                PictureBox26.BackColor = Color.Black
                Label17.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_P______________________________________________'
            If e.KeyCode = Keys.P Then
                My.Computer.Audio.Play(My.Resources._39199__jobro__piano_ff_051, AudioPlayMode.Background)
                PictureBox14.BackColor = Color.Chartreuse
                Label18.ForeColor = Color.Chartreuse
            Else
                PictureBox14.BackColor = Color.White
                Label18.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'
        End If
    End Sub
    Private Sub RadioButton4_KeyDown(sender As Object, e As KeyEventArgs) Handles TuneFourRadioButton.KeyDown
        '______________________Radio_Button_4____________________'

        If TuneFourRadioButton.Checked Then

            '___________________________________________Key_Q_____________________________________________'
            If e.KeyCode = Keys.Q Then
                My.Computer.Audio.Play(My.Resources._39200__jobro__piano_ff_052, AudioPlayMode.Background)
                PictureBox5.BackColor = Color.Chartreuse
                Label2.ForeColor = Color.Chartreuse
            Else
                PictureBox5.BackColor = Color.White
                Label2.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D2_____________________________________________'
            If e.KeyCode = Keys.D2 Then
                My.Computer.Audio.Play(My.Resources._39201__jobro__piano_ff_053, AudioPlayMode.Background)
                PictureBox1.BackColor = Color.Cyan
                Label3.ForeColor = Color.Cyan
            Else
                PictureBox1.BackColor = Color.Black
                Label3.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_W______________________________________________'
            If e.KeyCode = Keys.W Then
                My.Computer.Audio.Play(My.Resources._39202__jobro__piano_ff_054, AudioPlayMode.Background)
                PictureBox6.BackColor = Color.Chartreuse
                Label4.ForeColor = Color.Chartreuse
            Else
                PictureBox6.BackColor = Color.White
                Label4.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D3_____________________________________________'
            If e.KeyCode = Keys.D3 Then
                My.Computer.Audio.Play(My.Resources._39203__jobro__piano_ff_055, AudioPlayMode.Background)
                PictureBox29.BackColor = Color.Cyan
                Label5.ForeColor = Color.Cyan
            Else
                PictureBox29.BackColor = Color.Black
                Label5.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_E______________________________________________'
            If e.KeyCode = Keys.E Then
                My.Computer.Audio.Play(My.Resources._39204__jobro__piano_ff_056, AudioPlayMode.Background)
                PictureBox7.BackColor = Color.Chartreuse
                Label6.ForeColor = Color.Chartreuse
            Else
                PictureBox7.BackColor = Color.White
                Label6.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_R______________________________________________'
            If e.KeyCode = Keys.R Then
                My.Computer.Audio.Play(My.Resources._39205__jobro__piano_ff_057, AudioPlayMode.Background)
                PictureBox8.BackColor = Color.Chartreuse
                Label7.ForeColor = Color.Chartreuse
            Else
                PictureBox8.BackColor = Color.White
                Label7.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D5_____________________________________________'
            If e.KeyCode = Keys.D5 Then
                My.Computer.Audio.Play(My.Resources._39206__jobro__piano_ff_058, AudioPlayMode.Background)
                PictureBox31.BackColor = Color.Cyan
                Label8.ForeColor = Color.Cyan
            Else
                PictureBox31.BackColor = Color.Black
                Label8.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_T______________________________________________'
            If e.KeyCode = Keys.T Then
                My.Computer.Audio.Play(My.Resources._39207__jobro__piano_ff_059, AudioPlayMode.Background)
                PictureBox9.BackColor = Color.Chartreuse
                Label9.ForeColor = Color.Chartreuse
            Else
                PictureBox9.BackColor = Color.White
                Label9.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D6_____________________________________________'
            If e.KeyCode = Keys.D6 Then
                My.Computer.Audio.Play(My.Resources._39208__jobro__piano_ff_060, AudioPlayMode.Background)
                PictureBox33.BackColor = Color.Cyan
                Label10.ForeColor = Color.Cyan
            Else
                PictureBox33.BackColor = Color.Black
                Label10.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_Y______________________________________________'
            If e.KeyCode = Keys.Y Then
                My.Computer.Audio.Play(My.Resources._39209__jobro__piano_ff_061, AudioPlayMode.Background)
                PictureBox10.BackColor = Color.Chartreuse
                Label11.ForeColor = Color.Chartreuse
            Else
                PictureBox10.BackColor = Color.White
                Label11.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D7_____________________________________________'
            If e.KeyCode = Keys.D7 Then
                My.Computer.Audio.Play(My.Resources._39210__jobro__piano_ff_062, AudioPlayMode.Background)
                PictureBox35.BackColor = Color.Cyan
                Label12.ForeColor = Color.Cyan
            Else
                PictureBox35.BackColor = Color.Black
                Label12.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_U______________________________________________'
            If e.KeyCode = Keys.U Then
                My.Computer.Audio.Play(My.Resources._39211__jobro__piano_ff_063, AudioPlayMode.Background)
                PictureBox11.BackColor = Color.Chartreuse
                Label13.ForeColor = Color.Chartreuse
            Else
                PictureBox11.BackColor = Color.White
                Label13.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_I______________________________________________'
            If e.KeyCode = Keys.I Then
                My.Computer.Audio.Play(My.Resources._39212__jobro__piano_ff_064, AudioPlayMode.Background)
                PictureBox12.BackColor = Color.Chartreuse
                Label14.ForeColor = Color.Chartreuse
            Else
                PictureBox12.BackColor = Color.White
                Label14.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D9_____________________________________________'
            If e.KeyCode = Keys.D9 Then
                My.Computer.Audio.Play(My.Resources._39213__jobro__piano_ff_065, AudioPlayMode.Background)
                PictureBox37.BackColor = Color.Cyan
                Label15.ForeColor = Color.Cyan
            Else
                PictureBox37.BackColor = Color.Black
                Label15.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_O______________________________________________'
            If e.KeyCode = Keys.O Then
                My.Computer.Audio.Play(My.Resources._39214__jobro__piano_ff_066, AudioPlayMode.Background)
                PictureBox13.BackColor = Color.Chartreuse
                Label16.ForeColor = Color.Chartreuse
            Else
                PictureBox13.BackColor = Color.White
                Label16.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_D0_____________________________________________'
            If e.KeyCode = Keys.D0 Then
                My.Computer.Audio.Play(My.Resources._39215__jobro__piano_ff_067, AudioPlayMode.Background)
                PictureBox26.BackColor = Color.Cyan
                Label17.ForeColor = Color.Cyan
            Else
                PictureBox26.BackColor = Color.Black
                Label17.ForeColor = Color.White
            End If
            '______________________________________________________________________________________________'

            '___________________________________________Key_P______________________________________________'
            If e.KeyCode = Keys.P Then
                My.Computer.Audio.Play(My.Resources._39216__jobro__piano_ff_068, AudioPlayMode.Background)
                PictureBox14.BackColor = Color.Chartreuse
                Label18.ForeColor = Color.Chartreuse
            Else
                PictureBox14.BackColor = Color.White
                Label18.ForeColor = Color.Black
            End If
            '______________________________________________________________________________________________'

        End If
    End Sub
End Class
