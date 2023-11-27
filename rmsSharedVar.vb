Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class rmsSharedVar
    'DB shared instance 
    Public Shared mongoDBase As IMongoDatabase = connectToMongo()

    Public Shared colTransac As IMongoCollection(Of BsonDocument) = mongoDBase.GetCollection(Of BsonDocument)("logTransactions")
    Public Shared colReserv As IMongoCollection(Of BsonDocument) = mongoDBase.GetCollection(Of BsonDocument)("custReservations")
    Public Shared colInventory As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("rmsInventory")
    Public Shared colAtvTrails As IMongoCollection(Of BsonDocument) = mongoDBase.GetCollection(Of BsonDocument)("rmsAtvTours")
    Public Shared colReviews As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("custReviews")

    Public Shared labelName As String   'store current user's username
    Public Shared admnID As String  'store userid
    Public Shared role As String 'store account type

End Class