Imports MongoDB.Driver
Public Class rmsSharedVar
    'DB shared instance
    Public Shared mongoDBase As IMongoDatabase = connectToMongo()

    'store current user's username
    Public Shared labelName As String

    'store userid
    Public Shared admnID As String
End Class