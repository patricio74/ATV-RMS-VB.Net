Imports System.Drawing.Imaging
Imports System.Windows.Forms.VisualStyles
Imports MongoDB.Bson
Imports MongoDB.Driver

Module rmsModule
    '==============MONGODB==============
    Public ReadOnly connectionString As String = "mongodb+srv://atvrms:atvrms@atvrms.nwojtse.mongodb.net/?retryWrites=true&w=majority"


    '==============LOGIN FORM==============
    Public Sub loadRMSLogin()
        rmsLogin.panelRFIDLogin.Hide()
        rmsLogin.panelPassLogin.Show()
        rmsLogin.labelPassSwitch.Hide()
        rmsLogin.labelRFIDSwitch.Show()
        rmsLogin.checkShow.Checked = False
        rmsLogin.tboxUsername.Focus()
    End Sub

    Public Sub rmsPassLogin()
        rmsLogin.panelRFIDLogin.Hide()
        rmsLogin.panelPassLogin.Show()
        rmsLogin.labelPassSwitch.Hide()
        rmsLogin.labelRFIDSwitch.Show()
        rmsLogin.tboxRFID.Clear()
        rmsLogin.checkShow.Checked = False
        rmsLogin.tboxUsername.Focus()
    End Sub

    Public Sub rmsRFIDLogin()
        rmsLogin.panelRFIDLogin.Show()
        rmsLogin.panelPassLogin.Hide()
        rmsLogin.labelPassSwitch.Show()
        rmsLogin.labelRFIDSwitch.Hide()
        rmsLogin.tboxPassword.Clear()
        rmsLogin.checkShow.Checked = False
    End Sub

    Public Function getAdminUsername(username As String) As BsonDocument
        Try
            Dim client As MongoClient = New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase("ATVRMS")
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("rmsAdmin")
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("username", username)
            Dim userDocument As BsonDocument = collection.Find(filter).FirstOrDefault()

            Return userDocument
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function getAdminRFID(rfid As String) As BsonDocument
        Try
            Dim client As MongoClient = New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase("ATVRMS")
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("rmsAdmin")
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("rfid", rfid)
            Dim userDocument As BsonDocument = collection.Find(filter).FirstOrDefault()

            Return userDocument
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Sub adminLogin()
        If rmsLogin.tboxUsername.Text = "" Then
            MessageBox.Show("Username cannot be empty.", "Blank username!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rmsLogin.tboxUsername.Focus()
        ElseIf rmslogin.tboxPassword.Text = "" Then
            MessageBox.Show("Password cannot be empty.", "Blank password!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rmsLogin.tboxPassword.Focus()
        Else
            Try
                Dim username As String = rmsLogin.tboxUsername.Text
                Dim password As String = rmsLogin.tboxPassword.Text
                Dim connectionString As String = rmsModule.connectionString
                Dim userDocument As BsonDocument = rmsModule.getAdminUsername(username)
                If userDocument IsNot Nothing Then
                    Dim storedPassword As String = userDocument("password").ToString()
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

    Public Sub clearLoginForm()
        rmsLogin.tboxUsername.Clear()
        rmsLogin.tboxPassword.Clear()
        rmsLogin.tboxRFID.Clear()
        rmsLogin.checkShow.Checked = False
    End Sub

End Module
