Public Class Form1
    REM: Marilou Gagnon (Gouliram)
    REM: Beggining of the process : 23-05-2021
    REM: This needs to be an easy fix. So, the problem is the Main Sub doesnt allowed me to make changes. It opens and closes without being able to do something onto the app. 
    REM: My twitch account : www.twitch.tv/gouliram
    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        ' With this button, i want it to be able to put this timer on, when im going on live. or press it when im on live on twitch. 
        ' i want it to go by second on second and put some xp onto the xp bar that we're going to see in a little. 
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        'For every event going on my streams, this xp bar will be increasing and it will make up to some levels. for every levels, i want it to be able to save the progress between each sessions. 
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Level.Text = "Level up!"
            'leveling up : i want it to be able to go on levels up to 1000. increasing the xp by some little modifiers. 
        End If
        Progress.Text = ProgressBar1.Value & (" %")
    End Sub

    Private Sub Ends_Click(sender As Object, e As EventArgs) Handles Ends.Click
        Timer.Stop()
        ' i want it to be able to keeps the xp that has been going on since the beginning of this project. When i do have to close my streaming session. 
    End Sub

    Private Sub Followers_Click(sender As Object, e As EventArgs) Handles Followers.Click
        'For every followers, i want it to be able to add some xp to the bar. still less than a subscriptions or bits and donations. 
    End Sub

    Private Sub Subscriptions_Click(sender As Object, e As EventArgs) Handles Subscriptions.Click
        'For every subscriptions, i want it to be able to add some xp to the bar. still less than a donation or bits
    End Sub
    Private Sub Bits_Click(sender As Object, e As EventArgs) Handles Bits.Click
        'For every bits, i want it to be able to add some xp to the bar. still less than a donation. 
        'If possible, can we have a textbox for putting the amount of bits donated?
    End Sub
    Private Sub Donations_Click(sender As Object, e As EventArgs) Handles Donations.Click
        'For every donations, i want it to be able to add some xp to the bar.  
        'If possible, can we have a textbox for putting the amount of money donated?
    End Sub

    Private Sub Hugs_Click(sender As Object, e As EventArgs) Handles Hugs.Click
        'this is a bit more complicated im my honest opinion. this action is actually going on by the channels points. and for every 'hugs' that my viewers will be giving, it will affect the xp bar, still less than a subscription xp. 
    End Sub

    Private Sub Treats_Click(sender As Object, e As EventArgs) Handles Treats.Click
        'this is a bit more complicated im my honest opinion. this action is actually going on by the channels points. and for every 'treats' that my viewers will be giving, it will affect the xp bar, still less than a bits xp. 
    End Sub
End Class
Public Module mainModule
    Sub Main()
    End Sub
End Module
