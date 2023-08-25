Imports MongoDB.Bson
Imports MongoDB.Driver

Module moduleLogin

    Public Sub loadRMSLogin()
        rmsLogin.panelRFIDLogin.Hide()
        rmsLogin.panelPassLogin.Show()
        rmsLogin.checkShow.Checked = False
        rmsLogin.tboxUsername.Focus()
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
        If rmsLogin.tboxUsername.Text = "" Then
            MessageBox.Show("Username cannot be empty.", "Blank username!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rmsLogin.tboxUsername.Focus()
        ElseIf rmsLogin.tboxPassword.Text = "" Then
            MessageBox.Show("Password cannot be empty.", "Blank password!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rmsLogin.tboxPassword.Focus()
        Else
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
                        Dim admnFullName As String = $"{userDocument("First Name")} {userDocument("Middle Name")} {userDocument("Surname")}"
                        rmsDashboard.labelName = admnFullName
                        rmsDashboard.Show
                        rmsLogin.Hide()
                    Else
                        MessageBox.Show("Wrong password.", "Failed to Login!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        rmsLogin.tboxPassword.Focus()
                    End If
                Else
                    MessageBox.Show("User not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    rmsLogin.tboxUsername.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End If
    End Sub


End Module