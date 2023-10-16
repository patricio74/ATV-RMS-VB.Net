
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class ctrlInventory

    Private Sub ctrlInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim collection As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("Inventory")
        Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
    End Sub

    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxInvNum.KeyPress, tbxBrand.KeyPress, tbxModel.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnInv_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnUpd.Click, btnDel.Click, lblClearAdd.Click
        If sender Is btnAdd Then

        ElseIf sender Is btnUpd Then

        ElseIf sender Is btnDel Then

        ElseIf sender Is lblClearAdd Then

        End If
    End Sub
End Class
