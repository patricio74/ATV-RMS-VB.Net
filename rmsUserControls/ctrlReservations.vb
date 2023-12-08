Public Class ctrlReservations
    Dim tourPrice As Double = 0
    Dim numberOfPerson As Double = 0
    Dim totalPrice As Double = 0
    Private Sub clearAddResTab()
        'cbxTransacFilter.SelectedIndex = 0
        tbxNewFName.Clear()
        tbxNewMName.Clear()
        tbxNewSName.Clear()
        cbxNewTour.SelectedIndex = -1
        dateTimeNew.Value = DateTime.Now
        tbxNewPerson.Clear()
        cbxNewTimeSlot.SelectedIndex = -1
        cbxNewStatus.SelectedIndex = -1
        tbxNewTotal.Clear()
    End Sub
    Private Sub clearUpdResTab()
        'cbxTransacFilter.SelectedIndex = 0
        dgvTransactions.ClearSelection()
        'lblUpdReservID.Text = ""
        tbxReservFName.Clear()
        tbxReservMName.Clear()
        tbxReservSName.Clear()
        cbxReservTour.SelectedIndex = -1
        tbxReservPerson.Clear()
        dateTimeReserv.Value = DateTime.Now
        cbxReservStatus.SelectedIndex = -1
        cbxReservTimeSlot.SelectedIndex = -1
        tbxReservTotal.Clear()
        tourPrice = 0
        numberOfPerson = 0
        totalPrice = 0
    End Sub












    'wag iclear yung reservform pag lumipat sa ibang form
    Private Sub ctrlReservations_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub ctrlReservations_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

    End Sub
End Class