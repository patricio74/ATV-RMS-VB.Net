Public Class ctrlAdminSettings

    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxFName.KeyPress, tbxMName.KeyPress, tbxSName.KeyPress,
    tbxPhone.KeyPress, tbxRFID.KeyPress, tbxEmail.KeyPress, tbxUsername.KeyPress, tbxPword.KeyPress, tbxPword2.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
End Class
