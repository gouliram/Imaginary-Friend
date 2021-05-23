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
        Me.Start = New System.Windows.Forms.Button()
        Me.Ends = New System.Windows.Forms.Button()
        Me.Followers = New System.Windows.Forms.Button()
        Me.Subscriptions = New System.Windows.Forms.Button()
        Me.Donations = New System.Windows.Forms.Button()
        Me.Bits = New System.Windows.Forms.Button()
        Me.Hugs = New System.Windows.Forms.Button()
        Me.Treats = New System.Windows.Forms.Button()
        Me.Level = New System.Windows.Forms.Label()
        Me.Progress = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.AllowDrop = True
        Me.Start.Location = New System.Drawing.Point(260, 278)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(112, 31)
        Me.Start.TabIndex = 0
        Me.Start.Text = "Start Stream"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Ends
        '
        Me.Ends.Location = New System.Drawing.Point(407, 278)
        Me.Ends.Name = "Ends"
        Me.Ends.Size = New System.Drawing.Size(112, 31)
        Me.Ends.TabIndex = 1
        Me.Ends.Text = "End Stream"
        Me.Ends.UseVisualStyleBackColor = True
        '
        'Followers
        '
        Me.Followers.Location = New System.Drawing.Point(260, 315)
        Me.Followers.Name = "Followers"
        Me.Followers.Size = New System.Drawing.Size(112, 31)
        Me.Followers.TabIndex = 2
        Me.Followers.Text = "Followers"
        Me.Followers.UseVisualStyleBackColor = True
        '
        'Subscriptions
        '
        Me.Subscriptions.Location = New System.Drawing.Point(407, 315)
        Me.Subscriptions.Name = "Subscriptions"
        Me.Subscriptions.Size = New System.Drawing.Size(112, 31)
        Me.Subscriptions.TabIndex = 3
        Me.Subscriptions.Text = "Subscriptions"
        Me.Subscriptions.UseVisualStyleBackColor = True
        '
        'Donations
        '
        Me.Donations.Location = New System.Drawing.Point(260, 352)
        Me.Donations.Name = "Donations"
        Me.Donations.Size = New System.Drawing.Size(112, 31)
        Me.Donations.TabIndex = 4
        Me.Donations.Text = "Donations"
        Me.Donations.UseVisualStyleBackColor = True
        '
        'Bits
        '
        Me.Bits.Location = New System.Drawing.Point(407, 352)
        Me.Bits.Name = "Bits"
        Me.Bits.Size = New System.Drawing.Size(112, 31)
        Me.Bits.TabIndex = 5
        Me.Bits.Text = "Bits"
        Me.Bits.UseVisualStyleBackColor = True
        '
        'Hugs
        '
        Me.Hugs.Location = New System.Drawing.Point(260, 389)
        Me.Hugs.Name = "Hugs"
        Me.Hugs.Size = New System.Drawing.Size(112, 31)
        Me.Hugs.TabIndex = 6
        Me.Hugs.Text = "Hugs"
        Me.Hugs.UseVisualStyleBackColor = True
        '
        'Treats
        '
        Me.Treats.Location = New System.Drawing.Point(407, 389)
        Me.Treats.Name = "Treats"
        Me.Treats.Size = New System.Drawing.Size(112, 31)
        Me.Treats.TabIndex = 7
        Me.Treats.Text = "Treats"
        Me.Treats.UseVisualStyleBackColor = True
        '
        'Level
        '
        Me.Level.AutoSize = True
        Me.Level.Location = New System.Drawing.Point(371, 222)
        Me.Level.Name = "Level"
        Me.Level.Size = New System.Drawing.Size(34, 15)
        Me.Level.TabIndex = 8
        Me.Level.Text = "Level"
        '
        'Progress
        '
        Me.Progress.AutoSize = True
        Me.Progress.Location = New System.Drawing.Point(550, 222)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(26, 15)
        Me.Progress.TabIndex = 9
        Me.Progress.Text = "0 %"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(211, 240)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(365, 23)
        Me.ProgressBar1.TabIndex = 10
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.Level)
        Me.Controls.Add(Me.Treats)
        Me.Controls.Add(Me.Hugs)
        Me.Controls.Add(Me.Bits)
        Me.Controls.Add(Me.Donations)
        Me.Controls.Add(Me.Subscriptions)
        Me.Controls.Add(Me.Followers)
        Me.Controls.Add(Me.Ends)
        Me.Controls.Add(Me.Start)
        Me.Name = "Form1"
        Me.Text = "Ami imaginaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Start As Button
    Friend WithEvents Ends As Button
    Friend WithEvents Followers As Button
    Friend WithEvents Subscriptions As Button
    Friend WithEvents Donations As Button
    Friend WithEvents Bits As Button
    Friend WithEvents Hugs As Button
    Friend WithEvents Treats As Button
    Friend WithEvents Level As Label
    Friend WithEvents Progress As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer As Timer
End Class
