Imports System.Globalization
Imports ATV_RMS.ctrlCustomers
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class ctrlTransactions
    Dim colTransac As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDbBase.GetCollection(Of BsonDocument)("logTransactions")
    Dim colReserv As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDbBase.GetCollection(Of BsonDocument)("custReservations")
    Dim tourPrice As Double = 0
    Dim numberOfPerson As Double = 0
    Dim totalPrice As Double = 0
    Private Sub clearReservTab()
        cbxReservFilter.SelectedIndex = -1
        DataGridView1.ClearSelection()
        tbxReservID.Clear()
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
    Private Sub clearTransacTab()
        cbxReservFilter.SelectedIndex = -1
        DataGridView1.ClearSelection()
        tbxAddFName.Clear()
        tbxAddMName.Clear()
        tbxAddSname.Clear()
        cbxAddTour.SelectedIndex = -1
        tbxAddPerson.Clear()
        dateTimeAdd.Value = DateTime.Now
        cbxAddTimeSlot.SelectedIndex = -1
        tbxAddTotal.Clear()
        tourPrice = 0
        numberOfPerson = 0
        totalPrice = 0
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            'transac tab
            cbxReservFilter.Visible = False
            btnViewRes.Visible = False
            lblReservCounter.Visible = False
            lblTransacCounter.Visible = True
            clearReservTab()
            'add code to display data to dgv
        ElseIf TabControl1.SelectedIndex = 1 Then
            'upd reserv tab
            cbxReservFilter.Visible = True
            btnViewRes.Visible = True
            lblReservCounter.Visible = True
            lblTransacCounter.Visible = False
            clearTransacTab()
        Else
        End If
    End Sub
    Private Sub ctrlTransactions_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            closeMongoConn()
            clearTransacTab()
            clearReservTab()
            reloadTrailList()
            TabControl1.SelectedIndex = 0
        End If
    End Sub
    Private Function cbxToursList()
        Dim col As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDbBase.GetCollection(Of BsonDocument)("rmsAtvTours")
        Dim filter As New BsonDocument()
        Dim tourData As List(Of BsonDocument) = col.Find(filter).ToList()
        Return tourData
    End Function
    Private Sub refreshLabel()
        'counter para sa transactions today
        Dim currentDate As DateTime = DateTime.Now.Date
        Dim dateStart As DateTime = currentDate.AddHours(0)
        Dim dateEnd As DateTime = currentDate.AddHours(23).AddMinutes(59).AddSeconds(59)
        Dim transacFilter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.And(
            Builders(Of BsonDocument).Filter.Gte(Of String)("transacDate", dateStart),
            Builders(Of BsonDocument).Filter.Lte(Of String)("transacDate", dateEnd)
        )
        'Dim transacFilter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("transacDate", DateTime.Now.Date)
        Dim transacCount = colTransac.CountDocuments(transacFilter)
        'transac counter
        lblTransacCounter.Text = "Total transactions today: " & transacCount.ToString()

        'pang update ng reservation count
        Dim pendingResFilter = Builders(Of BsonDocument).Filter.Eq(Of String)("status", "Pending")
        Dim canceledResFilter = Builders(Of BsonDocument).Filter.Eq(Of String)("status", "Canceled")
        pendingReserv = colReserv.CountDocuments(pendingResFilter)
        canceledReserv = colReserv.CountDocuments(canceledResFilter)
        'reserv counter
        lblReservCounter.Text = "Reservation count: " + pendingReserv.ToString + " Pending, " + canceledReserv.ToString + " Canceled"
    End Sub
    'call mo rin to kada mag add/update sa form
    Private Sub reloadTrailList()
        'clear combobox then repopulate list
        cbxReservTour.Items.Clear()
        cbxReservTour.SelectedIndex = -1
        cbxAddTour.Items.Clear()
        cbxAddTour.SelectedIndex = -1
        Dim tourData As List(Of BsonDocument) = cbxToursList()
        For Each tourDocument As BsonDocument In tourData
            cbxReservTour.Items.Add(tourDocument("nameOfTour").ToString())
            cbxAddTour.Items.Add(tourDocument("nameOfTour").ToString())
        Next
    End Sub
    Private Sub ctrlTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'refresh content every 3secs
        Timer1.Interval = 3000
        Timer1.Start()
        reloadTrailList()
    End Sub
    'Private Sub ctrlTransactions_Enter(sender As Object, e As EventArgs) Handles Me.Enter

    '    reloadTrailList()
    'call mo to sa click event ng mismong combobox, clear form, add/update res, add transac

    'End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        refreshLabel()
    End Sub
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxReservID.KeyPress, tbxReservFName.KeyPress, tbxReservMName.KeyPress,
        tbxReservSName.KeyPress, tbxReservPerson.KeyPress, tbxReservTotal.KeyPress, tbxAddFName.KeyPress, tbxAddMName.KeyPress, tbxAddSname.KeyPress, tbxAddPerson.KeyPress, tbxAddTotal.KeyPress
        'suppress enter key sound sa mga textboxes
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub clearForm(sender As Object, e As EventArgs) Handles lblClearAdd.Click, lblClearRes.Click
        If sender Is lblClearAdd Then
            clearTransacTab()
        ElseIf sender Is lblClearRes Then
            clearReservTab()
        End If
    End Sub





    Private transac As List(Of Transactions)
    Public Class Transactions
        Public Property custID As String
        Public Property FName As String
        Public Property MName As String
        Public Property Sname As String
        Public Property tourName As String
        Public Property tourPrice As String
        Public Property reservDate As String
        Public Property timeSlot As String
        Public Property status As String
        Public Property totalPerson As String
        Public Property totalPrice As String
        Public Property transacDate As String
    End Class


    Private Sub cbxAddTour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxAddTour.SelectedIndexChanged
        If cbxAddTour.SelectedItem IsNot Nothing Then
            Dim selectedTourName As String = cbxAddTour.SelectedItem.ToString()
            Dim tourData As List(Of BsonDocument) = cbxToursList()
            If tourData IsNot Nothing Then
                Dim selectedTour = tourData.FirstOrDefault(Function(t) t("nameOfTour").ToString() = selectedTourName)
                If selectedTour IsNot Nothing Then
                    Dim tourPriceString As String = selectedTour("price").ToString()
                    If Double.TryParse(tourPriceString, tourPrice) Then
                        If tbxAddPerson IsNot Nothing AndAlso Not String.IsNullOrEmpty(tbxAddPerson.Text) Then
                            If Double.TryParse(tbxAddPerson.Text, numberOfPerson) Then
                                totalPrice = tourPrice * numberOfPerson
                                tbxAddTotal.Text = totalPrice.ToString()
                            Else
                                tbxAddTotal.Clear()
                            End If
                        Else
                            tbxAddTotal.Clear()
                        End If
                    End If
                Else
                End If
            Else
            End If
        End If
    End Sub
    Private Sub btnAddTransac_Click(sender As Object, e As EventArgs) Handles btnAddTransac.Click
        'TODO:
        'add message box for confirmation before proceeding
        'add code pangstop sa pag-insert ng blank form
        Try
            Dim document As New BsonDocument From {
                {"FName", tbxAddFName.Text},
                {"MName", tbxAddMName.Text},
                {"Sname", tbxAddSname.Text},
                {"tourName", cbxAddTour.SelectedItem.ToString()},
                {"tourPrice", tbxAddTotal.Text},
                {"totalPerson", tbxAddPerson.Text},
                {"totalPrice", tbxAddTotal.Text},
                {"reservDate", dateTimeAdd.Value.ToString("yyyy-MM-ddTHH:mm:ssZ")},
                {"transacDate", dateTimeAdd.Value.ToString("yyyy-MM-ddTHH:mm:ssZ")},
                {"timeSlot", cbxAddTimeSlot.SelectedItem.ToString}
            }
            colTransac.InsertOne(document)
            'replace msgbox with label
            MessageBox.Show("Transaction successful.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshLabel()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub







    Private reserv As List(Of Reservations)
    Dim pendingReserv As Long
    Dim canceledReserv As Long
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
    Private Sub populateReservList()
        Dim documents As List(Of BsonDocument) = colReserv.Find(New BsonDocument()).ToList()
        reserv = New List(Of Reservations)()

        For Each document As BsonDocument In documents
            '.resID = document("resID").ToString,
            Dim res As New Reservations() With {
            .FName = document("FName").ToString,
            .MName = document("MName").ToString,
            .SName = document("Sname").ToString,
            .tour = document("tourName").ToString,
            .resPrice = document("tourPrice").ToString,
            .resDate = document("reservDate").ToString,
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
                    cbxReservTour.Text = selectedReserv.tour
                    tbxReservPerson.Text = selectedReserv.totPerson
                    cbxReservTimeSlot.Text = selectedReserv.resTime
                    cbxReservStatus.Text = selectedReserv.resStatus
                    tbxReservTotal.Text = "₱" + selectedReserv.resPrice
                End If
            End If
        End If
    End Sub
    Private Sub btnUpdRes_Click(sender As Object, e As EventArgs) Handles btnUpdRes.Click
        'TODO:
        'add message box for confirmation before proceeding
        'update reserv where id = selectedrow id
        Try
            Dim document As New BsonDocument From {
                {"FName", tbxReservFName.Text},
                {"MName", tbxReservMName.Text},
                {"Sname", tbxReservSName.Text},
                {"tourName", cbxReservTour.SelectedItem.ToString()},
                {"tourPrice", tbxReservTotal.Text},
                {"reservDate", dateTimeReserv.Value.ToString("yyyy-MM-ddTHH:mm:ssZ")},
                {"timeSlot", cbxReservTimeSlot.SelectedItem.ToString},
                {"status", cbxReservStatus.SelectedItem.ToString}
            }
            colReserv.InsertOne(document)
            'replace msgbox with label
            MessageBox.Show("Reservation added successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshLabel()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cbxReservTour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxReservTour.SelectedIndexChanged
        If cbxReservTour.SelectedItem IsNot Nothing Then
            Dim selectedTourName As String = cbxReservTour.SelectedItem.ToString()
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
    'compute total price
    Private Sub tbxAddPerson_TextChanged(sender As Object, e As EventArgs) Handles tbxAddPerson.TextChanged
        If tbxAddPerson.Text = "" Then
            tbxAddTotal.Clear()
        ElseIf tbxAddPerson.Text IsNot "" Then
            Double.TryParse(tbxAddPerson.Text, numberOfPerson)
            totalPrice = tourPrice * numberOfPerson
            tbxAddTotal.Text = totalPrice
        End If
    End Sub
    'compute total price
    Private Sub tbxReservPerson_TextChanged(sender As Object, e As EventArgs) Handles tbxReservPerson.TextChanged
        If tbxReservPerson.Text = "" Then
            tbxReservTotal.Clear()
        ElseIf tbxReservPerson.Text IsNot "" Then
            Double.TryParse(tbxReservPerson.Text, numberOfPerson)
            totalPrice = tourPrice * numberOfPerson
            tbxReservTotal.Text = totalPrice
        End If
    End Sub

    Private Sub btnViewRes_Click(sender As Object, e As EventArgs) Handles btnViewRes.Click

    End Sub
End Class