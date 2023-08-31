Imports MongoDB.Bson
Imports MongoDB.Driver

Module moduleLogin

    Public Sub loadRMSLogin()
        rmsLogin.panelRFIDLogin.Hide()
        rmsLogin.panelPassLogin.Show()
        clearLoginForm()
        rmsLogin.tboxUsername.Focus()
    End Sub

    Public Sub clearLoginForm()
        'rmsLogin.tboxUsername.Clear()
        rmsLogin.tboxPassword.Clear()
        rmsLogin.tboxRFID.Clear()
        rmsLogin.checkShow.Checked = False
        hideErrorLabel()
    End Sub

    Public Sub hideErrorLabel()
        rmsLogin.lblLoginError.Visible = False
        rmsLogin.lblUserError.Visible = False
        rmsLogin.lblPassError.Visible = False
        rmsLogin.lblRFIDErr.Visible = False
    End Sub

    Public Function getAdminRFID(RFID As String) As BsonDocument
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("rmsAdmin")
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("RFID", RFID)
            Dim userDocument As BsonDocument = collection.Find(filter).FirstOrDefault()
            Return userDocument
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Sub adminLogin()
        If rmsLogin.tboxUsername.Text = "" And rmsLogin.tboxPassword.Text = "" Then
            rmsLogin.lblLoginError.Text = "Error: Please enter the required field to continue."
            rmsLogin.lblUserError.Visible = True
            rmsLogin.lblPassError.Visible = True
            rmsLogin.lblLoginError.Visible = True
        ElseIf rmslogin.tboxUsername.Text = "" And rmslogin.tboxPassword IsNot "" Then
            rmsLogin.lblUserError.Visible = True
            rmsLogin.tboxUsername.Focus()
        ElseIf rmslogin.tboxUsername.Text IsNot "" And rmslogin.tboxPassword.Text = "" Then
            rmsLogin.lblPassError.Visible = True
            rmsLogin.tboxPassword.Focus()
        Else
            hideErrorLabel()
            Try
                Dim username As String = rmsLogin.tboxUsername.Text
                Dim password As String = rmsLogin.tboxPassword.Text
                Dim collection As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("rmsAdmin")
                Dim filter = Builders(Of BsonDocument).Filter.Or(
                    Builders(Of BsonDocument).Filter.Eq(Of String)("Username", username),
                    Builders(Of BsonDocument).Filter.Eq(Of String)("Email", username)
                )
                Dim userDocument As BsonDocument = collection.Find(filter).FirstOrDefault()
                If userDocument IsNot Nothing Then
                    Dim storedPassword As String = userDocument("Password").ToString()
                    If password = storedPassword Then
                        hideErrorLabel()
                        Dim admnFullName As String = $"{userDocument("First Name")} {userDocument("Middle Name")} {userDocument("Surname")}"
                        rmsDashboard.labelName = admnFullName
                        rmsDashboard.Show()
                        rmsLogin.Hide()
                    Else
                        rmsLogin.lblLoginError.Text = "Authentication failed: Invalid password."
                        rmsLogin.lblLoginError.Visible = True
                        rmsLogin.tboxPassword.Focus()
                    End If
                Else
                    rmsLogin.lblLoginError.Text = "Authentication error: user not found."
                    rmsLogin.lblLoginError.Visible = True
                    rmsLogin.tboxUsername.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End If
    End Sub


End Module