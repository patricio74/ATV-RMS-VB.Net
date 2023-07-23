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
        Try
            'Dim client As MongoClient = New MongoClient(connectionString)
            'Dim database As IMongoDatabase = client.GetDatabase("ATVRMS")
            Dim firstName As String = regFname.Text.Trim()
            Dim surname As String = regSname.Text.Trim()
            Dim email As String = regEmail.Text.Trim()
            Dim phone As String = regPhone.Text.Trim()
            Dim username As String = regUsername.Text.Trim()
            Dim password As String = regPassw.Text.Trim()
            Dim rfid As String = regRFID.Text.Trim()

            Dim document As New BsonDocument From {
                {"First Name", firstName},
                {"Surname", surname},
                {"Email", email},
                {"Phone", phone},
                {"Username", username},
                {"Password", password},
                {"RFID", rfid}
            }
            Dim collection As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("rmsAdmin")
            collection.InsertOne(document)
            MessageBox.Show("You may now login to ATV-RMS.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None)
            rmsLogin.Show()
            'clearRegForm()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub labelLogin_Click(sender As Object, e As EventArgs) Handles labelLogin.Click
        rmsLogin.Show()
        Me.Close()
    End Sub


End Class