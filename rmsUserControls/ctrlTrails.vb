Public Class ctrlTrails

    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxResID.KeyPress, tbxFName.KeyPress, tbxMName.KeyPress,
    tbxSName.KeyPress, tbxPerson.KeyPress, tbxTotal.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub


End Class
