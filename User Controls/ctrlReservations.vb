Public Class ctrlReservations

    Private Sub ctrlReservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentTime()
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub currentTime()
        Dim currentDateTime As DateTime = DateTime.Now
        Dim formattedDateTime As String = currentDateTime.ToString("MMM d, yyyy hh:mm:ss tt")
        lblDateTime.Text = formattedDateTime
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentTime()
    End Sub

End Class
