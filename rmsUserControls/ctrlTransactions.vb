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
        tbxAddInitPayment.Text = remBalance.ToString("N2")
        lblTourPrice.Text = tourPrice.ToString("N2")
        cbxAddTourGuide.SelectedIndex = -1
        cbxAddTimeSlot.SelectedIndex = -1
        transacCounter()
    End Sub
    Private Sub clearWaitList()
        tourPrice = 0.00
        numberOfPerson = 0
        totalPrice = 0.00
        initPayment = 0.00
        totChange = 0.00
        remBalance = 0.00
        finPayment = 0.00
        tbxWaitFName.Clear()
        tbxWaitMName.Clear()
        tbxWaitSname.Clear()
        tbxWaitTour.Clear()
        cbxWaitTourGuide.SelectedIndex = -1
        tbxWaitPerson.Clear()
        'cbxWaitStatus.SelectedIndex = -1
        tbxWaitTotPrice.Text = totalPrice.ToString("N2")
        tbxWaitBalance.Text = remBalance.ToString("N2")
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
        tbxWaitFName.Text = selTransac.trFname
        tbxWaitMName.Text = selTransac.trMname
        tbxWaitSname.Text = selTransac.trSname
        tbxWaitTour.Text = selTransac.trTourName
        tbxWaitPerson.Text = selTransac.trTotalPerson
        rmsSharedVar.atvTotNum = tbxWaitPerson.Text
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
        tbxOnGTour.KeyPress, tbxAddSname.KeyPress, tbxAddMName.KeyPress, tbxAddFName.KeyPress, tbxAddInitPayment.KeyPress,
        tbxWaitFName.KeyPress, tbxWaitPerson.KeyPress, tbxWaitTotPrice.KeyPress, tbxAddNewPayment.KeyPress, tbxAddChange.KeyPress
        'suppress enter key sound sa mga textboxes
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub tbxPerson(sender As Object, e As KeyPressEventArgs) Handles tbxAddNewPayment.KeyPress, tbxAddTotal.KeyPress, tbxAddChange.KeyPress,
        tbxAddInitPayment.KeyPress, tbxWaitTotPrice.KeyPress, tbxWaitPerson.KeyPress, tbxOnGTourPrice.KeyPress
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
                If initPayment < totalPrice Then 'display remaining balance
                    totChange = 0.00
                    remBalance = totalPrice - initPayment
                    tbxAddChange.Text = totChange.ToString("N2")
                    tbxAddInitPayment.Text = remBalance.ToString("N2")
                ElseIf initPayment = totalPrice Then 'reset value ng balance&change pag eksakto binayad
                    totChange = 0.00
                    remBalance = 0.00
                    tbxAddChange.Text = totChange.ToString("N2")
                    tbxAddInitPayment.Text = remBalance.ToString("N2")
                Else 'display sukli kapag sobra binayad
                    totChange = initPayment - totalPrice
                    remBalance = 0.00
                    tbxAddChange.Text = totChange.ToString("N2")
                    tbxAddInitPayment.Text = remBalance.ToString("N2")
                End If
            Else
                remBalance = 0.00
                totChange = 0.00
                tbxAddChange.Text = totChange.ToString("N2")
                tbxAddInitPayment.Text = remBalance.ToString("N2")
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
                        '
                        '
                        '
                        '
                        '            
                        'add code dito para magprint ng invoice
                        '
                        '
                        '
                        MessageBox.Show("New transaction added successfully!")
                        'add code to reset atv array saka tourguide pagtapos ng transaction
                        clearAddTransacTab()
                        populateTransac()
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
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

    Private Sub btnStartTrail_Click(sender As Object, e As EventArgs) Handles btnStartTrail.Click
        'add start time
        'update doc; dagdag tguide, atv array sa docu, set stat:not available
        'status=ongoing
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

                ' Update ATV status to "AVAILABLE"
                Dim atvUpdateDefinition = Builders(Of BsonDocument).Update.Set(Of String)("status", "AVAILABLE")
                If selectedTransac.trATV IsNot Nothing AndAlso TypeOf selectedTransac.trATV Is List(Of BsonDocument) Then
                    For Each atv As BsonDocument In CType(selectedTransac.trATV, List(Of BsonDocument))
                        Dim atvId As String = atv("_id").AsObjectId.ToString
                        Dim atvFilter = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(atvId))
                        rmsSharedVar.colInventory.UpdateOne(atvFilter, atvUpdateDefinition)
                    Next

                End If

                ' Update tour guide status to "available"
                Dim guideFilter = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(selectedTransac.trTGuideID))
                Dim guideUpdateDefinition = Builders(Of BsonDocument).Update.Set(Of String)("status", "available")
                rmsSharedVar.colTourGuide.UpdateOne(guideFilter, guideUpdateDefinition)

                Dim filter = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(selectedTransac.trID))
                Dim updateDefinition = Builders(Of BsonDocument).Update.Set(Of String)("status", "done").Set(Of String)("transacEnd", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                'update trail status=done
                'add trail end date sa transac doc
                rmsSharedVar.colTransac.UpdateOne(filter, updateDefinition)

                populateTransac()
                MessageBox.Show("Trail ended successfully!" & vbCrLf & vbCrLf & "ATVs and tour guide are now set as available.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Please select on-going transaction first.")
            End If
        End If
    End Sub
End Class