Imports System.ComponentModel
Imports System.Globalization
Imports ATV_RMS.ctrlCustomers
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class ctrlReservations
    Dim collection As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("Reservation")
    Private reserv As List(Of Reservations)

    Public Class Reservations
        Public Property resID As String
        Public Property FName As String
        Public Property MName As String
        Public Property SName As String
        Public Property tour As String
        Public Property resPrice As String
        Public Property resDate As String
        Public Property resTime As String
        Public Property resStatus As String
    End Class

    Private Sub ctrlReservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectToMongo()
        refreshRes()
    End Sub

    Private Sub ctrlReservations_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        refreshRes()
    End Sub

    Private Sub refreshRes()
        populateList()
        clearResForm()
    End Sub
    Private Sub clearResForm()
        DataGridView1.ClearSelection()
        tbxFName.Clear()
        tbxMName.Clear()
        tbxSName.Clear()
        cboxTour.SelectedIndex = -1
        DateTimePicker1.Value = DateTime.Now
        cboxStatus.SelectedIndex = -1
        cboxTimeSlot.SelectedIndex = -1
        tbxTotal.Clear()
        cboxFilter.SelectedIndex = -1
        tourPrice = 0
        numberOfPerson = 0
        totalPrice = 0
    End Sub

    Private Sub populateResInfo(reserv As List(Of Reservations))
        DataGridView1.Rows.Clear()
        For Each res As Reservations In reserv
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridView1,
            res.resID,
            $"{res.FName} {res.MName} {res.SName}",
            res.tour, res.resDate, res.resTime, res.resStatus
        )
            DataGridView1.Rows.Add(row)
        Next
    End Sub

    Private Sub populateList()
        Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
        reserv = New List(Of Reservations)()

        For Each document As BsonDocument In documents
            Dim res As New Reservations() With {
            .resID = document("resID").ToString,
            .FName = document("First Name").ToString,
            .MName = document("Middle Name").ToString,
            .SName = document("Surname").ToString,
            .tour = document("tourName").ToString,
            .resPrice = document("tourPrice").ToString,
            .resDate = document("Date").ToString,
            .resTime = document("timeSlot").ToString,
            .resStatus = document("Status").ToString
        }
            reserv.Add(res)
        Next
        populateResInfo(reserv)
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            If reserv IsNot Nothing AndAlso DataGridView1.SelectedRows(0).Index < reserv.Count Then
                Dim selectedReserv = reserv(DataGridView1.SelectedRows(0).Index)
                Dim parsedDate As DateTime
                If DateTime.TryParseExact(selectedReserv.resDate, "MM-dd-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, parsedDate) Then
                    DateTimePicker1.Value = parsedDate
                    tbxResID.Text = selectedReserv.resID
                    tbxFName.Text = selectedReserv.FName
                    tbxMName.Text = selectedReserv.MName
                    tbxSName.Text = selectedReserv.SName
                    cboxTour.Text = selectedReserv.tour
                    'DateTimePicker1.Value = selectedReserv.resDate
                    cboxTimeSlot.Text = selectedReserv.resTime
                    cboxStatus.Text = selectedReserv.resStatus
                End If
            End If
        End If
    End Sub

    Private Sub btnAddRes_Click(sender As Object, e As EventArgs) Handles btnAddRes.Click
        Try
            Dim document As New BsonDocument From {
                {"resID", tbxResID.Text},
                {"First Name", tbxFName.Text},
                {"Middle Name", tbxMName.Text},
                {"Surname", tbxSName.Text},
                {"tourName", cboxTour.SelectedItem.ToString()},
                {"tourPrice", tbxTotal.Text},
                {"Date", DateTimePicker1.Value.ToString},
                {"timeSlot", cboxTimeSlot.SelectedItem.ToString},
                {"Status", cboxStatus.SelectedItem.ToString}
            }

            collection.InsertOne(document)

            MessageBox.Show("Reservation added successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshRes()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClearRes_Click(sender As Object, e As EventArgs) Handles btnClearRes.Click
        refreshRes()
    End Sub

    Dim tourPrice As Double = 0
    Dim numberOfPerson As Double = 0
    Dim totalPrice As Double = 0
    Private Sub cboxTour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxTour.SelectedIndexChanged
        If cboxTour.SelectedIndex = 0 Then
            tourPrice = 1500
        ElseIf cboxTour.SelectedIndex = 1 Then
            tourPrice = 5500
        ElseIf cboxTour.SelectedIndex = 2 Then
            tourPrice = 3000
        ElseIf cboxTour.SelectedIndex = 3 Then
            tourPrice = 3500
        ElseIf cboxTour.SelectedIndex = 4 Then
            tourPrice = 4000
        ElseIf cboxTour.SelectedIndex = 5 Then
            tourPrice = 6500
        ElseIf cboxTour.SelectedIndex = 6 Then
            tourPrice = 6500
        ElseIf cboxTour.SelectedIndex = 7 Then
            tourPrice = 5000
        ElseIf cboxTour.SelectedIndex = 8 Then
            tourPrice = 6500
        End If
        totalPrice = tourPrice * numberOfPerson
        tbxTotal.Text = totalPrice
    End Sub

    Private Sub tbxPerson_TextChanged(sender As Object, e As EventArgs) Handles tbxPerson.TextChanged
        If Double.TryParse(tbxPerson.Text, numberOfPerson) Then
            totalPrice = tourPrice * numberOfPerson
            tbxTotal.Text = totalPrice
        End If
    End Sub
End Class