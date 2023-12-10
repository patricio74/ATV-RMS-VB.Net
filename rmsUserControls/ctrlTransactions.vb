Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ctrlTransactions
    'para macompute total price
    Dim tourPrice As Double = 0.00
    Dim numberOfPerson As Double = 0.00
    Dim totalPrice As Double = 0.00
    'compute change,balance
    Dim initPayment As Double = 0.00
    Dim totChange As Double = 0.00
    Dim remBalance As Double = 0.00
    Private Sub clearAddTransacTab()
        tourPrice = 0.00
        numberOfPerson = 0.00
        totalPrice = 0.00
        initPayment = 0.00
        totChange = 0.00
        remBalance = 0.00
        dgvTransactions.ClearSelection()
        tbxAddFName.Clear()
        tbxAddMName.Clear()
        tbxAddSname.Clear()
        cbxAddTour.SelectedIndex = -1
        'dateTimeNew.Value = DateTime.Now
        cbxAddTour.SelectedIndex = -1
        cbxAddPerson.SelectedIndex = -1
        tbxAddTotal.Text = "0.00"
        tbxAddInitPayment.Clear()
        tbxAddChange.Text = totChange.ToString("C2")
        tbxAddBalance.Text = remBalance.ToString("C2")
        cbxAddTourGuide.SelectedIndex = -1
    End Sub
    Private Sub clearWaitList()
        tourPrice = 0.00
        numberOfPerson = 0.00
        totalPrice = 0.00
        initPayment = 0.00
        totChange = 0.00
        remBalance = 0.00
        tbxWaitFName.Clear()
        tbxWaitPerson.Clear()
        tbxWaitTotPrice.Clear()
        cbxWaitTour.SelectedIndex = -1
        cbxWaitStatus.SelectedIndex = -1
        cbxWaitTourGuide.SelectedIndex = -1
    End Sub
    Private Sub clearOngoingTab()
        tourPrice = 0.00
        numberOfPerson = 0.00
        totalPrice = 0.00
        initPayment = 0.00
        totChange = 0.00
        remBalance = 0.00
        tbxOnGName.Clear()
        tbxOnGTour.Clear()
        tbxOnGTime.Clear()
        tbxOnGPerson.Clear()
        tbxOnGTotal.Clear()
        cbxOnGTourGuide.SelectedIndex = -1
        cbxOnGStatus.SelectedIndex = -1
    End Sub
    Private Function cbxToursList()
        Dim filter As New BsonDocument()
        Dim tourData As List(Of BsonDocument) = rmsSharedVar.colTrails.Find(filter).ToList()
        Return tourData
    End Function
    Private Sub reloadTrailList()
        'clear combobox then repopulate list
        cbxAddTour.Items.Clear()
        cbxAddTour.SelectedIndex = -1
        Dim tourData As List(Of BsonDocument) = cbxToursList()
        For Each tourDocument As BsonDocument In tourData
            cbxAddTour.Items.Add(tourDocument("nameOfTour").ToString())
        Next
    End Sub
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxOnGName.KeyPress, tbxOnGTour.KeyPress, tbxOnGTime.KeyPress, tbxOnGPerson.KeyPress,
        tbxOnGTour.KeyPress, tbxAddSname.KeyPress, tbxAddMName.KeyPress, tbxAddFName.KeyPress, tbxAddBalance.KeyPress,
        tbxWaitFName.KeyPress, tbxWaitPerson.KeyPress, tbxWaitTotPrice.KeyPress, tbxAddInitPayment.KeyPress, tbxAddChange.KeyPress
        'suppress enter key sound sa mga textboxes
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub tbxPerson(sender As Object, e As KeyPressEventArgs) Handles tbxAddInitPayment.KeyPress, tbxAddTotal.KeyPress, tbxAddChange.KeyPress,
        tbxAddBalance.KeyPress, tbxWaitTotPrice.KeyPress, tbxWaitPerson.KeyPress
        'check if the inputted char is a number,backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub clearForm(sender As Object, e As EventArgs) Handles lblOnGClear.Click, lblClearAdd.Click, lblWaitClear.Click
        If sender Is lblClearAdd Then
            clearAddTransacTab()
            populateTransac()
        ElseIf sender Is lblWaitClear Then
            clearWaitList()
            populateTransac()
        ElseIf sender Is lblOnGClear Then
            clearOngoingTab()
            populateTransac()
        End If
    End Sub
    Private Sub transacCounter()
        'count docs
        Dim ongoingCount = rmsSharedVar.colTransac.CountDocuments(Builders(Of BsonDocument).Filter.Eq(Of String)("status", "ongoing"))
        Dim waitingCount = rmsSharedVar.colTransac.CountDocuments(Builders(Of BsonDocument).Filter.Eq(Of String)("status", "waiting"))
        'display total count
        lblOngoing.Text = $"Ongoing: {ongoingCount}"
        lblWaiting.Text = $"Waiting: {waitingCount}"
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabTransactions.SelectedIndexChanged
        If tabTransactions.SelectedIndex = 0 Then 'walk-in transac tab
            reloadTrailList()
            transacCounter()
            populateTransac()
            clearWaitList()
            clearOngoingTab()
        ElseIf tabTransactions.SelectedIndex = 1 Then 'waiting list tab
            reloadTrailList()
            transacCounter()
        ElseIf tabTransactions.SelectedIndex = 2 Then 'ongoing tab
            reloadTrailList()
            transacCounter()
        End If
    End Sub
    Private tranzac As List(Of trDoc)
    Public Class trDoc
        Public Property trID As String
        Public Property trFname As String '
        Public Property trMname As String
        Public Property trSname As String
        Public Property trTourName As String
        Public Property trTourPrice As String
        Public Property trReservDate As String
        Public Property trTimeSlot As String
        Public Property trStatus As String
        Public Property trTotalPerson As String
        Public Property trTotalPrice As String
        Public Property trTransacStart As String
        Public Property trCustomerID As String
    End Class
    Private Sub populateTransac()
        If rmsDashboard.switchTransac = True Then
            dgvTransactions.Rows.Clear()
            'retrieve docs with status "waiting" or "ongoing"
            Dim filter = Builders(Of BsonDocument).Filter.In(Of String)("status", {"waiting", "ongoing"})
            Dim trDocList As List(Of BsonDocument) = rmsSharedVar.colTransac.Find(filter).ToList()
            tranzac = New List(Of trDoc)()
            For Each document As BsonDocument In trDocList
                Dim idElement = document.GetElement("_id")
                Dim tr As New trDoc() With {
                .trID = idElement.Value.AsObjectId.ToString,
                .trFname = document("FName").ToString,
                .trMname = document("MName").ToString,
                .trSname = document("Sname").ToString,
                .trTourName = document("tourName").ToString,
                .trTourPrice = document("tourPrice").ToString,
                .trReservDate = document("reservDate").ToString,
                .trTimeSlot = document("timeSlot").ToString,
                .trStatus = document("status").ToString,
                .trTotalPerson = document("totalPerson").ToString,
                .trTotalPrice = document("totalPrice").ToString,
                .trTransacStart = document("transacStart").ToString,
                .trCustomerID = document("customer").ToString
                }
                tranzac.Add(tr)
            Next
            dgvTransactions.Rows.Clear()
            For Each doc In tranzac
                Dim applicant As String = $"{doc.trFname} {doc.trMname} {doc.trSname}".Trim()
                dgvTransactions.Rows.Add(doc.trID, applicant, doc.trTourName, doc.trTransacStart, doc.trTimeSlot, doc.trStatus)
            Next
            dgvTransactions.ClearSelection()
            transacCounter()
        End If
    End Sub
    Private Sub dgvTransactions_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactions.CellClick
        If e.RowIndex >= 0 Then
            If tranzac IsNot Nothing AndAlso e.RowIndex < tranzac.Count Then
                Dim selTransac = tranzac(e.RowIndex)
                'check status field ng selected row
                If selTransac.trStatus = "waiting" Then
                    'populate wait list tab
                    tabTransactions.SelectedIndex = 1
                    popuWaitListTab(selTransac)
                ElseIf selTransac.trStatus = "ongoing" Then
                    'populate on going
                    tabTransactions.SelectedIndex = 2
                    popuOngoingTab(selTransac)
                End If
            End If
        End If
    End Sub
    Private Sub popuWaitListTab(selTransac As trDoc)
        tbxWaitFName.Text = selTransac.trFname
        tbxWaitPerson.Text = selTransac.trTotalPerson
    End Sub
    Private Sub popuOngoingTab(selTransac As trDoc)
        tbxOnGName.Text = selTransac.trFname
        tbxOnGPerson.Text = selTransac.trTotalPerson
    End Sub



    Private Sub cbxIndexChanged(sender As Object, e As EventArgs) Handles cbxAddTour.SelectedIndexChanged, cbxAddPerson.SelectedIndexChanged
        'set tour price
        If cbxAddTour.SelectedItem IsNot Nothing Then
            Dim selectedTourName As String = cbxAddTour.SelectedItem.ToString()
            Dim tourData As List(Of BsonDocument) = cbxToursList()
            If tourData IsNot Nothing Then
                Dim selectedTour = tourData.FirstOrDefault(Function(t) t("nameOfTour").ToString() = selectedTourName)
                If selectedTour IsNot Nothing Then
                    Dim tourPriceString As String = selectedTour("price").ToString()
                    If Double.TryParse(tourPriceString, tourPrice) Then
                        If cbxAddPerson IsNot Nothing AndAlso Not String.IsNullOrEmpty(cbxAddPerson.Text) Then
                            If Double.TryParse(cbxAddPerson.Text, numberOfPerson) Then
                                totalPrice = tourPrice * numberOfPerson
                                tbxAddTotal.Text = totalPrice.ToString("C2")
                            Else
                                tbxAddTotal.Text = "0.00"
                            End If
                        Else
                            tbxAddTotal.Text = "0.00"
                        End If
                    End If
                Else
                End If
            Else
            End If
        End If
    End Sub
    'compute total change, balance
    Private Sub tbx_TextChanged(sender As Object, e As EventArgs) Handles tbxAddInitPayment.TextChanged, tbxAddTotal.TextChanged
        Dim inputtedPayment As String = tbxAddInitPayment.Text
        If tbxAddTotal.Text = "" Then
        Else
            If Not String.IsNullOrEmpty(inputtedPayment) AndAlso Double.TryParse(inputtedPayment, initPayment) Then
                If initPayment < totalPrice Then 'display remaining balance
                    totChange = 0.00
                    remBalance = totalPrice - initPayment
                    tbxAddChange.Text = totChange.ToString("C2")
                    tbxAddBalance.Text = remBalance.ToString("C2")
                ElseIf initPayment = totalPrice Then 'reset value ng balance&change pag eksakto binayad
                    totChange = 0.00
                    remBalance = 0.00
                    tbxAddChange.Text = totChange.ToString("C2")
                    tbxAddBalance.Text = remBalance.ToString("C2")
                Else 'display sukli kapag sobra binayad
                    totChange = initPayment - totalPrice
                    remBalance = 0.00
                    tbxAddChange.Text = totChange.ToString("C2")
                    tbxAddBalance.Text = remBalance.ToString("C2")
                End If
            Else
                remBalance = 0.00
                totChange = 0.00
                tbxAddChange.Text = totChange.ToString("C2")
                tbxAddBalance.Text = remBalance.ToString("C2")
            End If
        End If
    End Sub





    'compute total price
    Private Sub tbxAddPerson_TextChanged(sender As Object, e As EventArgs)
        If cbxAddPerson.SelectedIndex = -1 Then
            tbxAddTotal.Text = "0"
        ElseIf cbxAddPerson.Text IsNot "" Then
            Double.TryParse(cbxAddPerson.Text, numberOfPerson)
            totalPrice = tourPrice * numberOfPerson
            tbxAddTotal.Text = totalPrice.ToString("C2")
        End If
    End Sub
    'compute total price
    Private Sub tbxWaitPerson_TextChanged(sender As Object, e As EventArgs) Handles tbxWaitPerson.TextChanged
        If tbxWaitPerson.Text = "" Then
            tbxWaitTotPrice.Clear()
        ElseIf tbxWaitPerson.Text IsNot "" Then
            Double.TryParse(tbxWaitPerson.Text, numberOfPerson)
            totalPrice = tourPrice * numberOfPerson
            tbxWaitTotPrice.Text = totalPrice
        End If
    End Sub
    Private Sub ctrlTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadTrailList()
        populateTransac()
    End Sub
    Private Sub ctrlTransactions_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            reloadTrailList()
            populateTransac()
        ElseIf Me.Visible = False Then
            'closeMongoConn()
            clearAddTransacTab()
            clearWaitList()
            clearOngoingTab()
            reloadTrailList()
            tabTransactions.SelectedIndex = 0
            tranzac = Nothing
        End If
    End Sub







    Private Sub btnAddConfirm_Click(sender As Object, e As EventArgs) Handles btnAddConfirm.Click
        'insert doc to logTransac
        'ongoing stat
        'print invoice
        '

    End Sub

    Private Sub btnAddAtv_Click(sender As Object, e As EventArgs) Handles btnAddAtv.Click
        selectATV.ShowDialog()
    End Sub
End Class