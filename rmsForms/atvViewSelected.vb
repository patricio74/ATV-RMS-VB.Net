Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class atvViewSelected
    Private Sub loadList()
        If rmsSharedVar.atvInUseID Is Nothing Then
            'clear dgv if atvInUseID=nothing
            dgvViewAtv.Rows.Clear()
            Return
        End If
        'get atvlist ng selected transaction
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(rmsSharedVar.atvInUseID))
        Dim projection = Builders(Of BsonDocument).Projection.Include("selectedATV")
        Dim result = rmsSharedVar.colTransac.Find(filter).Project(projection).FirstOrDefault()
        If result IsNot Nothing AndAlso result.Contains("selectedATV") Then
            Dim selectedATVList As BsonArray = result("selectedATV").AsBsonArray
            'populate dgv
            For Each atv As BsonDocument In selectedATVList
                Dim atvName As String = atv("Name").AsString
                dgvViewAtv.Rows.Add(atvName)
            Next
        End If
    End Sub
    Private Sub atvViewSelected_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            dgvViewAtv.Rows.Clear()
            loadList()
            dgvViewAtv.ClearSelection()
        ElseIf Me.Visible = False Then
            dgvViewAtv.Rows.Clear()
        End If
    End Sub
End Class