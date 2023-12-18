Imports MongoDB.Driver
Module moduleDatabase
    Private client As MongoClient
    Private database As IMongoDatabase
    Public Function connectToMongo() As IMongoDatabase
        Try
            Dim connectionString As String = "mongodb+srv://atvrms:atvrms@atvrms.nwojtse.mongodb.net/?retryWrites=true&w=majority&connectTimeoutMS=10000"
            'Dim connectionString As String = "mongodb://localhost:27017/?connectTimeoutMS=10000"
            client = New MongoClient(connectionString)
            database = client.GetDatabase("ATVRMS")
            Return database
        Catch ex As MongoCommandException When ex.Code = 50 'para sa timeout
            MessageBox.Show("Timeout error: Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Catch ex As Exception
            MessageBox.Show("An error has occured while trying to connect to the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
    Public Sub closeMongoConn()
        If client IsNot Nothing Then
            client = Nothing
        End If
    End Sub
End Module