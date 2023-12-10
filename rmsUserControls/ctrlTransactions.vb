Imports ATV_RMS.selectATV
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ctrlTransactions
    'para macompute total price
    Dim tourPrice As Double = 0.00
    Dim numberOfPerson As Integer = 0
    Dim totalPrice As Double = 0.00
    'compute change,balance
    Dim initPayment As Double = 0.00
    Dim totChange As Double = 0.00
    Dim remBalance As Double = 0.00
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
        'dateTimeNew.Value = DateTime.Now
        cbxAddTour.SelectedIndex = -1
        cbxAddPerson.SelectedIndex = -1
        tbxAddTotal.Text = "0.00"
        tbxAddInitPayment.Clear()
        tbxAddChange.Text = totChange.ToString("N2")
        tbxAddBalance.Text = remBalance.ToString("N2")
        cbxAddTourGuide.SelectedIndex = -1
        cbxAddTimeSlot.SelectedIndex = -1
    End Sub
    Private Sub clearWaitList()
        tourPrice = 0.00
        numberOfPerson = 0
        totalPrice = 0.00
        initPayment = 0.00
        totChange = 0.00
        remBalance = 0.00
        tbxWaitFName.Clear()
        tbxWaitPerson.Clear()
        tbxWaitTotPrice.Clear()
        tbxWaitTour.Clear()
        cbxWaitStatus.SelectedIndex = -1
        cbxWaitTourGuide.SelectedIndex = -1
    End Sub
    Private Sub clearOngoingTab()
        tourPrice = 0.00
        numberOfPerson = 0
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
    Private Sub ctrlTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadTrailList()
        reloadTGuideList()
        populateTransac()
    End Sub
    Private Sub ctrlTransactions_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            reloadTrailList()
            reloadTGuideList()
            populateTransac()
        ElseIf Me.Visible = False Then
            'closeMongoConn()
            clearAddTransacTab()
            clearWaitList()
            clearOngoingTab()
            reloadTrailList()
            reloadTGuideList()
            tabTransactions.SelectedIndex = 0
            tranzac = Nothing
        End If
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


    '!!!!!!!!!!! ADD TRANSAC TAB!!!!!!!!!!!!
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
                                tbxAddTotal.Text = "0.00"
                                numberOfPerson = 0
                            End If
                        Else
                            tbxAddTotal.Text = "0.00"
                            numberOfPerson = 0
                        End If
                    End If
                Else
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
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("status", "available")
            Dim projection = Builders(Of BsonDocument).Projection.Include("FName").Include("MName").Include("Sname")
            Dim cursor = rmsSharedVar.colTourGuide.Find(filter).Project(projection).ToCursor()
            While cursor.MoveNext()
                For Each document In cursor.Current
                    Dim fullName As String = $"{document("FName").AsString} {document("MName").AsString} {document("Sname").AsString}"
                    'add tour ugide names to cboxes
                    cbxAddTourGuide.Items.Add(fullName)
                    cbxWaitTourGuide.Items.Add(fullName)
                Next
            End While
        Catch ex As Exception
            ' Handle exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabTransactions.SelectedIndexChanged
        If tabTransactions.SelectedIndex = 0 Then 'walk-in transac tab
            reloadTrailList()
            reloadTGuideList()
            transacCounter()
            populateTransac()
            clearWaitList()
            clearOngoingTab()
        ElseIf tabTransactions.SelectedIndex = 1 Then 'waiting list tab
            reloadTrailList()
            reloadTGuideList()
            transacCounter()
        ElseIf tabTransactions.SelectedIndex = 2 Then 'ongoing tab
            reloadTrailList()
            reloadTGuideList()
            transacCounter()
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
                    tbxAddChange.Text = totChange.ToString("N2")
                    tbxAddBalance.Text = remBalance.ToString("N2")
                ElseIf initPayment = totalPrice Then 'reset value ng balance&change pag eksakto binayad
                    totChange = 0.00
                    remBalance = 0.00
                    tbxAddChange.Text = totChange.ToString("N2")
                    tbxAddBalance.Text = remBalance.ToString("N2")
                Else 'display sukli kapag sobra binayad
                    totChange = initPayment - totalPrice
                    remBalance = 0.00
                    tbxAddChange.Text = totChange.ToString("N2")
                    tbxAddBalance.Text = remBalance.ToString("N2")
                End If
            Else
                remBalance = 0.00
                totChange = 0.00
                tbxAddChange.Text = totChange.ToString("N2")
                tbxAddBalance.Text = remBalance.ToString("N2")
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
            selectATV.ShowDialog()
        Else
            numberOfPerson = 0
            rmsSharedVar.atvTotNum = numberOfPerson
        End If
    End Sub
    Private Sub btnAddConfirm_Click(sender As Object, e As EventArgs) Handles btnAddConfirm.Click
        If String.IsNullOrEmpty(tbxAddFName.Text) OrElse String.IsNullOrEmpty(tbxAddMName.Text) OrElse String.IsNullOrEmpty(tbxAddSname.Text) OrElse String.IsNullOrEmpty(tbxAddInitPayment.Text) OrElse cbxAddTimeSlot.SelectedIndex <= -1 OrElse cbxAddPerson.SelectedIndex <= -1 OrElse cbxAddTour.SelectedIndex <= -1 OrElse cbxAddTourGuide.SelectedIndex <= -1 OrElse rmsSharedVar.selectedATVs Is Nothing OrElse rmsSharedVar.selectedATVs.Count = 0 Then
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
                    Next
                    Dim newTransacDoc As New BsonDocument From {
                        {"FName", tbxAddFName.Text},
                        {"MName", tbxAddMName.Text},
                        {"Sname", tbxAddSname.Text},
                        {"totalPerson", cbxAddPerson.SelectedItem.ToString},
                        {"timeSlot", cbxAddTimeSlot.SelectedItem.ToString},
                        {"selectedATV", atvArray},
                        {"tourName", cbxAddTour.SelectedItem.ToString},
                        {"tourPrice", lblTourPrice.Text},
                        {"InitialPayment", tbxAddInitPayment.Text},
                        {"TotalPayment", tbxAddTotal.Text},
                        {"Balance", tbxAddBalance.Text.ToString},
                        {"change", tbxAddChange.Text},
                        {"status", "ongoing"},
                        {"customer", ""},
                        {"tourGuide", cbxAddTourGuide.SelectedItem.ToString},
                        {"reservDate", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ")},
                        {"transacStart", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ")}
                    }
                    ' {"guideID", cbxAddTourGuide.SelectedItem.ToString},
                    rmsSharedVar.colTransac.InsertOne(newTransacDoc)
                    ' Generate the receipt string
                    Dim receiptString As String = GenerateReceiptString(newTransacDoc)
                    ' Send the receipt string to the receipt printer (replace this with your actual code to print)
                    PrintReceipt(receiptString)

                    MessageBox.Show("New transaction added successfully!")
                    clearAddTransacTab()
                    populateTransac()
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            '
            '
            'update selected atvs, tourguide status to not available
            'print invoice
            '
            '
            '
            '
        End If
    End Sub
    Private Function GenerateReceiptString(transaction As BsonDocument) As String
        ' Create a formatted string based on the transaction data
        ' Modify this according to your receipt format
        Dim receiptString As String = $"ATV-RMS Transaction Invoice" & vbCrLf & vbCrLf &
                                 $"Customer: {transaction("FName")} {transaction("MName")} {transaction("Sname")}" & vbCrLf &
                                 $"Total Persons: {transaction("totalPerson")}" & vbCrLf &
                                 $"Time Slot: {transaction("timeSlot")}" & vbCrLf &
                                 $"Tour Name: {transaction("tourName")}" & vbCrLf &
                                 $"Tour Guide: {transaction("tourGuide")}" & vbCrLf &
                                 $"Tour Price: {transaction("tourPrice")}" & vbCrLf &
                                 $"Initial Payment: {transaction("InitialPayment")}" & vbCrLf &
                                 $"Total Payment: {transaction("TotalPayment")}" & vbCrLf &
                                 $"Balance: {transaction("Balance")}" & vbCrLf &
                                 $"Change: {transaction("change")}" & vbCrLf &
                                 $"Transaction Start: {transaction("transacStart")}" & vbCrLf &
                                 $"Status: {transaction("status")}"
        Return receiptString
    End Function
    Private Sub PrintReceipt(receiptString As String)
        ' Implement the logic to print the receipt string on your receipt printer
        ' Replace this with your actual code to send the receipt to the printer
        Console.WriteLine(receiptString)
        ' Your printing logic here...
    End Sub
    Private tranzac As List(Of trDoc)
    'add other fieldzzzzzzz
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
                .trTotalPrice = document("TotalPayment").ToString,
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
        tbxWaitMName.Text = selTransac.trMname
        tbxWaitSname.Text = selTransac.trSname
        'add other textboxes
        'here!!!!!!
        '!!!!!!!!!!
        '
        '
        '
        '
    End Sub
    Private Sub popuOngoingTab(selTransac As trDoc)
        tbxOnGName.Text = selTransac.trFname
        tbxOnGPerson.Text = selTransac.trTotalPerson
        '
        '
        '
        '
        '
    End Sub













    '!!!!!!! WAITING TAB !!!!
    Dim numberOfWaitPerson As Integer
    'select atv only if numberOfPerson >0
    Private Sub btnWaitAtv_Click(sender As Object, e As EventArgs) Handles btnWaitAtv.Click
        If Not String.IsNullOrEmpty(tbxWaitPerson.Text) Then
            numberOfWaitPerson = tbxWaitPerson.Text
            rmsSharedVar.atvWaitTotNum = numberOfWaitPerson
            selectATV.ShowDialog()
        Else
            numberOfWaitPerson = 0
            rmsSharedVar.atvWaitTotNum = numberOfWaitPerson
        End If
    End Sub
    Private Sub btnStartTrail_Click(sender As Object, e As EventArgs) Handles btnStartTrail.Click
        'add time
        'update doc
    End Sub

    Private Sub btnEndTrail_Click(sender As Object, e As EventArgs) Handles btnEndTrail.Click
        'add trail end date
        'update total
    End Sub

    Private Sub btnOnGAtv_Click(sender As Object, e As EventArgs) Handles btnOnGAtv.Click
        'show form dialog with list of atvs in use
    End Sub
End Class