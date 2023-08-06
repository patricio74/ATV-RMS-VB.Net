Public Class ctrlOverview

    Private Sub SetGroupColors(group As GroupBox, colorEnter As Color, colorLeave As Color)
        group.BackColor = colorEnter
    End Sub

    Private Sub MouseEnterHandler(sender As Object, e As EventArgs) Handles grpReservations.MouseEnter, lblReservations.MouseEnter,
        grpAvailable.MouseEnter, lblAvailable.MouseEnter, grpCustCount.MouseEnter,
        lblCustCount.MouseEnter, grpEarnings.MouseEnter, lblEarnings.MouseEnter

        If sender Is grpReservations OrElse sender Is lblReservations Then
            SetGroupColors(grpReservations, Color.MediumOrchid, Color.DarkOrchid)
        ElseIf sender Is grpAvailable OrElse sender Is lblAvailable Then
            SetGroupColors(grpAvailable, Color.LightSkyBlue, Color.DeepSkyBlue)
        ElseIf sender Is grpCustCount OrElse sender Is lblCustCount Then
            SetGroupColors(grpCustCount, Color.MediumSlateBlue, Color.SlateBlue)
        ElseIf sender Is grpEarnings OrElse sender Is lblEarnings Then
            SetGroupColors(grpEarnings, Color.LimeGreen, Color.PaleGreen)
        End If
    End Sub

    Private Sub MouseLeaveHandler(sender As Object, e As EventArgs) Handles grpReservations.MouseLeave, lblReservations.MouseLeave,
        grpAvailable.MouseLeave, lblAvailable.MouseLeave, grpCustCount.MouseLeave,
        lblCustCount.MouseLeave, grpEarnings.MouseLeave, lblEarnings.MouseLeave

        If sender Is grpReservations OrElse sender Is lblReservations Then
            grpReservations.BackColor = Color.DarkOrchid
        ElseIf sender Is grpAvailable OrElse sender Is lblAvailable Then
            grpAvailable.BackColor = Color.DeepSkyBlue
        ElseIf sender Is grpCustCount OrElse sender Is lblCustCount Then
            grpCustCount.BackColor = Color.SlateBlue
        ElseIf sender Is grpEarnings OrElse sender Is lblEarnings Then
            grpEarnings.BackColor = Color.PaleGreen
        End If
    End Sub
End Class
