﻿Public Class BeginnerLegs

    'Declared the variables for the timer as Integer
    Dim intMinutes As Integer = 0
    Dim intSeconds As Integer = 0
    Dim intMilliseconds As Integer = 0

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim intExit As Integer

        intExit = MessageBox.Show("Are you sure you want to exit?", "Exit Hannah's Fitness Guide?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If intExit = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        BeginnerForm.Show()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Start()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Stop()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Timer1.Stop()
        intMinutes = 0
        intSeconds = 0
        intMilliseconds = 0
        lblTimer.Text = (intMinutes & " : " & intSeconds & " : " & intMilliseconds)
        lblWorkout.Text = "Click 'Start' to begin your workout!"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Adds 1 before the If statement begins
        intMilliseconds += 1
        lblTimer.Text = (intMinutes & " : " & intSeconds & " : " & intMilliseconds)

        'Every time intMillieseconds reaches 100, intSeconds adds 1. When intSeconds reaches 60, intMinutes adds one as well until intMinutes reaches 3.
        'When intMinutes reaches 3, the timer stops and the label is set to the appropriate time.
        If intMilliseconds = 100 Then
            intMilliseconds = 0
            intSeconds += 1
            lblTimer.Text = (intMinutes & " : " & intSeconds & " : " & intMilliseconds)
            If intSeconds = 60 Then
                intSeconds = 0
                intMinutes += 1
                lblTimer.Text = (intMinutes & " : " & intSeconds & " : " & intMilliseconds)
                If intMinutes = 3 Then
                    Timer1.Stop()
                    intMinutes = 3
                    intSeconds = 0
                    intMilliseconds = 0
                    lblTimer.Text = (intMinutes & " : " & intSeconds & " : " & intMilliseconds)
                End If
            End If
        End If

        'I found a long If-ElseIf statement worked best because I wanted to add a workout each time intMinutes and intSeconds reached a certain point.
        If intSeconds = 0 Then
            lblWorkout.Text = "Get Ready!"
        ElseIf intSeconds = 2 Then
            lblWorkout.Text = "3"
        ElseIf intSeconds = 3 Then
            lblWorkout.Text = "2"
        ElseIf intSeconds = 4 Then
            lblWorkout.Text = "1"
        ElseIf intSeconds = 5 Then
            lblWorkout.Text = "Half Squats"
        ElseIf intSeconds = 15 Then
            lblWorkout.Text = "Alternate - Reach down with one arm and lift opposite side leg"
        ElseIf intSeconds = 25 Then
            lblWorkout.Text = "Alternating Lunges"
        ElseIf intSeconds = 45 Then
            lblWorkout.Text = "Squats"
        ElseIf intMinutes = 1 And intSeconds = 5 Then
            lblWorkout.Text = "Donkey Kicks - Left Side"
        ElseIf intMinutes = 1 And intSeconds = 15 Then
            lblWorkout.Text = "Donkey Kicks - Right Side"
        ElseIf intMinutes = 1 And intSeconds = 25 Then
            lblWorkout.Text = "REST"
        ElseIf intMinutes = 1 And intSeconds = 35 Then
            lblWorkout.Text = "Lay flat on floor and raise hip to the air. Alternate legs bringing knees to chest."
        ElseIf intMinutes = 1 And intSeconds = 55 Then
            lblWorkout.Text = "Lie on side. Raise left leg up and down."
        ElseIf intMinutes = 2 And intSeconds = 15 Then
            lblWorkout.Text = "Lie on side. Raise right leg up and down."
        ElseIf intMinutes = 2 And intSeconds = 35 Then
            lblWorkout.Text = "Single-leg hip extensions - Left side."
        ElseIf intMinutes = 2 And intSeconds = 45 Then
            lblWorkout.Text = "Single-leg hip extensions - Right side."
        ElseIf intMinutes = 2 And intSeconds = 55 Then
            lblWorkout.Text = "Alternating side leg raises."
        ElseIf intMinutes = 3 Then
            Timer1.Stop()
            lblWorkout.Text = "Congratulations, you finished!"
        End If
    End Sub

    Private Sub BeginnerLegs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets location of form
        Me.Location = New Point(250, 200)

        'Colors for the form
        Me.BackColor = Color.MediumPurple
        lblTimer.BackColor = Color.Plum
        lblWorkout.BackColor = Color.Plum
    End Sub
End Class