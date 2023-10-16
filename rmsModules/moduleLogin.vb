Imports MongoDB.Bson
Imports MongoDB.Driver
Module moduleLogin
    Public Sub loadRMSLogin()
        rmsLogin.panelRFIDLogin.Hide()
        rmsLogin.panelPassLogin.Show()
        rmsLogin.clearLoginForm()
        rmsLogin.tboxUsername.Focus()
    End Sub
    Public Sub hideErrorLabel()
        rmsLogin.lblLoginError.Visible = False
        rmsLogin.lblUserError.Visible = False
        rmsLogin.lblPassError.Visible = False
        rmsLogin.lblRFIDErr.Visible = False
    End Sub
    Public Sub adminPassLogin()
        hideErrorLabel()
        Try
            Dim username As String = rmsLogin.tboxUsername.Text
            Dim password As String = rmsLogin.tboxPassword.Text
            Dim loginCol As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("rmsAdmin")
            Dim filter = Builders(Of BsonDocument).Filter.Or(
                Builders(Of BsonDocument).Filter.Eq(Of String)("Username", username),
                Builders(Of BsonDocument).Filter.Eq(Of String)("Email", username)
            )
            Dim loginDocument = loginCol.Find(filter).FirstOrDefault()
            If loginDocument IsNot Nothing Then
                Dim storedPassw As String = loginDocument("Password").ToString()
                If password = storedPassw Then
                    hideErrorLabel()
                    Dim admnFullName As String = $"{loginDocument("First Name")} {loginDocument("Middle Name")} {loginDocument("Surname")}"
                    rmsSharedVar.labelName = admnFullName
                    Dim adminID As String = loginDocument("_id").ToString()
                    rmsSharedVar.admnID = adminID
                    rmsDashboard.Show()
                    rmsLogin.Hide()
                Else
                    rmsLogin.lblLoginError.Text = "Authentication failed: Wrong password."
                    rmsLogin.lblLoginError.Visible = True
                    rmsLogin.tboxPassword.Focus()
                End If
            Else
                rmsLogin.lblLoginError.Text = "Authentication error: User not found."
                rmsLogin.lblLoginError.Visible = True
                rmsLogin.tboxUsername.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("An error has occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub
    Public Sub adminRFIDLogin()
        Try
            Dim RFID As String = rmsLogin.tboxRFID.Text
            Dim rfidCol As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("rmsAdmin")
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("RFID", RFID)
            Dim rfidDocument As BsonDocument = rfidCol.Find(filter).FirstOrDefault()
            If rfidDocument Is Nothing Then
                rmsLogin.lblRFIDErr.Text = "Error: RFID not registered."
                rmsLogin.lblRFIDErr.Visible = True
                rmsLogin.tboxRFID.Focus()
            ElseIf rfidDocument IsNot Nothing Then
                hideErrorLabel()
                Dim admnFullName As String = $"{rfidDocument("First Name")} {rfidDocument("Middle Name")} {rfidDocument("Surname")}"
                rmsSharedVar.labelName = admnFullName
                Dim adminID As String = $"{rfidDocument("_id")}"
                rmsSharedVar.admnID = adminID
                rmsDashboard.Show()
                rmsLogin.Hide()
            Else
                MessageBox.Show("An error occured: ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error has occured: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub
End Module