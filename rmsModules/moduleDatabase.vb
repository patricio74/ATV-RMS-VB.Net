Imports MongoDB.Bson
Imports MongoDB.Driver

Module moduleDatabase

    Public Function connectToMongo() As IMongoDatabase
        Try
            Dim connectionString As String = "mongodb+srv://atvrms:atvrms@atvrms.nwojtse.mongodb.net/?retryWrites=true&w=majority"
            'Dim connectionString As String = "mongodb://localhost:27017/"
            Dim client As MongoClient = New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase("ATVRMS")
            Return database
        Catch ex As Exception
            MessageBox.Show("Error sa mongoDB lodz: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    'ctrlreservations combobox
    Public Function cbxToursList()
        Dim col As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("rmsAtvTours")
        Dim filter As New BsonDocument()
        Dim tourData As List(Of BsonDocument) = col.Find(filter).ToList()
        Return tourData
    End Function

End Module