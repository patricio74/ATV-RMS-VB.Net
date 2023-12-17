Imports MongoDB.Bson
Imports MongoDB.Driver
Imports System.IO
Public Class ctrlTourGuides
    Private tGuidez As List(Of empDoc)
    Public Class empDoc
        Public Property empID As String
        Public Property empFname As String '
        Public Property empMname As String
        Public Property empSname As String
        Public Property empEmail As String
        Public Property empPhone As String
        Public Property empAddress As String
        Public Property empRFID As String
        Public Property empStatus As String
        Public Property empCreationDate As String
    End Class
    Private Sub clearUpdEmpTab()
        tbxUpdEmpFname.Clear()
        tbxUpdEmpMname.Clear()
        tbxUpdEmpSname.Clear()
        tbxUpdEmpPhone.Clear()
        tbxUpdEmpEmail.Clear()
        tbxUpdEmpAddress.Clear()
        cbxStatus.SelectedIndex = -1
        lblUpdEmpDate.Text = "Account creation date: ---------"
        populateEmpDGV()
        dgvTourGuide.ClearSelection()
    End Sub
    Private Sub clearAddEmpTab()
        tbxAddEmpFname.Clear()
        tbxAddEmpMname.Clear()
        tbxAddEmpSname.Clear()
        tbxAddEmpPhone.Clear()
        tbxAddEmpEmail.Clear()
        tbxAddEmpAddress.Clear()
        cbxAddEmpStatus.SelectedIndex = -1
        populateEmpDGV()
        dgvTourGuide.ClearSelection()
    End Sub
    Private Sub tbxContNum_TextChanged(sender As Object, e As KeyPressEventArgs) Handles tbxUpdEmpPhone.KeyPress, tbxAddEmpPhone.KeyPress
        'check if the inputted char is a number,backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxUpdEmpFname.KeyPress, tbxUpdEmpMname.KeyPress, tbxUpdEmpSname.KeyPress, tbxUpdEmpPhone.KeyPress, tbxUpdEmpEmail.KeyPress, tbxAddEmpFname.KeyPress, tbxAddEmpMname.KeyPress, tbxAddEmpSname.KeyPress, tbxAddEmpPhone.KeyPress, tbxAddEmpEmail.KeyPress, tbxUpdEmpAddress.KeyPress, tbxAddEmpAddress.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    'Public Sub resetFilter()
    'tbxSearchFir.Clear()
    'tbxSearchSur.Clear()
    'tbxSearchPhone.Clear()
    'tbxSearchEmail.Clear()
    'tbxSearchRFID.Clear()
    ' cbxSearchFilter.SelectedIndex = 0
    'End Sub
    ' Private Sub cbxSearchFilter_SelectedIndexChanged(sender As Object, e As EventArgs)
    ' If cbxSearchFilter.SelectedIndex = 0 Then 'search using rfid
    '     tbxSearchRFID.Visible = True
    '     tbxSearchFir.Visible = False
    '     tbxSearchSur.Visible = False
    '     tbxSearchEmail.Visible = False
    '     tbxSearchPhone.Visible = False
    ' ElseIf cbxSearchFilter.SelectedIndex = 1 Then 'search emp name
    '     tbxSearchRFID.Visible = False
    '     tbxSearchFir.Visible = True
    '      tbxSearchSur.Visible = True
    '      tbxSearchEmail.Visible = False
    '     tbxSearchPhone.Visible = False
    ' ElseIf cbxSearchFilter.SelectedIndex = 2 Then 'search phone
    '     tbxSearchRFID.Visible = False
    '    tbxSearchFir.Visible = False
    '    tbxSearchSur.Visible = False
    '    tbxSearchEmail.Visible = False
    '     tbxSearchPhone.Visible = True
    ' ElseIf cbxSearchFilter.SelectedIndex = 3 Then 'search email
    '    tbxSearchRFID.Visible = False
    '    tbxSearchFir.Visible = False
    '    tbxSearchSur.Visible = False
    '    tbxSearchEmail.Visible = True
    '    tbxSearchPhone.Visible = False
    ' Else 'default
    '    tbxSearchRFID.Visible = True
    '    tbxSearchFir.Visible = False
    '    tbxSearchSur.Visible = False
    '    tbxSearchEmail.Visible = False
    '    tbxSearchPhone.Visible = False
    '  End If
    'End Sub
    'Private Sub btnClearFilter_Click(sender As Object, e As EventArgs)
    '    clearUpdEmpTab()
    '    resetFilter()
    '    populateEmpDGV()
    'End Sub
    'Private Sub btnSearch_Click(sender As Object, e As EventArgs)
    '
    '
    '
    'may mali pa sa search, ayaw magsearch ng email, phone, name
    'search sa name dagdag ka code para pwede magsearch kahit yung surname/fname lang isearch
    'search col where fname&sname contain tbxfnma.text&sname.text
    '
    '
    '
    'End Sub
    'Private Sub populateFilteredList(tGuidez As List(Of empDoc))
    '    dgvTourGuide.Rows.Clear()
    '    For Each tg As empDoc In tGuidez
    '        Dim row As New DataGridViewRow()
    '        row.CreateCells(dgvTourGuide, tg.empRFID, tg.empFname, tg.empMname, tg.empSname, tg.empPhone, tg.empEmail)
    '        dgvTourGuide.Rows.Add(row)
    '    Next
    '    dgvTourGuide.ClearSelection()
    '    clearUpdEmpTab()
    'End Sub
    Private Sub populateEmpDGV()
        If rmsDashboard.switchTgui = True Then
            dgvTourGuide.Rows.Clear()
            Dim empDocList As List(Of BsonDocument) = rmsSharedVar.colTourGuide.Find(New BsonDocument()).ToList()
            tGuidez = New List(Of empDoc)()
            For Each document As BsonDocument In empDocList
                Dim idElement = document.GetElement("_id")
                Dim emplist As New empDoc() With {
                    .empID = idElement.Value.AsObjectId.ToString,
                    .empFname = document("FName").ToString,
                    .empMname = document("MName").ToString,
                    .empSname = document("Sname").ToString,
                    .empPhone = document("phone").ToString,
                    .empEmail = document("email").ToString,
                    .empAddress = document("address").ToString,
                    .empStatus = document("status").ToString,
                    .empCreationDate = document("accountCreationDate").ToString
                }
                tGuidez.Add(emplist)
            Next
            dgvTourGuide.Rows.Clear()
            For Each doc In tGuidez
                Dim guideName As String = $"{doc.empFname} {doc.empMname} {doc.empSname}".Trim()
                dgvTourGuide.Rows.Add(guideName, doc.empPhone, doc.empAddress, doc.empEmail, doc.empStatus)
            Next
            dgvTourGuide.ClearSelection()
        End If
    End Sub
    Private Sub dgvTourGuide_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTourGuide.CellClick
        If e.RowIndex >= 0 Then
            tabTourGuide.SelectedIndex = 0 'update trails tab
            If tGuidez IsNot Nothing AndAlso e.RowIndex < tGuidez.Count Then
                Dim selectedEmp = tGuidez(e.RowIndex)
                tbxUpdEmpFname.Text = selectedEmp.empFname
                tbxUpdEmpMname.Text = selectedEmp.empMname
                tbxUpdEmpSname.Text = selectedEmp.empSname
                tbxUpdEmpPhone.Text = selectedEmp.empPhone
                tbxUpdEmpEmail.Text = selectedEmp.empEmail
                tbxUpdEmpAddress.Text = selectedEmp.empAddress
                cbxStatus.Text = selectedEmp.empStatus
                lblUpdEmpDate.Text = "Account creation date: " + selectedEmp.empCreationDate
            End If
        End If
    End Sub
    Private Sub tabTourGuide_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabTourGuide.SelectedIndexChanged
        If tabTourGuide.SelectedIndex = 0 Then 'update emp tab

        ElseIf tabTourGuide.SelectedIndex = 1 Then 'add new emp tab
            clearUpdEmpTab()
            tbxAddEmpFname.Focus()
        End If
    End Sub
    Private Sub btnUpd_Click(sender As Object, e As EventArgs) Handles btnUpdEmp.Click, btnDelEmp.Click, btnUpdDownloadResume.Click,
            btnAddEmp.Click, btnClearForm.Click
        If sender Is btnUpdEmp Then
            If dgvTourGuide.SelectedRows.Count > 0 Then
                Dim selectedRow = dgvTourGuide.SelectedRows(0)
                Dim selectedEmp = tGuidez(selectedRow.Index)
                Dim empID As String = selectedEmp.empID
                If String.IsNullOrEmpty(tbxUpdEmpFname.Text) OrElse String.IsNullOrEmpty(tbxUpdEmpSname.Text) OrElse String.IsNullOrEmpty(tbxUpdEmpPhone.Text) OrElse String.IsNullOrEmpty(tbxUpdEmpEmail.Text) OrElse String.IsNullOrEmpty(tbxUpdEmpAddress.Text) Then
                    MessageBox.Show("Please fill in all fields to continue.")
                Else
                    Dim updConfirmation As DialogResult = MessageBox.Show("Do you want to update this info?", "Confirmation", MessageBoxButtons.YesNo)
                    If updConfirmation = DialogResult.Yes Then
                        Try
                            Dim objectId As ObjectId
                            If ObjectId.TryParse(empID, objectId) Then
                                Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objectId)
                                Dim update = Builders(Of BsonDocument).Update.Set(Of String)("FName", tbxUpdEmpFname.Text).
                                Set(Of String)("MName", tbxUpdEmpMname.Text).
                                Set(Of String)("Sname", tbxUpdEmpSname.Text).
                                Set(Of String)("phone", tbxUpdEmpPhone.Text).
                                Set(Of String)("email", tbxUpdEmpEmail.Text).
                                Set(Of String)("address", tbxUpdEmpAddress.Text).
                                Set(Of String)("status", cbxStatus.Text)
                                rmsSharedVar.colTourGuide.UpdateOne(filter, update)
                                MessageBox.Show("Tour guide information updated successfully.")
                                populateEmpDGV()
                                clearUpdEmpTab()
                            End If
                        Catch ex As Exception
                            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                End If
            Else
                MessageBox.Show("Please select a Tour Guide to update.")
                populateEmpDGV()
            End If

        ElseIf sender Is btnDelEmp Then
            If dgvTourGuide.SelectedRows.Count > 0 Then
                Dim selectedEmp = tGuidez(dgvTourGuide.SelectedRows(0).Index)
                Dim tgID As String = selectedEmp.empID
                Dim delConfirmation = MessageBox.Show("Are you sure you want to remove this Tour Guide?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                'move selected tour guide doc to archive collection
                If delConfirmation = DialogResult.Yes Then
                    moveToArchive(tgID)
                ElseIf delConfirmation = DialogResult.No Then
                    populateEmpDGV()
                End If
            Else
                MessageBox.Show("Please select Tour Guide to delete.")
                populateEmpDGV()
            End If

        ElseIf sender Is btnUpdDownloadResume Then
            'download resume file
            If dgvTourGuide.SelectedRows.Count > 0 Then
                Dim selectedEmp = tGuidez(dgvTourGuide.SelectedRows(0).Index)
                Dim tgID As String = selectedEmp.empID
                Dim filter = Builders(Of BsonDocument).Filter.Eq(Of Object)("_id", ObjectId.Parse(tgID))
                Dim document As BsonDocument = rmsSharedVar.colTourGuide.Find(filter).FirstOrDefault()

                If document IsNot Nothing Then
                    ' Check if resume is not empty
                    If document.Contains("resume") AndAlso document("resume").AsByteArray IsNot Nothing AndAlso document("resume").AsByteArray.Length > 0 Then
                        Dim downloadConfirmation As DialogResult = MessageBox.Show("Do you want to download the resume?", "Confirmation", MessageBoxButtons.YesNo)
                        If downloadConfirmation = DialogResult.Yes Then
                            'save as resume_Surname_FName+pdf extension
                            Dim fileName As String = "resume_" + document("Sname").AsString + "_" + document("FName").AsString + ".pdf"
                            'choose download loc
                            Dim saveFileDialog As New SaveFileDialog()
                            saveFileDialog.FileName = fileName
                            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
                            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                                Dim resumeContent As Byte() = document("resume").AsByteArray
                                File.WriteAllBytes(saveFileDialog.FileName, resumeContent)
                                MessageBox.Show($"Resume downloaded to: {saveFileDialog.FileName}")
                            Else
                                MessageBox.Show("Download canceled by the user.")
                            End If
                        End If
                    Else
                        MessageBox.Show($"No resume file found for {document("Sname").AsString} {document("FName").AsString} in the database!")
                    End If
                Else
                    MessageBox.Show("No tour guide document found in the database!")
                End If
            End If

        ElseIf sender Is btnAddEmp Then
            If String.IsNullOrEmpty(tbxAddEmpFname.Text) OrElse String.IsNullOrEmpty(tbxAddEmpSname.Text) OrElse String.IsNullOrEmpty(tbxAddEmpAddress.Text) OrElse String.IsNullOrEmpty(tbxAddEmpPhone.Text) OrElse String.IsNullOrEmpty(tbxAddEmpEmail.Text) OrElse cbxAddEmpStatus.SelectedIndex = -1 Then
                MessageBox.Show("Please fill in all fields to continue.")
            Else
                Dim addConfirmation As DialogResult = MessageBox.Show("Do you want to save this new tour guide?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If addConfirmation = DialogResult.Yes Then
                    Try
                        ' Create an empty byte array for a blank resume field
                        Dim blankResume As Byte() = New Byte() {}

                        Dim newEmpDoc As New BsonDocument From {
                        {"FName", tbxAddEmpFname.Text},
                        {"MName", tbxAddEmpMname.Text},
                        {"Sname", tbxAddEmpSname.Text},
                        {"phone", tbxAddEmpPhone.Text},
                        {"email", tbxAddEmpEmail.Text},
                        {"address", tbxAddEmpAddress.Text},
                        {"status", cbxAddEmpStatus.Text},
                        {"resume", blankResume},
                        {"accountCreationDate", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ")}
                    }
                        rmsSharedVar.colTourGuide.InsertOne(newEmpDoc)
                        MessageBox.Show("New tour guide added successfully.")
                        populateEmpDGV()
                        clearAddEmpTab()
                    Catch ex As Exception
                        MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                ElseIf addConfirmation = DialogResult.No Then
                    populateEmpDGV()
                End If
            End If
        ElseIf sender Is btnClearForm Then
            clearUpdEmpTab()
            clearAddEmpTab()
        End If
    End Sub
    Private Sub moveToArchive(tgID As String)
        Try
            Dim objectId As ObjectId
            If ObjectId.TryParse(tgID, objectId) Then
                Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objectId)
                Dim document = rmsSharedVar.colTourGuide.Find(filter).FirstOrDefault()
                If document IsNot Nothing Then
                    'Add date to accountDeletionDate bago iarchive
                    document.Add("accountDeletionDate", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                    rmsSharedVar.archiveTourGuide.InsertOne(document)
                    rmsSharedVar.colTourGuide.DeleteOne(filter)
                    MessageBox.Show("Tour guide deleted successfully.")
                    populateEmpDGV()
                    clearUpdEmpTab()
                Else
                    MessageBox.Show("Tour guide not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    populateEmpDGV()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            populateEmpDGV()
        End Try
    End Sub
    Private Sub ctrlTourGuides_Load(sender As Object, e As EventArgs) Handles Me.Load
        'disable dgv sorting on column header clikc
        For Each column As DataGridViewColumn In dgvTourGuide.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        'resetFilter()
        populateEmpDGV()
    End Sub
    Private Sub ctrlTourGuides_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            'closeMongoConn()
            'resetFilter()
            clearAddEmpTab()
            clearUpdEmpTab()
            tabTourGuide.SelectedIndex = 0
            'clear form
        ElseIf Me.Visible = True Then
            populateEmpDGV()
        End If
    End Sub
End Class