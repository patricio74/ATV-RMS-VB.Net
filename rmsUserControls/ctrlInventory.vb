Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class ctrlInventory

    Private Sub ctrlInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim collection As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("Inventory")
        Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
    End Sub

    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxInvNum.KeyPress, tbxUpdBrand.KeyPress, tbxUpdModel.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnInv_Click(sender As Object, e As EventArgs) Handles btnAddAtv.Click, btnUpdAtv.Click, lblClearAtv.Click
        If sender Is btnAddAtv Then

        ElseIf sender Is btnUpdAtv Then

        ElseIf sender Is btnDelAtv Then

        ElseIf sender Is lblClearAtv Then

        End If
    End Sub
End Class
