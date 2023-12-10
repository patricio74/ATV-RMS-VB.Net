Public Class selectATV
    Dim selectedATVs As New List(Of String)
    Dim maxATV As Integer = 3 'max selection limit
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        atvCheckList.ClearSelected()
        'also reset array before closing
    End Sub
    Private Sub selectATV_Load(sender As Object, e As EventArgs) Handles Me.Load
        initializeDraggablePanel(panelTop)
        lblATVCount.Text = "Please select " + maxATV.ToString + " ATV:"
    End Sub
    Private Sub btnSaveList_Click(sender As Object, e As EventArgs) Handles btnSaveList.Click
        If atvCheckList.CheckedItems.Count < maxATV Then
            Dim kulang As Integer = maxATV - atvCheckList.CheckedItems.Count
            MessageBox.Show("Please select " + kulang.ToString + " ATV to continue.")
        Else
            'save selected list to an array

        End If
    End Sub
    Private Sub lblClearList_Click(sender As Object, e As EventArgs) Handles lblClearList.Click
        'unseletc all items
        For i As Integer = 0 To atvCheckList.Items.Count - 1
            atvCheckList.SetItemChecked(i, False)
        Next
        atvCheckList.ClearSelected() 'remove highlighted item
        ' Clear the array
        selectedATVs.Clear()
    End Sub
    Private Sub atvCheckList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles atvCheckList.SelectedIndexChanged
        atvCheckList.ClearSelected() 'para hindi naghihighlight yung last selection
        ' Check the count of currently checked items
        If atvCheckList.CheckedItems.Count > maxATV Then
            MessageBox.Show("Oops! You have reached the ATV selection limit.")
            ' Uncheck the last checked item
            atvCheckList.SetItemChecked(atvCheckList.SelectedIndex, False)
        ElseIf atvCheckList.CheckedItems.Count < 0 Then
        End If
    End Sub

    'TO DO!!!!!
    'create a function to populate list with ATVs from mongo col then call on form load, button, lblClear click event

End Class