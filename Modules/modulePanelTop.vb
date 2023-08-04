Module modulePanelTop

    Private mouseDrag As Boolean = False
    Private mouseOffset As Point

    Public Sub InitializeDraggablePanel(panelTop As Panel)
        AddHandler panelTop.MouseDown, AddressOf panelTop_MouseDown
        AddHandler panelTop.MouseMove, AddressOf panelTop_MouseMove
        AddHandler panelTop.MouseUp, AddressOf panelTop_MouseUp
    End Sub

    Private Sub panelTop_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            mouseDrag = True
            mouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub

    Private Sub panelTop_MouseMove(sender As Object, e As MouseEventArgs)
        If mouseDrag Then
            Dim panelTop = DirectCast(sender, Panel)
            Dim mousePos = panelTop.PointToScreen(e.Location)
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            panelTop.Parent.Location = mousePos
        End If
    End Sub

    Private Sub panelTop_MouseUp(sender As Object, e As MouseEventArgs)
        mouseDrag = False
    End Sub

End Module
