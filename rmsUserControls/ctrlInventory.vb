Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ctrlInventory
    Private inventoryy As List(Of inventoryDoc)
    Public Class inventoryDoc
        Public Property invID As String
        Public Property atvBrand As String
        Public Property atvModel As String
        Public Property description As String
        Public Property status As String
        Public Property dateAdded As String
    End Class
    Private Sub clearAtvForm()
        dgvInventory.ClearSelection()
        dgvAtvMaintenance.Rows.Clear()
        dgvAtvMaintenance.ClearSelection()
        updBrand.Clear()
        updModel.Clear()
        rtbxUpdDesc.Clear()
        cbxUpdStatus.SelectedIndex = -1
        addBrand.Clear()
        addModel.Clear()
        rtbxAddDesc.Clear()
        cbxAddStatus.SelectedIndex = -1
    End Sub
    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles updBrand.KeyPress, updModel.KeyPress, addBrand.KeyPress, addModel.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub refreshInv()
        If rmsDashboard.switchInven = True Then
            dgvInventory.Rows.Clear()
            Dim invList As List(Of BsonDocument) = rmsSharedVar.colInventory.Find(New BsonDocument()).ToList()
            inventoryy = New List(Of inventoryDoc)()
            For Each document As BsonDocument In invList
                Dim idElement = document.GetElement("_id")
                Dim invvv As New inventoryDoc() With {
                    .invID = idElement.Value.AsObjectId.ToString,
                    .atvBrand = document("atvBrand").ToString,
                    .atvModel = document("atvModel").ToString,
                    .description = document("description").ToString,
                    .status = document("status").ToString,
                    .dateAdded = document("dateAdded").ToString
                }
                inventoryy.Add(invvv)
            Next
            populateInventory(inventoryy)
        End If
    End Sub
    Private Sub populateInventory(inventoryy As List(Of inventoryDoc))
        dgvInventory.Rows.Clear()
        For Each atv As inventoryDoc In inventoryy
            Dim row As New DataGridViewRow()
            row.CreateCells(
            dgvInventory, atv.atvBrand, atv.atvModel, atv.status, atv.description
            )
            dgvInventory.Rows.Add(row)
            dgvInventory.ClearSelection()
            clearAtvForm()
        Next
    End Sub
    Private Sub tabInventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabInventory.SelectedIndexChanged
        If tabInventory.SelectedIndex = 0 Then 'update ATV tab
            updBrand.Focus()
        ElseIf tabInventory.SelectedIndex = 1 Then 'add new ATV tab
            refreshInv()
            clearAtvForm()
            addBrand.Focus()
        End If
    End Sub
    Private Sub dgvInventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellClick
        If e.RowIndex >= 0 Then
            tabInventory.SelectedIndex = 0 'update atv tab
            If inventoryy IsNot Nothing AndAlso e.RowIndex < inventoryy.Count Then
                Dim selectedAtv = inventoryy(e.RowIndex)
                updBrand.Text = selectedAtv.atvBrand
                updModel.Text = selectedAtv.atvModel
                rtbxUpdDesc.Text = selectedAtv.description
                cbxUpdStatus.Text = selectedAtv.status
                'updBrand.Focus()

                'populate maintenance dgv
                Dim atvID As String = selectedAtv.invID
                'get atv maintenance history based sa ID
                Dim logMaintenance = getMaintenanceHist(atvID)
                'populate dgvMaintenance with the fetched logMaintenance doc
                populateMaintenHistory(logMaintenance)
            End If
        End If
    End Sub
    Private Function getMaintenanceHist(atvID As String) As List(Of BsonDocument)
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("atvID", atvID)
        Return rmsSharedVar.colAtvMaintenance.Find(filter).ToList()
    End Function
    Private Sub populateMaintenHistory(logMaintenance As List(Of BsonDocument))
        'sort dgv ng maintenance history
        logMaintenance.Sort(Function(x, y) DateTime.Compare(DateTime.Parse(x("maintenanceDate").ToString()), DateTime.Parse(y("maintenanceDate").ToString())))
        dgvAtvMaintenance.Rows.Clear()
        For Each maintt As BsonDocument In logMaintenance
            Dim row As New DataGridViewRow()
            'convert to datetime object
            Dim maintenDate As DateTime = DateTime.Parse(maintt("maintenanceDate").ToString())
            'change format para mas readable
            Dim formattedDate As String = maintenDate.ToString("MMM. dd, yyyy hh:mmtt")
            'format as currency
            Dim formattedCost As String = FormatCurrency(CDec(maintt("maintenanceCost").ToString()))
            row.CreateCells(dgvAtvMaintenance, formattedDate, formattedCost, maintt("maintenanceType").ToString(), maintt("otherType").ToString()
            )
            dgvAtvMaintenance.Rows.Add(row)
        Next
        dgvAtvMaintenance.ClearSelection()
    End Sub
    Private Sub btnInv_Click(sender As Object, e As EventArgs) Handles btnAddAtv.Click, btnUpdAtv.Click, btnMaintenance.Click, btnDelAtv.Click, lblClearAtv.Click
        If sender Is btnAddAtv Then
            'check muna kung may blangko sa form bago mag-update
            If String.IsNullOrEmpty(addBrand.Text) OrElse String.IsNullOrEmpty(addModel.Text) OrElse String.IsNullOrEmpty(cbxAddStatus.Text) Then
                MessageBox.Show("Please fill in all fields to continue.")
            Else
                Dim addConfirmation As DialogResult = MessageBox.Show("Do you want to add this ATV to the database?", "Confirmation", MessageBoxButtons.YesNo)
                If addConfirmation = DialogResult.Yes Then
                    Dim newBrand As String = addBrand.Text
                    Dim newModel As String = addModel.Text
                    Dim newStatus As String = cbxAddStatus.Text
                    Dim newDesc As String = rtbxAddDesc.Text
                    Dim newDate As String = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ")
                    Dim docNewAtv As New BsonDocument() From {
                        {"atvBrand", newBrand},
                        {"atvModel", newModel},
                        {"description", newDesc},
                        {"status", newStatus},
                        {"dateAdded", newDate}
                    }
                    Try
                        rmsSharedVar.colInventory.InsertOne(docNewAtv)
                        MessageBox.Show("New ATV added to the database")
                        refreshInv()
                        clearAtvForm()
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If

        ElseIf sender Is btnUpdAtv Then
            If dgvInventory.SelectedRows.Count > 0 Then
                Dim selectedRow = dgvInventory.SelectedRows(0)
                Dim selectedAtv = inventoryy(selectedRow.Index)
                Dim atvID As String = selectedAtv.invID
                'check muna kung may blangko sa form bago mag-update
                If String.IsNullOrEmpty(updBrand.Text) OrElse String.IsNullOrEmpty(updModel.Text) OrElse String.IsNullOrEmpty(cbxUpdStatus.Text) Then
                    MessageBox.Show("Please fill in all fields to continue.")
                Else
                    Dim updConfirmation As DialogResult = MessageBox.Show("Do you want to update this ATV?", "Confirmation", MessageBoxButtons.YesNo)
                    If updConfirmation = DialogResult.Yes Then
                        Try
                            Dim objectId As ObjectId
                            If ObjectId.TryParse(atvID, objectId) Then
                                Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objectId)
                                Dim update = Builders(Of BsonDocument).Update.Set(Of String)("atvBrand", updBrand.Text).
                                Set(Of String)("atvModel", updModel.Text).
                                Set(Of String)("description", rtbxUpdDesc.Text).
                                Set(Of String)("status", cbxUpdStatus.Text)
                                rmsSharedVar.colInventory.UpdateOne(filter, update)
                                MessageBox.Show("ATV updated successfully.")
                                refreshInv()
                                clearAtvForm()
                            End If
                        Catch ex As Exception
                            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                End If
            Else
                MessageBox.Show("Please select an ATV to update.")
                refreshInv()
            End If

        ElseIf sender Is btnMaintenance Then
            If dgvInventory.SelectedRows.Count > 0 Then
                Dim selectedRow = dgvInventory.SelectedRows(0)
                Dim selectedAtv = inventoryy(selectedRow.Index)
                Dim atvID As String = selectedAtv.invID
                rmsSharedVar.maintenanceID = atvID
                Dim updConfirmation As DialogResult = MessageBox.Show("Add maintenance information to this ATV?", "Confirmation", MessageBoxButtons.YesNo)
                If updConfirmation = DialogResult.Yes Then
                    'show maintenance form
                    rmsSharedVar.openMaintenanceForm = True
                    atvMaintenance.ShowDialog()
                    If rmsSharedVar.openMaintenanceForm = False Then
                        'repopulate maintenance dgv
                        'get atv maintenance history based sa ID
                        'Dim logMaintenance = getMaintenanceHist(atvID)
                        'populate dgvMaintenance with the fetched logMaintenance doc
                        'populateMaintenHistory(logMaintenance)
                        'refresh dgv
                        refreshInv()
                    End If
                End If
            Else
                MessageBox.Show("Please select an ATV to update.")
                refreshInv()
            End If

        ElseIf sender Is btnDelAtv Then
            If dgvInventory.SelectedRows.Count > 0 Then
                Dim selectedAtv = inventoryy(dgvInventory.SelectedRows(0).Index)
                Dim atvID As String = selectedAtv.invID
                Dim delConfirmation = MessageBox.Show("Are you sure you want to remove this ATV?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                'move customer data to archive collection
                If delConfirmation = DialogResult.Yes Then
                    moveToArchive(atvID)
                ElseIf delConfirmation = DialogResult.No Then
                    refreshInv()
                End If
            Else
                MessageBox.Show("No ATV selected for deletion.")
                refreshInv()
            End If

        ElseIf sender Is lblClearAtv Then
            clearAtvForm()
        End If
    End Sub
    Private Sub moveToArchive(atvID As String)
        Try
            Dim objectId As ObjectId
            If ObjectId.TryParse(atvID, objectId) Then
                Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objectId)
                Dim document = rmsSharedVar.colInventory.Find(filter).FirstOrDefault()
                If document IsNot Nothing Then
                    'Add date to accountDeletionDate bago iarchive
                    document.Add("atvDeletionDate", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                    rmsSharedVar.archiveInventory.InsertOne(document)
                    rmsSharedVar.colInventory.DeleteOne(filter)
                    MessageBox.Show("ATV trail deleted successfully.")
                    refreshInv()
                    clearAtvForm()
                Else
                    MessageBox.Show("ATV trail not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    refreshInv()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            refreshInv()
        End Try
    End Sub
    Private Sub ctrlInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'disable dgv sorting on column header clikc
        For Each column As DataGridViewColumn In dgvInventory.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        For Each column As DataGridViewColumn In dgvAtvMaintenance.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        refreshInv()
    End Sub
    Private Sub ctrlInventory_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            refreshInv()
        ElseIf Me.Visible = False Then
            'closeMongoConn()
            clearAtvForm()
            tabInventory.SelectedIndex = 0
        End If
    End Sub
End Class
