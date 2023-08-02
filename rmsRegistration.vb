Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class rmsRegistration

    Private Sub rmsRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load
        connectToMongo()
    End Sub


    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        rmsLogin.Close()
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        If regFname.Text = "" Or regSname.Text = "" Or regEmail.Text = "" Or regPhone.Text = "" Or regUsername.Text = "" Or regPassw.Text = "" Or regRFID.Text = "" Then
            MessageBox.Show("Fill out all the fields to continue.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                'Dim client As MongoClient = New MongoClient(connectionString)
                'Dim database As IMongoDatabase = client.GetDatabase("ATVRMS")
                Dim firstName As String = regFname.Text()
                Dim surname As String = regSname.Text()
                Dim email As String = regEmail.Text.Trim()
                Dim phone As String = regPhone.Text.Trim()
                Dim username As String = regUsername.Text.Trim()
                Dim password As String = regPassw.Text.Trim()
                Dim rfid As String = regRFID.Text.Trim()

                Dim newAdmin As New BsonDocument From {
                    {"First Name", firstName},
                    {"Surname", surname},
                    {"Email", email},
                    {"Phone", phone},
                    {"Username", username},
                    {"Password", password},
                    {"RFID", rfid}
                }
                Dim collection As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("rmsAdmin")
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Or(
                    Builders(Of BsonDocument).Filter.Eq(Of String)("RFID", rfid),
                    Builders(Of BsonDocument).Filter.Eq(Of String)("Username", username),
                    Builders(Of BsonDocument).Filter.Eq(Of String)("Email", email)
                )
                Dim count As Long = collection.CountDocuments(filter)

                If count > 0 Then
                    MessageBox.Show("The email, username, or RFID is already in use by another admin.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    regRFID.Focus()
                Else
                    collection.InsertOne(newAdmin)
                    MessageBox.Show("You may now login to ATV-RMS.", "Successfully registered!", MessageBoxButtons.OK, MessageBoxIcon.None)
                    rmsLogin.Show()
                    clearRegForm()
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub labelLogin_Click(sender As Object, e As EventArgs) Handles labelLogin.Click
        rmsLogin.Show()
        Me.Close()
    End Sub


End Class