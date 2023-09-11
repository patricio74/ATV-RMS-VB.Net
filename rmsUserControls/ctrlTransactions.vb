Imports System.ComponentModel
Imports System.Globalization
Imports ATV_RMS.ctrlCustomers
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class ctrlTransactions
    Dim tourPrice As Double = 0
    Dim numberOfPerson As Double = 0
    Dim totalPrice As Double = 0

    Dim collection As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("Reservation")
    Private reserv As List(Of Reservations)

    Public Class Reservations
        Public Property resID As String
        Public Property FName As String
        Public Property MName As String
        Public Property SName As String
        Public Property tour As String
        Public Property totPerson As String
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
        refreshRes() 'delete, palitan ng timer
    End Sub

    Private Sub refreshRes()
        populateList()
        clearTransactionForm()
        'reserevation label count
        Dim colReserv As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("custReservations")
        Dim pendingResFilter = Builders(Of BsonDocument).Filter.Eq(Of String)("status", "Pending")
        Dim canceledResFilter = Builders(Of BsonDocument).Filter.Eq(Of String)("status", "Canceled")
        Dim pendingReserv As Long = colReserv.CountDocuments(pendingResFilter)
        Dim canceledReserv As Long = colReserv.CountDocuments(canceledResFilter)
        lblResCount.Text = "Reservation count: " + pendingReserv.ToString + " Pending, " + canceledReserv.ToString + " Canceled"

        'combobox list
        Dim tourData As List(Of BsonDocument) = cbxToursList()
        For Each tourDocument As BsonDocument In tourData
            cboxReservTour.Items.Add(tourDocument("nameOfTour").ToString())
        Next
    End Sub

    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxReservID.KeyPress, tbxReservFName.KeyPress, tbxReservMName.KeyPress,
        tbxReservSName.KeyPress, tbxReservPerson.KeyPress, tbxReservTotal.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub

    Private Sub clearTransactionForm()
        cboxReservFilter.SelectedIndex = -1
        DataGridView1.ClearSelection()

        tbxAddTotal.Clear()

        tbxReservID.Clear()
        tbxReservFName.Clear()
        tbxReservMName.Clear()
        tbxReservSName.Clear()
        cboxReservTour.SelectedIndex = -1
        tbxReservPerson.Clear()
        dateTimeReserv.Value = DateTime.Now
        cboxReservStatus.SelectedIndex = -1
        cboxReservTimeSlot.SelectedIndex = -1
        tbxReservTotal.Clear()
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
            .FName = document("FName").ToString,
            .MName = document("MName").ToString,
            .SName = document("Sname").ToString,
            .tour = document("tourName").ToString,
            .resPrice = document("tourPrice").ToString,
            .resDate = document("date").ToString,
            .totPerson = document("totalPerson").ToString,
            .resTime = document("timeSlot").ToString,
            .resStatus = document("status").ToString
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
                    dateTimeReserv.Value = parsedDate
                    tbxReservID.Text = selectedReserv.resID
                    tbxReservFName.Text = selectedReserv.FName
                    tbxReservMName.Text = selectedReserv.MName
                    tbxReservSName.Text = selectedReserv.SName
                    cboxReservTour.Text = selectedReserv.tour
                    tbxReservPerson.Text = selectedReserv.totPerson
                    cboxReservTimeSlot.Text = selectedReserv.resTime
                    cboxReservStatus.Text = selectedReserv.resStatus
                    tbxReservTotal.Text = "₱" + selectedReserv.resPrice
                End If
            End If
        End If
    End Sub

    Private Sub btnAddRes_Click(sender As Object, e As EventArgs) Handles btnAddRes.Click
        'TODO:
        'add message box for confirmation before proceeding
        Try
            Dim document As New BsonDocument From {
                {"FName", tbxReservFName.Text},
                {"MName", tbxReservMName.Text},
                {"Sname", tbxReservSName.Text},
                {"tourName", cboxReservTour.SelectedItem.ToString()},
                {"tourPrice", tbxReservTotal.Text},
                {"date", dateTimeReserv.Value.ToString},
                {"timeSlot", cboxReservTimeSlot.SelectedItem.ToString},
                {"status", cboxReservStatus.SelectedItem.ToString}
            }

            collection.InsertOne(document)
            'replace msgbox with label
            MessageBox.Show("Reservation added successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshRes()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdRes_Click(sender As Object, e As EventArgs) Handles btnUpdRes.Click

    End Sub

    Private Sub clearForm(sender As Object, e As EventArgs) Handles lblClearAdd.Click, lblClearRes.Click
        clearTransactionForm()
    End Sub

    Private Sub cboxTour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxReservTour.SelectedIndexChanged
        If cboxReservTour.SelectedItem IsNot Nothing Then
            Dim selectedTourName As String = cboxReservTour.SelectedItem.ToString()
            Dim tourData As List(Of BsonDocument) = cbxToursList()
            If tourData IsNot Nothing Then
                Dim selectedTour = tourData.FirstOrDefault(Function(t) t("nameOfTour").ToString() = selectedTourName)
                If selectedTour IsNot Nothing Then
                    Dim tourPriceString As String = selectedTour("price").ToString()
                    If Double.TryParse(tourPriceString, tourPrice) Then
                        If tbxReservPerson IsNot Nothing AndAlso Not String.IsNullOrEmpty(tbxReservPerson.Text) Then
                            If Double.TryParse(tbxReservPerson.Text, numberOfPerson) Then
                                totalPrice = tourPrice * numberOfPerson
                                tbxReservTotal.Text = totalPrice.ToString()
                            Else
                                tbxReservTotal.Clear()
                            End If
                        Else
                            tbxReservTotal.Clear()
                        End If
                    End If
                Else
                End If
            Else
            End If
        End If
    End Sub


    Private Sub tbxPerson_TextChanged(sender As Object, e As EventArgs) Handles tbxReservPerson.TextChanged
        If tbxReservPerson.Text = "" Then
            tbxReservTotal.Clear()
        ElseIf tbxReservPerson.Text IsNot "" Then
            Double.TryParse(tbxReservPerson.Text, numberOfPerson)
            totalPrice = tourPrice * numberOfPerson
            tbxReservTotal.Text = totalPrice
        End If
    End Sub

End Class