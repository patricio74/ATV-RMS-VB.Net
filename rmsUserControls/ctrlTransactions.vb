﻿Imports System.Drawing.Printing
Imports System.Text
Imports ATV_RMS.atvSelection
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ctrlTransactions
    'para macompute total price
    Dim tourPrice As Double = 0.00 'price ng selected tour
    Dim numberOfPerson As Integer = 0
    Dim totalPrice As Double = 0.00 'selected tour * no. of person
    'compute change,balance
    Dim initPayment As Double = 0.00
    Dim remBalance As Double = 0.00
    Dim finPayment As Double = 0.00
    Dim totChange As Double = 0.00
    'waitlist
    Dim waitTourPrice As Double = 0.00
    Dim waitPerson As Double = 0
    Dim waitTotPrice As Double = 0.00
    Dim waitInitPayment As Double = 0.00
    Dim waitTotChange As Double = 0.00
    Dim waitBalance As Double = 0.00
    Dim waitFinPayment As Double = 0.00
    Dim waitChange As Double = 0.00
    Private Sub clearAddTransacTab()
        tourPrice = 0.00
        numberOfPerson = 0
        totalPrice = 0.00
        initPayment = 0.00
        totChange = 0.00
        remBalance = 0.00
        dgvTransactions.ClearSelection()
        tbxAddFName.Clear()
        tbxAddMName.Clear()
        tbxAddSname.Clear()
        cbxAddTour.SelectedIndex = -1
        cbxAddPerson.SelectedIndex = 0
        tbxAddTotal.Text = totalPrice.ToString("N2")
        tbxAddNewPayment.Clear()
        tbxAddChange.Text = totChange.ToString("N2")
        'tbxAddInitPayment.Text = remBalance.ToString("N2")
        lblTourPrice.Text = tourPrice.ToString("N2")
        cbxAddTourGuide.SelectedIndex = -1
        cbxAddTimeSlot.SelectedIndex = -1
        transacCounter()
    End Sub
    Private Sub clearWaitList()
        waitTourPrice = 0.00
        waitPerson = 0
        waitTotPrice = 0.00
        waitInitPayment = 0.00
        waitTotChange = 0.00
        waitBalance = 0.00
        waitFinPayment = 0.00
        waitChange = 0.00
        tbxWaitCustName.Clear()
        tbxWaitInitPayment.Text = waitinitPayment.ToString("N2")
        tbxWaitFinPayment.Clear()
        tbxWaitTour.Clear()
        cbxWaitTourGuide.SelectedIndex = -1
        tbxWaitPerson.Clear()
        tbxWaitChange.Text = waitChange.ToString("N2")
        'cbxWaitStatus.SelectedIndex = -1
        tbxWaitTotPrice.Text = waitTotPrice.ToString("N2")
        tbxWaitBalance.Text = waitBalance.ToString("N2")
        lblWaitID.Text = ""
        transacCounter()
        'clear selected atv array
    End Sub
    Private Sub clearOngoingTab()
        tourPrice = 0.00
        numberOfPerson = 0
        totalPrice = 0.00
        initPayment = 0.00
        finPayment = 0.00
        totChange = 0.00
        remBalance = 0.00
        tbxOnGName.Clear()
        tbxOnGTour.Clear()
        tbxOnGTourGuide.Clear()
        tbxOnGPerson.Clear()
        tbxOnGTotalPrice.Text = totalPrice.ToString("N2")
        tbxOnGTourPrice.Clear()
        tbxOnGTrailDate.Clear()
        lblTransacID.Text = ""
        'rmsSharedVar.atvInUseID = Nothing
        transacCounter()
        'add code to clear selected atv array
    End Sub
    Private tranzac As List(Of trDoc)
    Public Class trDoc
        Public Property trID As String
        Public Property trFname As String '
        Public Property trMname As String
        Public Property trSname As String
        Public Property trTourName As String
        Public Property trTourPrice As String
        Public Property trDuration As String
        Public Property trReservDate As String
        Public Property trTotalPerson As String
        Public Property trTimeSlot As String
        Public Property trStatus As String
        Public Property trBalance As String
        Public Property trInitPayment As String
        Public Property trTotalPayment As String
        Public Property trGcashNum As String
        Public Property trChange As String
        Public Property trATV As List(Of BsonDocument)
        Public Property trTGuide As String
        Public Property trTGuideID As String
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
                .trDuration = document("duration").ToString,
                .trReservDate = document("reservDate").ToString,
                .trTotalPerson = document("totalPerson").ToString,
                .trTimeSlot = document("timeSlot").ToString,
                .trStatus = document("status").ToString,
                .trBalance = document("Balance").ToString,
                .trInitPayment = document("InitialPayment").ToString,
                .trTotalPayment = document("TotalPayment").ToString,
                .trGcashNum = document("gCashNum").ToString,
                .trChange = document("change").ToString,
                .trTransacStart = document("transacStart").ToString,
                .trTGuide = document("tourGuide").ToString,
                .trTGuideID = document("tourGuideID").ToString,
                .trCustomerID = document("customer").ToString
                }
                tranzac.Add(tr)
            Next
            'sort reservDate in descending order
            tranzac = tranzac.OrderByDescending(Function(tr) DateTime.Parse(tr.trReservDate)).ToList()

            dgvTransactions.Rows.Clear()
            For Each doc In tranzac
                Dim applicant As String = ($"{doc.trFname} {doc.trMname} {doc.trSname}").Trim()
                'convert to datetime object
                Dim resvDate As DateTime = DateTime.Parse(doc.trReservDate)
                'change format para mas readable
                Dim formattedDate As String = resvDate.ToString("MMM. dd, yyyy hh:mmtt")
                dgvTransactions.Rows.Add(applicant, doc.trTourName, formattedDate, doc.trTimeSlot, doc.trStatus)
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
        clearOngoingTab()
        tbxWaitCustName.Text = (selTransac.trFname + " " + selTransac.trMname + " " + selTransac.trSname).Trim
        tbxWaitTour.Text = selTransac.trTourName
        tbxWaitPerson.Text = selTransac.trTotalPerson
        rmsSharedVar.atvTotNum = tbxWaitPerson.Text
        initPayment = selTransac.trInitPayment
        tbxWaitInitPayment.Text = initPayment.ToString("N2")
        totalPrice = selTransac.trTotalPayment
        tbxWaitTotPrice.Text = totalPrice.ToString("N2")
        remBalance = selTransac.trBalance
        tbxWaitBalance.Text = remBalance.ToString("N2")
        lblWaitID.Text = selTransac.trID
        'rmsSharedVar.atvInUseID = Nothing
        '!!!!!!!!!!
        'tourguide, atv array blank lang sya kasi iseselect pa lang value
    End Sub
    Private Sub popuOngoingTab(selTransac As trDoc)
        clearWaitList()
        tbxOnGName.Text = (selTransac.trFname + " " + selTransac.trMname + " " + selTransac.trSname).Trim
        tbxOnGTour.Text = selTransac.trTourName
        tbxOnGTourGuide.Text = selTransac.trTGuide
        tourPrice = selTransac.trTourPrice
        tbxOnGTourPrice.Text = tourPrice.ToString("N2")
        tbxOnGPerson.Text = selTransac.trTotalPerson
        totalPrice = selTransac.trTotalPayment
        tbxOnGTotalPrice.Text = totalPrice.ToString("N2")
        Dim startDate As DateTime = DateTime.Parse(selTransac.trTransacStart)
        tbxOnGTrailDate.Text = startDate.ToString("MMM. dd, yyyy hh:mm tt")
        lblTransacID.Text = selTransac.trID
        'rmsSharedVar.atvInUseID = Nothing

        'populate dgv ng list ng atv na ginamit
        If String.IsNullOrEmpty(selTransac.trID) Then
            'clear dgv if atvInUseID=nothing
            dgvViewAtv.Rows.Clear()
            Return
        End If
        'get atvlist ng selected transaction
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(selTransac.trID))
        Dim projection = Builders(Of BsonDocument).Projection.Include("selectedATV")
        Dim result = rmsSharedVar.colTransac.Find(filter).Project(projection).FirstOrDefault()
        If result IsNot Nothing AndAlso result.Contains("selectedATV") Then
            Dim selectedATVList As BsonArray = result("selectedATV").AsBsonArray
            'populate dgv
            dgvViewAtv.Rows.Clear()
            For Each atv As BsonDocument In selectedATVList
                Dim atvName As String = atv("Name").AsString
                dgvViewAtv.Rows.Add(atvName)
            Next
        End If
    End Sub
    Private Sub ctrlTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'disable dgv sorting on column header clikc
        For Each column As DataGridViewColumn In dgvTransactions.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        reloadTrailList()
        reloadTGuideList()
        populateTransac()
        cbxAddPerson.SelectedIndex = 0
    End Sub
    Private Sub ctrlTransactions_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            reloadTrailList()
            reloadTGuideList()
            populateTransac()
            cbxAddPerson.SelectedIndex = 0
        ElseIf Me.Visible = False Then
            'closeMongoConn()
            clearAddTransacTab()
            clearWaitList()
            clearOngoingTab()
            tabTransactions.SelectedIndex = 0
            tranzac = Nothing
        End If
    End Sub
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxOnGName.KeyPress, tbxOnGTour.KeyPress, tbxOnGPerson.KeyPress,
        tbxOnGTour.KeyPress, tbxAddSname.KeyPress, tbxAddMName.KeyPress, tbxAddFName.KeyPress,
        tbxWaitCustName.KeyPress, tbxWaitPerson.KeyPress, tbxWaitTotPrice.KeyPress, tbxAddNewPayment.KeyPress, tbxAddChange.KeyPress
        'suppress enter key sound sa mga textboxes
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub tbxPerson(sender As Object, e As KeyPressEventArgs) Handles tbxAddNewPayment.KeyPress, tbxAddTotal.KeyPress, tbxAddChange.KeyPress,
        tbxWaitTotPrice.KeyPress, tbxWaitPerson.KeyPress, tbxOnGTourPrice.KeyPress, tbxWaitFinPayment.KeyPress
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
    '!!!!!!!!!!! A D D   W A L K - I N   T R A N S A C   T A B!!!!!!!!!!!!
    Private Function cbxToursList()
        Dim filter As New BsonDocument()
        Dim tourData As List(Of BsonDocument) = rmsSharedVar.colTrails.Find(filter).ToList()
        Return tourData
    End Function
    Private Sub reloadTrailList()
        'clear combobox then repopulate list
        cbxAddTour.Items.Clear()
        cbxAddTour.SelectedIndex = -1
        tourPrice = 0.00
        lblTourPrice.Text = tourPrice.ToString("N2")
        Dim tourData As List(Of BsonDocument) = cbxToursList()
        For Each tourDocument As BsonDocument In tourData
            cbxAddTour.Items.Add(tourDocument("nameOfTour").ToString())
        Next
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
                    lblTourPrice.Text = tourPriceString
                    If Double.TryParse(tourPriceString, tourPrice) Then
                        If cbxAddPerson IsNot Nothing AndAlso Not String.IsNullOrEmpty(cbxAddPerson.Text) AndAlso cbxAddPerson.SelectedIndex <> -1 Then
                            If Double.TryParse(cbxAddPerson.Text, numberOfPerson) Then
                                totalPrice = tourPrice * numberOfPerson
                                tbxAddTotal.Text = totalPrice.ToString("N2")
                            Else
                                totalPrice = 0.00
                                numberOfPerson = 0
                                tbxAddTotal.Text = totalPrice.ToString("N2")
                            End If
                        Else
                            totalPrice = 0.00
                            numberOfPerson = 0
                            tbxAddTotal.Text = totalPrice.ToString("N2")
                        End If
                    End If
                Else
                    tourPrice = 0.00
                    lblTourPrice.Text = tourPrice.ToString("N2")
                End If
            Else
            End If
        End If
    End Sub
    Private Sub reloadTGuideList()
        Try
            'clear and repopulate tour guide comboboxes
            cbxAddTourGuide.Items.Clear()
            cbxWaitTourGuide.Items.Clear()
            'create an array to store the full name and _id of each tour guide
            Dim tourGuides As New List(Of Tuple(Of String, String))
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("status", "available")
            Dim projection = Builders(Of BsonDocument).Projection.Include("FName").Include("MName").Include("Sname").Include("_id")
            Dim cursor = rmsSharedVar.colTourGuide.Find(filter).Project(projection).ToCursor()
            While cursor.MoveNext()
                For Each document In cursor.Current
                    Dim fullName As String = $"{document("FName").AsString} {document("MName").AsString} {document("Sname").AsString}"
                    Dim tourGuideId As String = document("_id").ToString()
                    ' Add a tuple with the full name and _id to the array
                    tourGuides.Add(New Tuple(Of String, String)(fullName, tourGuideId))
                    ' Add tour guide names to cboxes
                    cbxAddTourGuide.Items.Add(fullName)
                    cbxWaitTourGuide.Items.Add(fullName)
                Next
            End While
            'store the tour guide array in a shared variable for later use
            rmsSharedVar.atvGuide = tourGuides
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabTransactions.SelectedIndexChanged
        If tabTransactions.SelectedIndex = 0 Then 'walk-in transac tab
            clearWaitList()
            clearOngoingTab()
            reloadTrailList()
            reloadTGuideList()
            populateTransac()
            'rmsSharedVar.atvInUseID = Nothing
        ElseIf tabTransactions.SelectedIndex = 1 Then 'waiting list tab
            reloadTrailList()
            reloadTGuideList()
            transacCounter()
            'rmsSharedVar.atvInUseID = Nothing
        ElseIf tabTransactions.SelectedIndex = 2 Then 'ongoing tab
            reloadTrailList()
            reloadTGuideList()
            transacCounter()
        End If
    End Sub
    'compute total change, balance
    Private Sub tbx_TextChanged(sender As Object, e As EventArgs) Handles tbxAddNewPayment.TextChanged, tbxAddTotal.TextChanged
        Dim inputtedPayment As String = tbxAddNewPayment.Text
        If tbxAddTotal.Text = "" Then
        Else
            If Not String.IsNullOrEmpty(inputtedPayment) AndAlso Double.TryParse(inputtedPayment, initPayment) Then
                If initPayment < totalPrice Then 'store remaining balance
                    totChange = 0.00
                    remBalance = totalPrice - initPayment
                    tbxAddChange.Text = totChange.ToString("N2")
                    'tbxAddInitPayment.Text = remBalance.ToString("N2")
                ElseIf initPayment = totalPrice Then 'reset value ng balance&change pag eksakto binayad
                    totChange = 0.00
                    remBalance = 0.00
                    tbxAddChange.Text = totChange.ToString("N2")
                    'tbxAddInitPayment.Text = remBalance.ToString("N2")
                Else 'display sukli kapag sobra binayad
                    totChange = initPayment - totalPrice
                    remBalance = 0.00
                    tbxAddChange.Text = totChange.ToString("N2")
                    'tbxAddInitPayment.Text = remBalance.ToString("N2")
                End If
            Else
                remBalance = 0.00
                totChange = 0.00
                tbxAddChange.Text = totChange.ToString("N2")
                'tbxAddInitPayment.Text = remBalance.ToString("N2")
            End If
        End If
    End Sub
    'save total person to variable
    Private Sub tbxAddPerson_TextChanged(sender As Object, e As EventArgs) Handles cbxAddPerson.TextChanged
        If cbxAddPerson.SelectedIndex = -1 Then
            tbxAddTotal.Text = "0"
            numberOfPerson = 0
        ElseIf cbxAddPerson.Text IsNot "" Then
            numberOfPerson = cbxAddPerson.Text
            Double.TryParse(cbxAddPerson.Text, numberOfPerson)
            totalPrice = tourPrice * numberOfPerson
            tbxAddTotal.Text = totalPrice.ToString("N2")
        End If
    End Sub
    'select atv only if numberOfPerson >0
    Private Sub btnAddAtv_Click(sender As Object, e As EventArgs) Handles btnAddAtv.Click
        If cbxAddPerson.SelectedIndex <> -1 Then
            numberOfPerson = cbxAddPerson.Text
            rmsSharedVar.atvTotNum = numberOfPerson
            atvSelection.ShowDialog()
        Else
            numberOfPerson = 0
            rmsSharedVar.atvTotNum = numberOfPerson
        End If
    End Sub
    Private Sub btnAddConfirm_Click(sender As Object, e As EventArgs) Handles btnAddConfirm.Click
        If String.IsNullOrEmpty(tbxAddFName.Text) OrElse String.IsNullOrEmpty(tbxAddSname.Text) OrElse String.IsNullOrEmpty(tbxAddNewPayment.Text) OrElse cbxAddTimeSlot.SelectedIndex <= -1 OrElse cbxAddPerson.SelectedIndex <= -1 OrElse cbxAddTour.SelectedIndex <= -1 OrElse cbxAddTourGuide.SelectedIndex <= -1 OrElse rmsSharedVar.selectedATVs Is Nothing OrElse rmsSharedVar.selectedATVs.Count = 0 Then
            MessageBox.Show("Please fill in the required fields to continue.")
        Else
            Dim inputtedPayment As String = tbxAddNewPayment.Text
            If remBalance >= 1 Then
                MessageBox.Show("You need an additional " + remBalance.ToString("N2") + " to continue.", "Payment not enough!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'check the balance
                If remBalance < 1 Then
                    'insert doc to logTransac, stat=ongoing
                    Dim addConfirmation As DialogResult = MessageBox.Show("Do you want to add this transaction?", "Confirmation", MessageBoxButtons.YesNo)
                    If addConfirmation = DialogResult.Yes Then
                        Try
                            'convert selectedATVs into a BsonArray
                            Dim atvArray As New BsonArray()
                            For Each item As atvItem In rmsSharedVar.selectedATVs
                                Dim atvItemDoc As New BsonDocument From {
                                        {"Name", item.Name},
                                        {"Id", item.Id}
                                    }
                                atvArray.Add(atvItemDoc)
                                'get _id
                                Dim selectedAtvId As ObjectId = item.Id
                                'set status to "not available"
                                Dim updateAtvFilter = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", selectedAtvId)
                                Dim updateAtv = Builders(Of BsonDocument).Update.Set(Of String)("status", "NOT AVAILABLE")
                                rmsSharedVar.colInventory.UpdateOne(updateAtvFilter, updateAtv)
                            Next

                            'get selected tour guide's name
                            Dim selectedTourGuideName As String = cbxAddTourGuide.SelectedItem.ToString()
                            'find the corresponding tuple in the array based on the selected name
                            Dim selectedTourGuideTuple As Tuple(Of String, String) = Nothing
                            For Each tourGuideTuple As Tuple(Of String, String) In rmsSharedVar.atvGuide
                                If tourGuideTuple.Item1 = selectedTourGuideName Then
                                    selectedTourGuideTuple = tourGuideTuple
                                    Exit For
                                End If
                            Next

                            If selectedTourGuideTuple IsNot Nothing Then
                                ' Retrieve the _id of the selected tour guide
                                Dim selectedTourGuideId As String = selectedTourGuideTuple.Item2
                                ' Update the selected tour guide's status to "not available"
                                Dim updateTourGuideFilter = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(selectedTourGuideId))
                                Dim updateTourGuide = Builders(Of BsonDocument).Update.Set(Of String)("status", "not available")
                                rmsSharedVar.colTourGuide.UpdateOne(updateTourGuideFilter, updateTourGuide)

                                'save transaction sa db
                                Dim newTransacDoc As New BsonDocument From {
                                    {"FName", tbxAddFName.Text},
                                    {"MName", tbxAddMName.Text},
                                    {"Sname", tbxAddSname.Text},
                                    {"tourName", cbxAddTour.SelectedItem.ToString},
                                    {"tourGuide", selectedTourGuideName},
                                    {"tourGuideID", selectedTourGuideId},
                                    {"tourPrice", lblTourPrice.Text},
                                    {"totalPerson", cbxAddPerson.SelectedItem.ToString},
                                    {"timeSlot", cbxAddTimeSlot.SelectedItem.ToString},
                                    {"status", "ongoing"},
                                    {"TotalPayment", tbxAddTotal.Text},
                                    {"gCashNum", ""},
                                    {"change", tbxAddChange.Text},
                                    {"selectedATV", atvArray},
                                    {"duration", ""},
                                    {"customer", ""},
                                    {"Balance", "0.00"},
                                    {"reservDate", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ")},
                                    {"transacStart", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ")},
                                    {"InitialPayment", "0.00"}, 'full payment pag walk in, reserve lang may downpayment
                                    {"finPayment", tbxAddNewPayment.Text} 'dito na agad bayad
                                    }
                                rmsSharedVar.colTransac.InsertOne(newTransacDoc)
                                MessageBox.Show("New transaction added successfully!")
                                ' Generate and show receipt
                                generateWalkInReceipt(newTransacDoc)

                                'add code to reset atv array saka tourguide pagtapos ng transaction
                                clearAddTransacTab()
                                populateTransac()
                            End If
                        Catch ex As Exception
                            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub generateWalkInReceipt(transacDoc As BsonDocument)
        Try
            ' Dim receipt As New StringBuilder()
            ' ' Build receipt text using transacDoc values
            '  receipt.AppendLine("ATV RENTAL RECEIPT")
            '  receipt.AppendLine($"Customer: {tbxAddFName.Text} {tbxAddMName.Text} {tbxAddSname.Text}")
            ' receipt.AppendLine($"Trail Name: {cbxAddTour.SelectedItem.ToString}")
            '  receipt.AppendLine($"Tour Guide: {cbxAddTourGuide.SelectedItem.ToString}")
            '  receipt.AppendLine($"Total Person: {cbxAddPerson.SelectedItem.ToString}")
            '  Dim pricePerHead As String = lblTourPrice.Text
            '  receipt.AppendLine($"Trail Price/Head: {pricePerHead}")
            '  Dim totPayment As String = tbxAddNewPayment.Text
            '   receipt.AppendLine($"Total Paid: {totPayment}")
            '  Dim totChange As String = tbxAddChange.Text
            '  receipt.AppendLine($"Total Change: {totChange}")
            '  receipt.AppendLine($"Transaction Date: {DateTime.UtcNow.ToString("MMM. dd, yyyy hh:mm tt")}")
            '  ' Display the receipt
            '  MessageBox.Show(receipt.ToString(), "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optionally, you can also print the receipt using PrintDocument and PrintPreviewDialog
            ' Uncomment the following lines if you want to enable printing
            Dim printDocument As New PrintDocument()
            AddHandler printDocument.PrintPage, AddressOf printWalkInReceipt
            Dim printPreviewDialog As New PrintPreviewDialog()
            printPreviewDialog.Document = printDocument
            printPreviewDialog.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred while generating the receipt: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Uncomment the following lines if you want to enable printing
    Private Sub printWalkInReceipt(sender As Object, e As PrintPageEventArgs)
        Dim graphics As Graphics = e.Graphics
        Dim font As New Font("Courier New", 8)
        Dim yPos As Single = 10

        ' Use the graphics object to draw the receipt content
        graphics.DrawString("ATV RENTAL RECEIPT", font, Brushes.Black, 10, yPos)
        yPos += 15
        graphics.DrawString($"Customer: {tbxAddFName.Text} {tbxAddMName.Text} {tbxAddSname.Text}", font, Brushes.Black, 10, yPos)
        yPos += 15
        graphics.DrawString($"Trail Name: {cbxAddTour.SelectedItem.ToString}", font, Brushes.Black, 10, yPos)
        yPos += 15
        graphics.DrawString($"Tour Guide: {cbxAddTourGuide.SelectedItem.ToString}", font, Brushes.Black, 10, yPos)
        yPos += 15
        graphics.DrawString($"Total Person: {cbxAddPerson.SelectedItem.ToString}", font, Brushes.Black, 10, yPos)
        yPos += 15
        Dim pricePerHead As String = lblTourPrice.Text
        Dim totPayment As String = tbxAddNewPayment.Text
        Dim totChange As String = tbxAddChange.Text
        graphics.DrawString($"Trail Price/Head: {pricePerHead}", font, Brushes.Black, 10, yPos)
        yPos += 15
        graphics.DrawString($"Total Paid: {totPayment}", font, Brushes.Black, 10, yPos)
        yPos += 15
        graphics.DrawString($"Total Change: {totChange}", font, Brushes.Black, 10, yPos)
        yPos += 15
        graphics.DrawString($"Transaction Date: {DateTime.UtcNow.ToString("MMM. dd, yyyy hh:mm tt")}", font, Brushes.Black, 10, yPos)
        yPos += 15
    End Sub


    '!!!!!!!!!!! W A I T I N G   T A B !!!!!!!!!!!!
    Dim numberOfWaitPerson As Integer
    'select atv only if numberOfWaitPerson >0
    Private Sub btnWaitAtv_Click(sender As Object, e As EventArgs) Handles btnWaitAtv.Click
        If Not String.IsNullOrEmpty(tbxWaitPerson.Text) Then
            If Integer.TryParse(tbxWaitPerson.Text, numberOfWaitPerson) AndAlso numberOfWaitPerson > 0 Then
                rmsSharedVar.atvWaitTotNum = numberOfWaitPerson
                atvSelection.ShowDialog()
            Else
                numberOfWaitPerson = 0
                rmsSharedVar.atvWaitTotNum = numberOfWaitPerson
            End If
        End If
    End Sub
    Private Sub tbxWaitFinPayment_TextChanged(sender As Object, e As EventArgs) Handles tbxWaitFinPayment.TextChanged
        'check muna kung may laman
        If Not String.IsNullOrEmpty(tbxWaitFinPayment.Text) Then
            'compute change
            Double.TryParse(tbxWaitBalance.Text, waitBalance)
            Double.TryParse(tbxWaitFinPayment.Text, waitFinPayment)
            waitChange = waitFinPayment - waitBalance
            If waitBalance > waitFinPayment Then 'kulang bayad, 0 sukli
                waitChange = 0.00
                tbxWaitChange.Text = waitChange.ToString("N2")
            ElseIf waitBalance < waitFinPayment Then 'mas mataas bayad kesa balance, display sukli
                tbxWaitChange.Text = waitChange.ToString("N2")
            ElseIf waitBalance = waitFinPayment Then 'wala sukli
                tbxWaitChange.Text = waitChange.ToString("N2")
            End If
        Else
            waitChange = 0.00
        End If
    End Sub
    Private Sub btnStartTrail_Click(sender As Object, e As EventArgs) Handles btnStartTrail.Click
        'check payment tbx
        If String.IsNullOrEmpty(tbxWaitFinPayment.Text) OrElse cbxWaitTourGuide.SelectedIndex = -1 OrElse rmsSharedVar.selectedATVs Is Nothing OrElse rmsSharedVar.selectedATVs.Count = 0 Then
            MessageBox.Show("Please enter payment/select tour guide, ATVs, to continue.")
            Return
        End If
        'check balance
        If waitFinPayment < waitBalance Then
            MessageBox.Show("There is still a remaining balance. Please complete the payment.")
            Return
        End If

        Dim waitConfirmation As DialogResult = MessageBox.Show("Do you want to start this trail now?", "Confirmation", MessageBoxButtons.YesNo)
        If waitConfirmation = DialogResult.Yes Then
            Try
                'convert selectedATVs into a BsonArray
                Dim atvArray As New BsonArray()
                For Each item As atvItem In rmsSharedVar.selectedATVs
                    Dim atvItemDoc As New BsonDocument From {
                            {"Name", item.Name},
                            {"Id", item.Id}
                        }
                    atvArray.Add(atvItemDoc)
                    'get _id
                    Dim selectedAtvId As ObjectId = item.Id
                    'set status to "not available"
                    Dim updateAtvFilter = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", selectedAtvId)
                    Dim updateAtv = Builders(Of BsonDocument).Update.Set(Of String)("status", "NOT AVAILABLE")
                    rmsSharedVar.colInventory.UpdateOne(updateAtvFilter, updateAtv)
                Next

                'get selected tour guide's name
                Dim selectedTourGuideName As String = cbxWaitTourGuide.SelectedItem.ToString()
                'find the corresponding tuple in the array based on the selected name
                Dim selectedTourGuideTuple As Tuple(Of String, String) = Nothing
                For Each tourGuideTuple As Tuple(Of String, String) In rmsSharedVar.atvGuide
                    If tourGuideTuple.Item1 = selectedTourGuideName Then
                        selectedTourGuideTuple = tourGuideTuple
                        Exit For
                    End If
                Next
                If selectedTourGuideTuple IsNot Nothing Then
                    ' Retrieve the _id of the selected tour guide
                    Dim selectedTourGuideId As String = selectedTourGuideTuple.Item2
                    ' Update the selected tour guide's status to "not available"
                    Dim updateTourGuideFilter = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(selectedTourGuideId))
                    Dim updateTourGuide = Builders(Of BsonDocument).Update.Set(Of String)("status", "not available")
                    rmsSharedVar.colTourGuide.UpdateOne(updateTourGuideFilter, updateTourGuide)

                    'logTransac, stat=ongoing
                    ' Update the status of the selected row to "ongoing"
                    Dim filter = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(lblWaitID.Text))
                    'Dim updateStatus = Builders(Of BsonDocument).Update
                    'rmsSharedVar.colTransac.UpdateOne(filter, updateStatus)

                    ' Add new fields to the document
                    Dim updateFields = Builders(Of BsonDocument).Update.Set(Of String)("change", waitChange.ToString) _
                                                                        .Set(Of String)("finPayment", waitFinPayment.ToString) _
                                                                        .Set(Of String)("Balance", waitBalance.ToString) _
                                                                        .Set(Of String)("transacStart", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ")) _
                                                                        .Set(Of String)("tourGuide", selectedTourGuideName) _
                                                                        .Set(Of String)("tourGuideID", selectedTourGuideId) _
                                                                        .Set(Of BsonArray)("selectedATV", atvArray) _
                                                                        .Set(Of String)("status", "ongoing")
                    ' Update the document with the new fields and values
                    rmsSharedVar.colTransac.UpdateOne(filter, updateFields)
                    MessageBox.Show("Selected trail has now started!")

                    ' ' Generate and show receipt
                    generateWaitReceipt()
                    '
                    'add code to reset atv array saka tourguide pagtapos ng transaction
                    clearWaitList()
                    populateTransac()
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub generateWaitReceipt()
        Try
            ' Dim receipt As New StringBuilder()
            ' ' Build receipt text using transacDoc values
            '  receipt.AppendLine("ATV RENTAL RECEIPT")
            '  receipt.AppendLine($"Customer: {tbxWaitCustName.Text}")
            ' receipt.AppendLine($"Trail Name: {tbxWaitTour.Text}")
            '  receipt.AppendLine($"Tour Guide: {cbxWaitTourGuide.SelectedItem.ToString}")
            '  receipt.AppendLine($"Total Person: {tbxWaitPerson.Text}")
            '  Dim pricePerHead As String = lblTourPrice.Text
            '  receipt.AppendLine($"Trail Price/Head: {pricePerHead}")
            '  Dim totPayment As String = tbxWaitTotPrice.Text
            '   receipt.AppendLine($"Total Paid: {totPayment}")
            '  Dim totChange As String = tbxAddChange.Text
            '  receipt.AppendLine($"Total Change: {totChange}")
            '  receipt.AppendLine($"Transaction Date: {DateTime.UtcNow.ToString("MMM. dd, yyyy hh:mm tt")}")
            '  ' Display the receipt
            '  MessageBox.Show(receipt.ToString(), "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optionally, you can also print the receipt using PrintDocument and PrintPreviewDialog
            ' Uncomment the following lines if you want to enable printing
            Dim printDocument As New PrintDocument()
            AddHandler printDocument.PrintPage, AddressOf generateWaitPrintReceipt
            Dim printPreviewDialog As New PrintPreviewDialog()
            printPreviewDialog.Document = printDocument
            printPreviewDialog.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred while generating the receipt: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Uncomment the following lines if you want to enable printing
    Private Sub generateWaitPrintReceipt(sender As Object, e As PrintPageEventArgs)
        Dim graphics As Graphics = e.Graphics
        Dim font As New Font("Courier New", 8)
        Dim yPos As Single = 10

        ' Use the graphics object to draw the receipt content
        graphics.DrawString("ATV RENTAL RECEIPT", font, Brushes.Black, 10, yPos)
        yPos += 15
        graphics.DrawString($"Transaction Date: {DateTime.UtcNow.ToString("MMM. dd, yyyy hh:mm tt")}", font, Brushes.Black, 10, yPos)
        yPos += 15
        graphics.DrawString($"Customer: {tbxWaitCustName.Text}", font, Brushes.Black, 10, yPos)
        yPos += 15
        graphics.DrawString($"Trail Name: {tbxWaitTour.Text}", font, Brushes.Black, 10, yPos)
        yPos += 15
        graphics.DrawString($"Tour Guide: {cbxWaitTourGuide.SelectedItem.ToString}", font, Brushes.Black, 10, yPos)
        yPos += 15
        graphics.DrawString($"Total Person: {tbxWaitPerson.Text}", font, Brushes.Black, 10, yPos)
        yPos += 15
        'Dim pricePerHead As String = lblTourPrice.Text
        'graphics.DrawString($"Trail Price/Head: {pricePerHead}", font, Brushes.Black, 10, yPos)
        'yPos += 15
        'Dim totPayment As String = tbxWaitTotPrice.Text
        'Dim totChange As String = tbxWaitChange.Text
        graphics.DrawString($"Downpayment: {tbxWaitInitPayment.Text}", font, Brushes.Black, 10, yPos)
        yPos += 15
        graphics.DrawString($"Balance: {tbxWaitBalance.Text}", font, Brushes.Black, 10, yPos)
        yPos += 15
        graphics.DrawString($"Total Paid: {tbxWaitFinPayment.Text}", font, Brushes.Black, 10, yPos)
        yPos += 15
        graphics.DrawString($"Change: {tbxWaitChange.Text}", font, Brushes.Black, 10, yPos)
        yPos += 15
    End Sub




    '!!!!!!!!!!! O N   G O I N G   T A B !!!!!!!!!!!!
    Private Sub btnOnGAtv_Click(sender As Object, e As EventArgs) Handles btnOnGViewAtv.Click
        If tranzac IsNot Nothing AndAlso dgvTransactions.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = dgvTransactions.SelectedRows(0).Index
            Dim selectedTransaction As trDoc = tranzac(selectedRowIndex)
            ' Pass the trID to the atvViewSelected form
            atvViewSelected.SetTransactionID(selectedTransaction.trID)
            'show form dialog with list of atvs used by selected row
            atvViewSelected.ShowDialog()
        End If
    End Sub
    Private Sub btnEndTrail_Click(sender As Object, e As EventArgs) Handles btnEndTrail.Click
        If dgvTransactions.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = dgvTransactions.SelectedRows(0).Index
            If selectedRowIndex < tranzac.Count AndAlso tranzac(selectedRowIndex).trStatus = "ongoing" Then
                Dim selectedTransac As trDoc = tranzac(selectedRowIndex)

                ' Update tour guide status to "available"
                Dim guideFilter = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(selectedTransac.trTGuideID))
                Dim guideUpdateDefinition = Builders(Of BsonDocument).Update.Set(Of String)("status", "available")
                rmsSharedVar.colTourGuide.UpdateOne(guideFilter, guideUpdateDefinition)

                ' Fetch selectedATV field using trID
                Dim trIDFilter = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(selectedTransac.trID))
                Dim selectedATVField = Builders(Of BsonDocument).Projection.Include("selectedATV")
                Dim selectedATVDoc = rmsSharedVar.colTransac.Find(trIDFilter).Project(selectedATVField).FirstOrDefault()

                If selectedATVDoc IsNot Nothing Then
                    Dim selectedATVArray As BsonArray = selectedATVDoc.GetValue("selectedATV", New BsonArray())

                    ' Update ATV statuses to "AVAILABLE"
                    For Each atv As BsonDocument In selectedATVArray
                        Dim atvId = atv("Id").AsObjectId
                        Dim atvFilter = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", atvId)
                        Dim atvUpdateDefinition = Builders(Of BsonDocument).Update.Set(Of String)("status", "AVAILABLE")
                        rmsSharedVar.colInventory.UpdateOne(atvFilter, atvUpdateDefinition)
                    Next
                End If

                Dim filter = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(selectedTransac.trID))
                Dim updateDefinition = Builders(Of BsonDocument).Update.Set(Of String)("status", "done").Set(Of String)("transacEnd", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                'update trail status=done
                'add trail end date sa transac doc
                rmsSharedVar.colTransac.UpdateOne(filter, updateDefinition)

                populateTransac()
                MessageBox.Show("Trail ended successfully!" & vbCrLf & vbCrLf & "ATVs and tour guide are now set as available.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Please select on-going transaction first.")
            End If
        End If
    End Sub
End Class