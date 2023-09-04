Public Class AdvancedForm

    'The advanced form has three different body options the user can choose to exercise.
    'For Arms, the workout will certainly create that burning feeling, so be prepared!
    'For Legs, the workout will work on the thigh and butt areas for a larger look.
    'For Core, the workout is a slighlty longer workout than others to really get your abs looking good!

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FitnessGuide1.Show()
    End Sub
    Private Sub radArms_CheckedChanged(sender As Object, e As EventArgs) Handles radArms.CheckedChanged

        If radArms.Checked = True Then
            lblMessage.Text = "The advanced arms workout will certainly create that burning feeling, so be prepared!"
        End If

    End Sub

    Private Sub radLegs_CheckedChanged(sender As Object, e As EventArgs) Handles radLegs.CheckedChanged

        If radLegs.Checked = True Then
            lblMessage.Text = "The advanced legs workout will work on the thigh and butt areas for a larger look."
        End If

    End Sub

    Private Sub radCore_CheckedChanged(sender As Object, e As EventArgs) Handles radCore.CheckedChanged

        If radCore.Checked = True Then
            lblMessage.Text = "The advanced core workout is a slighlty longer workout than others to really get your abs looking good!"
        End If
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        'Same code as FitnessGuide1, just different forms are shown after a radio button is selected.
        Dim arms As Boolean
        Dim legs As Boolean
        Dim core As Boolean

        arms = radArms.Checked
        legs = radLegs.Checked
        core = radCore.Checked

        If arms Or legs Or core Then
            Select Case arms
                Case = True
                    Me.Hide()
                    AdvancedArms.Show()
            End Select
            Select Case legs
                Case = True
                    Me.Hide()
                    AdvancedLegs.Show()
            End Select
            Select Case core
                Case = True
                    Me.Hide()
                    AdvancedCore.Show()
            End Select
        Else
            MessageBox.Show("Please select an option!")
        End If
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FitnessGuide1.Show()

        'Resets the form after the user decideds to go back
        radArms.Checked = False
        radLegs.Checked = False
        radCore.Checked = False
        lblMessage.Text = "Select what part of the body you want to work on! Once chosen, press 'Start!'"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        radArms.Checked = False
        radLegs.Checked = False
        radCore.Checked = False
        lblMessage.Text = "Select what part of the body you want to work on! Once chosen, press 'Start!'"

    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim intExit As Integer

        intExit = MessageBox.Show("Are you sure you want to exit?", "Exit Hannah's Fitness Guide?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'Application.Exit exits the whole application which I found worked with the multiple forms
        If intExit = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub AdvancedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets location of form
        Me.Location = New Point(250, 200)

        'Colors for the form
        Me.BackColor = Color.RoyalBlue
        lblTitle.BackColor = Color.LightSalmon
        GroupBox1.BackColor = Color.LightSalmon
        lblMessage.BackColor = Color.LightSalmon
    End Sub
End Class