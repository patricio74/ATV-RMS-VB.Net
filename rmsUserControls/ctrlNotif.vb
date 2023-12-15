Imports System.IO
Imports MongoDB.Bson
Imports MongoDB.Driver
Imports MongoDB.Libmongocrypt
Public Class ctrlNotif
    Private pendingTGuide As List(Of tgDoc)
    Private pendingAdmin As List(Of admDoc)
    Public Class tgDoc
        Public Property tgID As String
        Public Property tgFname As String '
        Public Property tgMname As String
        Public Property tgSname As String
        Public Property tgPhone As String
        Public Property tgEmail As String
        Public Property tgAddress As String
        Public Property tgResume As BsonBinaryData
        Public Property tgSubmissionDate As String
    End Class
    Public Class admDoc
        Public Property admpID As String
        Public Property admpFname As String
        Public Property admpMname As String
        Public Property admpSname As String
        Public Property admpEmail As String
        Public Property admpPhone As String
        Public Property admpRFID As String
        Public Property admpUsername As String
        Public Property admpPassword As String
        Public Property admpRole As String
        Public Property admpCreationDate As String
    End Class
    Private Sub clearApplicantForm()
        tbxApplicantName.Clear()
        tbxApplicantAddress.Clear()
        tbxApplicantEmail.Clear()
        tbxApplicantPhone.Clear()
    End Sub
    Private Sub clearAdmin()
        tbxAdminName.Clear()
        tbxAdminEmail.Clear()
        tbxAdminPhone.Clear()
        tbxAdminRFID.Clear()
    End Sub
    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxApplicantName.KeyPress, tbxApplicantAddress.KeyPress, tbxApplicantEmail.KeyPress,
            tbxAdminName.KeyPress, tbxAdminEmail.KeyPress, tbxAdminPhone.KeyPress, tbxAdminRFID.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub populateApplicantDGV()
        If rmsDashboard.switchPendi = True Then
            dgvPendingTourGuides.Rows.Clear()
            Dim tgDocList As List(Of BsonDocument) = rmsSharedVar.colResume.Find(New BsonDocument()).ToList()
            pendingTGuide = New List(Of tgDoc)()
            For Each document As BsonDocument In tgDocList
                Dim idElement = document.GetElement("_id")
                Dim tg As New tgDoc() With {
                .tgID = idElement.Value.AsObjectId.ToString,
                .tgFname = document("FName").ToString,
                .tgMname = document("MName").ToString,
                .tgSname = document("Sname").ToString,
                .tgPhone = document("phone").ToString,
                .tgEmail = document("email").ToString,
                .tgAddress = document("address").ToString,
                .tgResume = document("resume").AsBsonBinaryData,
                .tgSubmissionDate = document("submissionDate").ToString
                }
                pendingTGuide.Add(tg)
            Next
            dgvPendingTourGuides.Rows.Clear()
            For Each doc In pendingTGuide
                Dim applicant As String = $"{doc.tgFname} {doc.tgMname} {doc.tgSname}".Trim()
                dgvPendingTourGuides.Rows.Add(applicant, doc.tgPhone, doc.tgEmail)
            Next
            dgvPendingTourGuides.ClearSelection()
        End If
    End Sub
    Private Sub dgvPendingTourGuides_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPendingTourGuides.CellClick
        If e.RowIndex >= 0 Then
            If pendingTGuide IsNot Nothing AndAlso e.RowIndex < pendingTGuide.Count Then
                Dim selectedTG = pendingTGuide(e.RowIndex)
                Dim applicantName As String = $"{selectedTG.tgFname} {selectedTG.tgMname} {selectedTG.tgSname}".Trim()
                tbxApplicantName.Text = applicantName
                tbxApplicantAddress.Text = selectedTG.tgAddress
                tbxApplicantEmail.Text = selectedTG.tgEmail
                tbxApplicantPhone.Text = selectedTG.tgPhone
            End If
        End If
    End Sub
    Private Sub populatePendingAdminDGV()
        If rmsDashboard.switchPendi = True Then
            dgvPendingAdminAcc.Rows.Clear()
            Dim admDocList As List(Of BsonDocument) = rmsSharedVar.colPendingAdmin.Find(New BsonDocument()).ToList()
            pendingAdmin = New List(Of admDoc)()
            For Each document As BsonDocument In admDocList
                Dim idElement = document.GetElement("_id")
                Dim admp As New admDoc() With {
                .admpID = idElement.Value.AsObjectId.ToString,
                .admpFname = document("FName").ToString,
                .admpMname = document("MName").ToString,
                .admpSname = document("Sname").ToString,
                .admpPhone = document("phone").ToString,
                .admpEmail = document("email").ToString,
                .admpUsername = document("username").ToString,
                .admpPassword = document("password"),
                .admpRFID = document("RFID").ToString,
                .admpCreationDate = document("accountCreationDate").ToString,
                .admpRole = document("role").ToString
                }
                pendingAdmin.Add(admp)
            Next
            dgvPendingAdminAcc.Rows.Clear()
            For Each doc In pendingAdmin
                Dim admin As String = $"{doc.admpFname} {doc.admpMname} {doc.admpSname}".Trim()
                dgvPendingAdminAcc.Rows.Add(admin, doc.admpEmail)
            Next
            dgvPendingAdminAcc.ClearSelection()
        End If
    End Sub
    Private Sub dgvPendingAdminAcc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPendingAdminAcc.CellClick
        If e.RowIndex >= 0 Then
            If pendingAdmin IsNot Nothing AndAlso e.RowIndex < pendingAdmin.Count Then
                Dim selectedAdmnp = pendingAdmin(e.RowIndex)
                Dim applicantName As String = $"{selectedAdmnp.admpFname} {selectedAdmnp.admpMname} {selectedAdmnp.admpSname}".Trim()
                tbxAdminName.Text = applicantName
                tbxAdminEmail.Text = selectedAdmnp.admpEmail
                tbxAdminPhone.Text = selectedAdmnp.admpPhone
                tbxAdminRFID.Text = selectedAdmnp.admpRFID
            End If
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClearApplicant.Click, btnClearAdmin.Click
        If sender Is btnClearApplicant Then
            clearApplicantForm()
            populateApplicantDGV()
        ElseIf sender Is btnClearAdmin Then
            clearAdmin()
            populatePendingAdminDGV()
        End If
    End Sub
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnDownloadResume.Click, btnAcceptApplicant.Click, btnApproveAdmin.Click
        If sender Is btnDownloadResume Then
            If dgvPendingTourGuides.SelectedRows.Count > 0 Then
                Dim selectedGuide = pendingTGuide(dgvPendingTourGuides.SelectedRows(0).Index)
                Dim selID As String = selectedGuide.tgID
                Dim filter = Builders(Of BsonDocument).Filter.Eq(Of Object)("_id", ObjectId.Parse(selID))
                Dim document As BsonDocument = rmsSharedVar.colResume.Find(filter).FirstOrDefault()

                If document IsNot Nothing Then
                    ' Check if resume is not empty
                    If document.Contains("resume") AndAlso document("resume").AsByteArray IsNot Nothing AndAlso document("resume").AsByteArray.Length > 0 Then
                        Dim downloadConfirmation As DialogResult = MessageBox.Show("Do you want to download the resume?", "Confirmation", MessageBoxButtons.YesNo)
                        If downloadConfirmation = DialogResult.Yes Then
                            'alt code para direkta save sa desktop
                            'Dim savePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), fileName)

                            'save as resume_Surname_FName+pdf file extension
                            Dim fileName As String = "resume_" + document("Sname").AsString + "_" + document("FName").AsString + ".pdf"

                            'choose download loc
                            Dim saveFileDialog As New SaveFileDialog()
                            saveFileDialog.FileName = fileName
                            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"

                            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                                ' Download the resume file
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
                    MessageBox.Show("No resume document found in the database!")
                End If
            End If

        ElseIf sender Is btnAcceptApplicant Then
            'moveDocToTouGuideCollection
            If dgvPendingTourGuides.SelectedRows.Count > 0 Then
                Dim selectedGuide = pendingTGuide(dgvPendingTourGuides.SelectedRows(0).Index)
                Dim guideID As String = selectedGuide.tgID
                Dim empConfirmation = MessageBox.Show("Are you sure you want to accept this applicant?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                'move selected applicant doc to tour guide collection
                If empConfirmation = DialogResult.Yes Then
                    moveToTourGuideCol(guideID)
                ElseIf empConfirmation = DialogResult.No Then
                    populateApplicantDGV()
                End If
            Else
                MessageBox.Show("Please select an applicant first.")
                populateApplicantDGV()
            End If

        ElseIf sender Is btnApproveAdmin Then
            If dgvPendingAdminAcc.SelectedRows.Count > 0 Then
                Dim selectedEmp = pendingAdmin(dgvPendingAdminAcc.SelectedRows(0).Index)
                Dim pendingID As String = selectedEmp.admpID
                Dim admConfirmation = MessageBox.Show("Are you sure you want to accept this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                'move selected admin acc to rmsAdmin collection
                If admConfirmation = DialogResult.Yes Then
                    moveToAdminCol(pendingID)
                ElseIf admConfirmation = DialogResult.No Then
                    populatePendingAdminDGV()
                End If
            Else
                MessageBox.Show("Please select an account first.")
                populatePendingAdminDGV()
            End If
        End If
    End Sub
    Private Sub moveToTourGuideCol(guideID As String)
        Try
            Dim objectId As ObjectId
            If ObjectId.TryParse(guideID, objectId) Then
                Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objectId)
                Dim document = rmsSharedVar.colResume.Find(filter).FirstOrDefault()
                If document IsNot Nothing Then
                    'Add account creation date, set status bago imove
                    document.Add("accountCreationDate", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                    document.Add("status", "available")
                    rmsSharedVar.colTourGuide.InsertOne(document)
                    rmsSharedVar.colResume.DeleteOne(filter)
                    MessageBox.Show("New tour guide account successfully added!")
                    populateApplicantDGV()
                    clearApplicantForm()
                Else
                    MessageBox.Show("Account not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    populateApplicantDGV()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            populateApplicantDGV()
        End Try
    End Sub
    Private Sub moveToAdminCol(pendingID As String)
        Try
            Dim objectId As ObjectId
            If ObjectId.TryParse(pendingID, objectId) Then
                Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objectId)
                Dim document = rmsSharedVar.colPendingAdmin.Find(filter).FirstOrDefault()
                If document IsNot Nothing Then
                    rmsSharedVar.colAdmin.InsertOne(document)
                    rmsSharedVar.colPendingAdmin.DeleteOne(filter)
                    MessageBox.Show("New admin account successfully added!")
                    populatePendingAdminDGV()
                    clearAdmin()
                Else
                    MessageBox.Show("Account not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    populatePendingAdminDGV()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            populatePendingAdminDGV()
        End Try
    End Sub
    Private Sub ctrlNotif_Load(sender As Object, e As EventArgs) Handles Me.Load
        populateApplicantDGV()
        populatePendingAdminDGV()
    End Sub
    Private Sub ctrlNotif_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            populateApplicantDGV()
            populatePendingAdminDGV()
        ElseIf Me.Visible = False Then
            'closeMongoConn()
            clearApplicantForm()
            clearAdmin()
        End If
    End Sub
End Class