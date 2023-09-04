Public Class FitnessGuide1
    'Hannah Guillen 12/10/2019
    'Fitness Guide Application Final

    'In this application, the user must first chose what level they wish to begin their fitness journey. 
    'After choosing their level, they are able To pick which part Of the body they want To exercise. 
    'This will Then show them the recommended exercises they should do.

    'This program uses If-Then statements, Select Case, Input box, and Timers.
    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click

        'Declare Variables 
        'Declared them as Boolean because they were true/false.

        Dim beginner As Boolean
        Dim intermediate As Boolean
        Dim advanced As Boolean

        'Assign Values
        beginner = radBeginner.Checked
        intermediate = radIntermediate.Checked
        advanced = radAdvanced.Checked

        'Perform Calculation/Display Result
        If beginner Or intermediate Or advanced Then
            Select Case beginner
                Case = True
                    Me.Hide()
                    BeginnerForm.Show()
            End Select
            Select Case intermediate
                Case = True
                    Me.Hide()
                    IntermediateForm.Show()
            End Select
            Select Case advanced
                Case = True
                    Me.Hide()
                    AdvancedForm.Show()
            End Select
        Else
            MessageBox.Show("Please select an option!")
        End If

        radBeginner.Checked = False
        radIntermediate.Checked = False
        radAdvanced.Checked = False

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        radBeginner.Checked = False
        radIntermediate.Checked = False
        radAdvanced.Checked = False
    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim intExit As Integer

        intExit = MessageBox.Show("Are you sure you want to exit?", "Exit Hannah's Fitness Guide?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'Application.Exit exits the whole application which I found worked with the multiple forms
        If intExit = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub FitnessGuide1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Giving this location for all forms lets them appear at the same spot
        Me.Location = New Point(250, 200)

        'InputBox appears before the form in actually shown to user
        Dim strUserName As String
        strUserName = InputBox("What is your name?", "Please enter your name.")
            lblMessage.Text = "Hi " & strUserName & "! Welcome to your own fitness guide, designed to help you throughout your workout journey! To begin your workout, please selsect your level and press 'Begin My Workout!'"
            'To set lblMotivation as a flashing label
            Timer1.Enabled = True
        Timer2.Enabled = False

        'Gives the form some color!
        Me.BackColor = Color.PowderBlue
        lblTitle.BackColor = Color.SkyBlue
        GroupBox1.BackColor = Color.SkyBlue
        lblMotivation.BackColor = Color.SkyBlue

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Set lblMotivation as a flashing label using Timer1
        lblMotivation.Visible = True
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        'Set lblMotivation as a flashing label using Timer2
        lblMotivation.Visible = False
        Timer1.Enabled = True
        Timer2.Enabled = False
    End Sub
End Class

