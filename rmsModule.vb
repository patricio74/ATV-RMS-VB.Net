Imports MongoDB.Bson
Imports MongoDB.Driver

Module rmsModule

    '==============MONGODB==============
    'Public ReadOnly connectionString As String = "mongodb+srv://atvrms:atvrms@atvrms.nwojtse.mongodb.net/?retryWrites=true&w=majority"

    Public Function connectToMongo() As IMongoDatabase
        Try
            Dim connectionString As String = "mongodb+srv://atvrms:atvrms@atvrms.nwojtse.mongodb.net/?retryWrites=true&w=majority"
            Dim client As MongoClient = New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase("ATVRMS")
            Return database
        Catch ex As Exception
            MessageBox.Show("Error sa mongoDB lodz: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function


    '==============REGISTRATION FORM==============
    Public Sub clearRegForm()
        rmsRegistration.regFname.Clear()
        rmsRegistration.regSname.Clear()
        rmsRegistration.regEmail.Clear()
        rmsRegistration.regPhone.Clear()
        rmsRegistration.regUsername.Clear()
        rmsRegistration.regPassw.Clear()
        rmsRegistration.regRFID.Clear()
    End Sub

    Public Sub regForm()

    End Sub

    '==============LOGIN FORM==============
    Public Sub loadRMSLogin()
        rmsLogin.panelRFIDLogin.Hide()
        rmsLogin.panelPassLogin.Show()
        rmsLogin.checkShow.Checked = False
        rmsLogin.tboxUsername.Focus()
    End Sub

    Public Function getAdminUsername(username As String) As BsonDocument
        Try
            'connectToMongo()
            Dim collection As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("rmsAdmin")
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("username", username)
            Dim userDocument As BsonDocument = collection.Find(filter).FirstOrDefault()
            Return userDocument
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

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
                        rmsDashboard.Show()
                        rmsLogin.Hide()
                    Else
                        MessageBox.Show("Incorrect password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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


    '===============ADMIN DASHBOARD==============
    Public Sub resetButtonColor()
        Dim defaultForeColor As Color = ColorTranslator.FromHtml("#f5f5f5")
        Dim defaultBackColor As Color = ColorTranslator.FromHtml("#1e272e")

        Dim buttons As Button() = {
            rmsDashboard.btnReservations,
            rmsDashboard.btnInventory,
            rmsDashboard.btnTGuides,
            rmsDashboard.btnCustomers,
            rmsDashboard.btnNotif,
            rmsDashboard.btnTransacHist,
            rmsDashboard.btnRules
        }
        For Each btn In buttons
            btn.ForeColor = defaultForeColor
            btn.BackColor = defaultBackColor
        Next
    End Sub

    Public Sub activeButtonColor(sender As Object, e As EventArgs)
        Dim activeBtn As Button = CType(sender, Button)
        activeBtn.ForeColor = ColorTranslator.FromHtml("#151515")
        activeBtn.BackColor = ColorTranslator.FromHtml("#ffc048")
    End Sub

    Public Sub clearLoginForm()
        rmsLogin.tboxUsername.Clear()
        rmsLogin.tboxPassword.Clear()
        rmsLogin.tboxRFID.Clear()
        rmsLogin.checkShow.Checked = False
    End Sub

End Module
