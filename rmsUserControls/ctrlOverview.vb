Public Class ctrlOverview
    Private Sub ctrlOverview_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim currentYear As Integer = DateTime.Now.Year
        For i As Integer = currentYear To currentYear + 2
            cbxYear.Items.Add(i.ToString())
        Next
        cbxYear.SelectedIndex = -1
    End Sub

    Private Sub setGroupColors(group As GroupBox, colorEnter As Color, colorLeave As Color)
        group.BackColor = colorEnter
    End Sub

    Private Sub MouseEnterHandler(sender As Object, e As EventArgs) Handles grpReserv.MouseEnter, lblReservations.MouseEnter,
        grpATV.MouseEnter, lblAvailable.MouseEnter, grpCustomerz.MouseEnter,
        lblCustCount.MouseEnter, grpRevenue.MouseEnter, lblEarnings.MouseEnter

        If sender Is grpReserv OrElse sender Is lblReservations Then
            setGroupColors(grpReserv, Color.MediumOrchid, Color.DarkOrchid)
        ElseIf sender Is grpATV OrElse sender Is lblAvailable Then
            SetGroupColors(grpATV, Color.LightSkyBlue, Color.DeepSkyBlue)
        ElseIf sender Is grpCustomerz OrElse sender Is lblCustCount Then
            SetGroupColors(grpCustomerz, Color.MediumSlateBlue, Color.SlateBlue)
        ElseIf sender Is grpRevenue OrElse sender Is lblEarnings Then
            SetGroupColors(grpRevenue, Color.LimeGreen, Color.PaleGreen)
        End If
    End Sub

    Private Sub MouseLeaveHandler(sender As Object, e As EventArgs) Handles grpReserv.MouseLeave, lblReservations.MouseLeave,
        grpATV.MouseLeave, lblAvailable.MouseLeave, grpCustomerz.MouseLeave,
        lblCustCount.MouseLeave, grpRevenue.MouseLeave, lblEarnings.MouseLeave

        If sender Is grpReserv OrElse sender Is lblReservations Then
            grpReserv.BackColor = Color.DarkOrchid
        ElseIf sender Is grpATV OrElse sender Is lblAvailable Then
            grpATV.BackColor = Color.DeepSkyBlue
        ElseIf sender Is grpCustomerz OrElse sender Is lblCustCount Then
            grpCustomerz.BackColor = Color.SlateBlue
        ElseIf sender Is grpRevenue OrElse sender Is lblEarnings Then
            grpRevenue.BackColor = Color.PaleGreen
        End If
    End Sub


End Class
