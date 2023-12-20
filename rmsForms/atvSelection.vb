Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class atvSelection
    Dim maxATV As Integer
    Public Class atvItem
        Public Property Name As String
        Public Property Id As ObjectId
        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class
    Private Sub loadATVCheckList()
        If Me.Visible = True Then
            'clear array, repopulate list
            ' rmsSharedVar.selectedATVs.Clear()
            ' atvCheckList.Items.Clear()
            Dim atvFilter = Builders(Of BsonDocument).Filter.Eq(Of String)("status", "AVAILABLE")
            Dim atvField = Builders(Of BsonDocument).Projection.Include("atvBrand").Include("atvModel").Include("_id")
            Dim cursor = rmsSharedVar.colInventory.Find(atvFilter).Project(atvField).ToCursor()
            'list available ATVs
            While cursor.MoveNext()
                For Each document In cursor.Current
                    Dim brandName As String = document("atvBrand").AsString
                    Dim modelName As String = document("atvModel").AsString
                    Dim atvId As ObjectId = document("_id").AsObjectId
                    'combine brand and model sa bawat checklist
                    Dim atvItem As New atvItem With {.Name = $"{brandName} {modelName}", .Id = atvId}
                    atvCheckList.Items.Add(atvItem)
                Next
            End While
        End If
    End Sub
    Private Sub btnSaveList_Click(sender As Object, e As EventArgs) Handles btnSaveList.Click
        If atvCheckList.CheckedItems.Count < maxATV Then
            Dim kulang As Integer = maxATV - atvCheckList.CheckedItems.Count
            MessageBox.Show("Please select " + kulang.ToString + " ATV to continue.")
        Else
            'clear muna array bago insert ng bago
            rmsSharedVar.selectedATVs.Clear()
            'save selected list to an array
            For Each item As atvItem In atvCheckList.CheckedItems
                'save only the model and _id to the array
                rmsSharedVar.selectedATVs.Add(item)
            Next
            Me.Hide()
        End If
    End Sub
    Private Sub lblClearList_Click(sender As Object, e As EventArgs) Handles lblClearList.Click
        'unselect all items
        For i As Integer = 0 To atvCheckList.Items.Count - 1
            atvCheckList.SetItemChecked(i, False)
        Next
        atvCheckList.ClearSelected() 'unhighlight item
        'clear array, repopulate list
        rmsSharedVar.selectedATVs.Clear()
        atvCheckList.Items.Clear()
        loadATVCheckList()
    End Sub
    Private Sub atvCheckList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles atvCheckList.SelectedIndexChanged
        If atvCheckList.SelectedIndex <> -1 Then
            'count checked items
            If atvCheckList.CheckedItems.Count > maxATV Then
                MessageBox.Show("Oops! You have reached a limit of " & maxATV & " ATVs.")
                'uncheck the last checked item
                atvCheckList.SetItemChecked(atvCheckList.SelectedIndex, False)
            End If
        End If
    End Sub
    Private Sub selectATV_Load(sender As Object, e As EventArgs) Handles Me.Load
        maxATV = rmsSharedVar.atvTotNum
        lblATVCount.Text = "Please select " + maxATV.ToString + " ATV:"
        'clear array, repopulate list
        ' rmsSharedVar.selectedATVs.Clear()
        ' atvCheckList.Items.Clear()
        loadATVCheckList()
    End Sub
    Private Sub atvSelection_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            maxATV = rmsSharedVar.atvTotNum
            lblATVCount.Text = "Please select " + maxATV.ToString + " ATV:"
            'clear array, repopulate list
            'rmsSharedVar.selectedATVs.Clear()
            'atvCheckList.Items.Clear()
            loadATVCheckList()
        ElseIf Me.Visible = False Then
            ' atvCheckList.Items.Clear()
            ' atvCheckList.ClearSelected()
        End If
    End Sub
End Class
