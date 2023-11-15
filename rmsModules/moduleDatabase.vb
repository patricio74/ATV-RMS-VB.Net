Imports MongoDB.Driver
Module moduleDatabase
    Private client As MongoClient
    Private database As IMongoDatabase
    Public Function connectToMongo() As IMongoDatabase
        Try
            Dim connectionString As String = "mongodb+srv://atvrms:atvrms@atvrms.nwojtse.mongodb.net/?retryWrites=true&w=majority"
            'Dim connectionString As String = "mongodb://localhost:27017/"
            client = New MongoClient(connectionString)
            database = client.GetDatabase("ATVRMS")
            Return database
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