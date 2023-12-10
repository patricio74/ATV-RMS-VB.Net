Imports ATV_RMS.selectATV
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class rmsSharedVar
    'DB shared instance
    Public Shared mongoDBase As IMongoDatabase = connectToMongo()

    Public Shared archiveAdmin As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("archiveAdmin")
    Public Shared archiveCust As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("archiveCustomerInfo")
    Public Shared archiveTrail As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("archiveAtvTours")
    Public Shared archiveInventory As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("archiveInventory")
    Public Shared archiveRejectedResume As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("archiveRejectedResume")
    Public Shared archiveTourGuide As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("archiveTourGuide")

    Public Shared colCustomer As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("Customer")
    Public Shared colReserv As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("custReservations")
    Public Shared colReviews As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("custReviews")
    Public Shared colResume As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("empResume")
    Public Shared colTourGuide As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("empTourGuide")

    Public Shared colTransac As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("logTransactions")
    Public Shared colNotif As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("notifSMS")

    Public Shared colAdmin As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("rmsAdmin")
    Public Shared colPendingAdmin As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("rmsAdminPendingAcc")
    Public Shared colTrails As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("rmsAtvTours")
    Public Shared colInventory As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("rmsInventory")

    Public Shared currentUser As String   'store current user's username
    Public Shared admnID  'store userid

    'add transaction var
    Public Shared atvTotNum As Integer 'var para sa dami ng ATV
    Public Shared selectedATVs As New List(Of atvItem) 'store selected ATVs as array
    'waiting tab
    Public Shared atvWaitTotNum As Integer 'var para sa dami ng ATV

End Class