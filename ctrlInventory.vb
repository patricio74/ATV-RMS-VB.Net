
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class ctrlInventory

    Private Sub ctrlInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim collection As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("Inventory")
        Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()

    End Sub

End Class
