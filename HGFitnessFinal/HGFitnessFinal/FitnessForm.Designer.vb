<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FitnessGuide1
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
        Me.components = New System.ComponentModel.Container()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBeginner = New System.Windows.Forms.RadioButton()
        Me.radAdvanced = New System.Windows.Forms.RadioButton()
        Me.radIntermediate = New System.Windows.Forms.RadioButton()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMotivation = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBegin
        '
        Me.btnBegin.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBegin.Location = New System.Drawing.Point(591, 329)
        Me.btnBegin.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(145, 75)
        Me.btnBegin.TabIndex = 0
        Me.btnBegin.Text = "Select My Workout!"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("Stencil", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(182, 22)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(445, 56)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Hannah's Fitness Guide"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radBeginner)
        Me.GroupBox1.Controls.Add(Me.radAdvanced)
        Me.GroupBox1.Controls.Add(Me.radIntermediate)
        Me.GroupBox1.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(72, 204)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(349, 200)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chose Your Level"
        '
        'radBeginner
        '
        Me.radBeginner.AutoSize = True
        Me.radBeginner.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBeginner.Location = New System.Drawing.Point(35, 56)
        Me.radBeginner.Name = "radBeginner"
        Me.radBeginner.Size = New System.Drawing.Size(124, 33)
        Me.radBeginner.TabIndex = 3
        Me.radBeginner.TabStop = True
        Me.radBeginner.Text = "Beginner"
        Me.radBeginner.UseVisualStyleBackColor = True
        '
        'radAdvanced
        '
        Me.radAdvanced.AutoSize = True
        Me.radAdvanced.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAdvanced.Location = New System.Drawing.Point(35, 148)
        Me.radAdvanced.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.radAdvanced.Name = "radAdvanced"
        Me.radAdvanced.Size = New System.Drawing.Size(133, 33)
        Me.radAdvanced.TabIndex = 2
        Me.radAdvanced.TabStop = True
        Me.radAdvanced.Text = "Advanced"
        Me.radAdvanced.UseVisualStyleBackColor = True
        '
        'radIntermediate
        '
        Me.radIntermediate.AutoSize = True
        Me.radIntermediate.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radIntermediate.Location = New System.Drawing.Point(35, 101)
        Me.radIntermediate.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.radIntermediate.Name = "radIntermediate"
        Me.radIntermediate.Size = New System.Drawing.Size(168, 33)
        Me.radIntermediate.TabIndex = 1
        Me.radIntermediate.TabStop = True
        Me.radIntermediate.Text = "Intermediate"
        Me.radIntermediate.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(107, 90)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(588, 111)
        Me.lblMessage.TabIndex = 3
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(465, 340)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 52)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(700, 22)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(67, 33)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMotivation
        '
        Me.lblMotivation.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivation.Location = New System.Drawing.Point(492, 215)
        Me.lblMotivation.Name = "lblMotivation"
        Me.lblMotivation.Size = New System.Drawing.Size(228, 102)
        Me.lblMotivation.TabIndex = 13
        Me.lblMotivation.Text = " Remember, results happen over time, not over night. Work hard, stay consintent a" &
    "nd be patient!"
        Me.lblMotivation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1100
        '
        'Timer2
        '
        Me.Timer2.Interval = 1100
        '
        'FitnessGuide1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 436)
        Me.Controls.Add(Me.lblMotivation)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnBegin)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Name = "FitnessGuide1"
        Me.Text = "Welcome to Hannah's Fitness Guide"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBegin As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radAdvanced As RadioButton
    Friend WithEvents radIntermediate As RadioButton
    Friend WithEvents lblMessage As Label
    Friend WithEvents radBeginner As RadioButton
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMotivation As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
