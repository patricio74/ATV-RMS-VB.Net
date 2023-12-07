Imports System.IO
Imports MongoDB.Bson
Imports MongoDB.Driver

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
        Public Property tgResume As String
        Public Property tgSubmissionDate As String
    End Class
    Public Class admDoc
        Public Property admpID As String
        Public Property admpFname As String '
        Public Property admpMname As String
        Public Property admpSname As String
        Public Property admpEmail As String
        Public Property admpPhone As String
        Public Property admpAddress As String
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
        cbxRole.SelectedIndex = 0
    End Sub
    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxApplicantName.KeyPress, tbxApplicantAddress.KeyPress, tbxApplicantEmail.KeyPress,
            tbxAdminName.KeyPress, tbxAdminEmail.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClearApplicant.Click, btnClearAdmin.Click
        If sender Is btnClearApplicant Then
            clearApplicantForm()
            populateApplicantDGV()
        ElseIf sender Is btnClearAdmin Then
            clearAdmin()
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
                .tgResume = document("resume"),
                .tgSubmissionDate = document("submissionDate").ToString
                }
                pendingTGuide.Add(tg)
            Next
            dgvPendingTourGuides.Rows.Clear()
            For Each doc In pendingTGuide
                Dim applicant As String = $"{doc.tgFname} {doc.tgMname} {doc.tgSname}".Trim()
                dgvPendingTourGuides.Rows.Add(doc.tgID, applicant, doc.tgPhone, doc.tgEmail)
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
    Private Sub ctrlNotif_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbxRole.SelectedIndex = 0
        populateApplicantDGV()
    End Sub
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnDownloadResume.Click, btnAcceptApplicant.Click, btnApproveAdmin.Click
        If sender Is btnDownloadResume Then
            If dgvPendingTourGuides.SelectedRows.Count > 0 Then
                Dim downloadConfirmation As DialogResult = MessageBox.Show("Do you want to download resume?", "Confirmation", MessageBoxButtons.YesNo)
                If downloadConfirmation = DialogResult.Yes Then
                    'ID is in the first column (index 0)
                    Dim selectedRow = dgvPendingTourGuides.SelectedRows(0)
                    Dim selID As String = selectedRow.Cells(0).Value.ToString()
                    'use ObjectId.Parse to convert the string ID to ObjectId
                    Dim filter = Builders(Of BsonDocument).Filter.Eq(Of Object)("_id", ObjectId.Parse(selID))
                    Dim document As BsonDocument = rmsSharedVar.colResume.Find(filter).FirstOrDefault()
                    If document IsNot Nothing Then
                        ' Get the filename
                        Dim fileName As String = document("resume").AsString
                        ' Specify the path where you want to save the downloaded resume
                        Dim savePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), fileName)
                        ' Retrieve the resume content from MongoDB
                        Dim resumeContent As String = document("resume").AsString
                        ' Check if the content is not empty
                        If Not String.IsNullOrEmpty(resumeContent) Then
                            ' Save the content to a file
                            File.WriteAllText(savePath, resumeContent)
                            MessageBox.Show($"Resume downloaded to Desktop: {fileName}")
                        Else
                            MessageBox.Show($"No resume file found in the database!")
                        End If
                    Else
                        MessageBox.Show("No resume document found in the database!")
                    End If
                End If
            End If
            ElseIf sender Is btnAcceptApplicant Then

        ElseIf sender Is btnApproveAdmin Then

        End If
    End Sub
    Private Sub ctrlNotif_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            closeMongoConn()
            clearApplicantForm()
            clearAdmin()
        End If
    End Sub
End Class